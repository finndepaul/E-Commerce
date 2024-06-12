using AutoMapper;
using Ecommerce.Application.DataTransferObj.User.Request;
using Ecommerce.Application.Interface;
using Ecommerce.Domain.Database.Entities;
using Ecommerce.Domain.Enum;
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

                var result = await _userRepository.Register(_mapper.Map<Users>(userCreateRequest), cancellationToken);
                if (result == Domain.Enum.ErrorMessage.Successfull)
                    return Ok("thêm thành công");
                else
                {
                    return Ok("Email hoặc UserName đã tồn tại");
                }
            }
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAllUsers(CancellationToken cancellationToken)
        {
            var users = await _userRepository.GetAllUsers(cancellationToken);
            return Ok(users);
        }

        

        [HttpPut("update-user")]
        public async Task<IActionResult> UpdateUser([FromQuery] UserUpdateRequest request, CancellationToken cancellationToken)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var result = await _userRepository.UpdateUser(request, cancellationToken);
                
                    return Ok(result);
                
            }
            catch (Exception)
            {

                return BadRequest("Update failed.");
            }
            
            
        }

        [HttpDelete("delete-user")]
        public async Task<IActionResult> DeleteUser(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _userRepository.DeleteUser(id, cancellationToken);
                
                    return Ok(result);
                
            }
            catch (Exception)
            {

                return BadRequest("Deletion failed.");
            }
           
           
        }
    }
}
