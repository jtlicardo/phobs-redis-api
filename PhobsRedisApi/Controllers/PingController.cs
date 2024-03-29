﻿using Microsoft.AspNetCore.Mvc;
using PhobsRedisApi.Dtos;
using PhobsRedisApi.Services.Ping;
using PhobsRedisApi.PhobsModels;

namespace PhobsRedisApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        private readonly IPingService _service;

        public PingController(IPingService service)
        {
            _service = service;
        }

        [HttpPost]
        async public Task<ActionResult<PCPingRS>> PingRemoteServer([FromBody] PingDto request)
        {
            PCPingRS? response = await _service.PingRemoteServer(request);

            if (response != null)
            {
                return Ok(response);
            }

            return BadRequest();
        }
    }
}
