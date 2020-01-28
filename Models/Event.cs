using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modas.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool Flagged { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
    }
}
