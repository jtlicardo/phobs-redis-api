using PhobsRedisApi.Dtos;
using PhobsRedisApi.Models;

namespace PhobsRedisApi.Services.Ping
{
    public class PingService : IPingService
    {
        private readonly XmlRpcUtilities _utils;
        private readonly IConfiguration _config;

        public PingService(IConfiguration config, XmlRpcUtilities utils)
        {
            _config = config;
            _utils = utils;
        }

        public async Task<PCPingRS> PingRemoteServer(PingDto request)
        {

            PCPingRQ requestObj = CreateRequestObject(request);

            string requestXml = _utils.SerializeObjectToXml(requestObj);
            Console.WriteLine("\nREQUEST\n" + requestXml);

            HttpResponseMessage response = await _utils.SendHttpRequest(requestXml, _config["PhobsUrl"]);
            string responseXml = await response.Content.ReadAsStringAsync();
            Console.WriteLine("\nRESPONSE\n" + responseXml);

            if (response.IsSuccessStatusCode)
            {
                PCPingRS responseObject = _utils.DeserializeXmlToObject<PCPingRS>(responseXml);
                return responseObject;
            }

            return null;
        }
        
        private PCPingRQ CreateRequestObject(PingDto request)
        {
            return PCPingRQ.CreateObject(
                _config["PhobsUsername"],
                _config["PhobsPassword"],
                _config["PhobsSiteId"],
                request);
        }
    }
}
