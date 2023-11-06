using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using InventoryX_Transactional.Data;
using InventoryX_Transactional.Data.Models.Common;
using Microsoft.EntityFrameworkCore;

namespace InventoryX_Transactional.Repository.Common;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    protected InventoryXDbContext _context;

    public GenericRepository(InventoryXDbContext context)
    {
        _context = context; 
    }

    public async Task<T?> GetByIdAsync(object id, bool detach = true)
    {
        var entity = await _context.Set<T>().FindAsync(id);
        if(entity == null || entity.IsDeleted)
            return null;

        if(detach)
            _context.Entry(entity).State = EntityState.Detached;

        return entity;
    }


    public async Task<IEnumerable<T>> GetByConditionAsync(Expression<Func<T, bool>> condition) =>
        await _context.Set<T>().Where(condition).Where(t => !t.IsDeleted).ToListAsync();

    public async Task<T> AddAsync(T entity) => (await _context.Set<T>().AddAsync(entity)).Entity;

    public T Update(T entity) => _context.Set<T>().Update(entity).Entity;

    public RepositoryOperation Delete(object id)
    {
        var dbSet = _context.Set<T>();
        var entityFounded = dbSet.Find(id);
        if(entityFounded == null)
            return RepositoryOperation.Failed;
        if(entityFounded.IsDeleted)
            return RepositoryOperation.Failed;

        entityFounded.IsDeleted = true;
        entityFounded.DeletedAt = DateTime.Now;
        dbSet.Update(entityFounded); 
        return RepositoryOperation.Applied;  
    }
}
