﻿using AutoMapper;
using Ecommerce.Application.DataTransferObj.RoleUser;
using Ecommerce.Application.Interface;
using Ecommerce.Domain.Database.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        private readonly IRoleUserRepository _repo;
        private readonly IMapper _map;
        public AuthorizationController(IRoleUserRepository repo,IMapper map)
        {
            _repo = repo;
            _map = map;
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]ViewRoleUserRequest request,CancellationToken cancellationToken)
        {
            var result = await _repo.GetAll(request, cancellationToken);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]RoleUserCreateRequest request, CancellationToken cancellationToken)
        {
            var result = await _repo.Create(_map.Map<RoleUser>(request), cancellationToken);
            return Ok(result);
        }
    }
}
