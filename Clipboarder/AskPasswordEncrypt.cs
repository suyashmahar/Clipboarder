using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clipboarder {
    public partial class AskPasswordEncrypt : Form {
        MainForm mainForm;

        public AskPasswordEncrypt(MainForm mainForm) {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void AskPassword_Load(object sender, EventArgs e) {
            // // // // // // // // // // // // // // // // // 
        }

        private void okButton_Click(object sender, EventArgs e) {
            mainForm.password = passwordReEnterBox.Text;
            this.DialogResult =  DialogResult.OK;
        }

        private void passwordReEnterBox_TextChanged(object sender, EventArgs e) {
            if (passwordReEnterBox.Text != passwordBox.Text) {
                warningSign.Visible = true;
                okButton.Enabled = false;
            } else {
                warningSign.Visible = false;
                okButton.Enabled = true;
            }
        }

        private void closeButton_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void passwordReEnterBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter && okButton.Enabled == true) {
                okButton.PerformClick();
            }
        }
    }
}
