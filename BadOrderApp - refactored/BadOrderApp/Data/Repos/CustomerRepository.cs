using BadOrderApp.Data.Entities;
using BadOrderAppRefactored.Data.Interfaces;

//Simulerar kontakt med en databas för kunder
namespace BadOrderAppRefactored.Data.Repos
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly Dictionary<int, Customer> _customers = new();

        public void Add(Customer customer) => _customers[customer.Id] = customer;
        public Customer? GetById(int id) => _customers.TryGetValue(id, out var c) ? c : null;
        public IEnumerable<Customer> GetAll() => _customers.Values;
    }
}
