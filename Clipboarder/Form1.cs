using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clipboarder.Extension;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Clipboarder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            if (true) {
                string a = "iVBORw0KGgoAAAANSUhEUgAAAEQAAAAiCAAAAADD1SApAAAA5UlEQVR4AYXUMW6EQBAF0TpSS4T//vda2dO0GgiKwDuItwRl7ef6v5L+qNSc+5EL+jZpkTZJm3LBkBxRx2TI5YLzriQ5j//O9+0hLmgz4hoz71BB56kRc552KtjFpvqjnQtWsdHJbueCVWx9Z7dzwSpWQ2q3c8GudMN6tHPBo1hV/9ntXLCK7SsZ44Jd7CXqGBdMsQ+ZdipYldYvf7dzwfwHWqRNDXXBa2Eq9dkgFfgGucA3yAW+QS7wDXKBb5ALfINc4BvkAt8gF/gGucA3yAW+QS7wDXKBb5ALfINc4BvkAt8gFz+Bp+mo8f2VxAAAAABJRU5ErkJggg==";
                pictureBox1.Image = ImageConversion.Base64ToImage(a);
                Debug.WriteLine(ImageConversion.ImageToBase64(Clipboard.GetImage(), System.Drawing.Imaging.ImageFormat.Png));
            }
        }

    }
}
