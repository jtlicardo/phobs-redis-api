using PhobsRedisApi.Dtos;
using PhobsRedisApi.Models;

namespace PhobsRedisApi.Services.PropertyAvailability
{
    public interface IPropertyAvailabilityService
    {
        Task<PCPropertyAvailabilityRS?> GetPropertyAvailability(PropertyAvailabilityDto request);
        string? GetCachedData(string key);
    }
}