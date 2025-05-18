@echo off
cd /d %~dp0

set CSC="C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe"

%CSC% /target:winexe ^
/reference:System.Data.SQLite.dll ^
/reference:System.Windows.Forms.dll ^
LoginForm.cs AdminForm.cs SocioForm.cs DB.cs
