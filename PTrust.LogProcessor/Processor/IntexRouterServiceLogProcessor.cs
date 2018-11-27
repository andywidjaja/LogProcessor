using System.Configuration;

namespace PTrust.LogProcessor.Processor
{
    public class IntexRouterServiceLogProcessor : LogProcessor<IntexRouterServiceLogProcessor>
    {
        public IntexRouterServiceLogProcessor() : base(ConfigurationManager.AppSettings["IntexRouterServiceId"])
        {
        }
    }
}