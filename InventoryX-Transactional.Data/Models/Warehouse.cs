using InventoryX_Transactional.Data.Models.Common;

namespace InventoryX_Transactional.Data.Models;

public class Warehouse : BaseEntity
{
    public int WarehouseId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public int MaxStock { get; set; }
    public string Address { get; set; }
    public string District { get; set; }
    public string Province { get; set; }
    public string City { get; set; }
    public List<Product> Products { get; } = new();
}
