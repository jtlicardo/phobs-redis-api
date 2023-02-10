using Microsoft.AspNetCore.Mvc;
using PhobsRedisApi.XmlRpc;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Xml.Serialization;

namespace PhobsRedisApi.Controllers
{

    public class EchoRequest
    {
        public string echoString { get; set; }
    }


    [Route("[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        private readonly IConfiguration _config;

        public PingController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost]
        async public Task<ActionResult<PCPingRS>> PingRemoteServer([FromBody] EchoRequest request)
        {

            string phobsUrl = _config["PhobsUrl"];
            string phobsUsername = _config["PhobsUsername"];
            string phobsPassword = _config["PhobsPassword"];
            string phobsSiteId = _config["PhobsSiteId"];
            string echoString = request.echoString;

            PCPingRQ requestObj = new PCPingRQ() {
                Auth = new PCPingRQAuth()
                {
                    Username = phobsUsername,
                    Password = phobsPassword,
                    SiteId = phobsSiteId
                },
                EchoString = echoString
            };

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(phobsUrl);

                XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
                namespaces.Add("", "");
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(PCPingRQ));

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    xmlSerializer.Serialize(memoryStream, requestObj, namespaces);
                    
                    StringContent content = new StringContent(Encoding.UTF8.GetString(memoryStream.ToArray()), Encoding.UTF8, "text/xml");
                    Console.WriteLine("\nREQUEST\n" + await content.ReadAsStringAsync());
                    
                    HttpResponseMessage response = await client.PostAsync(phobsUrl, content);
                    
                    if (response.IsSuccessStatusCode)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();
                        Console.WriteLine("\nRESPONSE\n" + responseData);
                        return Ok(responseData);
                    }
                    else
                    {
                        return BadRequest(response.StatusCode + " " + response.ReasonPhrase);
                    }
                }
            }

        }
    }
}
