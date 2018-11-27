using System.Configuration;

namespace PTrust.LogProcessor.Processor
{
    public class ShapeManagerRouterServiceLogProcessor : LogProcessor<ShapeManagerRouterServiceLogProcessor>
    {
        public ShapeManagerRouterServiceLogProcessor() : base(ConfigurationManager.AppSettings["ShapeManagerRouterServiceId"])
        {            
        }
    }
}