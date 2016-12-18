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
        MainFormPresenter mainFormPresenter;
        PasswordStrength passwordStrength = new PasswordStrength();

        public AskPasswordEncrypt(MainFormPresenter mainForm) {
            this.mainFormPresenter = mainForm;
            InitializeComponent();
        }

        private void AskPassword_Load(object sender, EventArgs e) {

        }

        private void okButton_Click(object sender, EventArgs e) {
            mainFormPresenter.password = passwordReEnterBox.Text;
            this.DialogResult =  DialogResult.OK;
        }

        private void closeButton_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
        
        private void passwordBox_TextChanged_1(object sender, EventArgs e) {
            if (passwordReEnterBox.Text != "" && passwordReEnterBox.Text != null) checkPasswordEquality();
            passwordStrength.SetPassword(passwordBox.Text);
            passwordStrengthBar.Value = passwordStrength.GetPasswordScore();
        }

        private void passwordReEnterBox_KeyDown_1(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter && okButton.Enabled == true) {
                okButton.PerformClick();
            }
        }

        private void passwordReEnterBox_TextChanged_1(object sender, EventArgs e) {
            checkPasswordEquality();
        }

        private void checkPasswordEquality() {
            if (passwordReEnterBox.Text != passwordBox.Text) {
                warningSign.Visible = true;
                okButton.Enabled = false;
            } else {
                warningSign.Visible = false;
                okButton.Enabled = true;
            }
        }
    }
}
