using Microsoft.Extensions.Diagnostics.HealthChecks;

using WebSampleApp.Services;

namespace WebSampleApp;

public class CustomHealthCheck(HealthSampleService healthSampleService) : IHealthCheck
{
    public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
    {
        var result = healthSampleService.IsHealthy ? HealthCheckResult.Healthy("healthy") : HealthCheckResult.Unhealthy("unhealthy");
        return Task.FromResult(result);
    }
}
