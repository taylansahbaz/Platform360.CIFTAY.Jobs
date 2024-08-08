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
        Task SendDataToQueueAsync();
    }

    public class CalculatedDataService : ICalculatedDataService
    {
        private readonly ciftayContext _context;
        private readonly ILogger<CalculatedDataService> _logger;
        private readonly IQueueService _queueService;

        public CalculatedDataService(ciftayContext context, ILogger<CalculatedDataService> logger, IQueueService queueService)
        {
            _context = context;
            _logger = logger;
            _queueService = queueService;
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
        public async Task SendDataToQueueAsync()
        {
            var data = GetCalculatedData();
            foreach (var item in data)
            {
                var messageBody = Newtonsoft.Json.JsonConvert.SerializeObject(item);
                await _queueService.SendMessageAsync(messageBody);
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
