using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace YARPSample;

public class TestMiddleware(RequestDelegate next)
{
    public Task Invoke(HttpContext httpContext)
    {
        return next(httpContext);
    }
}

// Extension method used to add the middleware to the HTTP request pipeline.
public static class TestMiddlewareExtensions
{
    public static IApplicationBuilder UseTestMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<TestMiddleware>();
    }
}
