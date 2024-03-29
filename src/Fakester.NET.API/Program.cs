using Fakester.NET.API.Setup;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers()
    .AddXmlSerializerFormatters();

builder.Services.ResolveApplicationServices();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGens();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    
}

app.MapGet("/", c => Task.Run((() =>
        c.Response.Redirect("/swagger/index.html"))));

app.UseSwagger();

app.UseSwaggerUIs();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
