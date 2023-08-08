using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace sbehsreematt56faV1
{
    public class eventhub1
    {
        private readonly ILogger _logger;

        public eventhub1(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<eventhub1>();
        }

        [Function("eventhub1")]
        public void Run([EventHubTrigger("ehname", Connection = "ehconnstring", ConsumerGroup = "consumergroup1")] string[] input)
        {
            _logger.LogInformation($"First Event Hubs triggered message: {input[0]}");
        }
    }
}
