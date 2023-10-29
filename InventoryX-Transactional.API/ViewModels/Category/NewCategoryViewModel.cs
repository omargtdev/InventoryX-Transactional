using System.ComponentModel.DataAnnotations;

namespace InventoryX_Transactional.API;

public class NewCategoryViewModel
{
    [MinLength(3, ErrorMessage = "Name must be at least 3 characters long")]
    public string Name { get; set; }
    public string? Description { get; set; }
}
