using System.Linq.Expressions;
using InventoryX_Transactional.Data.Models;

namespace InventoryX_Transactional.Repository;

public interface IReceiptRepository
{
    Task<Receipt?> GetByIdAsync(Guid id);
    Task<IEnumerable<Receipt>> GetReceiptsAsync(Expression<Func<Receipt, bool>>? condition = null);
    Task<Receipt> AddReceiptAsync(Receipt receipt);
}
