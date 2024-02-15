using System.Globalization;
using System.Threading.RateLimiting;

using Yarp.ReverseProxy.Transforms;

using YARPSample;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"))
    .AddTransforms(builderContext =>
    {
        builderContext.AddResponseHeader("myheader", "custom value");
    });

builder.Services.AddRateLimiter(limiterOptions =>
{
    limiterOptions.OnRejected = (context, cancellationToken) =>
    {
        var metadata = context.Lease.GetAllMetadata();
        if (context.Lease.TryGetMetadata(MetadataName.RetryAfter, out TimeSpan retryAfter))
        {
            context.HttpContext.Response.Headers.RetryAfter = 
                ((int)retryAfter.TotalSeconds).ToString(NumberFormatInfo.InvariantInfo);
        }

        context.HttpContext.Response.StatusCode = StatusCodes.Status429TooManyRequests;
        return default;
    };

    limiterOptions.GlobalLimiter = PartitionedRateLimiter.Create<HttpContext, string>(httpContext =>
    {
        return RateLimitPartition.GetFixedWindowLimiter(partitionKey: httpContext.Request.Headers.Host.ToString(), partition =>
            new FixedWindowRateLimiterOptions
            {
                PermitLimit = 5000,
                AutoReplenishment = true,
                Window = TimeSpan.FromSeconds(10)
            });
    });

    limiterOptions.AddPolicy<string>("subscriptions", context =>
    {
        string subscriptionId = context.Request.Headers["SubscriptionID"].ToString();
        string subscription = context.Request.Headers["Subscription"].ToString();

        int permitLimit = subscription switch
        {
            "premium" => 1000,
            "basic" => 100,
            "min" => 3,
            null => 5,
            _ => 5
        };

        string id = subscriptionId?.ToString() ?? string.Empty;

        RateLimitPartition<string> partition = RateLimitPartition.GetSlidingWindowLimiter(id, _ =>
            new SlidingWindowRateLimiterOptions
            {
                PermitLimit = id == string.Empty ? 5 : permitLimit,
                QueueProcessingOrder = QueueProcessingOrder.NewestFirst,
                QueueLimit = 0,
                Window = TimeSpan.FromSeconds(10),
                SegmentsPerWindow = 5
            });

        return partition;

    });
});

var app = builder.Build();

app.UseTestMiddleware();

app.UseRateLimiter();

app.MapReverseProxy();

app.Run();
