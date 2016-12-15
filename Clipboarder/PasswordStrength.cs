using System;
using System.Collections;
using System.Data;

namespace Clipboarder {
    /// <summary>
    /// Determines how strong a password is based on lots of different criteria. 0 is very weak. 100 is Very strong.
    /// </summary>
    public class PasswordStrength {
        private DataTable dtDetails;
        private string PreviousPassword = "";

        /// <summary>
        /// Set the password
        /// </summary>
        /// <param name="pwd"></param>
        public void SetPassword(string pwd) {
            if (PreviousPassword != pwd) {
                PreviousPassword = pwd;
                CheckPasswordWithDetails(PreviousPassword);
            }
        }

        /// <summary>
        /// Returns score for the password passed in SetPassword
        /// </summary>
        /// <returns></returns>
        public int GetPasswordScore() {
            if (dtDetails != null)
                return (int)dtDetails.Rows[0][5];
            else
                return 0;
        }

        /// <summary>
        /// Returns a textual description of the stregth of the password
        /// </summary>
        /// <returns></returns>
        public string GetPasswordStrength() {
            if (dtDetails != null)
                return (String)dtDetails.Rows[0][3];
            else
                return "Unknown";
        }

        /// <summary>
        /// Returns the details for the password score - Allows you to see why a password has the score it does.
        /// </summary>
        /// <returns></returns>
        public DataTable GetStrengthDetails() {
            return dtDetails;
        }

        /// <summary>
        /// This is the method which checks the password and determines the score.
        /// </summary>
        /// <param name="pwd"></param>
        private void CheckPasswordWithDetails(string pwd) {
            // Init Vars
            int nScore = 0;
            string sComplexity = "";
            int iUpperCase = 0;
            int iLowerCase = 0;
            int iDigit = 0;
            int iSymbol = 0;
            int iRepeated = 1;
            Hashtable htRepeated = new Hashtable();
            int iMiddle = 0;
            int iMiddleEx = 1;
            int ConsecutiveMode = 0;
            int iConsecutiveUpper = 0;
            int iConsecutiveLower = 0;
            int iConsecutiveDigit = 0;
            int iLevel = 0;
            string sAlphas = "abcdefghijklmnopqrstuvwxyz";
            string sNumerics = "01234567890";
            int nSeqAlpha = 0;
            int nSeqChar = 0;
            int nSeqNumber = 0;

            // Create data table to store results
            CreateDetailsTable();
            DataRow drScore = AddDetailsRow(iLevel++, "Score", "", "", 0, 0);

            // Scan password
            foreach (char ch in pwd.ToCharArray()) {
                // Count digits
                if (Char.IsDigit(ch)) {
                    iDigit++;

                    if (ConsecutiveMode == 3)
                        iConsecutiveDigit++;
                    ConsecutiveMode = 3;
                }

                // Count uppercase characters
                if (Char.IsUpper(ch)) {
                    iUpperCase++;
                    if (ConsecutiveMode == 1)
                        iConsecutiveUpper++;
                    ConsecutiveMode = 1;
                }

                // Count lowercase characters
                if (Char.IsLower(ch)) {
                    iLowerCase++;
                    if (ConsecutiveMode == 2)
                        iConsecutiveLower++;
                    ConsecutiveMode = 2;
                }

                // Count symbols
                if (Char.IsSymbol(ch) || Char.IsPunctuation(ch)) {
                    iSymbol++;
                    ConsecutiveMode = 0;
                }

                // Count repeated letters 
                if (Char.IsLetter(ch)) {
                    if (htRepeated.Contains(Char.ToLower(ch))) iRepeated++;
                    else htRepeated.Add(Char.ToLower(ch), 0);

                    if (iMiddleEx > 1)
                        iMiddle = iMiddleEx - 1;
                }

                if (iUpperCase > 0 || iLowerCase > 0) {
                    if (Char.IsDigit(ch) || Char.IsSymbol(ch))
                        iMiddleEx++;
                }
            }

            // Check for sequential alpha string patterns (forward and reverse) 
            for (int s = 0; s < 23; s++) {
                string sFwd = sAlphas.Substring(s, 3);
                string sRev = strReverse(sFwd);
                if (pwd.ToLower().IndexOf(sFwd) != -1 || pwd.ToLower().IndexOf(sRev) != -1) {
                    nSeqAlpha++;
                    nSeqChar++;
                }
            }

            // Check for sequential numeric string patterns (forward and reverse)
            for (int s = 0; s < 8; s++) {
                string sFwd = sNumerics.Substring(s, 3);
                string sRev = strReverse(sFwd);
                if (pwd.ToLower().IndexOf(sFwd) != -1 || pwd.ToLower().IndexOf(sRev) != -1) {
                    nSeqNumber++;
                    nSeqChar++;
                }
            }

            // Calcuate score
            AddDetailsRow(iLevel++, "Additions", "", "", 0, 0);

            // Score += 4 * Password Length
            nScore = 4 * pwd.Length;
            AddDetailsRow(iLevel++, "Password Length", "Flat", "(n*4)", pwd.Length, pwd.Length * 4);

            // if we have uppercase letetrs Score +=(number of uppercase letters *2)
            if (iUpperCase > 0) {
                nScore += ((pwd.Length - iUpperCase) * 2);
                AddDetailsRow(iLevel++, "Uppercase Letters", "Cond/Incr", "+((len-n)*2)", iUpperCase, ((pwd.Length - iUpperCase) * 2));
            } else
                AddDetailsRow(iLevel++, "Uppercase Letters", "Cond/Incr", "+((len-n)*2)", iUpperCase, 0);

            // if we have lowercase letetrs Score +=(number of lowercase letters *2)
            if (iLowerCase > 0) {
                nScore += ((pwd.Length - iLowerCase) * 2);
                AddDetailsRow(iLevel++, "Lowercase Letters", "Cond/Incr", "+((len-n)*2)", iLowerCase, ((pwd.Length - iLowerCase) * 2));
            } else
                AddDetailsRow(iLevel++, "Lowercase Letters", "Cond/Incr", "+((len-n)*2)", iLowerCase, 0);


            // Score += (Number of digits *4)
            nScore += (iDigit * 4);
            AddDetailsRow(iLevel++, "Numbers", "Cond", "+(n*4)", iDigit, (iDigit * 4));

            // Score += (Number of Symbols * 6)
            nScore += (iSymbol * 6);
            AddDetailsRow(iLevel++, "Symbols", "Flat", "+(n*6)", iSymbol, (iSymbol * 6));

            // Score += (Number of digits or symbols in middle of password *2)
            nScore += (iMiddle * 2);
            AddDetailsRow(iLevel++, "Middle Numbers or Symbols", "Flat", "+(n*2)", iMiddle, (iMiddle * 2));

            //requirments
            int requirments = 0;
            if (pwd.Length >= 8) requirments++;     // Min password length
            if (iUpperCase > 0) requirments++;      // Uppercase letters
            if (iLowerCase > 0) requirments++;      // Lowercase letters
            if (iDigit > 0) requirments++;          // Digits
            if (iSymbol > 0) requirments++;         // Symbols

            // If we have more than 3 requirments then
            if (requirments > 3) {
                // Score += (requirments *2) 
                nScore += (requirments * 2);
                AddDetailsRow(iLevel++, "Requirments", "Flat", "+(n*2)", requirments, (requirments * 2));
            } else
                AddDetailsRow(iLevel++, "Requirments", "Flat", "+(n*2)", requirments, 0);

            //
            // Deductions
            //
            AddDetailsRow(iLevel++, "Deductions", "", "", 0, 0);

            // If only letters then score -=  password length
            if (iDigit == 0 && iSymbol == 0) {
                nScore -= pwd.Length;
                AddDetailsRow(iLevel++, "Letters only", "Flat", "-n", pwd.Length, -pwd.Length);
            } else
                AddDetailsRow(iLevel++, "Letters only", "Flat", "-n", 0, 0);

            // If only digits then score -=  password length
            if (iDigit == pwd.Length) {
                nScore -= pwd.Length;
                AddDetailsRow(iLevel++, "Numbers only", "Flat", "-n", pwd.Length, -pwd.Length);
            } else
                AddDetailsRow(iLevel++, "Numbers only", "Flat", "-n", 0, 0);

            // If repeated letters used then score -= (iRepeated * (iRepeated - 1));
            if (iRepeated > 1) {
                nScore -= (iRepeated * (iRepeated - 1));
                AddDetailsRow(iLevel++, "Repeat Characters (Case Insensitive)", "Incr", "-(n(n-1))", iRepeated, -(iRepeated * (iRepeated - 1)));
            }

            // If Consecutive uppercase letters then score -= (iConsecutiveUpper * 2);
            nScore -= (iConsecutiveUpper * 2);
            AddDetailsRow(iLevel++, "Consecutive Uppercase Letters", "Flat", "-(n*2)", iConsecutiveUpper, -(iConsecutiveUpper * 2));

            // If Consecutive lowercase letters then score -= (iConsecutiveUpper * 2);
            nScore -= (iConsecutiveLower * 2);
            AddDetailsRow(iLevel++, "Consecutive Lowercase Letters", "Flat", "-(n*2)", iConsecutiveLower, -(iConsecutiveLower * 2));

            // If Consecutive digits used then score -= (iConsecutiveDigits* 2);
            nScore -= (iConsecutiveDigit * 2);
            AddDetailsRow(iLevel++, "Consecutive Numbers", "Flat", "-(n*2)", iConsecutiveDigit, -(iConsecutiveDigit * 2));

            // If password contains sequence of letters then score -= (nSeqAlpha * 3)
            nScore -= (nSeqAlpha * 3);
            AddDetailsRow(iLevel++, "Sequential Letters (3+)", "Flat", "-(n*3)", nSeqAlpha, -(nSeqAlpha * 3));

            // If password contains sequence of digits then score -= (nSeqNumber * 3)
            nScore -= (nSeqNumber * 3);
            AddDetailsRow(iLevel++, "Sequential Numbers (3+)", "Flat", "-(n*3)", nSeqNumber, -(nSeqNumber * 3));

            /* Determine complexity based on overall score */
            if (nScore > 100) { nScore = 100; } else if (nScore < 0) { nScore = 0; }
            if (nScore >= 0 && nScore < 20) { sComplexity = "Very Weak"; } else if (nScore >= 20 && nScore < 40) { sComplexity = "Weak"; } else if (nScore >= 40 && nScore < 60) { sComplexity = "Good"; } else if (nScore >= 60 && nScore < 80) { sComplexity = "Strong"; } else if (nScore >= 80 && nScore <= 100) { sComplexity = "Very Strong"; }

            // Store score and complexity in dataset
            drScore[5] = nScore;
            drScore[3] = sComplexity;
            dtDetails.AcceptChanges();
        }

        /// <summary>
        /// Create datatable for results
        /// </summary>
        private void CreateDetailsTable() {
            dtDetails = new DataTable("PasswordDetails");
            dtDetails.Columns.Add(new DataColumn("Level", typeof(Int32)));
            dtDetails.Columns.Add(new DataColumn("Description", typeof(String)));
            dtDetails.Columns.Add(new DataColumn("Type", typeof(String)));
            dtDetails.Columns.Add(new DataColumn("Rate", typeof(String)));
            dtDetails.Columns.Add(new DataColumn("Count", typeof(Int32)));
            dtDetails.Columns.Add(new DataColumn("Bonus", typeof(Int32)));
        }

        /// <summary>
        /// Helper method to add row into DataTable
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Description"></param>
        /// <param name="Type"></param>
        /// <param name="Rate"></param>
        /// <param name="Count"></param>
        /// <param name="Bouns"></param>
        /// <returns></returns>
        private DataRow AddDetailsRow(int Id, string Description, string Type, string Rate, int Count, int Bouns) {
            DataRow dr = dtDetails.NewRow();
            dr[0] = Id;
            dr[1] = Description;
            dr[2] = Type;
            dr[3] = Rate;
            dr[4] = Count;
            dr[5] = Bouns;
            dtDetails.Rows.Add(dr);
            dtDetails.AcceptChanges();
            return dr;
        }

        /// <summary>
        /// Helper string function to reverse string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private String strReverse(String str) {
            string newstring = "";
            for (int s = 0; s < str.Length; s++) {
                newstring = str[s] + newstring;
            }
            return newstring;
        }
    }
}
