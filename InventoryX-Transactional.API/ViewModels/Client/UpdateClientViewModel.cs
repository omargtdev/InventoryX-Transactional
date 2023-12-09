namespace InventoryX_Transactional.API.ViewModels.Client;

public class UpdateClientViewModel
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DocumentTypeViewModel DocumentType { get; set; }
    public string DocumentNumber { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string? Address { get; set; }
    public bool IsLegal { get; set; }
}
