using ÖvningarUnitTests.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningarUnitTests.Tests;

public class GradeServiceTests
{
    [Fact]
    public void CalculateFinalGrade_PassingGrades_ReturnsPass()
    {
        var grades = new[] { 51, 51 };
        var finalGrade = GradeService.CalculateFinalGrade(grades, 51);
        Assert.Equal("Pass", finalGrade);
    }

    //Test is correct but GradeService implementation is wrong
    [Fact]
    public void CalculateFinalGrade_TooLowAssignmentPoints_ReturnsFail()
    {
        var grades = new[] { 1, 0 };
        var finalGrade = GradeService.CalculateFinalGrade(grades, 51);
        Assert.Equal("Fail", finalGrade);
    }

    [Fact]
    public void CalculateFinalGrade_ExamPointsTooHigh_ThrowsException()
    {
        var grades = new[] { 20, 20 };
        Assert.Throws<ArgumentException>(() => GradeService.CalculateFinalGrade(grades, 101));
    }
}
