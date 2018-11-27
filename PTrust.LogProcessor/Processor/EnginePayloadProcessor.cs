using System;
using System.Configuration;
using System.IO;
using System.Text;
using System.Threading.Tasks;

using Common.Logging;
using PTrust.LogMessages;

namespace PTrust.LogProcessor.Processor
{
    public class EnginePayloadProcessor<T>
    {
        private static readonly ILog Log = LogManager.GetLogger<T>();

        protected string PayloadRoutingKey;

        public EnginePayloadProcessor(string payloadRoutingKey)
        {
            PayloadRoutingKey = payloadRoutingKey;
        }

        public void HandleMessage(EnginePayloadMessage message)
        {
            Task.Run(() => PublishPayload(message));
        }

        private static void PublishPayload(EnginePayloadMessage message)
        {
            var fileName = message.PayloadName;
            var fileContent = message.PayloadContent;

            var payloadRepository = ConfigurationManager.AppSettings["YieldBookEnginePayloadRepository"];

            FileStream fileStream = null;
            try
            {
                if (!Directory.Exists(payloadRepository))
                {
                    Directory.CreateDirectory(payloadRepository);
                }

                var fullFileName = Path.Combine(payloadRepository, fileName);

                if (File.Exists(fullFileName))
                {
                    File.Delete(fullFileName);
                }

                fileStream = File.Open(fullFileName, FileMode.CreateNew, FileAccess.ReadWrite, FileShare.ReadWrite);
                fileStream.Write(Encoding.UTF8.GetBytes(fileContent), 0, fileContent.Length);
            }
            catch (Exception ex)
            {
                Log.Error($"{fileName}: File was not saved", ex);
            }
            finally
            {
                fileStream?.Dispose();
            }

            Log.Debug($"{fileName}: File was saved successfully");
        }
    }
}