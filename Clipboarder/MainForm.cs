using Clipboarder.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;


namespace Clipboarder {
    public partial class MainForm : Form, IMainDataLayer {
        private MainFormPresenter presenter;

        #region Properties
        public int TaskProgress {
            get {
                return progressBar.Value;
            }

            set {
                progressBar.Value = value;
            }
        }
        public bool ProgressVisibility {
            get {
                return progressBar.Visible;
            }

            set {
                progressBar.Visible = value;
            }
        }
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
            }
        }
        public string SelectedRowText {
            get {
                if (textDataGrid.SelectedRows.Count == 1) {
                    return (string)textDataGrid.SelectedRows[0].Cells[1].Value;    
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
        }

        private void MainForm_Load(object sender, EventArgs e) {
            presenter = new MainFormPresenter(this);
        }      

        public event EventHandler<EventArgs> LoadContent;
        public event EventHandler<EventArgs> SaveContent;
        public event EventHandler<EventArgs> OnExiting;
        public event EventHandler<EventArgs> ViewLoaded;
        public event EventHandler<EventArgs> ShowSettings;
        public event EventHandler<EventArgs> URLCalled;
        public event EventHandler<TextEventArgs> textGridCheckURLAndSetStatus;

        public void AddNewImageRow(ImageContent contentToAdd) {
            DataGridViewRow NewRow = new DataGridViewRow();
            NewRow.CreateCells(imageDataGrid);
            
            NewRow.Cells[0].Value = contentToAdd.index;
            NewRow.Cells[1].Value = contentToAdd.image;
            NewRow.Cells[2].Value = contentToAdd.time;

            //Adjusts height of a row
            NewRow.Height = Clipboard.GetImage().Height;
            
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
            Close();
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
        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            OnExiting(sender, e);
        }

        private void mainGridContextMenu_Opened(object sender, EventArgs e) {
            if (textDataGrid.SelectedRows.Count == 1) {
                TextEventArgs textEventArgs = new TextEventArgs();    // Declares new TextEventArg
                textEventArgs.Add((string)textDataGrid.SelectedRows[0].Cells[1].Value);   // Adds row text content as string to TextEventArgs
                textGridCheckURLAndSetStatus(sender, textEventArgs);
            } else {
                goToURLToolStripMenuItem.Enabled = false;
            }
        }

        private void goToURLToolStripMenuItem_Click(object sender, EventArgs e) {
            URLCalled(sender, e);
        }

        private void textDataGrid_MouseClick(object sender, MouseEventArgs e) {
            
        }
    }
}
