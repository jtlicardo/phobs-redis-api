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
            
            PCPropertyAvailabilityRQ requestObj = PCPropertyAvailabilityRQ.CreateObject(
                _config["PhobsUsername"],
                _config["PhobsPassword"],
                _config["PhobsSiteId"],
                request);

            var client = _clientFactory.CreateClient();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(PCPropertyAvailabilityRQ));

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

                    XmlSerializer deserializer = new XmlSerializer(typeof(PCPropertyAvailabilityRS));
                    using (TextReader reader = new StringReader(responseData))
                    {
                        PCPropertyAvailabilityRS responseObject = (PCPropertyAvailabilityRS)deserializer.Deserialize(reader);
                        return responseObject;
                    }
                }

                return null;
            }

        }
    }
}
