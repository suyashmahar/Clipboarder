;------------------------------------------------------------
; clipboarder.nsi
;------------------------------------------------------------
; NSIS Installer script for Clipboarder
; (c) 2015-17 Suyash Mahar, MIT License
;------------------------------------------------------------
; Usage:
;   1.  Within the directory from where this script will run
;       create directory named 'bin'
;   2.  Copy source files into 'bin/'
;   3.  Set this variable to release version number:
        !define VERSION "1.0.0.0" 
;   4.  Compile script using NSIS
;------------------------------------------------------------

; The name of the installer
Name "Clipboarder"

; The file to write
OutFile "clipboarder_release.exe"

; The default installation directory
InstallDir $PROGRAMFILES\Clipboarder\${VERSION}

; Registry key to check for directory (so if you install again, it will 
; overwrite the old one automatically)
InstallDirRegKey HKLM "Software\Clipboarder" "Install_Dir"

; Request application privileges for Windows Vista
RequestExecutionLevel admin

;--------------------------------

; Pages

Page components
Page directory
Page instfiles

UninstPage uninstConfirm
UninstPage instfiles

;--------------------------------

; The stuff to install
Section "Clipboarder (required)"

  SectionIn RO
  
  ; Set output path to the installation directory.
  SetOutPath $INSTDIR
  
  ; Put file there
  ; File /nonfatal /r /x *.nsi /x .pdb
  File /r "bin\*"

  ; Write the installation path into the registry
  WriteRegStr HKLM SOFTWARE\Clipboarder "Install_Dir" "$INSTDIR"
  
  ; Write the uninstall keys for Windows
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Clipboarder" "DisplayName" "Clipboarder"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Clipboarder" "UninstallString" '"$INSTDIR\uninstall.exe"'
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Clipboarder" "NoModify" 1
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Clipboarder" "NoRepair" 1
  WriteUninstaller "uninstall.exe"
  
SectionEnd

; Optional section (can be disabled by the user)
Section "Start Menu Shortcuts"

  CreateDirectory "$SMPROGRAMS\Clipboarder"
  CreateShortcut "$SMPROGRAMS\Clipboarder\Uninstall.lnk" "$INSTDIR\uninstall.exe" "" "$INSTDIR\uninstall.exe" 0
  CreateShortcut "$SMPROGRAMS\Clipboarder\Clipboarder (MakeNSISW).lnk" "$INSTDIR\Clipboarder.exe" "" "$INSTDIR\Clipboarder.exe" 0
  
SectionEnd

; Create Desktop shortcut
Section "Desktop Shortcuts"
  CreateShortcut "$desktop\Clipboarder.lnk" "$instdir\Clipboarder.exe"
SectionEnd

;--------------------------------

; Uninstaller

Section "Uninstall"
  
  ; Remove registry keys
  DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Clipboarder"
  DeleteRegKey HKLM SOFTWARE\NSIS_Clipboarder

  ; Remove files and uninstaller
  Delete $INSTDIR\*
  RMDir $INSTDIR\SHLs\*
  RMDir $INSTDIR\SHLs

  ; Remove shortcuts, if any
  Delete "$SMPROGRAMS\Clipboarder\*.*"

  ; Remove directories used
  RMDir "$SMPROGRAMS\Clipboarder"
  RMDir "$INSTDIR"

  ; Remove desktop shortcut
  Delete "$desktop\Clipboarder.lnk"

SectionEnd
