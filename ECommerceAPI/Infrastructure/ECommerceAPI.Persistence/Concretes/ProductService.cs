using ECommerceAPI.Application.Abstractions;
using ECommerceAPI.Domain.Entities;

namespace ECommerceAPI.Persistence.Concretes;

public class ProductService : IProductService

{
    public List<Product> GetProducts() => new()
    {
        new()
        {
            Id = Guid.NewGuid(),
            Name = "Product 1 ",
            Price = 9000,
            Stock = 10,
        },
        new()
        {
            Id = Guid.NewGuid(),
            Name = "Product  2",
            Price = 9000,
            Stock = 10,
        },
        new()
        {
            Id = Guid.NewGuid(),
            Name = "Product 3 ",
            Price = 90000,
            Stock = 10,
        },
        new()
        {
            Id = Guid.NewGuid(),
            Name = "Product 4 ",
            Price = 9000,
            Stock = 10,
        }
    };
}