using InventoryX_Transactional.Services.DTOs.Receipt;
using InventoryX_Transactional.Services.DTOs.Storage;
using Microsoft.AspNetCore.Http;

namespace InventoryX_Transactional.Services;

public interface IReceiptService
{
    Task<ReceiptDTO> GetById(Guid id);
    Task<List<ReceiptDTO>> GetReceipts();
    Task<ReceiptCreatedDTO> CreateReceipt(NewReceiptDTO receipt);
    Task<BlobFileDTO> UploadReferralGuide(IFormFile file);
}
