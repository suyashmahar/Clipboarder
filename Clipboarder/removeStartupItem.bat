@rem Clipboarder Script (c) 2015-17 Suyash Mahar
@rem Remove Clipboarder entry to startup item registry key

reg delete HKCU\Software\Microsoft\Windows\CurrentVersion\Run /v Clipboarder
