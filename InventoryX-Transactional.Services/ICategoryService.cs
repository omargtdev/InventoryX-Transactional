using InventoryX_Transactional.Services.DTOs.Category;

namespace InventoryX_Transactional.Services;

public interface ICategoryService
{
    Task<List<CategoryDTO>> GetCategories();
    Task<CategoryDTO> GetCategoryById(int id);
    Task<CategoryDTO> CreateCategory(NewCategoryDTO category);
    Task<CategoryDTO> UpdateCategory(UpdateCategoryDTO category);
    Task DeleteCategory(int id);
}
