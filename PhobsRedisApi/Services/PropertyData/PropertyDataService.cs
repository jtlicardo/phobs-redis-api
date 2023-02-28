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

        private List<DateTime> GetDatesToCheck (string Date, byte Nights)
        {
            DateTime startDate = DateTime.ParseExact(Date, "yyyyMMdd", null);
            List<DateTime> datesToCheck = new List<DateTime>();

            for (int i = 0; i < Nights; i++)
            {
                DateTime currentDate = startDate.AddDays(i);
                datesToCheck.Add(currentDate);
            }

            return datesToCheck;
        }

        public Task<PropertyDataRS> GetPropertyData(GetPropertyDataDto request)
        {
            PropertyDataRS propertyData = new PropertyDataRS();
            propertyData.PropertyId = request.Property;

            string pricesKey =
                $"{request.Property}:" +
                $"{request.Adults}:" +
                $"{request.Chd}:" +
                $"{request.Pets}:" +
                $"{request.Rate}:" +
                $"{request.Date}:" +
                $"{request.Nights}";

            var minPricePerDay = _repo.GetData(pricesKey);

            if (minPricePerDay == null)
            {
                propertyData.MinPricePerDay = null;
            }
            else
            {
                propertyData.MinPricePerDay = float.Parse(minPricePerDay);
            }

            List<DateTime> datesToCheck = GetDatesToCheck(request.Date, request.Nights);

            propertyData.Availability = true;

            foreach (DateTime date in datesToCheck)
            {
                string availabilityKey = $"{request.Property}:{date.ToString("yyyyMMdd")}";
                var availability = _repo.GetData(availabilityKey);
                if (availability == null)
                {
                    propertyData.Availability = null;
                    break;
                }
                else if (int.Parse(availability) == 0)
                {
                    propertyData.Availability = false;
                    break;
                }
            }

            return Task.FromResult(propertyData);
        }
    }
}
