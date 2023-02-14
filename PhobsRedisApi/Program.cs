using PhobsRedisApi.Services.Ping;
using PhobsRedisApi.Services.PropertyAvailability;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddHttpClient();
builder.Services.AddScoped<IPingService, PingService>();
builder.Services.AddScoped<IPropertyAvailabilityService, PropertyAvailabilityService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
