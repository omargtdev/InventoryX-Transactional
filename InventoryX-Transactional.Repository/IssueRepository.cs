using System.Linq.Expressions;
using InventoryX_Transactional.Data;
using InventoryX_Transactional.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryX_Transactional.Repository;

public class IssueRepository : IIssueRepository
{
    private readonly InventoryXDbContext _context;
    
    public IssueRepository(InventoryXDbContext context)
    {
        _context = context;
    }

    public async Task AddIssueAsync(Issue issue)
    {
        await _context.Issues.AddAsync(issue);
    }

    public async Task<Issue?> GetIssueAsync(Guid id)
    {
        return await _context.Issues.FirstOrDefaultAsync(x => x.IssueId == id);
    }

    public async Task<IEnumerable<Issue>> GetIssuesAsync(Expression<Func<Issue, bool>>? condition = null)
    {
        if(condition is null)
        {
            return await _context.Issues.ToListAsync();
        }     

        return await _context.Issues.Where(condition).ToListAsync();
    }
}
