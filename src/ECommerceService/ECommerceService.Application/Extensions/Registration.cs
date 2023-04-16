using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ECommerceService.Application.Extensions
{
    public static class Registration
    {
        public static void AddApplicationRegistration(this IServiceCollection services)
        {
            var assm = Assembly.GetExecutingAssembly();
            services.AddAutoMapper(assm);
            services.AddMediatR(assm);
        }
    }
}
