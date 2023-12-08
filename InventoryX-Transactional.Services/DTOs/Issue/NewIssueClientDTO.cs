using InventoryX_Transactional.Services.DTOs.Client;

namespace InventoryX_Transactional.Services;

public class NewIssueClientDTO
{
    public string Name { get; set; } = null!;
    public DocumentTypeClient DocumentType { get; set; }
    public string DocumentNumber { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string? Address { get; set; }
    public bool IsLegal { get; set; }
}
