using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Platform360.CIFTAY.Jobs.Data;
using Platform360.CIFTAY.Jobs.Models;
using System.Linq;

namespace Platform360.CIFTAY.Jobs.Services
{
    public interface ICalculatedDataService
    {
        IEnumerable<Calculatedlastdatum> GetCalculatedData();
        bool TestDbConnection();
    }

    public class CalculatedDataService : ICalculatedDataService
    {
        private readonly ciftayContext _context;
        private readonly ILogger<CalculatedDataService> _logger;

        public CalculatedDataService(ciftayContext context, ILogger<CalculatedDataService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IEnumerable<Calculatedlastdatum> GetCalculatedData()
        {
            try
            {
                return _context.Calculatedlastdata.ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving data from the database.");
                return Enumerable.Empty<Calculatedlastdatum>();
            }
        }

        public bool TestDbConnection()
        {
            try
            {
                return _context.Database.CanConnect();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while connecting to the database.");
                return false;
            }
        }
    }
}
