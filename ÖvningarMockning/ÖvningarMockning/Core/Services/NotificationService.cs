using ÖvningarMockning.Core.Interfaces;

namespace ÖvningarMockning.Core.Services
{
    public class NotificationService
    {
        private readonly IMessenger _messenger;

        public NotificationService(IMessenger messenger)
        {
            _messenger = messenger;
        }

        public void NotifyUser(string userId, string message)
        {
            if (string.IsNullOrWhiteSpace(message)) return;
            _messenger.SendMessage(userId, message);
        }
    }
}
