using Microsoft.AspNetCore.Mvc.Filters;

namespace CleanArchitecture.Api
{
    public class LogActivityFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            context.HttpContext.Request.Headers.ContainsKey("IsArabic");
            await next();
            throw new System.NotImplementedException();
        }
    }
}
