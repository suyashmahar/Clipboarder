@rem Clipboarder Script (c) 2015-17 Suyash Mahar 
@rem Remove Clipboarder entry to startup item registry key

reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Run /v Clipboarder /d "%~dp0Clipboarder.exe -u" /f
