using PhobsRedisApi.Dtos;
using PhobsRedisApi.Models;
using System.Text;
using System.Xml.Serialization;

namespace PhobsRedisApi.Services.PropertyAvailability
{
    public class PropertyAvailabilityService : IPropertyAvailabilityService
    {
        private readonly IConfiguration _config;
        private readonly IHttpClientFactory _clientFactory;
        public PropertyAvailabilityService(IConfiguration config, IHttpClientFactory clientFactory)
        {
            _config = config;
            _clientFactory = clientFactory;
        }

        public async Task<PCPropertyAvailabilityRS> GetPropertyAvailability(PropertyAvailabilityDto request)
        {

            PCPropertyAvailabilityRQ requestObj = CreateRequestObject(request);

            string requestXml = SerializeObjectToXml(requestObj);
            Console.WriteLine("\nREQUEST\n" + requestXml);

            HttpResponseMessage response = await SendHttpRequest(requestXml);
            string responseXml = await response.Content.ReadAsStringAsync();
            Console.WriteLine("\nRESPONSE\n" + responseXml);

            if (response.IsSuccessStatusCode)
            {
                PCPropertyAvailabilityRS responseObject = DeserializeXmlToObject<PCPropertyAvailabilityRS>(responseXml);
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

        private string SerializeObjectToXml<T>(T obj)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (MemoryStream memoryStream = new MemoryStream())
            {
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("", "");
                xmlSerializer.Serialize(memoryStream, obj, ns);
                return Encoding.UTF8.GetString(memoryStream.ToArray());
            }
        }
        private async Task<HttpResponseMessage> SendHttpRequest(string requestXml)
        {
            var client = _clientFactory.CreateClient();
            StringContent content = new StringContent(requestXml, Encoding.UTF8, "text/xml");
            return await client.PostAsync(_config["PhobsUrl"], content);
        }

        private T DeserializeXmlToObject<T>(string xml)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(T));
            using (TextReader reader = new StringReader(xml))
            {
                return (T)deserializer.Deserialize(reader);
            }
        }
    }
}
