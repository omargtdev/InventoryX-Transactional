using System.Linq.Expressions;

namespace InventoryX_Transactional.Repository.Common;

public interface IGenericRepository<T>
{
    Task<T?> GetByIdAsync(object id, bool detach = true);
    Task<IEnumerable<T>> GetByConditionAsync(Expression<Func<T, bool>> condition);
    Task<T> AddAsync(T entity);
    T Update(T entity);
    RepositoryOperation Delete(object id); 
}
