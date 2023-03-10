using PhobsRedisApi.Dtos;
using PhobsRedisApi.PhobsModels;

namespace PhobsRedisApi.Services.PropertyAvailability
{
    public interface IPropertyAvailabilityService
    {
        Task<PCPropertyAvailabilityRS?> GetPropertyAvailability(PropertyAvailabilityDto request);
    }
}