using Microsoft.AspNetCore.Mvc;
using PhobsRedisApi.Dtos;
using PhobsRedisApi.Models;
using PhobsRedisApi.Services.PropertyAvailability;

namespace PhobsRedisApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PropertyAvailabilityController : ControllerBase
    {
        private readonly IPropertyAvailabilityService _service;

        public PropertyAvailabilityController(IPropertyAvailabilityService service)
        {
            _service = service;
        }

        [HttpPost]
        async public Task<ActionResult<PCPropertyAvailabilityRS>> GetPropertyAvailability(
            [FromBody] PropertyAvailabilityDto request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            PCPropertyAvailabilityRS? response = await _service.GetPropertyAvailability(request);

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
