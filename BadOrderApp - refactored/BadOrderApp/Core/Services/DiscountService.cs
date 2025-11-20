using BadOrderApp.Data.Entities;
using BadOrderAppRefactored.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadOrderApp.Core.Services
{
    public class DiscountService:IDiscountService
    {
        public double CalculateTotalDiscount(double total, string? promoCode, Customer customer)
        {
            double discount = 0;

            if (total > 500) discount += 0.1;
            if (promoCode == "SUMMER10") discount += 0.1;
            else if (promoCode == "VIP20" && customer.IsVip) discount += 0.2;

            return discount > 0.5 ? 0.5 : discount;
        }
    }
}
