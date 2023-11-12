using InventoryX_Transactional.Data.Models;
using InventoryX_Transactional.Repository.Common;
using InventoryX_Transactional.Services.DTOs.Client;
using InventoryX_Transactional.Services.DTOs.Product;

namespace InventoryX_Transactional.Services;

public interface IProductService
{
    Task<List<ProductDTO>> GetProducts();
    Task<ProductDTO> GetProductById(int id);
    Task<ProductDTO> CreateProduct(NewClientDTO client);
    Task<ProductDTO> UpdateProduct(UpdateClientDTO client);
    Task DeleteProduct(int id);
}

public class ProductService : IProductService
{
    private readonly IGenericRepository<Product> _repository;

    public ProductService(IGenericRepository<Product> repository)
    {
        _repository = repository;
    }

    public Task<ProductDTO> CreateProduct(NewClientDTO client)
    {
        throw new NotImplementedException();
    }

    public Task DeleteProduct(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ProductDTO> GetProductById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<ProductDTO>> GetProducts()
    {
        throw new NotImplementedException();
    }

    public Task<ProductDTO> UpdateProduct(UpdateClientDTO client)
    {
        throw new NotImplementedException();
    }
}
