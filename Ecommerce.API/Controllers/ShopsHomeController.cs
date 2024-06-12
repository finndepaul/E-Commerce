using Ecommerce.Application.DataTransferObj.Products;
using Ecommerce.Application.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopsHomeController : ControllerBase
    {
        private readonly IProductRespository _res;

        public ShopsHomeController(IProductRespository res)
        {
            _res = res;
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] Guid idShop,[FromQuery] ViewProductRequest product, CancellationToken cancellationToken)
        {
            var obj = await _res.GetAll(new ViewProductRequest()
            {
                NameProduct = product.NameProduct,
                PageNumber = product.PageNumber,
                PageSize = product.PageSize,
                Status = product.Status,
            }, cancellationToken);
            var result = obj.Data.Where(x=>x.ShopId == idShop).SkipWhile(x => x.Status == Domain.Enum.ProductStatus.Waiting);
            
            return Ok(result);
        }
    }
}
