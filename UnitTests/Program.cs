using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clipboarder.Encryption;
using System.Drawing;
using System.IO;
using Clipboarder.Extension;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;

namespace UnitTests {
    class Program {
        [STAThread]
        static void Main(string[] args) {
            Console.WriteLine("Unit Tests for Clipboarder v0.1b");
            Console.WriteLine("Starting Tests...");
            ImageConversionTests();
        }

        static void HashingTests() {
            Console.WriteLine();
            Console.WriteLine("Starting HashingTest...");
            Stopwatch newStopWatch = new Stopwatch();
            
            for (int i = 8; i < 16; i++) {
                newStopWatch.Start();
                string passwordHashed = BCrypt.HashPassword("Th1$ 1& @ p@$$w0rd", BCrypt.GenerateSalt(i));
                newStopWatch.Stop();
                Console.WriteLine(String.Format("Time elapsed using salt of length {0} is {1} ticks or {2} ms.",i,newStopWatch.ElapsedTicks,newStopWatch.ElapsedMilliseconds));
            }

            Console.WriteLine();
            Console.WriteLine("HashingTest Completed.");
        }

        static void DatabaseTests() {

        }

        static void ImageConversionTests() {
            Image newImage = GetMeImage();
            if (newImage == null) {
                MessageBox.Show("This is not going to work");
            }
            string base64 = ImageConversion.ImageToBase64(newImage,newImage.RawFormat);
            Console.WriteLine(base64);
            newImage = ImageConversion.Base64ToImage(base64);
            Clipboard.SetImage(newImage);
        }
        static Image GetMeImage() {
            Image res = null;
            Thread staThread = new Thread(x =>
            {
                try {
                    res = Clipboard.GetImage();
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            });
            staThread.SetApartmentState(ApartmentState.STA);
            staThread.Start();
            staThread.Join();
            return res;
        }
    }
}
