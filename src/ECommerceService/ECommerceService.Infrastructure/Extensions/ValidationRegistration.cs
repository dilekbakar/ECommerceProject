using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerceService.Infrastructure.Extensions
{

    public static class ValidationRegistration
    {
        public static IServiceCollection AddValidationRegistration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();

            //services.AddScoped<IValidator<CreateCategoryCommand>, CreateCategoryValidator>();


            services.Configure<ApiBehaviorOptions>(opt =>
            {
                opt.SuppressModelStateInvalidFilter = true;
            });

            return services;
        }
    }
}
