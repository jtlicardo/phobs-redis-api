using Microsoft.AspNetCore.Mvc;
using Moq;
using PhobsRedisApi.Controllers;
using PhobsRedisApi.Dtos;
using PhobsRedisApi.Models;
using PhobsRedisApi.Services.PropertyAvailability;

namespace PhobsRedisApi.UnitTests.Controllers
{
    [TestFixture]
    public class TestPropertyAvailabilityController
    {
        private Mock<IPropertyAvailabilityService> _mockService;
        private PropertyAvailabilityController _controller;

        [SetUp]
        public void SetUp()
        {
            _mockService = new Mock<IPropertyAvailabilityService>();
            _controller = new PropertyAvailabilityController(_mockService.Object);
        }

        [Test]
        public async Task GetPropertyAvailability_ReturnsOk_WhenResponseIsNotNullAndNoErrors()
        {
            // Arrange
            PropertyAvailabilityDto request = new PropertyAvailabilityDto();
            PCPropertyAvailabilityRS? response = new PCPropertyAvailabilityRS();
            response.ResponseType = new PCPropertyAvailabilityRSResponseType();
            response.ResponseType.Errors = null;
            _mockService.Setup(s => s.GetPropertyAvailability(request)).ReturnsAsync(response);

            // Act
            var result = await _controller.GetPropertyAvailability(request);

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result.Result);
        }

        [Test]
        public async Task GetPropertyAvailability_ReturnsBadRequestObjectResult_WhenResponseIsNotNullAndHasErrors()
        {
            // Arrange
            PropertyAvailabilityDto request = new PropertyAvailabilityDto();
            PCPropertyAvailabilityRS? response = new PCPropertyAvailabilityRS();
            response.ResponseType = new PCPropertyAvailabilityRSResponseType();
            response.ResponseType.Errors = new PCPropertyAvailabilityRSResponseTypeError[0];
            _mockService.Setup(s => s.GetPropertyAvailability(request)).ReturnsAsync(response);

            // Act
            var result = await _controller.GetPropertyAvailability(request);

            // Assert
            Assert.IsInstanceOf<BadRequestObjectResult>(result.Result);
        }

        [Test]
        public async Task GetPropertyAvailability_ReturnsStatusCode500_WhenResponseIsNull()
        {
            // Arrange
            PropertyAvailabilityDto request = new PropertyAvailabilityDto();
            PCPropertyAvailabilityRS? response = null;
            _mockService.Setup(s => s.GetPropertyAvailability(request)).ReturnsAsync(response);

            // Act
            var result = await _controller.GetPropertyAvailability(request);

            // Assert
            Assert.That(result.Result, Is.InstanceOf<ObjectResult>().And.Property("StatusCode").EqualTo(500));
        }

        [Test]
        public async Task GetPropertyAvailability_ReturnsBadRequestObjectResult_WhenModelStateIsInvalid()
        {
            // Arrange
            PropertyAvailabilityDto request = new PropertyAvailabilityDto();
            _controller.ModelState.AddModelError("Date", "Date is not a valid date");

            // Act
            var result = await _controller.GetPropertyAvailability(request);

            // Assert
            Assert.IsInstanceOf<BadRequestObjectResult>(result.Result);
        }
    }
}
