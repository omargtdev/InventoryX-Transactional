namespace InventoryX_Transactional.Services.DTOs.Receipt;

public class ReceiptDTO
{
    public Guid Id { get; set; }
    public DateTime RegistrationDate { get; set; }
    public string ProviderName { get; set; } = string.Empty;
    public string ReferralGuideUrl { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}
