using System.Configuration;

namespace PTrust.LogProcessor.Processor
{
    public class PerformanceTrustEngineServiceLogProcessor : LogProcessor<PerformanceTrustEngineServiceLogProcessor>
    {
        public PerformanceTrustEngineServiceLogProcessor() : base(ConfigurationManager.AppSettings["PerformanceTrustEngineServiceId"])
        {
        }
    }
}