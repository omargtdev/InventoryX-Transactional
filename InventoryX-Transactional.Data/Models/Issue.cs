namespace InventoryX_Transactional.Data.Models;

public class Issue
{
    public Guid ReceiptId { get; set; }
    public string? Notes { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }


    public Guid ClientId { get; set; }
    public Client Client { get; set; }
    public List<IssueProduct> IssueProducts { get; } = new();
}
