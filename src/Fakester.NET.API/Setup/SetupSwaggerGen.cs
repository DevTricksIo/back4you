using Microsoft.OpenApi.Models;
using System.Reflection;

namespace Fakester.NET.API.Setup;

public static class SetupSwaggerGen
{
    public static void AddSwaggerGens(this IServiceCollection services)
    {
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc(SwaggerDocs.WeatherSummary, new OpenApiInfo
            {
                Version = "v1",
                Title = "Weather Forecast API 🌤️",
                Description = "This is a simple example of a Weather Forecast API without authentication. It supports both JSON and XML response formats."
            });

            //options.SwaggerDoc("v2", new OpenApiInfo { Title = "My API - V2", Version = "v2" });

            //enable comment annotation in swagger
            var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            options.IncludeXmlComments(xmlPath);
        });
    }
}