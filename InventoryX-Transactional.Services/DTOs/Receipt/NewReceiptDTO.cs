using Microsoft.AspNetCore.Http;

namespace InventoryX_Transactional.Services.DTOs.Receipt;

public class NewReceiptDTO
{
    public string DataJsonContent { get; set; } = null!;
    public IFormFile ReferralGuide { get; set; } = null!;
}
