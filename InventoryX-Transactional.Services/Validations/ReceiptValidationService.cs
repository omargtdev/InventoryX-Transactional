using AutoMapper;
using InventoryX_Transactional.Data.Models;
using InventoryX_Transactional.Repository.Common;

namespace InventoryX_Transactional.Services.Validations;

public class ReceiptValidationService
{
    private readonly IGenericRepository<Provider> _providerRepository;
    private readonly IMapper _mapper;

    public ReceiptValidationService(IGenericRepository<Provider> providerRepository, IMapper mapper)
    {
        _providerRepository = providerRepository;
        _mapper = mapper;
    }
    
    public ReceiptProductDTO ValidateReceiptProductForCreate(ReceiptProductDTO product)
    {
        if(product.Count <= 0)
            throw new EntityRuleException($"Invalid count for product with code {product.Code}.");

        if(product.UnitPrice <= 0)
            throw new EntityRuleException($"Invalid unit price for product with code {product.Code}.");

        return product;
    }
}
