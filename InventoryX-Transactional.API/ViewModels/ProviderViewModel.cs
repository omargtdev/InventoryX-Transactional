using System.Text.Json.Serialization;

namespace InventoryX_Transactional.API.ViewModels;

public class ProviderViewModel
{
    [JsonPropertyName("id")]
    public string ProviderId { get; set; } = null!;
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
