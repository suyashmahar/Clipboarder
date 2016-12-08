using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clipboarder.Extension {
    public class ImageConversion {

        /// <summary>
        /// Converts Image to Base64 string
        /// </summary>
        /// <param name="image">A System.Drawing.Image object</param>
        /// <param name="format">Format for saving image to memory stream</param>
        /// <returns>Base64 of an image</returns>
        public static string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format) {
            using (MemoryStream ms = new MemoryStream()) {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        /// <summary>
        /// Returns Image from a base64 string
        /// </summary>
        /// <param name="base64String">string containing just base64 of image without prefixes</param>
        /// <returns>Image</returns>
        public static Image Base64ToImage(string base64String) {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
              imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
    }
}
