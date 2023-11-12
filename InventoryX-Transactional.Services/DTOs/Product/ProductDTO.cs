namespace InventoryX_Transactional.Services.DTOs.Product;

public record ProductDTO(
    int Id,
    string Code,
    string Name,
    string Description,
    string Brand,
    bool IsActive,
    ProductCategoryDTO Category,
    ProductWarehouseDTO Warehouse
    );


public record ProductCategoryDTO(
    int Id,
    string Name
    );

public record ProductWarehouseDTO(
    int Id,
    string Name
    );
