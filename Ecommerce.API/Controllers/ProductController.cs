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
        //public async Task<IActionResult> Get([FromBody]ProductDTO product, CancellationToken cancellationToken)
        //{
        //    var result = _reps(product,cancellationToken);
        //}
        [HttpPost("create-product")]
        public async Task<IActionResult> Create([FromBody]ProductCreateRequest product, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _reps.CreateProduct(_mapper.Map<Products>(product),cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("update-product")]
        public async Task<IActionResult> Update()
        {
            return Ok();
        }
    }
}
