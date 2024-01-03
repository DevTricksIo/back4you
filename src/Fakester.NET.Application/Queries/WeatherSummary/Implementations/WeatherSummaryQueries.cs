using Fakester.NET.Application.Models.WeatherSummary;
using Fakester.NET.Application.Queries.WeatherSummary.Abstractions;

namespace Fakester.NET.Application.Queries.WeatherSummary.Implementations;

public class WeatherSummaryQueries : IWeatherSummaryQueries
{
    private static readonly string[] Summaries =
    [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    ];

    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        });
    }
}
