using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneClassLibrary
{
    public class User
    {
        public string userName { get; set; }
        public string userType { get; set; }
        public int userID { get; set; }
        public List<List<string>> itinerary { get; set; }

        public User(string id, string name, string type)
        {
            userID = int.Parse(id);
            userName = name;
            userType = type;
        }
        public User()
        {

        }
    }
}
