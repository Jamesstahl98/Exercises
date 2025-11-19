using Moq;
using ÖvningarMockning.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningarMockning.Tests;

public class WeatherServiceTests
{
    [Theory]
    [InlineData("Stockholm", 15.0)]
    [InlineData("Gothenburg", 18.5)]
    public void GetWeatherForecast_ShouldReturnForecast(string city, double temperature)
    {
        var weatherMock = new Mock<IWeatherApiClient>();
        weatherMock.Setup(w => w.GetTemperature(city, DateTime.Today)).Returns(temperature);
        var service = new WeatherService(weatherMock.Object);

        var forecast = service.GetTodaysTemperature(city);

        Assert.Equal(temperature, forecast);
    }

    [Fact]
    public void GetWeatherForecast_UnknownCity_ShouldThrowHttpException()
    {
        var weatherMock = new Mock<IWeatherApiClient>();
        weatherMock.Setup(w => w.GetTemperature("UnknownCity", DateTime.Today))
                   .Throws(new HttpRequestException("City not found", null, System.Net.HttpStatusCode.NotFound));
        var service = new WeatherService(weatherMock.Object);
        Assert.Throws<HttpRequestException>(() => service.GetTodaysTemperature("UnknownCity"));
    }
}
