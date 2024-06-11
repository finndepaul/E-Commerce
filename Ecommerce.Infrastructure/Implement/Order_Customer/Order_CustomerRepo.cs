using AutoMapper;
using AutoMapper.QueryableExtensions;
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
    public class Order_CustomerRepo : IOderDetailRespository
    {
        private readonly WebBanHangContext _context;
        private readonly IMapper _mapper;
        public Order_CustomerRepo(WebBanHangContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CancelOrderDetail(Guid idOrderdetail, CancellationToken cancellationToken)
        {
            var Orderdetail = await _context.OrderDetail.FindAsync(idOrderdetail,cancellationToken);
            Orderdetail.Status = OrderStatus.cancle;
            _context.OrderDetail.Update(Orderdetail);

           if(Orderdetail != null)
            {
                var product = await _context.Product.FindAsync(Orderdetail.ProductID, cancellationToken);
                product.Quantity += Orderdetail.NumberOfProduct;
                _context.Product.Update(product);
            }

            _context.SaveChanges();
            return true;
        }

        public async Task<bool> CreateOrderDetail(OrderDetails request, CancellationToken cancellationToken)
        {
            try
            {
                request.ID = Guid.NewGuid();
                request.CreatedTime = DateTime.Now;
                var result = await _context.OrderDetail.AddAsync(request,cancellationToken);

                var product = await _context.Product.FindAsync(request.ProductID,cancellationToken);
                product.Quantity -= request.NumberOfProduct;
                _context.Product.Update(product);

                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<OrderDetailDto>> GetAllOrdersOfID(Guid ID, CancellationToken cancellationToken)
        {
            var OrderDetails = await _context.OrderDetail.Where(x => x.CreatedBy == ID).ProjectTo<OrderDetailDto>(_mapper.ConfigurationProvider).ToListAsync();
            return OrderDetails;
        }


        public async Task<bool> Purchase(PurchaseRequest request, CancellationToken cancellationToken)
        {
            var cartDetails = await _context.CartDetail
            .Include(cd => cd.Products)
            .Where(cd => cd.Status == EntityStatus.Active)
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
