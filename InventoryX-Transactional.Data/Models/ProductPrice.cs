namespace InventoryX_Transactional.Data.Models;

public class ProductPrice
{
    public int ProductPriceId { get; set; }
    public decimal LastReceiptPrice { get; set; }
    public decimal LastIssuePrice { get; set; }
    public DateTime UpdatedAt { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
}
