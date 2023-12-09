using InventoryX_Transactional.Services.DTOs.Client;

namespace InventoryX_Transactional.Services.DTOs.Issue;

public class NewIssueDTO
{
     public NewClientDTO Client { get; set; }
     public string? Notes { get; set; }
     public List<IssueProductDTO> Products { get; set; }
}
