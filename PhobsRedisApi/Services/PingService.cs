using Microsoft.AspNetCore.Mvc;
using PhobsRedisApi.Dtos;
using PhobsRedisApi.XmlRpc;
using System.Text;
using System.Xml.Serialization;

namespace PhobsRedisApi.Services
{
    public class PingService : IPingService
    {

        private readonly IConfiguration _config;
        private readonly IHttpClientFactory _clientFactory;

        public PingService(IConfiguration config, IHttpClientFactory clientFactory)
        {
            _config = config;
            _clientFactory = clientFactory;
        }

        public async Task<string> PingRemoteServer(PingDto request)
        {

            PCPingRQ requestObj = PCPingRQ.CreateObject(
                _config["PhobsUsername"],
                _config["PhobsPassword"],
                _config["PhobsSiteId"],
                request.echoString);

            var client = _clientFactory.CreateClient();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(PCPingRQ));

            using (MemoryStream memoryStream = new MemoryStream())
            {
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("", "");
                xmlSerializer.Serialize(memoryStream, requestObj, ns);

                StringContent content = new StringContent(Encoding.UTF8.GetString(memoryStream.ToArray()), Encoding.UTF8, "text/xml");
                Console.WriteLine("\nREQUEST\n" + await content.ReadAsStringAsync());

                HttpResponseMessage response = await client.PostAsync(_config["PhobsUrl"], content);

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("\nRESPONSE\n" + responseData);
                    return responseData;
                }

                return null;
            }
        }
    }
}
