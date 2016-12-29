using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Clipboarder {
    public class ColoredKeyword {
        public string keyword;
        public Color color;

        public ColoredKeyword(string keyword, Color color) {
            this.keyword = keyword;
            this.color = color;
        }
    }
}
