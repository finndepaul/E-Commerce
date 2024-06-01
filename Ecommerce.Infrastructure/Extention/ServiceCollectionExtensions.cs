using Ecommerce.Application.Interface;
using Ecommerce.Infrastructure.Implement;
using Ecommerce.Infrastructure.Implement.RoleUser;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Infrastructure.Extention
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddEventBus(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IExampleRepository, ExampleRepository>();
            services.AddTransient<IRoleUserRepository, RoleUserRepository>();
            return services;
        }
    }
}