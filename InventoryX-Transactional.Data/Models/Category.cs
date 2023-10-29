using InventoryX_Transactional.Data.Models.Common;

namespace InventoryX_Transactional.Data.Models;

public class Category : BaseEntity
{
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }


    //public List<Product> Products { get; } = new();
}
