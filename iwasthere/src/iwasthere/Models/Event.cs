﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iwasthere.Models
{
    public class Event
    {
        public int Id { get; set; }
        public Place Place {get; set;}
        public DateTime? Date { get; set; }

    }
}
