using Microsoft.Extensions.Configuration;
using Moq;
using PhobsRedisApi.Dtos;
using PhobsRedisApi.Models;
using PhobsRedisApi.Services;
using PhobsRedisApi.Services.PropertyAvailability;
using System.Net;

namespace PhobsRedisApi.UnitTests.Services
{
    [TestFixture]
    public class TestPropertyAvailabilityService
    {
        private PropertyAvailabilityService _propertyAvailabilityService;
        private Mock<IConfiguration> _configMock;
        private Mock<IXmlRpcUtilities> _utilsMock;

        [SetUp]
        public void SetUp()
        {
            _configMock = new Mock<IConfiguration>();
            _utilsMock = new Mock<IXmlRpcUtilities>();
            _propertyAvailabilityService = new PropertyAvailabilityService(_utilsMock.Object, _configMock.Object);
        }

        [Test]
        public async Task GetPropertyAvailability_ReturnsResponseObject_WhenResponseIsSucessful()
        {
            // Arrange
            var request = new PropertyAvailabilityDto
            {
                Date = "2024-06-05"
            };

            _utilsMock
                .Setup(x => x.SendHttpRequest(It.IsAny<string>(), It.IsAny<string>()))
                .ReturnsAsync(new HttpResponseMessage(HttpStatusCode.OK));

            _utilsMock
                .Setup(x => x.DeserializeXmlToObject<PCPropertyAvailabilityRS>(It.IsAny<string>()))
                .Returns(new PCPropertyAvailabilityRS());

            // Act
            var result = await _propertyAvailabilityService.GetPropertyAvailability(request);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.InstanceOf<PCPropertyAvailabilityRS>());
        }

        [Test]
        public async Task GetPropertyAvailability_ReturnsNull_WhenResponseIsNotSuccessful()
        {
            // Arrange
            var request = new PropertyAvailabilityDto
            {
                Date = "2024-06-05"
            };

            _utilsMock
                .Setup(x => x.SendHttpRequest(It.IsAny<string>(), It.IsAny<string>()))
                .ReturnsAsync(new HttpResponseMessage(HttpStatusCode.BadRequest));

            // Act
            var result = await _propertyAvailabilityService.GetPropertyAvailability(request);

            // Assert
            Assert.That(result, Is.Null);
        }


    }
}
