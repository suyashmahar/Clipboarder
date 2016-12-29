using System;
using Clipboarder.SyntaxHighlighting;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}
