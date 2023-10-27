using System.Text.Json.Serialization;

namespace InventoryX_Transactional.API.ViewModels;

public class ClientViewModel
{
    [JsonPropertyName("id")]
    public string ClientId { get; set; } = null!;
    public string Name { get; set; } = null!;
    public int DocumentType { get; set; }
    public string DocumentTypeName { get; set; } = null!;
    public string DocumentNumber { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string? Address { get; set; }
    public bool IsLegal { get; set; }
    public string CreatedBy { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
    public string ModifiedBy { get; set; } = null!;
    public DateTime ModifiedAt { get; set; }
}
