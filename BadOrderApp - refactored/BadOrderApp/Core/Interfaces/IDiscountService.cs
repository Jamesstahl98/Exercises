using BadOrderApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadOrderAppRefactored.Core.Interfaces
{
    public interface IDiscountService
    {
        double CalculateTotalDiscount(double total, string? promoCode, Customer customer);
    }
}
