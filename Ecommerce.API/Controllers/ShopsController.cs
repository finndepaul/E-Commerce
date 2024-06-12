using AutoMapper;
using Ecommerce.Application.DataTransferObj.Shops;
using Ecommerce.Application.Interface;
using Ecommerce.Domain.Database.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopsController : ControllerBase
    {
        private readonly IShopsRepository _repo;
        private readonly IMapper _map;

        public ShopsController(IShopsRepository shopsRepository, IMapper map)
        {
            _repo = shopsRepository;
            _map = map;
        }
        [HttpPost]
        public async Task<IActionResult> Post(ShopsCreateRequest request,CancellationToken cancellationToken)
        {
            var result = await _repo.Create(_map.Map<Shops>(request), cancellationToken);
            return Ok(result);
        } 
        [HttpPut]
        public async Task<IActionResult> Put(ShopsUpdateRequest request,CancellationToken cancellationToken)
        {
            var result = await _repo.Update(_map.Map<Shops>(request), cancellationToken);
            return Ok(result);
        } 
        [HttpDelete]
        public async Task<IActionResult> Delete(ShopsDeleteRequest request,CancellationToken cancellationToken)
        {
            var result = await _repo.Delete(_map.Map<Shops>(request), cancellationToken);
            return Ok(result);
        }
    }
}
