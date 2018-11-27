using System.Configuration;

namespace PTrust.LogProcessor.Processor
{
    public class KalotayBondOasEngineServiceLogProcessor : LogProcessor<KalotayBondOasEngineServiceLogProcessor>
    {
        public KalotayBondOasEngineServiceLogProcessor() : base(ConfigurationManager.AppSettings["KalotayBondOasEngineServiceId"])
        {
        }
    }
}