using AutoMapper;
using Ecommerce.Application.DataTransferObj.FeedBack;
using Ecommerce.Application.Interface;
using Ecommerce.Domain.Database.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedBackController : ControllerBase
    {
        private readonly IFeedBackRepository _repo;
        private readonly IMapper _map;

        public FeedBackController(IFeedBackRepository repo, IMapper map)
        {
            _repo = repo;
            _map = map;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]ViewFeedBackRequest request ,CancellationToken cancellationToken)
        {
            var result = await _repo.GetAll(request, cancellationToken);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Post(FeedBackCreateRequest request, CancellationToken cancellationToken)
        {
            var result = await _repo.Create(_map.Map<Feedbacks>(request), cancellationToken);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> Put(FeedBackUpdateRequest request, CancellationToken cancellationToken)
        {
            var result = await _repo.Update(_map.Map<Feedbacks>(request), cancellationToken);
            return Ok(result);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(FeedBackDeleteRequest request,CancellationToken cancellationToken)
        {
            var result = await _repo.Delete(_map.Map<Feedbacks>(request), cancellationToken);
            return Ok(result);
        }
        
    }
}
