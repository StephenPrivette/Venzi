using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstoneClassLibrary
{
    public class Apex
    {
        // singleton
        private static Apex _instance;

        // private constructor for singleton. not to be used
        private Apex()
        {

        }

        // property for singleton
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

        // fields
        public SQLiteDataAccess db = new SQLiteDataAccess();
        public User mainUser;

        // returns true if the username and password are valid
        public string createNewUser(string username, string password, string usertype)
        {
            // flags for each condition
            bool upper = false;
            bool lower = false;
            bool special = false;

            // constants for acceptable lengths
            int maxPassLength = 15;
            int minPassLength = 4;
            int maxUserLength = 15;
            int minUserLength = 4;

            // validating password and username length
            if (password.Length < minPassLength || password.Length > maxPassLength ||
                username.Length < minUserLength || username.Length > maxUserLength)
            {
                return "The password and/or username is not the correct length";
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

                // if all conditions are met instantiate user object
                if(upper && lower && special)
                {
                    User newUser = new User();
                    newUser.userName = username;
                    newUser.userPass = password;
                    newUser.userType = usertype;

                    if(db.isObjectNameInDb(newUser, username))
                    {
                        return "This username already exists.";
                    }
                    else
                    {
                        // if the user is not an attendee it must be sent for approval. in the meantime it will be created as an attendee
                        if (newUser.userType != "Attendee")
                        {
                            UserTypeRequest request = new UserTypeRequest();
                            request.userType = newUser.userType;

                            newUser.userType = "Attendee";
                            db.insertObjectIntoDb(newUser);
                            newUser = (User)db.getObjectFromDbByName(newUser, username);

                            request.userID = newUser.userID;
                            db.insertObjectIntoDb(request);
                        }
                        else
                        {
                            // if not an attendee don't need to submit request
                            db.insertObjectIntoDb(newUser);
                            newUser = (User)db.getObjectFromDbByName(newUser, username);
                        }

                        db.createItinerary(newUser);

                        return "The user has been created successfully.";
                    }
                }
                else
                {
                    return "The password does not meet criteria.";
                }
            }
        }

        // changes the mainuser's username. returns a string indicating error or success
        public string changeMainUserName(string newUsername)
        {
            // constants for acceptable lengths
            int maxUserLength = 15;
            int minUserLength = 4;

            // validating username length
            if (newUsername.Length < minUserLength || newUsername.Length > maxUserLength)
            {
                return "The new username is not the correct length";
            }
            else
            {
                // checking database to make sure username doesn't already exist
                if (db.isObjectNameInDb(new User(), newUsername))
                {
                    return "This username already exists.";
                }
                else
                {
                    mainUser.userName = newUsername;
                    db.updateDbFromObject(mainUser);
                }

                return "The username has been changed successfully.";
            }
        }

        // changes the mainuser's password. returns a string indicating error or success
        public string changeMainUserPassword(string newPassword)
        {
            // flags for each condition
            bool upper = false;
            bool lower = false;
            bool special = false;

            // constants for acceptable lengths
            int maxPassLength = 15;
            int minPassLength = 4;

            // validating password length
            if (newPassword.Length < minPassLength || newPassword.Length > maxPassLength)
            {
                return "The password is not the correct length";
            }
            else
            {
                // for every char in password check to see if it meets each condition. if so that flag is true
                foreach (char ch in newPassword)
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

                // if all conditions are met update password
                if (upper && lower && special)
                {
                    mainUser.userPass = newPassword;
                    db.updateDbFromObject(mainUser);

                    return "The password has been changed successfully.";
                }
                else
                {
                    return "The new password does not meet criteria.";
                }
            }
        }

        // saves itinerary to the database
        public void saveItineraryToDb()
        {
            db.saveItineraryToDb(mainUser.userID, mainUser.getItinerary());
        }

        // gets itinerary from the database
        public void loadItineraryFromDb()
        {
            mainUser.setItinerary(db.getItineraryFromDb(mainUser.userID));
        }

        // returns all records in a table as a list of the corresponding objects
        public List<object> getAllFromTable(object obj)
        {
            return db.getAllFromTable(obj);
        }

        // populates the main user object field at the top of this class
        public string loadMainUserFromDb(string username, string password)
        {
            User user1 = new User();
            user1.userName = username;

            if(db.isObjectNameInDb(user1, username))
            {
                user1 = (User)db.getObjectFromDbByName(user1, username);

                // making sure user has the correct password
                if(user1.userPass == password)
                {
                    mainUser = user1;
                    return "Login successful.";
                }
                else
                {
                    return "Our records do not show a user with the username and/or password entered.";
                }
            }
            else
            {
                return "Our records do not show a user with the username and/or password entered.";
            }
        }
        //used for testing not ready
        public static void TestEmail()
        {

            //string from = "";
            string to = "";
            string subject = "";
            StringBuilder body = new StringBuilder();



        }
    }
}