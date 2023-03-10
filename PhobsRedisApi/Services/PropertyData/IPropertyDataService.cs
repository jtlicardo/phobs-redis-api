using PhobsRedisApi.Dtos;
using PhobsRedisApi.PhobsModels;

namespace PhobsRedisApi.Services.PropertyData
{
    public interface IPropertyDataService
    {
        Task<PropertyDataResponseDto> GetPropertyData(PropertyDataRequestDto request);
    }
}
