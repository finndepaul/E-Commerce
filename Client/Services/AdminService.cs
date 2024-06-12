using Client.IServices;
using Ecommerce.Application.DataTransferObj.Products;
using Ecommerce.Application.ValueObj.Pagination;

namespace Client.Services
{
    public class AdminService : IAdminService
    {
        private readonly HttpClient _http; // đần vl
        public AdminService()
        {
            _http = new();
        }

        public async Task<PaginationResponse<ProductDTO>> GetAll()
        {
            var result = await _http.GetFromJsonAsync<PaginationResponse<ProductDTO>>("https://localhost:7140/api/AdminHome/get-product");
            return result;
        }
        public async Task<bool> AcceptionProduct(Guid productID)
        {
            var result = await _http.DeleteAsync($"https://localhost:7140/api/AdminHome/inspect-product?productId={productID}");
            return result.IsSuccessStatusCode;
        }
    }
}
