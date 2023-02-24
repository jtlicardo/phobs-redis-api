using PhobsRedisApi.Dtos;
using PhobsRedisApi.Models;

namespace PhobsRedisApi.Services.AvailabilityCalendar
{
    public class AvailabilityCalendarService : IAvailabilityCalendarService
    {
        private readonly IXmlRpcUtilities _utils;
        private readonly IConfiguration _config;

        public AvailabilityCalendarService(IXmlRpcUtilities utils, IConfiguration config)
        {
            _utils = utils;
            _config = config;
        }

        public async Task<PCAvailabilityCalendarRS?> GetAvailabilityCalendar(AvailabilityCalendarDto request)
        {
            PCAvailabilityCalendarRQ requestObj = CreateRequestObject(request);
            
            string requestXml = _utils.SerializeObjectToXml(requestObj);
            Console.WriteLine("\nREQUEST\n" + requestXml);

            HttpResponseMessage response = await _utils.SendHttpRequest(requestXml, _config["PhobsUrl"]);
            string responseXml = await response.Content.ReadAsStringAsync();
            Console.WriteLine("\nRESPONSE\n" + responseXml);

            if (response.IsSuccessStatusCode)
            {
                PCAvailabilityCalendarRS responseObject = _utils.DeserializeXmlToObject<PCAvailabilityCalendarRS>(responseXml);
                return responseObject;
            }

            return null;
        }

        private PCAvailabilityCalendarRQ CreateRequestObject(AvailabilityCalendarDto request)
        {
            return PCAvailabilityCalendarRQ.CreateObject(
                _config["PhobsUsername"],
                _config["PhobsPassword"],
                _config["PhobsSiteId"],
                request);
        }
    }
}
