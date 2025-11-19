using Moq;
using ÖvningarMockning.Core.Interfaces;
using ÖvningarMockning.Core.Services;

namespace ÖvningarMockning.Tests;

public class NotificationServiceTests
{
    [Fact]
    public void SendMessage_ShouldSendNotification()
    {
        var messengerMock = new Mock<IMessenger>();
        var service = new NotificationService(messengerMock.Object);

        service.NotifyUser("user123", "Hello, User!");

        messengerMock.Verify(m => m.SendMessage("user123", "Hello, User!"), Times.Once);
    }

    [Fact]
    public void SendMessage_EmptyMessage_ShouldNotSendNotification()
    {
        var messengerMock = new Mock<IMessenger>();
        var service = new NotificationService(messengerMock.Object);

        service.NotifyUser("user123", "");

        messengerMock.Verify(m => m.SendMessage("user123", "Hello, User!"), Times.Never);
    }
}
