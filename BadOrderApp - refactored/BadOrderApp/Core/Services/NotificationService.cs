using BadOrderAppRefactored.Core.Interfaces;

namespace BadOrderApp.Core.Services
{
    public class NotificationService: INotificationService
    {
        public void Send(string type, string message, string email)
        {
            if (type == "email")
            {
                Console.WriteLine($"Skickar email till {email}: {message}");
            }
            else if (type == "sms")
            {
                Console.WriteLine($"Skickar SMS till {email}: {message}");
            }
            else
            {
                Console.WriteLine($"Okänd notifieringstyp: {type}");
            }
        }
    }
}
