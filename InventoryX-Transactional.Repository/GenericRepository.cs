using System.Linq.Expressions;
using InventoryX_Transactional.Data;
using Microsoft.EntityFrameworkCore;

namespace InventoryX_Transactional.Repository;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly InventoryXDbContext _context;
    private readonly DbSet<T> _dbSet;

    public GenericRepository(InventoryXDbContext context)
    {
        _context = context; 
        _dbSet = _context.Set<T>();
    }

    public async Task<T?> GetByIdAsync(object id) =>
        await _dbSet.FindAsync(id);

    public async Task<IEnumerable<T>> GetByConditionAsync(Expression<Func<T, bool>> condition) =>
        await _dbSet.Where(condition).ToListAsync();

    public void Add(T entity) => _dbSet.Add(entity);

    public void Update(T entity) => _dbSet.Update(entity);

    public void Delete(T entity) => _dbSet.Remove(entity);

    public Task SaveAsync() => _context.SaveChangesAsync();

}
