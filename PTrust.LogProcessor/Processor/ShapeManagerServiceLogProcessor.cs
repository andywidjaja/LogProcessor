using System.Configuration;

namespace PTrust.LogProcessor.Processor
{
    public class ShapeManagerServiceLogProcessor : LogProcessor<ShapeManagerServiceLogProcessor>
    {
        public ShapeManagerServiceLogProcessor() : base(ConfigurationManager.AppSettings["ShapeManagerServiceId"])
        {            
        }
    }
}