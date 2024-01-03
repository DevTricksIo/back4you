using Microsoft.AspNetCore.Mvc;
using Fakester.NET.Application.Queries.WeatherSummary.Abstractions;
using Fakester.NET.Application.Models.WeatherSummary;
using Fakester.NET.API.Setup;

namespace Fakester.NET.API.Controllers.WeatherSummary;

[ApiController]
[ApiExplorerSettings(GroupName = SwaggerDocs.WeatherSummary)]
[Route($"{SwaggerDocs.WeatherSummary}/weather-forecast")]
public class WeatherForecastController(IWeatherSummaryQueries weatherSummaryQueries) : ControllerBase
{
    private readonly IWeatherSummaryQueries _weatherSummaryQueries = weatherSummaryQueries;

    /// <summary>
    /// Get Weather Forecast
    /// </summary>
    /// <returns>Retrieve a list of fake Weather Forecast</returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    //[ProducesResponseType(typeof(IEnumerable<WeatherForecast>), 200)]
    public IEnumerable<WeatherForecast> Get()
    {
        return _weatherSummaryQueries.Get();
    }
}
