using System.ComponentModel.DataAnnotations;

namespace InventoryX_Transactional.API.ViewModels.Warehouse;

public class NewWarehouseViewModel
{
    [Required(ErrorMessage = "The Name field is required.")]

    [MinLength(3, ErrorMessage = "The Name field must be at least 3 characters long.")]
    public string Name { get; set; } = null!;
    public string? Description { get; set; }

    [Required(ErrorMessage = "The MaxStock field is required.")]
    public int MaxStock { get; set; }

    [Required(ErrorMessage = "The Address field is required.")]
    public string Address { get; set; } = null!;

    [Required(ErrorMessage = "The District field is required.")]
    public string District { get; set; } = null!;

    [Required(ErrorMessage = "The Province field is required.")]
    public string Province { get; set; } = null!;

    [Required(ErrorMessage = "The City field is required.")]
    public string City { get; set; } = null!;
}
