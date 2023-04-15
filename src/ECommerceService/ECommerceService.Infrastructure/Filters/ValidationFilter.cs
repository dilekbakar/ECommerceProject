using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace ECommerceService.Infrastructure.Filters
{
    public class ValidationFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ModelState.IsValid)
            {
                var errors = context.ModelState
                       .Where(x => x.Value.Errors.Any())
                       .ToDictionary(e => e.Key, e => e.Value.Errors.Select(e => e.ErrorMessage))
                       .ToArray();

                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Conflict;
                context.Result = new ObjectResult(errors);
                return;
            }

            await next();
        }
    }
}
