using blinkCore.Contracts.Entities;
using blinkCore.Contracts.Repository;
using blinkRepository.Repositories;
using blinkServices;
using Microsoft.Extensions.DependencyInjection;

namespace blinkCat_DependecyInjection
{
    public class DependencyInjectionExtension
    {
        public static void AddServicesDependency(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
        }
        public static void AddRepositoriesDependency(IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}