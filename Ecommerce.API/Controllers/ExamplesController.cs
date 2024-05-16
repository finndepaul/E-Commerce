using AutoMapper;
using Ecommerce.Application.DataTransferObj.Example;
using Ecommerce.Application.Interface;
using Ecommerce.Domain.Database.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamplesController : ControllerBase
    {
        private readonly IExampleRepository _repo;
        private readonly IMapper _map;

        public ExamplesController(IExampleRepository repo, IMapper map)
        {
            _repo = repo;
            _map = map;
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]ExampleCreateRequest request,CancellationToken cancellationToken)
        {
            var result = await _repo.Create(_map.Map<Example>(request), cancellationToken);
            return Ok(result);
        }
    
    }
}
