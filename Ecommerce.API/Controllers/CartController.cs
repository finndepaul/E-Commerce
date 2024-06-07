using AutoMapper;
using Ecommerce.Application.DataTransferObj.Carts;
using Ecommerce.Application.Interface;
using Ecommerce.Domain.Enum;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartRepository _repo;
        private readonly IMapper _mapper;
        public CartController(ICartRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }
        // Endpoint để lấy tất cả các chi tiết giỏ hàng với phân trang
        [HttpGet("get-all")]
        public async Task<IActionResult> GetAllCartDetails([FromQuery] ViewCartDetailRequest request, CancellationToken cancellationToken)
        {
            var cartDetails = await _repo.GetAllCartDetails(request, cancellationToken);

            if (cartDetails.Data != null && cartDetails.Data.Count > 0)
                return Ok(cartDetails);

            return NotFound();
        }

        [HttpGet("details-cartdetails")]
        public async Task<IActionResult> GetCartDetailById(Guid cartDetailId, CancellationToken cancellationToken)
        {
            var cartDetail = await _repo.GetCartDetailById(cartDetailId, cancellationToken);

            if (cartDetail != null)
            {
                return Ok(cartDetail);
            }

            return NotFound();
        }
        // Endpoint để thêm sản phẩm vào giỏ hàng
        // Endpoint để thêm chi tiết giỏ hàng
        [HttpPost("create-cartdetails")]
        public async Task<IActionResult> CreateCartDetail([FromBody] CreateCartDetailRequest request, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userId = GetUserIdFromContext(); // Triển khai phương thức này để lấy ID người dùng từ ngữ cảnh
            var result = await _repo.AddToCart(request, userId, cancellationToken);

            if (result == ErrorMessage.Successfull)
                return Ok();

            if (result == ErrorMessage.QuantityExceedsStock)
                return BadRequest("Số lượng không thỏa mãn");

            return BadRequest();
        }

        // Endpoint để cập nhật số lượng của sản phẩm trong giỏ hàng
        [HttpPut("update-tocart")]
        // Endpoint để cập nhật chi tiết giỏ hàng
       
        public async Task<IActionResult> UpdateCartDetail([FromBody] UpdateCartRequest request, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userId = GetUserIdFromContext();
            var result = await _repo.UpdateCartDetail(request, userId, cancellationToken);

            if (result == ErrorMessage.Successfull)
                return Ok();

            return BadRequest();
        }

        // Endpoint để xóa sản phẩm khỏi giỏ hàng
        [HttpDelete("remove-cart")]
        public async Task<IActionResult> DeleteCartDetail([FromBody] DeleteCartDetailRequest request, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userId = GetUserIdFromContext();
            var result = await _repo.RemoveFromCart(request, userId, cancellationToken);

            if (result == ErrorMessage.Successfull)
                return Ok();

            return BadRequest();
        }

        // Endpoint để lấy chi tiết giỏ hàng của người dùng
        //[HttpGet("details-cart")]
        //public async Task<IActionResult> GetCartDetails(CancellationToken cancellationToken)
        //{
        //    var userId = GetUserIdFromContext();
        //    var cartDetails = await _repo.GetCartDetails(userId, cancellationToken);

        //    if (cartDetails != null)
        //        return Ok(cartDetails);

        //    return NotFound();
        //}

        private Guid GetUserIdFromContext()
        {
            // Triển khai phương thức của bạn để lấy ID người dùng từ ngữ cảnh
            return Guid.NewGuid();
        }
    }
}
