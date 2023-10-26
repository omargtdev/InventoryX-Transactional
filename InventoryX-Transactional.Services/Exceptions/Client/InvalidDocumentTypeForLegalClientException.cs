namespace InventoryX_Transactional.Services.Exceptions.Client;

public class InvalidDocumentTypeForLegalClientException : BaseException
{
    public InvalidDocumentTypeForLegalClientException(string message) : base(message) {}
}
