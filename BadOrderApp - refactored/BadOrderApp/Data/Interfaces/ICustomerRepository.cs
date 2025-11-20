using BadOrderApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadOrderAppRefactored.Data.Interfaces
{
    public interface ICustomerRepository
    {
        void Add(Customer customer);
        Customer? GetById(int id);
        IEnumerable<Customer> GetAll();
    }
}
