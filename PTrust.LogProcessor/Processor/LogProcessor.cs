using System;
using System.Text;

using Common.Logging;
using PTrust.LogMessages;

namespace PTrust.LogProcessor.Processor
{
    public class LogProcessor<T>
    {
        private static readonly ILog Log = LogManager.GetLogger<T>();

        protected string LogRoutingKey;

        public LogProcessor(string logRoutingKey)
        {
            LogRoutingKey = logRoutingKey;
        }

        public void HandleLogMessage(LogMessage message)
        {
            var logTxt = new StringBuilder();
            var threadId = string.IsNullOrEmpty(message.ThreadId) ? string.Empty : $"[{Right(message.ThreadId, 2)}]";
            logTxt.Append($"[{message.ServiceId}][{message.ContainerId}]{threadId}[{message.Timestamp:yyyy-MM-dd HH:mm:ss,fff}] {message.Message}");

            switch (message.LogType)
            {
                case LogType.Debug:
                    Log.Debug(logTxt);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case LogType.Info:
                    Log.Info(logTxt);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;

                case LogType.Warning:
                    Log.Warn(logTxt);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;

                case LogType.Error:
                    Log.Error(logTxt);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
            }

            Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss,fff}: {logTxt}");
            Console.ResetColor();
        }

        private static string Right(string text, int maxLength)
        {
            // Check if the value is valid
            if (string.IsNullOrEmpty(text))
            {
                // Set valid empty string as string could be null
                text = string.Empty;
            }
            else if (text.Length > maxLength)
            {
                // Make the string no longer than the max length
                text = text.Substring(text.Length - maxLength, maxLength);
            }

            // Right pad if necessary
            return text.PadRight(maxLength);
        }
    }
}