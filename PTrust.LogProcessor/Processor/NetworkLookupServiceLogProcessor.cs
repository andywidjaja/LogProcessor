using System.Configuration;

namespace PTrust.LogProcessor.Processor
{
    public class NetworkLookupServiceLogProcessor : LogProcessor<NetworkLookupServiceLogProcessor>
    {
        public NetworkLookupServiceLogProcessor() : base(ConfigurationManager.AppSettings["NetworkLookupServiceId"])
        {
        }
    }
}