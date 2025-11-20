using DemoUnitTest3.Core.Services;
using DemoUnitTest3.Data.Entities;
using DemoUnitTest3.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnitTest3.Tests;

public class ProductServiceTests
{
    [Fact]
    public void FindProduct_ProductExists_ReturnsProduct()
    {
        var fakeRepository = new FakeProductRepository();
        var product = new Product { Id = 1, Name = "Test Product" };
        fakeRepository.Add(product);

        var productService = new ProductService(fakeRepository);
        var result = productService.FindProduct(1);
        Assert.NotNull(result);
        Assert.Equal("Test Product", result.Name);
    }
}

public class FakeProductRepository : IProductRepository
{
    private readonly List<Product> _products = new List<Product>();

    public void Add(Product product)
    {
        _products.Add(product);
    }

    public Product GetById(int id)
    {
        return _products.FirstOrDefault(p => p.Id == id);
    }
}