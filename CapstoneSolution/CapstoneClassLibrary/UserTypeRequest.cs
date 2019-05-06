using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneClassLibrary
{
    // class for requests from convention users to become certain types of users
    // it directly corresponds to the UserTypeRequests table in the database
    public class UserTypeRequest
    {
        public int userTypeRequestID { get; set; }
        public int userID { get; set; }
        public string userTypeName { get; set; }
    }
}
