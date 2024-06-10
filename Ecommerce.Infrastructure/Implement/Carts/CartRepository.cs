using AutoMapper;
using Ecommerce.Application.DataTransferObj.Carts;
using Ecommerce.Application.DataTransferObj.Products;
using Ecommerce.Application.Interface;
using Ecommerce.Application.ValueObj.Pagination;
using Ecommerce.Domain.Database.Entities;
using Ecommerce.Domain.Enum;
using Ecommerce.Infrastructure.Database.AppDbContext;
using Ecommerce.Infrastructure.Extention;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Implement.Carts
{
    public class CartRepository : ICartRepository
    {
        private readonly WebBanHangContext _context;
        private readonly IMapper _map;
        public CartRepository(WebBanHangContext context, IMapper map)
        {
            _context = context;
            _map = map;
        }

        public async Task<bool> AddToCart(CreateCartDetailRequest request, Guid userId, CancellationToken cancellationToken)
        {
            var cart = await _context.Cart
             .Include(c => c.CartDetails)
             .FirstOrDefaultAsync(c => c.Id == userId && c.Status == EntityStatus.Active, cancellationToken);

            if (cart == null)
                return false;

            var product = await _context.Product.FirstOrDefaultAsync(p => p.ID == request.ProductID, cancellationToken);

            if (product == null)
                return false;

            var existingCartDetail = cart.CartDetails.FirstOrDefault(cd => cd.ProductID == request.ProductID && cd.Status == EntityStatus.Active);

            if (existingCartDetail != null)
            {
                var newTotalQuantity = existingCartDetail.NumberOfProduct + request.NumberOfProduct;
                if (newTotalQuantity > product.Quantity)
                    return false;

                existingCartDetail.NumberOfProduct = newTotalQuantity;
                existingCartDetail.TotalMoney = product.Price * newTotalQuantity;

                cart.TotalMoney += product.Price * request.NumberOfProduct;

                _context.CartDetail.Update(existingCartDetail);
            }
            else
            {
                if (request.NumberOfProduct > product.Quantity)
                    return false;

                var cartDetail = new CartDetails
                {
                    Id = Guid.NewGuid(),
                    CartID = cart.Id,
                    ProductID = request.ProductID,
                    NumberOfProduct = request.NumberOfProduct,
                    TotalMoney = product.Price * request.NumberOfProduct,
                    Status = EntityStatus.Active
                };

                cart.TotalMoney += cartDetail.TotalMoney;

                _context.CartDetail.Add(cartDetail);
            }

            _context.Cart.Update(cart);
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }


        // Phương thức để lấy tất cả các chi tiết giỏ hàng của người dùng
        public async Task<PaginationResponse<CartDetailDTO>> GetAllCartDetails(ViewCartDetailRequest request, CancellationToken cancellationToken)
        {
            var query = _context.CartDetail
                .Include(cd => cd.Products)
                .AsNoTracking();

            if (request.CartID.HasValue)
            {
                query = query.Where(cd => cd.CartID == request.CartID.Value);
            }

            var result = await query.PaginateAsync<CartDetails, CartDetailDTO>(request, _map, cancellationToken);

            return new PaginationResponse<CartDetailDTO>
            {
                HasNext = result.HasNext,
                PageNumber = result.PageNumber,
                PageSize = result.PageSize,
                Data = result.Data
            };
        }

        public async Task<CartDetailDTO> GetCartDetailById(Guid cartDetailId, CancellationToken cancellationToken)
        {
            var cartDetail = await _context.CartDetail
            .Include(cd => cd.Products)
            .AsNoTracking()
            .FirstOrDefaultAsync(cd => cd.Id == cartDetailId && cd.Status == EntityStatus.Active, cancellationToken);

            if (cartDetail == null)
            {
                return null;
            }

            var cartDetailDto = _map.Map<CartDetailDTO>(cartDetail);
            return cartDetailDto;
        }

        public async Task<bool> RemoveFromCart(DeleteCartDetailRequest request, Guid userId, CancellationToken cancellationToken)
        {
            var cartDetail = await _context.CartDetail
            .Include(cd => cd.Carts)
            .FirstOrDefaultAsync(cd => cd.Id == request.CartDetailId && cd.Status == EntityStatus.Active, cancellationToken);

            if (cartDetail == null || cartDetail.Carts == null || cartDetail.Carts.Id != userId)
                return false;

            var cart = cartDetail.Carts;
            cart.TotalMoney -= cartDetail.TotalMoney;
            cartDetail.Status = EntityStatus.Deleted;

            _context.CartDetail.Update(cartDetail);
            _context.Cart.Update(cart);

            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<bool> UpdateCartDetail(UpdateCartRequest request, Guid userId, CancellationToken cancellationToken)
        {
            var cartDetail = await _context.CartDetail
            .Include(cd => cd.Carts)
            .FirstOrDefaultAsync(cd => cd.Id == request.CartDetailId && cd.Status == EntityStatus.Active, cancellationToken);

            if (cartDetail == null || cartDetail.Carts == null || cartDetail.Carts.Id != userId)
                return false;

            var product = await _context.Product.FirstOrDefaultAsync(p => p.ID == cartDetail.ProductID, cancellationToken);

            if (product == null)
                return false;

            var oldTotalMoney = cartDetail.TotalMoney;

            cartDetail.NumberOfProduct = request.NumberOfProduct;
            cartDetail.TotalMoney = product.Price * request.NumberOfProduct;

            var cart = cartDetail.Carts;
            cart.TotalMoney = cart.TotalMoney - oldTotalMoney + cartDetail.TotalMoney;

            _context.CartDetail.Update(cartDetail);
            _context.Cart.Update(cart);

            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
