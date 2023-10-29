using System.ComponentModel.DataAnnotations;

namespace InventoryX_Transactional.API.ViewModels.Client;

public class UpdateClientViewModel
{

    public Guid Id { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [MinLength(3, ErrorMessage = "Name must be at least 3 characters long")]
    public string Name { get; set; }

    [Required(ErrorMessage = "DocumentType is required")]
    [EnumDataType(typeof(DocumentTypeViewModel), ErrorMessage = "Invalid DocumentType")]
    public DocumentTypeViewModel DocumentType { get; set; }

    [Required(ErrorMessage = "DocumentNumber is required")]
    [RegularExpression(@"^\d+$", ErrorMessage = "DocumentNumber must contain only numbers")]
    public string DocumentNumber { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email format")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Phone is required")]
    [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Phone must be valid")]
    public string Phone { get; set; }

    public string? Address { get; set; }

    [Required(ErrorMessage = "IsLegal is required")]
    public bool? IsLegal { get; set; }

}
