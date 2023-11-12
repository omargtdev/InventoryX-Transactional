namespace InventoryX_Transactional.Services.DTOs.Product;

public class NewProductDTO
{
    public string Code { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public string Brand { get; set; } = null!;
    public int CategoryId { get; set; }
    public int WarehouseId { get; set; }
}
