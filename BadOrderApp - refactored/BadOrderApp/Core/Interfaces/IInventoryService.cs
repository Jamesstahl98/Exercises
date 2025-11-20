using BadOrderApp.Data.Entities;

namespace BadOrderAppRefactored.Core.Interfaces
{
    public interface IInventoryService
    {
        bool IsInStock(Product product) ;

        void ReduceStock(Product product, int quantity);

    }
}
