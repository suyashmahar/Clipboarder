using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Clipboarder {
    public struct TextContent {
        public int index;
        public string text;
        public string time;
    }

    public struct ImageContent {
        public int index;
        public Image image;
        public string time;
    }
}
