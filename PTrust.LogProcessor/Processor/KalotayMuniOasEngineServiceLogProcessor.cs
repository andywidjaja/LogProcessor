using System.Configuration;

namespace PTrust.LogProcessor.Processor
{
    public class KalotayMuniOasEngineServiceLogProcessor : LogProcessor<KalotayMuniOasEngineServiceLogProcessor>
    {
        public KalotayMuniOasEngineServiceLogProcessor() : base(ConfigurationManager.AppSettings["KalotayMuniOasEngineServiceId"])
        {
        }
    }
}