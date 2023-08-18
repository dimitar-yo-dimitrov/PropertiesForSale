using Microsoft.EntityFrameworkCore;
using Server.Data;

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
    }
}
