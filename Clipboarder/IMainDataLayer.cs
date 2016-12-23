using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clipboarder {
    public interface IMainDataLayer {
        int TaskProgress { get; set; } // Progress of any task being processed
        bool ProgressVisibility { get; set; }
        int TextRowCount { get; }
        int ImageRowCount { get; }
        string status { get; set; }
        string SelectedRowText { get; }
        bool ShowURLStatus { set; }

        event EventHandler<EventArgs> LoadContent;
        event EventHandler<EventArgs> SaveContent;
        event EventHandler<EventArgs> OnExiting;
        event EventHandler<EventArgs> ViewLoaded;
        event EventHandler<EventArgs> ShowSettings;
        event EventHandler<EventArgs> URLCalled;
        event EventHandler<TextEventArgs> textGridCheckURLAndSetStatus;

        void AddNewTextRow(TextContent contentToAdd);
        void AddNewImageRow(ImageContent contentToAdd);
        List<ImageContent> GetAllImageContent();
        List<TextContent> GetAllTextContent();
        ImageContent GetImageContentAt(int index);
        TextContent GetTextContentAt(int index);

        void ClearAll();
    }
}
