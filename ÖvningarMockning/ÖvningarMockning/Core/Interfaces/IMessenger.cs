namespace ÖvningarMockning.Core.Interfaces
{
    public interface IMessenger
    {
        void SendMessage(string userId, string message);
    }
}
