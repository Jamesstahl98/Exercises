using DemoUnitTest3.Core.Helpers;
using DemoUnitTest3.Core.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnitTest3.Tests;

public class WeatherAnalyzerTests
{
    [Fact]
    public void GetTemperatureCategory_ColdTemperature_ReturnsCold()
    {
        var stubWeatherService = new Mock<IWeatherService>();
        stubWeatherService.Setup(ws => ws.GetCurrentTemperature("Moscow")).Returns(-5);
        var analyzer = new WeatherAnalyzer(stubWeatherService.Object);

        var category = analyzer.GetTemperatureCategory("Moscow");

        Assert.Equal("Cold", category);
    }
    [Fact]
    public void GetTemperatureCategory_HotTemperature_ReturnsHot()
    {
        var stubWeatherService = new Mock<IWeatherService>();
        stubWeatherService.Setup(ws => ws.GetCurrentTemperature("Dubai")).Returns(35);
        var analyzer = new WeatherAnalyzer(stubWeatherService.Object);

        var category = analyzer.GetTemperatureCategory("Dubai");

        Assert.Equal("Hot", category);
    }
    [Fact]
    public void GetTemperatureCategory_MildTemperature_ReturnsMild()
    {
        var stubWeatherService = new Mock<IWeatherService>();
        stubWeatherService.Setup(ws => ws.GetCurrentTemperature("San Francisco")).Returns(15);
        var analyzer = new WeatherAnalyzer(stubWeatherService.Object);

        var category = analyzer.GetTemperatureCategory("San Francisco");

        Assert.Equal("Mild", category);
    }
}
