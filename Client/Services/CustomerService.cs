using Client.IServices;
using Ecommerce.Application.DataTransferObj.Products;
using Ecommerce.Application.ValueObj.Pagination;
using Ecommerce.Domain.Enum;

namespace Client.Services
{
    public class CustomerService : ICustomerServices
    {
        private readonly HttpClient _httpClient;
        public CustomerService()
        {
            _httpClient = new HttpClient();
        }
        public async Task<PaginationResponse<ProductDTO>> GetAllProduct(ViewProductRequest request)
        {
            var rs = await _httpClient.GetFromJsonAsync<PaginationResponse<ProductDTO>>($"https://localhost:7140/api/Product/getall-product?NameProduct={request.NameProduct}&Status=1&PageNumber={request.PageNumber}&PageSize=16");
            return rs;
        }

        public async Task<ProductDTO> GetProductByID(Guid id)
        {
            var rs = await _httpClient.GetFromJsonAsync<PaginationResponse<ProductDTO>>($"https://localhost:7140/api/Product/getall-product?Status=1&PageNumber=1&PageSize=1000");
            var obj = rs.Data.FirstOrDefault(x => x.ID == id);
            return obj;
        }
    }
}
