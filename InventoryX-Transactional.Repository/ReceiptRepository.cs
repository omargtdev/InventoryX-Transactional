using System.Linq.Expressions;
using InventoryX_Transactional.Data;
using InventoryX_Transactional.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryX_Transactional.Repository;

public class ReceiptRepository : IReceiptRepository
{
    private readonly InventoryXDbContext _context;

    public ReceiptRepository(InventoryXDbContext context)
    {
        _context = context; 
    }

    public async Task<Receipt> AddReceiptAsync(Receipt receipt) => (await _context.Receipts.AddAsync(receipt)).Entity;

    public async Task<Receipt?> GetByIdAsync(Guid id) => await _context.Receipts.FindAsync(id);

    public async Task<IEnumerable<Receipt>> GetReceiptsAsync(Expression<Func<Receipt, bool>>? condition = null)
    {
        if(condition is null)
            return await _context.Receipts.Include(r => r.Provider).ToListAsync();

        return await _context.Receipts.Include(r => r.Provider).Where(condition).ToListAsync();
    }
}
