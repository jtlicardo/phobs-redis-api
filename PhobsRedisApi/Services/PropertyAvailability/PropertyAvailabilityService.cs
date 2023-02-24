using PhobsRedisApi.Data;
using PhobsRedisApi.Dtos;
using PhobsRedisApi.Models;

namespace PhobsRedisApi.Services.PropertyAvailability
{
    public class PropertyAvailabilityService : IPropertyAvailabilityService
    {
        private readonly IXmlRpcUtilities _utils;
        private readonly IConfiguration _config;
        private readonly IDataRepo _repo;

        public PropertyAvailabilityService(IXmlRpcUtilities utils, IConfiguration config, IDataRepo repo)
        {
            _utils = utils;
            _config = config;
            _repo = repo;
        }

        public async Task<PCPropertyAvailabilityRS?> GetPropertyAvailability(PropertyAvailabilityDto request)
        {
            PCPropertyAvailabilityRQ requestObj = CreateRequestObject(request);

            string requestXml = _utils.SerializeObjectToXml(requestObj);
            Console.WriteLine("\nREQUEST\n" + requestXml);

            HttpResponseMessage response = await _utils.SendHttpRequest(requestXml, _config["PhobsUrl"]);
            string responseXml = await response.Content.ReadAsStringAsync();
            Console.WriteLine("\nRESPONSE\n" + responseXml);

            if (response.IsSuccessStatusCode)
            {
                PCPropertyAvailabilityRS responseObject = _utils.DeserializeXmlToObject<PCPropertyAvailabilityRS>(responseXml);
                SaveData(request, responseObject);
                return responseObject;
            }

            return null;
        }

        public string? GetCachedData(string key)
        {
            return _repo.GetData(key);
        }

        private PCPropertyAvailabilityRQ CreateRequestObject(PropertyAvailabilityDto request)
        {
            return PCPropertyAvailabilityRQ.CreateObject(
                _config["PhobsUsername"],
                _config["PhobsPassword"],
                _config["PhobsSiteId"],
                request);
        }

        private void SaveData(PropertyAvailabilityDto req, PCPropertyAvailabilityRS res)
        {
            if (res.AvailabilityList is null) return;

            foreach (var property in res.AvailabilityList)
            {
                foreach (var rate in property.RatePlans)
                {
                    foreach (var unit in rate.Units)
                    {
                        foreach (var price in unit.Rate.PriceBreakdown)
                        {
                            string date = price.Date.ToString("yyyyMMdd");
                            // Example key: PHDIA:3:1:0:WHB:JRSUP:20240426
                            string key =
                                $"{property.PropertyId}:" +
                                $"{req.Adults}:" +
                                $"{req.ChdGroup1}:" +
                                $"{req.Pets}:" +
                                $"{rate.RateId}:" +
                                $"{unit.UnitId}:" +
                                $"{date}";
                            string value = price.Price.Value.ToString();
                            _repo.SaveData(key, value);
                        }
                    }
                }
            }
        }

    }
}
