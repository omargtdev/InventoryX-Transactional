using InventoryX_Transactional.Services.DTOs.Issue;

namespace InventoryX_Transactional.Services;

public interface IIssueService
{
    Task<IssueDTO> GetByIdAsync(Guid id);
    Task<Guid> CreateIssueAsync(NewIssueDTO issue);
}
