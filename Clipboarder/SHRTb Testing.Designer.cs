namespace Clipboarder {
    partial class SHRTb_Testing {
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
            this.syntaxHighlightingTextBox1 = new Clipboarder.SyntaxHighlightingTextBox();
            this.SuspendLayout();
            // 
            // syntaxHighlightingTextBox1
            // 
            this.syntaxHighlightingTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.syntaxHighlightingTextBox1.EnableSyntaxHiglighting = false;
            this.syntaxHighlightingTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.syntaxHighlightingTextBox1.Location = new System.Drawing.Point(0, 0);
            this.syntaxHighlightingTextBox1.Name = "syntaxHighlightingTextBox1";
            this.syntaxHighlightingTextBox1.Size = new System.Drawing.Size(563, 443);
            this.syntaxHighlightingTextBox1.TabIndex = 1;
            this.syntaxHighlightingTextBox1.Text = "";
            // 
            // SHRTb_Testing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 443);
            this.Controls.Add(this.syntaxHighlightingTextBox1);
            this.Name = "SHRTb_Testing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SHRTb_Testing";
            this.Load += new System.EventHandler(this.SHRTb_Testing_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SyntaxHighlightingTextBox syntaxHighlightingTextBox1;
    }
}