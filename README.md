# Clipboarder
**Clipboarder** is a clipboard management tool for Windows written in C#.

## Features:
1. Clipboard management for text and image based content.
2. Ability to save contents of Clipboarder to database using password.
3. Ability to access content in hierarchical order using keyboard shortcut (`Ctrl + Shift + NumberKeys`).

## TODOs:
1. Improve performance on exporting content.
2. Customizable shortcut and option to export save data without a password.
3. Identification of URL in content to open link in a browser window.
4. Better image support.

## Instruction for Building Solution
    1. Project is in Visual Studio 2015.
    2. Change Active Solution Configuration in Configuration Manager to *x86* to avoid build errors.
    3. Build Solution. 
If build shows reference errors in `Clipboarder` or `Clipboarder.Extensions.DatabaseOperations` add manually reference to `System.Data.SQlite.dll` and `PasswordControlBox.dll` from packages directory to `Clipboarder.Extensions` and `Clipboarder` respectively. Then rebuild the solution.
