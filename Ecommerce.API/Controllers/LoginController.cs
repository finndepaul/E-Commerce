using Ecommerce.Application.DataTransferObj.User.Ultilities;
using Ecommerce.Domain.Database.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Ecommerce.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LoginController : ControllerBase
	{
		private readonly IConfiguration _configuration;
        public LoginController(IConfiguration configuration)
		{
			_configuration = configuration;
			
		}
		[HttpPost("login")]
		public async Task<IActionResult> Login(LoginRequest request)
		{
			if (request.IsValid())
			{
				return BadRequest();
			}
			var obj = CreateToken(request);
			return Ok(obj);

		}
		private string CreateToken(LoginRequest request)
		{
			List<Claim> claims = new List<Claim>
			{
				new Claim(ClaimTypes.Name,request.UserName)
			};
			var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration.GetSection("JWT:Token").Value));
			var creds = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);
			var token = new JwtSecurityToken(
				claims: claims,
				expires: DateTime.Now.AddDays(1),
				signingCredentials: creds
				);
			var jwt = new JwtSecurityTokenHandler().WriteToken(token);

			return jwt;

		}
	}
}
