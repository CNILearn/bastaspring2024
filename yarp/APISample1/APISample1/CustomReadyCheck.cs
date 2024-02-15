using Microsoft.Extensions.Diagnostics.HealthChecks;
using WebSampleApp.Services;

namespace WebSampleApp;

public class CustomReadyCheck(HealthSampleService healthSampleService) : IHealthCheck
{
    public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
    {
        HealthCheckResult result = healthSampleService.IsReady ? HealthCheckResult.Healthy("healthy") : HealthCheckResult.Unhealthy("unhealthy");
        return Task.FromResult(result);
    }
}
