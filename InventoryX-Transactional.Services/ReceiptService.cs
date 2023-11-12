using AutoMapper;
using InventoryX_Transactional.Data.Models;
using InventoryX_Transactional.Repository.UnitOfWork;
using InventoryX_Transactional.Services.DTOs.Product;
using InventoryX_Transactional.Services.DTOs.Provider;
using InventoryX_Transactional.Services.DTOs.Receipt;
using InventoryX_Transactional.Services.Validations;

namespace InventoryX_Transactional.Services;

public class ReceiptService : IReceiptService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ProviderValidationService _providerValidationService;
    private readonly ProductValidationService _productValidationService;
    private readonly ReceiptValidationService _receiptValidationService;
    private readonly IMapper _mapper;

    public ReceiptService(
        IUnitOfWork unitOfWork,
        ProviderValidationService providerValidationService,
        ProductValidationService productValidationService,
        ReceiptValidationService receiptValidationService,
        IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _providerValidationService = providerValidationService;
        _productValidationService = productValidationService;
        _receiptValidationService = receiptValidationService;
        _mapper = mapper;
    }

    // TODO: Return information about the count of products
    public async Task CreateReceipt(NewReceiptDTO receipt)
    {
        var providerByRuc = (await _unitOfWork.Providers.GetByConditionAsync(p => p.RUC == receipt.Provider.RUC)).FirstOrDefault();
        if(providerByRuc is not null)
            await CreateReceiptWithExistingProvider(receipt, providerByRuc);
        else
            await CreateReceiptWithNewProvider(receipt);
        
        await _unitOfWork.SaveAsync();
    }

    private async Task CreateReceiptWithExistingProvider(NewReceiptDTO receipt, Provider provider)
    {
        var products = await GetProducts(receipt.Products);
        var receiptToRegister = new Receipt 
        {
            RegistrationDate = receipt.RegistrationDate,
            Notes = receipt.Notes,
            Provider = provider,
            CreatedAt = DateTime.Now,
            CreatedBy = "System"
        };
        receiptToRegister.ReceiptProducts.AddRange(products);
        await _unitOfWork.Receipts.AddReceiptAsync(receiptToRegister);
    }

    private async Task CreateReceiptWithNewProvider(NewReceiptDTO receipt)
    {
        var newProviderValidated = await _providerValidationService
            .ValidateForCreate(_mapper.Map<NewProviderDTO>(receipt.Provider));
        
        var providerToCreate = _mapper.Map<Provider>(newProviderValidated);
        providerToCreate.CreatedAt = DateTime.Now;
        providerToCreate.CreatedBy = "System";
        var providerCreated = await _unitOfWork.Providers
            .AddAsync(providerToCreate);

        var products = await GetProducts(receipt.Products);
        var receiptToRegister = new Receipt 
        {
            RegistrationDate = receipt.RegistrationDate,
            Notes = receipt.Notes,
            Provider = providerCreated,
            CreatedAt = DateTime.Now,
            CreatedBy = "System"
        };
        receiptToRegister.ReceiptProducts.AddRange(products);
        await _unitOfWork.Receipts.AddReceiptAsync(receiptToRegister);
    }

    private async Task<List<ReceiptProduct>> GetProducts(List<ReceiptProductDTO> products)
    {
        if(!products.Any())
            throw new EntityRuleException("The count of products in a receipt cannot be 0.");

        var productsForReceipt = new List<ReceiptProduct>();
        foreach(var product in products)
        {
            _receiptValidationService.ValidateReceiptProductForCreate(product);

            var productByCode = (await _unitOfWork.Products.GetByConditionAsync(p => p.Code == product.Code)).FirstOrDefault();
            if(productByCode is null)
            {
                // Creating products if does not exist
                var productValidatedForCreate = await _productValidationService.ValidateForCreate(_mapper.Map<NewProductDTO>(product));

                var productMapped = _mapper.Map<Product>(productValidatedForCreate);
                productMapped.CreatedBy = "System";
                productMapped.CreatedAt = DateTime.Now;
                productMapped.ProductPrice = new ProductPrice 
                {
                    LastReceiptPrice = product.UnitPrice,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "System"
                };

                productByCode = await _unitOfWork.Products.AddAsync(productMapped);
            }
            
            // Creating receipt product
            var productForReceipt = new ReceiptProduct
            {
                Product = productByCode,
                UnitSalesPrice = product.UnitPrice,
                Quantity = product.Count,
                CreatedAt = DateTime.Now,
                CreatedBy = "System"
            };
            productsForReceipt.Add(productForReceipt);
        }

        return productsForReceipt;
    }

    public Task<ReceiptDTO> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<ReceiptDTO>> GetReceipts()
    {
        throw new NotImplementedException();
    }
}
