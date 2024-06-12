
﻿using Ecommerce.Application.DataTransferObj.User;
using Ecommerce.Application.DataTransferObj.User.Ultilities;
using Ecommerce.Domain.Database.Entities;
using Ecommerce.Infrastructure.Database.AppDbContext;
using Ecommerce.Infrastructure.Extention;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Immutable;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly WebBanHangContext _db;
        public LoginController(IConfiguration configuration)
        {
            _configuration = configuration;
            _db = new WebBanHangContext();

        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            // Kiểm tra thông tin đăng nhập từ database hoặc dịch vụ xác thực
            var user = await GetUserFromDatabase(request.UserName, request.Password);
            if (user == null)
                return Unauthorized();

            // Tạo JWT token
            var token = GenerateToken(user);
            return Ok(token);
        }

        private string GenerateToken(LoginDTO user)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
            new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
            new Claim(ClaimTypes.Name, user.Username),
            new Claim(ClaimTypes.Role, user.RoleName)
        };

            var token = new JwtSecurityToken(
                _configuration["JWT:Issuer"],
                _configuration["JWT:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private async Task<LoginDTO> GetUserFromDatabase(string username, string password)
        {
            // Lấy thông tin người dùng từ database hoặc dịch vụ xác thực
            // Ví dụ:
            var obj = await _db.User.FirstOrDefaultAsync(x => x.Username == username && x.Password == Hash.EncryptPassword(password));
            var objRoleUser = await _db.RoleUsers.FirstOrDefaultAsync(x => x.CreatedBy == obj.ID);
            var objRole = await _db.Role.FirstOrDefaultAsync(x => x.ID == objRoleUser.RoleId);
            return new LoginDTO()
            {
                UserId = obj.ID,
                Username = obj.Username,
                RoleName = objRole.RoleName
            };
        }
    }
}
