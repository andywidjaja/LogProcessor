using System.Configuration;

namespace PTrust.LogProcessor.Processor
{
    public class YieldBookServiceLogProcessor : LogProcessor<YieldBookServiceLogProcessor>
    {
        public YieldBookServiceLogProcessor() : base(ConfigurationManager.AppSettings["YieldBookServiceId"])
        {            
        }
    }
}