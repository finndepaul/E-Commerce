using Ecommerce.Application.Interface;
using Ecommerce.Infrastructure.Database.AppDbContext;
using Ecommerce.Infrastructure.Implement;
using Ecommerce.Infrastructure.Implement.AddressRepo;
using Ecommerce.Infrastructure.Implement.Product;
using Ecommerce.Infrastructure.Implement.ProductType;
using Ecommerce.Infrastructure.Implement.RoleUserRepo;
using Ecommerce.Infrastructure.Implement.Sale;
using Ecommerce.Infrastructure.Implement.Ulitities;
using Ecommerce.Infrastructure.Implement.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Infrastructure.Extention
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddEventBus(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<WebBanHangContext>(options =>
            {

                // Configure your DbContext options here
                options.UseSqlServer("Data Source=.;Initial Catalog=WebBanHang;Integrated Security=True;Trust Server Certificate=True");
            });
            services.AddTransient<IExampleRepository, ExampleRepository>();
            services.AddTransient<IRoleUserRepository, RoleUserRepository>();
            services.AddTransient<IUtilitiesRespository, UserUlititiesRepository>();
            services.AddTransient<IProductRespository, ProductRespository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IProductTypeRespository, ProductTypeRespository>();
            services.AddTransient<ISalesRespository, SaleRespository>();
            services.AddTransient<IAddressRepository, AddressRepository>();
            return services;
        }
    }
}