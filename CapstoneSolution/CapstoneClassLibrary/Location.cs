using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneClassLibrary
{
    // class for locations of convention events that directly corresponds to the Locations table in the database
    public class Location
    {
        public int locationID { get; set; }
        public string locationName { get; set; }
    }
}
