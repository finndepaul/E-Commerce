using AutoMapper;
using Ecommerce.Application.DataTransferObj.Address;
using Ecommerce.Application.Interface;
using Ecommerce.Domain.Database.Entities;
using Ecommerce.Infrastructure.Implement.AddressRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressRepository _repo;
        IMapper _mapper;
        public AddressController(IAddressRepository repo,IMapper mapper)
        {
            _mapper = mapper;   
            _repo = repo;
        }

        [HttpGet("getalladdressbyid")]
        public async Task<IActionResult> GetAllAddressByID(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var lst = await _repo.GetAllAdressByID(id,cancellationToken);
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return BadRequest("Lỗi: " + ex.Message);
            }
        }

        [HttpGet("getaddressbyid")]
        public async Task<IActionResult> GetAddressByID(Guid id,CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _repo.GetById(id,cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest("Lỗi: " + ex.Message);
            }
        }

        [HttpPost("createaddress")]
        public async Task<IActionResult> CreateAddress([FromQuery]AddressCreateRequest request,CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repo.AddressCreate(_mapper.Map<Address>(request),cancellationToken); 
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest("Lỗi: " + ex.Message);
            }
        }

        [HttpPost("deleteaddress")]
        public async Task<IActionResult> DeleteAddress(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repo.Delete(id, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest("Lỗi: " + ex.Message);
            }
        }
    }
}
