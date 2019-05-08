using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneClassLibrary
{
    // class for types of convention events that directly corresponds to the EventTypes table in the database
    public class EventType
    {
        public int eventTypeID { get; set; }
        public string eventTypeName { get; set; }
        public int eventTypeColor { get; set; }
    }
}
