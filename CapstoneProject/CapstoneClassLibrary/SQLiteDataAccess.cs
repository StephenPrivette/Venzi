using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstoneClassLibrary
{
    public class SQLiteDataAccess
    {
        // Method for saving a user's data to the database
        public void saveUser(string username, string password)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                string defaultType = "attendee";
                string sql = "Insert into Users (userName, userPass, userType) values(@param1, @param2, @param3)";

                cnn.Open();
                // Sends the data to be stored in the database
                using (SQLiteCommand cmd = new SQLiteCommand(sql, cnn))
                {
                    cmd.Parameters.Add(new SQLiteParameter("@param1", username));
                    cmd.Parameters.Add(new SQLiteParameter("@param2", password));
                    cmd.Parameters.Add(new SQLiteParameter("@param3", defaultType));
                    cmd.ExecuteNonQuery();
                }

                cnn.Close();
            }
        }

        // Method for loading a user from the database
        public bool valUser(string username, string password)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                string usernameDB = "";
                string passwordDB = "";

                cnn.Open();

                SQLiteCommand command = cnn.CreateCommand();

                // Loads the record from the database that has a matching username
                command.CommandText = "select * from Users Where userName Like @param1";
                command.Parameters.Add(new SQLiteParameter("@param1", username));
                command.Parameters.Add(new SQLiteParameter("@param2", password));

                // Runs command that reads the rows in the database
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    usernameDB = reader.GetString(1);
                    passwordDB = reader.GetString(2);
                }

                reader.Close();
                cnn.Close();

                // Checks to see if the username and password have a match in the database before user can login
                return username == usernameDB && passwordDB == password && password != "" && username != "";
            }
        }

        // Method for loading a user from the database
        public List<string> loadUserTypes()
        {
            using (SQLiteConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                List<string> types = new List<string>();

                cnn.Open();

                SQLiteCommand command = cnn.CreateCommand();

                // Loads the record from the database that has a matching username
                command.CommandText = "select * from UserTypes";

                // Runs command that reads the rows in the database
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    types.Add(reader.GetString(0));
                }

                reader.Close();
                cnn.Close();

                return types;
            }
        }

        // Method for saving a user's data to the database
        public void addUserRequest(string username, string usertype)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                string sql = "Insert into UserRequests (userName, userType) values(@param1, @param2)";

                cnn.Open();
                // Sends the data to be stored in the database
                using (SQLiteCommand cmd = new SQLiteCommand(sql, cnn))
                {
                    cmd.Parameters.Add(new SQLiteParameter("@param1", username));
                    cmd.Parameters.Add(new SQLiteParameter("@param2", usertype));
                    cmd.ExecuteNonQuery();
                }

                cnn.Close();
            }
        }

        // Method for loading a user from the database
        public List<string> loadUser(string username)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                List<string> user = new List<string>();

                cnn.Open();

                SQLiteCommand command = cnn.CreateCommand();

                // Loads the record from the database that has a matching username
                command.CommandText = "select * from Users Where userName Like @param1";
                command.Parameters.Add(new SQLiteParameter("@param1", username));

                // Runs command that reads the rows in the database
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    user.Add(reader.GetInt32(0).ToString());
                    user.Add(reader.GetString(1));
                    user.Add(reader.GetString(2));
                    user.Add(reader.GetString(3));
                }

                reader.Close();
                cnn.Close();

                return user;
            }
        }

        // Method for creating the string that allows the program to interact with the database
        public string loadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public List<List<string>> getEvents()
        {
            using (SQLiteConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();

                List<List<string>> rows = new List<List<string>>();
                List<string> fields;

                SQLiteCommand command = cnn.CreateCommand();

                // Loads the record from the database that has a matching username
                command.CommandText = "SELECT * FROM Events ORDER BY startTime";

                // Runs command that reads the rows in the database
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    fields = new List<string>();
                    fields.Add(reader.GetInt32(0).ToString());
                    fields.Add(reader.GetString(1));
                    fields.Add(reader.GetInt32(2).ToString());
                    fields.Add(reader.GetString(3));
                    fields.Add(reader.GetInt32(4).ToString());
                    fields.Add(reader.GetInt32(5).ToString());
                    fields.Add(reader.GetInt32(6).ToString());
                    fields.Add(reader.GetInt32(7).ToString());
                    fields.Add(reader.GetString(8));
                    rows.Add(fields);
                }

                reader.Close();
                cnn.Close();

                return rows;
            }
        }

        public void createItinerary(string username)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();
                SQLiteCommand command = cnn.CreateCommand();

                command.CommandText = "CREATE TABLE " + username +
                    "Itinerary (eventID NUMBER, CONSTRAINT itinerary_fk FOREIGN KEY (eventID) REFERENCES Events (eventID))";
                command.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public List<List<string>> getItinerary(string username)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();

                List<List<string>> rows = new List<List<string>>();
                List<string> fields;

                SQLiteCommand command = cnn.CreateCommand();

                // Loads the record from the database that has a matching username
                command.CommandText = "SELECT * FROM " + username + "Itinerary";

                // Runs command that reads the rows in the database
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    fields = new List<string>();
                    fields.Add(reader.GetInt32(0).ToString());
                    rows.Add(fields);
                }

                reader.Close();
                cnn.Close();

                return rows;
            }
        }

        public void addEventToItinerary(string username, string eventID)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();
                SQLiteCommand command = cnn.CreateCommand();
                command.CommandText = "Insert into " + username + "Itinerary (eventID) VALUES (" + eventID + ")";
                command.ExecuteNonQuery();
                cnn.Close();
            }
        }
    }
}
