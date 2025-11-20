using BadOrderApp.Data.Entities;
using BadOrderAppRefactored.Data.Interfaces;

namespace BadOrderAppRefactored.Data.Repos
{
    //Simulerar kontakt med en databas för ordrar
    public class OrderRepository : IOrderRepository
    {
        private readonly List<Order> _orders = new();
        private int _nextId = 1;

        public void Add(Order order)
        {
            order.Id = _nextId++;
            _orders.Add(order);
        }

        public IEnumerable<Order> GetOrdersByCustomer(int customerId)
            => _orders.Where(o => o.Customer.Id == customerId);
    }
}
