using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Clipboarder {
    partial class AboutBox : Form {
        Color closeLabelColors;
        public AboutBox() {
            InitializeComponent();
            this.Text = String.Format("About {0}", AssemblyTitle);
            this.productNameLabel.Text = AssemblyProduct;
            this.versionLabel.Text = String.Format("Version {0}", AssemblyVersion);
            this.copyrightLabel.Text = AssemblyCopyright;
            //this.labelCompanyName.Text = AssemblyCompany;
            //this.textBoxDescription.Text = AssemblyDescription;
            this.closeLabelColors = this.closeLabel.ForeColor;
        }
        
        #region Assembly Attribute Accessors

        public string AssemblyTitle {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0) {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "") {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion {
            get {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0) {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0) {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0) {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0) {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        #region closeLabelMouseReaction
        private void Label5_Click(object sender, EventArgs e) {
            this.Close();
        }

        // Darkens forecolor on mouse enter
        private void closeLabel_MouseEnter(object sender, EventArgs e) {
            closeLabel.ForeColor 
                = Color.FromArgb(closeLabel.ForeColor.A, (closeLabel.ForeColor.R + 0x10) % 0xff, 
                                (closeLabel.ForeColor.G + 0x10) % 0xff, (closeLabel.ForeColor.B + 0x10) % 0xff);
        }

        // restore forecolor on mouse leave
        private void closeLabel_MouseLeave(object sender, EventArgs e) {
            closeLabel.ForeColor = closeLabelColors;
        }
        #endregion

        private void visitWebsiteLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("http://suyashmahar.me/Clipboarder");
        }

        private void reportIssueLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("https://github.com/suyashmahar/clipboarder/issues");
        }

        private void viewSourceCodeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("https://github.com/suyashmahar/clipboarder/");
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }
    }
}
