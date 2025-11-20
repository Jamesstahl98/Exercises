using BadOrderAppRefactored.Core.Interfaces;

namespace BadOrderApp.Core.Services
{
    public class ConsoleLogger:ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"LOG: {message}");
        }
    }
}
