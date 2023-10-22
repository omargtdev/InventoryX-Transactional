using InventoryX_Transactional.Data.Models.Common;

namespace InventoryX_Transactional.Data.Models;

public class Product : Audit
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Brand { get; set; }
    public bool IsActive { get; set; }
    

    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public ProductPrice ProductPrice { get; set; }
    public List<Warehouse> Warehouses { get; } = new();
    public List<WarehouseProduct> WarehouseProducts { get; } = new();
    public List<Issue> Issues { get; } = new();
    public List<IssueProduct> IssueProducts { get; } = new();
    public List<Receipt> Receipts { get; } = new();
    public List<ReceiptProduct> ReceiptProducts { get; } = new();
}
