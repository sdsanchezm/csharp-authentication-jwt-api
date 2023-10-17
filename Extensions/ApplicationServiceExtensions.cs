using AuthenticationAPI2.Data;
using AuthenticationAPI2.Interfaces;
using AuthenticationAPI2.Services;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationAPI2.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, 
            IConfiguration config)
        {
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("connString1"));
            });

            services.AddScoped<ITokenService, TokenService>();

            return services;
        }
    }
}
