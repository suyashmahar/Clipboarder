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
            List<string> languagesList =  Languages.GetLanguages();
            languagesList.ForEach(language => {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Text = language;
                item.Click += new EventHandler(someHistoryMenuItem_Click);
                languageToolStripMenuItem.DropDownItems.Insert(languageToolStripMenuItem.DropDownItems.Count, item);
            });
            syntaxHighlightingTextBox.Text = initText;

            // Sets font preferences from settings
            syntaxHighlightingTextBox.Font = Properties.Settings.Default.syntaxHighlightingFont;
        }

        private void someHistoryMenuItem_Click(object sender, EventArgs e) {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            string args = menuItem.Text;

            Compile(args);
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
Clipboarder uses SHL files to highlight syntax of different languages
*.shl files are ASCII UTF-8 files containing keywords and thier color

Shl files for Clipboarder are located at %ApplicationPath%\SHLs

* Coloring of text in Clipboarder follows same order as they are defined
in shl file.

* Description for each language should be a different file with file name
same as that of the language.

* Clipboarder only searches for shl files at %ApplicationPath%\SHLs

", "Clipboarder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

