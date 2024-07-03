using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace azure_functions
{
    public class UpdateSubscription
    {
        private readonly ILogger _logger;
        private readonly IPaymentRepository paymentRepository

        public UpdateSubscription(ILoggerFactory loggerFactory, IPaymentRepository paymentRepository)
        {
            _logger = loggerFactory.CreateLogger<UpdateSubscription>();
        }

        [Function("Function1")]
        public void Run([TimerTrigger("0 */5 * * * *")] TimerInfo myTimer)
        {
            _logger.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
            
            if (myTimer.ScheduleStatus is not null)
            {
                _logger.LogInformation($"Next timer schedule at: {myTimer.ScheduleStatus.Next}");
            }
        }
    }
}
