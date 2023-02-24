using PhobsRedisApi.Dtos;
using PhobsRedisApi.Models;

namespace PhobsRedisApi.Services.PropertyAvailability
{
    public class PropertyAvailabilityService : IPropertyAvailabilityService
    {
        private readonly IXmlRpcUtilities _utils;
        private readonly IConfiguration _config;

        public PropertyAvailabilityService(IXmlRpcUtilities utils, IConfiguration config)
        {
            _utils = utils;
            _config = config;
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
                return responseObject;
            }

            return null;
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
