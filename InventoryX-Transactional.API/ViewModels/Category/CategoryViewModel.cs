using System.Text.Json.Serialization;

namespace InventoryX_Transactional.API;

public class CategoryViewModel
{
    [JsonPropertyName("id")]
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public string ModifiedBy { get; set; }
    public DateTime ModifiedAt { get; set; }
}
