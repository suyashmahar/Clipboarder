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
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveContentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadContentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertDataGridViewRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.MessageCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.clipboardMonitor1 = new Cllipboarder.ClipboardMonitor();
            this.imagePage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.imageDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textPage = new System.Windows.Forms.TabPage();
            this.textDataGrid = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.MainMenuStrip.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            this.imagePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.SettingsToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(814, 45);
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
            this.saveContentToolStripMenuItem.Name = "saveContentToolStripMenuItem";
            this.saveContentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveContentToolStripMenuItem.Text = "Save Content";
            this.saveContentToolStripMenuItem.Click += new System.EventHandler(this.saveContentToolStripMenuItem_Click);
            // 
            // loadContentToolStripMenuItem
            // 
            this.loadContentToolStripMenuItem.Name = "loadContentToolStripMenuItem";
            this.loadContentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadContentToolStripMenuItem.Text = "Load Content";
            this.loadContentToolStripMenuItem.Click += new System.EventHandler(this.loadContentToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // SaveAllToolStripMenuItem
            // 
            this.SaveAllToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SaveAllToolStripMenuItem.Name = "SaveAllToolStripMenuItem";
            this.SaveAllToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.SaveAllToolStripMenuItem.Size = new System.Drawing.Size(152, 20);
            this.SaveAllToolStripMenuItem.Text = "Exit";
            this.SaveAllToolStripMenuItem.Click += new System.EventHandler(this.SaveAllToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItem1.Image = global::Clipboarder.Properties.Resources.Clipboarder_Gear_Icon;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 50);
            this.toolStripMenuItem1.Text = "Settings";
            this.toolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            this.toolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(164, 22);
            this.toolStripMenuItem3.Text = "Clear clipboarder";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(164, 22);
            this.toolStripMenuItem4.Text = "Clear clipboard";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.AutoSize = false;
            this.SettingsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.SettingsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SettingsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertDataGridViewRowToolStripMenuItem});
            this.SettingsToolStripMenuItem.Image = global::Clipboarder.Properties.Resources.Clipboarder_Debug_Icon;
            this.SettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(50, 50);
            this.SettingsToolStripMenuItem.Text = "Settings";
            this.SettingsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // insertDataGridViewRowToolStripMenuItem
            // 
            this.insertDataGridViewRowToolStripMenuItem.Name = "insertDataGridViewRowToolStripMenuItem";
            this.insertDataGridViewRowToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.insertDataGridViewRowToolStripMenuItem.Text = "Insert DataGridViewRow";
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.MessageCountLabel});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 366);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(814, 22);
            this.MainStatusStrip.TabIndex = 8;
            this.MainStatusStrip.Text = "MainStatusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // MessageCountLabel
            // 
            this.MessageCountLabel.Name = "MessageCountLabel";
            this.MessageCountLabel.Size = new System.Drawing.Size(47, 17);
            this.MessageCountLabel.Text = "No Text";
            this.MessageCountLabel.Visible = false;
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
            // imagePage
            // 
            this.imagePage.Controls.Add(this.splitContainer1);
            this.imagePage.Location = new System.Drawing.Point(4, 25);
            this.imagePage.Name = "imagePage";
            this.imagePage.Padding = new System.Windows.Forms.Padding(3);
            this.imagePage.Size = new System.Drawing.Size(806, 292);
            this.imagePage.TabIndex = 1;
            this.imagePage.Text = "Image";
            this.imagePage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.imageDataGrid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 286);
            this.splitContainer1.SplitterDistance = 628;
            this.splitContainer1.TabIndex = 0;
            // 
            // imageDataGrid
            // 
            this.imageDataGrid.AllowUserToAddRows = false;
            this.imageDataGrid.AllowUserToOrderColumns = true;
            this.imageDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.imageDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.imageDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imageDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.imageDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.imageDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.imageDataGrid.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.imageDataGrid.Location = new System.Drawing.Point(0, 0);
            this.imageDataGrid.Name = "imageDataGrid";
            this.imageDataGrid.ReadOnly = true;
            this.imageDataGrid.RowHeadersVisible = false;
            this.imageDataGrid.Size = new System.Drawing.Size(628, 286);
            this.imageDataGrid.TabIndex = 12;
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
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 286);
            this.label1.TabIndex = 1;
            this.label1.Text = "Preview pane";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 286);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textPage
            // 
            this.textPage.Controls.Add(this.textDataGrid);
            this.textPage.Location = new System.Drawing.Point(4, 25);
            this.textPage.Name = "textPage";
            this.textPage.Size = new System.Drawing.Size(806, 292);
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
            this.textDataGrid.Size = new System.Drawing.Size(806, 292);
            this.textDataGrid.TabIndex = 10;
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
            this.MainTabControl.Size = new System.Drawing.Size(814, 321);
            this.MainTabControl.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 388);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.clipboardMonitor1);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.MainMenuStrip);
            this.Name = "MainForm";
            this.Text = "Clipboarder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.imagePage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        internal System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        internal System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        internal System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        internal System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        internal System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem insertDataGridViewRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel MessageCountLabel;
        private Cllipboarder.ClipboardMonitor clipboardMonitor1;
        private System.Windows.Forms.ToolStripMenuItem saveContentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TabPage imagePage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        internal System.Windows.Forms.DataGridView imageDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage textPage;
        internal System.Windows.Forms.DataGridView textDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.ToolStripMenuItem loadContentToolStripMenuItem;
    }
}

