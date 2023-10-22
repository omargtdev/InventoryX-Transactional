using InventoryX_Transactional.Data.Models.Common;

namespace InventoryX_Transactional.Data.Models;

public class Client : Audit
{
    public Guid ClientId { get; set; }
    public string Name { get; set; }
    public DocumentType DocumentType { get; set; }
    public string DocumentNumber { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public bool IsLegal { get; set; }


    // public List<Issue> Issues { get; set; } = new();
}

public enum DocumentType 
{
    DNI = 1,
    RUC = 2,
    ImmigrationCard = 3
}
