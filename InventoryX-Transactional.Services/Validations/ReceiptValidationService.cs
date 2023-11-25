using AutoMapper;
using InventoryX_Transactional.Repository;
using InventoryX_Transactional.Services.DTOs.Receipt;
using InventoryX_Transactional.Services.Exceptions;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace InventoryX_Transactional.Services.Validations;

public class ReceiptValidationService
{
    private readonly IProviderRepository _providerRepository;
    private readonly IProductRepository _productRepository;

    public ReceiptValidationService(IProviderRepository providerRepository, IProductRepository productRepository)
    {
        _providerRepository = providerRepository;
        _productRepository = productRepository;
    }
    
    public async Task<ReceiptProductDTO> ValidateReceiptProductForCreate(ReceiptProductDTO product)
    {
        var productExists = await _productRepository.ExistProductByCode(product.Code);
        if(!productExists)
            throw new ResourceNotFoundException($"The product with code '{product.Code}' does not exist.");

        if (product.Count <= 0)
            throw new EntityRuleException($"Invalid count for product with code {product.Code}.");

        if(product.UnitPurchasePrice <= 0)
            throw new EntityRuleException($"Invalid unit purchase price for product with code {product.Code}.");

        if (product.UnitSalesPrice <= 0)
            throw new EntityRuleException($"Invalid unit sales price for product with code {product.Code}.");
        
        return product;
    }

    public async Task<NewReceiptFormattedDTO> ValidReceiptForCreate(NewReceiptDTO receipt)
    {
        NewReceiptJsonContent? receiptJsonContent;

        try
        {
            receiptJsonContent = JsonConvert.DeserializeObject<NewReceiptJsonContent>(receipt.DataJsonContent);
        }
        catch (JsonSerializationException)
        {
            throw new EntityRuleException($"Invalid data in {nameof(NewReceiptDTO.DataJsonContent)} property.");
        }

        if (receiptJsonContent is null)
            throw new EntityRuleException($"{nameof(NewReceiptDTO.DataJsonContent)} cannot be null.");

        if (receiptJsonContent.Products is null)
            throw new EntityRuleException($"{nameof(NewReceiptJsonContent.Products)} cannot be null.");

        if(!receiptJsonContent.Products.Any())
            throw new EntityRuleException($"{nameof(NewReceiptJsonContent.Products)} must have at least 1 element.");

        if(receiptJsonContent.Products.GroupBy(p => p.Code).Any(g => g.Count() > 1))
            throw new EntityRuleException($"There are repeated products!.");

        var provider = await _providerRepository.GetByIdAsync(receiptJsonContent.ProviderId);
        if(provider is null)
            throw new ResourceNotFoundException($"Provider with id {receiptJsonContent.ProviderId} does not exist.");

        if (receipt.ReferralGuide.ContentType != "application/pdf")
            throw new EntityRuleException("The file needs to be of type pdf.");

        return new NewReceiptFormattedDTO(receiptJsonContent, receipt.ReferralGuide);
    }
}
