using AutoMapper;
using Ecommerce.Application.DataTransferObj.Products;
using Ecommerce.Application.Interface;
using Ecommerce.Domain.Database.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRespository _reps;
        private readonly IMapper _mapper;
        public ProductController(IProductRespository reps, IMapper mapper)
        {
            _reps = reps;
            _mapper = mapper;
        }
        [HttpGet("getall-product")]
        public async Task<IActionResult> Get([FromQuery] ViewProductRequest product, CancellationToken cancellationToken)
        {
            var result = await _reps.GetAll(product, cancellationToken);
            return Ok(result);
        }
        [HttpPost("create-product")]
        public async Task<IActionResult> Create([FromBody]ProductCreateRequest product, CancellationToken cancellationToken)
        {
            try
            {
                var result  = await _reps.CreateProduct(_mapper.Map<Products>(product),cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("update-product")]
        public async Task<IActionResult> Update([FromBody]ProductUpdateRequest product, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _reps.UpdateProduct(_mapper.Map<Products>(product), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex) 
            { 
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody]ProductDeleteRequest product, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _reps.DeleteProduct(_mapper.Map<Products>(product), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); 
            }
        }

    }
}
