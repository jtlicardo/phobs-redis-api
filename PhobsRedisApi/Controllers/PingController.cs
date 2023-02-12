using Microsoft.AspNetCore.Mvc;
using PhobsRedisApi.Dtos;
using PhobsRedisApi.Services;
using PhobsRedisApi.XmlRpc;

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
            PCPingRS response = await pingService.PingRemoteServer(request);

            if (response != null)
                return Ok(response);
          
            return BadRequest();
        }
    }
}
