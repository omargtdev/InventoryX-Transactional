namespace InventoryX_Transactional.Services.Exceptions;

public class BaseException : Exception
{
    public BaseException(string message) : base(message) {}

    public string ExceptionName 
    { 
        get => GetType().Name;     
    }
}
