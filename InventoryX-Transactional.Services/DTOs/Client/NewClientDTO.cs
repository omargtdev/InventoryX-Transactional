namespace InventoryX_Transactional.Services.DTOs.Client;

public class NewClientDTO
{
    public string Name { get; set; } = string.Empty;
    public DocumentTypeClient DocumentType { get; set; }
    public string DocumentNumber { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string? Address { get; set; }
    public bool IsLegal { get; set; }
}

public enum DocumentTypeClient
{
    DNI = 1,
    RUC = 2,
    ImmigrationCard = 3
}