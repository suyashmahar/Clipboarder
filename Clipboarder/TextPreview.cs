using System;
using Clipboarder.SyntaxHighlighting;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clipboarder {
    public partial class TextPreview : Form {
        string initText;

        public TextPreview(string initText) {
            InitializeComponent();
            this.initText = initText;
        }

        private void TextPreview_Load(Object sender, EventArgs e) {
            // Following code populates language menu from files present 
            // in SHLs folder in application directory
            List<string> languagesList = Languages.GetLanguages();
            languagesList.ForEach(language => {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Text = language;
                item.Click += new EventHandler(languageMenuItem_Click);
                languageToolStripMenuItem.DropDownItems.Insert(languageToolStripMenuItem.DropDownItems.Count, item);
            });
            syntaxHighlightingTextBox.Text = initText;

            // Sets font preferences from settings
            syntaxHighlightingTextBox.Font = Properties.Settings.Default.syntaxHighlightingFont;
        }

        private void languageMenuItem_Click(object sender, EventArgs e) {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            string args = menuItem.Text;

            // Tries to compile corresponding XML file and enable syntax highlighting
            try {
                Compile(args);
            } catch (Exception) {
                MessageBox.Show(@"Unable to compile keywords from language file,
define XML file similar to sample java.xml", "Clipboarder - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Compile(string args) {
            List<ColoredKeyword> list = Languages.CompileFromFile(args);
            list.ForEach(coloredKeyword => {
                syntaxHighlightingTextBox.AddKeyword(coloredKeyword.keyword, coloredKeyword.color);
            });
            syntaxHighlightingTextBox.EnableSyntaxHiglighting = true;
            syntaxHighlightingTextBox.Text = syntaxHighlightingTextBox.Text;
        }

        private void helpToolStripMenuItem_Click(Object sender, EventArgs e) {
            MessageBox.Show(@"
Clipboarder uses XML files to highlight syntax of different languages

XML files used by Clipboarder for syntax highlighting are located at
 %ApplicationStartupPath%\SHLs

* Coloring of text in Clipboarder follows same order as they are defined
  in XML file.

* Description for each language should be in a different file with file
  name same as that of the language.

* Clipboarder only searches for XML files at %ApplicationStartupPath%\SHLs

", "Clipboarder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

