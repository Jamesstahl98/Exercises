using BadOrderApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadOrderAppRefactored.Data.Interfaces
{
    public interface IOrderRepository
    {
        void Add(Order order);
        IEnumerable<Order> GetOrdersByCustomer(int customerId);
    }
}
