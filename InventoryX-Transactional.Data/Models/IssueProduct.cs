namespace InventoryX_Transactional.Data.Models;

public class IssueProduct
{
    public Guid IssueId { get; set; }
    public int ProductId { get; set; }
    public decimal UnitPriceForSale { get; set; }
    public int Quantity { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }


    public Issue Issue { get; set; }
    public Product Product { get; set; }
}
