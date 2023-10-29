using AutoMapper;
using InventoryX_Transactional.Data.Models;
using InventoryX_Transactional.Repository;
using InventoryX_Transactional.Services.DTOs.Warehouse;
using InventoryX_Transactional.Services.Exceptions;
using InventoryX_Transactional.Services.Exceptions.Warehouse;

namespace InventoryX_Transactional.Services;

public class WarehouseService : IWarehouseService
{
    private readonly IWarehouseRepository _warehouseRepository;
    private readonly IMapper _mapper;

    public WarehouseService(IWarehouseRepository warehouseRepository, IMapper mapper)
    {
        _warehouseRepository = warehouseRepository;
        _mapper = mapper;
    }

    public async Task<WarehouseDTO> GetWarehouseById(int id)
    {
        var warehouse = await _warehouseRepository.GetByIdAsync(id)
            ?? throw new ResourceNotFoundException("Warehouse cannot be found.");

        return _mapper.Map<WarehouseDTO>(warehouse);
    }

    public async Task<List<WarehouseDTO>> GetWarehouses()
    {
        var warehouses = await _warehouseRepository.GetByConditionAsync(c => true);
        return warehouses.Select(c => _mapper.Map<WarehouseDTO>(c)).ToList();
    }

    public async Task<WarehouseDTO> CreateWarehouse(NewWarehouseDTO warehouse)
    {
        await ValidateWarehouse(warehouse);

        var warehouseToCreate = _mapper.Map<Warehouse>(warehouse);
        warehouseToCreate.CreatedBy = "";

        var warehouseCreated = await _warehouseRepository.AddAsync(warehouseToCreate);
        await _warehouseRepository.SaveAsync();

        return _mapper.Map<WarehouseDTO>(warehouseCreated);
    }

    public async Task<WarehouseDTO> UpdateWarehouse(UpdateWarehouseDTO warehouse)
    {
        var warehouseFound = await _warehouseRepository.GetByIdAsync(warehouse.WarehouseId)
            ?? throw new ResourceNotFoundException("Warehouse cannot be found.");

        await ValidateWarehouse(warehouse);

        var warehouseToUpdate = _mapper.Map<Warehouse>(warehouse);
        warehouseToUpdate.CreatedBy = warehouseFound.CreatedBy;
        warehouseToUpdate.CreatedAt = warehouseFound.CreatedAt;
        warehouseToUpdate.ModifiedBy = "";

        var warehouseUpdated = _warehouseRepository.Update(warehouseToUpdate);
        await _warehouseRepository.SaveAsync();

        return _mapper.Map<WarehouseDTO>(warehouseUpdated);
    }

    public async Task DeleteWarehouse(int id)
    {
        var result = _warehouseRepository.Delete(id);
        if(result == RepositoryOperation.Failed)
            throw new ResourceNotFoundException("Warehouse cannot be found.");
        await _warehouseRepository.SaveAsync();
    }

    public async Task ValidateWarehouse(NewWarehouseDTO warehouse)
    {
        if(warehouse.MaxStock <= 0)
            throw new InvalidStockValueException("An warehouse needs to have MaxStock greater than zero.");

        var warehouseByName = (await _warehouseRepository.GetByConditionAsync(w => w.Name == warehouse.Name)).FirstOrDefault();
        if(warehouseByName != null)
            throw new WarehouseWithExistingNameException("The name of the warehouse already exists.");
    }

    public async Task ValidateWarehouse(UpdateWarehouseDTO warehouse)
    {
        if(warehouse.MaxStock <= 0)
            throw new InvalidStockValueException("An warehouse needs to have MaxStock greater than zero.");

        var warehouseByName = (await _warehouseRepository.GetByConditionAsync(w => w.Name == warehouse.Name && w.WarehouseId != warehouse.WarehouseId)).FirstOrDefault();
        if(warehouseByName != null)
            throw new WarehouseWithExistingNameException("The name of the warehouse already exists.");
    }
}
