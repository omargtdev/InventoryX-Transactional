using AutoMapper;
using InventoryX_Transactional.API.ViewModels;
using InventoryX_Transactional.Services;
using InventoryX_Transactional.Services.DTOs.Issue;
using InventoryX_Transactional.Services.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace InventoryX_Transactional.API.Controllers;

[ApiController]
[Route("[controller]s")]
public class IssueController : ControllerBase
{
    private readonly IIssueService _issueService;
    private readonly IMapper _mapper;

    public IssueController(IIssueService issueService, IMapper mapper)
    {
        _issueService = issueService;
        _mapper = mapper;
    }


    // [HttpGet]
    // public async Task<IActionResult> GetIssues()
    // {
    //     var receipts = await _issueService.GetIssues();
    //     return Ok(receipts);
    // }

    [HttpGet]
    [Route("{receiptId}")]
    public async Task<IActionResult> GetReceipt(Guid receiptId)
    {
        return Ok(new { Id = receiptId });
    }

    [HttpPost]
    public async Task<IActionResult> CreateIssue([FromBody] NewIssueDTO issue)
    {
        try
        {
            var response = await _issueService.CreateIssueAsync(issue);
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
}
