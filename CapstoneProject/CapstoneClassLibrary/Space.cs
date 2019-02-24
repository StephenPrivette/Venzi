using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneClassLibrary
{
    public class Space
    {
        private List<Event> _spaceEvents;

        public void addEventToSpace(Event e)
        {
            _spaceEvents.Add(e);
        }

        public List<Event> getSpaceEvents()
        {
            return _spaceEvents;
        }
    }
}
