using Fakester.NET.Application.Models.WeatherSummary;

namespace Fakester.NET.Application.Queries.WeatherSummary.Abstractions;

public interface IWeatherSummaryQueries
{
    IEnumerable<WeatherForecast> Get();
}
