namespace InventoryX_Transactional.Services.DTOs.Storage;

public class BlobFileDTO
{
    public Guid Id { get; set; }
    public string FileName { get; set; } = string.Empty;
    public string FileUri { get; set; } = string.Empty;
}
