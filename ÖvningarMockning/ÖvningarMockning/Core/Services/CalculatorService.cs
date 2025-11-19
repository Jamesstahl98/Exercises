using ÖvningarMockning.Core.Interfaces;

namespace ÖvningarMockning.Core.Services
{
    public class CalculatorService
    {
        private readonly ILogger _logger;

        public CalculatorService(ILogger logger)
        {
            _logger = logger;
        }

        public int Add(int a, int b)
        {
            int result = a + b;
            _logger.Log($"Add: {a} + {b} = {result}");
            return result;
        }
    }
}
