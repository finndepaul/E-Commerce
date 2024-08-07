﻿using Ecommerce.Application.DataTransferObj.Carts;
using Ecommerce.Application.DataTransferObj.Oders;
using Ecommerce.Application.DataTransferObj.Products;
using Ecommerce.Application.ValueObj.Pagination;

namespace Client.IServices
{
    public interface ICustomerServices
    {
        Task<PaginationResponse<ProductDTO>> GetAllProduct(ViewProductRequest request);
        Task<ProductDTO> GetProductByID(Guid id);
        Task<List<OrderDetailDto>> GetOrderDetailAll(Guid id);
        Task<OrderDetailDto> GetOrderDetailById(Guid id,Guid USer);
        Task<bool> CreateBill(OrderDetailCreateRequest request);
        Task<bool> DeleteCartDetail(Guid id,Guid user);

        // Cart
        Task<PaginationResponse<CartDetailDTO>> GetCart(Guid id);
        Task<bool> AddToCart(CreateCartDetailRequest request);
    }
}
