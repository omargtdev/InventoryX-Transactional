using InventoryX_Transactional.Data.Models.Common;

namespace InventoryX_Transactional.Data.Models;

public class Product : BaseEntity
{
    public int ProductId { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public string Brand { get; set; }
    public int Stock { get; set; }
    


    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public int WarehouseId { get; set; }
    public Warehouse Warehouse { get; set; }
    public ProductPrice ProductPrice { get; set; }
    public List<ReceiptProduct> ReceiptProducts { get; set; } = new();
}
