using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finisar.SQLite;
using System.Security;

namespace Clipboarder.Extension {
    class DatabaseOperations {

        static SQLiteConnection databaseConnection;
        static SQLiteCommand databaseCommand;
        static SQLiteDataReader databaseDataReader;

        static string userNameTable = "users";
        static string entriesTable = "clipboarderEntries";
        static string userNameField = "by_user"; //Stores column name for userName in entriesTable


        public DatabaseOperations(string databaseName) {
            databaseConnection = new SQLiteConnection("Data Source=" + databaseName + ";Version=3;New=True;Compress=True;");
            try {
                databaseConnection.Open();
            } catch (Exception) {
                throw new InvalidOperationException("Unable to open connection to the database");
            }
        }

    #region ReadAndWrite
        public void ExecuteNonQueryCommand(String command) {
            databaseCommand = databaseConnection.CreateCommand();
            databaseCommand.ExecuteNonQuery();
        }

        public SQLiteDataReader GetDataReader(string command) {
            databaseCommand.CommandText = command;
            return databaseCommand.ExecuteReader();
        }
    #endregion
                
        public void AddNewUser(SecureString hashedPassword) {
            try {
                string query = String.Format("INSERT INTO {0} VALUES(\'{1}\',\'{2}\');", userNameTable, Environment.UserName, hashedPassword);
                ExecuteNonQueryCommand(query);
            } catch (Exception) {

            }
        }

        public void EnterContentForCurrentUser(int index, string content, string time) {
            string query = String.Format("INSERT INTO {0} VALUES({1},\'{2}\',\'{3}\',\'{4}\');", entriesTable, index, content, time, Environment.UserName);
            ExecuteNonQueryCommand(query);
        }
        
        public List<string[]> GetData() {
            string query = String.Format("SELECT * FROM {0} where {1}='{2}';",entriesTable, userNameField,Environment.UserName);

            databaseCommand.CommandText = query;
            databaseDataReader = databaseCommand.ExecuteReader();

            List<string[]> outputList = new List<string[]>();
            while (databaseDataReader.Read()) {
                string[] stringToAdd = new String[3];

                stringToAdd[0] = "" + databaseDataReader.GetInt32(0);
                stringToAdd[1] = databaseDataReader.GetString(1);
                stringToAdd[2] = databaseDataReader.GetString(2);

                outputList.Add(stringToAdd);
            }
            return outputList;
        }

        public void CloseConnection() {
            databaseConnection.Close();
        }

    }
}
