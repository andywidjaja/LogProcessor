using System;

namespace PTrust.LogMessages
{
    public class EnginePayloadMessage
    {
        public string ContainerId { get; set; }

        public string PayloadContent { get; set; }

        public string PayloadName { get; set; }

        public string ServiceId { get; set; }

        public string ThreadId { get; set; }

        public DateTime Timestamp { get; set; }
    }
}