using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Services;
using HealthMate.DAL.DI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HealthMate.BLL.DI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDataAccessServices(configuration);

            services.AddScoped<IMoodService, MoodService>();
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
