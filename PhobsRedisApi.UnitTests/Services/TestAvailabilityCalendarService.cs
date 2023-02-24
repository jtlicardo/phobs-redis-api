using Microsoft.Extensions.Configuration;
using Moq;
using PhobsRedisApi.Data;
using PhobsRedisApi.Dtos;
using PhobsRedisApi.Models;
using PhobsRedisApi.Services;
using PhobsRedisApi.Services.AvailabilityCalendar;
using System.Net;

namespace PhobsRedisApi.UnitTests.Services
{
    [TestFixture]
    public class TestAvailabilityCalendarService
    {
        private AvailabilityCalendarService _availabilityCalendarService;
        private Mock<IConfiguration> _configMock;
        private Mock<IXmlRpcUtilities> _utilsMock;

        [SetUp]
        public void SetUp()
        {
            _configMock = new Mock<IConfiguration>();
            _utilsMock = new Mock<IXmlRpcUtilities>();
            _availabilityCalendarService = new AvailabilityCalendarService(_utilsMock.Object, _configMock.Object);
        }

        [Test]
        public async Task GetAvailabilityCalendar_ReturnsResponseObject_WhenResponseIsSucessful()
        {
            // Arrange
            var request = new AvailabilityCalendarDto
            { 
                PropertyId = It.IsAny<string>(),
                StartDate = "2024-06-05",
                EndDate = "2024-06-15",
                ShowUnitDetails = It.IsAny<bool>(),
                Lang = It.IsAny<string>()
            };

            _utilsMock
                .Setup(x => x.SendHttpRequest(It.IsAny<string>(), It.IsAny<string>()))
                .ReturnsAsync(new HttpResponseMessage(HttpStatusCode.OK));

            _utilsMock
                .Setup(x => x.DeserializeXmlToObject<PCAvailabilityCalendarRS>(It.IsAny<string>()))
                .Returns(new PCAvailabilityCalendarRS());

            // Act
            var result = await _availabilityCalendarService.GetAvailabilityCalendar(request);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.InstanceOf<PCAvailabilityCalendarRS>());
        }

        [Test]
        public async Task GetAvailabilityCalendar_ReturnsNull_WhenResponseIsNotSucessful()
        {
            // Arrange
            var request = new AvailabilityCalendarDto
            {
                PropertyId = It.IsAny<string>(),
                StartDate = "2024-06-05",
                EndDate = "2024-06-15",
                ShowUnitDetails = It.IsAny<bool>(),
                Lang = It.IsAny<string>()
            };

            _utilsMock
                .Setup(x => x.SendHttpRequest(It.IsAny<string>(), It.IsAny<string>()))
                .ReturnsAsync(new HttpResponseMessage(HttpStatusCode.BadRequest));

            // Act
            var result = await _availabilityCalendarService.GetAvailabilityCalendar(request);

            // Assert
            Assert.That(result, Is.Null);
        }
    }
}
