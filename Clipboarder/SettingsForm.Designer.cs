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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.shortcutsEnabledCheckbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shortcutsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.okButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shortcutsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.shortcutsEnabledCheckbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.shortcutsNumericUpDown);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Short-Cuts";
            // 
            // shortcutsEnabledCheckbox
            // 
            this.shortcutsEnabledCheckbox.AutoSize = true;
            this.shortcutsEnabledCheckbox.Location = new System.Drawing.Point(9, 29);
            this.shortcutsEnabledCheckbox.Name = "shortcutsEnabledCheckbox";
            this.shortcutsEnabledCheckbox.Size = new System.Drawing.Size(105, 17);
            this.shortcutsEnabledCheckbox.TabIndex = 2;
            this.shortcutsEnabledCheckbox.Text = "Enable shortcuts";
            this.shortcutsEnabledCheckbox.UseVisualStyleBackColor = true;
            this.shortcutsEnabledCheckbox.CheckedChanged += new System.EventHandler(this.shortcutsEnabledCheckbox_CheckedChanged);
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
            // shortcutsNumericUpDown
            // 
            this.shortcutsNumericUpDown.Location = new System.Drawing.Point(142, 53);
            this.shortcutsNumericUpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.shortcutsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shortcutsNumericUpDown.Name = "shortcutsNumericUpDown";
            this.shortcutsNumericUpDown.Size = new System.Drawing.Size(47, 20);
            this.shortcutsNumericUpDown.TabIndex = 0;
            this.shortcutsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(62, 113);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(143, 113);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 148);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shortcutsNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown shortcutsNumericUpDown;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.CheckBox shortcutsEnabledCheckbox;
    }
}