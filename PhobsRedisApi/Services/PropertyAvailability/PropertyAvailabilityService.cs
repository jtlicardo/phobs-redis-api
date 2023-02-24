using Newtonsoft.Json;
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
                _repo.SaveData("PA:test", JsonConvert.SerializeObject(responseObject));
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

    }
}
