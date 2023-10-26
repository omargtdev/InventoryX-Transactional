using InventoryX_Transactional.Services.Exceptions;

namespace InventoryX_Transactional.Services;

public class InvalidDocumentNumberLengthException : BaseException
{
    public InvalidDocumentNumberLengthException(string message) : base(message)
    {
    }
}
