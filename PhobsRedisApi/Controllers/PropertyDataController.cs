﻿using Microsoft.AspNetCore.Mvc;
using PhobsRedisApi.Dtos;
using PhobsRedisApi.Models;
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
        async public Task<ActionResult<PropertyDataRS>> GetPropertyData([FromQuery] GetPropertyDataDto request)
        {
            PropertyDataRS? response = await _service.GetPropertyData(request);

            if (response != null)
            {
                return Ok(response);
            }

            return StatusCode(500, "An error occurred while processing your request.");
        }
    }
}
