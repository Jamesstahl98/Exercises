using ÖvningarUnitTests.Core.Services;

namespace ÖvningarUnitTests.Tests;

public class DiscountServiceTests
{
    [Fact]
    public void CalculateDiscountedPrice_Membership()
    {
        Assert.Equal(90, DiscountService.CalculateDiscountedPrice(100, 30, true));
    }

    [Fact]
    public void CalculateDiscountedPrice_SeniorWithMembership()
    {
        Assert.Equal(85, DiscountService.CalculateDiscountedPrice(100, 65, true));
    }

    [Fact]
    public void CalculateDiscountedPrice_SeniorWithNoMembership()
    {
        Assert.Equal(95, DiscountService.CalculateDiscountedPrice(100, 65, false));
    }

    [Fact]
    public void CalculateDiscountedPrice_NegativePrice()
    {
        Assert.Throws<ArgumentException>(() => DiscountService.CalculateDiscountedPrice(-50, 30, false));
    }

    [Fact]
    public void CalculateDiscountedPrice_NoDiscount()
    {
        Assert.Equal(100, DiscountService.CalculateDiscountedPrice(100, 30, false));
    }

    [Fact]
    public void CalculateDiscountedPrice_RoundPrice()
    {
        Assert.Equal(100, DiscountService.CalculateDiscountedPrice(111, 30, true));
    }
}
