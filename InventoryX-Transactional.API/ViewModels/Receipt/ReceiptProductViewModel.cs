using System.Text.Json.Serialization;

namespace InventoryX_Transactional.API.ViewModels.Receipt;

public class ReceiptProductViewModel
{
    [JsonPropertyName("code")]
    public string Code { get; set; } = null!;
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("brand")]
    public string? Brand { get; set; }

    [JsonPropertyName("category_id")]
    public int? CategoryId { get; set; }

    [JsonPropertyName("warehouse_id")]
    public int? WarehouseId { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("unit_price")]
    public decimal UnitPrice { get; set; }
}
