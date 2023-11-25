namespace InventoryX_Transactional.Services.DTOs.Receipt;

public class NewReceiptJsonContent
{
    public DateTime RegistrationDate { get; set; }
    public string? Notes { get; set; }
    public Guid ProviderId { get; set; }
    public List<ReceiptProductDTO> Products { get; set; } = new();
}
