using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clipboarder {
    public partial class EditText : Form {
        IMainDataLayer view;

        public EditText(IMainDataLayer view) {
            InitializeComponent();
            this.view = view;     
        }

        private void EditText_Load(Object sender, EventArgs e) {
            textContentBox.Text = view.SelectedRowTextContent.text;
            timeLabel.Text = view.SelectedRowTextContent.time;
        }

        private void okButton_Click(Object sender, EventArgs e) {
            if (textContentBox.Text != null && textContentBox.Text != "") {
                this.DialogResult = DialogResult.OK;

                view.SetTextContentAt(new TextContent(
                    view.SelectedRowTextContent.index,
                    textContentBox.Text,
                    view.SelectedRowTextContent.time));
                Close();
            } else {
                MessageBox.Show("Text content cannot be empty.",
                     "Clipboarder Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void closeButton_Click(Object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}