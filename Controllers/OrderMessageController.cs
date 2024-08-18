using Confluent.Kafka;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderMessageController : ControllerBase
    {
        private readonly string kafkaTopic = "glo-webhook-topic";
        private readonly string kafkaBootstrapServers = "192.168.0.136:9092"; // Update with your Kafka broker address

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] OrderMessage message)
        {
            var config = new ProducerConfig { BootstrapServers = kafkaBootstrapServers };

            using (var producer = new ProducerBuilder<Null, string>(config).Build())
            {
                var jsonMessage = JsonSerializer.Serialize(message);
                var result = await producer.ProduceAsync(kafkaTopic, new Message<Null, string> { Value = jsonMessage });

                return Ok(new { result.TopicPartitionOffset });
            }
        }
    }
}
