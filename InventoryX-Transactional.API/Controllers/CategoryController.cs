using AutoMapper;
using InventoryX_Transactional.API.ViewModels;
using InventoryX_Transactional.Services;
using InventoryX_Transactional.Services.DTOs.Category;
using InventoryX_Transactional.Services.Exceptions;
using InventoryX_Transactional.Services.Exceptions.Category;
using Microsoft.AspNetCore.Mvc;

namespace InventoryX_Transactional.API;

[ApiController]
[Route("categories")]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;
    private readonly IMapper _mapper;

    public CategoryController(ICategoryService categoryService, IMapper mapper)
    {
        _categoryService = categoryService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<List<CategoryViewModel>>> GetCategories()
    {
        var categories = await _categoryService.GetCategories();
        return Ok(categories.Select(c => _mapper.Map<CategoryViewModel>(c)));
    }

    [HttpGet]
    [Route("{categoryId}")]
    public async Task<ActionResult<CategoryViewModel>> GetCategoryById(int categoryId)
    {
        try
        {
            var category = await _categoryService.GetCategoryById(categoryId);
            
            return Ok(_mapper.Map<CategoryViewModel>(category));
        }
        catch (Exception ex)
        {
            return ex switch
            {
                ResourceNotFoundException => NotFound(_mapper.Map<ResponseErrorViewModel>(ex)),
                _ => StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new ResponseErrorViewModel
                    {
                        Type = "ServerError",
                        Message = ex.Message
                    }
                ),
            };
        }
    }

    [HttpPost]
    public async Task<IActionResult> CreateCategory([FromBody] NewCategoryViewModel newCategory)
    {
        try
        {
            if(!ModelState.IsValid)    
                return BadRequest(ModelState.Values.SelectMany(v => v.Errors));
            
            var category = await _categoryService.CreateCategory(_mapper.Map<NewCategoryDTO>(newCategory));
            return CreatedAtAction(null, category);
        }
        catch (Exception ex)
        {
            return ex switch
            {
                CategoryNameAlreadyExistsException => BadRequest(_mapper.Map<ResponseErrorViewModel>(ex)),
                _ => StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new ResponseErrorViewModel
                    {
                        Type = "ServerError",
                        Message = ex.Message
                    }
                ),
            };
        }
    }

    [HttpPut]
    [Route("{categoryId}")]
    public async Task<IActionResult> UpdateCategory(int categoryId, [FromBody] UpdateCategoryViewModel categoryToUpdate)
    {
        try
        {
            if(!ModelState.IsValid)    
                return BadRequest(ModelState.Values.SelectMany(v => v.Errors));
            
            var categoryMapped =_mapper.Map<UpdateCategoryDTO>(categoryToUpdate); 
            categoryMapped.CategoryId = categoryId;
            var category = await _categoryService.UpdateCategory(categoryMapped);
            
            return Ok(category);
        }
        catch (Exception ex)
        {
            return ex switch
            {
                ResourceNotFoundException or
                CategoryNameAlreadyExistsException => BadRequest(_mapper.Map<ResponseErrorViewModel>(ex)),
                _ => StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new ResponseErrorViewModel
                    {
                        Type = "ServerError",
                        Message = ex.Message
                    }
                ),
            };
        }
    }

    [HttpDelete]
    [Route("{categoryId}")]
    public async Task<IActionResult> DeleteCategory(int categoryId)
    {
        try
        {
            await _categoryService.DeleteCategory(categoryId);
            return NoContent();
        }
        catch (Exception ex)
        {
            return ex switch
            {
                ResourceNotFoundException => BadRequest(_mapper.Map<ResponseErrorViewModel>(ex)),
                _ => StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new ResponseErrorViewModel
                    {
                        Type = "ServerError",
                        Message = ex.Message
                    }
                ),
            };
        }
    }
}
