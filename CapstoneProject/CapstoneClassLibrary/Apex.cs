using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneClassLibrary
{
    public class Apex
    {
        // singleton
        private static Apex _instance;

        public SQLiteDataAccess db = new SQLiteDataAccess();
        public User mainUser;
        public List<List<string>> events = new List<List<string>>();

        private Apex()
        {

        }

        public static Apex i
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Apex();
                }

                return _instance;
            }
        }

        // if password is valid returns true
        public bool valNewUser(string username, string password)
        {
            // flags for each condition
            bool upper = false;
            bool lower = false;
            bool special = false;

            // constants for acceptable lengths
            int maxPassLength = 10;
            int minPassLength = 4;
            int maxUserLength = 15;
            int minUserLength = 3;


            // validating password length
            if (password.Length < minPassLength || password.Length > maxPassLength ||
                username.Length < minUserLength || username.Length > maxUserLength)
            {
                return false;
            }
            else
            {
                // for every char in password check to see if it meets each condition. if so that flag is true
                foreach (char ch in password)
                {
                    if (Char.IsUpper(ch))
                    {
                        upper = true;
                    }

                    if (Char.IsLower(ch))
                    {
                        lower = true;
                    }

                    if (!Char.IsLetterOrDigit(ch))
                    {
                        special = true;
                    }
                }

                return upper == true && lower == true && special == true;
            }
        }

        public void loadUser(string username)
        {
            List<string> user = db.loadUser(username);
            mainUser = new User(user[0], user[1], user[3]);
        }

        public void loadEvents()
        {
            events = db.getEvents();
        }

        public void loadItinerary(string username)
        {
            mainUser.itinerary = db.getItinerary(username);
        }
    }
}