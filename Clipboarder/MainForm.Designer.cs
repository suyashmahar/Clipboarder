using System;

namespace Clipboarder
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveContentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadContentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fillWithGarbageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.springStatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.imagePage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.imageDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textPage = new System.Windows.Forms.TabPage();
            this.textDataGrid = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.clipboardMonitor1 = new Cllipboarder.ClipboardMonitor();
            this.MainMenuStrip.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            this.imagePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageDataGrid)).BeginInit();
            this.textPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textDataGrid)).BeginInit();
            this.MainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.AutoSize = false;
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolsToolStripMenuItem,
            this.toolStripMenuItem5,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(509, 45);
            this.MainMenuStrip.TabIndex = 6;
            this.MainMenuStrip.Text = "MainMenuStrip";
            // 
            // ToolsToolStripMenuItem
            // 
            this.ToolsToolStripMenuItem.AutoSize = false;
            this.ToolsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ToolsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveContentToolStripMenuItem,
            this.loadContentToolStripMenuItem,
            this.toolStripSeparator1,
            this.SaveAllToolStripMenuItem});
            this.ToolsToolStripMenuItem.Image = global::Clipboarder.Properties.Resources.Clipboarder_Menu_Icon;
            this.ToolsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            this.ToolsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.ToolsToolStripMenuItem.Size = new System.Drawing.Size(50, 50);
            this.ToolsToolStripMenuItem.Text = "Tools";
            this.ToolsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // saveContentToolStripMenuItem
            // 
            this.saveContentToolStripMenuItem.Image = global::Clipboarder.Properties.Resources.Clipboarder_Export_Icon;
            this.saveContentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveContentToolStripMenuItem.Name = "saveContentToolStripMenuItem";
            this.saveContentToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.saveContentToolStripMenuItem.Text = "Save Content";
            this.saveContentToolStripMenuItem.Click += new System.EventHandler(this.saveContentToolStripMenuItem_Click);
            // 
            // loadContentToolStripMenuItem
            // 
            this.loadContentToolStripMenuItem.Image = global::Clipboarder.Properties.Resources.Clipboarder_Import_Icon;
            this.loadContentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.loadContentToolStripMenuItem.Name = "loadContentToolStripMenuItem";
            this.loadContentToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.loadContentToolStripMenuItem.Text = "Load Content";
            this.loadContentToolStripMenuItem.Click += new System.EventHandler(this.loadContentToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // SaveAllToolStripMenuItem
            // 
            this.SaveAllToolStripMenuItem.Image = global::Clipboarder.Properties.Resources.Clipboarder_Close_Icon;
            this.SaveAllToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SaveAllToolStripMenuItem.Name = "SaveAllToolStripMenuItem";
            this.SaveAllToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.SaveAllToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.SaveAllToolStripMenuItem.Text = "Exit";
            this.SaveAllToolStripMenuItem.Click += new System.EventHandler(this.SaveAllToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.AutoSize = false;
            this.toolStripMenuItem5.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripMenuItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItem5.Image = global::Clipboarder.Properties.Resources.Clipboarder_Gear_Icon;
            this.toolStripMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(50, 50);
            this.toolStripMenuItem5.Text = "Settings";
            this.toolStripMenuItem5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AutoSize = false;
            this.toolStripMenuItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripMenuItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.toolStripMenuItem2.Image = global::Clipboarder.Properties.Resources.Clipboarder_Clean_Icon;
            this.toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(50, 50);
            this.toolStripMenuItem2.Text = "Edit";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.AutoSize = false;
            this.toolStripMenuItem3.Image = global::Clipboarder.Properties.Resources.Clipboarder_Clipboarder_clear_Icon;
            this.toolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(164, 22);
            this.toolStripMenuItem3.Text = "Clear clipboarder";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = global::Clipboarder.Properties.Resources.Clipboarder_Clipboard_Clear_Icon;
            this.toolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(168, 26);
            this.toolStripMenuItem4.Text = "Clear clipboard";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillWithGarbageToolStripMenuItem});
            this.toolStripMenuItem1.Image = global::Clipboarder.Properties.Resources.Clipboarder_Debug_Icon;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F1)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 50);
            this.toolStripMenuItem1.Text = "Settings";
            this.toolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // fillWithGarbageToolStripMenuItem
            // 
            this.fillWithGarbageToolStripMenuItem.Name = "fillWithGarbageToolStripMenuItem";
            this.fillWithGarbageToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.fillWithGarbageToolStripMenuItem.Text = "Fill with garbage";
            this.fillWithGarbageToolStripMenuItem.Click += new System.EventHandler(this.fillWithGarbageToolStripMenuItem_Click);
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.springStatusStripLabel,
            this.progressBar});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 321);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(509, 22);
            this.MainStatusStrip.TabIndex = 8;
            this.MainStatusStrip.Text = "MainStatusStrip";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Ready";
            // 
            // springStatusStripLabel
            // 
            this.springStatusStripLabel.Name = "springStatusStripLabel";
            this.springStatusStripLabel.Size = new System.Drawing.Size(322, 17);
            this.springStatusStripLabel.Spring = true;
            // 
            // progressBar
            // 
            this.progressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // imagePage
            // 
            this.imagePage.Controls.Add(this.splitContainer1);
            this.imagePage.Location = new System.Drawing.Point(4, 25);
            this.imagePage.Name = "imagePage";
            this.imagePage.Size = new System.Drawing.Size(358, 133);
            this.imagePage.TabIndex = 1;
            this.imagePage.Text = "Image";
            this.imagePage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.imageDataGrid);
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Size = new System.Drawing.Size(358, 133);
            this.splitContainer1.SplitterDistance = 333;
            this.splitContainer1.TabIndex = 0;
            // 
            // imageDataGrid
            // 
            this.imageDataGrid.AllowUserToAddRows = false;
            this.imageDataGrid.AllowUserToOrderColumns = true;
            this.imageDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.imageDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.imageDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imageDataGrid.ColumnHeadersHeight = 27;
            this.imageDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.imageDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.imageDataGrid.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.imageDataGrid.Location = new System.Drawing.Point(0, 0);
            this.imageDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.imageDataGrid.Name = "imageDataGrid";
            this.imageDataGrid.ReadOnly = true;
            this.imageDataGrid.RowHeadersVisible = false;
            this.imageDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.imageDataGrid.Size = new System.Drawing.Size(358, 133);
            this.imageDataGrid.TabIndex = 12;
            this.imageDataGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.imageDataGrid_RowsRemoved);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.FillWeight = 50F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Index";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 66;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 226.3333F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Image";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 50F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Time";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // textPage
            // 
            this.textPage.Controls.Add(this.textDataGrid);
            this.textPage.Location = new System.Drawing.Point(4, 25);
            this.textPage.Name = "textPage";
            this.textPage.Size = new System.Drawing.Size(501, 247);
            this.textPage.TabIndex = 0;
            this.textPage.Text = "Text";
            this.textPage.UseVisualStyleBackColor = true;
            // 
            // textDataGrid
            // 
            this.textDataGrid.AllowUserToAddRows = false;
            this.textDataGrid.AllowUserToOrderColumns = true;
            this.textDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.textDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.textDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.textDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.textDataGrid.ColumnHeadersHeight = 27;
            this.textDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Content,
            this.TimeColumn});
            this.textDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.textDataGrid.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.textDataGrid.Location = new System.Drawing.Point(0, 0);
            this.textDataGrid.Name = "textDataGrid";
            this.textDataGrid.ReadOnly = true;
            this.textDataGrid.RowHeadersVisible = false;
            this.textDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.textDataGrid.Size = new System.Drawing.Size(501, 247);
            this.textDataGrid.TabIndex = 10;
            this.textDataGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.textDataGrid_RowsRemoved);
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Number.FillWeight = 50F;
            this.Number.HeaderText = "Index";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Number.Width = 66;
            // 
            // Content
            // 
            this.Content.FillWeight = 226.3333F;
            this.Content.HeaderText = "Data";
            this.Content.Name = "Content";
            this.Content.ReadOnly = true;
            this.Content.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TimeColumn
            // 
            this.TimeColumn.FillWeight = 50F;
            this.TimeColumn.HeaderText = "Time";
            this.TimeColumn.Name = "TimeColumn";
            this.TimeColumn.ReadOnly = true;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.textPage);
            this.MainTabControl.Controls.Add(this.imagePage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTabControl.Location = new System.Drawing.Point(0, 45);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.Padding = new System.Drawing.Point(0, 0);
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(509, 276);
            this.MainTabControl.TabIndex = 11;
            // 
            // clipboardMonitor1
            // 
            this.clipboardMonitor1.BackColor = System.Drawing.Color.Red;
            this.clipboardMonitor1.Location = new System.Drawing.Point(1352, 725);
            this.clipboardMonitor1.Name = "clipboardMonitor1";
            this.clipboardMonitor1.Size = new System.Drawing.Size(10, 10);
            this.clipboardMonitor1.TabIndex = 10;
            this.clipboardMonitor1.Text = "clipboardMonitor1";
            this.clipboardMonitor1.Visible = false;
            this.clipboardMonitor1.ClipboardChanged += new System.EventHandler<Cllipboarder.ClipboardChangedEventArgs>(this.clipboardMonitor1_ClipboardChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 343);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.clipboardMonitor1);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.MainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(382, 268);
            this.Name = "MainForm";
            this.Text = "Clipboarder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.imagePage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageDataGrid)).EndInit();
            this.textPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textDataGrid)).EndInit();
            this.MainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MainMenuStrip;
        internal System.Windows.Forms.ToolStripMenuItem ToolsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SaveAllToolStripMenuItem;
        internal System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        internal System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        internal System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        internal System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private Cllipboarder.ClipboardMonitor clipboardMonitor1;
        private System.Windows.Forms.ToolStripMenuItem saveContentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TabPage imagePage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        internal System.Windows.Forms.DataGridView imageDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TabPage textPage;
        internal System.Windows.Forms.DataGridView textDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.ToolStripMenuItem loadContentToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        internal System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fillWithGarbageToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel springStatusStripLabel;
    }
}

