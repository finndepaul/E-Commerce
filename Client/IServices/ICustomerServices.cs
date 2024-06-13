using Ecommerce.Application.DataTransferObj.Products;
using Ecommerce.Application.ValueObj.Pagination;

namespace Client.IServices
{
    public interface ICustomerServices
    {
        Task<PaginationResponse<ProductDTO>> GetAllProduct(ViewProductRequest request);
        Task<ProductDTO> GetProductByID(Guid id);
    }
}
