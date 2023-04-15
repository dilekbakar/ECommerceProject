using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;

namespace ECommerceService.API.Infrastructure.Extensions
{
    public static class ApiVersioningExtension
    {
        public static IServiceCollection AddApiVersioningWithConfigure(this IServiceCollection services)
        {
            services.AddApiVersioning(opt =>
            {
                opt.DefaultApiVersion = new ApiVersion(1, 0);
                opt.AssumeDefaultVersionWhenUnspecified = true;
                opt.ReportApiVersions = true;
                opt.ApiVersionReader = ApiVersionReader.Combine(new UrlSegmentApiVersionReader(),
                                                                new HeaderApiVersionReader("x-api-version"),
                                                                new MediaTypeApiVersionReader("x-api-version"));
            });

            services.AddVersionedApiExplorer(conf =>
            {
                conf.GroupNameFormat = "'v'VVV";
                conf.SubstituteApiVersionInUrl = true;
            });

            return services;
        }
    }
}
