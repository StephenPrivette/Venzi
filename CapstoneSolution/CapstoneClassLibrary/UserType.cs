using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneClassLibrary
{
    // class for types of convention users that directly corresponds to the UserTypes table in the database
    public class UserType
    {
        public int userTypeID { get; set; }
        public string userTypeName { get; set; }
        public int userPermissionsLevel { get; set; }
    }
}
