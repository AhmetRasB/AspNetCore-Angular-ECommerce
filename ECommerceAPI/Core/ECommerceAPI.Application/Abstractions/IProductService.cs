using ECommerceAPI.Domain.Entities;

namespace ECommerceAPI.Application.Abstractions;

public interface IProductService
{
    List<Product> GetProducts();
}