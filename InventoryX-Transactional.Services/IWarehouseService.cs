using InventoryX_Transactional.Services.DTOs.Warehouse;

namespace InventoryX_Transactional.Services;

public interface IWarehouseService
{
    Task<List<WarehouseDTO>> GetWarehouses();
    Task<WarehouseDTO> GetWarehouseById(int id);
    Task<WarehouseDTO> CreateWarehouse(NewWarehouseDTO warehouse);
    Task<WarehouseDTO> UpdateWarehouse(UpdateWarehouseDTO warehouse);
    Task DeleteWarehouse(int id);
}
