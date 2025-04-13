using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TestTaskDaData.AddressProcessApi.Services.AddressProcessService;

namespace TestTaskDaData.AddressProcessApi.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AddressController(IAddressProcessService addressProcessService) : ControllerBase
{
    private readonly IAddressProcessService _addressProcessService = addressProcessService;

    [HttpGet("process")]
    public async Task<IActionResult> ProcessAddress([FromQuery] string address)
    {
        if (string.IsNullOrWhiteSpace(address)) return BadRequest("Параметр address не может быть пустым");
        
        var serviceResponse = await _addressProcessService.AddressProcessAsync(address);

        return Ok(serviceResponse);
    }
}