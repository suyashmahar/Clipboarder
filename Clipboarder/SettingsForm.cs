using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clipboarder {
    public partial class SettingsForm : Form {

        public SettingsForm() {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e) {
            shortcutsNumericUpDown.Value = Properties.Settings.Default.shortCuts;
            shortcutsEnabledCheckbox.Checked = Properties.Settings.Default.areShortcutsEnabled;
            if (!Properties.Settings.Default.areShortcutsEnabled) {
                shortcutsNumericUpDown.Enabled = false;
            }
        }

        private void okButton_Click(object sender, EventArgs e) {
            if (shortcutsNumericUpDown.Enabled) {
                Properties.Settings.Default.shortCuts = (int)shortcutsNumericUpDown.Value;
                Properties.Settings.Default.areShortcutsEnabled = true;
            } else {
                Properties.Settings.Default.areShortcutsEnabled = false;
            }

            Properties.Settings.Default.Save();
            Close();
        }

        private void closeButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void shortcutsEnabledCheckbox_CheckedChanged(object sender, EventArgs e) {
            if (shortcutsEnabledCheckbox.Checked) {
                shortcutsNumericUpDown.Enabled = true;
            } else {
                shortcutsNumericUpDown.Enabled = false;
            }
        }
    }
}
