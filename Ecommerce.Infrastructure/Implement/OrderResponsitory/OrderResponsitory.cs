using AutoMapper;
using Ecommerce.Application.DataTransferObj.Oders;
using Ecommerce.Application.Interface;
using Ecommerce.Domain.Database.Entities;
using Ecommerce.Domain.Enum;
using Ecommerce.Infrastructure.Database.AppDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Implement.OrderResponsitory
{
    public class OrderResponsitory : IOderDetailRespository
    {
        private readonly WebBanHangContext _context;
        private readonly IMapper _mapper;
        public OrderResponsitory(WebBanHangContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ErrorMessage> DeleteBill(Guid billId, CancellationToken cancellationToken)
        {
            var bill = await _context.Bill
           .Include(b => b.BillDetails)
           .FirstOrDefaultAsync(b => b.Id == billId && b.Status == EntityStatus.Active, cancellationToken);

            if (bill == null)
            {
                return ErrorMessage.Faild;
            }

            bill.Status = EntityStatus.Deleted;
            foreach (var billDetail in bill.BillDetails)
            {
                billDetail.Status = EntityStatus.Deleted;
                var product = await _context.Product.FirstOrDefaultAsync(p => p.ID == billDetail.ProductID, cancellationToken);
                if (product != null)
                {
                    product.Quantity += billDetail.NumberOfProduct;
                    _context.Product.Update(product);
                }
            }

            _context.Bill.Update(bill);
            await _context.SaveChangesAsync(cancellationToken);
            return ErrorMessage.Successfull;
        }
    

        public async Task<BillDto> GetBillById(Guid billId, CancellationToken cancellationToken)
        {
            var bill = await _context.Bill
           .Include(b => b.BillDetails)
           .ThenInclude(bd => bd.Products)
           .FirstOrDefaultAsync(b => b.Id == billId && b.Status == EntityStatus.Active, cancellationToken);

            if (bill == null)
            {
                return null;
            }

            var billDto = _mapper.Map<BillDto>(bill);
            return billDto;
        }

        public async Task<bool>   Purchase(PurchaseRequest request, CancellationToken cancellationToken)
        {
            var cartDetails = await _context.CartDetail
            .Include(cd => cd.Products)
            .Where(cd => request.CartDetailIds.Contains(cd.Id) && cd.Status == EntityStatus.Active)
            .ToListAsync(cancellationToken);

            if (cartDetails == null || !cartDetails.Any())
            {
                return false;
            }

            // Tạo hóa đơn
            var bill = new Bills
            {
                Id = Guid.NewGuid(),
                CreatedBy = request.UserId,
                SoldDate = DateTime.Now,
                TotalMoney = cartDetails.Sum(cd => cd.TotalMoney),
                Status = EntityStatus.Active,
            };

            _context.Bill.Add(bill);

            // Tạo chi tiết hóa đơn và cập nhật số lượng sản phẩm
            foreach (var cartDetail in cartDetails)
            {
                var billDetail = new BillDetails
                {
                    ID = Guid.NewGuid(),
                    BillID = bill.Id,
                    ProductID = cartDetail.ProductID,
                    Price = cartDetail.TotalMoney,
                    NumberOfProduct = Convert.ToInt32( cartDetail.NumberOfProduct),
                    Status = EntityStatus.Active,
                };

                _context.BillDetail.Add(billDetail);

                // Cập nhật số lượng sản phẩm
                var product = cartDetail.Products;
                product.Quantity -= Convert.ToInt32( cartDetail.NumberOfProduct);
                _context.Product.Update(product);

                // Đánh dấu chi tiết giỏ hàng là đã mua
                cartDetail.Status = EntityStatus.Deleted;
                _context.CartDetail.Update(cartDetail);
            }

            // Tạo lịch sử thanh toán
            var payHistory = new PayHistories
            {
                Id = Guid.NewGuid(),
                PaymentExpressionID = request.PaymentExpressionID,
                BillID = bill.Id,
                TimePay = DateTime.Now,
                MoneyPayed = bill.TotalMoney,
                Status = EntityStatus.Active
            };

            _context.PayHistory.Add(payHistory);

            // Lưu thay đổi vào cơ sở dữ liệu
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
