using Microsoft.AspNetCore.Mvc;
using PhobsRedisApi.Dtos;
using PhobsRedisApi.Models;
using PhobsRedisApi.Services.AvailabilityCalendar;

namespace PhobsRedisApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AvailabilityCalendarController : ControllerBase
    {

        private readonly IAvailabilityCalendarService _service;

        public AvailabilityCalendarController(IAvailabilityCalendarService service)
        {
            _service = service;
        }

        [HttpPost]
        async public Task<ActionResult<PCAvailabilityCalendarRS>> GetAvailabilityCalendar(
            [FromBody] AvailabilityCalendarDto request)
        {
            PCAvailabilityCalendarRS? response = await _service.GetAvailabilityCalendar(request);

            if (response != null)
            {
                return Ok(response);
            }

            return BadRequest();
        }

    }
}
