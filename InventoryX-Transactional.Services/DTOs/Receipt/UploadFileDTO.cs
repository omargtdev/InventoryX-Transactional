using Microsoft.AspNetCore.Http;

namespace InventoryX_Transactional.Services.DTOs.Receipt;

public record UploadFileDTO(
    IFormFile File);
