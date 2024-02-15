using System.Text.Json;
using System.Text;
using Yarp.ReverseProxy.Transforms;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"))
    .AddTransforms(builderContext =>
    {
        builderContext.AddResponseHeader("myheader", "my yarp value");

        if (builderContext.Route.RouteId == "route1")
        {
            builderContext.AddResponseTransform(async context =>
            {
                context.SuppressResponseBody = true;
                var jsonObject = new
                {
                    Text = "From YARP"
                };
                var json = JsonSerializer.Serialize(jsonObject);
                await context.HttpContext.Response.Body.WriteAsync(Encoding.UTF8.GetBytes(json));
            });
        }
    })
    .AddTransforms(builderContext =>
    {
        if (builderContext.Route.RouteId == "route1")
        {
            builderContext.AddResponseTransform(async context =>
            {
                context.SuppressResponseBody = true;
                var jsonObject = new
                {
                    Text = "From YARP"
                };
                var json = JsonSerializer.Serialize(jsonObject);
                await context.HttpContext.Response.Body.WriteAsync(Encoding.UTF8.GetBytes(json));
            });
        }
    });

var app = builder.Build();

app.MapReverseProxy();

app.Run();
