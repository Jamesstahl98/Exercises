using BadOrderApp.Data.Entities;
using BadOrderAppRefactored.Core.Interfaces;

namespace BadOrderApp.Core.Services
{
    public class InventoryService: IInventoryService
    {
        public bool IsInStock(Product product) => product.Stock > 0;

        public void ReduceStock(Product product, int quantity = 1)
        {
            if (product.Stock >= quantity)
                product.Stock -= quantity;
        }
    }
}
