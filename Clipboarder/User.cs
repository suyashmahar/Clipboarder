using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace Clipboarder {
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
