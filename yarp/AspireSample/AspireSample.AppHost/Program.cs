var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AspireSample_ApiService>("apiservice")
    .WithReplicas(2);

builder.AddProject<Projects.AspireSample_Web>("webfrontend")
    .WithReference(apiService);

builder.Build().Run();
