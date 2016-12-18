using System.Drawing;

namespace Clipboarder {

    public class Content {
        public int index;
        public string time;
    }

    public class TextContent : Content{
        public string text;
        
        public TextContent() {
            
        }

        public TextContent(int index, string text, string time) {
            this.index = index;
            this.text = text;
            this.time = time;
        }
    }

    public class ImageContent : Content {
        public Image image;

        public ImageContent() {

        }

        public ImageContent(int index, Image image, string time) {
            this.index = index;
            this.image = image;
            this.time = time;
        }
    }
}
