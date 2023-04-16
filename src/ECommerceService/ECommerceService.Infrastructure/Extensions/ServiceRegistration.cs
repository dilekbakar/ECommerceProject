using ECommerceService.Application.Interfaces;
using ECommerceService.Infrastructure.Contexts;
using ECommerceService.Infrastructure.Repositories;
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

            services.AddScoped<IBasketRepository, BasketRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IDiscountRepository, DiscountRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            return services;
        }
    
}
}
