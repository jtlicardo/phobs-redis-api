using Microsoft.AspNetCore.Mvc;
using PhobsRedisApi.Dtos;
using PhobsRedisApi.Services.PropertyData;

namespace PhobsRedisApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PropertyDataController : Controller
    {
        private readonly IPropertyDataService _service;

        public PropertyDataController(IPropertyDataService service)
        {
            _service = service;
        }

        [HttpGet]
        async public Task<ActionResult<PropertyDataResponseDto>> GetPropertyData([FromQuery] PropertyDataRequestDto request)
        {
            PropertyDataResponseDto response = await _service.GetPropertyData(request);
            return Ok(response);
        }
    }
}
