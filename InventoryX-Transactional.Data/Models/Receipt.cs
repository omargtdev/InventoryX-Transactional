namespace InventoryX_Transactional.Data.Models;

public class Receipt
{
    public Guid ReceiptId { get; set; }
    public DateTime RegistrationDate { get; set; }
    public string Notes { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }


    public Guid ProviderId { get; set; }
    public Provider Provider { get; set; }
    public List<Warehouse> Warehouses { get; } = new();
    public List<Product> Products { get; } = new();
    public List<ReceiptProduct> ReceiptProducts { get; } = new();
}
