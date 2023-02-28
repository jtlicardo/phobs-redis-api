using PhobsRedisApi.Dtos;
using PhobsRedisApi.Models;

namespace PhobsRedisApi.Services.PropertyData
{
    public interface IPropertyDataService
    {
        Task<PropertyDataRS> GetPropertyData(GetPropertyDataDto request);
    }
}
