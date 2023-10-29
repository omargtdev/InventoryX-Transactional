namespace InventoryX_Transactional.Services.Exceptions.Category;

public class CategoryNameAlreadyExistsException : BaseException
{
    public CategoryNameAlreadyExistsException(string message) : base(message)
    {
    }
}
