namespace InventoryX_Transactional.Services.DTOs.Category;

public class NewCategoryDTO
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string ActionBy { get; set; }
}
