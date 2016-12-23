namespace Clipboarder {
    partial class SettingsForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.okButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.textSettingsPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textAltKeycheckBox = new System.Windows.Forms.CheckBox();
            this.textShiftKeycheckBox = new System.Windows.Forms.CheckBox();
            this.textControlKeycheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textKeyDisplayLabel = new System.Windows.Forms.Label();
            this.plusLabel3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textContentCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textShortcutsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.generalSettingsPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RegexLinkLabel = new System.Windows.Forms.LinkLabel();
            this.CustomRegexCheckBox = new System.Windows.Forms.CheckBox();
            this.URLCheckBox = new System.Windows.Forms.CheckBox();
            this.textSettingsPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textShortcutsNumericUpDown)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.generalSettingsPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(125, 223);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(206, 223);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // textSettingsPage
            // 
            this.textSettingsPage.Controls.Add(this.groupBox2);
            this.textSettingsPage.Controls.Add(this.groupBox1);
            this.textSettingsPage.Location = new System.Drawing.Point(4, 22);
            this.textSettingsPage.Name = "textSettingsPage";
            this.textSettingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.textSettingsPage.Size = new System.Drawing.Size(280, 188);
            this.textSettingsPage.TabIndex = 0;
            this.textSettingsPage.Text = "Text";
            this.textSettingsPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textAltKeycheckBox);
            this.groupBox2.Controls.Add(this.textShiftKeycheckBox);
            this.groupBox2.Controls.Add(this.textControlKeycheckBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textKeyDisplayLabel);
            this.groupBox2.Controls.Add(this.plusLabel3);
            this.groupBox2.Location = new System.Drawing.Point(6, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 83);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Custom Keys";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Number Keys";
            // 
            // textAltKeycheckBox
            // 
            this.textAltKeycheckBox.AutoSize = true;
            this.textAltKeycheckBox.Location = new System.Drawing.Point(130, 53);
            this.textAltKeycheckBox.Name = "textAltKeycheckBox";
            this.textAltKeycheckBox.Size = new System.Drawing.Size(38, 17);
            this.textAltKeycheckBox.TabIndex = 22;
            this.textAltKeycheckBox.Text = "Alt";
            this.textAltKeycheckBox.UseVisualStyleBackColor = true;
            this.textAltKeycheckBox.CheckStateChanged += new System.EventHandler(this.textModifierKeycheckBox_CheckStateChanged);
            // 
            // textShiftKeycheckBox
            // 
            this.textShiftKeycheckBox.AutoSize = true;
            this.textShiftKeycheckBox.Location = new System.Drawing.Point(75, 53);
            this.textShiftKeycheckBox.Name = "textShiftKeycheckBox";
            this.textShiftKeycheckBox.Size = new System.Drawing.Size(47, 17);
            this.textShiftKeycheckBox.TabIndex = 21;
            this.textShiftKeycheckBox.Text = "Shift";
            this.textShiftKeycheckBox.UseVisualStyleBackColor = true;
            this.textShiftKeycheckBox.CheckStateChanged += new System.EventHandler(this.textModifierKeycheckBox_CheckStateChanged);
            // 
            // textControlKeycheckBox
            // 
            this.textControlKeycheckBox.AutoSize = true;
            this.textControlKeycheckBox.Location = new System.Drawing.Point(14, 53);
            this.textControlKeycheckBox.Name = "textControlKeycheckBox";
            this.textControlKeycheckBox.Size = new System.Drawing.Size(59, 17);
            this.textControlKeycheckBox.TabIndex = 20;
            this.textControlKeycheckBox.Text = "Control";
            this.textControlKeycheckBox.UseVisualStyleBackColor = true;
            this.textControlKeycheckBox.CheckStateChanged += new System.EventHandler(this.textModifierKeycheckBox_CheckStateChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Current Keys : ";
            // 
            // textKeyDisplayLabel
            // 
            this.textKeyDisplayLabel.AutoSize = true;
            this.textKeyDisplayLabel.Location = new System.Drawing.Point(120, 25);
            this.textKeyDisplayLabel.Name = "textKeyDisplayLabel";
            this.textKeyDisplayLabel.Size = new System.Drawing.Size(112, 13);
            this.textKeyDisplayLabel.TabIndex = 17;
            this.textKeyDisplayLabel.Text = "Ctrl + Shift + NumKeys";
            // 
            // plusLabel3
            // 
            this.plusLabel3.AutoSize = true;
            this.plusLabel3.Location = new System.Drawing.Point(166, 54);
            this.plusLabel3.Name = "plusLabel3";
            this.plusLabel3.Size = new System.Drawing.Size(13, 13);
            this.plusLabel3.TabIndex = 4;
            this.plusLabel3.Text = "+";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textContentCheckBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textShortcutsNumericUpDown);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 89);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Short-Cuts";
            // 
            // textContentCheckBox
            // 
            this.textContentCheckBox.AutoSize = true;
            this.textContentCheckBox.Location = new System.Drawing.Point(9, 29);
            this.textContentCheckBox.Name = "textContentCheckBox";
            this.textContentCheckBox.Size = new System.Drawing.Size(105, 17);
            this.textContentCheckBox.TabIndex = 0;
            this.textContentCheckBox.Text = "Enable shortcuts";
            this.textContentCheckBox.UseVisualStyleBackColor = true;
            this.textContentCheckBox.CheckedChanged += new System.EventHandler(this.textContentCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total number of shortcuts ";
            // 
            // textShortcutsNumericUpDown
            // 
            this.textShortcutsNumericUpDown.Location = new System.Drawing.Point(142, 53);
            this.textShortcutsNumericUpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.textShortcutsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textShortcutsNumericUpDown.Name = "textShortcutsNumericUpDown";
            this.textShortcutsNumericUpDown.Size = new System.Drawing.Size(47, 20);
            this.textShortcutsNumericUpDown.TabIndex = 0;
            this.textShortcutsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.generalSettingsPage);
            this.tabControl1.Controls.Add(this.textSettingsPage);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(288, 214);
            this.tabControl1.TabIndex = 0;
            // 
            // generalSettingsPage
            // 
            this.generalSettingsPage.Controls.Add(this.groupBox3);
            this.generalSettingsPage.Location = new System.Drawing.Point(4, 22);
            this.generalSettingsPage.Name = "generalSettingsPage";
            this.generalSettingsPage.Size = new System.Drawing.Size(280, 188);
            this.generalSettingsPage.TabIndex = 1;
            this.generalSettingsPage.Text = "General";
            this.generalSettingsPage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.RegexLinkLabel);
            this.groupBox3.Controls.Add(this.CustomRegexCheckBox);
            this.groupBox3.Controls.Add(this.URLCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(6, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 69);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "URL Identification";
            // 
            // RegexLinkLabel
            // 
            this.RegexLinkLabel.AutoSize = true;
            this.RegexLinkLabel.Enabled = false;
            this.RegexLinkLabel.Location = new System.Drawing.Point(121, 43);
            this.RegexLinkLabel.Name = "RegexLinkLabel";
            this.RegexLinkLabel.Size = new System.Drawing.Size(98, 13);
            this.RegexLinkLabel.TabIndex = 2;
            this.RegexLinkLabel.TabStop = true;
            this.RegexLinkLabel.Text = "Enter custom regex";
            this.RegexLinkLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.RegexLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // CustomRegexCheckBox
            // 
            this.CustomRegexCheckBox.AutoSize = true;
            this.CustomRegexCheckBox.Enabled = false;
            this.CustomRegexCheckBox.Location = new System.Drawing.Point(6, 42);
            this.CustomRegexCheckBox.Name = "CustomRegexCheckBox";
            this.CustomRegexCheckBox.Size = new System.Drawing.Size(111, 17);
            this.CustomRegexCheckBox.TabIndex = 1;
            this.CustomRegexCheckBox.Text = "Use custom regex";
            this.CustomRegexCheckBox.UseVisualStyleBackColor = true;
            this.CustomRegexCheckBox.CheckedChanged += new System.EventHandler(this.CustomRegexCheckBox_CheckedChanged);
            // 
            // URLCheckBox
            // 
            this.URLCheckBox.AutoSize = true;
            this.URLCheckBox.Location = new System.Drawing.Point(6, 19);
            this.URLCheckBox.Name = "URLCheckBox";
            this.URLCheckBox.Size = new System.Drawing.Size(156, 17);
            this.URLCheckBox.TabIndex = 0;
            this.URLCheckBox.Text = "Check text content for URL";
            this.URLCheckBox.UseVisualStyleBackColor = true;
            this.URLCheckBox.CheckedChanged += new System.EventHandler(this.URLCheckBox_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(292, 258);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.closeButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.textSettingsPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textShortcutsNumericUpDown)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.generalSettingsPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TabPage textSettingsPage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox textAltKeycheckBox;
        private System.Windows.Forms.CheckBox textShiftKeycheckBox;
        private System.Windows.Forms.CheckBox textControlKeycheckBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label textKeyDisplayLabel;
        private System.Windows.Forms.Label plusLabel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox textContentCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown textShortcutsNumericUpDown;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage generalSettingsPage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox URLCheckBox;
        private System.Windows.Forms.CheckBox CustomRegexCheckBox;
        private System.Windows.Forms.LinkLabel RegexLinkLabel;
    }
}