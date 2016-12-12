// Blue Color : #FF0766FF
using System;
using System.Windows.Forms;
using System.Drawing;
using Clipboarder.Encryption;
using Clipboarder.Extension;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;

namespace Clipboarder {
    public partial class MainForm : Form {
        string LastClipboardText = "sample";
        string databaseName = "contents.db";
        public string password = null;
        Image LastClipboardImage = null;
        List<Hotkey> hotkeys = new List<Hotkey>();

        Keys[] numKeys = {Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9}; //Number keys

        public MainForm() {
            InitializeComponent();
            this.FormClosing += OnFormClosing;
            RegisterShortcuts();
        }
        
        private void Form1_Load(object sender, EventArgs e) {
            if (Clipboard.ContainsText()) {
                MessageCountLabel.Text = LastClipboardText = Clipboard.GetText();
                AddClipboardTextRow();
            } else if (Clipboard.ContainsImage()) {
                MessageCountLabel.Text = LastClipboardText = Clipboard.GetText();
                AddClipboardImageRow();
            }
        }

        // Calls for application key binding.
        #region Key Binding
        protected void OnFormClosing(Object sender, FormClosingEventArgs e) {
            //if (e.CloseReason == CloseReason.WindowsShutDown) return;
            //e.Cancel = true;
            //WindowState = FormWindowState.Minimized;
            for (int i = 0; i < hotkeys.Count; i++) {
                
            }
        }

        /// <summary>
        /// Registers hotkeys using HotKey class
        /// </summary>
        private void RegisterShortcuts() {
            if (Properties.Settings.Default.areShortcutsEnabled) {
                int keyboardShortcuts = Properties.Settings.Default.shortCuts;
                for (int i = 0; i < keyboardShortcuts; i++) {
                    Hotkey newHotkey = new Hotkey();

                    // Ctrl + Shift + i
                    newHotkey.Control = true;
                    newHotkey.Shift = true;
                    newHotkey.KeyCode = numKeys[i];

                    // Modifies behaviour for abvoe key combination
                    newHotkey.Pressed += delegate { onHotkeyPress(newHotkey); };
                    try {
                        newHotkey.Register(this);
                    } catch (Exception ex) {
                        MessageBox.Show("Error registering hotkeys. \n\nOperation aborted.\n\nError:" + ex.ToString(), "Clipboarder Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    hotkeys.Add(newHotkey);
                }
            }
        }

        public void UnregisterShortcuts(bool reregisterKeys) {
            for (int i = 0; i < hotkeys.Count; i++) {
                hotkeys[i].Unregister();
            }
            
            if (reregisterKeys) {
                RegisterShortcuts();
            }
        }

        private void onHotkeyPress(Hotkey key) {
            if (Array.IndexOf(numKeys, key.KeyCode) < textDataGrid.RowCount) {
                string temp = null;
                if (Clipboard.ContainsText()) temp = Clipboard.GetText();

                LastClipboardText = (string)textDataGrid.Rows[textDataGrid.RowCount - Array.IndexOf(numKeys, key.KeyCode) - 2].Cells[1].Value;
                Clipboard.SetText(LastClipboardText);
                SendKeys.SendWait("^v");

                if (temp != null) {
                    LastClipboardText = temp;
                    Clipboard.SetText(LastClipboardText);
                }
            }
        }
        #endregion

        #region MenuStripItems

        private void SaveAllToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        private void ClearClipboardToolStripMenuItem_Click(object sender, EventArgs e) {
            Clipboard.Clear();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageCountLabel.Visible = true;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e) {
            Clipboard.Clear();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e) {
            textDataGrid.Rows.Clear();
        }

        private void saveContentToolStripMenuItem_Click(object sender, EventArgs e) {
            ExportEntries();
        }

        private void loadContentToolStripMenuItem_Click(object sender, EventArgs e) {
            ImportEntries();
        }

        #endregion

        #region AddRows
        private void AddClipboardTextRow() {
            DataGridViewRow NewRow = new DataGridViewRow();
            NewRow.CreateCells(textDataGrid);

            // Cell contents
            NewRow.Cells[0].Value = textDataGrid.RowCount + 1;
            NewRow.Cells[1].Value = Clipboard.GetText();
            NewRow.Cells[2].Value = System.DateTime.Now.ToShortTimeString();

            textDataGrid.Rows.Insert(textDataGrid.RowCount, NewRow);
        }

        private void AddClipboardImageRow() {
            DataGridViewRow NewRow = new DataGridViewRow();
            NewRow.CreateCells(imageDataGrid);
            NewRow.Height = Clipboard.GetImage().Height;

            // Cell contents
            NewRow.Cells[0].Value = imageDataGrid.RowCount + 1;
            NewRow.Cells[1].Value = Clipboard.GetImage();
            NewRow.Cells[2].Value = DateTime.Now.ToShortTimeString();

            imageDataGrid.Rows.Insert(imageDataGrid.RowCount, NewRow);
        }
        #endregion

        #region ImportExport

        /// <summary>
        /// Imports entries from database file earlier exported to.
        /// </summary>
        private void ImportEntries() {
            if (!File.Exists(System.IO.Path.Combine(Application.StartupPath, "contents.db"))) {
                MessageBox.Show("No content to load. \n\n Use Menu > Save Content to save entries.", "Clipboarder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } else {
                // Uses DatabaseOperations class object to connect and write to database
                DatabaseOperations dbOperations = new DatabaseOperations();
                
                if (!Properties.Settings.Default.doesDatabaseExists) {
                    //Creates new Database
                    DatabaseOperations.CreatesNewDatabase(databaseName);
                    Properties.Settings.Default.doesDatabaseExists = true;
                }
                
                // Connects to database and opens connection
                try {
                    dbOperations = new DatabaseOperations();
                    dbOperations.ConnectDatabase(databaseName);
                    dbOperations.OpenConnection();
                } catch (Exception ex) {
                    MessageBox.Show("Error connecting database, database does not exists or is unreachable.  \n\nOperation aborted.\n" + ex.ToString(), "Clipboarder Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                AskPasswordDecrypt askPassword = new AskPasswordDecrypt(this, dbOperations.GetUserPassword());
                DialogResult result = askPassword.ShowDialog();

                if (result != DialogResult.OK){
                    return;
                }

                // Checks equality of password provided and stored
                if (!dbOperations.CurrentUserHasID()) {
                    if (!dbOperations.CurrentUserHasID()) {
                        MessageBox.Show("Database for current user doesn't exists.  \n\nOperation aborted.\n", "Clipboarder Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    return;
                } else {
                    try {
                        List<string[]> outputList = dbOperations.GetData();

                        //clears current grid
                        textDataGrid.Rows.Clear();

                        for (int i = 0; i < outputList.Count; i++) {
                            string[] outputString = outputList[i];

                            // Removes prefix "[text]" Incase of image duplicate line and replace "[text]" with "[image]"
                            outputString[1] = outputString[1].IndexOf("[text]") == -1 ? outputString[1] : outputString[1].Substring(6);

                            //Decrypts strings 
                            outputString[1] = StringCipher.Decrypt(outputString[1], password);
                            outputString[2] = StringCipher.Decrypt(outputString[2], password);

                            DataGridViewRow newRow = new DataGridViewRow();
                            newRow.CreateCells(textDataGrid);

                            for (int j = 0; j < outputString.Length; j++) {
                                newRow.Cells[j].Value = outputString[j];
                            }
                            textDataGrid.Rows.Insert(i, newRow);
                        }
                    } catch (Exception) {
                        MessageBox.Show("Error filling table with values. \n  \n\nOperation aborted.\n", "Clipboarder Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
                dbOperations.CloseConnection();
                statusLabel.Text = "Export Completed";
            } // Else statement for check on file existence
            password = "";
        }   // Import Entries

        /// <summary>
        /// Exports all clipboarder entries to database
        /// </summary>
        public void ExportEntries() {
            if (textDataGrid.RowCount == 0) {
                MessageBox.Show("No entries to save.", "Clipboarder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } else {
                AskPasswordEncrypt askPassword = new AskPasswordEncrypt(this);
                DialogResult result = askPassword.ShowDialog();

                // Uses DatabaseOperations class object to connect and write to database
                DatabaseOperations dbOperations = new DatabaseOperations();

                if (result == DialogResult.OK) {
                    if (!File.Exists(System.IO.Path.Combine(Application.StartupPath, databaseName))) {
                        //Creates new Database
                        DatabaseOperations.CreatesNewDatabase(databaseName);
                        Properties.Settings.Default.doesDatabaseExists = true;
                    }

                    // Connects to database and opens connection
                    try {
                        dbOperations = new DatabaseOperations();
                        dbOperations.ConnectDatabase(databaseName);
                        dbOperations.OpenConnection();
                    } catch (Exception ex) {
                        MessageBox.Show("Error connecting database. \n\nOperation aborted.\n" + ex.ToString(), "Clipboarder Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    // Deletes existing content for current user if corresponding record exists in userTable
                    if (dbOperations.CurrentUserHasID()) {
                        try {
                            dbOperations.RemoveRecordsForCurrentUsers();
                        } catch (Exception ex) {
                            DialogResult messageResult = MessageBox.Show("Error adding current user record to database. \n\nDo you want to continue?.\n" + ex.ToString(), "Clipboarder Error", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                            if (messageResult == DialogResult.No) return;
                        }
                    } else {

                        // Hashes password using BCrypt Class and adds new record to userName table in database
                        try {
                            dbOperations.AddNewUser(BCrypt.HashPassword(password, BCrypt.GenerateSalt(10)));
                        } catch (Exception ex) {
                            MessageBox.Show("Error adding current user record to database. \n\nOperation aborted.\n" + ex.ToString(), "Clipboarder Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }
                    }

                    //  Adds Content to databased as it is encrypted using password provided by the user
                    for (int i = 0; i < textDataGrid.RowCount; i++) {
                        DataGridViewRow row = (DataGridViewRow)textDataGrid.Rows[i].Clone();
                        for (int j = 0; j < 3; j++) {
                            row.Cells[j].Value = textDataGrid.Rows[i].Cells[j].Value;
                        }

                        // Encrypts content and time 
                        // '[text]' or '[image]' is appended to the begining of the content according to the content to identify decryption. 
                        row.Cells[1].Value = "[text]" + StringCipher.Encrypt((string)row.Cells[1].Value, password);
                        row.Cells[2].Value = StringCipher.Encrypt((string)row.Cells[2].Value, password);

                        // Writing data to database
                        try {
                            dbOperations.EnterContentForCurrentUser((int)row.Cells[0].Value, (string)row.Cells[1].Value, (string)row.Cells[2].Value);
                        } catch (Exception ex) {
                            MessageBox.Show("Error adding content to database. \n\nOperation aborted.\n" + ex.ToString(), "Clipboarder Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }
                    }
                    dbOperations.CloseConnection();
                }
                password = null;
                statusLabel.Text = "Export Completed";
            }
        }

        #endregion

        private void clipboardMonitor1_ClipboardChanged(object sender, Cllipboarder.ClipboardChangedEventArgs e) {
            if (Clipboard.ContainsText()) {
                if (!(Clipboard.GetText() == LastClipboardText)) {
                    MessageCountLabel.Text = LastClipboardText = Clipboard.GetText();
                    AddClipboardTextRow();
                }
            } else if (Clipboard.ContainsImage()) {
                if (!(Clipboard.GetImage() == LastClipboardImage)) {
                    MessageCountLabel.Text = LastClipboardText = Clipboard.GetText();
                    AddClipboardImageRow();
                }
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e) {
            SettingsForm settings = new SettingsForm(this);
            settings.ShowDialog();
        }
    }
}