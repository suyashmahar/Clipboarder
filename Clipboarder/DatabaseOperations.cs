using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace Clipboarder {
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
            databaseCommand = new SQLiteCommand(query,databaseConnection);
            return databaseCommand.ExecuteReader();
        }
    }
}
