using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadOrderApp.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; } = new Customer();
        public List<Product> Products { get; set; } = new List<Product>();
        public double Total { get; set; }
        public string? PromoCode { get; set; }
    }
}
