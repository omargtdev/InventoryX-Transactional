namespace InventoryX_Transactional.Data.Models;

public class Issue
{
    public Guid ReceiptId { get; set; }
    public DateTime RegistrationDate { get; set; }
    public string Notes { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }


    public Guid ClientId { get; set; }
    public Client Client { get; set; }
    public List<Warehouse> Warehouses { get; } = new();
    public List<Product> Products { get; } = new();
    public List<IssueProduct> IssueProducts { get; } = new();
}
