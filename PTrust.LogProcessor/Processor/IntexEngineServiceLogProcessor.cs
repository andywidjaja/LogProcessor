using System.Configuration;

namespace PTrust.LogProcessor.Processor
{
    public class IntexEngineServiceLogProcessor : LogProcessor<IntexEngineServiceLogProcessor>
    {
        public IntexEngineServiceLogProcessor() : base(ConfigurationManager.AppSettings["IntexEngineServiceId"])
        {
        }
    }
}