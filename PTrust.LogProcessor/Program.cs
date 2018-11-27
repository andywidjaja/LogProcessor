using System.Configuration;

using Topshelf;

namespace PTrust.LogProcessor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                x.Service<LogProcessorManager>(s =>
                {
                    s.ConstructUsing(logProcessorManager => new LogProcessorManager());
                    s.WhenStarted(logProcessorManager => logProcessorManager.Start());
                    s.WhenStopped(logProcessorManager => logProcessorManager.Stop());
                });

                x.RunAsLocalSystem();

                x.SetDescription("Centralized logger for PT services");
                x.SetDisplayName(ConfigurationManager.AppSettings["ServiceName"]);

                x.SetServiceName(ConfigurationManager.AppSettings["ServiceName"]);
            });
        }        
    }
}