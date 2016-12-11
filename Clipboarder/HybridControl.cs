using System.Drawing;
using System.Windows.Forms;

namespace Clipboarder {
    public partial class HybridControl : UserControl {
        bool isHostingImage = false;
        Image image = null;
        string text = "Error";

        public HybridControl(){
            InitializeComponent();
        }

        public bool IsHostingImage {
            get {
                return isHostingImage;
            }

            set {
                isHostingImage = value;
            }
        }

        public Image Image {
            get {
                return ContentLabel.Image;
            }

            set {
                ContentLabel.Image = value;
            }
        }
        
        public string Text {
            get {
                return ContentLabel.Text;
            }
            set {
                ContentLabel.Text = value;
            }


        }
    }
}
