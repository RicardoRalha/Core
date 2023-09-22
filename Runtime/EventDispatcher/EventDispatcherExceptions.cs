using System;

namespace RicardoRalha.Core.EventDispatcher
{
    class EventNotPublishedException : Exception
    {
        public EventNotPublishedException(string message) : base(message) {}
    }

    class EventNotRemovedException : Exception
    {
        public EventNotRemovedException(string message) : base(message) {}
    }
}
