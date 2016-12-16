using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clipboarder {
    public partial class MainForm : Form, IMainDataLayer {
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            ViewLoaded(sender, e);
        }

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
        
        public event EventHandler<EventArgs> LoadContent;
        public event EventHandler<EventArgs> SaveContent;
        public event EventHandler<EventArgs> OnExiting;
        public event EventHandler<EventArgs> ViewLoaded;

        public void AddNewImageRow(ImageContent contentToAdd) {
            DataGridViewRow NewRow = new DataGridViewRow();
            NewRow.CreateCells(textDataGrid);
            
            NewRow.Cells[0].Value = contentToAdd.index;
            NewRow.Cells[1].Value = contentToAdd.image;
            NewRow.Cells[2].Value = contentToAdd.time;

            textDataGrid.Rows.Insert(textDataGrid.RowCount, NewRow);
        }

        public void AddNewTextRow(TextContent contentToAdd) {
            DataGridViewRow NewRow = new DataGridViewRow();
            NewRow.CreateCells(imageDataGrid);

            NewRow.Cells[0].Value = contentToAdd.index;
            NewRow.Cells[1].Value = contentToAdd.text;
            NewRow.Cells[2].Value = contentToAdd.time;

            textDataGrid.Rows.Insert(imageDataGrid.RowCount, NewRow);
        }

        public List<ImageContent> GetAllImageContent() {
            List<ImageContent> returnValues = new List<ImageContent>();

            for (int i = 0; i < imageDataGrid.RowCount; i++) {
                ImageContent contentToAdd;
                contentToAdd.index = (int)imageDataGrid.Rows[i].Cells[0].Value;
                contentToAdd.image = (Image)imageDataGrid.Rows[i].Cells[1].Value;
                contentToAdd.time = (string)imageDataGrid.Rows[i].Cells[3].Value;

                returnValues.Add(contentToAdd);
            }

            return returnValues;
        }

        public List<TextContent> GetAllTextContent() {
            List<TextContent> returnValues = new List<TextContent>();

            for (int i = 0; i < textDataGrid.RowCount; i++) {
                TextContent contentToAdd;
                contentToAdd.index = (int)textDataGrid.Rows[i].Cells[0].Value;
                contentToAdd.text = (string)textDataGrid.Rows[i].Cells[1].Value;
                contentToAdd.time = (string)textDataGrid.Rows[i].Cells[3].Value;

                returnValues.Add(contentToAdd);
            }

            return returnValues;
        }

        // Manges grid content incase on or more rows are removed
        #region Re-index Grid
        private void textDataGrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) {
            reIndexDataGridContent(0);
        }

        private void imageDataGrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) {
            reIndexDataGridContent(1);
        }

        /// <summary>
        /// Re-number  all the rows
        /// </summary>
        /// <param name="code">'0' coresponds to text grid and '1' corresponds to image grid</param>
        public void reIndexDataGridContent(int code) {
            // Reindexing textDataGridView
            for (int i = 0; i < textDataGrid.RowCount; i++) {
                DataGridViewRow row = textDataGrid.Rows[i];
                row.Cells[0].Value = i + 1;
            }

            // Reindexing imageDataGridView
            for (int i = 0; i < imageDataGrid.RowCount; i++) {
                DataGridViewRow row = imageDataGrid.Rows[i];
                row.Cells[0].Value = i + 1;
            }
        }

        #endregion

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
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }
    }
}
