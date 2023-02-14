using PhobsRedisApi.Dtos;
using PhobsRedisApi.Models;

namespace PhobsRedisApi.Services.PropertyAvailability
{
    public interface IPropertyAvailabilityService
    {
        public Task<PCPropertyAvailabilityRS> GetPropertyAvailability(PropertyAvailabilityDto request);
    }
}
