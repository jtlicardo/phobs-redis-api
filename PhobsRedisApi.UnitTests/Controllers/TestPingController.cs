using Microsoft.AspNetCore.Mvc;
using Moq;
using PhobsRedisApi.Controllers;
using PhobsRedisApi.Dtos;
using PhobsRedisApi.Models;
using PhobsRedisApi.Services.Ping;

namespace PhobsRedisApi.UnitTests.Controllers
{
    [TestFixture]
    public class TestPingController
    {
        private Mock<IPingService> _mockService;
        private PingController _controller;

        [SetUp]
        public void SetUp()
        {
            _mockService = new Mock<IPingService>();
            _controller = new PingController(_mockService.Object);
        }

        [Test]
        public async Task PingRemoteServer_ReturnsOk_WhenResponseIsNotNull()
        {
            // Arrange
            PingDto request = new PingDto();
            PCPingRS? response = new PCPingRS();
            _mockService.Setup(s => s.PingRemoteServer(request)).ReturnsAsync(response);

            // Act
            var result = await _controller.PingRemoteServer(request);

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result.Result);
        }

        [Test]
        public async Task PingRemoteServer_ReturnsBadRequest_WhenResponseIsNull()
        {
            // Arrange
            PingDto request = new PingDto();
            PCPingRS? response = null;
            _mockService.Setup(s => s.PingRemoteServer(request)).ReturnsAsync(response);

            // Act
            var result = await _controller.PingRemoteServer(request);

            // Assert
            Assert.IsInstanceOf<BadRequestResult>(result.Result);
        }

        [Test]
        public void GetCachedData_ReturnsOk_WhenDataIsFound()
        {
            // Arrange
            string key = "testKey";
            string data = "testData";
            _mockService.Setup(s => s.GetCachedData(key)).Returns(data);

            // Act
            var result = _controller.GetCachedData(key);

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result.Result);
        }

        [Test]
        public void GetCachedData_ReturnsNotFound_WhenDataIsNotFound()
        {
            // Arrange
            string key = "testKey";
            _mockService.Setup(s => s.GetCachedData(key)).Returns(null as string);

            // Act
            var result = _controller.GetCachedData(key);

            // Assert
            Assert.IsInstanceOf<NotFoundResult>(result.Result);
        }

    }
}