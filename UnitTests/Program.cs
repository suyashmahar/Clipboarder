using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clipboarder.Encryption;
using System.Drawing;
using System.IO;
using Clipboarder.Extension;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;

namespace UnitTests {
    class Program {
        [STAThread]
        static void Main(string[] args) {
            Console.WriteLine("Unit Tests for Clipboarder v0.1b");
            Console.WriteLine("Starting Tests...");
            HashingTests();
            DatabaseTests();
            Console.ReadKey();
        }

        /// <summary>
        /// Tests all mehtods of Clipboarder.Encryption.BCrypt class
        /// </summary>
        static void HashingTests() {
            Console.WriteLine();
            Console.WriteLine("Starting HashingTest...");

            Stopwatch newStopWatch = new Stopwatch();
            
            for (int i = 8; i < 16; i++) {
                newStopWatch.Start();
                string passwordHashed = BCrypt.HashPassword("Th1$ 1& @ p@$$w0rd", BCrypt.GenerateSalt(i));
                newStopWatch.Stop();
                Console.WriteLine(String.Format("Time elapsed using salt of length {0} is {1} ticks or {2} ms.",i,newStopWatch.ElapsedTicks,newStopWatch.ElapsedMilliseconds));
            }

            Console.WriteLine();
            Console.WriteLine("HashingTest Completed.");
        }
        
        /// <summary>
        /// Tests all methods of Clipboarder.Extension.DatabaseOperations
        /// </summary>
        static void DatabaseTests() {
            Console.WriteLine();
            Console.WriteLine("Starting DatabaseTest...");

            Console.WriteLine();
            Console.WriteLine("Creating database...");
            DatabaseOperations.CreatesNewDatabase("debug.db"); //Comment this line if database exists

            Console.WriteLine("Starting Database Tests...");

            Console.WriteLine("Initializing database..");
            DatabaseOperations newDatabaseOperations = null;

            try {
                newDatabaseOperations = new DatabaseOperations();
                newDatabaseOperations.ConnectDatabase("debug.db");
                newDatabaseOperations.OpenConnection();
            } catch (Exception ex) {
                Console.WriteLine("Error : " + ex.Message);
                Console.WriteLine("Stack Trace:\n" + ex.StackTrace);
                return;
            }
            
            Console.WriteLine("\nCleaning database...");
            newDatabaseOperations.clearTables();

            Console.WriteLine("Is record available for current user : " + newDatabaseOperations.CurrentUserHasID());
            
            Console.WriteLine("\nAdding new User...");
            try {
                newDatabaseOperations.AddNewUser("This is a password");
            } catch (Exception ex) {
                Console.WriteLine("Error : " + ex.Message);
                Console.WriteLine("Stack Trace:\n" + ex.StackTrace);
                return;
            }

            
            Console.WriteLine("Making entires into database...");
            try {
                for (int i = 0; i < 10; i++) {                    
                    newDatabaseOperations.EnterContentForCurrentUser(i, String.Format("This is a sample string:{0}", i), "This is a sample time");
                }
            } catch (Exception ex) {
                Console.WriteLine("Error : " + ex.Message);
                Console.WriteLine("Stack Trace:\n" + ex.StackTrace);
                return;
            }

            Console.WriteLine("Reading entries from the database...");
            try {
                List<string[]> outputList = newDatabaseOperations.GetData();
                for (int i = 0; i < outputList.Count; i++) {
                    string[] outputString = outputList[i];
                    for (int j = 0; j < outputString.Length; j++) {
                        Console.Write(outputString[j] + " | ");
                    }
                    Console.WriteLine("");
                }
            } catch (Exception ex) {
                Console.WriteLine("Error : " + ex.Message);
                Console.WriteLine("Stack Trace:\n" + ex.StackTrace);
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Database Operations completed successfully.");
            newDatabaseOperations.CloseConnection();
        }
        
    }
}
