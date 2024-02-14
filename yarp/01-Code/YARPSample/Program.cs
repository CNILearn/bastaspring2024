using Yarp.ReverseProxy.Configuration;

var builder = WebApplication.CreateBuilder(args);

IReadOnlyList<RouteConfig> routes = 
[
    new() 
    { 
        RouteId ="route1", 
        ClusterId = "cluster1", 
        Match = new() { Path= "{**catch-all}" } 
    }
    //new() 
    //{ 
    //    RouteId ="route1", 
    //    ClusterId = "cluster1", 
    //    Match = new() 
    //    { 
    //        Path= "/weatherforecast" 
    //    } 
    //}
];
IReadOnlyList<ClusterConfig> clusters =
[
    new() 
    {
        ClusterId = "cluster1",
        Destinations = new Dictionary<string, DestinationConfig>() 
        {
            { "first", new DestinationConfig { Address = "http://localhost:5300"} }
        }
    }
];

builder.Services.AddReverseProxy()
    .LoadFromMemory(routes, clusters);

var app = builder.Build();

app.MapReverseProxy();

app.Run();
