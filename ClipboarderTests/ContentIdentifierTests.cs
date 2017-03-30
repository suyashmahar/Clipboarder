using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clipboarder;
using System.Collections.Generic;

namespace ClipboarderTests {
    [TestClass]
    public class ContentIdentifierTests {
        [TestMethod]
        public void ContainsURL_withValidURLString_returnsTrue() {
            Dictionary<String, Boolean> sampleStrings = new Dictionary<String, Boolean>();
            sampleStrings.Add("019avd23asvad8\nee www.g.com", true);
            sampleStrings.Add("https://a.a", false);
            sampleStrings.Add("https://example.me", false);
            sampleStrings.Add("http://www.example.com", true);
            sampleStrings.Add("w3.example.com", false);

            foreach (String sampleString in sampleStrings.Keys) {
                Assert.AreEqual(ContentIdentifier.ContainsURL(sampleString),
                    sampleStrings[sampleString]);
            }
        }
    }
}
