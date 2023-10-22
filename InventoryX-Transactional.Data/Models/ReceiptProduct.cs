namespace InventoryX_Transactional.Data.Models;

public class ReceiptProduct
{
    public Guid IssueId { get; set; }
    public int WarehouseId { get; set; }
    public int ProductId { get; set; }
    public decimal UnitSalesPrice { get; set; }
    public int Quantity { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }


    public Receipt Receipt { get; set; }
    public Warehouse Warehouse { get; set; }
    public Product Product { get; set; }
}
