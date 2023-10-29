namespace InventoryX_Transactional.Services.Exceptions.Warehouse;

public class InvalidStockValueException : BaseException
{
    public InvalidStockValueException(string message) : base(message)
    {
    }
}
