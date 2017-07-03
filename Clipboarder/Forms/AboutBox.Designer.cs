namespace Clipboarder {
    partial class AboutBox {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.viewSourceCodeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.reportIssueLinkLabel = new System.Windows.Forms.LinkLabel();
            this.visitWebsiteLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.closeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Clipboarder.Properties.Resources.Clipboard_WF_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.BackColor = System.Drawing.Color.White;
            this.productNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.Location = new System.Drawing.Point(213, 19);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(223, 37);
            this.productNameLabel.TabIndex = 1;
            this.productNameLabel.Text = "Product Name";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.BackColor = System.Drawing.Color.White;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(216, 56);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(106, 20);
            this.versionLabel.TabIndex = 2;
            this.versionLabel.Text = "Version Label";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(217, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "This product and its source code is licensed under very permissive MIT license";
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.BackColor = System.Drawing.Color.White;
            this.copyrightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.copyrightLabel.Location = new System.Drawing.Point(217, 87);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(69, 13);
            this.copyrightLabel.TabIndex = 4;
            this.copyrightLabel.Text = "coyright label";
            // 
            // viewSourceCodeLinkLabel
            // 
            this.viewSourceCodeLinkLabel.AutoSize = true;
            this.viewSourceCodeLinkLabel.BackColor = System.Drawing.Color.White;
            this.viewSourceCodeLinkLabel.Location = new System.Drawing.Point(415, 142);
            this.viewSourceCodeLinkLabel.Name = "viewSourceCodeLinkLabel";
            this.viewSourceCodeLinkLabel.Size = new System.Drawing.Size(134, 13);
            this.viewSourceCodeLinkLabel.TabIndex = 5;
            this.viewSourceCodeLinkLabel.TabStop = true;
            this.viewSourceCodeLinkLabel.Text = "View source code (GitHub)";
            this.viewSourceCodeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewSourceCodeLinkLabel_LinkClicked);
            // 
            // reportIssueLinkLabel
            // 
            this.reportIssueLinkLabel.AutoSize = true;
            this.reportIssueLinkLabel.BackColor = System.Drawing.Color.White;
            this.reportIssueLinkLabel.Location = new System.Drawing.Point(313, 142);
            this.reportIssueLinkLabel.Name = "reportIssueLinkLabel";
            this.reportIssueLinkLabel.Size = new System.Drawing.Size(81, 13);
            this.reportIssueLinkLabel.TabIndex = 6;
            this.reportIssueLinkLabel.TabStop = true;
            this.reportIssueLinkLabel.Text = "Report an issue";
            this.reportIssueLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reportIssueLinkLabel_LinkClicked);
            // 
            // visitWebsiteLinkLabel
            // 
            this.visitWebsiteLinkLabel.AutoSize = true;
            this.visitWebsiteLinkLabel.BackColor = System.Drawing.Color.White;
            this.visitWebsiteLinkLabel.Location = new System.Drawing.Point(227, 142);
            this.visitWebsiteLinkLabel.Name = "visitWebsiteLinkLabel";
            this.visitWebsiteLinkLabel.Size = new System.Drawing.Size(65, 13);
            this.visitWebsiteLinkLabel.TabIndex = 7;
            this.visitWebsiteLinkLabel.TabStop = true;
            this.visitWebsiteLinkLabel.Text = "Visit website";
            this.visitWebsiteLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.visitWebsiteLinkLabel_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(298, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(9, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "|";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(400, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(9, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "|";
            // 
            // closeLabel
            // 
            this.closeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeLabel.BackColor = System.Drawing.Color.Red;
            this.closeLabel.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeLabel.ForeColor = System.Drawing.Color.White;
            this.closeLabel.Location = new System.Drawing.Point(545, 0);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(65, 29);
            this.closeLabel.TabIndex = 10;
            this.closeLabel.Text = "x";
            this.closeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closeLabel.Click += new System.EventHandler(this.Label5_Click);
            this.closeLabel.MouseEnter += new System.EventHandler(this.closeLabel_MouseEnter);
            this.closeLabel.MouseLeave += new System.EventHandler(this.closeLabel_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.productNameLabel);
            this.panel1.Controls.Add(this.versionLabel);
            this.panel1.Controls.Add(this.copyrightLabel);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 200);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(610, 220);
            this.Controls.Add(this.closeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.visitWebsiteLinkLabel);
            this.Controls.Add(this.reportIssueLinkLabel);
            this.Controls.Add(this.viewSourceCodeLinkLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(111)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.LinkLabel viewSourceCodeLinkLabel;
        private System.Windows.Forms.LinkLabel reportIssueLinkLabel;
        private System.Windows.Forms.LinkLabel visitWebsiteLinkLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label closeLabel;
    }
}
