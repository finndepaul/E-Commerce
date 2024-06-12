using Ecommerce.Application.DataTransferObj.Products;
using Ecommerce.Application.ValueObj.Pagination;

namespace Client.IServices
{
    public interface IAdminService
    {
        Task<PaginationResponse<ProductDTO>> GetAll();
        Task<bool> AcceptionProduct(Guid productID);
    }
}
