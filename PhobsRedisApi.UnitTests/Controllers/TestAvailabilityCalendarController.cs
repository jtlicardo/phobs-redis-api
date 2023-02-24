using Microsoft.AspNetCore.Mvc;
using Moq;
using PhobsRedisApi.Controllers;
using PhobsRedisApi.Dtos;
using PhobsRedisApi.Models;
using PhobsRedisApi.Services.AvailabilityCalendar;

namespace PhobsRedisApi.UnitTests.Controllers
{
    [TestFixture]
    public class TestAvailabilityCalendarController
    {
        private Mock<IAvailabilityCalendarService> _mockService;
        private AvailabilityCalendarController _controller;

        [SetUp]
        public void SetUp()
        {
            _mockService = new Mock<IAvailabilityCalendarService>();
            _controller = new AvailabilityCalendarController(_mockService.Object);
        }

        [Test]
        public async Task GetAvailabilityCalendar_ReturnsOk_WhenResponseIsNotNull()
        {
            // Arrange
            AvailabilityCalendarDto request = new AvailabilityCalendarDto();
            PCAvailabilityCalendarRS? response = new PCAvailabilityCalendarRS();
            _mockService.Setup(s => s.GetAvailabilityCalendar(request)).ReturnsAsync(response);

            // Act
            var result = await _controller.GetAvailabilityCalendar(request);

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result.Result);
        }

        [Test]
        public async Task GetAvailabilityCalendar_ReturnsBadRequest_WhenResponseIsNull()
        {
            // Arrange
            AvailabilityCalendarDto request = new AvailabilityCalendarDto();
            PCAvailabilityCalendarRS? response = null;
            _mockService.Setup(s => s.GetAvailabilityCalendar(request)).ReturnsAsync(response);

            // Act
            var result = await _controller.GetAvailabilityCalendar(request);

            // Assert
            Assert.IsInstanceOf<BadRequestResult>(result.Result);
        }

        [Test]
        public async Task GetAvailabilityCalendar_ReturnsBadRequestObjectResult_WhenModelStateIsInvalid()
        {
            // Arrange
            AvailabilityCalendarDto request = new AvailabilityCalendarDto();
            _controller.ModelState.AddModelError("StartDate", "StartDate is not a valid date");

            // Act
            var result = await _controller.GetAvailabilityCalendar(request);

            // Assert
            Assert.IsInstanceOf<BadRequestObjectResult>(result.Result);
        }
    }
}
