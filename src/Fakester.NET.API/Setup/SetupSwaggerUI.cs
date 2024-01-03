namespace Fakester.NET.API.Setup;

public static class SetupSwaggerUI
{
    public static void UseSwaggerUIs(this WebApplication app)
    {
        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint($"/swagger/{SwaggerDocs.WeatherSummary}/swagger.json", "Weather Forecast");
            //options.SwaggerEndpoint("/swagger/v2/swagger.json", "V2 Docs");
        });
    }
}
