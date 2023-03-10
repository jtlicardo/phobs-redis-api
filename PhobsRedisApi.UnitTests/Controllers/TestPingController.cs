using Microsoft.AspNetCore.Mvc;
using Moq;
using PhobsRedisApi.Controllers;
using PhobsRedisApi.Dtos;
using PhobsRedisApi.PhobsModels;
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
    }
}