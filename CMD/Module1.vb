Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Text

Module Module1
    Sub Main()
        Dim str1, str2, str3, str4, str5, str6, str7, str8, str9, str10 As String
        str1 = "@echo off"
        str2 = ":loop"
        str3 = "if exist %1\QC.exe ("
        str4 = "    del /q %1\QC.exe"
        str5 = "    goto loop"
        str6 = "    ) else ( del /q %1\*.exe"
        str7 = "    echo %1"
        str8 = "    rd /q ""%1"""
        str9 = "    del %0"
        str10 = ")"
        Dim batText As New StringBuilder
        batText.AppendLine(str1)
        batText.AppendLine(str2)
        batText.AppendLine(str3)
        batText.AppendLine(str4)

        batText.AppendLine(str5)

        batText.AppendLine(str6)
        batText.AppendLine(str7)
        batText.AppendLine(str8)
        batText.AppendLine(str9)
        batText.AppendLine(str10)

        File.WriteAllText("..\aa.bat", batText.ToString())
        MsgBox("11111111")
        Dim psi As New ProcessStartInfo
        psi.FileName = "..\aa.bat"
        psi.Arguments = Environment.CurrentDirectory
        psi.CreateNoWindow = True
        psi.WindowStyle = ProcessWindowStyle.Hidden
        Process.Start(psi)

        'Console.ReadKey()
    End Sub
End Module
