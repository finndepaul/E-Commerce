using Ecommerce.Application.DataTransferObj.User.Ultilities;
using Ecommerce.Application.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UltilitiesController : ControllerBase
    {
        IUtilitiesRespository _repo;
        public UltilitiesController(IUtilitiesRespository repo)
        {
            _repo = repo;
        }

        [HttpPost("seedgmail")]
        public async Task<IActionResult> SeedMail(SeedMailRequest request)
        {
            try
            {
                var obj = await _repo.SeedGmail(request);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest("Faild: " + $"{ex.Message}");
            }
        }

        [HttpPut("forgotpassword")]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordRequest request,CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _repo.ForgotPassword(request,cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest("Faild: " + $"{ex.Message}");
            }
        }

        [HttpPut("changepassword")]
        public async Task<IActionResult> ChangePassword(ChangePasswordRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _repo.ChangePassword(request, cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest("Faild: " + $"{ex.Message}");
            }
        }
    }
}
