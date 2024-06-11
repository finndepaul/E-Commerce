using Ecommerce.Application.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminHomeController : ControllerBase
    {
        private readonly IProductRespository _res;

        public AdminHomeController(IProductRespository res)
        {
            _res = res;
        }
        [HttpPost("inspect-product")]
        public async Task<IActionResult> InspectProduct(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var model = await _res.ProductReview(id, cancellationToken);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
