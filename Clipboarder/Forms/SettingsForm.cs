﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Clipboarder {
    public partial class SettingsForm : Form {
        Font syntaxHiglightingFont;
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

            CustomRegexCheckBox.Checked = Properties.Settings.Default.isCutomRegexEnabled;
            URLCheckBox.Checked = Properties.Settings.Default.isURLIdentificationEnabled;
            startOnBootCheckBox.Checked = Properties.Settings.Default.startOnLogon;
            minimizeOnBoot.Checked = Properties.Settings.Default.minimizeOnLogon;

            //Fills font for syntaxhighlighting
            syntaxHiglightingFont = Properties.Settings.Default.syntaxHighlightingFont;
            UpdateFontDescription();
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

            Properties.Settings.Default.isURLIdentificationEnabled = URLCheckBox.Checked;
            Properties.Settings.Default.isCutomRegexEnabled = CustomRegexCheckBox.Checked;

            // -----------------------
            // Procedure for controlling windows logon startup of Clipboarder
            Properties.Settings.Default.startOnLogon = startOnBootCheckBox.Checked;

            String scriptsDir = null;

            // Using Reflection since Environment.CurrentDirectory returns path from 
            // where application was called instead of its location
            String curDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            if (startOnBootCheckBox.Checked) {
                Properties.Settings.Default.minimizeOnLogon = minimizeOnBoot.Checked;
                scriptsDir = Path.Combine(curDir, "addStartupItem.bat");
            } else {
                scriptsDir = Path.Combine(curDir, "removeStartupItem.bat");
            }

            Properties.Settings.Default.Save();

            try {
                System.Diagnostics.Process.Start(scriptsDir);
            } catch (FileNotFoundException) {
                MessageBox.Show(this, "Unable to find scripts for e, check installation and file permissions", 
                    "Clipboarder Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } catch (Exception) {
                MessageBox.Show(this, "Unkown error, please try again",
                    "Clipboarder Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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

        private void URLCheckBox_CheckedChanged(object sender, EventArgs e) {
            CustomRegexCheckBox.Enabled = URLCheckBox.Checked;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            TextForm textForm = new TextForm();
            textForm.ShowDialog();
        }

        private void CustomRegexCheckBox_CheckedChanged(object sender, EventArgs e) {
            RegexLinkLabel.Enabled = CustomRegexCheckBox.Checked;
        }

        private void button1_Click(Object sender, EventArgs e) {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowEffects = false;
            fontDialog.ShowApply = false;
            fontDialog.ShowColor = false;
            fontDialog.Font = syntaxHiglightingFont;

            DialogResult result = fontDialog.ShowDialog();
            if (result == DialogResult.OK) {
                syntaxHiglightingFont = fontDialog.Font;
                UpdateFontDescription();
            }
            
        }
        private void UpdateFontDescription() {
            fontDescriptionLabel.Text =
                "Font: " + syntaxHiglightingFont.Name + Environment.NewLine +
                "Size:" + syntaxHiglightingFont.Size + Environment.NewLine +
                "Style: " + syntaxHiglightingFont.Style;
        }

        private void startOnBootCheckBox_CheckedChanged(object sender, EventArgs e) {
             minimizeOnBoot.Enabled = startOnBootCheckBox.Checked;
        }
    }
}
