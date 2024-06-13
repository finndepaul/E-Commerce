using Client.IServices;
using Ecommerce.Application.DataTransferObj.Oders;
using Ecommerce.Application.DataTransferObj.Carts;
using Ecommerce.Application.DataTransferObj.Products;
using Ecommerce.Application.ValueObj.Pagination;
using Ecommerce.Domain.Database.Entities;
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

        public async Task<List<OrderDetailDto>> GetOrderDetailAll(Guid id)
        {
            var rs = await _httpClient.GetFromJsonAsync<List<OrderDetailDto>>($"https://localhost:7140/api/Order/getorderdetail?UserID={id}");
            return rs;
        }

        public async Task<OrderDetailDto> GetOrderDetailById(Guid id,Guid User)
        {
            var rs = await _httpClient.GetFromJsonAsync<List<OrderDetailDto>>($"https://localhost:7140/api/Order/getorderdetail?UserID={User}");
            var obj = rs.FirstOrDefault(x => x.Id == id);
            return obj;
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

        public async Task<bool> CreateBill(OrderDetailCreateRequest request)
        {
            var rs = await _httpClient.PostAsJsonAsync($"https://localhost:7140/api/Order/createorderdetail?ProductID={request.ProductID}&CreatedBy={request.CreatedBy}&Shipfee=20000&Price={request.Price}&NumberOfProduct={request.NumberOfProduct}",request);
            return rs.IsSuccessStatusCode;
        }

        public Task<bool> DeleteCartDetail(Guid id ,Guid User)
        {
            var rs = _httpClient.GetFromJsonAsync<bool>($"https://localhost:7140/api/Cart/remove-cart?CartDetailId={id}&UserID={User}");
            return rs;
        }
    }
}
