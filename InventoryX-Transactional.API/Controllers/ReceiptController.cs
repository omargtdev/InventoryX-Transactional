using AutoMapper;
using InventoryX_Transactional.API.ViewModels;
using InventoryX_Transactional.Services;
using InventoryX_Transactional.Services.DTOs.Receipt;
using InventoryX_Transactional.Services.Exceptions;
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
        var receipts = await _receiptService.GetReceipts();
        return Ok(receipts);
    }

    [HttpGet]
    [Route("{receiptId}")]
    public async Task<IActionResult> GetReceipt(Guid receiptId)
    {
        return Ok(new { Id = receiptId });
    }

    [HttpPost]
    public async Task<IActionResult> CreateReceipt([FromForm] NewReceiptDTO receipt)
    {
        try
        {
            var response = await _receiptService.CreateReceipt(receipt);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return ex switch
            {
                ResourceNotFoundException => NotFound(_mapper.Map<ResponseErrorViewModel>(ex)),
                EntityRuleException => BadRequest(_mapper.Map<ResponseErrorViewModel>(ex)),
                _ => StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new ResponseErrorViewModel
                    {
                        Type = "ServerError",
                        Message = ex.Message
                    }
                ),
            };
        }
    }

    //[HttpPost]
    //[Route("referralGuide")]
    //public async Task<IActionResult> UploadReferralGuid([FromForm] UploadFileDTO upload)
    //{
    //    try
    //    {
    //        return Ok(await _receiptService.UploadReferralGuide(upload.File));
    //    }
    //    catch (Exception ex)
    //    {
    //        return StatusCode(
    //                StatusCodes.Status500InternalServerError,
    //                new ResponseErrorViewModel
    //                {
    //                    Type = "ServerError",
    //                    Message = ex.Message
    //                }
    //        );
    //    }
    //}

}
