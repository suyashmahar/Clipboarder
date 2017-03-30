using Clipboarder;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGrid = new System.Windows.Forms.DataGridView();
            this.mainGridContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.goToURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInSyntaxHighlightingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textPage = new System.Windows.Forms.TabPage();
            this.imagePage = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.imageDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagePreviewLabel = new System.Windows.Forms.Label();
            this.picturePreviewBox = new System.Windows.Forms.PictureBox();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveContentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadContentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearClipboarderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearClipboardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.springStatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotificationMenuContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clearClipboarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseExpandButton = new System.Windows.Forms.PictureBox();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.textDataGrid)).BeginInit();
            this.mainGridContextMenu.SuspendLayout();
            this.textPage.SuspendLayout();
            this.imagePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreviewBox)).BeginInit();
            this.MainTabControl.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            this.NotificationMenuContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collapseExpandButton)).BeginInit();
            this.SuspendLayout();
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
            this.textDataGrid.ContextMenuStrip = this.mainGridContextMenu;
            this.textDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.textDataGrid.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.textDataGrid.Location = new System.Drawing.Point(0, 0);
            this.textDataGrid.Name = "textDataGrid";
            this.textDataGrid.ReadOnly = true;
            this.textDataGrid.RowHeadersVisible = false;
            this.textDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.textDataGrid.Size = new System.Drawing.Size(614, 272);
            this.textDataGrid.TabIndex = 10;
            this.textDataGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.textDataGrid_RowsRemoved);
            this.textDataGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textDataGrid_MouseClick);
            // 
            // mainGridContextMenu
            // 
            this.mainGridContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.copyToClipboardToolStripMenuItem,
            this.toolStripSeparator4,
            this.goToURLToolStripMenuItem,
            this.viewInSyntaxHighlightingToolStripMenuItem});
            this.mainGridContextMenu.Name = "mainGridContextMenu";
            this.mainGridContextMenu.Size = new System.Drawing.Size(217, 98);
            this.mainGridContextMenu.Opened += new System.EventHandler(this.mainGridContextMenu_Opened);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.copyToClipboardToolStripMenuItem.Text = "Copy to clipboard";
            this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(213, 6);
            // 
            // goToURLToolStripMenuItem
            // 
            this.goToURLToolStripMenuItem.Enabled = false;
            this.goToURLToolStripMenuItem.Name = "goToURLToolStripMenuItem";
            this.goToURLToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.goToURLToolStripMenuItem.Text = "Go to URL";
            this.goToURLToolStripMenuItem.Click += new System.EventHandler(this.goToURLToolStripMenuItem_Click);
            // 
            // viewInSyntaxHighlightingToolStripMenuItem
            // 
            this.viewInSyntaxHighlightingToolStripMenuItem.Name = "viewInSyntaxHighlightingToolStripMenuItem";
            this.viewInSyntaxHighlightingToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.viewInSyntaxHighlightingToolStripMenuItem.Text = "View in syntax highlighting";
            this.viewInSyntaxHighlightingToolStripMenuItem.Click += new System.EventHandler(this.viewInSyntaxHighlightingToolStripMenuItem_Click);
            // 
            // textPage
            // 
            this.textPage.Controls.Add(this.textDataGrid);
            this.textPage.Location = new System.Drawing.Point(4, 25);
            this.textPage.Name = "textPage";
            this.textPage.Size = new System.Drawing.Size(614, 272);
            this.textPage.TabIndex = 0;
            this.textPage.Text = "Text";
            this.textPage.UseVisualStyleBackColor = true;
            // 
            // imagePage
            // 
            this.imagePage.Controls.Add(this.splitContainer2);
            this.imagePage.Location = new System.Drawing.Point(4, 25);
            this.imagePage.Name = "imagePage";
            this.imagePage.Size = new System.Drawing.Size(614, 272);
            this.imagePage.TabIndex = 1;
            this.imagePage.Text = "Image";
            this.imagePage.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.imageDataGrid);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.imagePreviewLabel);
            this.splitContainer2.Panel2.Controls.Add(this.picturePreviewBox);
            this.splitContainer2.Size = new System.Drawing.Size(614, 272);
            this.splitContainer2.SplitterDistance = 456;
            this.splitContainer2.TabIndex = 14;
            // 
            // imageDataGrid
            // 
            this.imageDataGrid.AllowUserToAddRows = false;
            this.imageDataGrid.AllowUserToOrderColumns = true;
            this.imageDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.imageDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.imageDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.imageDataGrid.Size = new System.Drawing.Size(456, 272);
            this.imageDataGrid.TabIndex = 12;
            this.imageDataGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.imageDataGrid_RowEnter_1);
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
            // imagePreviewLabel
            // 
            this.imagePreviewLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imagePreviewLabel.AutoSize = true;
            this.imagePreviewLabel.Enabled = false;
            this.imagePreviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.85F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagePreviewLabel.Location = new System.Drawing.Point(28, 118);
            this.imagePreviewLabel.Name = "imagePreviewLabel";
            this.imagePreviewLabel.Size = new System.Drawing.Size(88, 15);
            this.imagePreviewLabel.TabIndex = 1;
            this.imagePreviewLabel.Text = "Image Preview";
            // 
            // picturePreviewBox
            // 
            this.picturePreviewBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picturePreviewBox.Location = new System.Drawing.Point(0, 0);
            this.picturePreviewBox.Name = "picturePreviewBox";
            this.picturePreviewBox.Size = new System.Drawing.Size(154, 272);
            this.picturePreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePreviewBox.TabIndex = 0;
            this.picturePreviewBox.TabStop = false;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTabControl.Controls.Add(this.textPage);
            this.MainTabControl.Controls.Add(this.imagePage);
            this.MainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTabControl.Location = new System.Drawing.Point(0, 48);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.Padding = new System.Drawing.Point(0, 0);
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(622, 301);
            this.MainTabControl.TabIndex = 15;
            this.MainTabControl.SelectedIndexChanged += new System.EventHandler(this.MainTabControl_SelectedIndexChanged);
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
            this.MainMenuStrip.Size = new System.Drawing.Size(622, 45);
            this.MainMenuStrip.TabIndex = 12;
            this.MainMenuStrip.Text = "MainMenuStrip";
            this.MainMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MainMenuStrip_ItemClicked);
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
            // saveContentToolStripMenuItem
            // 
            this.saveContentToolStripMenuItem.Image = global::Clipboarder.Properties.Resources.Clipboarder_Export_Icon;
            this.saveContentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveContentToolStripMenuItem.Name = "saveContentToolStripMenuItem";
            this.saveContentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveContentToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.saveContentToolStripMenuItem.Text = "Save Content";
            this.saveContentToolStripMenuItem.Click += new System.EventHandler(this.saveContentToolStripMenuItem_Click);
            // 
            // loadContentToolStripMenuItem
            // 
            this.loadContentToolStripMenuItem.Image = global::Clipboarder.Properties.Resources.Clipboarder_Import_Icon;
            this.loadContentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.loadContentToolStripMenuItem.Name = "loadContentToolStripMenuItem";
            this.loadContentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadContentToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.loadContentToolStripMenuItem.Text = "Load Content";
            this.loadContentToolStripMenuItem.Click += new System.EventHandler(this.loadContentToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Image = global::Clipboarder.Properties.Resources.Clipboarder_Close_Icon;
            this.exitMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.exitMenuItem.Size = new System.Drawing.Size(193, 24);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
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
            this.ClearClipboarderMenuItem.Click += new System.EventHandler(this.ClearClipboarderMenuItem_Click);
            // 
            // clearClipboardMenuItem
            // 
            this.clearClipboardMenuItem.Image = global::Clipboarder.Properties.Resources.Clipboarder_Clipboard_Clear_Icon;
            this.clearClipboardMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clearClipboardMenuItem.Name = "clearClipboardMenuItem";
            this.clearClipboardMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.clearClipboardMenuItem.Size = new System.Drawing.Size(251, 26);
            this.clearClipboardMenuItem.Text = "Clear Clipboard";
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.springStatusStripLabel,
            this.progressBar,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 349);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(622, 22);
            this.MainStatusStrip.TabIndex = 16;
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
            this.springStatusStripLabel.Size = new System.Drawing.Size(326, 17);
            this.springStatusStripLabel.Spring = true;
            // 
            // progressBar
            // 
            this.progressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(111)))), ((int)(((byte)(255)))));
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(111)))), ((int)(((byte)(255)))));
            this.toolStripStatusLabel2.IsLink = true;
            this.toolStripStatusLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(111)))), ((int)(((byte)(255)))));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(75, 17);
            this.toolStripStatusLabel2.Text = "Report a bug";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // mainNotifyIcon
            // 
            this.mainNotifyIcon.ContextMenuStrip = this.NotificationMenuContextMenuStrip;
            this.mainNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("mainNotifyIcon.Icon")));
            this.mainNotifyIcon.Text = "Clipboarder";
            this.mainNotifyIcon.Visible = true;
            // 
            // NotificationMenuContextMenuStrip
            // 
            this.NotificationMenuContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.toolStripSeparator2,
            this.clearClipboarderToolStripMenuItem,
            this.clearClipboardToolStripMenuItem,
            this.toolStripSeparator3,
            this.closeToolStripMenuItem});
            this.NotificationMenuContextMenuStrip.Name = "NotificationMenuContextMenuStrip";
            this.NotificationMenuContextMenuStrip.Size = new System.Drawing.Size(171, 120);
            this.NotificationMenuContextMenuStrip.Opened += new System.EventHandler(this.NotificationMenuContextMenuStrip_Opened);
            this.NotificationMenuContextMenuStrip.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotificationMenuContextMenuStrip_MouseDoubleClick);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Image = global::Clipboarder.Properties.Resources.Clipboarder_Show;
            this.showToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(167, 6);
            // 
            // clearClipboarderToolStripMenuItem
            // 
            this.clearClipboarderToolStripMenuItem.Image = global::Clipboarder.Properties.Resources.Clipboarder_Clipboarder_clear_Icon;
            this.clearClipboarderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clearClipboarderToolStripMenuItem.Name = "clearClipboarderToolStripMenuItem";
            this.clearClipboarderToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.clearClipboarderToolStripMenuItem.Text = "Clear Clipboarder";
            this.clearClipboarderToolStripMenuItem.Click += new System.EventHandler(this.clearClipboarderToolStripMenuItem_Click);
            // 
            // clearClipboardToolStripMenuItem
            // 
            this.clearClipboardToolStripMenuItem.Image = global::Clipboarder.Properties.Resources.Clipboarder_Clipboard_Clear_Icon;
            this.clearClipboardToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clearClipboardToolStripMenuItem.Name = "clearClipboardToolStripMenuItem";
            this.clearClipboardToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.clearClipboardToolStripMenuItem.Text = "Clear Clipboard";
            this.clearClipboardToolStripMenuItem.Click += new System.EventHandler(this.clearClipboardToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(167, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = global::Clipboarder.Properties.Resources.Clipboarder_Close_Icon;
            this.closeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // collapseExpandButton
            // 
            this.collapseExpandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.collapseExpandButton.BackColor = System.Drawing.Color.Transparent;
            this.collapseExpandButton.Image = global::Clipboarder.Properties.Resources.Clipboarder_Expand_Arrow;
            this.collapseExpandButton.Location = new System.Drawing.Point(600, 48);
            this.collapseExpandButton.Name = "collapseExpandButton";
            this.collapseExpandButton.Size = new System.Drawing.Size(20, 20);
            this.collapseExpandButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.collapseExpandButton.TabIndex = 1;
            this.collapseExpandButton.TabStop = false;
            this.collapseExpandButton.Visible = false;
            this.collapseExpandButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(111)))), ((int)(((byte)(255)))));
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(111)))), ((int)(((byte)(255)))));
            this.toolStripStatusLabel3.IsLink = true;
            this.toolStripStatusLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.toolStripStatusLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(111)))), ((int)(((byte)(255)))));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(34, 17);
            this.toolStripStatusLabel3.Text = "BETA";
            this.toolStripStatusLabel3.ToolTipText = "Open GitHub Repository";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 371);
            this.Controls.Add(this.collapseExpandButton);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.MainMenuStrip);
            this.Controls.Add(this.MainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MinimumSize = new System.Drawing.Size(549, 381);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clipboarder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textDataGrid)).EndInit();
            this.mainGridContextMenu.ResumeLayout(false);
            this.textPage.ResumeLayout(false);
            this.imagePage.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreviewBox)).EndInit();
            this.MainTabControl.ResumeLayout(false);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.NotificationMenuContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.collapseExpandButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        internal System.Windows.Forms.DataGridView textDataGrid;
        private System.Windows.Forms.TabPage textPage;
        private System.Windows.Forms.TabPage imagePage;
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
        private System.Windows.Forms.ContextMenuStrip mainGridContextMenu;
        private System.Windows.Forms.ToolStripMenuItem goToURLToolStripMenuItem;
        private System.Windows.Forms.PictureBox collapseExpandButton;
        private System.Windows.Forms.SplitContainer splitContainer2;
        internal System.Windows.Forms.DataGridView imageDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.PictureBox picturePreviewBox;
        private System.Windows.Forms.Label imagePreviewLabel;
        internal System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripStatusLabel springStatusStripLabel;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.NotifyIcon mainNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip NotificationMenuContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem clearClipboarderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem viewInSyntaxHighlightingToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}