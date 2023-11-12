namespace InventoryX_Transactional.Services.DTOs.Product;

public record UpdateProductDTO(
    string Code,
    string Name,
    string Description,
    string Brand,
    int CategoryId,
    int WarehouseId);