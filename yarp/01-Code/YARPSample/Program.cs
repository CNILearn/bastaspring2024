using Yarp.ReverseProxy.Configuration;

var builder = WebApplication.CreateBuilder(args);

IReadOnlyList<RouteConfig> routes = 
    [
       // new RouteConfig { RouteId ="First", ClusterId = "cluster1", Match = new RouteMatch() { Path= "{**catch-all}" } }
       new RouteConfig { RouteId ="First", ClusterId = "cluster1", Match = new RouteMatch() { Path= "/weatherforecast" } }
    ];
IReadOnlyList<ClusterConfig> clusters =
    [
        new ClusterConfig() 
        {
            ClusterId = "cluster1",
            Destinations = new Dictionary<string, DestinationConfig>() 
            {
                { "first", new DestinationConfig() { Address = "http://localhost:5295"} }
            }
        }
    ];

builder.Services.AddReverseProxy()
    .LoadFromMemory(routes, clusters);

var app = builder.Build();

app.MapReverseProxy();


app.Run();
