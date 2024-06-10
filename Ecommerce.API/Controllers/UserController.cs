using AutoMapper;
using Ecommerce.Application.DataTransferObj.User.Request;
using Ecommerce.Application.Interface;
using Ecommerce.Domain.Database.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        [HttpPost("register-user")]
        public async Task<IActionResult> Register(UserCreateRequest userCreateRequest, CancellationToken cancellationToken)
        {
            if (userCreateRequest == null)
            {
                return BadRequest("that's null in model request brother !");
            }
            else
            {

               var result=   await _userRepository.Register(_mapper.Map<Users>(userCreateRequest), cancellationToken);
                if(result == Domain.Enum.ErrorMessage.Successfull)
                return Ok("thêm thành công");
                else
                {
                    return Ok("Email hoặc UserName đã tồn tại");
                }
            }
        }
    }
}
