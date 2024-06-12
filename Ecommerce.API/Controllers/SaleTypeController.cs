//using Ecommerce.Application.DataTransferObj.SaleType;
//using Ecommerce.Application.Interface;
//using Ecommerce.Domain.Enum;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace Ecommerce.API.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class SaleTypeController : ControllerBase
//    {
//        private readonly ISaleTypeResponsitory _repo;
//        public SaleTypeController(ISaleTypeResponsitory repo)
//        {
//                _repo = repo;
//        }

//        [HttpGet("get-by-id")]
//        public async Task<IActionResult> GetSaleTypeById(Guid id, CancellationToken cancellationToken)
//        {
//            var saleType = await _repo.GetSaleTypeById(id, cancellationToken);
//            if (saleType != null)
//            {
//                return Ok(saleType);
//            }
//            return NotFound();
//        }

//        [HttpGet("get-all")]
//        public async Task<IActionResult> GetAllSaleTypes(CancellationToken cancellationToken)
//        {
//            var saleTypes = await _repo.GetAllSaleTypes(cancellationToken);
//            return Ok(saleTypes);
//        }

//        [HttpPost("create-saletype")]
//        public async Task<IActionResult> CreateSaleType([FromQuery] SaleTypeCreateRequest request, CancellationToken cancellationToken)
//        {
            
            
//            try
//            {
//                if (!ModelState.IsValid)
//                {
//                    return BadRequest(ModelState);
//                }

//                var result = await _repo.CreateSaleType(request, cancellationToken);
//                return Ok(result);
//            }
//            catch (Exception)
//            {

//                return BadRequest();
//            }
//        }

//        [HttpPut("update-satetype")]
//        public async Task<IActionResult> UpdateSaleType([FromBody] SaleTypeUpdateRequest request, CancellationToken cancellationToken)
//        {
            
//            try
//            {
//                if (!ModelState.IsValid)
//                {
//                    return BadRequest(ModelState);
//                }

//                var result = await _repo.UpdateSaleType(request, cancellationToken);
//                return Ok(result);
//            }
//            catch (Exception)
//            {

//                return BadRequest();
//            }
            
//        }

//        [HttpDelete("delete-Saletype")]
//        public async Task<IActionResult> DeleteSaleType(Guid id, CancellationToken cancellationToken)
//        {
            
            
           
            
//                var result = await _repo.DeleteSaleType(id, cancellationToken);
//            return Ok(result);
           
//        }
//    }
//}
