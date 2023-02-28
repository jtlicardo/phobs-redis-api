
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using PhobsRedisApi.Controllers;
using PhobsRedisApi.Dtos;
using PhobsRedisApi.Models;
using PhobsRedisApi.Services.PropertyData;

namespace PhobsRedisApi.UnitTests.Controllers
{
    [TestFixture]
    public class TestPropertyDataController
    {
        private Mock<IPropertyDataService> _mockService;
        private PropertyDataController _controller;

        [SetUp]
        public void SetUp()
        {
            _mockService = new Mock<IPropertyDataService>();
            _controller = new PropertyDataController(_mockService.Object);
        }

        [Test]
        public async Task GetPropertyData_ReturnsOkObjectResult_WithValidDto()
        {
            // Arrange
            GetPropertyDataDto request = new GetPropertyDataDto
            {
                Property = "XXXX", Adults = 2, Chd = 1, Pets = 0,
                Rate = "ABC", Date = "yyyyMMdd", Nights = 5
            };
            PropertyDataRS response = new PropertyDataRS
            {
                PropertyId = "XXXX", MinPricePerDay = 123.12f, Availability = true
            };
            _mockService.Setup(s => s.GetPropertyData(request)).ReturnsAsync(response);

            // Act
            var result = await _controller.GetPropertyData(request);

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result.Result);
            Assert.IsInstanceOf<PropertyDataRS>(((OkObjectResult)result.Result).Value);
        }
    }
}
