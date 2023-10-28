﻿namespace InventoryX_Transactional.Services.DTOs.Provider;

public class NewProviderDTO
{
    public string BusinessName { get; set; } = null!;
    public string RUC { get; set; } = null!;
    public string ContactEmail { get; set; } = null!;
    public string ContactPhone { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string ActionBy { get; set; } = null!;
}
