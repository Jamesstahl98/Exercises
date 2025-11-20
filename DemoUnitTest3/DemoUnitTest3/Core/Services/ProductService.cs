using DemoUnitTest3.Data.Entities;
using DemoUnitTest3.Data.Interfaces;

namespace DemoUnitTest3.Core.Services
{
    public class ProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public Product CreateProduct(string name)
        {
            var product = new Product { Id = new Random().Next(1, 100000), Name = name };
            _repository.Add(product);
            return product;
        }

        public Product FindProduct(int id)
        {
            return _repository.GetById(id);
        }
    }
}
