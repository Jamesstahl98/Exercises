using Moq;
using ÖvningarMockning.Core.Services;
using ÖvningarMockning.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningarMockning.Tests;

public class UserServiceTests
{
    [Fact]
    public void IsAdmin_AdminUser_ShouldReturnTrue()
    {
        var userRepoMock = new Mock<IUserRepository>();
        userRepoMock.Setup(r => r.GetRole("admin123")).Returns("Admin");
        var userService = new UserService(userRepoMock.Object);

        var isAdmin = userService.IsAdmin("admin123");

        Assert.True(isAdmin);
    }

    [Fact]
    public void IsAdmin_RegularUser_ShouldReturnFalse()
    {
        var userRepoMock = new Mock<IUserRepository>();
        userRepoMock.Setup(r => r.GetRole("user456")).Returns("User");
        var userService = new UserService(userRepoMock.Object);

        var isAdmin = userService.IsAdmin("user456");
        Assert.False(isAdmin);
    }

    [Fact]
    public void IsAdmin_UnknownUser_ShouldReturnFalse()
    {
        var userRepoMock = new Mock<IUserRepository>();
        userRepoMock.Setup(r => r.GetRole(It.IsAny<string>())).Returns((string?)null);
        var userService = new UserService(userRepoMock.Object);
        var isAdmin = userService.IsAdmin("unknown789");
        Assert.False(isAdmin);
    }
}
