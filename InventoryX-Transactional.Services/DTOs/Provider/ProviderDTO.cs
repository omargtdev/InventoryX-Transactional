namespace InventoryX_Transactional.Services.DTOs.Provider;

public class ProviderDTO
{
    public Guid ProviderId { get; set; }
    public string BusinessName { get; set; } = null!;
    public string RUC { get; set; } = null!;
    public string ContactEmail { get; set; } = null!;
    public string ContactPhone { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string CreatedBy { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
    public string ModifiedBy { get; set; } = null!;
    public DateTime ModifiedAt { get; set; }
}
