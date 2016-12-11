using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Diagnostics;
using System.Threading;

namespace Clipboarder
{
    public partial class MainForm : Form {
        string LastClipboardText = "sample";
        Image LastClipboardImage = null;
        
        public MainForm(){
            InitializeComponent();
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

        private void clipboardMonitor1_ClipboardChanged(object sender, Cllipboarder.ClipboardChangedEventArgs e) {
            if (!(Clipboard.GetText() == LastClipboardText)) {
                MessageCountLabel.Text = LastClipboardText = Clipboard.GetText();
            }
        }
        #endregion


    }
}
