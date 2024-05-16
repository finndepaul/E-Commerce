using Ecommerce.Application.Interface;
using Ecommerce.Infrastructure.Implement;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BaseSolution.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddEventBus(this IServiceCollection services, IConfiguration configuration)
        {
			services.AddTransient<IExampleRepository, ExampleRepository>();
			return services;
        }
    }
}