using AutoMapper;
using Ecommerce.Application.DataTransferObj.Oders;
using Ecommerce.Application.Interface;
using Ecommerce.Domain.Database.Entities;
using Ecommerce.Domain.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOderDetailRespository _repo;
        IMapper _mapper;
        public OrderController(IOderDetailRespository repo,IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
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

