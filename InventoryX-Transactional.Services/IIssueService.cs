namespace InventoryX_Transactional.Services;

public interface IIssueService
{
    Task<IssueDTO> GetByIdAsync(Guid id);
    Task<Guid> CreateIssueAsync(NewIssueDTO issue);
}
