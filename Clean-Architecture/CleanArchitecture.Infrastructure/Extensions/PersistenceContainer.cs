using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infrastructure.Repositories;
using CleanArchitecture.Domain.Interfaces.LookUp;
using CleanArchitecture.Infrastructure.Repositories.LookUp;

namespace CleanArchitecture.Infrastructure.Extensions
{
    public static class PersistenceContainer
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<UsersDbContext>();
                //options =>
                //options.UseSqlServer(configuration.GetConnectionString("UsersCtring("UsersConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IUserRepository), typeof(UserRepository));
            services.AddScoped(typeof(IAddressRepository), typeof(AddressRepository));
            services.AddScoped(typeof(IGovernorateRepository), typeof(GovernorateRepository));
            services.AddScoped(typeof(ICityRepository), typeof(CityRepository));

            return services;
        }
    }

}
