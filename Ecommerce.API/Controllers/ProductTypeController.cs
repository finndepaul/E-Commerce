using AutoMapper;
using Ecommerce.Application.DataTransferObj.ProductType;
using Ecommerce.Application.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Domain.Database.Entities;
namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypeController : ControllerBase
    {
        private readonly IProductTypeRespository _reps;
        private readonly IMapper _maper;

        public ProductTypeController(IProductTypeRespository reps, IMapper maper)
        {
            _reps = reps;
            _maper = maper;
        }
        [HttpGet("getall-productType")]
        public async Task<IActionResult> Get([FromQuery]ViewProductTypeRequest request, CancellationToken cancellationToken)
        {
      
                var result = await _reps.GetAll(request, cancellationToken);
                return Ok(result);
        
        }
        [HttpPost("create-productType")]
        public async Task<IActionResult> CreateProductType([FromBody]ProductTypeCreateRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _reps.CreateProduct(_maper.Map<ProductTypes>(request), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("update-ProductType")]
        public async Task<IActionResult> UpdateProductType([FromBody]ProductTypeUpdateRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _reps.UpdateProduct(_maper.Map<ProductTypes>(request), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("delete-ProductType")]
        public async Task<IActionResult> DeleteProductType([FromBody]ProductTypeDeleteRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _reps.DeleteProduct(_maper.Map<ProductTypes>(request), cancellationToken);
                return Ok(result);
            }
            catch
            {
                return BadRequest();
            }
        }

    }
}
