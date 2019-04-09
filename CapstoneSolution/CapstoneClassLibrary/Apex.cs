using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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

        // constants
        private int DEFAULTMIN = 4;
        private int DEFAULTMAX = 20;
        private int EMAILMAX = 40;
        private int DESCRIPTIONMAX = 80;

        // validates length of user entries
        private bool valEntry(string entry, int min, int max)
        {
            return entry.Length >= min && entry.Length <= max;
        }

        // returns true if the username and password are valid
        public string createNewUser(string username, string password, string usertype, string email)
        {
            // flags for each condition
            bool upper = false;
            bool lower = false;
            bool special = false;

            // validating password, email, and username length
            if (valEntry(password, DEFAULTMIN, DEFAULTMAX) && valEntry(username, DEFAULTMIN, DEFAULTMAX) &&
                valEntry(password, DEFAULTMIN, EMAILMAX))
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
                if (upper && lower && special)
                {
                    // ATW: Creates a new user object to store values the current user inputs.
                    User newUser = new User();
                    newUser.userName = username;
                    newUser.userPass = password;
                    newUser.userTypeName = usertype;
                    newUser.userEmail = email;

                    // making sure email is unique
                    if (!db.isObjectNameInDb(newUser, username))
                    {
                        bool doesEmailAlreadyExist = false;
                        List<User> allUsers = db.getAllFromTable(new User()).Cast<User>().ToList();
                        foreach (User i in allUsers)
                        {
                            if (i.userEmail.ToString() == newUser.userEmail)
                            {
                                doesEmailAlreadyExist = true;
                            }
                        }

                        if (!doesEmailAlreadyExist)
                        {
                            // if the user is not an attendee it must be sent for approval. in the meantime it will be created as an attendee
                            if (newUser.userTypeName != "Attendee")
                            {
                                UserTypeRequest request = new UserTypeRequest();
                                request.userTypeName = newUser.userTypeName;

                                newUser.userTypeName = "Attendee";
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
                        else
                        {
                            return "This email address is already in use.";
                        }
                    }
                    else
                    {
                        return "This username already exists.";
                    }
                }
                else
                {
                    return "The password does not meet criteria.";
                }
            }
            else
            {
                return "The username, password, or email is not the correct length";
            }
        }

        // changes the mainuser's username. returns a string indicating error or success
        public string changeMainUserName(string newUsername)
        {
            // validating username length
            if (valEntry(newUsername, DEFAULTMIN, DEFAULTMAX))
            {
                // checking database to make sure username doesn't already exist
                if (!db.isObjectNameInDb(new User(), newUsername))
                {
                    mainUser.userName = newUsername;
                    db.updateDbFromObject(mainUser);
                }
                else
                {
                    return "This username already exists.";
                }

                return "The username has been changed successfully.";
            }
            else
            {
                return "The new username is not the correct length";
            }
        }

        // changes the mainuser's password. returns a string indicating error or success
        public string changeMainUserPassword(string newPassword)
        {
            // flags for each condition
            bool upper = false;
            bool lower = false;
            bool special = false;

            // validating password length
            if (valEntry(newPassword, DEFAULTMIN, DEFAULTMAX))
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
            else
            {
                return "The password is not the correct length";
            }
        }

        // deletes event type from database
        public string deleteEventTypeFromDb(object obj, string name)
        {
            // making sure record exists
            if(db.isObjectNameInDb(obj, name))
            {
                // checking events to make sure there aren't any with that event type
                if(!db.isSelectWhereInDb("Events", "EventTypeName", name))
                {
                    db.deleteObjectFromDb(obj, name);
                    return obj.GetType().Name + " has been deleted.";
                }
                else
                {
                    return "There are still events that use this type. " +
                        "In order to delete this type the type for these events must be changed first.";
                }
            }
            else
            {
                return obj.GetType().Name + " does not exist in the database.";
            }
        }

        // adds event type to database
        public string addEventTypeToDb(object obj, string name)
        {
            // making sure event type doesn't already exist
            if (!db.isObjectNameInDb(obj, name))
            {
                db.insertObjectIntoDb(obj);
                return obj.GetType().Name + " has been added.";
            }
            else
            {
                return obj.GetType().Name + " this name already exists.";
            }
        }

        // deletes location from database
        public string deleteLocationFromDb(object obj, string name)
        {
            // making sure the location exists in the database
            if (db.isObjectNameInDb(obj, name))
            {
                // making sure there aren't events with this location
                if (!db.isSelectWhereInDb("Events", "LocationName", name))
                {
                    db.deleteObjectFromDb(obj, name);
                    return obj.GetType().Name + " has been deleted.";
                }
                else
                {
                    return "There are still events that use this location. " +
                        "In order to delete this location the location for these events must be changed first.";
                }
            }
            else
            {
                return obj.GetType().Name + " does not exist in the database.";
            }
        }

        //adds location to database
        public string addLocationToDb(object obj, string name)
        {
            // making sure location doesn't already exist
            if (!db.isObjectNameInDb(obj, name))
            {
                db.insertObjectIntoDb(obj);
                return obj.GetType().Name + " has been added.";
            }
            else
            {
                return obj.GetType().Name + " this name already exists.";
            }
        }

        // retrieves corresponding object from the database by looking up its name
        public object getObjectFromDbByName(object obj, string name)
        {
            return db.getObjectFromDbByName(obj, name);
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

        // checks to see if object is in database by name
        public bool isObjectNameInDb(object obj, string name)
        {
            return db.isObjectNameInDb(obj, name);
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

        // updates or inserts edited event
        public string editEvent(string name, string type, string location, DateTime startTime1, DateTime startTime2,
            TimeSpan eventDur, TimeSpan setupDur, TimeSpan breakdownDur, string description)
        {
            if (valEntry(name, DEFAULTMIN, DEFAULTMAX) && valEntry(description, DEFAULTMIN, DESCRIPTIONMAX))
            {
                Event event1 = new Event();
                event1.eventName = name;
                event1.eventTypeName = type;
                event1.locationName = location;
                event1.startTime = startTime1.Date.Add(startTime2.TimeOfDay);
                event1.eventDuration = eventDur;
                event1.setupDuration = setupDur;
                event1.breakdownDuration = breakdownDur;
                event1.description = description;

                DateTime locationStartTime = event1.startTime - event1.setupDuration;
                DateTime locationEndTime = event1.startTime + event1.eventDuration + event1.breakdownDuration;

                foreach (Event e in Apex.i.getAllFromTable(new Event()).Cast<Event>().ToList())
                {
                    if (event1.locationName == e.locationName)
                    {
                        if (event1.eventName != e.eventName)
                        {
                            DateTime locStart = e.startTime - e.setupDuration;
                            DateTime locEnd = e.startTime + e.eventDuration + e.breakdownDuration;

                            if (locationStartTime >= locStart && locationStartTime <= locEnd ||
                                locationEndTime >= locStart && locationEndTime <= locEnd)
                            {
                                return "The event time cannot overlap an existing event in the same location.";
                            }
                        }
                    }
                }

                if (db.isObjectNameInDb(new Event(), name))
                {
                    db.updateDbFromObject(event1);

                    return "Event updated successfully.";
                }
                else
                {
                    db.insertObjectIntoDb(event1);

                    return "Event created successfully.";
                }
            }
            else
            {
                return "The name and/or description is not the correct length.";
            }
        }

        //This will be used to send emails
        public void sendEmail(string to, string subject, string body)
        {
            string adminEmail = "cp5k.owner@gmail.com"; //User login credential

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Settings for gmail
            client.UseDefaultCredentials = false; //required by gmail smtp
            client.EnableSsl = true; //required by gmail smtp
            client.Credentials = new System.Net.NetworkCredential(adminEmail, "Password!@#"); //hardcoded password

            //Basics of en email
            MailAddress fromMailAddress = new MailAddress(adminEmail); //admin username
            MailMessage mail = new MailMessage();

            //Everything here needs to get passed when calling SendEmail(from, )
            mail.To.Add(to);
            mail.From = fromMailAddress;
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = false;

            client.Send(mail);
        }
    }
}