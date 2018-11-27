using System.Configuration;

namespace PTrust.LogProcessor.Processor
{
    public class BloombergEngineServiceLogProcessor : LogProcessor<BloombergEngineServiceLogProcessor>
    {
        public BloombergEngineServiceLogProcessor() : base(ConfigurationManager.AppSettings["BloombergEngineServiceId"])
        {
        }
    }
}