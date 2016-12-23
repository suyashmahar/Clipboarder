using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace UnitTests {
    class DatabaseTesting {
        [STAThread]
        static void Main(string[] args) {
            Console.WriteLine("Starting Database Tests...");

            string databaseName = "contents.db";

            DatabaseOperations dbOperations = new DatabaseOperations();
            DatabaseOperations.CreatesNewDatabase(databaseName);
            dbOperations.ConnectDatabase(databaseName);
            dbOperations.OpenConnection();

            User user = new User(dbOperations);
            user.CreateEntry("this is a password");

            DatabaseContent content = new DatabaseContent(dbOperations, user);
            
            for (int i = 0; i < 100; i++) {
                content.EnterTextContent(i, "This is a sample content at line : " + (i + 1), "2500");
            }
            
            List<string[]> output = content.GetTextData();
            for (int i = 0; i < output.Count; i++) {
                string[] arrToWrite = output[i];
                for (int j = 0; j < arrToWrite.Length; j++) {
                    Console.Write(arrToWrite[j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            
        }
    }
    class DatabaseContent {
        DatabaseOperations dbOperations;
        User user;

        public DatabaseContent(DatabaseOperations dbOperations, User user) {
            this.dbOperations = dbOperations;
            this.user = user;
        }


        /// <summary>
        /// Adds record to database entriesTable. 
        /// Note - content column should be encrypted 
        /// </summary>
        /// <param name="index">Index of content.</param>
        /// <param name="content">Content to be written to the database, if security is a concern content should be encrypted.</param>
        /// <param name="time">Time of entry in clipboarder.</param>
        public void EnterTextContent(int index, string content, string time) {
            string command = String.Format("INSERT INTO {0}('indexNumber', 'content', 'time', 'byUser') VALUES({1},\'{2}\',\'{3}\',\'{4}\');", DatabaseOperations.textEntriesTable, index, content, time, user.id);
            dbOperations.ExecuteNonQueryCommand(command);
        }

        /// <summary>
        /// Adds record to database entriesTable. 
        /// Note - content column should be encrypted 
        /// </summary>
        /// <param name="index">Index of content.</param>
        /// <param name="content">Content to be written to the database, if security is a concern content should be encrypted.</param>
        /// <param name="time">Time of entry in clipboarder.</param>
        public void EnterImageContentForCurrentUser(int index, string content, string time) {
            string command = String.Format("INSERT INTO {0}('indexNumber', 'content', 'time', 'byUser') VALUES({1},\'{2}\',\'{3}\',\'{4}\');", DatabaseOperations.imageEntriesTable, index, content, time, user.id);
            dbOperations.ExecuteNonQueryCommand(command);
        }

        /// <summary>
        /// Pulls entries for current user from database and returns list of string array with encrypted  content.
        /// </summary>
        /// <returns>List of string[3] where string[0], [1] & [2] corresponds to Index, content and Time respectively</returns>
        public List<string[]> GetTextData() {
            string query = String.Format("SELECT * FROM {0} where byUser='{1}';", DatabaseOperations.textEntriesTable, user.id);
            SQLiteDataReader databaseDataReader = dbOperations.GetDataReader(query);

            List<string[]> outputList = new List<string[]>();
            while (databaseDataReader.Read()) {
                string[] stringToAdd = new String[3];

                //ignored value at [0] since id of record is of no use in this context.
                stringToAdd[0] = "" + databaseDataReader.GetInt32(1); //Index of record acording to clipboarder entry
                stringToAdd[1] = databaseDataReader.GetString(2);   //content
                stringToAdd[2] = databaseDataReader.GetString(3);   //time of entry in clipboarder

                outputList.Add(stringToAdd);
            }
            return outputList;
        }

        /// <summary>
        /// Pulls entries from image table for current user from database and returns list of string array with encrypted  content.
        /// </summary>
        /// <returns>List of string[3] where string[0], [1] & [2] corresponds to Index, content and Time respectively</returns>
        public List<string[]> GetImageData() {
            string query = String.Format("SELECT * FROM {0} where byUser='{1}';", DatabaseOperations.imageEntriesTable, user.id);
            SQLiteDataReader databaseDataReader = dbOperations.GetDataReader(query);

            List<string[]> outputList = new List<string[]>();
            while (databaseDataReader.Read()) {
                string[] stringToAdd = new String[3];

                //ignored value at [0] since id of record is of no use in this context.
                stringToAdd[0] = "" + databaseDataReader.GetInt32(1); //Index of record acording to clipboarder entry
                stringToAdd[1] = databaseDataReader.GetString(2);   //content
                stringToAdd[2] = databaseDataReader.GetString(3);   //time of entry in clipboarder

                outputList.Add(stringToAdd);
            }
            return outputList;
        }


        /// <summary>
        /// Deletes all records in tables 'userNameTable' and 'entriesTable'
        /// </summary>
        public void clearAllContent() {
            string deleteUsersTablequery = String.Format("DELETE FROM {0};", DatabaseOperations.userNameTable);
            string deleteTextEntriesTablequery = String.Format("DELETE FROM {0};", DatabaseOperations.textEntriesTable);
            string deleteImageEntriesTablequery = String.Format("DELETE FROM {0};", DatabaseOperations.imageEntriesTable);

            dbOperations.ExecuteNonQueryCommand(deleteTextEntriesTablequery);
            dbOperations.ExecuteNonQueryCommand(deleteImageEntriesTablequery);
            dbOperations.ExecuteNonQueryCommand(deleteUsersTablequery);
        }

        /// <summary>
        /// Deletes all records corresponding to current user in clipboarderEntries table
        /// </summary>
        public void RemoveRecordsForCurrentUsers() {
            string removeTextContentQuery = String.Format("DELETE FROM {0} WHERE byUser = \"{1}\";", DatabaseOperations.textEntriesTable, user.id);
            string removeImageContentQuery = String.Format("DELETE FROM {0} WHERE byUser = \"{1}\";", DatabaseOperations.imageEntriesTable, user.id);
            dbOperations.ExecuteNonQueryCommand(removeTextContentQuery);
            dbOperations.ExecuteNonQueryCommand(removeImageContentQuery);
        }

    }
    class DatabaseOperations {


        SQLiteConnection databaseConnection;
        SQLiteCommand databaseCommand = new SQLiteCommand();
        SQLiteDataReader databaseDataReader;

        public static string userNameTable = "users";  // Table name corresponding to table containing records of Users
        public static string textEntriesTable = "clipboarderTextEntries";   // Table name corresponding to table containing text entries of Clipboard
        public static string imageEntriesTable = "clipboarderImageEntries";   // Table name corresponding to table containing image entries of Clipboard

        /// <summary>
        /// Creates new database along with all tables and releationships among tables.
        /// </summary>
        /// <param name="databaseName">Path or name of new database.</param>
        public static void CreatesNewDatabase(string databaseName) {
            string createUsersTableQuery = String.Format("CREATE TABLE \"{0}\" (\"id\" INTEGER PRIMARY KEY  AUTOINCREMENT  NOT NULL  UNIQUE , \"userName\" TEXT NOT NULL  UNIQUE , \"password\" TEXT);", userNameTable);
            string createTextEntriesTableQuery = String.Format("CREATE TABLE \"{0}\" (id INTEGER PRIMARY KEY  AUTOINCREMENT, indexNumber INTEGER, content TEXT, time TEXT, byUser TEXT NOT NULL, FOREIGN KEY(byUser) REFERENCES users(id));", textEntriesTable);
            string createImageEntriesTableQuery = String.Format("CREATE TABLE \"{0}\" (id INTEGER PRIMARY KEY  AUTOINCREMENT, indexNumber INTEGER, content TEXT, time TEXT, byUser TEXT NOT NULL, FOREIGN KEY(byUser) REFERENCES users(id));", imageEntriesTable);

            // Description of connection string at : http://adodotnetsqlite.sourceforge.net/documentation/SQLiteConnection/ConnectionString.php.
            // Creating new file with compression turned off.
            try {
                SQLiteConnection newConnection = new SQLiteConnection("Data Source=\"" + databaseName + "\";Version=3;New=True;");
                newConnection.Open();

                SQLiteCommand newCommand = new SQLiteCommand(createUsersTableQuery, newConnection);
                newCommand.ExecuteNonQuery();
                newCommand = new SQLiteCommand(createTextEntriesTableQuery, newConnection); // Creates table for text content
                newCommand.ExecuteNonQuery();
                newCommand = new SQLiteCommand(createImageEntriesTableQuery, newConnection);// Creates table for storing image in Base64 format
                newCommand.ExecuteNonQuery();

                newConnection.Close();
            } catch (SQLiteException ex) {
                throw new InvalidOperationException("Illegal connection : " + ex.Message, ex);
            }
        }

        /// <summary>
        /// Opens SQLiteConnection to existing or new database. 
        /// Should always be preceded by CreateNewDatabase(string databaseName) or ConnectDatabase(string databaseName) method.
        /// </summary>
        public void OpenConnection() {
            databaseConnection.Open();
        }

        public void CloseConnection() {
            try {
                databaseConnection.Close();
            } catch (SQLiteException ex) {
                throw new InvalidOperationException("Unable to close connnection", ex);
            }
        }

        /// <summary>
        /// Connects to existing database
        /// </summary>
        /// <param name="databaseName">Path or name of database to connect</param>
        public void ConnectDatabase(string databaseName) {
            // Description of connection string at : http://adodotnetsqlite.sourceforge.net/documentation/SQLiteConnection/ConnectionString.php.
            // Using here old file with compression turned off.
            try {
                databaseConnection = new SQLiteConnection("Data Source=\"" + databaseName + "\";Version=3;");
            } catch (SQLiteException ex) {
                throw new InvalidOperationException("Illegal connection : " + ex.Message, ex);
            }
        }

        /// <summary>
        /// Executes query that does not return any data
        /// </summary>
        /// <param name="command"></param>
        public void ExecuteNonQueryCommand(string command) {
            using (databaseCommand = new SQLiteCommand(command, databaseConnection)) {
                databaseCommand.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Returns SQLiteDataReader object for query passed as parameter
        /// </summary>
        public SQLiteDataReader GetDataReader(string query) {
            databaseCommand = new SQLiteCommand(query, databaseConnection);
            return databaseCommand.ExecuteReader();
        }

    }

    class User {
        DatabaseOperations dbOperations;

        public int id;

        public User(DatabaseOperations dbOperations) {
            this.dbOperations = dbOperations;
        }

        public Boolean CurrentUserHasID() {
            string command = String.Format("SELECT id FROM {0} WHERE userName='{1}';", DatabaseOperations.userNameTable, Environment.UserName);

            SQLiteDataReader reader = dbOperations.GetDataReader(command);

            return reader.Read();
        }


        /// <summary>
        /// Returns id in table 'userNameTable' corresponding to user logged-in.
        /// </summary>
        public int GetCurrentUserID() {
            string command = String.Format("SELECT id FROM {0} WHERE userName='{1}';", DatabaseOperations.userNameTable, Environment.UserName);

            SQLiteDataReader reader = dbOperations.GetDataReader(command);
            reader.Read();
            return id = (int)reader.GetInt32(0);
        }

        /// <summary>
        /// Removes user name entry along with password from userNameTable
        /// </summary>
        public void DeleteEntry() {
            string query = String.Format("DELETE FROM {0} WHERE id=\"{1}\"", DatabaseOperations.userNameTable, GetCurrentUserID());
            dbOperations.ExecuteNonQueryCommand(query);
        }

        /// <summary>
        /// Adds new record to userNameTable corresponding to user currently logged-in
        /// </summary>
        /// <param name="hashedPassword">Hash of password supplied by the user.</param>
        public void CreateEntry(string hashedPassword) {
            if (!CurrentUserHasID()) {
                string command = String.Format("INSERT INTO {0}(userName,password) VALUES(\'{1}\',\'{2}\');", DatabaseOperations.userNameTable, Environment.UserName, hashedPassword);
                dbOperations.ExecuteNonQueryCommand(command);
            }
        }


        public string GetUserPassword() {
            string query = String.Format("SELECT * FROM {0} where id='{1}';", DatabaseOperations.userNameTable, GetCurrentUserID());
            SQLiteDataReader databaseDataReader = dbOperations.GetDataReader(query);

            databaseDataReader.Read();
            return databaseDataReader.GetString(2);   //password       
        }

    }
}
