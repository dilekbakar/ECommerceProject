namespace ECommerceService.API.Infrastructure.Middlewares
{
    public class SecurityHeadersMiddleware
    {
        private readonly RequestDelegate next;

        public SecurityHeadersMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            httpContext.Response.Headers.Add("X-Frame-Options", "DENY");
            httpContext.Response.Headers.Add("X-Xss-Protection", "1; mode=block");
            httpContext.Response.Headers.Add("X-Content-Type-Options", "nosniff");
            httpContext.Response.Headers.Add(
                "Content-Security-Policy",
                "default-src 'self'; " +
                "img-src 'self' {localhost:7000}; " +
                "font-src 'self'; " +
                "style-src 'self'; " +
                "script-src 'self' 'nonce-{localhost:7000}' " + " 'nonce-{localhost:7000}'; " +
                "frame-src 'self';" +
                "connect-src 'self';");
            httpContext.Response.Headers.Add("Referrer-Policy", "no-referrer");
            httpContext.Response.Headers.Add("Feature-Policy", "accelerometer 'none'; camera 'none';" +
                                                               " geolocation 'none'; gyroscope 'none'; " +
                                                               "magnetometer 'none'; microphone 'none'; " +
                                                               "payment 'none'; usb 'none'");

            await next(httpContext);
        }
    }
}
