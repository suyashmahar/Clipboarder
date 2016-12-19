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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imageCustomKeysCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imageContentKeysComboBox = new System.Windows.Forms.ComboBox();
            this.imageModifierKeysComboBox3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.imageModifierKeysComboBox2 = new System.Windows.Forms.ComboBox();
            this.imageModifierKeysComboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.imageContentCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.imageShortcutsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textShortcutsNumericUpDown)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageShortcutsNumericUpDown)).BeginInit();
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
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(288, 214);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(280, 188);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Text";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(280, 215);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Image";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.imageCustomKeysCheckBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.imageContentKeysComboBox);
            this.groupBox3.Controls.Add(this.imageModifierKeysComboBox3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.imageModifierKeysComboBox2);
            this.groupBox3.Controls.Add(this.imageModifierKeysComboBox1);
            this.groupBox3.Location = new System.Drawing.Point(5, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 106);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Custom Keys";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Current Keys : ";
            // 
            // imageCustomKeysCheckBox
            // 
            this.imageCustomKeysCheckBox.AutoSize = true;
            this.imageCustomKeysCheckBox.Location = new System.Drawing.Point(14, 19);
            this.imageCustomKeysCheckBox.Name = "imageCustomKeysCheckBox";
            this.imageCustomKeysCheckBox.Size = new System.Drawing.Size(108, 17);
            this.imageCustomKeysCheckBox.TabIndex = 0;
            this.imageCustomKeysCheckBox.Text = "Use Default Keys";
            this.imageCustomKeysCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ctrl + Shift + NumKeys";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "+";
            // 
            // imageContentKeysComboBox
            // 
            this.imageContentKeysComboBox.FormattingEnabled = true;
            this.imageContentKeysComboBox.Location = new System.Drawing.Point(266, 67);
            this.imageContentKeysComboBox.Name = "imageContentKeysComboBox";
            this.imageContentKeysComboBox.Size = new System.Drawing.Size(59, 21);
            this.imageContentKeysComboBox.TabIndex = 4;
            // 
            // imageModifierKeysComboBox3
            // 
            this.imageModifierKeysComboBox3.FormattingEnabled = true;
            this.imageModifierKeysComboBox3.Location = new System.Drawing.Point(182, 67);
            this.imageModifierKeysComboBox3.Name = "imageModifierKeysComboBox3";
            this.imageModifierKeysComboBox3.Size = new System.Drawing.Size(59, 21);
            this.imageModifierKeysComboBox3.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "+";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "+";
            // 
            // imageModifierKeysComboBox2
            // 
            this.imageModifierKeysComboBox2.FormattingEnabled = true;
            this.imageModifierKeysComboBox2.Location = new System.Drawing.Point(98, 67);
            this.imageModifierKeysComboBox2.Name = "imageModifierKeysComboBox2";
            this.imageModifierKeysComboBox2.Size = new System.Drawing.Size(59, 21);
            this.imageModifierKeysComboBox2.TabIndex = 2;
            // 
            // imageModifierKeysComboBox1
            // 
            this.imageModifierKeysComboBox1.FormattingEnabled = true;
            this.imageModifierKeysComboBox1.Location = new System.Drawing.Point(14, 67);
            this.imageModifierKeysComboBox1.Name = "imageModifierKeysComboBox1";
            this.imageModifierKeysComboBox1.Size = new System.Drawing.Size(59, 21);
            this.imageModifierKeysComboBox1.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.imageContentCheckBox);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.imageShortcutsNumericUpDown);
            this.groupBox4.Location = new System.Drawing.Point(6, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(341, 89);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Short-Cuts";
            // 
            // imageContentCheckBox
            // 
            this.imageContentCheckBox.AutoSize = true;
            this.imageContentCheckBox.Location = new System.Drawing.Point(9, 29);
            this.imageContentCheckBox.Name = "imageContentCheckBox";
            this.imageContentCheckBox.Size = new System.Drawing.Size(105, 17);
            this.imageContentCheckBox.TabIndex = 0;
            this.imageContentCheckBox.Text = "Enable shortcuts";
            this.imageContentCheckBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Total number of shortcuts ";
            // 
            // imageShortcutsNumericUpDown
            // 
            this.imageShortcutsNumericUpDown.Location = new System.Drawing.Point(142, 53);
            this.imageShortcutsNumericUpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.imageShortcutsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.imageShortcutsNumericUpDown.Name = "imageShortcutsNumericUpDown";
            this.imageShortcutsNumericUpDown.Size = new System.Drawing.Size(47, 20);
            this.imageShortcutsNumericUpDown.TabIndex = 0;
            this.imageShortcutsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textShortcutsNumericUpDown)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageShortcutsNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox textContentCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown textShortcutsNumericUpDown;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox imageContentCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown imageShortcutsNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label textKeyDisplayLabel;
        private System.Windows.Forms.Label plusLabel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox imageCustomKeysCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox imageContentKeysComboBox;
        private System.Windows.Forms.ComboBox imageModifierKeysComboBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox imageModifierKeysComboBox2;
        private System.Windows.Forms.ComboBox imageModifierKeysComboBox1;
        private System.Windows.Forms.CheckBox textControlKeycheckBox;
        private System.Windows.Forms.CheckBox textAltKeycheckBox;
        private System.Windows.Forms.CheckBox textShiftKeycheckBox;
        private System.Windows.Forms.Label label2;
    }
}