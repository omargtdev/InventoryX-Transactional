namespace InventoryX_Transactional.Services.DTOs.Receipt;

public class NewReceiptDTO
{
    public DateTime RegistrationDate { get; set; }
    public string? Notes { get; set; }
    public ReceiptProviderDTO Provider { get; set; } = new();
    public List<ReceiptProductDTO> Products { get; set; } = new();
    public string ActionBy { get; set; } = null!;
}
