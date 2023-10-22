namespace InventoryX_Transactional.Data.Models;

public class IssueProduct
{
    public Guid IssueId { get; set; }
    public int WarehouseId { get; set; }
    public int ProductId { get; set; }
    public decimal UnitPurchasePrice { get; set; }
    public decimal UnitPriceForSale { get; set; }
    public int Quantity { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }


    public Issue Issue { get; set; }
    public Warehouse Warehouse { get; set; }
    public Product Product { get; set; }
}
