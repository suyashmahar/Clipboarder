# Clipboarder
**Clipboarder** is a clipboard management tool for Windows written in C#.

## Features:
1. Clipboard management for text and image based content.
2. Ability to save contents of Clipboarder to database using password.
3. Ability to access content in hierarchical order using customizable  keyboard shortcut (<kbd>Ctrl</kbd> + <kbd>Shift</kbd> + <kbd>NumberKeys</kbd>).

## TODOs:
1. Improve performance on exporting content.
2. More user control over opertations like exporting content.
3. Identification of URL in content to open link in a browser window.
4. Better image support and stability.

## Instruction for Building Solution
1. Open project is in Visual Studio 2015.
2. Change Active Solution Configuration in Configuration Manager to *x86* to avoid build errors.
3. Build Solution. 

### Fixing common build errors
* If build shows reference errors in `Clipboarder` or `Clipboarder.Extensions.DatabaseOperations` add manually reference to `System.Data.SQlite.dll` and `PasswordControlBox.dll` from packages directory to `Clipboarder.Extensions` and `Clipboarder` respectively. Then rebuild the solution.
* If Visual Studio fails to recognize `ClipboardControl` in `MainForm.Desginer.cs` try adding `using Clipboarder;` at the beginning of the document.
