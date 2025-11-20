using BadOrderApp.Data.Entities;
using BadOrderAppRefactored.Core.Interfaces;
using BadOrderAppRefactored.Data.Interfaces;
using BadOrderAppRefactored.Data.Repos;

namespace BadOrderAppRefactored.Core.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repo;

        public CustomerService(ICustomerRepository repo)
        {
            _repo = repo;
        }

        public void Add(Customer customer)
        {
            _repo.Add(customer);
        }
    }
}
