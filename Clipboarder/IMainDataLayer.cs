using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clipboarder {
    interface IMainDataLayer {
        int TaskProgress { get; set; } // Progress of any task bieng processed
        bool ProgressVisibility { get; set; }

        event EventHandler<EventArgs> LoadContent;
        event EventHandler<EventArgs> SaveContent;
        event EventHandler<EventArgs> OnExiting;
        event EventHandler<EventArgs> ViewLoaded;

        void AddNewTextRow(TextContent contentToAdd);
        void AddNewImageRow(ImageContent contentToAdd);
        List<ImageContent> GetAllImageContent();
        List<TextContent> GetAllTextContent();
    }
}
