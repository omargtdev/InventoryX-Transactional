using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace InventoryX_Transactional.API.ViewModels.Receipt;

public class NewReceiptViewModel
{
    [JsonPropertyName("registration_date")]
    public DateTime RegistrationDate { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("provider")]
    public ReceiptProviderViewModel Provider { get; set; } = null!;

    [JsonPropertyName("products")]
    [MinLength(1, ErrorMessage = "I need at least one product.")]
    public List<ReceiptProductViewModel> Products { get; set; } = null!;

}
