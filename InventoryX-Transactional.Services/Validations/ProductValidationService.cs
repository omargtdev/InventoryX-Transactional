﻿using AutoMapper;
using InventoryX_Transactional.Data.Models;
using InventoryX_Transactional.Extensions;
using InventoryX_Transactional.Repository.Common;
using InventoryX_Transactional.Services.DTOs.Receipt;
using InventoryX_Transactional.Services.Exceptions;

namespace InventoryX_Transactional.Services.Validations;

public class ProductValidationService
{
    private readonly IGenericRepository<Product> _productRepository;
    private readonly IGenericRepository<Category> _categoryRepository;
    private readonly IGenericRepository<Warehouse> _warehouseRepository;
    private readonly IMapper _mapper;

    public ProductValidationService(
        IGenericRepository<Product> productRepository,
        IGenericRepository<Category> categoryRepository,
        IGenericRepository<Warehouse> warehouseRepository,
        IMapper mapper)
    {
        _productRepository = productRepository;
        _categoryRepository = categoryRepository;
        _warehouseRepository = warehouseRepository;
        _mapper = mapper;
    }

    public async Task<NewProductDTO> ValidateForCreate(NewProductDTO product)
    {
        if(product.Name.IsLessThan3Characters())
            throw new EntityRuleException("Invalid name for product.");

        var productFound = (await _productRepository.GetByConditionAsync(p => p.Code == product.Code)).FirstOrDefault();
            
        if(productFound is not null)
            throw new DuplicateEntityException("Code already exists for product.");

        var categoryFound = await _categoryRepository.GetByIdAsync(product.CategoryId, detach: false);
        if(categoryFound is null)
            throw new ResourceNotFoundException($"Does not exist the category with id {product.CategoryId}.");
            
        var warehouseFound = await _warehouseRepository.GetByIdAsync(product.WarehouseId, detach: false);
        if(warehouseFound is null)
            throw new ResourceNotFoundException($"Does not exist the warehouse with id {product.WarehouseId}.");

        return product;
    }
}
