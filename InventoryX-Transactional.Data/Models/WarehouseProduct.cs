namespace InventoryX_Transactional.Data.Models;

public class WarehouseProduct
{
    public int WarehouseId { get; set; }
    public int ProductId { get; set; }
    public int Stock { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    
    public Warehouse Warehouse { get; set; }
    public Warehouse Product { get; set; }

}
