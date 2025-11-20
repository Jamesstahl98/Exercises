using BadOrderApp.Data.Entities;
using BadOrderAppRefactored.Core.Interfaces;
using BadOrderAppRefactored.Data.Interfaces;
using BadOrderAppRefactored.Data.Repos;

namespace BadOrderApp.Core.Services
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IInventoryService _inventory;
        private readonly IDiscountService _discountService;
        private readonly IEnumerable<INotifier> _notifiers;
        private readonly ILogger _logger;

        public OrderService(IOrderRepository orderRepository,
                            IInventoryService inventory,
                            IDiscountService discountService,
                            IEnumerable<INotifier> notifiers,
                            ILogger logger)
        {
            
            _orderRepository = orderRepository;
            _inventory = inventory;
            _discountService = discountService;
            _notifiers = notifiers;
            _logger = logger;
        }

       

        public void PlaceOrder(Customer customer, List<Product> products, string? promoCode = null)
        {
            if (!ValidateOrder(products)) return;

            double total = CalculateTotal(products, promoCode, customer);
            
            ReduceStock(products);

            var order = new Order
            {
                Customer = customer,
                Products = products,
                Total = total,
                PromoCode = promoCode
            };
            _orderRepository.Add(order);

            NotifyCustomer(customer, total);
            _logger.Log($"Order för {customer.Name} lagrad med total {total}.");
        }

        private bool ValidateOrder(List<Product> products)
        {
            if (products == null || !products.Any())
            {
                Console.WriteLine("Ingen produkt vald.");
                return false;
            }

            foreach (var product in products)
            {
                if (!_inventory.IsInStock(product))
                {
                    Console.WriteLine($"Produkten {product.Name} är slut i lager!");
                    return false;
                }
            }
            return true;
        }

        private double CalculateTotal(List<Product> products, string? promoCode, Customer customer)
        {
            double total = products.Sum(p => p.Price);
            double discount = _discountService.CalculateTotalDiscount(total, promoCode, customer);
            total -= total * discount;

            return total;
        }

        private void ReduceStock(List<Product> products)
        {
            foreach (var product in products)
                _inventory.ReduceStock(product,1);
        }

        private void NotifyCustomer(Customer customer, double total)
        {
            string message = $"Din order på {total} har mottagits.";
            foreach (var notifier in _notifiers)
                notifier.Notify(customer, message);
        }
    }
}
