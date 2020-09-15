using WebBase.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebBase.Configuration
{
    public static class DbContextConfig
    {
        public static IServiceCollection AddDbContextConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<WebBaseDbContext>(options =>
                options.UseMySql(configuration.GetConnectionString("WebBaseDbContext"), builder =>
                builder.MigrationsAssembly("WebBase")));
            return services;
        }
    }
}