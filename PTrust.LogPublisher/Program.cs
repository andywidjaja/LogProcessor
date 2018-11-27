using System;
using System.Configuration;

using EasyNetQ;
using PTrust.LogMessages;

namespace PTrust.LogPublisher
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var bus = RabbitHutch.CreateBus(ConfigurationManager.AppSettings["PtLoggerEndpoint"]))
            {
                string input;
                Console.WriteLine("Enter a message. 'Quit' to quit.");
                while ((input = Console.ReadLine()) != "Quit")
                {
                    //var parsedInput = input.Split(':');
                    //bus.Publish(new LogMessage {ServiceId = $"{parsedInput[0]}", ContainerId = Environment.MachineName, LogType = (LogType) Enum.Parse(typeof(LogType), parsedInput[1]), Timestamp = DateTime.Now, Message = parsedInput[2]}, "ptrust.log.prepaymentvectorservice");
                    bus.Publish(new LogMessage { ServiceId = "SMAG", ContainerId = Environment.MachineName, LogType = LogType.Info, Timestamp = DateTime.Now, Message = input }, "ptrust.log.shapemanagerapigateway");
                }
            }
        }
    }
}