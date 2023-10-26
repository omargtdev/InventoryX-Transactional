namespace InventoryX_Transactional.Services.Exceptions.Client;

public class EmailAlreadyExistForClientException : BaseException
{
    public EmailAlreadyExistForClientException(string message) : base(message) {}
}
