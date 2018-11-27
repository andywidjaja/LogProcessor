using System.Configuration;

namespace PTrust.LogProcessor.Processor
{
    public class PrepaymentVectorServiceLogProcessor : LogProcessor<PrepaymentVectorServiceLogProcessor>
    {
        public PrepaymentVectorServiceLogProcessor() : base(ConfigurationManager.AppSettings["PrepaymentVectorServiceId"])
        {            
        }
    }
}