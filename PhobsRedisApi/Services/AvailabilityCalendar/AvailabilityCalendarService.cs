using PhobsRedisApi.Data;
using PhobsRedisApi.Dtos;
using PhobsRedisApi.Models;

namespace PhobsRedisApi.Services.AvailabilityCalendar
{
    public class AvailabilityCalendarService : IAvailabilityCalendarService
    {
        private readonly IXmlRpcUtilities _utils;
        private readonly IConfiguration _config;
        private readonly IDataRepo _repo;

        public AvailabilityCalendarService(IXmlRpcUtilities utils, IConfiguration config, IDataRepo repo)
        {
            _utils = utils;
            _config = config;
            _repo = repo;
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
                SaveData(request, responseObject);
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

        private void SaveData(AvailabilityCalendarDto req, PCAvailabilityCalendarRS res)
        {
            if (res.Properties is null) return; 

            foreach (var unit in res.Properties.Property.Units)
            {
                foreach (var day in unit.AvailabilityCalendar)
                {
                    string date = day.Date.ToString("yyyyMMdd");
                    // Example key: PHDIA:JRSUP:20240426
                    string key = $"{req.PropertyId}:{unit.UnitId}:{date}";
                    string value = day.Available.ToString();
                    _repo.SaveData(key, value);
                }
            }
        }
    }
}
