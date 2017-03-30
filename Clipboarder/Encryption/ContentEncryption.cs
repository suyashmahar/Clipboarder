using System;
using Clipboarder.Encryption;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clipboarder.Extension;
using System.Drawing.Imaging;

namespace Clipboarder {
    class ContentEncryption {
        public static TextContent DecryptTextContent(EncryptedTextContent encryptedContent, string password) {
            TextContent contentToReturn = new TextContent();
            contentToReturn.index = encryptedContent.index;
            contentToReturn.text = StringCipher.Decrypt(encryptedContent.encryptedText, password);
            contentToReturn.time = StringCipher.Decrypt(encryptedContent.time, password);
            return contentToReturn;
        }

        public static ImageContent DecryptImageContent(EncryptedImageContent encryptedContent, string password) {
            ImageContent contentToReturn = new ImageContent();
            contentToReturn.index = encryptedContent.index;
            contentToReturn.image = 
                ImageConversion.Base64ToImage(StringCipher.Decrypt(encryptedContent.encryptedImage, password));
            contentToReturn.time = StringCipher.Decrypt(encryptedContent.time, password);
            return contentToReturn;
        }

        public static EncryptedTextContent EncryptTextContent(TextContent unencryptedContent, string password) {
            EncryptedTextContent contentToReturn = new EncryptedTextContent();
            contentToReturn.index = unencryptedContent.index;
            contentToReturn.encryptedText = StringCipher.Encrypt(unencryptedContent.text, password);
            contentToReturn.time = StringCipher.Encrypt(unencryptedContent.time, password);
            return contentToReturn;
        }

        public static EncryptedImageContent EncryptImageContent(ImageContent unencryptedContent, string password) {
            EncryptedImageContent contentToReturn = new EncryptedImageContent();
            contentToReturn.index = unencryptedContent.index;
            contentToReturn.encryptedImage = 
                StringCipher.Encrypt(ImageConversion.ImageToBase64(unencryptedContent.image, ImageFormat.Png), password);
            contentToReturn.time = StringCipher.Encrypt(unencryptedContent.time, password);
            return contentToReturn;
        }
    }
}
