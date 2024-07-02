using HealthMate.DAL.Abstractions;
using HealthMate.DAL.DbContexts;
using HealthMate.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HealthMate.DAL.DI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DbConnectionString"));
            });

            services.AddScoped<IActivityTypeRepository, ActivityTypeRepository>();
            services.AddScoped<IGenderRepository, GenderRepository>();
            services.AddScoped<IHealthRepository, HealthRepository>();
            services.AddScoped<IMedicationRepository, MedicationRepository>();
            services.AddScoped<IMoodRepository, MoodRepository>();
            services.AddScoped<INutritionRepository, NutritionRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
