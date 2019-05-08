using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstoneClassLibrary
{
    /*
     * this class serves as the manager for all database related methods
     * an instance of it exists on the Application Manager class and all activity goes through that instance
     * it serves to abstract away all database management from business rules and UI
     * as a philosophy of seperation the application manager will only contact this and this will only contact the application manager
     */
    public class DatabaseManager
    {
        // method for creating the string that allows the program to interact with the database
        public string loadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        // saves the passed in object to its appropriate table in the database via an update query from name
        public void updateDbFromObjectByName(object obj)
        {
            // writing query with passed in object's info
            string objTable = obj.GetType().Name + "s";
            string query = "UPDATE " + objTable + " SET "; // start concatenating string for query

            int count = 1;

            // iterating through the properties of the object and concatenating string with them
            foreach (var i in obj.GetType().GetProperties())
            {
                if(count != 1)
                    query += i.Name + " = '" + i.GetValue(obj) + "', ";
                count++;
            }

            query = query.Substring(0, (query.Length - 2));

            // where name (userName, eventName, etc.) equals the passed in object's value for that field
            query += " WHERE " + obj.GetType().GetProperties()[1].Name + " = '"
                + obj.GetType().GetProperties()[1].GetValue(obj).ToString() + "'";

            // opening connection, running query, and closing connection
            using (SQLiteConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();
                SQLiteCommand command = cnn.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                cnn.Close();
            }
        }

        // saves the passed in object to its appropriate table in the database via an update query from id
        public void updateDbFromObjectById(object obj)
        {
            // writing query with passed in object's info
            string objTable = obj.GetType().Name + "s";
            string query = "UPDATE " + objTable + " SET "; // start concatenating string for query

            int count = 1;

            // iterating through the properties of the object and concatenating string with them
            foreach (var i in obj.GetType().GetProperties())
            {
                if (count != 1)
                    query += i.Name + " = '" + i.GetValue(obj) + "', ";
                count++;
            }

            query = query.Substring(0, (query.Length - 2));

            // where ID (userID, eventID, etc.) equals the passed in object's value for that field
            query += " WHERE " + obj.GetType().GetProperties()[0].Name + " = '"
                + obj.GetType().GetProperties()[0].GetValue(obj).ToString() + "'";

            // opening connection, running query, and closing connection
            using (SQLiteConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();
                SQLiteCommand command = cnn.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                cnn.Close();
            }
        }

        // saves the passed in object to its appropriate table in the database via an insert query
        public void insertObjectIntoDb(object obj)
        {
            // writing query with passed in object's info
            string objTable = obj.GetType().Name + "s";
            string query = "INSERT INTO " + objTable + " ("; // start concatenating string for query
            string values = "VALUES (";

            int count = 1;

            // iterating through the properties of the object and concatenating string with them
            foreach (var i in obj.GetType().GetProperties())
            {
                if (count != 1)
                {
                    query += i.Name + ", ";
                    values += "'" + i.GetValue(obj) + "', ";
                }
                count++;
            }

            // deleting off the comma and space from the above for loop
            query = query.Substring(0, (query.Length - 2)) + ")";
            values = values.Substring(0, (values.Length - 2)) + ")";
            query += values;

            // opening connection, running query, and closing connection
            using (SQLiteConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();
                SQLiteCommand command = cnn.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                cnn.Close();
            }
        }

        // deletes passed in object from database
        public void deleteObjectFromDb(object obj, string name)
        {
            // writing query with passed in object's info
            string objTable = obj.GetType().Name + "s";
            string query = "DELETE FROM " + objTable + " WHERE " + obj.GetType().GetProperties()[1].Name + " = '" + name + "'";

            // opening connection, running query, and closing connection
            using (SQLiteConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();
                SQLiteCommand command = cnn.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                cnn.Close();
            }
        }

        // retrieves corresponding object from the database by looking up its name
        public object getObjectFromDbByName(object obj, string name)
        {
            // writing query with passed in object's info
            string objTable = obj.GetType().Name + "s";
            string query = "SELECT * FROM " + objTable + " WHERE " + obj.GetType().GetProperties()[1].Name + " = '" + name + "'";

            // opening connection, running query, and closing connection
            using (SQLiteConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();
                SQLiteCommand command = cnn.CreateCommand();
                command.CommandText = query;
                int numOfColumns = obj.GetType().GetProperties().Length;
                SQLiteDataReader reader = command.ExecuteReader();

                // for every record in the table
                while(reader.Read())
                {
                    // for property in the object
                    for (int i = 0; i < numOfColumns; i++)
                    {
                        // name of the property
                        string prop = obj.GetType().GetProperties()[i].Name;

                        // the property's value
                        PropertyInfo pi = obj.GetType().GetProperty(prop);

                        // making sure to set property with correct type
                        if (pi.PropertyType == typeof(int))
                        {
                            // setting current property of object with it's corresponding field in the database
                            pi.SetValue(obj, reader.GetInt32(i));
                        }
                        else if (pi.PropertyType == typeof(DateTime))
                        {
                            pi.SetValue(obj, DateTime.Parse(reader.GetString(i)));
                        }
                        else if (pi.PropertyType == typeof(TimeSpan))
                        {
                            pi.SetValue(obj, TimeSpan.Parse(reader.GetString(i)));
                        }
                        else
                        {
                            pi.SetValue(obj, reader.GetString(i));
                        }
                    }
                }
                reader.Close();
                cnn.Close();
            }

            return obj;
        }

        // retrieves corresponding object from the database by looking up its ID
        public object getObjectFromDbById(object obj, int id)
        {
            // writing query with passed in object's info
            string objTable = obj.GetType().Name + "s";
            string query = "SELECT * FROM " + objTable + " WHERE " + obj.GetType().GetProperties()[0].Name + " = " + id;

            // opening connection, running query, and closing connection
            using (SQLiteConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();
                SQLiteCommand command = cnn.CreateCommand();
                command.CommandText = query;
                int numOfColumns = obj.GetType().GetProperties().Length;
                SQLiteDataReader reader = command.ExecuteReader();

                // for every record in the table
                while (reader.Read())
                {
                    // for every property in the object
                    for (int i = 0; i < numOfColumns; i++)
                    {
                        // the name of the property
                        string prop = obj.GetType().GetProperties()[i].Name;

                        // the property's value
                        PropertyInfo pi = obj.GetType().GetProperty(prop);

                        // making sure to set property with correct type
                        if (pi.PropertyType == typeof(int))
                        {
                            // setting current property of object with it's corresponding field in the database
                            pi.SetValue(obj, reader.GetInt32(i));
                        }
                        else if (pi.PropertyType == typeof(DateTime))
                        {
                            pi.SetValue(obj, DateTime.Parse(reader.GetString(i)));
                        }
                        else if (pi.PropertyType == typeof(TimeSpan))
                        {
                            pi.SetValue(obj, TimeSpan.Parse(reader.GetString(i)));
                        }
                        else
                        {
                            pi.SetValue(obj, reader.GetString(i));
                        }
                    }
                }
                reader.Close();
                cnn.Close();
            }

            return obj;
        }

        // returns true if the passed in object's ID already exists as a row in the database
        public bool isObjectIdInDb(object obj, int id)
        {
            // writing query with passed in object's info
            string objTable = obj.GetType().Name + "s";
            string query = "SELECT * FROM " + objTable + " WHERE " + obj.GetType().GetProperties()[0].Name + " = " + id;
            bool isInDB;

            // opening connection, running query, and closing connection
            using (SQLiteConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();
                SQLiteCommand command = cnn.CreateCommand();
                command.CommandText = query;
                SQLiteDataReader reader = command.ExecuteReader();

                // if the reader has no lines to read it will return false meaning there is no corresponding record
                isInDB = reader.Read();
                reader.Close();
                cnn.Close();
            }

            return isInDB;
        }

        // returns true if the passed in object's name already exists as a row in the database
        public bool isObjectNameInDb(object obj, string name)
        {
            // writing query with passed in object's info
            string objTable = obj.GetType().Name + "s";
            string query = "SELECT * FROM " + objTable + " WHERE " + obj.GetType().GetProperties()[1].Name + " = '" + name + "'";
            bool isInDB;

            // opening connection, running query, and closing connection
            using (SQLiteConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();
                SQLiteCommand command = cnn.CreateCommand();
                command.CommandText = query;
                SQLiteDataReader reader = command.ExecuteReader();

                // if the reader has no lines to read it will return false meaning there is no corresponding record
                isInDB = reader.Read();
                reader.Close();
                cnn.Close();
            }

            return isInDB;
        }

        // generic method for seeing if an entry exists in a record via a select query with a where clause
        public bool isSelectWhereInDb(string table, string column, string item)
        {
            // writing query with passed in information
            string query = "SELECT * FROM " + table + " WHERE " + column + " = '" + item + "'";

            bool isInDB;

            // opening connection, running query, and closing connection
            using (SQLiteConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();
                SQLiteCommand command = cnn.CreateCommand();
                command.CommandText = query;
                SQLiteDataReader reader = command.ExecuteReader();

                // if the reader has no lines to read it will return false meaning there is no corresponding record
                isInDB = reader.Read();
                reader.Close();
                cnn.Close();
            }

            return isInDB;
        }

        // gets all records from table
        public List<object> getAllFromTable(object obj)
        {
            List<object> objects = new List<object>();

            // writing query with passed in object's info
            string objTable = obj.GetType().Name + "s";
            string query = "SELECT * FROM " + objTable; // start concatenating string for query

            // opening connection, running query, and closing connection
            using (SQLiteConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();
                SQLiteCommand command = cnn.CreateCommand();
                command.CommandText = query;
                int numOfColumns = obj.GetType().GetProperties().Length;
                SQLiteDataReader reader = command.ExecuteReader();

                // for each record in the table
                while (reader.Read())
                {
                    // instantiating an object to hold record
                    object obj1 = Activator.CreateInstance(obj.GetType());

                    // for each property of the passed in object
                    for (int i = 0; i < numOfColumns; i++)
                    {
                        // the name of the property
                        string prop = obj.GetType().GetProperties()[i].Name;

                        // the property's value
                        PropertyInfo pi = obj.GetType().GetProperty(prop);

                        // making sure to set property with correct type
                        if (pi.PropertyType == typeof(int))
                        {
                            // setting current property of object with it's corresponding field in the database
                            pi.SetValue(obj1, reader.GetInt32(i));
                        }
                        else if (pi.PropertyType == typeof(DateTime))
                        {
                            pi.SetValue(obj1, DateTime.Parse(reader.GetString(i)));
                        }
                        else if (pi.PropertyType == typeof(TimeSpan))
                        {
                            pi.SetValue(obj1, TimeSpan.Parse(reader.GetString(i)));
                        }
                        else
                        {
                            pi.SetValue(obj1, reader.GetString(i));
                        }
                    }
                    
                    // adding an object containing a row in the table to the list of objects that will be returned
                    objects.Add(obj1);
                }

                reader.Close();
                cnn.Close();
            }

            return objects;
        }

        // creates the user's itinerary table in the database
        public void createItinerary(User user1)
        {
            // opening connection, running query, and closing connection
            using (SQLiteConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();
                SQLiteCommand command = cnn.CreateCommand();

                // string to execute query
                command.CommandText = "CREATE TABLE Itinerary" + user1.userID.ToString() +
                    " (eventID NUMBER, CONSTRAINT itinerary_fk FOREIGN KEY (eventID) REFERENCES Events (eventID))";
                command.ExecuteNonQuery();
                cnn.Close();
            }
        }

        // saves passed in itinerary to the database
        public void saveItineraryToDb(int userID, List<Event> events)
        {
            // opening connection, running query, and closing connection
            using (SQLiteConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                // deleting all events from the itinerary
                cnn.Open();
                SQLiteCommand command = cnn.CreateCommand();
                command.CommandText = "delete from Itinerary" + userID.ToString(); // start concatenating string for query
                command.ExecuteNonQuery();

                // each iteration executes a query
                foreach (Event i in events)
                {
                    // inserting events into itinerary
                    command.CommandText = "Insert into Itinerary" + userID + " (eventID) VALUES ('" + i.eventID + "')";
                    command.ExecuteNonQuery();
                }

                cnn.Close();
            }
        }

        // gets itinerary from the database
        public List<Event> getItineraryFromDb(int userID)
        {
            List<int> eventIDs = new List<int>();
            List<Event> events = new List<Event>();

            // opening connection, running query, and closing connection
            using (SQLiteConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();
                SQLiteCommand command = cnn.CreateCommand();

                // itinerary is always the word Itinerary then the userID of the owner (Itinerary3, Itinerary25, etc.)
                command.CommandText = "SELECT * FROM Itinerary" + userID.ToString();
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // only need to save ids
                    eventIDs.Add(reader.GetInt32(0));
                }

                reader.Close();
                cnn.Close();
            }

            // for every id get the corresponding event
            foreach (int i in eventIDs)
            {
                events.Add((Event)getObjectFromDbById(new Event(), i));
            }

            return events; ;
        }

        // deletes event id from user id's itinerary
        public void deleteEventFromItinerary(int userID, int eventID)
        {
            // query
            string query = "DELETE FROM Itinerary" + userID + " WHERE EventID = " + eventID;

            Event eventToRemove = (Event)getObjectFromDbById(new Event(), eventID);
            int numStaffAssigned = eventToRemove.staffAssigned - 1;

            // opening connection, running query, and closing connection
            using (SQLiteConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();
                SQLiteCommand command = cnn.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();

                // staff assigned is the number of user's with permission levels 0 or 1 that have the event in their itinerary
                // this query updates that number
                command.CommandText = "UPDATE events SET staffAssigned = " + numStaffAssigned + " WHERE eventID = " + eventID;
                command.ExecuteNonQuery();
                cnn.Close();
            }
        }

        // deletes passed in event id from all itineraries
        public void deleteEventFromAllItineraries(int id)
        {
            List<int> userIDs = new List<int>();

            // opening connection, running query, and closing connection
            using (SQLiteConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();
                SQLiteCommand command = cnn.CreateCommand();

                // getting all user IDs
                command.CommandText = "SELECT UserID FROM Users";
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    userIDs.Add(reader.GetInt32(0));
                }

                reader.Close();
                cnn.Close();
            }

            // for every user id select that itinerary and delete the event from it
            foreach (int i in userIDs)
            {
                string query = "DELETE FROM Itinerary" + i + " WHERE EventID = " + id;

                // opening connection, running query, and closing connection
                using (SQLiteConnection cnn = new SQLiteConnection(loadConnectionString()))
                {
                    cnn.Open();
                    SQLiteCommand command = cnn.CreateCommand();
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }

        // adds event to staff user's itinerary
        public void assignStaffToEvent(string eventname, string username)
        {
            // getting passed in user
            User staffer = (User)getObjectFromDbByName(new User(), username);

            // getting passed in event
            Event eventToAdd = (Event)getObjectFromDbByName(new Event(), eventname);
            int numStaffAssigned = eventToAdd.staffAssigned + 1;

            // opening connection, running query, and closing connection
            using (SQLiteConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();
                SQLiteCommand command = cnn.CreateCommand();

                // putting event into user's itinerary
                command.CommandText = "INSERT INTO Itinerary" + staffer.userID + " (eventID) VALUES ('" + eventToAdd.eventID + "')";
                command.ExecuteNonQuery();

                // staff assigned is the number of user's with permission levels 0 or 1 that have the event in their itinerary
                // this query updates that number
                command.CommandText = "UPDATE events SET staffAssigned = " + numStaffAssigned + " WHERE eventID = " + eventToAdd.eventID;
                command.ExecuteNonQuery();
                cnn.Close();
            }
        }

        // gets all users who have scheduled passed in event id
        public List<User> getStaffAssignedToEvent(int eventId)
        {
            List<int> userIDs = new List<int>();

            // opening connection, running query, and closing connection
            using (SQLiteConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();
                SQLiteCommand command = cnn.CreateCommand();

                // getting all users IDs
                command.CommandText = "SELECT UserID FROM Users";
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    userIDs.Add(reader.GetInt32(0));
                }

                reader.Close();
                cnn.Close();
            }

            List<int> userIdsWhoScheduledEvent = new List<int>();
            List<User> staffWhoScheduledEvent = new List<User>();

            // for every user id select that itinerary and delete the event from it
            foreach (int i in userIDs)
            {
                string query = "SELECT * FROM Itinerary" + i + " WHERE EventID = " + eventId;

                bool isInDB;

                // opening connection, running query, and closing connection
                using (SQLiteConnection cnn = new SQLiteConnection(loadConnectionString()))
                {
                    cnn.Open();
                    SQLiteCommand command = cnn.CreateCommand();
                    command.CommandText = query;
                    SQLiteDataReader reader = command.ExecuteReader();

                    // if the reader has no lines to read it will return false meaning there is no corresponding record
                    isInDB = reader.Read();
                    reader.Close();
                    cnn.Close();
                }

                if (isInDB)
                {
                    // adding all users who have the passed in event in their itineraries
                    userIdsWhoScheduledEvent.Add(i);
                }
            }

            // for all user's who have event in their itineraries
            foreach(int userId in userIdsWhoScheduledEvent)
            {
                User user1 = (User)getObjectFromDbById(new User(), userId);

                // for all user types
                foreach(UserType ut in getAllFromTable(new UserType()).Cast<UserType>().ToList())
                {
                    // if user type is a staff position
                    if(ut.userPermissionsLevel == 1)
                    {
                        // if staff usertype is the user type of the current user who has event in their itinerary
                        if(user1.userTypeName == ut.userTypeName)
                        {
                            // add user to list of all staff who have event in their itinerary
                            staffWhoScheduledEvent.Add(user1);
                        }
                    }
                }
            }

            return staffWhoScheduledEvent;
        }
    }
}