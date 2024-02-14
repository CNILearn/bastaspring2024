using APISample1;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.Diagnostics.HealthChecks;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHealthChecks()
    .AddCheck<UnhealthyAfter4>("health", HealthStatus.Unhealthy, ["ready", "live"]);

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

app.MapHealthChecks("/live", new HealthCheckOptions()
{
    Predicate = check => check.Tags.Contains("live")
});

app.MapHealthChecks("/ready"); // all checks

app.MapGet("/headers", (HttpRequest request) => 
{
    var info = request.Headers
    .Select(h => new HeaderInfo(h.Key, h.Value.ToString()))
    .ToArray();

    return TypedResults.Ok(request.Headers);
    // return TypedResults.Ok(info);
});

app.MapGet("/replace", () => TypedResults.Ok("Content from API"));
app.MapGet("/api/version", () => TypedResults.Ok("V1 Server"));

app.MapGet("/info", () => TypedResults.Ok("API-1"))
    .WithName("Info")
    .WithOpenApi();

string[] summaries =
[
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
];

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}

internal record HeaderInfo(string Key, string Value);