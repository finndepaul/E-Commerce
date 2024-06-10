using Ecommerce.Application.Interface;
using Ecommerce.Infrastructure.Database.AppDbContext;
using Ecommerce.Infrastructure.Extention;
using Ecommerce.Infrastructure.Extention.AutoMapperProfile;
using Ecommerce.Infrastructure.Implement.Carts;
using Ecommerce.Infrastructure.Implement.OrderResponsitory;
using Ecommerce.Infrastructure.Implement.Product;
using Ecommerce.Infrastructure.Implement.ProductType;
using Ecommerce.Infrastructure.Implement.Ulitities;
using Ecommerce.Infrastructure.Implement.User;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.IdentityModel.Tokens;
using System.Configuration;
using System.Text;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["JWT:Issuer"],
            ValidAudience = builder.Configuration["JWT:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]))
        };
    });
// Kích hoạt Swagger để tài liệu API
builder.Services.AddEndpointsApiExplorer();
// Đăng ký dịch vụ giỏ hàng
builder.Services.AddTransient<ICartRepository, CartRepository>();
builder.Services.AddTransient<IOderDetailRespository,OrderResponsitory >();
builder.Services.AddAuthorization();
builder.Services.AddAutoMapper(typeof(CartProfile));
builder.Services.AddApplication(); //use automapper
builder.Services.AddEventBus(builder.Configuration); //use automapper
builder.Services.AddCors(options =>////
{
    options.AddPolicy("AllowLocalhost",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors("AllowLocalhost");
app.MapControllers();

app.Run();