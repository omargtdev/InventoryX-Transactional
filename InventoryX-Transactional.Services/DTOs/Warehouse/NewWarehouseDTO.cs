namespace InventoryX_Transactional.Services.DTOs.Warehouse;

public class NewWarehouseDTO
{
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public int MaxStock { get; set; }
    public string Address { get; set; } = null!;
    public string District { get; set; } = null!;
    public string Province { get; set; } = null!;
    public string City { get; set; } = null!;
    public string ActionBy { get; set; } = null!;
}
