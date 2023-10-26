﻿using System.Linq.Expressions;
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

    public async Task<T?> GetByIdAsync(object id)
    {
        var entity = await _context.Set<T>().FindAsync(id);
        return entity != null && !entity.IsDeleted
            ? entity
            : null;
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

        entityFounded.IsDeleted = true;
        entityFounded.DeletedAt = DateTime.Now;
        dbSet.Update(entityFounded); 
        return RepositoryOperation.Applied;  
    }
}
