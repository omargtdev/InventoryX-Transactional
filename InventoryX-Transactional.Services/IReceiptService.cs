using InventoryX_Transactional.Services.DTOs.Receipt;

namespace InventoryX_Transactional.Services;

public interface IReceiptService
{
    Task<ReceiptDTO> GetById(Guid id);
    Task<List<ReceiptDTO>> GetReceipts();
    Task CreateReceipt(NewReceiptDTO receipt);
}
