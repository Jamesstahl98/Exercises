

using ÖvningarUnitTests.Core.Services;

namespace ÖvningarUnitTests.Tests;

public class ShippingServiceTests
{
    [Theory]
    [InlineData(1, "A", 60)]
    [InlineData(1, "B", 85)]
    [InlineData(1, "C", 120)]
    public void CalculateShippingCost_ReturnsCorrect(double weightKg, string zone, double expectedResult)
    {
        Assert.Equal(expectedResult, ShippingService.CalculateShippingCost(weightKg, zone));
    }
    [Fact]
    public void CalculateShippingCost_InvalidZone()
    {
        Assert.Throws<ArgumentException>(() => ShippingService.CalculateShippingCost(1, "D"));
    }
    [Fact]
    public void CalculateShippingCost_NegativeWeight()
    {
        Assert.Throws<ArgumentException>(() => ShippingService.CalculateShippingCost(-5, "A"));
    }
}
