using OpenWeatherAPI;
using System;
using System.Threading.Tasks;
using Xunit;

namespace OpenWeatherAPITests
{
    public class OpenWeatherProcessorTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public async Task GetOneCallAsync_IfApiKeyEmptyOrNull_ThrowArgumentException(string str)
        {
            OpenWeatherProcessor openWeatherProcessor = OpenWeatherProcessor.Instance;

            openWeatherProcessor.ApiKey = str;

            await Assert.ThrowsAsync<ArgumentException>(openWeatherProcessor.GetOneCallAsync);
        }
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public async Task GetCurrentWeatherAsync_IfApiKeyEmptyOrNull_ThrowArgumentException(string str)
        {
            OpenWeatherProcessor openWeatherProcessor = OpenWeatherProcessor.Instance;

            openWeatherProcessor.ApiKey = str;

            await Assert.ThrowsAsync<ArgumentException>(openWeatherProcessor.GetCurrentWeatherAsync);
        }
        [Fact]
        public async Task GetOneCallAsync_IfApiHelperIsNotInitialized_ThrowArgumentException()
        {
            OpenWeatherProcessor openWeatherProcessor = OpenWeatherProcessor.Instance;

            await Assert.ThrowsAsync<ArgumentException>(openWeatherProcessor.GetOneCallAsync);
        }
        [Fact]
        public async Task GetCurrentWeatherAsync_IfApiHelperIsNotInitialized_ThrowArgumentException()
        {
            OpenWeatherProcessor openWeatherProcessor = OpenWeatherProcessor.Instance;

            await Assert.ThrowsAsync<ArgumentException>(openWeatherProcessor.GetCurrentWeatherAsync);
        }
    }
}
