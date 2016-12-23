using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clipboarder {
    public class TextEventArgs : EventArgs {
        private List<string> textContent = new List<string>();
        
        public List<string> GetAll {
            get {
                return textContent;
            }
        }

        public void Add(string stringToAdd) {
            textContent.Add(stringToAdd);
        }
    }
}
