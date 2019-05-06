using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstoneClassLibrary
{
    /*
     * this class is the manager for the entire application
     * it is a singleton and persists regardless of current location in the UI
     * it serves as a place to abstract business rules away from UI and also away from the database
     * as a philosophy of seperation the UI will only contact this and the database manager will only contact this
     */
    public class ApplicationManager
    {
        // singleton
        private static ApplicationManager _instance;

        // private constructor for singleton. not to be used
        private ApplicationManager()
        {

        }

        // property for singleton
        public static ApplicationManager i
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ApplicationManager();
                }

                return _instance;
            }
        }

        // fields
        public DatabaseManager db = new DatabaseManager();
        public User mainUser;

        // constants
        private int DEFAULTMIN = 1;
        private int DEFAULTMAX = 30;
        private int DESCRIPTIONMAX = 400;
        private int USERNAMEMIN = 4;
        private int PASSWORDMIN = 6;
        private int EMAILBODYMAX = 400;

        // validates length of user entries
        private bool valEntry(string entry, int min, int max)
        {
            return entry.Length >= min && entry.Length <= max;
        }

        // creates a new user, returns string indicating success or type of error
        public string createNewUser(string username, string firstName, string lastName, string password, string usertype, string email)
        {
            // flags for each condition
            bool upper = false;
            bool lower = false;
            bool special = false;
            bool spaces = false;

            // validating user entry lengths
            if (valEntry(password, PASSWORDMIN, DEFAULTMAX) && valEntry(username, USERNAMEMIN, DEFAULTMAX) &&
                valEntry(email, DEFAULTMIN, DEFAULTMAX) && valEntry(firstName, DEFAULTMIN, DEFAULTMAX) &&
                valEntry(lastName, DEFAULTMIN, DEFAULTMAX))
            {
                // for every char in password check to see if it meets each condition
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

                if (upper && lower && special)
                {
                    // making sure username does not contain spaces
                    foreach (char ch in username)
                    {
                        if (Char.IsWhiteSpace(ch))
                        {
                            spaces = true;
                        }
                    }

                    if (!spaces)
                    {
                        // validating email address
                        if (sendEmail(email, "Venzi: Test", "This is a test email to validate your email address.")
                            == "The email has been sent successfully")
                        {
                            // SaltingHashing is used to encrypt the password
                            // First variable in CreateSaltHash can be changed to increase or decrease length of hash
                            SaltingHashing userHashSalt = SaltingHashing.CreateSaltHash(30, password);
                            string passwordHash = userHashSalt.passHash;
                            string passwordSalt = userHashSalt.passSalt;

                            // creating new user object
                            User newUser = new User();
                            newUser.userName = username;
                            newUser.userFirstName = firstName;
                            newUser.userLastName = lastName;
                            newUser.userPass = passwordHash;
                            newUser.userTypeName = usertype;
                            newUser.userEmail = email;
                            newUser.userSalt = passwordSalt;

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

                                // if email is unique
                                if (!doesEmailAlreadyExist)
                                {
                                    // getting new user's type to check permissions
                                    UserType newUsersType = (UserType)ApplicationManager.i.getObjectFromDbByName(new UserType(), newUser.userTypeName);

                                    string returnMessage;

                                    // if the user is attempting to pick a user type with permissions below a 2
                                    // it must be sent for approval. in the meantime it will be created as a Basic user
                                    if (newUsersType.userPermissionsLevel == 0 || newUsersType.userPermissionsLevel == 1)
                                    {
                                        UserTypeRequest request = new UserTypeRequest();
                                        request.userTypeName = newUser.userTypeName;

                                        newUser.userTypeName = "Basic";
                                        db.insertObjectIntoDb(newUser);
                                        newUser = (User)db.getObjectFromDbByName(newUser, username);

                                        request.userID = newUser.userID;
                                        db.insertObjectIntoDb(request);

                                        returnMessage = "The user has been created successfully. The user type selected requires " +
                                            "special permission from the administrator. A request has been made. In the meantime events " +
                                            "can be viewed under our basic user type. Please check your email for the result of the request.";
                                    }
                                    else
                                    {
                                        // if the user is attempting to pick a user type with permissions of 2 or 3 then let them
                                        db.insertObjectIntoDb(newUser);
                                        newUser = (User)db.getObjectFromDbByName(newUser, username);

                                        returnMessage = "The user has been created successfully.";
                                    }

                                    db.createItinerary(newUser);

                                    // send welcome email
                                    sendEmail(newUser.userEmail, "Venzi: Welcome",
                                        "Welcome! You will find our app to be the go-to software for planning and running a convention. " +
                                        "If you are a convention attendee you will find our app is great for scheduling " +
                                        "your own convention experience. " +
                                        "We hope you have a wonderful time.");

                                    return returnMessage;
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
                            return "A valid email address must be used.";
                        }
                    }
                    else
                    {
                        return "The username cannot contain spaces.";
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

        // resets user password to a random password
        public string resetPassword(string username)
        {
            // checking to see if user exists
            if(db.isObjectNameInDb(new User(), username))
            {
                User user1 = (User)db.getObjectFromDbByName(new User(), username);

                // blank string for password to concatenate with
                string tempPass = "";

                // strings to hold potential password chars
                string alphaNums = "abcdefghijklmnopqrstuvwxyz0123456789";
                string alphaCaps = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string specials = "!@#$%^&*";

                Random rand = new Random();

                // concatenating password string with random picks making sure to include one uppercase and one special character
                tempPass += alphaCaps[rand.Next(0, alphaCaps.Length - 1)];
                tempPass += alphaNums[rand.Next(0, alphaNums.Length - 1)];
                tempPass += alphaNums[rand.Next(0, alphaNums.Length - 1)];
                tempPass += alphaNums[rand.Next(0, alphaNums.Length - 1)];
                tempPass += alphaNums[rand.Next(0, alphaNums.Length - 1)];
                tempPass += alphaNums[rand.Next(0, alphaNums.Length - 1)];
                tempPass += specials[rand.Next(0, specials.Length - 1)];

                // SaltingHashing is used to encrypt the password
                // First variable in CreateSaltHash can be changed to increase or decrease length of hash
                SaltingHashing userHashSalt = SaltingHashing.CreateSaltHash(30, tempPass);
                string passwordHash = userHashSalt.passHash;
                string passwordSalt = userHashSalt.passSalt;

                user1.userPass = userHashSalt.passHash;
                user1.userSalt = userHashSalt.passSalt;

                // saving user
                db.updateDbFromObjectByName(user1);

                // email informing of change
                sendEmail(user1.userEmail, "Venzi: Password Reset", "Your password has been reset to " +
                    tempPass + ". If you did not reset it yourself please contact the administrator.");

                return "A temporary password has been sent to your email.";
            }
            else
            {
                return "Our records do not show a user with this username.";
            }
        }

        // changes the mainUser's username. returns a string indicating type of error or success
        public string changeMainUserName(string newUsername)
        {
            // validating username length
            if (valEntry(newUsername, USERNAMEMIN, DEFAULTMAX))
            {
                bool spaces = false;

                // making sure username contains no spaces
                foreach (char ch in newUsername)
                {
                    if (Char.IsWhiteSpace(ch))
                    {
                        spaces = true;
                    }
                }

                if (!spaces)
                {
                    // checking database to make sure username doesn't already exist
                    if (!db.isObjectNameInDb(new User(), newUsername))
                    {
                        // changing main username in program and saving it to database
                        mainUser.userName = newUsername;
                        db.updateDbFromObjectById(mainUser);

                        // email informing of change
                        sendEmail(mainUser.userEmail, "Venzi: Your Recent Username Change", "Your username was recently changed. " +
                            "Your new user name is " + mainUser.userName + ". If you did not change this yourself please contact " +
                            "the administrator.");

                        return "The username has been changed successfully.";
                    }
                    else
                    {
                        return "This username already exists.";
                    }
                }
                else
                {
                    return "The username cannot contain spaces.";
                }
            }
            else
            {
                return "The new username is not the correct length";
            }
        }

        // changes the mainUser's password. returns a string indicating type of error or success
        public string changeMainUserPassword(string newPassword)
        {
            // flags for each condition
            bool upper = false;
            bool lower = false;
            bool special = false;

            // validating password length
            if (valEntry(newPassword, PASSWORDMIN, DEFAULTMAX))
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
                    // changing main user password in program and saving it to database
                    mainUser.userPass = newPassword;
                    db.updateDbFromObjectByName(mainUser);

                    // email informing of change
                    sendEmail(mainUser.userEmail, "Venzi: Your Recent Password Change", "Your password was recently changed. " +
                            "If you did not change this yourself please contact the administrator.");

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
                    // deleting event type from database
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
            // making sure length of name is valid
            if (valEntry(name, DEFAULTMIN, DEFAULTMAX))
            {
                // making sure event type doesn't already exist
                if (!db.isObjectNameInDb(obj, name))
                {
                    // saving event type to database
                    db.insertObjectIntoDb(obj);
                    return obj.GetType().Name + " has been added.";
                }
                else
                {
                    return "This name already exists.";
                }
            }
            else
            {
                return "The name does not meet the criteria.";
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
                    // deleting location from database
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
            // validating length of location name
            if (valEntry(name, DEFAULTMIN, DEFAULTMAX))
            {
                // making sure location doesn't already exist
                if (!db.isObjectNameInDb(obj, name))
                {
                    // saving location to the database
                    db.insertObjectIntoDb(obj);
                    return obj.GetType().Name + " has been added.";
                }
                else
                {
                    return "This name already exists.";
                }
            }
            else
            {
                return "The name does not meet the criteria.";
            }
        }

        // deletes event type from database
        public string deleteUserTypeFromDb(object obj, string name)
        {
            // making sure record exists
            if (db.isObjectNameInDb(obj, name))
            {
                // checking events to make sure there aren't any with that event type
                if (!db.isSelectWhereInDb("Users", "UserTypeName", name))
                {
                    // deleting event type from database
                    db.deleteObjectFromDb(obj, name);
                    return obj.GetType().Name + " has been deleted.";
                }
                else
                {
                    return "There are still user that use this type. " +
                        "In order to delete this type, the type for these users must be changed first.";
                }
            }
            else
            {
                return obj.GetType().Name + " does not exist in the database.";
            }
        }

        //adds user type to database
        public string addUserTypeToDb(object obj, string name)
        {
            // validating length of user type name
            if (valEntry(name, DEFAULTMIN, DEFAULTMAX))
            {
                // making sure user type doesn't already exist
                if (!db.isObjectNameInDb(obj, name))
                {
                    // saving user type to database
                    db.insertObjectIntoDb(obj);
                    return obj.GetType().Name + " has been added.";
                }
                else
                {
                    return "This name already exists.";
                }
            }
            else
            {
                return "The name does not meet the criteria.";
            }
        }

        // changes permissions level of user type
        public string updateUserTypePermissions(UserType obj)
        {
            // making sure user type exists in database
            if (db.isObjectNameInDb(obj, obj.userTypeName))
            {
                // saving user type to database
                db.updateDbFromObjectByName(obj);
                return obj.GetType().Name + " has been added.";
            }
            else
            {
                return "This user type does not exist.";
            }
        }

        // deletes event type from database
        public string deleteEventFromDb(object obj, string name)
        {
            // making sure record exists
            if (db.isObjectNameInDb(obj, name))
            {
                // getting event to delete and deleting it from all itineraries and from the database
                Event eventToDelete = (Event)db.getObjectFromDbByName(obj, name);
                db.deleteEventFromAllItineraries(eventToDelete.eventID);
                db.deleteObjectFromDb(obj, name);

                // getting all emails from database and adding them to a list
                List<User> allUsers = db.getAllFromTable(new User()).Cast<User>().ToList();
                List<string> allEmails = new List<string>();
                foreach (User i in allUsers)
                {
                    allEmails.Add(i.userEmail);
                }

                // email informing of event cancellation sent to all users
                sendEmail(string.Join(",", allEmails), "Venzi: Event Cancelled", eventToDelete.eventName + " has been cancelled. " +
                    "We are sorry for the inconvienience.");

                return obj.GetType().Name + " has been deleted.";
            }
            else
            {
                return obj.GetType().Name + " does not exist in the database.";
            }
        }

        // retrieves corresponding object from the database by looking up its name
        public object getObjectFromDbByName(object obj, string name)
        {
            return db.getObjectFromDbByName(obj, name);
        }

        // retrieves corresponding object from the database by looking up its ID
        public object getObjectFromDbById(object obj, int id)
        {
            return db.getObjectFromDbById(obj, id);
        }

        // saves itinerary to the database
        public void saveItineraryToDb()
        {
            db.saveItineraryToDb(mainUser.userID, mainUser.getItinerary());
        }

        // gets itinerary from the database and loads it into the main user's itinerary
        public void loadItineraryFromDb()
        {
            mainUser.setItinerary(db.getItineraryFromDb(mainUser.userID));
        }

        // gets itinerary as list of events from database
        public List<Event> getItineraryFromDb(int id)
        {
            return db.getItineraryFromDb(id);
        }

        // deleted event id from user id's itinerary
        public string deleteEventFromItinerary(string eventName, string username)
        {
            // getting staff user
            User selectedAssignedStaffer = (User)db.getObjectFromDbByName(new User(), username);

            // selected staff user's itinerary
            List<Event> selectedAssignedItinerary = db.getItineraryFromDb(selectedAssignedStaffer.userID);

            // selected event
            Event currentEvent = (Event)db.getObjectFromDbByName(new Event(), eventName);

            int itineraryIdToDelete = 0;

            // getting id to delete
            foreach (Event eve in selectedAssignedItinerary)
            {
                if (eve.eventID == currentEvent.eventID)
                {
                    itineraryIdToDelete = eve.eventID;
                }
            }

            db.deleteEventFromItinerary(selectedAssignedStaffer.userID, itineraryIdToDelete);
            return username + " has been successfully unassigned from " + eventName + ".";
        }

        // gets all users who have scheduled passed in event id
        public List<User> getStaffAssignedToEvent(int id)
        {
            return db.getStaffAssignedToEvent(id);
        }

        // adds event to staff user's itinerary
        public string assignStaffToEvent(string eventName, string username)
        {
            Event eventToAssign = (Event)db.getObjectFromDbByName(new Event(), eventName);

            if (eventToAssign.staffAssigned >= eventToAssign.staffRequired)
            {
                return eventName + " is already fully staffed.";
            }
            else
            {
                User staffToAssign = (User)db.getObjectFromDbByName(new User(), username);

                // getting total time from setup to breakdown that the event to be assigned would take up
                DateTime eventToAssignStart = eventToAssign.startTime - eventToAssign.setupDuration;
                DateTime eventToAssignEnd = eventToAssign.startTime + eventToAssign.eventDuration
                    + eventToAssign.breakdownDuration;

                DateTime itineraryEventStart;
                DateTime itineraryEventEnd;

                foreach (Event eve in db.getItineraryFromDb(staffToAssign.userID).Cast<Event>().ToList())
                {
                    if (eve.eventName == eventName)
                    {
                        return eventName + " has already been assigned to " + username + ".";
                    }
                    else
                    {
                        // getting total time from setup to breakdown that each itinerary event would take up
                        itineraryEventStart = eve.startTime - eve.setupDuration;
                        itineraryEventEnd = eve.startTime + eve.eventDuration + eve.breakdownDuration;
                        
                        // comparing times of event to times of other events in itinerary
                        if (eventToAssignStart >= itineraryEventStart && eventToAssignStart < itineraryEventEnd ||
                            eventToAssignEnd > itineraryEventStart && eventToAssignEnd <= itineraryEventEnd)
                        {
                            return username + " is already assigned somewhere else during this time period.";
                        }
                    }
                }
            }

            db.assignStaffToEvent(eventName, username);
            return eventName + " has been successfully assigned to " + username + ".";
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

            // making sure user exists in database
            if(db.isObjectNameInDb(user1, username))
            {
                user1 = (User)db.getObjectFromDbByName(user1, username);

                // making sure user has the correct password
                bool authenticPassword = SaltingHashing.AuthenticPass(password, user1.userPass, user1.userSalt);
                if (authenticPassword)
                {
                    // setting main user
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
            TimeSpan eventDur, TimeSpan setupDur, TimeSpan breakdownDur, string description, int staffReq)
        {
            // validating lengths of name and description for event
            if (valEntry(name, DEFAULTMIN, DEFAULTMAX) && valEntry(description, DEFAULTMIN, DESCRIPTIONMAX))
            {
                // filling in event fields with passed in paramaters
                Event newEvent = new Event();
                newEvent.eventName = name;
                newEvent.eventTypeName = type;
                newEvent.locationName = location;
                newEvent.startTime = startTime1.Date.Add(startTime2.TimeOfDay);
                newEvent.eventDuration = eventDur;
                newEvent.setupDuration = setupDur;
                newEvent.breakdownDuration = breakdownDur;
                newEvent.description = description;
                newEvent.staffRequired = staffReq;
                newEvent.staffAssigned = 0;

                // getting total time from setup to breakdown that the new event would take up in its given location
                DateTime newEventStart = newEvent.startTime - newEvent.setupDuration;
                DateTime newEventEnd = newEvent.startTime + newEvent.eventDuration + newEvent.breakdownDuration;

                // making sure event does not overlap another event in the same location
                foreach (Event e in ApplicationManager.i.getAllFromTable(new Event()).Cast<Event>().ToList())
                {
                    if (newEvent.locationName == e.locationName)
                    {
                        if (newEvent.eventName != e.eventName)
                        {
                            DateTime existingEventStart = e.startTime - e.setupDuration;
                            DateTime existingEventEnd = e.startTime + e.eventDuration + e.breakdownDuration;

                            // comparing times of event to times of other events at location
                            if (newEventStart >= existingEventStart && newEventStart < existingEventEnd ||
                                newEventEnd > existingEventStart && newEventEnd <= existingEventEnd)
                            {
                                return "The event time cannot overlap an existing event in the same location.";
                            }
                        }
                    }
                }

                // if event already exists update it else insert a new record
                if (db.isObjectNameInDb(new Event(), name))
                {
                    db.updateDbFromObjectByName(newEvent);

                    return "Event updated successfully.";
                }
                else
                {
                    db.insertObjectIntoDb(newEvent);

                    return "Event created successfully.";
                }
            }
            else
            {
                return "The name and/or description is not the correct length.";
            }
        }

        // grants a user request for a specific user type
        public string grantUserTypeRequest(string username)
        {
            // getting the user who made the request
            User userWhoRequested = (User)getObjectFromDbByName(new User(), username);
            UserTypeRequest requestCopy = new UserTypeRequest();

            // getting all user requests
            List<UserTypeRequest> requests = getAllFromTable(new UserTypeRequest()).Cast<UserTypeRequest>().ToList();

            // if the user who requested the type is in the user requests then copy that username to request copy
            foreach (UserTypeRequest request in requests)
            {
                if (userWhoRequested.userID == request.userID)
                {
                    userWhoRequested.userTypeName = request.userTypeName;
                    requestCopy = request;
                }
            }

            // updating user with the new user type that they requested to have
            db.updateDbFromObjectByName(userWhoRequested);
            
            // deleting the user request
            db.deleteObjectFromDb(requestCopy, requestCopy.userID.ToString());

            // email informing request has been granted
            sendEmail(userWhoRequested.userEmail, "Venzi: Your User Type Request", "Your request to become a "
                + userWhoRequested.userTypeName + " user has been granted. This change is already in effect.");

            return "Request granted successfully.";
        }

        // denies a user request for a specific user type
        public string denyUserTypeRequest(string username)
        {
            // getting the user who made the request
            User userWhoRequested = (User)getObjectFromDbByName(new User(), username);
            UserTypeRequest requestCopy = new UserTypeRequest();

            // getting all user requests
            List<UserTypeRequest> requests = getAllFromTable(new UserTypeRequest()).Cast<UserTypeRequest>().ToList();

            // if the user who requested the type is in the user requests then copy that username to request copy
            foreach (UserTypeRequest request in requests)
            {
                if (userWhoRequested.userID == request.userID)
                {
                    requestCopy = request;
                }
            }

            // delete user request
            db.deleteObjectFromDb(requestCopy, requestCopy.userID.ToString());

            // email informing request has been denied
            sendEmail(userWhoRequested.userEmail, "Venzi: Your User Type Request", "Your request to become a "
                + requestCopy.userTypeName + " user has been denied. If you feel this is an error " +
                "on our part please contact the administrator.");

            return "Request denied successfully.";
        }

        // sends email
        public string sendEmail(string to, string subject, string body)
        {
            // constants for the system's email account
            string FROMADDRESS = "cp5k.owner@gmail.com";
            string PASSWORD = "Password!@#";
            string SMTP = "smtp.gmail.com";
            int PORT = 587;

            SmtpClient client = new SmtpClient(SMTP, PORT); // settings for gmail
            client.UseDefaultCredentials = false; // required by gmail smtp
            client.EnableSsl = true; // required by gmail smtp
            client.Credentials = new System.Net.NetworkCredential(FROMADDRESS, PASSWORD);

            // basics of en email
            MailAddress fromMailAddress = new MailAddress(FROMADDRESS);
            MailMessage mail = new MailMessage();

            if (valEntry(to, DEFAULTMIN, DEFAULTMAX) && valEntry(subject, DEFAULTMIN, DEFAULTMAX)
                && valEntry(body, DEFAULTMIN, EMAILBODYMAX))
            {
                try
                {
                    // everything here needs to get passed when calling sendEmail()
                    mail.To.Add(to);
                    mail.From = fromMailAddress;
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = false;
                    client.Send(mail);

                    return "The email has been sent successfully";
                }
                catch
                {
                    return "The to address must be a valid email address";
                }
            }
            else
            {
                return "The address, subject, or body is not the correct length.";
            }
        }

        // saves the convention title and other general information to the database
        public string saveGeneralInfo(string title, string subtitle, string description)
        {
            // instantiationg blank object and filling it in
            ConventionTitle conventionTitle1 = new ConventionTitle();
            conventionTitle1.conventionTitleID = 1;
            conventionTitle1.conventionTitleName = "convention";
            conventionTitle1.conventionTitleTitle = title;
            conventionTitle1.conventionTitleSubtitle = subtitle;
            conventionTitle1.conventionTitleDescription = description;

            if (db.isObjectNameInDb(new ConventionTitle(), "convention"))
            {
                db.updateDbFromObjectByName(conventionTitle1);
            }
            else
            {
                db.insertObjectIntoDb(conventionTitle1);
            }

            return "The general information has been saved successfully.";
        }
    }
}