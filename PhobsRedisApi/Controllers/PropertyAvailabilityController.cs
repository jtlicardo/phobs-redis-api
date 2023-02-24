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
            PCPropertyAvailabilityRS? response = await _service.GetPropertyAvailability(request);

            if (response != null)
            {
                return Ok(response);
            }
                
            return BadRequest();
        }

        [HttpGet]
        public ActionResult<string> GetCachedData([FromBody] string key)
        {
            string? data = _service.GetCachedData(key);

            if (data != null)
            {
                return Ok(data);
            }

            return NotFound();
        }
    }
}
