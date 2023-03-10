using Moq;
using PhobsRedisApi.Data;
using PhobsRedisApi.Dtos;
using PhobsRedisApi.PhobsModels;
using PhobsRedisApi.Services.PropertyData;

namespace PhobsRedisApi.UnitTests.Services
{
    [TestFixture]
    public class TestPropertyDataService
    {
        private PropertyDataService _propertyDataService;
        private Mock<IDataRepo> _repoMock;

        [SetUp]
        public void SetUp()
        {
            _repoMock = new Mock<IDataRepo>();
            _propertyDataService = new PropertyDataService(_repoMock.Object);
        }

        [Test]
        public async Task GetPropertyData_ReturnsResponseObject_WithValidDto()
        {
            // Arrange
            var request = new PropertyDataRequestDto
            {
                Property = "XXXXX", Adults = 2, Chd = 1, Pets = 0,
                Rate = "XXX", Date = "20240605", Nights = 1
            };

            _repoMock
                .Setup(x => x.GetData(It.IsAny<string>()))
                .Returns("100");

            // Act
            var result = await _propertyDataService.GetPropertyData(request);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.InstanceOf<PropertyDataResponseDto>());
        }
    }
}
