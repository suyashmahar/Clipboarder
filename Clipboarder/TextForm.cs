using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Clipboarder {
    public partial class TextForm : Form {
        public TextForm() {
            InitializeComponent();
        }

        private void TextForm_Load(object sender, EventArgs e) {
            textBox.Text = Properties.Settings.Default.regex;
        }

        private void okButton_Click(object sender, EventArgs e) {
            try {
                Regex regex = new Regex(textBox.Text);
            } catch (ArgumentException) {
                MessageBox.Show("Error compiling regex.", "Clipboarder Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Properties.Settings.Default.regex = textBox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void closeButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void textBox_TextChanged(object sender, EventArgs e) {

        }
    }
}
