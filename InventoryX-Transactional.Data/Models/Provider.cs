using InventoryX_Transactional.Data.Models.Common;

namespace InventoryX_Transactional.Data.Models;

public class Provider : Audit
{
    public Guid ProviderId { get; set; }
    public string BusinessName { get; set; }
    public string RUC { get; set; }
    public string ContactEmail { get; set; }
    public string ContactPhone { get; set; }
    public string Address { get; set; }


    // public List<Receipt> Receipts { get; set; } = new();
}
