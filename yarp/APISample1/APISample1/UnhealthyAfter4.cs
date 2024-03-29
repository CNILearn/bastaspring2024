﻿using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace APISample1;

public sealed class UnhealthyAfter4 : IHealthCheck
{
    private static int s_counter = 0;

    public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
    {
        HealthCheckResult check = s_counter++ % 4 != 0 ? HealthCheckResult.Healthy("healthy 1") : HealthCheckResult.Unhealthy("unhealthy 1");
        return Task.FromResult(check);
    }
}
