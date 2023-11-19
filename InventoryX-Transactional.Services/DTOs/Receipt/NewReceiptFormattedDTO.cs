using Microsoft.AspNetCore.Http;

namespace InventoryX_Transactional.Services.DTOs.Receipt;

public record NewReceiptFormattedDTO(
        NewReceiptJsonContent Content,
        IFormFile ReferralGuide);
