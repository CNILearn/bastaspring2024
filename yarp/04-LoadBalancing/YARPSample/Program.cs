using System.Text.Json;
using System.Text;
using Yarp.ReverseProxy.Transforms;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));

var app = builder.Build();

app.MapReverseProxy();
//app.MapReverseProxy(pipeline =>
//{
//    pipeline.UseSessionAffinity();
//    pipeline.UseLoadBalancing();
//    pipeline.UsePassiveHealthChecks();
//});

app.Run();
