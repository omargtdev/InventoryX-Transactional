using InventoryX_Transactional.Services.Exceptions;

namespace InventoryX_Transactional.Services;

public class RUCAlreadyExistsForProviderException : BaseException
{
    public RUCAlreadyExistsForProviderException(string message) : base(message)
    {
    }
}
