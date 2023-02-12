using Microsoft.AspNetCore.Mvc;
using PhobsRedisApi.Dtos;
using PhobsRedisApi.Services;
using PhobsRedisApi.XmlRpc;
using System.Xml.Serialization;

namespace PhobsRedisApi.Controllers
{
    
    [Route("[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        private readonly IPingService pingService;

        public PingController(IPingService pingService)
        {
            this.pingService = pingService;
        }

        [HttpPost]
        async public Task<ActionResult<PCPingRS>> PingRemoteServer([FromBody] PingDto request)
        {
            string response = await pingService.PingRemoteServer(request);

            if (response != null)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(PCPingRS));
                using (TextReader reader = new StringReader(response))
                {
                    PCPingRS responseObject = (PCPingRS)xmlSerializer.Deserialize(reader);
                    return Ok(responseObject);
                }
            }
            
            return BadRequest();
        }
    }
}
