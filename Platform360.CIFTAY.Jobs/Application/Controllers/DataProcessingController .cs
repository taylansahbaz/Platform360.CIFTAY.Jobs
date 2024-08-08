using Microsoft.AspNetCore.Mvc;
using Platform360.CIFTAY.Jobs.Application.Services;
using Platform360.CIFTAY.Jobs.Services;

namespace Platform360.CIFTAY.Jobs.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class DataProcessingController : ControllerBase
    {
        private readonly ILogger<DataProcessingController> _logger;
        private readonly IDataProcessingService _dataProcessingService;
    
        public DataProcessingController(ILogger<DataProcessingController> logger, IDataProcessingService dataProcessingService)
        {
            _logger = logger;
            _dataProcessingService = dataProcessingService;
        }

        [HttpPost("ProcessData")]
        public async Task<IActionResult> ProcessData()
        {
            try
            {
                await _dataProcessingService.ProcessDataAsync();
                return Ok("Send to queue basarili");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "error occupied when process data");
                return StatusCode(500, "error occupied when process data");
            }
        }
    }
}
