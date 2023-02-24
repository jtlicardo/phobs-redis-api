using PhobsRedisApi.Data;
using PhobsRedisApi.Services;
using PhobsRedisApi.Services.AvailabilityCalendar;
using PhobsRedisApi.Services.Ping;
using PhobsRedisApi.Services.PropertyAvailability;
using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddHttpClient();
builder.Services.AddScoped<IPingService, PingService>();
builder.Services.AddScoped<IPropertyAvailabilityService, PropertyAvailabilityService>();
builder.Services.AddScoped<IAvailabilityCalendarService, AvailabilityCalendarService>();
builder.Services.AddScoped<IDataRepo, RedisDataRepo>();
builder.Services.AddScoped<IXmlRpcUtilities, XmlRpcUtilities>();

builder.Services.AddSingleton<IConnectionMultiplexer>(opt =>
    ConnectionMultiplexer.Connect(builder.Configuration.GetConnectionString("RedisConnection"))
);

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
