using System;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

#region Author and File Information

/*
 *  Title				        :	Custom Password Textbox with preview
 *  Author(s)					:   Srivatsa Haridas
 *  Current Version             :   v1.4
 */
#endregion

namespace Clipboarder {

    public class PasswordTextBox : TextBox {
        private readonly Timer timer;
        private char[] adminPassword;
        private readonly char DecimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
        private int m_iCaretPosition = 0;
        private bool canEdit = true;
        private const int PWD_LENGTH = 8;

        public PasswordTextBox() {
            timer = new Timer { Interval = 1000 };
            timer.Tick += timer_Tick;
            adminPassword = new Char[8];
        }

        public string AdminPassword {
            get {
                return new string(adminPassword).Trim('\0').Replace("\0", "");
            }
        }

        protected override void OnTextChanged(EventArgs e) {
            if (canEdit) {
                base.OnTextChanged(e);
                txtInput_TextChanged(this, e);
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e) {
            HidePasswordCharacters();
        }

        protected override void OnMouseClick(MouseEventArgs e) {
            base.OnMouseClick(e);
            m_iCaretPosition = this.GetCharIndexFromPosition(e.Location);
        }

        private void HidePasswordCharacters() {
            int index = this.SelectionStart;

            if (index > 1) {
                StringBuilder s = new StringBuilder(this.Text);
                s[index - 2] = '*';
                this.Text = s.ToString();
                this.SelectionStart = index;
                m_iCaretPosition = index;
            }
            //timer.Enabled = true;
            timer.Start();
        }

        protected override void OnKeyDown(KeyEventArgs e) {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Delete) {
                canEdit = false;
                DeleteSelectedCharacters(this, e.KeyCode);
            }
        }

        /// <summary>
        /// Windows Timer elapsed eventhandler 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e) {
            //timer.Enabled = false;
            timer.Stop();
            int index = this.SelectionStart;

            if (index >= 1) {
                StringBuilder s = new StringBuilder(this.Text);
                s[index - 1] = '*';
                this.Invoke(new Action(() => {
                    this.Text = s.ToString();
                    this.SelectionStart = index;
                    m_iCaretPosition = index;
                }));
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e) {
            base.OnKeyPress(e);

            int selectionStart = this.SelectionStart;
            int length = this.TextLength;
            int selectedChars = this.SelectionLength;
            canEdit = false;

            if (selectedChars == length) {
                /*
                 * Means complete text selected so clear it before using it
                 */
                ClearCharBufferPlusTextBox();
            }

            Keys eModified = (Keys)e.KeyChar;

            if (e.KeyChar == DecimalSeparator) {
                e.Handled = true;
            }
            if ((Keys.Delete != eModified) && (Keys.Back != eModified)) {
                if (Keys.Space != eModified) {
                    if (e.KeyChar != '-') {
                        if (!char.IsLetterOrDigit(e.KeyChar)) {
                            e.Handled = true;
                        } else {
                            if (this.TextLength < PWD_LENGTH) {
                                adminPassword =
                                    new string(adminPassword).Insert(selectionStart, e.KeyChar.ToString()).ToCharArray();
                            }
                        }
                    }
                } else {
                    if (this.TextLength == 0) {
                        e.Handled = true;
                        Array.Clear(adminPassword, 0, adminPassword.Length);
                    }
                }
            } else if ((Keys.Back == eModified) || (Keys.Delete == eModified)) {
                DeleteSelectedCharacters(this, eModified);
            }

            /*
             * Replace the characters with '*'
             */
            HidePasswordCharacters();

            canEdit = true;
        }

        /// <summary>
        /// Deletes the specific characters in the char array based on the key press action
        /// </summary>
        /// <param name="sender"></param>
        private void DeleteSelectedCharacters(object sender, Keys key) {
            int selectionStart = this.SelectionStart;
            int length = this.TextLength;
            int selectedChars = this.SelectionLength;

            if (selectedChars == length) {
                ClearCharBufferPlusTextBox();
                return;
            }

            if (selectedChars > 0) {
                int i = selectionStart;
                this.Text.Remove(selectionStart, selectedChars);
                adminPassword = new string(adminPassword).Remove(selectionStart, selectedChars).ToCharArray();
            } else {
                /*
                 * Basically this portion of code is to handle the condition 
                 * when the cursor is placed at the start or in the end 
                 */
                if (selectionStart == 0) {
                    /*
                    * Cursor in the beginning, before the first character 
                    * Delete the character only when Del is pressed, No action when Back key is pressed
                    */
                    if (key == Keys.Delete) {
                        adminPassword = new string(adminPassword).Remove(0, 1).ToCharArray();
                    }
                } else if (selectionStart > 0 && selectionStart < length) {
                    /*
                    * Cursor position anywhere in between 
                    * Backspace and Delete have the same effect
                    */
                    if (key == Keys.Back || key == Keys.Delete) {
                        adminPassword = new string(adminPassword).Remove(selectionStart, 1).ToCharArray();
                    }
                } else if (selectionStart == length) {
                    /*
                    * Cursor at the end, after the last character 
                    * Delete the character only when Back key is pressed, No action when Delete key is pressed
                    */
                    if (key == Keys.Back) {
                        adminPassword = new string(adminPassword).Remove(selectionStart - 1, 1).ToCharArray();
                    }
                }
            }

            this.Select((selectionStart > this.Text.Length ? this.Text.Length : selectionStart), 0);

        }

        private void ClearCharBufferPlusTextBox() {
            Array.Clear(adminPassword, 0, adminPassword.Length);
            this.Clear();
        }
    }
}