using AutoMapper;
using InventoryX_Transactional.Data.Models;
using InventoryX_Transactional.Repository;
using InventoryX_Transactional.Services.DTOs.Category;
using InventoryX_Transactional.Services.Exceptions;
using InventoryX_Transactional.Services.Exceptions.Category;

namespace InventoryX_Transactional.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task<CategoryDTO> GetCategoryById(int id)
    {
        var categoryFound = await _categoryRepository.GetByIdAsync(id) ?? throw new ResourceNotFoundException("The category was not found");
        return _mapper.Map<CategoryDTO>(categoryFound);
    }

    public async Task<List<CategoryDTO>> GetCategories()
    {
        var categories = await _categoryRepository.GetByConditionAsync(c => true);
        return categories.Select(c => _mapper.Map<CategoryDTO>(c)).ToList();
    }

    public async Task<CategoryDTO> CreateCategory(NewCategoryDTO category)
    {
        await ValidateExistingCategory(category);

        var categoryToCreate = _mapper.Map<Category>(category);
        categoryToCreate.CreatedBy = "";
        categoryToCreate.CreatedAt = DateTime.Now;

        var categoryCreated = await _categoryRepository.AddAsync(categoryToCreate);
        await _categoryRepository.SaveAsync();

        return _mapper.Map<CategoryDTO>(categoryCreated);
    }

    public async Task<CategoryDTO> UpdateCategory(UpdateCategoryDTO category)
    {
        var categoryFound = await _categoryRepository.GetByIdAsync(category.CategoryId) ?? throw new ResourceNotFoundException("The category was not found");
        await ValidateExistingCategory(category);
        
        var categoryToUpdate = _mapper.Map<Category>(category);
        categoryToUpdate.CreatedBy = categoryFound.CreatedBy;
        categoryToUpdate.CreatedAt = categoryFound.CreatedAt;
        categoryToUpdate.ModifiedBy = category.ActionBy;

        var categoryUpdated = _categoryRepository.Update(categoryToUpdate);
        await _categoryRepository.SaveAsync();

        return _mapper.Map<CategoryDTO>(categoryUpdated);
    }

    public async Task DeleteCategory(int id)
    {
        var result = _categoryRepository.Delete(id);
        if(result == RepositoryOperation.Failed)
            throw new ResourceNotFoundException("Category cannot be found.");
        await _categoryRepository.SaveAsync();
    }

    public async Task ValidateExistingCategory(NewCategoryDTO category)
    {
        var categoryFound = (await _categoryRepository.GetByConditionAsync(c => c.Name == category.Name)).FirstOrDefault();
        if(categoryFound != null)
            throw new CategoryNameAlreadyExistsException("Category Name already exists");
    }

    public async Task ValidateExistingCategory(UpdateCategoryDTO category)
    {
        var categoryFound = (await _categoryRepository.GetByConditionAsync(c => c.Name == category.Name && c.CategoryId != category.CategoryId)).FirstOrDefault();
        if(categoryFound != null)
            throw new CategoryNameAlreadyExistsException("Category Name already exists");
    }
}
