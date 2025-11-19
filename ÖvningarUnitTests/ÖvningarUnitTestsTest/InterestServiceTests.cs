using ÖvningarUnitTests.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ÖvningarUnitTests.Tests;

public class InterestServiceTests
{
    [Theory]
    [InlineData(1000, 5, 365, 50)]
    public void CalculateInterest_ReturnsCorrect(decimal balance, decimal rate, int days, decimal expected)
    {
        var result = InterestService.CalculateInterest(balance, rate, days);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CalculateInterest_NegativeBalance_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => InterestService.CalculateInterest(-1000, 5, 1));
    }

    [Fact]
    public void CalculateInterest_NegativeDays_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => InterestService.CalculateInterest(1000, 5, -1));
    }

    [Fact]
    public void CalculateInterest_ZeroDays_ReturnsBalance()
    {
        var result = InterestService.CalculateInterest(1000, 100, 0);
        Assert.Equal(0, result);
    }
}
