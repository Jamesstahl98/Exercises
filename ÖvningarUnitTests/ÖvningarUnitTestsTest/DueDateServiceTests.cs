using ÖvningarUnitTests.Core.Services;

namespace ÖvningarUnitTests.Tests;

public class DueDateServiceTests
{
    [Fact]
    public void DaysUntilDue_FutureDate()
    {
        var today = new DateTime(2024, 6, 1);
        var dueDate = new DateTime(2024, 6, 10);
        var days = DueDateService.DaysUntilDue(dueDate, today);
        Assert.Equal(9, days);
    }

    [Fact]
    public void DaysUntilDue_Today()
    {
        var today = new DateTime(2024, 6, 1);
        var dueDate = new DateTime(2024, 6, 1);
        var days = DueDateService.DaysUntilDue(dueDate, today);
        Assert.Equal(0, days);
    }

    [Fact]
    public void DaysUntilDue_PastDate()
    {
        var today = new DateTime(2024, 6, 5);
        var dueDate = new DateTime(2024, 6, 1);
        var days = DueDateService.DaysUntilDue(dueDate, today);
        Assert.Equal(0, days);
    }
}
