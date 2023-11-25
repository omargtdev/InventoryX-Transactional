namespace InventoryX_Transactional.Services.DTOs.Product;

public class ProductDTO
{
    public int Id { get; set; }
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Brand { get; set; } = string.Empty;
    public int Stock { get; set; }
    public ProductCategoryDTO Category { get; set; } = new ProductCategoryDTO();
    public ProductWarehouseDTO Warehouse { get; set; } = new ProductWarehouseDTO();

}


public class ProductCategoryDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

}

public class ProductWarehouseDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
