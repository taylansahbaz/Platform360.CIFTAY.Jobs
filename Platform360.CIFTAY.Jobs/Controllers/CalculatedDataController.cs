using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using Platform360.CIFTAY.Jobs.Data;
using Platform360.CIFTAY.Jobs.Models;

namespace Platform360.CIFTAY.Jobs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatedDataController : ControllerBase
    {
        private readonly ILogger<CalculatedDataController> _logger;
        private readonly ciftayContext _context;

        public CalculatedDataController(ILogger<CalculatedDataController> logger, ciftayContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("GetCalculatedData")]
        public IActionResult GetCalculatedData()
        {
            try
            {
                var data = _context.Calculatedlastdata.ToList();
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving data from the database.");
                return StatusCode(500, "Error: " + ex.Message);
            }
        }       // Controlleri servis haline getir ICalculated interface olustur, ICalculateddATAService context boyle bverimli degil servi, .n

        [HttpGet("TestDbConnection")]
        public IActionResult TestDbConnection()
        {
            try
            {
                var canConnect = _context.Database.CanConnect();
                if (canConnect)
                {
                    return Ok("Database connection is working.");
                }
                else
                {
                    return StatusCode(500, "Cannot connect to the database.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while connecting to the database.");
                return StatusCode(500, "Error: " + ex.Message);
            }
        }
    }
}
