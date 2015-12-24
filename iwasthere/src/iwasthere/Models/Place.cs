using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iwasthere.Models
{
    public class Place : Event
    {
        public PlaceType Type { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }

    }
    public enum PlaceType
    {
        Restaurant,
        Museum,
        Landmark,
        Other,
    }
}
