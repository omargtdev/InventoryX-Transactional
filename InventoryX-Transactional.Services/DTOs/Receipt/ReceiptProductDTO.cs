namespace InventoryX_Transactional.Services;

public class ReceiptProductDTO
{
    public string Code { get; set; } = null!;
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Brand { get; set; }
    public int CategoryId { get; set; }
    public int WarehouseId { get; set; }
    public int Count { get; set; }
    public decimal UnitPrice { get; set; }
}
