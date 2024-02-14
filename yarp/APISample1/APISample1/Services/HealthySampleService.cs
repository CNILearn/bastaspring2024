namespace WebSampleApp.Services;

public sealed class HealthSampleService : IDisposable
{
    private Timer? _timer;
    public void SetHealthy(bool healthy = true)
    {
        if (IsHealthy == healthy) return;

        _isReady = false;
        IsHealthy = healthy;

        if (IsHealthy)
        {
            _timer?.Dispose();

            _timer = new(o =>
            {
                _isReady = true;
            }, null, TimeSpan.FromSeconds(5), Timeout.InfiniteTimeSpan);
        }
    }

    public void Dispose() => _timer?.Dispose();

    public bool IsHealthy { get; set; } = false;

    private bool _isReady = false;
    public bool IsReady => IsHealthy && _isReady;
}
