using BadOrderApp.Core.Services;
using BadOrderApp.Data.Entities;
using BadOrderAppRefactored.Core.Interfaces;
using BadOrderAppRefactored.Core.Services;
using BadOrderAppRefactored.Data.Interfaces;
using BadOrderAppRefactored.Data.Repos;

//Förbättringar i refaktorerad version
//SRP: OrderService hanterar endast affärslogik. Notifiering, rabatt, lager och loggning är
//separerade.
//OCP: Lätt att lägga till nya notifieringstyper utan att ändra OrderService.
//DIP: OrderService använder interfaces och DI för notifiering, loggning och repositories.
//Clean Code: Kortare metoder, tydliga namn, separation av ansvar.
//Testbarhet: Varje komponent kan testas isolerat (mock notifier, mock repository mm).

namespace BadOrderApp
{
    class Program
    {
        static void Main()
        {
            //Detta funkar som vår DI container. Lite svårt att få till allt helt korrekt :-)
            ICustomerRepository customerRepo = new CustomerRepository();
            IOrderRepository orderRepo = new OrderRepository();
            IInventoryService inventory = new InventoryService();
            IDiscountService discountService = new DiscountService();
            ILogger logger = new ConsoleLogger();

            try
            {
                List<INotifier> notifiers = new List<INotifier>
                {
                    new SmsNotifier()
                };

                var orderService = new OrderService(orderRepo, inventory, discountService, notifiers, logger);

                // Skapa customer och produkter
                var customer = new Customer { Id = 1, Name = "Anna", Email = "anna@example.com", IsVip = true };
                var customerService = new CustomerService(customerRepo);
                customerService.Add(customer);

                var product1 = new Product { Id = 1, Name = "Laptop", Price = 1000, Stock = 5 };
                var product2 = new Product { Id = 2, Name = "Mouse", Price = 50, Stock = 10 };

                // Skapa order
                orderService.PlaceOrder(customer, new List<Product> { product1, product2 }, "SUMMER10");
            
            }
            catch (Exception ex)
            {
                // Skriver till loggen här 
                logger.Log($"Order skapades inte.Något gick fel (simulerat).-{ex.Message}");
            }
        }
    
    }
}

