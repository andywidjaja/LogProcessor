using System.Configuration;

namespace PTrust.LogProcessor.Processor
{
    public class MasterDataServiceLogProcessor : LogProcessor<MasterDataServiceLogProcessor>
    {
        public MasterDataServiceLogProcessor() : base(ConfigurationManager.AppSettings["MaterDataServiceId"])
        {            
        }
    }
}