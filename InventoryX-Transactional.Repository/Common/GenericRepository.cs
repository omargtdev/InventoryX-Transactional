using System.Linq.Expressions;
using InventoryX_Transactional.Data;
using Microsoft.EntityFrameworkCore;

namespace InventoryX_Transactional.Repository.Common;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected InventoryXDbContext _context;

    public GenericRepository(InventoryXDbContext context)
    {
        _context = context; 
    }

    public async Task<T?> GetByIdAsync(object id) =>
        await _context.Set<T>().FindAsync(id);

    public async Task<IEnumerable<T>> GetByConditionAsync(Expression<Func<T, bool>> condition) =>
        await _context.Set<T>().Where(condition).ToListAsync();

    public async Task AddAsync(T entity) => await _context.Set<T>().AddAsync(entity);

    public void Update(T entity) => _context.Set<T>().Update(entity);

    public void Delete(T entity) => _context.Set<T>().Remove(entity);
}
