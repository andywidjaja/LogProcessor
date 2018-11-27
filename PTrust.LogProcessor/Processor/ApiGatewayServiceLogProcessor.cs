using System.Configuration;

namespace PTrust.LogProcessor.Processor
{
    public class ApiGatewayServiceLogProcessor : LogProcessor<ApiGatewayServiceLogProcessor>
    {
        public ApiGatewayServiceLogProcessor() : base(ConfigurationManager.AppSettings["ApiGatewayServiceId"])
        {
        }
    }
}