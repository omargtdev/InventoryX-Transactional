using System.Linq.Expressions;
using InventoryX_Transactional.Data.Models;

namespace InventoryX_Transactional.Repository;

public interface IIssueRepository
{
    Task<IEnumerable<Issue>> GetIssuesAsync(Expression<Func<Issue, bool>>? condition = null);
    Task<Issue?> GetIssueAsync(Guid id);
    Task AddIssueAsync(Issue issue);
}
