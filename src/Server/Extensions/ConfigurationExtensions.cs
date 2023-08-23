using Microsoft.EntityFrameworkCore;
using Server.Data;
using Server.Repositories.Interface;
using Server.Repositories.Services;

namespace Server.Extensions
{
    public static class ConfigurationExtensions
    {
        public static IServiceCollection GetDefaultConnectionString(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("PropertiesForSaleConnectionString");

            services.AddDbContext<ApplicationDbContext>(options
                => options.UseSqlServer(connectionString));

            return services;
        }

        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IPropertyRepository, PropertyRepository>();

            return services;
        }
    }
}
