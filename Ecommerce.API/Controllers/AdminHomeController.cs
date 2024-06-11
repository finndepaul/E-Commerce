using Ecommerce.Application.DataTransferObj.Products;
using Ecommerce.Application.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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
        [HttpGet("get-product")]
        public async Task<IActionResult> GetAll([FromQuery] ViewProductRequest product, CancellationToken cancellationToken)
        {
            //var result = await _res.GetAll(new ViewProductRequest()
            //{
            //    NameProduct = product.NameProduct,
            //    PageNumber = product.PageNumber,
            //    PageSize = product.PageSize,
            //    Status = Domain.Enum.ProductStatus.Waiting,
            //}, cancellationToken);
            var result = await _res.GetAll(product, cancellationToken);
            return Ok(result);
        }
        [HttpPost("inspect-product")]
        public async Task<IActionResult> InspectProduct(Guid productId, CancellationToken cancellationToken)
        {
            try
            {
                var model = await _res.ProductReview(productId, cancellationToken);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest("Lỗi");
            }
        }
    }
}
