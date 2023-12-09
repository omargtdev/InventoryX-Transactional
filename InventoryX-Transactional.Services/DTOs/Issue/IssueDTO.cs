namespace InventoryX_Transactional.Services.DTOs.Issue;

public class IssueDTO
{
    public Guid Id { get; set; }
    public string ClientName { get; set; } = string.Empty;
    public int ProductCount { get; set; }
    public DateTime CreatedAt { get; set; }
}
