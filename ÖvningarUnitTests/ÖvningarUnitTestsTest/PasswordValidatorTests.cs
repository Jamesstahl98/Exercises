using ÖvningarUnitTests.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningarUnitTests.Tests;

public class PasswordValidatorTests
{
    [Fact]
    public void IsStrongPassword_StrongPassword_ReturnsTrue()
    {
        var result = PasswordValidator.IsStrongPassword("Str0ngP@ssw0rd!");
        Assert.True(result);
    }

    [Fact]
    public void IsStrongPassword_NoSpecialCharacter_ReturnsFalse()
    {
        var result = PasswordValidator.IsStrongPassword("Str0ngPassw0rd");
        Assert.False(result);
    }

    [Fact]
    public void IsStrongPassword_NoNumber_ReturnsFalse()
    {
        var result = PasswordValidator.IsStrongPassword("StrongPassword!");
        Assert.False(result);
    }

    [Fact]
    public void IsStrongPassword_LessThanEightCharacters_ReturnsFalse()
    {
        var result = PasswordValidator.IsStrongPassword("Passw0!");
        Assert.False(result);
    }

    [Fact]
    public void IsStrongPassword_Null_ReturnsFalse()
    {
        var result = PasswordValidator.IsStrongPassword(null);
        Assert.False(result);
    }

    [Fact]
    public void IsStrongPassword_OnlySpecialCharacters_ReturnsFalse()
    {
        var result = PasswordValidator.IsStrongPassword("#!¤%&/()=?^^**");
        Assert.False(result);
    }
}
