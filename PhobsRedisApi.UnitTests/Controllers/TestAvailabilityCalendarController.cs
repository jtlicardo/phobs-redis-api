using Microsoft.AspNetCore.Mvc;
using Moq;
using PhobsRedisApi.Controllers;
using PhobsRedisApi.Dtos;
using PhobsRedisApi.PhobsModels;
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
        public async Task GetAvailabilityCalendar_ReturnsOk_WhenResponseIsNotNullAndNoErrors()
        {
            // Arrange
            AvailabilityCalendarDto request = new AvailabilityCalendarDto();
            PCAvailabilityCalendarRS? response = new PCAvailabilityCalendarRS();
            response.ResponseType = new PCAvailabilityCalendarRSResponseType();
            response.ResponseType.Errors = null;
            _mockService.Setup(s => s.GetAvailabilityCalendar(request)).ReturnsAsync(response);

            // Act
            var result = await _controller.GetAvailabilityCalendar(request);

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result.Result);
        }

        [Test]
        public async Task GetAvailabilityCalendar_ReturnsBadRequestObjectResult_WhenResponseIsNotNullAndHasErrors()
        {
            // Arrange
            AvailabilityCalendarDto request = new AvailabilityCalendarDto();
            PCAvailabilityCalendarRS? response = new PCAvailabilityCalendarRS();
            response.ResponseType = new PCAvailabilityCalendarRSResponseType();
            response.ResponseType.Errors = new PCAvailabilityCalendarRSResponseTypeError[0];
            _mockService.Setup(s => s.GetAvailabilityCalendar(request)).ReturnsAsync(response);

            // Act
            var result = await _controller.GetAvailabilityCalendar(request);

            // Assert
            Assert.IsInstanceOf<BadRequestObjectResult>(result.Result);
        }

        [Test]
        public async Task GetAvailabilityCalendar_ReturnsStatusCode500_WhenResponseIsNull()
        {
            // Arrange
            AvailabilityCalendarDto request = new AvailabilityCalendarDto();
            PCAvailabilityCalendarRS? response = null;
            _mockService.Setup(s => s.GetAvailabilityCalendar(request)).ReturnsAsync(response);

            // Act
            var result = await _controller.GetAvailabilityCalendar(request);

            // Assert
            Assert.That(result.Result, Is.InstanceOf<ObjectResult>().And.Property("StatusCode").EqualTo(500));
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
