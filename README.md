# Clipboarder
**Clipboarder** is a clipboard management tool for Windows written in C# using .NET framework 4.0.

## Features:
1. Clipboard management for text and image based content.
2. Ability to save contents of Clipboarder to database using password.
3. Ability to access content in hierarchical order using customizable  keyboard shortcut, default: <kbd>Ctrl</kbd> + <kbd>Shift</kbd> + <kbd>NumberKeys</kbd>.
4. Identification of multiple URLs in text content (turned off by default).
5. Syntax Highlighting for languages defined in SHLs directory

## Syntax Highlighting
Clipboarder uses cutom `RichTextBox`, `SyntaxHighlightingTextBox` to highlight text. Keywords for coloring are stored in XML files within the 'SHLs' directory.
### Note:
* Language name displayed in Text Preview are same as XML file in the SHLs directory.
* XML file should follow pattern similar to that of `sample-java.xml`
* Coloring of keywords in `SyntaxHighlightingTextBox` is in the order they are defined in XML file.

## Instruction for Building Solution
1. Open project is in Visual Studio 2015.
2. Change **Active Solution Configuration** in **Configuration Manager** to **x86**
3. Build Solution. 

### Fixing common build errors
* If build shows reference errors in `Clipboarder` add manually reference to `System.Data.SQlite.dll` and `PasswordControlBox.dll` from packages directory to `Clipboarder`. Then rebuild the solution.
* If Visual Studio fails to recognize `ClipboardControl` in `MainForm.Desginer.cs` try adding `using Clipboarder;` directive.
