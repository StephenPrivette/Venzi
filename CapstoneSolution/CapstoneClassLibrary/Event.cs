using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneClassLibrary
{
    // A: Class for filling information for events.
    public class Event
    {
        public int eventID { get; set; }
        public string eventName { get; set; }
        public TimeSpan eventDuration { get; set; }
        public string eventType { get; set; }
        public int minimumSF { get; set; }
        public TimeSpan setupDur { get; set; }
        public TimeSpan breakdownDur { get; set; }
        public DateTime startTime { get; set; }
        public string spaceName { get; set; }
    }
}
