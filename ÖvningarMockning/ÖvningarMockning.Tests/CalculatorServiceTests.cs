using Moq;
using ÖvningarMockning.Core.Interfaces;
using ÖvningarMockning.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningarMockning.Tests;

public class CalculatorServiceTests
{
    [Fact]
    public void Add_ShouldReturnAndPrintCorrectSum()
    {
        var loggerMock = new Mock<ILogger>();
        var calculator = new CalculatorService(loggerMock.Object);

        var result = calculator.Add(2, 3);

        Assert.Equal(5, result);
        loggerMock.Verify(l => l.Log("Add: 2 + 3 = 5"), Times.Once);
    }
}
