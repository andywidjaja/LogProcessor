using System;
using System.Configuration;

using Common.Logging;
using EasyNetQ;
using PTrust.LogMessages;
using PTrust.LogProcessor.Processor;

namespace PTrust.LogProcessor
{
    public class LogProcessorManager
    {
        private static readonly ILog Log = LogManager.GetLogger<LogProcessorManager>();

        private static readonly IBus Bus = RabbitHutch.CreateBus(ConfigurationManager.AppSettings["PtLoggerEndpoint"]);

        private static readonly EnginePayloadProcessor<YieldBookEnginePayloadProcessor> YbsEnginePayloadProcessor = new YieldBookEnginePayloadProcessor();

        private static readonly LogProcessor<ApiGatewayServiceLogProcessor> AgsLogProcessor = new ApiGatewayServiceLogProcessor();
        private static readonly LogProcessor<BloombergEngineServiceLogProcessor> BbesLogProcessor = new BloombergEngineServiceLogProcessor();
        private static readonly LogProcessor<IntexEngineServiceLogProcessor> IesLogProcessor = new IntexEngineServiceLogProcessor();
		private static readonly LogProcessor<IntexRouterServiceLogProcessor> IrsLogProcessor = new IntexRouterServiceLogProcessor();
        private static readonly LogProcessor<KalotayBondOasEngineServiceLogProcessor> KbesLogProcessor = new KalotayBondOasEngineServiceLogProcessor();
        private static readonly LogProcessor<KalotayMuniOasEngineServiceLogProcessor> KmesLogProcessor = new KalotayMuniOasEngineServiceLogProcessor();
        private static readonly LogProcessor<MasterDataServiceLogProcessor> YbshLogProcessor = new MasterDataServiceLogProcessor();
        private static readonly LogProcessor<MergentEngineServiceLogProcessor> MesLogProcessor = new MergentEngineServiceLogProcessor();
        private static readonly LogProcessor<NetworkLookupServiceLogProcessor> NlsLogProcessor = new NetworkLookupServiceLogProcessor();
        private static readonly LogProcessor<PerformanceTrustEngineServiceLogProcessor> PtesLogProcessor = new PerformanceTrustEngineServiceLogProcessor();
        private static readonly LogProcessor<PrepaymentVectorServiceLogProcessor> PpvsLogProcessor = new PrepaymentVectorServiceLogProcessor();
        private static readonly LogProcessor<ShapeManagerApiGatewayLogProcessor> SmagLogProcessor = new ShapeManagerApiGatewayLogProcessor();
        private static readonly LogProcessor<ShapeManagerRouterServiceLogProcessor> SmrsLogProcessor = new ShapeManagerRouterServiceLogProcessor();
        private static readonly LogProcessor<ShapeManagerServiceLogProcessor> SmsLogProcessor = new ShapeManagerServiceLogProcessor();        
        private static readonly LogProcessor<YieldBookServiceLogProcessor> YbsLogProcessor = new YieldBookServiceLogProcessor();                

        public void Start()
        {
            Bus.Subscribe<LogMessage>("ptrust.log.apigatewayservice", AgsLogProcessor.HandleLogMessage, x => x.WithTopic("ptrust.log.apigatewayservice"));
            Log.Info("Subscribed to ptrust.log.apigatewayservice messages");
            Console.WriteLine("Subscribed to ptrust.log.apigatewayservice messages");

            Bus.Subscribe<LogMessage>("ptrust.log.bloombergengineservice", BbesLogProcessor.HandleLogMessage, x => x.WithTopic("ptrust.log.bloombergengineservice"));
            Log.Info("Subscribed to ptrust.log.bloombergengineservice messages");
            Console.WriteLine("Subscribed to ptrust.log.bloombergengineservice messages");

            Bus.Subscribe<LogMessage>("ptrust.log.intexengineservice", IesLogProcessor.HandleLogMessage, x => x.WithTopic("ptrust.log.intexengineservice"));
            Log.Info("Subscribed to ptrust.log.intexengineservice messages");
            Console.WriteLine("Subscribed to ptrust.log.intexengineservice messages");

            Bus.Subscribe<LogMessage>("ptrust.log.intexrouterservice", IrsLogProcessor.HandleLogMessage, x => x.WithTopic("ptrust.log.intexrouterservice"));
            Log.Info("Subscribed to ptrust.log.intexrouterservice messages");
            Console.WriteLine("Subscribed to ptrust.log.intexrouterservice messages");

            Bus.Subscribe<LogMessage>("ptrust.log.kalotaybondoasengineservice", KbesLogProcessor.HandleLogMessage, x => x.WithTopic("ptrust.log.kalotaybondoasengineservice"));
            Log.Info("Subscribed to ptrust.log.kalotaybondoasengineservice messages");
            Console.WriteLine("Subscribed to ptrust.log.kalotaybondoasengineservice messages");

            Bus.Subscribe<LogMessage>("ptrust.log.kalotaymunioasengineservice", KmesLogProcessor.HandleLogMessage, x => x.WithTopic("ptrust.log.kalotaymunioasengineservice"));
            Log.Info("Subscribed to ptrust.log.kalotaymunioasengineservice messages");
            Console.WriteLine("Subscribed to ptrust.log.kalotaymunioasengineservice messages");

            Bus.Subscribe<LogMessage>("ptrust.log.masterdataservice", YbshLogProcessor.HandleLogMessage, x => x.WithTopic("ptrust.log.masterdataservice"));
            Log.Info("Subscribed to ptrust.log.masterdataservice messages");
            Console.WriteLine("Subscribed to ptrust.log.masterdataservice messages");

            Bus.Subscribe<LogMessage>("ptrust.log.mergentengineservice", MesLogProcessor.HandleLogMessage, x => x.WithTopic("ptrust.log.mergentengineservice"));
            Log.Info("Subscribed to ptrust.log.mergentengineservice messages");
            Console.WriteLine("Subscribed to ptrust.log.mergentengineservice messages");

            Bus.Subscribe<LogMessage>("ptrust.log.networklookupservice", NlsLogProcessor.HandleLogMessage, x => x.WithTopic("ptrust.log.networklookupservice"));
            Log.Info("Subscribed to ptrust.log.networklookupservice messages");
            Console.WriteLine("Subscribed to ptrust.log.networklookupservice messages");

            Bus.Subscribe<LogMessage>("ptrust.log.performancetrustengineservice", PtesLogProcessor.HandleLogMessage, x => x.WithTopic("ptrust.log.performancetrustengineservice"));
            Log.Info("Subscribed to ptrust.log.performancetrustengineservice messages");
            Console.WriteLine("Subscribed to ptrust.log.performancetrustengineservice messages");

            Bus.Subscribe<LogMessage>("ptrust.log.prepaymentvectorservice", PpvsLogProcessor.HandleLogMessage, x => x.WithTopic("ptrust.log.prepaymentvectorservice"));
            Log.Info("Subscribed to ptrust.log.prepaymentvectorservice messages");
            Console.WriteLine("Subscribed to ptrust.log.prepaymentvectorservice messages");

            Bus.Subscribe<LogMessage>("ptrust.log.shapemanagerapigateway", SmagLogProcessor.HandleLogMessage, x => x.WithTopic("ptrust.log.shapemanagerapigateway"));
            Log.Info("Subscribed to ptrust.log.shapemanagerapigateway messages");
            Console.WriteLine("Subscribed to ptrust.log.shapemanagerapigateway messages");

            Bus.Subscribe<LogMessage>("ptrust.log.shapemanagerrouterservice", SmrsLogProcessor.HandleLogMessage, x => x.WithTopic("ptrust.log.shapemanagerrouterservice"));
            Log.Info("Subscribed to ptrust.log.shapemanagerrouterservice messages");
            Console.WriteLine("Subscribed to ptrust.log.shapemanagerrouterservice messages");

            Bus.Subscribe<LogMessage>("ptrust.log.shapemanagerservice", SmsLogProcessor.HandleLogMessage, x => x.WithTopic("ptrust.log.shapemanagerservice"));
            Log.Info("Subscribed to ptrust.log.shapemanagerservice messages");
            Console.WriteLine("Subscribed to ptrust.log.shapemanagerservice messages");

            Bus.Subscribe<LogMessage>("ptrust.log.yieldbookservice", YbsLogProcessor.HandleLogMessage, x => x.WithTopic("ptrust.log.yieldbookservice"));
            Log.Info("Subscribed to ptrust.log.yieldbookservice messages");
            Console.WriteLine("Subscribed to ptrust.log.yieldbookservice messages");

            Bus.Subscribe<EnginePayloadMessage>("ptrust.payload.yieldbookservice", YbsEnginePayloadProcessor.HandleMessage, x => x.WithTopic("ptrust.payload.yieldbookservice"));
            Log.Info("Subscribed to ptrust.payload.yieldbookservice messages");
            Console.WriteLine("Subscribed to ptrust.payload.yieldbookservice messages");            

            Log.Info("Listening for messages ...");
            Console.WriteLine("Listening for messages ... Hit <return> to quit.");
            Console.ReadLine();
        }

        public void Stop()
        {
            Bus.Dispose();
            Log.Info("Service stopped");
        }
    }
}