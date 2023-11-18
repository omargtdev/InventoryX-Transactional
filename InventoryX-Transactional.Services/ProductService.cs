using AutoMapper;
using InventoryX_Transactional.Data.Models;
using InventoryX_Transactional.Repository;
using InventoryX_Transactional.Repository.Common;
using InventoryX_Transactional.Services.DTOs.Client;
using InventoryX_Transactional.Services.DTOs.Product;
using InventoryX_Transactional.Services.Exceptions;
using InventoryX_Transactional.Services.Validations;

namespace InventoryX_Transactional.Services;

public interface IProductService
{
    Task<List<ProductDTO>> GetProducts();
    Task<ProductDTO> GetProductById(int id);
    Task<ProductDTO> CreateProduct(NewProductDTO product);
    Task<ProductDTO> UpdateProduct(UpdateProductDTO product);
    Task DeleteProduct(int id);
}

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;
    private readonly ProductValidationService _validation;
    private readonly IMapper _mapper;

    public ProductService(IProductRepository repository, ProductValidationService validation, IMapper mapper)
    {
        _repository = repository;
        _validation = validation;
        _mapper = mapper;
    }

    public async Task<ProductDTO> CreateProduct(NewProductDTO request)
    {
        var productValidated = await _validation.ValidateForCreate(request);

        var product = new Product
        {
            Code = productValidated.Code,
            Name = productValidated.Name,
            Description = productValidated.Description,
            Brand = productValidated.Brand,
            Stock = 0,
            CategoryId = productValidated.CategoryId,
            WarehouseId = productValidated.WarehouseId,
            ProductPrice = new ProductPrice
            {
                LastIssuePrice = 0,
                LastReceiptPrice = 0,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "System"
            },
            CreatedAt = DateTime.UtcNow,
            CreatedBy = "System"
        };

        var productAdded = await _repository.AddAsync(product);
        await _repository.SaveAsync();

        return _mapper.Map<ProductDTO>(productAdded);
    }

    public async Task DeleteProduct(int id)
    {
        var response = _repository.Delete(id);
        if (response is RepositoryOperation.Failed)
            throw new ResourceNotFoundException("Product not found.");

        await _repository.SaveAsync();
    }

    public async Task<ProductDTO> GetProductById(int id)
    {
        var product = await _repository.GetByIdAsync(id);
        if(product is null)
            throw new ResourceNotFoundException($"Product with id {id} does not exist.");

        return _mapper.Map<ProductDTO>(product);
    }

    public async Task<List<ProductDTO>> GetProducts()
    {
        var products = await _repository.GetAll();
        return products.Select(p => _mapper.Map<ProductDTO>(p)).ToList();
    }

    public async Task<ProductDTO> UpdateProduct(UpdateProductDTO request)
    {
        var productValidated = await _validation.ValidateForUpdate(request);

        productValidated.Code = request.Code;
        productValidated.Name = request.Name;
        productValidated.Description = request.Description;
        productValidated.Brand = request.Brand;
        productValidated.CategoryId = request.CategoryId;
        productValidated.WarehouseId = request.WarehouseId;
        productValidated.ModifiedAt = DateTime.UtcNow;
        productValidated.ModifiedBy = "System";

        var productUpdated = _repository.Update(productValidated);
        await _repository.SaveAsync();

        return _mapper.Map<ProductDTO>(productUpdated);
    }
}
