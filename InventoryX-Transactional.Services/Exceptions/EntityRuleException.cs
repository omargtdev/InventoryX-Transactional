using InventoryX_Transactional.Services.Exceptions;

namespace InventoryX_Transactional.Services;

public class EntityRuleException : BaseException
{
    public EntityRuleException(string message) : base(message)
    {
    }
}
