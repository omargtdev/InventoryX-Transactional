using InventoryX_Transactional.Data.Models.Common;

namespace InventoryX_Transactional.Data.Models;

public class ProductPrice
{
    public int ProductPriceId { get; set; }
    public decimal LastReceiptPrice { get; set; }
    public decimal LastIssuePrice { get; set; }
    public DateTime CreatedAt { get; set; }
    public string CreatedBy { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
}
