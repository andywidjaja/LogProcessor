using System.Configuration;

namespace PTrust.LogProcessor.Processor
{
    public class ShapeManagerApiGatewayLogProcessor : LogProcessor<ShapeManagerApiGatewayLogProcessor>
    {
        public ShapeManagerApiGatewayLogProcessor() : base(ConfigurationManager.AppSettings["ShapeManagerApiGatewayId"])
        {            
        }
    }
}