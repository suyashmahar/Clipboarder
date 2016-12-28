using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clipboarder {
    public partial class SHRTb_Testing : Form {
        public SHRTb_Testing() {
            InitializeComponent();
        }

        private void SHRTb_Testing_Load(Object sender, EventArgs e) {
            List<string> blueColored = new List<string> {
                @"public\b",
                @"static\b",
                @"void\b",
                @"int\b",
                @"import\b",
                @"if\b",
                @"return\b",
                @"for\b",
                @"switch\b",
                @"default\b",
                @"class\b",
                @"short\b",
                @"byte\b",
                @"long\b",
                @"case:\b",
                @"[\s\(\[][A-Z]\w+",
                @"Integer\.?",
                @"extends\b",
                @"implements\b",
                @"@Overrides\b",
                @"super",
                @"\bthis\s",
                @"new\n"
            };
            List<string> greenColored = new List<string> {
                @"//.+",
                @"/\*.+\*/",
                @"//",
            };
            List<string> redColored = new List<string> {
                "\".+\""
            };
            syntaxHighlightingTextBox1.AddKeywords(blueColored, Color.Blue);
            syntaxHighlightingTextBox1.AddKeywords(greenColored, Color.Green);
            syntaxHighlightingTextBox1.AddKeywords(redColored, Color.Maroon);
            syntaxHighlightingTextBox1.EnableSyntaxHiglighting = true;
        }

        private void button1_Click(Object sender, EventArgs e) {
            syntaxHighlightingTextBox1.Text =
                @"
import java.util.*;

public class newTesting{
    public static void main(String args[]){
        System.out.println(hcf(10, 45));
        System.out.println" + "(\"This is a string\");" + "\n" + 
        @"System.out.println(hcf(10, 45));
    }
    pubci

	static int hcf(int a, int b){
		if(!(b%a==0)) {
		
			int temp = a;
			a=b%a;
			b=temp;
			hcf(a,b);
		}
         return a;
	}
}
//This is a comment %^&*()
/* This is a commment too! #$%^&*()*/
";
        }
         
        private void button2_Click(Object sender, EventArgs e) {
            syntaxHighlightingTextBox1.compile();
        }
    }
}
