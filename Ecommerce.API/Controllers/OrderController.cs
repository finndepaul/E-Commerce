using Ecommerce.Application.DataTransferObj.Oders;
using Ecommerce.Application.Interface;
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
        public OrderController(IOderDetailRespository repo)
        {
                _repo = repo;
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

        [HttpGet("get-by-id")]
        public async Task<IActionResult> GetBillById(Guid billId, CancellationToken cancellationToken)
        {
            try
            {
                var bill = await _repo.GetBillById(billId, cancellationToken);
               
                    return Ok(bill);
                
            }
            catch (Exception)
            {

                return BadRequest();
            }
           

            

           
        }

        [HttpDelete("delete-bill")]
        public async Task<IActionResult> DeleteBill(Guid billId, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repo.DeleteBill(billId, cancellationToken);

                
                    return Ok(result);
                
            }
            catch (Exception)
            {

                return BadRequest("Failed to delete the bill.");
            }
           

            
        }
    }
}

