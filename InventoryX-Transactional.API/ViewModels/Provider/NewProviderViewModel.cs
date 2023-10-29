using System.ComponentModel.DataAnnotations;

namespace InventoryX_Transactional.API.ViewModels.Provider;

public class NewProviderViewModel
{
    [Required(ErrorMessage = "The Business Name field is required.")]
    [MinLength(3, ErrorMessage = "Business Name must be at least 3 characters long")]
    public string BusinessName { get; set; } = null!;

    [Required(ErrorMessage = "The RUC field is required.")]
    [RegularExpression(@"^\d+$", ErrorMessage = "RUC must contain only numbers")]
    public string RUC { get; set; } = null!;

    [Required(ErrorMessage = "The Contact Email field is required.")]
    [EmailAddress(ErrorMessage = "The Contact Email field must be a valid email address.")]
    public string ContactEmail { get; set; } = null!;

    [Required(ErrorMessage = "The Contact Phone field is required.")]
    [RegularExpression(@"^\+?[1-9]\d{1,14}$", ErrorMessage = "The Contact Phone field must be a valid phone number.")]
    public string ContactPhone { get; set; } = null!;

    [Required(ErrorMessage = "The Address field is required.")]
    [MinLength(3, ErrorMessage = "Adress must be at least 3 characters long")]
    public string Address { get; set; } = null!;

}