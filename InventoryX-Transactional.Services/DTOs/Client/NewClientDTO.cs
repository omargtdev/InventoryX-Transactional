namespace InventoryX_Transactional.Services.DTOs.Client;

public class NewClientDTO
{
    public string Name { get; set; } = null!;
    public DocumentTypeClient DocumentType { get; set; }
    public string DocumentNumber { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string? Address { get; set; }
    public bool IsLegal { get; set; }
    public string ActionBy { get; set; }
}

public enum DocumentTypeClient
{
    DNI = 1,
    RUC = 2,
    ImmigrationCard = 3
}