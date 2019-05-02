using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneClassLibrary
{
    public class Event
    {
        public int eventID { get; set; }
        public string eventName { get; set; }
        public TimeSpan eventDuration { get; set; }
        public string eventTypeName { get; set; }
        public TimeSpan setupDuration { get; set; }
        public TimeSpan breakdownDuration { get; set; }
        public DateTime startTime { get; set; }
        public string locationName { get; set; }
        public string description { get; set; }
        public int staffRequired { get; set; }
        public int staffAssigned { get; set; }
    }
}
