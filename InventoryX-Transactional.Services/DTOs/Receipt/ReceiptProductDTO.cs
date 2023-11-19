namespace InventoryX_Transactional.Services;

public class ReceiptProductDTO
{
    public string Code { get; set; } = string.Empty;
    public int Count { get; set; }
    public decimal UnitPurchasePrice { get; set; }
    public decimal UnitSalesPrice { get; set; }
}
