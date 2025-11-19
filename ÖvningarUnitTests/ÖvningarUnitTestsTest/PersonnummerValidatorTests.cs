using ÖvningarUnitTests.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningarUnitTests.Tests;

public class PersonnummerValidatorTests
{
    [Fact]
    public void IsValidPersonnummer_ValidNumber_ReturnsTrue()
    {
        var result = PersonnummerValidator.IsValidSwedishPersonnummer("198507099805");
        Assert.True(result);
    }

    [Fact]
    public void IsValidPersonnummer_InvalidNumber_ReturnsFalse()
    {
        var result = PersonnummerValidator.IsValidSwedishPersonnummer("198507559805");
        Assert.False(result);
    }

    [Fact]
    public void IsValidPersonnummer_WrongLength_ReturnsFalse()
    {
        var result = PersonnummerValidator.IsValidSwedishPersonnummer("8507099805");
        Assert.False(result);
    }

    [Fact]
    public void IsValidPersonnummer_ContainsLetters_ReturnsFalse()
    {
        var result = PersonnummerValidator.IsValidSwedishPersonnummer("a198507099805");
        Assert.False(result);
    }

    [Fact]
    public void IsValidPersonnummer_LuhnAlgorithmFail_ReturnsFalse()
    {
        var result = PersonnummerValidator.IsValidSwedishPersonnummer("198507098905");
        Assert.False(result);
    }
}
