using AutoMapper;
using Ecommerce.Application.DataTransferObj.Address;
using Ecommerce.Application.DataTransferObj.Oders;
using Ecommerce.Application.Interface;
using Ecommerce.Domain.Database.Entities;
using Ecommerce.Domain.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOderDetailRespository _repo;
        private readonly IAddressRepository _addressRepository;
        HttpClient _client;
        IMapper _mapper;
        public OrderController(IOderDetailRespository repo,IMapper mapper, IAddressRepository addressRepository)
        {
            _repo = repo;
            _mapper = mapper;
            _client = new HttpClient();
            _addressRepository = addressRepository;
        }

        [HttpGet("district")]
        public async Task<IActionResult> GetDistricts(string id)
        {
            try
            {
                _client.DefaultRequestHeaders.Add("token", "5507f60c-257d-11ef-9f1e-a2db65f73a17");
                string url = $"https://online-gateway.ghn.vn/shiip/public-api/master-data/district?province_id={id}";

                HttpResponseMessage response = await _client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    // Đọc nội dung phản hồi dưới dạng chuỗi JSON
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Trả về dữ liệu phản hồi cho client
                    return Ok(responseBody);
                }
                else
                {
                    return BadRequest("Lấy dữ liệu thất bại");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Lỗi: " + ex.Message);
            }
        }

        [HttpGet("wards")]
        public async Task<IActionResult> GetWards(string id)
        {
            try
            {
                _client.DefaultRequestHeaders.Add("token", "5507f60c-257d-11ef-9f1e-a2db65f73a17");
                string url = $"https://online-gateway.ghn.vn/shiip/public-api/master-data/ward?district_id={id}";

                HttpResponseMessage response = await _client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    // Đọc nội dung phản hồi dưới dạng chuỗi JSON
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Trả về dữ liệu phản hồi cho client
                    return Ok(responseBody);
                }
                else
                {
                    return BadRequest("Lấy dữ liệu thất bại");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Lỗi: " + ex.Message);
            }
        }

        [HttpGet("cities")]
        public async Task<IActionResult> GetCities()
        {
            try
            {
                _client.DefaultRequestHeaders.Add("token", "5507f60c-257d-11ef-9f1e-a2db65f73a17");
                string url = $"https://online-gateway.ghn.vn/shiip/public-api/master-data/province";

                HttpResponseMessage response = await _client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    // Đọc nội dung phản hồi dưới dạng chuỗi JSON
                    string responseBody = await response.Content.ReadAsStringAsync();
                    // Trả về dữ liệu phản hồi cho client
                    return Ok(responseBody);
                }
                else
                {
                    return BadRequest("Lấy dữ liệu thất bại");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Lỗi: " + ex.Message);
            }
        }

        [HttpPost("create-purchase")]
        public async Task<IActionResult> Purchase([FromBody] PurchaseRequest request, CancellationToken cancellationToken)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var result = await _repo.Purchase(request, cancellationToken);

                
                    return Ok(result);
                
            }
            catch (Exception)
            {

                return BadRequest("Mua thất bại");
            }
           

          
        }


        [HttpGet("getorderdetail")]
        public async Task<IActionResult> GetAllOrderDetailsByID(Guid UserID, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repo.GetAllOrdersOfID(UserID, cancellationToken);
                return Ok(result);
                
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            } 
        }

        [HttpGet("fee")]
        public async Task<IActionResult> Getfee([FromQuery]GetFeeRequest request ,CancellationToken cancellationToken)
        {
            try
            {
                var ShopAdress = await _addressRepository.GetById(request.ID_Shop,cancellationToken);

                var CusAddress = await _addressRepository.GetById(request.ID_Cus,cancellationToken);

                _client.DefaultRequestHeaders.Add("token", "5507f60c-257d-11ef-9f1e-a2db65f73a17");
                string urlGetfee = $"https://online-gateway.ghn.vn/shiip/public-api/v2/shipping-order/fee?service_id=53320&insurance_value={request.insurance_value}&to_ward_code={CusAddress.WardCode}&to_district_id={CusAddress.district}&from_district_id={ShopAdress.district}&weight={request.weight}&length={request.length}&width={request.length}&height={request.height}";

                HttpResponseMessage response = await _client.GetAsync(urlGetfee);
                if (response.IsSuccessStatusCode)
                {
                    // Read the response body as a JSON string
                    string responseBody = await response.Content.ReadAsStringAsync();

                    var responseDic = JsonSerializer.Deserialize<Dictionary<string, object>>(responseBody);

                    if (responseDic.TryGetValue("data", out var obj))
                    {
                        var data = JsonSerializer.Deserialize<Dictionary<string, object>>(obj.ToString());
                        var rs = data.TryGetValue("total", out var totalShip);
                        return Ok(totalShip);
                    }
                    return BadRequest("Lấy dữ liệu thất bại");
                }
                else
                {
                    return BadRequest("Lấy dữ liệu thất bại");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Lỗi: " + ex.Message);
            }
        }

        [HttpPost("createorderdetail")]
        public async Task<IActionResult> CreateOrderDetails([FromQuery]OrderDetailCreateRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repo.CreateOrderDetail(_mapper.Map<OrderDetails>(request), cancellationToken);
                return Ok(result);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}

