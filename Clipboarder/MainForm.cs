// Blue Color : #FF0766FF

using System;
using System.Windows.Forms;
using System.Drawing;
using Clipboarder.Encryption;
using Clipboarder.Extension;
using System.Diagnostics;

namespace Clipboarder {
    public partial class MainForm : Form {
        string LastClipboardText = "sample";
        Image LastClipboardImage = null;

        public string password = null;

        public MainForm(){
            InitializeComponent();
            MessageBox.Show("Error connecting database. \n\nOperation aborted.\n", "Clipboarder Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

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

        private void saveContentToolStripMenuItem_Click(object sender, EventArgs e) {
            AskPassword askPassword = new AskPassword(this);
            DialogResult result = askPassword.ShowDialog();
            // Uses DatabaseOperations class to connect and write to database
            DatabaseOperations dbOperations = new DatabaseOperations(); 

            if (result == DialogResult.OK) {
                if (!Properties.Settings.Default.doesDatabaseExists) {
                    //Creates new Database
                    DatabaseOperations.CreatesNewDatabase("contents.db");
                    Properties.Settings.Default.doesDatabaseExists = true;
                }

                // Connects to database and opens connection
                try {
                    dbOperations = new DatabaseOperations();
                    dbOperations.ConnectDatabase("contents.db");
                    dbOperations.OpenConnection();
                } catch (Exception ex) {
                    MessageBox.Show("Error connecting database. \n\nOperation aborted.\n" + ex.ToString() ,"Clipboarder Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                
                // Hashes password using BCrypt Class and adds new record to userName table in database
                try {
                     dbOperations.AddNewUser(BCrypt.HashPassword(password,BCrypt.GenerateSalt(10)));
                } catch (Exception ex) {
                    MessageBox.Show("Error adding current user record to database. \n\nOperation aborted.\n" + ex.ToString(), "Clipboarder Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
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
                    row.Cells[2].Value =  StringCipher.Encrypt((string)row.Cells[2].Value, password);

                    // Writing data to database
                    try {
                        dbOperations.EnterContentForCurrentUser((int)row.Cells[0].Value, (string)row.Cells[1].Value, (string)row.Cells[2].Value);
                    } catch (Exception ex) {
                        MessageBox.Show("Error adding content to database. \n\nOperation aborted.\n" + ex.ToString(), "Clipboarder Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
            }
        }
    }
}
