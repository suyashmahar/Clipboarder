using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clipboarder {
    public partial class UrlListDisplay : Form {
        MainFormPresenter presenter;

        public UrlListDisplay(MainFormPresenter presenter, List<string> URLList) {
            this.presenter = presenter;
            InitializeComponent();
            listBox1.Items.Clear();
            foreach (string url in URLList) {
                listBox1.Items.Add(url);
            }
        }

        private void UrlListDisplay_Load(object sender, EventArgs e) {
            if (listBox1.Items.Count == 1) {
                Process.Start(ContentIdentifier.CheckAndAppendHTTP((string)listBox1.Items[0]));
                Close();
            }
        }

        private void openButton_Click(object sender, EventArgs e) {
            if (listBox1.SelectedItem != null) {
                Process.Start(ContentIdentifier.CheckAndAppendHTTP(listBox1.SelectedItem.ToString()));
            } else {
                MessageBox.Show("Please select a URL to open.", "Clipboarder - Display URL", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}