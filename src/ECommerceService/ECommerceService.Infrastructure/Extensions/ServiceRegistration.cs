using ECommerceService.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerceService.Infrastructure.Extensions
{
    public static class ServiceRegistration
    {

        public static IServiceCollection AddInfrastructureRegistration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ECommerceDbContext>(conf =>
            {
                string connStr = configuration["ECommerceConnectionstring"].ToString();

                conf.UseNpgsql(connStr, opt =>
                {
                    opt.EnableRetryOnFailure();
                });
            });

           

            return services;
        }
    
}
}
