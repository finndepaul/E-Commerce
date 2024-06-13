using Ecommerce.Application.DataTransferObj.Carts;
using Ecommerce.Application.DataTransferObj.Products;
using Ecommerce.Application.ValueObj.Pagination;

namespace Client.IServices
{
    public interface ICustomerServices
    {
        Task<PaginationResponse<ProductDTO>> GetAllProduct(ViewProductRequest request);
        Task<ProductDTO> GetProductByID(Guid id);

        // Cart
        Task<PaginationResponse<CartDetailDTO>> GetCart(Guid id);
        Task<bool> AddToCart(CreateCartDetailRequest request);
    }
}
