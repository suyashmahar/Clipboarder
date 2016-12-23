# Clipboarder
**Clipboarder** is a clipboard management tool for Windows written in C#. This projec is still under construction.

## Features:
1. Clipboard management for text and image based content.
2. Ability to save contents of Clipboarder to database using password.
3. Ability to access content in hierarchical order using customizable  keyboard shortcut, default: <kbd>Ctrl</kbd> + <kbd>Shift</kbd> + <kbd>NumberKeys</kbd>.
4. Identification of multiple URLs in text content (turned off by default).

## TODOs:
1. Improve performance on exporting content.
2. More user control over opertations like exporting content.
3. Better image support and stability.

## Instruction for Building Solution
1. Open project is in Visual Studio 2015.
2. Change Active Solution Configuration in Configuration Manager to *x86* to avoid build errors.
3. Build Solution. 

### Fixing common build errors
* If build shows reference errors in `Clipboarder` or `Clipboarder.Extensions.DatabaseOperations` add manually reference to `System.Data.SQlite.dll` and `PasswordControlBox.dll` from packages directory to `Clipboarder.Extensions` and `Clipboarder` respectively. Then rebuild the solution.
* If Visual Studio fails to recognize `ClipboardControl` in `MainForm.Desginer.cs` try adding `using Clipboarder;` at the beginning of the document.
