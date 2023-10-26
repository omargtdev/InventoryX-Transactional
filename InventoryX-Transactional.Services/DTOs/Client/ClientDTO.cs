namespace InventoryX_Transactional.Services.DTOs.Client;

public class ClientDTO
{
    public Guid ClientId { get; set; }
    public string Name { get; set; } = null!;
    public DocumentTypeClient DocumentType { get; set; }
    public string DocumentTypeName { get; set; } = null!;
    public string DocumentNumber { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string? Address { get; set; }
    public bool IsLegal { get; set; }
}
