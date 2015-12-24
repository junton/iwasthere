using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iwasthere.Models
{
    public abstract class Event
    {
        public int ID { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public DateTime? Date { get; set; }

    }
}
