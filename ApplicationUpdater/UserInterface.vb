Imports System.IO

Public Class UserInterface

    Private Sub UserInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim localInstallFilePath As String = System.IO.Path.GetDirectoryName(Application.ExecutablePath.ToString())

        If Not System.IO.File.Exists(localInstallFilePath & "\DataWarehouse.exe") Then
            MsgBox("There was an error launching the Data Warehouse." & vbNewLine & vbNewLine & "If this problem persists, please SCREENSHOT THIS ERROR MESSAGE and contact the Data Manager at (718) 584-9000 ext 6094 or joshua.arneson@mssm.edu", MsgBoxStyle.Critical, "ERROR")
            Me.Close()
        End If
        Try
            Dim myFileVersionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(localInstallFilePath & "\DataWarehouse.exe")
            Dim currentFileVersionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo("Q:\Warehouse Files\ApplicationUpdate\DataWarehouse.exe")
            Dim currentVersion As String = currentFileVersionInfo.FileVersion
            Dim myVersion As String = myFileVersionInfo.FileVersion
            If myVersion <> currentVersion Then
                System.IO.File.Copy("Q:\Warehouse Files\ApplicationUpdate\DataWarehouse.exe", localInstallFilePath & "\DataWarehouse.exe", True)
            End If
            Shell(localInstallFilePath & "\DataWarehouse.exe")
        Catch ex As Exception
            MsgBox("There was an error launching the Data Warehouse." & vbNewLine & vbNewLine & _
                   "Please make sure your computer is connected to the Mount Sinai network and that you are mapped to the ""Q"" drive and that the ""Q"" drive is active (not showing a red X in your My Computer screen)." & vbNewLine & vbNewLine & _
                   "If this problem persists, please SCREENSHOT THIS ERROR MESSAGE and contact the Data Manager at (718) 584-9000 ext 6094 or joshua.arneson@mssm.edu.", MsgBoxStyle.OkOnly, "Error")
        End Try
        Me.Close()
    End Sub

End Class