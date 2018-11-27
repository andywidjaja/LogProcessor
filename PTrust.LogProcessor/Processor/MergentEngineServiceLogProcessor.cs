using System.Configuration;

namespace PTrust.LogProcessor.Processor
{
    public class MergentEngineServiceLogProcessor : LogProcessor<MergentEngineServiceLogProcessor>
    {
        public MergentEngineServiceLogProcessor() : base(ConfigurationManager.AppSettings["MergentEngineServiceId"])
        {
        }
    }
}