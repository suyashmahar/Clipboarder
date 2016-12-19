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
        string defaultTextKeys = "Ctrl+Shift+(none)+NumKeys";
        string defaultImageKeys = "Ctrl+Alt+NumKeys";

        List<Keys> modifierKeys = new List<Keys>() {
            Keys.None,
            Keys.Alt,
            Keys.Control,
            Keys.Shift
        };

        List<string> ContentKeys = new List<string>() {
            "(none)",
            "Number Keys",  // NumKeys
            "NumPad Keys"   // NumPad
        };



        public SettingsForm() {
            InitializeComponent();

        }

        private void SettingsForm_Load(object sender, EventArgs e) {
            // Loading values for text content
            textShortcutsNumericUpDown.Value = Properties.Settings.Default.textShortcuts;
            textContentCheckBox.Checked = Properties.Settings.Default.areTextShortcutsEnabled;

            //Fills check boxes
            string[] splitted = Properties.Settings.Default.textContentKeys.Split('+');
            foreach (string key in splitted) {
                switch (key) {
                    case "Shift":
                        textShiftKeycheckBox.Checked = true;
                        break;
                    case "Ctrl":
                        textControlKeycheckBox.Checked = true;
                        break;
                    case "Alt":
                        textAltKeycheckBox.Checked = true;
                        break;
                }
            }

                if (!Properties.Settings.Default.areTextShortcutsEnabled) {
                    textShortcutsNumericUpDown.Enabled = false;
                    ChangeTextComboBoxesEnabledState(false);
                }

            // Loading values for image content
            imageShortcutsNumericUpDown.Value = Properties.Settings.Default.imageShortcuts;
            imageContentCheckBox.Checked = Properties.Settings.Default.areImageShortcutsEnabled;
            if (!Properties.Settings.Default.areImageShortcutsEnabled) {
                imageShortcutsNumericUpDown.Enabled = false;
            }
        }

        private void okButton_Click(object sender, EventArgs e) {
            //Text Content
            if (textShortcutsNumericUpDown.Enabled) {
                Properties.Settings.Default.textShortcuts = (int)textShortcutsNumericUpDown.Value;
                Properties.Settings.Default.areTextShortcutsEnabled = true;
                Properties.Settings.Default.textContentKeys = GenerateTextKeyCombinationString();
            } else {
                Properties.Settings.Default.areTextShortcutsEnabled = false;
            }

            Properties.Settings.Default.Save();
            Close();
        }

        private void closeButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void textContentCheckBox_CheckedChanged(object sender, EventArgs e) {
            // Enables-Disables numeric updown based on check box state
            if (textContentCheckBox.Checked) {
                textShortcutsNumericUpDown.Enabled = true;
                ChangeTextComboBoxesEnabledState(true);
            } else {
                textShortcutsNumericUpDown.Enabled = false;
                ChangeTextComboBoxesEnabledState(false);
            }
        }

        private void textModifierKeycheckBox_CheckStateChanged(object sender, EventArgs e) {
            if (!textAltKeycheckBox.Checked && !textControlKeycheckBox.Checked &&
                !textShiftKeycheckBox.Checked) {
                MessageBox.Show(this, "Please select atleast one of the keys", "Clipboarder - Settings", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                textShiftKeycheckBox.Checked = true;
                textControlKeycheckBox.Checked = true;
            }
            textKeyDisplayLabel.Text = GenerateTextKeyCombinationString();
        }

        private string GenerateTextKeyCombinationString() {
            string result = "";
            if (textControlKeycheckBox.Checked) {
                result += "Ctrl+";
            }
            if (textShiftKeycheckBox.Checked) {
                result += "Shift+";
            }
            if (textAltKeycheckBox.Checked) {
                result += "Alt+";
            }
            result += "NumKeys";
            return result;
        }

        private void ChangeTextComboBoxesEnabledState(bool value) {
            textControlKeycheckBox.Enabled = value;
            textShiftKeycheckBox.Enabled = value;
            textAltKeycheckBox.Enabled = value;
        }
    }
}
