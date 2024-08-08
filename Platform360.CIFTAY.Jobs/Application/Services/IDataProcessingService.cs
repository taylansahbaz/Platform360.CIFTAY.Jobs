using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Platform360.CIFTAY.Jobs.Services;
using System.Text.Json;

namespace Platform360.CIFTAY.Jobs.Application.Services
{
    public interface IDataProcessingService
    {
        Task ProcessDataAsync();
    }
    public class DataProcessingService : IDataProcessingService
    {
        private readonly ICalculatedDataService _calculatedDataService;
        private readonly IQueueService _queueService;

        public DataProcessingService(ICalculatedDataService calculatedDataService, IQueueService queueService)
        {
            _calculatedDataService = calculatedDataService;
            _queueService = queueService;
        }
        public async Task ProcessDataAsync()
        {
            try
            {
                var data = _calculatedDataService.GetCalculatedData();

                foreach (var item in data)
                {
                    var jsonMessage = JsonSerializer.Serialize(new
                    {
                        item.SubstationCode,
                        item.DataDate,
                        item.SensorGrupları,
                        item.Alh1,
                        item.Alh2,
                        item.Alh3,
                        item.Alh4,
                        item.Alh5,
                        item.Alh6,
                        item.Alh7,
                        item.Alh8,
                        item.Alh9,
                        item.Alh10,
                        item.Alh11,
                        item.Alh12,
                        item.Alh13,
                        item.Alh14,
                        item.Alh15,
                        item.Alh16
                    });
                    await _queueService.SendMessageAsync(jsonMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing data: {ex.Message}");
                throw;
            }
        }
    }
}
