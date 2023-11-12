namespace InventoryX_Transactional.Services;

public class ReceiptProviderDTO
{
    public string? BusinessName { get; set; }
    public string RUC { get; set; } = null!;
    public string? ContactEmail { get; set; }
    public string? ContactPhone { get; set; }
    public string? Address { get; set; }
}
