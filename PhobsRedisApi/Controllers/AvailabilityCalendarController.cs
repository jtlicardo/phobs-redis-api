using Microsoft.AspNetCore.Mvc;
using PhobsRedisApi.Dtos;
using PhobsRedisApi.PhobsModels;
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
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            PCAvailabilityCalendarRS? response = await _service.GetAvailabilityCalendar(request);

            if (response != null && !response.ResponseType.success)
            {
                return BadRequest(response);
            }

            if (response != null)
            {
                return Ok(response);
            }

            return StatusCode(500, "An error occurred while processing your request.");
        }

    }
}
