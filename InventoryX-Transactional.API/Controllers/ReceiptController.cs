using AutoMapper;
using InventoryX_Transactional.API.ViewModels.Receipt;
using InventoryX_Transactional.Services;
using InventoryX_Transactional.Services.DTOs.Receipt;
using Microsoft.AspNetCore.Mvc;

namespace InventoryX_Transactional.API.Controllers;

[ApiController]
[Route("[controller]s")]
public class ReceiptController : ControllerBase
{
    private readonly IReceiptService _receiptService;
    private readonly IMapper _mapper;

    public ReceiptController(IReceiptService receiptService, IMapper mapper)
    {
        _receiptService = receiptService;
        _mapper = mapper;
    }


    [HttpGet]
    public async Task<IActionResult> GetReceipts()
    {
        return Ok();
    }

    [HttpGet]
    [Route("{receiptId}")]
    public async Task<IActionResult> GetReceipt(Guid receiptId)
    {
        return Ok(new { Id = receiptId });
    }

    [HttpPost]
    public async Task<IActionResult> CreateReceipt([FromBody] NewReceiptViewModel receipt)
    {
        await _receiptService.CreateReceipt(_mapper.Map<NewReceiptDTO>(receipt)); 
        return Ok(receipt);
    }

}
