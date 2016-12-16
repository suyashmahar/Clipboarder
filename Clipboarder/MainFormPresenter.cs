using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clipboarder {
    class MainFormPresenter {
        private IMainDataLayer view;
        private string databaseName = "contents.db";
        public string password = null;

        string LastClipboardText = "";
        Image LastClipboardImage = null;

        List<Hotkey> hotkeys = new List<Hotkey>();
        Keys[] numKeys = { Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9 }; //Number keys

        public MainFormPresenter(IMainDataLayer view) {
            this.view = view;
            Initialize();
        }

        private void Initialize() {
            view.OnExiting += OnExit;
            view.LoadContent += LoadContent;
            view.SaveContent += SaveContent;
            //TODO add content from Cliboard
            if (Clipboard.ContainsText()) {
                view.AddNewTextRow();
            } else if (Clipboard.ContainsImage()) {
                view.AddClipboardImageRow();
            }

            view.ProgressVisibility = false;
        }


        private void OnExit(object sender, EventArgs e) {
            throw new NotImplementedException();
        }
        private void LoadContent(object sender, EventArgs e) {

        }

        private void SaveContent(object sender, EventArgs e) {

        }

        #region Key Bindings
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

                    // Modifies behaviour for above key combination
                    newHotkey.Pressed += delegate { onHotkeyPress(newHotkey); };
                    try {
                        newHotkey.Register((MainForm)view);
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
        //TODO Update onHotkeyPress to accomodate view
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
    }
}
