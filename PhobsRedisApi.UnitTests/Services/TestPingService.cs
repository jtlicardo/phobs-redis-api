using Moq;
using PhobsRedisApi.Data;
using PhobsRedisApi.Services.Ping;
using PhobsRedisApi.Services;
using Microsoft.Extensions.Configuration;
using PhobsRedisApi.Dtos;
using PhobsRedisApi.PhobsModels;
using System.Net;

namespace PhobsRedisApi.UnitTests.Services
{
    [TestFixture]
    public class TestPingService
    {
        private PingService _pingService;
        private Mock<IConfiguration> _configMock;
        private Mock<IXmlRpcUtilities> _utilsMock;
        private Mock<IDataRepo> _repoMock;

        [SetUp]
        public void SetUp()
        {
            _configMock = new Mock<IConfiguration>();
            _utilsMock = new Mock<IXmlRpcUtilities>();
            _repoMock = new Mock<IDataRepo>();
            _pingService = new PingService(_configMock.Object, _utilsMock.Object, _repoMock.Object);
        }

        [Test]
        public async Task PingRemoteServer_ReturnsResponseObject_WhenResponseIsSucessful()
        {
            // Arrange
            var request = new PingDto();

            _utilsMock
                .Setup(x => x.SendHttpRequest(It.IsAny<string>(), It.IsAny<string>()))
                .ReturnsAsync(new HttpResponseMessage(HttpStatusCode.OK));

            _utilsMock
                .Setup(x => x.DeserializeXmlToObject<PCPingRS>(It.IsAny<string>()))
                .Returns(new PCPingRS());

            // Act
            var result = await _pingService.PingRemoteServer(request);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.InstanceOf<PCPingRS>());
        }

        [Test]
        public async Task PingRemoteServer_ReturnsNull_WhenResponseIsNotSucessful()
        {
            // Arrange
            var request = new PingDto();

            _utilsMock
                .Setup(x => x.SendHttpRequest(It.IsAny<string>(), It.IsAny<string>()))
                .ReturnsAsync(new HttpResponseMessage(HttpStatusCode.BadRequest));

            // Act
            var result = await _pingService.PingRemoteServer(request);

            // Assert
            Assert.That(result, Is.Null);
        }
    }
}
