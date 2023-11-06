using InventoryX_Transactional.Services.Exceptions;

namespace InventoryX_Transactional.Services;

public class InvalidDocumentNumberException : BaseException
{
    public InvalidDocumentNumberException(string message) : base(message)
    {
    }
}
