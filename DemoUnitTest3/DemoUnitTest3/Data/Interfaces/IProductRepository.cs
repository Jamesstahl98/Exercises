using DemoUnitTest3.Data.Entities;

namespace DemoUnitTest3.Data.Interfaces
{
    public interface IProductRepository
    {
        void Add(Product product);
        Product GetById(int id);
    }
}
