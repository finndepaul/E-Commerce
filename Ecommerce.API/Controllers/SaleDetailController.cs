using AutoMapper;
using Ecommerce.Application.DataTransferObj.SaleDetail;
using Ecommerce.Application.Interface;
using Ecommerce.Domain.Database.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleDetailController : ControllerBase
    {
        private readonly ISaleDetailRespository _reps;
        private readonly IMapper _mapper;

        public SaleDetailController(ISaleDetailRespository reps, IMapper mapper)
        {
            _reps = reps;
            _mapper = mapper;
        }
        [HttpGet("sale-detail")]
        public async Task<IActionResult> Index([FromQuery]Guid id,CancellationToken cancellationToken)
        {
            try
            {
                var result = await _reps.GetSaleDetail(id,cancellationToken);
                return Ok(result);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("create-saledetail")]
        public async Task<IActionResult> Create([FromBody]SaleDetailCreateResquest resquest,CancellationToken cancellationToken)
        {
            try
            {
                var result = await _reps.Create(_mapper.Map<SaleDetails>(resquest),cancellationToken);
                return Ok(result);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("update-saledetail")]
        public async Task<IActionResult> Update([FromBody] SaleDetailUpdateResquest resquest, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _reps.Update(_mapper.Map<SaleDetails>(resquest), cancellationToken);
                return Ok(result);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("delete-saledetail")]
        public async Task<IActionResult> Delete([FromBody] SaleDetailDeleteResquest resquest, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _reps.Delete(_mapper.Map<SaleDetails>(resquest), cancellationToken);
                return Ok(result);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
