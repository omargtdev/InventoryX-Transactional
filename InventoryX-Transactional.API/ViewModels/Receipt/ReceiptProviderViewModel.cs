using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace InventoryX_Transactional.API.ViewModels.Receipt;

public class ReceiptProviderViewModel
{
    [JsonPropertyName("business_name")]
    public string? BusinessName { get; set; }

    [JsonPropertyName("ruc")]
    [RegularExpression(@"^\d+$", ErrorMessage = "ruc must contain only numbers")]
    public string RUC { get; set; } = null!;

    [JsonPropertyName("contact_email")]
    [EmailAddress(ErrorMessage = $"The contact_email field must be a valid email address.")]
    public string? ContactEmail { get; set; }

    [JsonPropertyName("contact_phone")]
    public string? ContactPhone { get; set; }

    [JsonPropertyName("address")]
    public string? Address { get; set; }
}
