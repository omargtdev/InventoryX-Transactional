using AutoMapper;
using InventoryX_Transactional.API.ViewModels;
using InventoryX_Transactional.Services.DTOs.Category;
using InventoryX_Transactional.Services.Exceptions;
using InventoryX_Transactional.Services;
using Microsoft.AspNetCore.Mvc;
using InventoryX_Transactional.Services.DTOs.Product;

namespace InventoryX_Transactional.API.Controllers;

[ApiController]
[Route("products")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;
    private readonly IMapper _mapper;

    public ProductController(IProductService productService, IMapper mapper)
    {
        _productService = productService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<List<CategoryDTO>>> GetProducts()
    {
        var categories = await _productService.GetProducts();
        return Ok(categories);
    }

    [HttpGet]
    [Route("{productId}")]
    public async Task<ActionResult<CategoryViewModel>> GetProductById(int productId)
    {
        try
        {
            var product = await _productService.GetProductById(productId);
            return Ok(product);
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
    public async Task<IActionResult> CreateProduct([FromBody] NewProductDTO newProduct)
    {
        try
        {
            var product = await _productService.CreateProduct(newProduct);
            return CreatedAtAction(null, product);
        }
        catch (Exception ex)
        {
            return ex switch
            {
                EntityRuleException or
                DuplicateEntityException or
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

    [HttpPut]
    [Route("{productId}")]
    public async Task<IActionResult> UpdateProduct(int productId, [FromBody] UpdateProductDTO productToUpdate)
    {
        try
        {
            productToUpdate.Id = productId;
            var product = await _productService.UpdateProduct(productToUpdate);
            return Ok(product);
        }
        catch (Exception ex)
        {
            return ex switch
            {
                EntityRuleException or
                DuplicateEntityException or
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

    [HttpDelete]
    [Route("{productId}")]
    public async Task<IActionResult> DeleteProduct(int productId)
    {
        try
        {
            await _productService.DeleteProduct(productId);
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
