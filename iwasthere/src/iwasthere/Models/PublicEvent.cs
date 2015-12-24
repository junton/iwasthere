using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iwasthere.Models
{
    public class PublicEvent : Event
    {
        public PublicEventType Type { get; set; }
    }

    public enum PublicEventType
    {
        Concert,
        Movie,
        SportingEvent,
        Party,
        Other,
    }
}
