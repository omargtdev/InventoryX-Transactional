using System.Linq.Expressions;

namespace InventoryX_Transactional.Repository;

public interface IGenericRepository<T>
{
    Task<T?> GetByIdAsync(object id);
    Task<IEnumerable<T>> GetByConditionAsync(Expression<Func<T, bool>> condition);
    Task AddAsync(T entity);
    void Update(T entity);
    void Delete(T entity); 
}
