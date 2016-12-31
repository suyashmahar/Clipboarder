using System.Drawing;

namespace Clipboarder {
    /// <summary>
    /// Content class and its derivative classes are used to return content
    /// from one method to another
    /// </summary>
    public class Content {
        public int index;
        public string time;
    }

    public class TextContent : Content {
        public string text;

        public TextContent() {

        }

        public TextContent(int index, string text, string time) {
            this.index = index;
            this.text = text;
            this.time = time;
        }
    }

    public class EncryptedTextContent : Content {
        public string encryptedText;

        public EncryptedTextContent() {

        }

        public EncryptedTextContent(int index, string encryptedText, string time) {
            this.index = index;
            this.encryptedText = encryptedText;
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

    public class EncryptedImageContent : Content {
        public string encryptedImage;

        public EncryptedImageContent() {

        }

        public EncryptedImageContent(int index, string encryptedImage, string time) {
            this.index = index;
            this.encryptedImage = encryptedImage;
            this.time = time;
        }
    }
}
