using Microsoft.Extensions.Logging;
using Sample;
using Moq;

namespace SampleTest;

public class WeatherForecastTest
{
    [Fact]
    public void GetReturnsWeatherForecastArray()
    {
        var logger = new Mock<ILogger<Sample.Controllers.WeatherForecastController>>();
        var controller = new Sample.Controllers.WeatherForecastController(logger.Object);
        var expectedType = typeof(Sample.WeatherForecast[]);
        var actual = controller.Get();
        var actualType = actual.GetType();
        var actualFirst = actual.FirstOrDefault();

        Assert.True(actualFirst != null);
        Assert.True(typeof(DateTime) == actualFirst.Date.GetType());
        Assert.True(typeof(int) == actualFirst.TemperatureC.GetType());
        Assert.True(typeof(int) == actualFirst.TemperatureF.GetType());

        Assert.Equal(expectedType, actualType);
        Assert.True(expectedType == actualType);
    }
}
