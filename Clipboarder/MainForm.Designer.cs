namespace Clipboarder {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.clipboardMonitor1 = new ClipboardMonitor();
            this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGrid = new System.Windows.Forms.DataGridView();
            this.textPage = new System.Windows.Forms.TabPage();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGrid = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.imagePage = new System.Windows.Forms.TabPage();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.springStatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.clearClipboardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearClipboarderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loadContentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveContentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.textDataGrid)).BeginInit();
            this.textPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.imagePage.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // clipboardMonitor1
            // 
            this.clipboardMonitor1.BackColor = System.Drawing.Color.Red;
            this.clipboardMonitor1.Location = new System.Drawing.Point(835, 497);
            this.clipboardMonitor1.Name = "clipboardMonitor1";
            this.clipboardMonitor1.Size = new System.Drawing.Size(10, 10);
            this.clipboardMonitor1.TabIndex = 14;
            this.clipboardMonitor1.Text = "clipboardMonitor1";
            this.clipboardMonitor1.Visible = false;
            // 
            // TimeColumn
            // 
            this.TimeColumn.FillWeight = 50F;
            this.TimeColumn.HeaderText = "Time";
            this.TimeColumn.Name = "TimeColumn";
            this.TimeColumn.ReadOnly = true;
            // 
            // Content
            // 
            this.Content.FillWeight = 226.3333F;
            this.Content.HeaderText = "Data";
            this.Content.Name = "Content";
            this.Content.ReadOnly = true;
            this.Content.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.textDataGrid.Size = new System.Drawing.Size(529, 235);
            this.textDataGrid.TabIndex = 10;
            this.textDataGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.textDataGrid_RowsRemoved);
            // 
            // textPage
            // 
            this.textPage.Controls.Add(this.textDataGrid);
            this.textPage.Location = new System.Drawing.Point(4, 25);
            this.textPage.Name = "textPage";
            this.textPage.Size = new System.Drawing.Size(529, 235);
            this.textPage.TabIndex = 0;
            this.textPage.Text = "Text";
            this.textPage.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 50F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Time";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
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
            this.imageDataGrid.Size = new System.Drawing.Size(411, 233);
            this.imageDataGrid.TabIndex = 12;
            this.imageDataGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.imageDataGrid_RowsRemoved);
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
            this.splitContainer1.Size = new System.Drawing.Size(411, 233);
            this.splitContainer1.SplitterDistance = 333;
            this.splitContainer1.TabIndex = 0;
            // 
            // imagePage
            // 
            this.imagePage.Controls.Add(this.splitContainer1);
            this.imagePage.Location = new System.Drawing.Point(4, 25);
            this.imagePage.Name = "imagePage";
            this.imagePage.Size = new System.Drawing.Size(411, 233);
            this.imagePage.TabIndex = 1;
            this.imagePage.Text = "Image";
            this.imagePage.UseVisualStyleBackColor = true;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(34, 17);
            this.toolStripStatusLabel1.Text = "BETA";
            // 
            // progressBar
            // 
            this.progressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // springStatusStripLabel
            // 
            this.springStatusStripLabel.Name = "springStatusStripLabel";
            this.springStatusStripLabel.Size = new System.Drawing.Size(347, 17);
            this.springStatusStripLabel.Spring = true;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Ready";
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.springStatusStripLabel,
            this.progressBar,
            this.toolStripStatusLabel1});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 287);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(537, 22);
            this.MainStatusStrip.TabIndex = 13;
            this.MainStatusStrip.Text = "MainStatusStrip";
            // 
            // clearClipboardMenuItem
            // 
            this.clearClipboardMenuItem.Image = global::Clipboarder.Properties.Resources.Clipboarder_Clipboard_Clear_Icon;
            this.clearClipboardMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clearClipboardMenuItem.Name = "clearClipboardMenuItem";
            this.clearClipboardMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.clearClipboardMenuItem.Size = new System.Drawing.Size(251, 26);
            this.clearClipboardMenuItem.Text = "Clear clipboard";
            // 
            // ClearClipboarderMenuItem
            // 
            this.ClearClipboarderMenuItem.AutoSize = false;
            this.ClearClipboarderMenuItem.Image = global::Clipboarder.Properties.Resources.Clipboarder_Clipboarder_clear_Icon;
            this.ClearClipboarderMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ClearClipboarderMenuItem.Name = "ClearClipboarderMenuItem";
            this.ClearClipboarderMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Delete)));
            this.ClearClipboarderMenuItem.Size = new System.Drawing.Size(251, 26);
            this.ClearClipboarderMenuItem.Text = "Clear clipboarder";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AutoSize = false;
            this.toolStripMenuItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripMenuItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearClipboarderMenuItem,
            this.clearClipboardMenuItem});
            this.toolStripMenuItem2.Image = global::Clipboarder.Properties.Resources.Clipboarder_Clean_Icon;
            this.toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(50, 50);
            this.toolStripMenuItem2.Text = "Edit";
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.AutoSize = false;
            this.settingsMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.settingsMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.settingsMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.settingsMenuItem.Image = global::Clipboarder.Properties.Resources.Clipboarder_Gear_Icon;
            this.settingsMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(50, 50);
            this.settingsMenuItem.Text = "Settings";
            this.settingsMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.settingsMenuItem.Click += new System.EventHandler(this.settingsMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Image = global::Clipboarder.Properties.Resources.Clipboarder_Close_Icon;
            this.exitMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.exitMenuItem.Size = new System.Drawing.Size(190, 24);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // loadContentToolStripMenuItem
            // 
            this.loadContentToolStripMenuItem.Image = global::Clipboarder.Properties.Resources.Clipboarder_Import_Icon;
            this.loadContentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.loadContentToolStripMenuItem.Name = "loadContentToolStripMenuItem";
            this.loadContentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadContentToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.loadContentToolStripMenuItem.Text = "Load Content";
            this.loadContentToolStripMenuItem.Click += new System.EventHandler(this.loadContentToolStripMenuItem_Click);
            // 
            // saveContentToolStripMenuItem
            // 
            this.saveContentToolStripMenuItem.Image = global::Clipboarder.Properties.Resources.Clipboarder_Export_Icon;
            this.saveContentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveContentToolStripMenuItem.Name = "saveContentToolStripMenuItem";
            this.saveContentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveContentToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.saveContentToolStripMenuItem.Text = "Save Content";
            this.saveContentToolStripMenuItem.Click += new System.EventHandler(this.saveContentToolStripMenuItem_Click);
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
            this.exitMenuItem});
            this.ToolsToolStripMenuItem.Image = global::Clipboarder.Properties.Resources.Clipboarder_Menu_Icon;
            this.ToolsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            this.ToolsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.ToolsToolStripMenuItem.Size = new System.Drawing.Size(50, 50);
            this.ToolsToolStripMenuItem.Text = "Tools";
            this.ToolsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            this.MainTabControl.Size = new System.Drawing.Size(537, 264);
            this.MainTabControl.TabIndex = 15;
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.AutoSize = false;
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolsToolStripMenuItem,
            this.settingsMenuItem,
            this.toolStripMenuItem2});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(537, 45);
            this.MainMenuStrip.TabIndex = 12;
            this.MainMenuStrip.Text = "MainMenuStrip";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 309);
            this.Controls.Add(this.clipboardMonitor1);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.MainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(382, 268);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textDataGrid)).EndInit();
            this.textPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageDataGrid)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.imagePage.ResumeLayout(false);
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.MainTabControl.ResumeLayout(false);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clipboarder.ClipboardMonitor clipboardMonitor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        internal System.Windows.Forms.DataGridView textDataGrid;
        private System.Windows.Forms.TabPage textPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        internal System.Windows.Forms.DataGridView imageDataGrid;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage imagePage;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel springStatusStripLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        internal System.Windows.Forms.StatusStrip MainStatusStrip;
        internal System.Windows.Forms.ToolStripMenuItem clearClipboardMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ClearClipboarderMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        internal System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem loadContentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveContentToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ToolsToolStripMenuItem;
        private System.Windows.Forms.TabControl MainTabControl;
        internal System.Windows.Forms.MenuStrip MainMenuStrip;
    }
}