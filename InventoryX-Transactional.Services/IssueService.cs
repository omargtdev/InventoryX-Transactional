using AutoMapper;
using InventoryX_Transactional.Services.DTOs.Issue;
using InventoryX_Transactional.Services.Validations;
using InventoryX_Transactional.Repository.UnitOfWork;
using InventoryX_Transactional.Data.Models;

namespace InventoryX_Transactional.Services;

public class IssueService : IIssueService
{

    private readonly IUnitOfWork _unitOfWork;
    private readonly ClientValidationService _clientValidator;
    private readonly IssueValidationService _issueValidator;
    private readonly IMapper _mapper;

    public IssueService(
        ClientValidationService clientValidator,
        IssueValidationService issueValidator,
        IUnitOfWork unitOfWork,
        IMapper mapper)
    {
        _clientValidator = clientValidator;
        _issueValidator = issueValidator;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<Guid> CreateIssueAsync(NewIssueDTO issue)
    {
        var issuePreValidated = _issueValidator.ValidateForCreate(issue); 

        var clients = await _unitOfWork.Clients.GetByConditionAsync(
            c => c.DocumentNumber == issuePreValidated.Client.DocumentNumber);

        var issueToCreate = new Issue
        {
            IssueId = Guid.NewGuid(),
            CreatedBy = "System"
        };

        var issueClient = clients.FirstOrDefault();
        if(issueClient is null)
        {
            var clientValidated = await _clientValidator.ValidateForCreateAsync(issuePreValidated.Client);
            var clientToCreate = _mapper.Map<Client>(clientValidated); 
            clientToCreate.CreatedBy = "System";
            clientToCreate.CreatedAt = DateTime.UtcNow;
            issueClient = await _unitOfWork.Clients.AddAsync(clientToCreate);
        }

        issueToCreate.ClientId = issueClient.ClientId;
        issueToCreate.Notes = issuePreValidated.Notes;

        foreach(var product in issue.Products)
        {
            var productToAddValidated = await _issueValidator.ValidateIssueProductForCreateAsync(product);

            var productFound = await _unitOfWork.Products.GetByCodeAsync(productToAddValidated.Code);
            if(productFound is null)
            {
                throw new Exception("Something was wrong");
            }

            var lastPriceForSale = productFound.ProductPrice.LastIssuePrice;
            var issueProduct = new IssueProduct
            {
                IssueId = issueToCreate.IssueId,
                ProductId = productFound.ProductId,
                UnitPriceForSale = lastPriceForSale,
                Quantity = productToAddValidated.Count,
                CreatedBy = "System"
            };
            
            productFound.Stock -= productToAddValidated.Count;
            _unitOfWork.Products.Update(productFound);

            issueToCreate.IssueProducts.Add(issueProduct);
        }

        issueToCreate.CreatedAt = DateTime.UtcNow;
        issueToCreate.IssueProducts.ForEach(p => 
        {
            p.CreatedAt = DateTime.UtcNow;
        });

        await _unitOfWork.Issues.AddIssueAsync(issueToCreate);
        await _unitOfWork.SaveAsync();

        return issueToCreate.IssueId;
    }

    public Task<IssueDTO> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}

