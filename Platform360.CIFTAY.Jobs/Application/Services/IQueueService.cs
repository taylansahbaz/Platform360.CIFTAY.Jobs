using RabbitMQ.Client;
using System.Text;
using System.Threading.Tasks;

namespace Platform360.CIFTAY.Jobs.Services
{
    public interface IQueueService
    {
        Task SendMessageAsync(string messageBody);
    }

    public class QueueService : IQueueService
    {
        private readonly string _host;
        private readonly string _queueName;

        public QueueService(string host, string queueName)
        {
            _host = host;
            _queueName = queueName;
        }

        public async Task SendMessageAsync(string messageBody)
        {
            var factory = new ConnectionFactory() { HostName = _host };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();

            channel.QueueDeclare(queue: _queueName, durable: false, exclusive: false, autoDelete: false, arguments: null);
            var body = Encoding.UTF8.GetBytes(messageBody);

            channel.BasicPublish(exchange: "", routingKey: _queueName, basicProperties: null, body: body);
        }
    }
}