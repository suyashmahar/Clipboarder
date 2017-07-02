// Blue Color : #FF076FFF
using Clipboarder.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace Clipboarder {
    public partial class MainForm : Form, IMainDataLayer {
        private MainFormPresenter presenter;
        bool isFormVisible = true;  // Stores state of visibility of MainForm
        bool areCommandLineArgumentsRead = false;

        System.Windows.Forms.Timer statusTextLifeTimer;

        #region Properties
        public int TaskProgress {
            get {
                return progressBar.Value;
            }
            set {
                progressBar.Value = value;
            }
        }    // TAG -- 0
        public bool ProgressVisibility {
            get {
                return progressBar.Visible;
            }
            set {
                progressBar.Visible = value;
            }
        } // TAG -- 0
        public int TextRowCount {
            get {
                return textDataGrid.RowCount;
            }
        }
        public int ImageRowCount {
            get {
                return imageDataGrid.RowCount;
            }
        }
        public string status {
            get {
                return statusLabel.Text;
            }
            set {
                statusLabel.Text = value;
                EnableStatusLifeTimer();
            }
        }
        // Returns text content from row currently selected in textDataGrid
        public TextContent SelectedRowTextContent {
            get {
                if (textDataGrid.SelectedRows.Count == 1) {
                    int index = textDataGrid.SelectedRows[0].Index;
                    return new TextContent(
                        (int)textDataGrid.Rows[index].Cells[0].Value,
                        (string)textDataGrid.Rows[index].Cells[1].Value,
                        (string)textDataGrid.Rows[index].Cells[2].Value);
                }
                return null;
            }
        }
        public bool ShowURLStatus {
            set {
                goToURLToolStripMenuItem.Enabled = value;
            }
        }
        #endregion

        public MainForm() {
            InitializeComponent();

            // Setup status life timer
            statusTextLifeTimer = new System.Windows.Forms.Timer();
            statusTextLifeTimer.Tick += StatusTextLifeTimer_Tick;
            statusTextLifeTimer.Interval = 5000;

            // Hide Image page for Update/1
            MainTabControl.TabPages.Remove(imagePage);
        }

        private void StatusTextLifeTimer_Tick(object sender, EventArgs e) {
            statusLabel.Text = "Ready";
            statusTextLifeTimer.Enabled = false;
        }

        private void MainForm_Load(object sender, EventArgs e) {
            // Changes expanded state of preview panel to that in which Clipboarder last exited 
            splitContainer2.Panel2Collapsed = Properties.Settings.Default.imagePreviewCollapsed;
            if (Properties.Settings.Default.imagePreviewCollapsed) {
                collapseExpandButton.Image = Properties.Resources.Clipboarder_Collapse_Arrow;
            } else {
                collapseExpandButton.Image = Properties.Resources.Clipboarder_Expand_Arrow;
            }

            this.toolStripStatusLabel3.Text = Application.ProductVersion.ToString() + " BETA";
            presenter = new MainFormPresenter(this);
        }

        private void MainForm_Paint(object sender, PaintEventArgs e) {
            ReadCommandLineArguments();
        }

        private void ReadCommandLineArguments() {
            if (!areCommandLineArgumentsRead) {
                String[] cmdArgs = Environment.GetCommandLineArgs();
            
                // Minimize winodw on reading corresponding flags
                if (cmdArgs.Contains("-m") | cmdArgs.Contains("--start-minimized")) {
                    isFormVisible = !isFormVisible;
                    this.Hide();
                }

                // Check if Cliboarder process is triggered by user logon
                if (cmdArgs.Contains("-u") | cmdArgs.Contains("--ulogon")) {
                    // Minimize window if enabled in settings
                    if (Properties.Settings.Default.minimizeOnLogon) {
                        isFormVisible = !isFormVisible;
                        this.Hide();
                    }
                }
            }
            areCommandLineArgumentsRead = true;
        }

        public event EventHandler<EventArgs> LoadContent;
        public event EventHandler<EventArgs> SaveContent;
        public event EventHandler<EventArgs> OnExiting;
        public event EventHandler<EventArgs> ShowSettings;
        public event EventHandler<EventArgs> InstallSHLs;
        public event EventHandler<EventArgs> URLCalled;
        public event EventHandler<TextEventArgs> textGridCheckURLAndSetStatus;
        public event EventHandler<EventArgs> EditTextContent;
        public event EventHandler<EventArgs> CopySelectedTextToClipboard;

        public void AddNewImageRow(ImageContent contentToAdd) {
            DataGridViewRow NewRow = new DataGridViewRow();
            NewRow.CreateCells(imageDataGrid);

            NewRow.Cells[0].Value = contentToAdd.index;
            NewRow.Cells[1].Value = contentToAdd.image;
            NewRow.Cells[2].Value = contentToAdd.time;

            //Adjusts height of a row
            NewRow.Height = contentToAdd.image.Height;

            imageDataGrid.Rows.Insert(imageDataGrid.RowCount, NewRow);
            MainTabControl.SelectedIndex = 1;
        }
        public void AddNewTextRow(TextContent contentToAdd) {
            DataGridViewRow NewRow = new DataGridViewRow();
            NewRow.CreateCells(textDataGrid);

            NewRow.Cells[0].Value = contentToAdd.index;
            NewRow.Cells[1].Value = contentToAdd.text;
            NewRow.Cells[2].Value = contentToAdd.time;

            textDataGrid.Rows.Insert(textDataGrid.RowCount, NewRow);
            MainTabControl.SelectedIndex = 0;
        }
        public void SetTextContentAt(TextContent contentToAdd) {
            try {
                DataGridViewRow row = textDataGrid.Rows[contentToAdd.index - 1];

                row.Cells[0].Value = contentToAdd.index;
                row.Cells[1].Value = contentToAdd.text;
                row.Cells[2].Value = contentToAdd.time;
            } catch (ArgumentOutOfRangeException) {
                MessageBox.Show("Error, unable to update content.",
                    "Clipboarder", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public void SetImageContentAt(ImageContent contentToAdd) {
            try {
                DataGridViewRow row = imageDataGrid.Rows[contentToAdd.index - 1];

                row.Cells[0].Value = contentToAdd.index;
                row.Cells[1].Value = contentToAdd.image;
                row.Cells[2].Value = contentToAdd.time;
            } catch (ArgumentOutOfRangeException) {
                MessageBox.Show("Error, unable to update content.",
                    "Clipboarder", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public List<ImageContent> GetAllImageContent() {
            List<ImageContent> returnValues = new List<ImageContent>();

            for (int i = 0; i < imageDataGrid.RowCount; i++) {
                ImageContent contentToAdd = new ImageContent();
                contentToAdd.index = (int)imageDataGrid.Rows[i].Cells[0].Value;
                contentToAdd.image = (Image)imageDataGrid.Rows[i].Cells[1].Value;
                contentToAdd.time = (string)imageDataGrid.Rows[i].Cells[2].Value;

                returnValues.Add(contentToAdd);
            }

            return returnValues;
        }
        public List<TextContent> GetAllTextContent() {
            List<TextContent> returnValues = new List<TextContent>();

            for (int i = 0; i < textDataGrid.RowCount; i++) {
                TextContent contentToAdd = new TextContent();
                contentToAdd.index = (int)textDataGrid.Rows[i].Cells[0].Value;
                contentToAdd.text = (string)textDataGrid.Rows[i].Cells[1].Value;
                contentToAdd.time = (string)textDataGrid.Rows[i].Cells[2].Value;

                returnValues.Add(contentToAdd);
            }

            return returnValues;
        }
        public ImageContent GetImageContentAt(int index) {
            //0 indexed
            DataGridViewRow row = imageDataGrid.Rows[index];
            return new ImageContent((int)row.Cells[0].Value, (Image)row.Cells[1].Value, (string)row.Cells[2].Value);
        }
        public TextContent GetTextContentAt(int index) {
            //0 indexed
            DataGridViewRow row = textDataGrid.Rows[index];
            return new TextContent((int)row.Cells[0].Value, (string)row.Cells[1].Value, (string)row.Cells[2].Value);
        }
        public void ClearAll() {
            textDataGrid.Rows.Clear();
            imageDataGrid.Rows.Clear();
        }

        // Manages grid content incase of or more rows are removed
        #region Re-index Grid
        private void textDataGrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) {
            ReIndexDataGridContent(0);
        }
        private void imageDataGrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) {
            ReIndexDataGridContent(1);
        }

        /// <summary>
        /// Re-number  all the rows
        /// </summary>
        /// <param name="code">'0' coresponds to text grid and '1' corresponds to image grid</param>
        public void ReIndexDataGridContent(int code) {
            if (code == 0) {
                // Reindexing textDataGridView
                for (int i = 0; i < textDataGrid.RowCount; i++) {
                    DataGridViewRow row = textDataGrid.Rows[i];
                    row.Cells[0].Value = i + 1;
                }
            } else {
                // Reindexing imageDataGridView
                for (int i = 0; i < imageDataGrid.RowCount; i++) {
                    DataGridViewRow row = imageDataGrid.Rows[i];
                    row.Cells[0].Value = i + 1;
                }
            }
        }
        #endregion

        #region MenuStripItems
        private void exitMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void saveContentToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveContent(sender, e);
        }

        private void loadContentToolStripMenuItem_Click(object sender, EventArgs e) {
            LoadContent(sender, e);
        }

        private void settingsMenuItem_Click(object sender, EventArgs e) {
            ShowSettings(sender, e);
        }

        private void ClearClipboarderMenuItem_Click(object sender, EventArgs e) {
            textDataGrid.Rows.Clear();
            imageDataGrid.Rows.Clear();
        }

        private void clearClipboardMenuItem_Click(object sender, EventArgs e) {
            Clipboard.Clear();
        }

        private void clearClipboardMenuItem_Click_1(Object sender, EventArgs e) {
            Clipboard.Clear();
        }

        private void installSHLToolStripMenuItem_Click(object sender, EventArgs e) {
            InstallSHLs(sender, e);
        }
        #endregion

        /// <summary>
        /// OnClosing method exits application if Close Reaseon is 
        /// either of Windows shutdown or manual using Menu > Exit
        /// / NotificationIcon > Exit.
        /// 
        /// If CloseReason is neither of the above then MainForm 
        /// visibility is set to false
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (e.CloseReason != CloseReason.WindowsShutDown &&
                    e.CloseReason != CloseReason.ApplicationExitCall) { // To identify close method request
                Hide();
                isFormVisible = false;
                e.Cancel = true;
            } else {
                OnExiting(sender, e);
            }
        }

        #region Text Data Grid Context Menu
        private void mainGridContextMenu_Opened(object sender, EventArgs e) {
            // Checks and Enable/Disables Go to URL menu item
            if (textDataGrid.SelectedRows.Count == 1) {
                TextEventArgs textEventArgs = new TextEventArgs();    // Declares new TextEventArg
                // Adds row text content as string to TextEventArgs
                textEventArgs.Add((string)textDataGrid.SelectedRows[0].Cells[1].Value);
                textGridCheckURLAndSetStatus(sender, textEventArgs);

                if (ContentIdentifier.ContainsURL((string)textDataGrid.SelectedRows[0].Cells[1].Value)) {
                    if (Properties.Settings.Default.isURLIdentificationEnabled) {
                        goToURLToolStripMenuItem.Enabled = true;
                    }
                }
            } else {
                goToURLToolStripMenuItem.Enabled = false;
                viewInSyntaxHighlightingToolStripMenuItem.Enabled = false;
            }
            // Checks and Enable/Disable Edit Context menu item5
            if (textDataGrid.SelectedRows.Count != 1) {
                goToURLToolStripMenuItem.Enabled = false;
            }

        }

        private void editToolStripMenuItem_Click(Object sender, EventArgs e) {
            EditTextContent(sender, e);
        }

        private void viewInSyntaxHighlightingToolStripMenuItem_Click(Object sender, EventArgs e) {
            TextPreview textPreview = new TextPreview((string)textDataGrid.SelectedRows[0].Cells[1].Value);
            textPreview.Show();
        }
        private void copyToClipboardToolStripMenuItem_Click(Object sender, EventArgs e) {
            CopySelectedTextToClipboard(sender, e);
            statusLabel.Text = "Copied to clipboard";
            EnableStatusLifeTimer();
        }

        // Enables/Re-enables timer controlling lifetime of status label
        private void EnableStatusLifeTimer() {
            if (statusTextLifeTimer.Enabled) {
                statusTextLifeTimer.Enabled = false;
            }
            statusTextLifeTimer.Enabled = true;
        }

        #endregion
        private void goToURLToolStripMenuItem_Click(object sender, EventArgs e) {
            URLCalled(sender, e);
        }

        private void textDataGrid_MouseClick(object sender, MouseEventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            if (splitContainer2.Panel2Collapsed) {
                collapseExpandButton.Image = Properties.Resources.Clipboarder_Expand_Arrow;
                splitContainer2.Panel2Collapsed = false;
                Properties.Settings.Default.imagePreviewCollapsed = false;
            } else {
                collapseExpandButton.Image = Properties.Resources.Clipboarder_Collapse_Arrow;
                splitContainer2.Panel2Collapsed = true;
                Properties.Settings.Default.imagePreviewCollapsed = true;
            }
            Properties.Settings.Default.Save();
        }

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e) {
            if (MainTabControl.SelectedIndex == 1) {
                collapseExpandButton.Visible = true;
            } else {
                collapseExpandButton.Visible = false;
            }
        }

        private void imageDataGrid_RowEnter_1(object sender, DataGridViewCellEventArgs e) {
            // Sets preview image to previewPictureBox
            if (imageDataGrid.SelectedRows.Count == 1) {
                picturePreviewBox.Image = (Image)imageDataGrid.Rows[imageDataGrid.SelectedRows[0].Index].Cells[1].Value;
            }

            imagePreviewLabel.Visible = false;  // Hides 'Image Preview' label
        }

        #region Notification context menu options

        private void NotificationMenuContextMenuStrip_Opened(object sender, EventArgs e) {
            if (isFormVisible) {
                showToolStripMenuItem.Text = "Hide";
            } else {
                showToolStripMenuItem.Text = "Show";
            }
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e) {
            if (isFormVisible) {
                Hide();
            } else {
                Show();
            }
            isFormVisible = !isFormVisible;
        }

        private void clearClipboarderToolStripMenuItem_Click(object sender, EventArgs e) {
            ClearAll();
        }

        private void clearClipboardToolStripMenuItem_Click(object sender, EventArgs e) {
            Clipboard.Clear();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void NotificationMenuContextMenuStrip_MouseDoubleClick(object sender, MouseEventArgs e) {
            isFormVisible = true;
            Show();
        }
        #endregion

        private void MainMenuStrip_ItemClicked(Object sender, ToolStripItemClickedEventArgs e) {

        }

        private void toolStripStatusLabel2_Click(Object sender, EventArgs e) {
            Process.Start("https://github.com/Suyash12mahar/Clipboarder/issues/new");
        }

        private void toolStripStatusLabel1_Click(Object sender, EventArgs e) {
            Process.Start("https://github.com/Suyash12mahar/Clipboarder/");
        }
    }
}
