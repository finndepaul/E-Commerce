using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BaseSolution.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddEventBus(this IServiceCollection services, IConfiguration configuration)
        {
   //         services.AddDbContextPool<AppReadOnlyDbContext>(options =>
   //         {
   //             // Configure your DbContext options here
   //             options.UseSqlServer(configuration.GetConnectionString("DbConnection"));
   //         });

   //         services.AddDbContextPool<AppReadWriteDbContext>(options =>
   //         {
   //             // Configure your DbContext options here
   //             options.UseSqlServer(configuration.GetConnectionString("DbConnection"));
   //         });
			//services.AddDbContextPool<ExampleReadOnlyDbContext>(options =>
			//{
			//	// Configure your DbContext options here
			//	options.UseSqlServer(configuration.GetConnectionString("DbConnection"));
			//});

			//services.AddDbContextPool<ExampleReadWriteDbContext>(options =>
			//{
			//	// Configure your DbContext options here
			//	options.UseSqlServer(configuration.GetConnectionString("DbConnection"));
			//});

			//services.AddTransient<ILocalizationService, LocalizationService>();
			return services;
        }
    }
}