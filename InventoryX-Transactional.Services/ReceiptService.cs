using AutoMapper;
using InventoryX_Transactional.Data.Models;
using InventoryX_Transactional.Repository;
using InventoryX_Transactional.Repository.UnitOfWork;
using InventoryX_Transactional.Services.Azure;
using InventoryX_Transactional.Services.DTOs.Receipt;
using InventoryX_Transactional.Services.DTOs.Storage;
using InventoryX_Transactional.Services.Validations;
using Microsoft.AspNetCore.Http;

namespace InventoryX_Transactional.Services;

public class ReceiptService : IReceiptService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IProductRepository _productRepository;
    private readonly ReceiptValidationService _validator;
    private readonly IAzureFileService _azureFileService;
    private readonly IMapper _mapper;

    private const string BlobContainerName = "receipts";

    public ReceiptService(
        IUnitOfWork unitOfWork,
        IProductRepository productRepository,
        ReceiptValidationService receiptValidationService,
        IAzureFileService azureFileService,
        IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _productRepository = productRepository;
        _validator = receiptValidationService;
        _azureFileService = azureFileService;
        _mapper = mapper;
    }

    public async Task<ReceiptCreatedDTO> CreateReceipt(NewReceiptDTO newReceipt)
    {
        var receiptValidated = await _validator.ValidReceiptForCreate(newReceipt);
        var receiptEntity = new Receipt
        {
            ReceiptId = Guid.NewGuid(),
            RegistrationDate = receiptValidated.Content.RegistrationDate,
            Notes = receiptValidated.Content.Notes,
            ProviderId = receiptValidated.Content.ProviderId,
            CreatedBy = "System",
            CreatedAt = DateTime.UtcNow
        };

        foreach(var product in receiptValidated.Content.Products)
        {
            var productValidated = await _validator.ValidateReceiptProductForCreate(product);
            var productEntity = await _productRepository.GetByCodeAsync(productValidated.Code);

            var currentWarehouseStock = await _productRepository.GetStockSumByWarehouse(productEntity!.WarehouseId);
            var warehouseStockResult = currentWarehouseStock + productValidated.Count;
            if (warehouseStockResult > productEntity.Warehouse.MaxStock)
                throw new EntityRuleException(
                    $"The warehouse '{productEntity.Warehouse.Name}' from the product with code " +
                    $"'{productEntity.Code}' would exceed the current stock. Actual stock: " +
                    $"{currentWarehouseStock}");

            productEntity!.ProductPrice.LastReceiptPrice = productValidated.UnitPurchasePrice;
            productEntity!.ProductPrice.LastIssuePrice = productValidated.UnitSalesPrice;
            productEntity!.Stock += productValidated.Count;
            productEntity!.ModifiedAt = DateTime.UtcNow;
            productEntity!.ModifiedBy = "System";

            var receiptProduct = new ReceiptProduct
            {
                ReceiptId = receiptEntity.ReceiptId,
                ProductId = productEntity.ProductId,
                UnitPurchasePrice = productValidated.UnitPurchasePrice,
                UnitSalesPrice = productValidated.UnitSalesPrice,
                Quantity = productValidated.Count,
                CreatedBy = "System",
                CreatedAt = DateTime.UtcNow
            };

            receiptEntity.ReceiptProducts.Add(receiptProduct);
        }

        var fileCreated = await _azureFileService.UploadFileAsync(BlobContainerName, receiptValidated.ReferralGuide);
        receiptEntity.ReferralGuideFileName = fileCreated.FileName;

        await _unitOfWork.Receipts.AddReceiptAsync(receiptEntity);
        await _unitOfWork.SaveAsync();

        return new ReceiptCreatedDTO(receiptEntity.ReceiptId);
    }
    public Task<ReceiptDTO> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<ReceiptDTO>> GetReceipts()
    {
        var receipts = await _unitOfWork.Receipts.GetReceiptsAsync();
        return _mapper.Map<List<ReceiptDTO>>(receipts);
    }

    public async Task<BlobFileDTO> UploadReferralGuide(IFormFile file)
    {
        return await _azureFileService.UploadFileAsync(BlobContainerName, file);
    }
}
