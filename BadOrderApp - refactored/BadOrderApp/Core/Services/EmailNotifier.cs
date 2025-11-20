using BadOrderApp.Data.Entities;
using BadOrderAppRefactored.Core.Interfaces;

namespace BadOrderAppRefactored.Core.Services
{
    public class EmailNotifier : INotifier
    {
        public void Notify(Customer customer, string message)
        {
            Console.WriteLine($"[Email] Skickar till {customer.Email}: {message}");
        }
    }
}
