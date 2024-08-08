using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Platform360.CIFTAY.Jobs.Services;

namespace Platform360.CIFTAY.Jobs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatedDataController : ControllerBase
    {
        private readonly ILogger<CalculatedDataController> _logger;
        private readonly ICalculatedDataService _calculatedDataService;

        public CalculatedDataController(ILogger<CalculatedDataController> logger, ICalculatedDataService calculatedDataService)
        {
            _logger = logger;
            _calculatedDataService = calculatedDataService;
        }

        [HttpGet("GetCalculatedData")]
        public IActionResult GetCalculatedData()
        {
            var data = _calculatedDataService.GetCalculatedData();
            return Ok(data);
        }

        [HttpGet("TestDbConnection")]
        public IActionResult TestDbConnection()
        {
            var canConnect = _calculatedDataService.TestDbConnection();
            if (canConnect)
            {
                return Ok("Database connection is working.");
            }
            else
            {
                return StatusCode(500, "Cannot connect to the database.");
            }
        }
    }
}
