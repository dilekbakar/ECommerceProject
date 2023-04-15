using ECommerceService.API.Infrastructure.Middlewares;

namespace ECommerceService.API.Infrastructure.Extensions
{
    public static class SecurityMiddlewareExtensions
    {
        public static IApplicationBuilder UseSecurityHeaders(this IApplicationBuilder app)
        {
            return app.UseMiddleware<SecurityHeadersMiddleware>();
        }
    }
}
