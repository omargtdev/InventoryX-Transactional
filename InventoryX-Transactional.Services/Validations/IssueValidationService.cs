using InventoryX_Transactional.Data.Models;
using InventoryX_Transactional.Repository;
using InventoryX_Transactional.Services.Exceptions;
using InventoryX_Transactional.Services.DTOs.Issue;

namespace InventoryX_Transactional.Services.Validations;

public class IssueValidationService
{
    private readonly IIssueRepository _issueRepository;
    private readonly IProductRepository _productRepository;
    
    public IssueValidationService(
        IIssueRepository issueRepository,
        IProductRepository productRepository)
    {
        _issueRepository = issueRepository;
        _productRepository = productRepository;
    }

    public NewIssueDTO ValidateForCreate(NewIssueDTO issue)
    {
        if(issue.Client is null)
        {
            throw new EntityRuleException($"The client cannot be null.");
        }

        if(!issue.Products.Any())
        {
            throw new EntityRuleException($"Provide at least one product.");
        }

        return issue;
    }

    public async Task<IssueProductDTO> ValidateIssueProductForCreateAsync(IssueProductDTO product)
    {
        var productFound = await _productRepository.GetByCodeAsync(product.Code);
        if(productFound is null)
        {
            throw new ResourceNotFoundException($"The product with code '{product.Code}' does not exist.");
        }

        if(product.Count <= 0)
        {
            throw new EntityRuleException($"Invalid count for product with code {product.Code}.");
        }

        var stockAfterPurchase = productFound.Stock - product.Count;
        if(stockAfterPurchase < 0)
        {
            throw new EntityRuleException($"There is not enough stock for the product with code {product.Code}.");
        }

        return product;
    }

}
