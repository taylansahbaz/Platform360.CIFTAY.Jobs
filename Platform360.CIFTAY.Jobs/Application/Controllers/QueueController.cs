using Microsoft.AspNetCore.Mvc;
using Platform360.CIFTAY.Jobs.Services;

[ApiController]
[Route("[controller]")]
public class QueueController : ControllerBase
{
    private readonly ILogger<QueueController> _logger;
    private readonly ICalculatedDataService _calculatedDataService;

    public QueueController(ILogger<QueueController> logger, ICalculatedDataService calculatedDataService)
    {
        _logger = logger;
        _calculatedDataService = calculatedDataService;
    }

    [HttpPost("SendData")]
    public async Task<IActionResult> SendDataToQueue()
    {
        try
        {
            await _calculatedDataService.SendDataToQueueAsync();
            return Ok("Data sent to the queue successfully.");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error olustu while sending data to the queue.");
            return StatusCode(500, "An error olustu while sending data to the queue.");
        }
    }
}
