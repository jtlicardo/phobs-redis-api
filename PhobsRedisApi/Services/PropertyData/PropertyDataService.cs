using PhobsRedisApi.Data;
using PhobsRedisApi.Dtos;
using PhobsRedisApi.Models;

namespace PhobsRedisApi.Services.PropertyData
{
    public class PropertyDataService : IPropertyDataService
    {
        private readonly IDataRepo _repo;

        public PropertyDataService(IDataRepo repo)
        {
            _repo = repo;
        }

        public Task<PropertyDataRS?> GetPropertyData(GetPropertyDataDto request)
        {
            string pricesKey =
                $"{request.Property}:" +
                $"{request.Adults}:" +
                $"{request.Chd}:" +
                $"{request.Pets}:" +
                $"{request.Rate}:" +
                $"{request.Date}:" +
                $"{request.Nights}";

            string availabilityKey =
                $"{request.Property}:" +
                $"{request.Date}:" +
                $"{request.Nights}";

            var prices = _repo.GetList(pricesKey);
            var availability = _repo.GetList(availabilityKey);

            PropertyDataRS propertyData = new PropertyDataRS();
            propertyData.PropertyId = request.Property;
            propertyData.Prices = Array.ConvertAll(prices, float.Parse);
            propertyData.Availability = Array.ConvertAll(availability, int.Parse);

            return Task.FromResult<PropertyDataRS?>(propertyData);
        }
    }
}
