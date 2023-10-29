using AutoMapper;
using InventoryX_Transactional.API.ViewModels;
using InventoryX_Transactional.API.ViewModels.Warehouse;
using InventoryX_Transactional.Services;
using InventoryX_Transactional.Services.DTOs.Warehouse;
using InventoryX_Transactional.Services.Exceptions;
using InventoryX_Transactional.Services.Exceptions.Warehouse;
using Microsoft.AspNetCore.Mvc;

namespace InventoryX_Transactional.API;

[ApiController]
[Route("[controller]s")]
public class WarehouseController : ControllerBase
{
    private readonly IWarehouseService _warehouseService;
    private readonly IMapper _mapper;

    public WarehouseController(IWarehouseService warehouseService, IMapper mapper)
    {
        _warehouseService = warehouseService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<List<WarehouseViewModel>>> GetWarehouses()
    {
        var warehouses = await _warehouseService.GetWarehouses();
        return Ok(warehouses.Select(c => _mapper.Map<WarehouseViewModel>(c)));
    }

    [HttpGet]
    [Route("{warehouseId}")]
    public async Task<ActionResult<WarehouseViewModel>> GetWarehouseById(int warehouseId)
    {
        try
        {
            var warehouse = await _warehouseService.GetWarehouseById(warehouseId);
            
            return Ok(_mapper.Map<WarehouseViewModel>(warehouse));
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
    public async Task<IActionResult> CreateWarehouse([FromBody] NewWarehouseViewModel newWarehouse)
    {
        try
        {
            if(!ModelState.IsValid)    
                return BadRequest(ModelState.Values.SelectMany(v => v.Errors));
            
            var warehouse = await _warehouseService.CreateWarehouse(_mapper.Map<NewWarehouseDTO>(newWarehouse));
            return CreatedAtAction(null, warehouse);
        }
        catch (Exception ex)
        {
            return ex switch
            {
                InvalidStockValueException or
                WarehouseWithExistingNameException => BadRequest(_mapper.Map<ResponseErrorViewModel>(ex)),
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
    [Route("{warehouseId}")]
    public async Task<IActionResult> UpdateWarehouse(int warehouseId, [FromBody] UpdateWarehouseViewModel warehouseToUpdate)
    {
        try
        {
            if(!ModelState.IsValid)    
                return BadRequest(ModelState.Values.SelectMany(v => v.Errors));
            
            var warehouseMapped =_mapper.Map<UpdateWarehouseDTO>(warehouseToUpdate); 
            warehouseMapped.WarehouseId = warehouseId;
            var warehouse = await _warehouseService.UpdateWarehouse(warehouseMapped);
            
            return Ok(warehouse);
        }
        catch (Exception ex)
        {
            return ex switch
            {
                ResourceNotFoundException or
                InvalidStockValueException or
                WarehouseWithExistingNameException => BadRequest(_mapper.Map<ResponseErrorViewModel>(ex)),
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
    [Route("{warehouseId}")]
    public async Task<IActionResult> DeleteWarehouse(int warehouseId)
    {
        try
        {
            await _warehouseService.DeleteWarehouse(warehouseId);
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
