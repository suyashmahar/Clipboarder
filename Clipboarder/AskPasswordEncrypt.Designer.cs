namespace Clipboarder {
    partial class AskPasswordEncrypt {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.warningSign = new System.Windows.Forms.PictureBox();
            this.passwordStrengthBar = new System.Windows.Forms.ProgressBar();
            this.passwordReEnterBox = new PasswordTextBoxControl.PasswordTextBox();
            this.passwordBox = new PasswordTextBoxControl.PasswordTextBox();
            this.mainTooltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.warningSign)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a password ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Renter password ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password for securing content";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(227, 108);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Enabled = false;
            this.okButton.Location = new System.Drawing.Point(146, 108);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // warningSign
            // 
            this.warningSign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.warningSign.Image = global::Clipboarder.Properties.Resources.Clipboarder_Warning_Icon;
            this.warningSign.Location = new System.Drawing.Point(308, 72);
            this.warningSign.MaximumSize = new System.Drawing.Size(20, 20);
            this.warningSign.MinimumSize = new System.Drawing.Size(20, 20);
            this.warningSign.Name = "warningSign";
            this.warningSign.Size = new System.Drawing.Size(20, 20);
            this.warningSign.TabIndex = 5;
            this.warningSign.TabStop = false;
            this.mainTooltip.SetToolTip(this.warningSign, "Passwords do not match with each other");
            this.warningSign.Visible = false;
            // 
            // passwordStrengthBar
            // 
            this.passwordStrengthBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordStrengthBar.Location = new System.Drawing.Point(108, 63);
            this.passwordStrengthBar.Margin = new System.Windows.Forms.Padding(0);
            this.passwordStrengthBar.Name = "passwordStrengthBar";
            this.passwordStrengthBar.Size = new System.Drawing.Size(194, 2);
            this.passwordStrengthBar.TabIndex = 6;
            // 
            // passwordReEnterBox
            // 
            this.passwordReEnterBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordReEnterBox.Location = new System.Drawing.Point(108, 72);
            this.passwordReEnterBox.Name = "passwordReEnterBox";
            this.passwordReEnterBox.PasswordCharDelay = 750;
            this.passwordReEnterBox.Size = new System.Drawing.Size(194, 20);
            this.passwordReEnterBox.TabIndex = 1;
            this.passwordReEnterBox.TextChanged += new System.EventHandler(this.passwordReEnterBox_TextChanged_1);
            this.passwordReEnterBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordReEnterBox_KeyDown_1);
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordBox.Location = new System.Drawing.Point(108, 46);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordCharDelay = 750;
            this.passwordBox.Size = new System.Drawing.Size(194, 20);
            this.passwordBox.TabIndex = 0;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged_1);
            // 
            // AskPasswordEncrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 143);
            this.ControlBox = false;
            this.Controls.Add(this.passwordReEnterBox);
            this.Controls.Add(this.passwordStrengthBar);
            this.Controls.Add(this.warningSign);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AskPasswordEncrypt";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clipboarder - Password";
            this.Load += new System.EventHandler(this.AskPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.warningSign)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.PictureBox warningSign;
        private System.Windows.Forms.ProgressBar passwordStrengthBar;
        private PasswordTextBoxControl.PasswordTextBox passwordReEnterBox;
        private PasswordTextBoxControl.PasswordTextBox passwordBox;
        private System.Windows.Forms.ToolTip mainTooltip;
    }
}