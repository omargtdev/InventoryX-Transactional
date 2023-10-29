namespace InventoryX_Transactional.Services.Exceptions.Warehouse;

public class WarehouseWithExistingNameException : BaseException
{
    public WarehouseWithExistingNameException(string message) : base(message)
    {
    }
}
