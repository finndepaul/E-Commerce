using Client.IServices;
using Ecommerce.Application.DataTransferObj.Carts;
using Ecommerce.Application.DataTransferObj.Products;
using Ecommerce.Application.ValueObj.Pagination;
using Ecommerce.Domain.Enum;
using static System.Net.WebRequestMethods;

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

        // Cart
        public async Task<PaginationResponse<CartDetailDTO>> GetCart(Guid id)
        {
            var result = await _httpClient.GetFromJsonAsync<PaginationResponse<CartDetailDTO>>($"https://localhost:7140/api/Cart/get-all?CartID={id}");
            return result;
        }

        public async Task<bool> AddToCart(CreateCartDetailRequest request)
        {
            var result = await _httpClient.PostAsJsonAsync("https://localhost:7140/api/Cart/create-cartdetails", request);
            return result.IsSuccessStatusCode;
        }
    }
}
