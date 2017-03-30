using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace Clipboarder {
    class DatabaseReadWrite {
        DatabaseOperations dbOperations;
        User user;

        public DatabaseReadWrite(DatabaseOperations dbOperations, User user) {
            this.dbOperations = dbOperations;
            this.user = user;
        }


        /// <summary>
        /// Adds record to database entriesTable. 
        /// Note - content column should be encrypted 
        /// </summary>
        /// <param name="index">Index of content.</param>
        /// <param name="content">Content to be written to the database,
        /// if security is a concern content should be encrypted.</param>
        /// <param name="time">Time of entry in clipboarder.</param>
        public void SetTextContent(EncryptedTextContent contentToAdd) {
            string command = String.Format(
                "INSERT INTO {0}('indexNumber', 'content', 'time', 'byUser') VALUES({1},\'{2}\',\'{3}\',\'{4}\');",
                DatabaseOperations.textEntriesTable,
                contentToAdd.index, contentToAdd.encryptedText, contentToAdd.time,
                user.id);
            dbOperations.ExecuteNonQueryCommand(command);
        }
        
        /// <summary>
        /// Adds record to database entriesTable. 
        /// Note - content column should be encrypted 
        /// </summary>
        /// <param name="index">Index of content.</param>
        /// <param name="content">Content to be written to the database, 
        /// if security is a concern content should be encrypted.</param>
        /// <param name="time">Time of entry in clipboarder.</param>
        public void SetImageContent(EncryptedImageContent contentToAdd) {

            string command = String.Format(
                "INSERT INTO {0}('indexNumber', 'content', 'time', 'byUser') VALUES({1},\'{2}\',\'{3}\',\'{4}\');",
                DatabaseOperations.imageEntriesTable,
                contentToAdd.index, contentToAdd.encryptedImage, contentToAdd.time,
                user.id);

            dbOperations.ExecuteNonQueryCommand(command);
        }

        /// <summary>
        /// Pulls entries for current user from database and returns list
        /// of string array with encrypted  content.
        /// </summary>
        /// <returns>List of string[3] where string[0], [1] & [2] corresponds to Index, content and Time respectively</returns>
        public List<EncryptedTextContent> GetTextData() {
            string query = String.Format("SELECT * FROM {0} where byUser='{1}';", DatabaseOperations.textEntriesTable, user.id);
            SQLiteDataReader databaseDataReader = dbOperations.GetDataReader(query);

            List<EncryptedTextContent> outputList = new List<EncryptedTextContent>();
            while (databaseDataReader.Read()) {
                EncryptedTextContent contentToAdd = new EncryptedTextContent();

                //ignored value at [0] since id of record is of no use in this context.
                contentToAdd.index = databaseDataReader.GetInt32(1); //Index of record acording to clipboarder entry
                contentToAdd.encryptedText = databaseDataReader.GetString(2);   //content
                contentToAdd.time = databaseDataReader.GetString(3);   //time of entry in clipboarder

                outputList.Add(contentToAdd);
            }
            return outputList;
        }

        /// <summary>
        /// Pulls entries from image table for current user from 
        /// database and returns list of string array with encrypted  content.
        /// </summary>
        /// <returns>List of string[3] where string[0], [1] & [2] corresponds to Index, content and Time respectively</returns>
        public List<EncryptedImageContent> GetImageData() {
            string query = String.Format("SELECT * FROM {0} where byUser='{1}';", DatabaseOperations.imageEntriesTable, user.id);
            SQLiteDataReader databaseDataReader = dbOperations.GetDataReader(query);

            List<EncryptedImageContent> outputList = new List<EncryptedImageContent>();
            while (databaseDataReader.Read()) {
                EncryptedImageContent contentToAdd = new EncryptedImageContent();

                //ignored value at [0] since id of record is of no use in this context.
                contentToAdd.index = databaseDataReader.GetInt32(1); //Index of record acording to clipboarder entry
                contentToAdd.encryptedImage = databaseDataReader.GetString(2);   //content
                contentToAdd.time = databaseDataReader.GetString(3);   //time of entry in clipboarder

                outputList.Add(contentToAdd);
            }
            return outputList;
        }


        /// <summary>
        /// Deletes all records in tables 'userNameTable' and 'entriesTable'
        /// </summary>
        public void ClearDatabase() {
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
        public void DeleteAllRecordsForCurrentUsers() {
            string removeTextContentQuery = String.Format("DELETE FROM {0} WHERE byUser = \"{1}\";",
                DatabaseOperations.textEntriesTable, user.id);
            string removeImageContentQuery = String.Format("DELETE FROM {0} WHERE byUser = \"{1}\";",
                DatabaseOperations.imageEntriesTable, user.id);

            dbOperations.ExecuteNonQueryCommand(removeTextContentQuery);
            dbOperations.ExecuteNonQueryCommand(removeImageContentQuery);
        }

    }
}
