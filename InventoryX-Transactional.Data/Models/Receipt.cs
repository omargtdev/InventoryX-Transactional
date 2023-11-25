namespace InventoryX_Transactional.Data.Models;

public class Receipt
{
    public Guid ReceiptId { get; set; }
    public DateTime RegistrationDate { get; set; }
    public string ReferralGuideFileName { get; set; }
    public string? Notes { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid ProviderId { get; set; }
    public Provider Provider { get; set; }
    public List<ReceiptProduct> ReceiptProducts { get; } = new();
}
