using System.Configuration;

namespace PTrust.LogProcessor.Processor
{
    public class YieldBookEnginePayloadProcessor : EnginePayloadProcessor<YieldBookEnginePayloadProcessor>
    {
        public YieldBookEnginePayloadProcessor() : base(ConfigurationManager.AppSettings["YieldBookServiceId"])
        {            
        }
    }
}