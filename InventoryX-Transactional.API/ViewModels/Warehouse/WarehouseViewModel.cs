using System.Text.Json.Serialization;

namespace InventoryX_Transactional.API.ViewModels.Warehouse;

public class WarehouseViewModel
{
    [JsonPropertyName("id")]
    public int WarehouseId { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int MaxStock { get; set; }
    public string Address { get; set; } = null!;
    public string District { get; set; } = null!;
    public string Province { get; set; } = null!;
    public string City { get; set; } = null!;
    public string CreatedBy { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
    public string ModifiedBy { get; set; } = null!;
    public DateTime ModifiedAt { get; set; }
}
