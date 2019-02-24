using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneClassLibrary
{
    public class Event
    {
        private int eventID { get; set; }
        private string eventName { get; set; }
        private int eventDuration { get; set; }
        private string eventType { get; set; }
        private int minimumSF { get; set; }
        private int setupDur { get; set; }
        private int breakdownDur { get; set; }
    }
}
