using Fintranet.MVP.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Fintranet.MVP.Infrastracture.Repositories
{
    public static class EFServiceCollections
    {
        public static IServiceCollection AddEfConfiguraion(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FintranetSampleDbContext>(options =>
            {
                options.UseInMemoryDatabase("data source=.;initial catalog=fintranet;TrustServerCertificate=True;user id=sa;password=mhm3623");
            });

            services.AddScoped(typeof(IDbRepository<>), typeof(DbRepository<>));

            return services;
        }
    }
}
