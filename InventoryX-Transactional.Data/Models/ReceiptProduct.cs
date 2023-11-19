namespace InventoryX_Transactional.Data.Models;

public class ReceiptProduct
{
    public Guid ReceiptId { get; set; }
    public int ProductId { get; set; }
    public decimal UnitPurchasePrice { get; set; }
    public decimal UnitSalesPrice { get; set; }
    public int Quantity { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }


    public Receipt Receipt { get; set; }
    public Product Product { get; set; }
}
