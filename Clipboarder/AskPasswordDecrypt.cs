using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clipboarder.Encryption;

namespace Clipboarder {
    public partial class AskPasswordDecrypt : Form {
        MainForm mainForm;
        string hashedPassword;

        public AskPasswordDecrypt(MainForm mainForm, string hashedPassword) {
            InitializeComponent();
            this.mainForm = mainForm;
            this.hashedPassword = hashedPassword;
        }

        private void closeButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e) {
            if (BCrypt.CheckPassword(passwordBox1.Text, hashedPassword)){
                mainForm.password = passwordBox1.Text;
                DialogResult = DialogResult.OK;
            } else {
                MessageBox.Show("Incorrect password!", "Clipboarder Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                passwordBox1.Text = "";
            }
        }

        private void passwordBox_TextChanged(object sender, EventArgs e) {

        }

        private void AskPasswordDecrypt_Load(object sender, EventArgs e) {

        }

        private void passwordBox1_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter && okButton.Enabled == true) {
                okButton.PerformClick();
            }

        }

        private void passwordBox1_TextChanged(object sender, EventArgs e) {
            if (passwordBox1.Text == "") {
                okButton.Enabled = false;
            } else {
                okButton.Enabled = true;
            }
        }
    }
}
