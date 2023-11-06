using InventoryX_Transactional.Services.Exceptions;

namespace InventoryX_Transactional.Services;

public class DuplicateEntityException : BaseException
{
    public DuplicateEntityException(string message) : base(message)
    {
    }
}
