namespace InventoryX_Transactional.Services.Exceptions;

public class ResourceNotFoundException : BaseException
{
    public ResourceNotFoundException(string message) : base(message) {}
}
