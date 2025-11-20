using BadOrderApp.Data.Entities;
using BadOrderAppRefactored.Core.Interfaces;

namespace BadOrderAppRefactored.Core.Services
{
    public class SmsNotifier : INotifier
    {
        public void Notify(Customer customer, string message)
        {
            Console.WriteLine($"[SMS] Skickar till {customer.Email}: {message}");
        }
    }
}
