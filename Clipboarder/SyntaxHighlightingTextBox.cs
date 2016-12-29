using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Clipboarder {
    class SyntaxHighlightingTextBox : RichTextBox{
        List<ColoredKeyword> syntaxList = new List<ColoredKeyword>();
        private bool isSyntaxHighlightingEnabled;

        public void BeginUpdate() {
            SendMessage(this.Handle, WM_SETREDRAW, (IntPtr)0, IntPtr.Zero);
        }
        public void EndUpdate() {
            SendMessage(this.Handle, WM_SETREDRAW, (IntPtr)1, IntPtr.Zero);
            this.Invalidate();
        }
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        private const int WM_SETREDRAW = 0x0b;

        public Boolean EnableSyntaxHiglighting {
            get {
                return isSyntaxHighlightingEnabled;
            }

            set {
                isSyntaxHighlightingEnabled = value;
            }
        }
        #region Constructor
        public SyntaxHighlightingTextBox() {

        }

        public SyntaxHighlightingTextBox(List<ColoredKeyword> syntaxList) {
            this.syntaxList = syntaxList;
        }
        #endregion


        public Int32 AddKeyword(string keyword, Color color) {
            try {
                Regex regex = new Regex(keyword);
                syntaxList.Add(new ColoredKeyword(keyword, color));
                Debug.WriteLine(0);
                return 0;
            } catch (ArgumentNullException) {
                Debug.WriteLine(1);
                return 1;
            } catch (ArgumentException) {
                Debug.WriteLine(2);
                return 2;
            } catch (Exception) {
                Debug.WriteLine(3);
                return 3;
            }
        }

        public Int32 AddKeywords(List<string> keywords, Color color) {
            if (keywords.Count == 0) return 1;

            foreach (string keyword in keywords) {
                try {
                    Regex regex = new Regex(keyword);
                    syntaxList.Add(new ColoredKeyword(keyword, color));
                } catch (ArgumentNullException) {
                    Debug.WriteLine(1);
                    return 1;
                } catch (ArgumentException) {
                    Debug.WriteLine(2);
                    return 2;
                } catch (Exception) {
                    Debug.WriteLine(3);
                    return 3;
                }
            }

            return 0;
        }

        protected override void OnTextChanged(EventArgs e) {
            compile();
            base.OnTextChanged(e);
        }

        public void compile() {
            if (EnableSyntaxHiglighting) {
                BeginUpdate();
                for (int i = 0; i < syntaxList.Count; i++) {
                    Regex regex = new Regex(syntaxList.ElementAt(i).keyword);
                    MatchCollection matches = regex.Matches(this.Text);
                    foreach (Match match in matches) {
                        Color initColor = this.ForeColor;

                        int initPosition = this.SelectionStart;
                        this.SelectionStart = match.Index;
                        this.SelectionLength = match.Length;
                        this.SelectionColor = syntaxList.ElementAt(i).color;
                        this.Select(initPosition, initPosition);
                        this.DeselectAll();
                        this.ForeColor = initColor;
                    }
                }
                EndUpdate();
            }
            // // 
        }
    }
}
