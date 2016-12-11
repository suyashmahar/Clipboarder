using System;

namespace Clipboarder {
    partial class HybridControl {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ContentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ContentLabel
            // 
            this.ContentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentLabel.Location = new System.Drawing.Point(0, 0);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(408, 49);
            this.ContentLabel.TabIndex = 0;
            // 
            // HybridControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContentLabel);
            this.Name = "HybridControl";
            this.Size = new System.Drawing.Size(408, 49);
            this.Load += new System.EventHandler(this.HybridControl_Load);
            this.ResumeLayout(false);

        }

        private void HybridControl_Load(object sender, EventArgs e) {
            new HybridControl();
        }

        #endregion

        private System.Windows.Forms.Label ContentLabel;
    }
}
