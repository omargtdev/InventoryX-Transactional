namespace InventoryX_Transactional.Services.DTOs.Category;

public class UpdateCategoryDTO
{
    public int CategoryId { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string ActionBy { get; set; }
}
