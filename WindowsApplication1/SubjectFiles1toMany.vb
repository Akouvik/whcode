Imports System.IO

Public Class SubjectFiles1toMany

    Public Shared Sub SaveFile(ByVal tableName As String, ByVal SubNum As Integer)
        'Define variables and open FileDialog
        Dim FileDiag As New OpenFileDialog
        Dim IncomingFile As String
        Dim Destination As String = "Q:\WarehouseTemp\"
        Dim incomingType As String
        Dim FileSize As Integer
        Dim infoReader As System.IO.FileInfo
        Dim cmd As New SqlCommand("", WarehouseShell.conn)
        Dim SequenceNum As Integer = 1

        'Check if there are previous files like this one (and increment SequenceNum if needed)
        If CheckFile(tableName, SubNum) Then
            cmd.CommandText = "Select Max(SequenceNum) from " & tableName & " where SubNum = " & SubNum & ";"
            Dim value As Integer = cmd.ExecuteScalar()
            SequenceNum = value + 1
        End If

        FileDiag.ShowDialog()
        'TODO- Make sure that a file was selected in the FileDiag window
        IncomingFile = FileDiag.FileName
        'Handle user cancelling out of FileDiag
        If IncomingFile <> "" Then
            infoReader = My.Computer.FileSystem.GetFileInfo(IncomingFile)
            FileSize = Math.Round(infoReader.Length / 1024, 0)
            incomingType = infoReader.Extension.ToString
            File.Copy(IncomingFile, Destination & "Temp" & incomingType, True)
            'Notice the filepath in the bulk copy is relative to the SERVER and not the local computer.
            Dim cmdText As String = "Insert into " & tableName &
                " (SubNum, " &
                "SequenceNum, " &
                "FileData, " &
                "FileExtension, " &
                "FileSizeKB, " &
                "UploadDate) " &
                "values (" &
                SubNum & ", " &
                SequenceNum & ", " &
                " (select * from openrowset(bulk N'Y:\Shares\Share\WarehouseTemp\Temp" & incomingType & "', single_blob) as n), '" & incomingType & "', " &
                FileSize & ", " &
                "'" & Format(Date.Now, "MM-dd-yyyy").ToString() & "');"
            cmd.CommandText = cmdText
            cmd.ExecuteNonQuery()
            'Delete the temp file.
            File.Delete(Destination & "Temp" & incomingType)
            'Delete the source image if the file needed to be converted
        End If
        FileDiag.Dispose()
    End Sub

    Public Shared Function CheckFile(ByVal tableName As String, ByVal SubNum As Integer) As Boolean
        Dim query As New SqlCommand
        query.CommandText = "Select count(*) from " & tableName & " where SubNum = " & SubNum & ";"
        query.Connection = WarehouseShell.conn
        If query.ExecuteScalar() > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Sub OpenFile(ByVal tableName As String, ByVal SubNum As Integer, ByVal outputFileName As String, ByVal SequenceNum As Integer)
        If WarehouseShell.ShowingPHI Then
            'This sub uses https://support.microsoft.com/en-us/kb/316887 & System.Diagnostics to grab the blob file from filestream, copy it with extension to the user's temp file, then open it using whatever default program they have for that extension.
            Dim tempFilePath As String = Path.GetTempPath()
            Dim tempFileExt As String
            'These lines get the file extension from the tableName table and assigns it to tempFileExt (and set the connection property for this and subsequent SqlCommands)
            Dim cmd As New SqlCommand
            cmd.Connection = WarehouseShell.conn
            cmd.CommandText = "Select FileExtension from " & tableName & " where SubNum = " & SubNum & " and SequenceNum = " & SequenceNum & ";"
            tempFileExt = cmd.ExecuteScalar().ToString
            'Grab the binary data from FileStream and load it into the SqlDataReader
            cmd.CommandText = "Select FileData from " & tableName & " where SubNum = " & SubNum & " and SequenceNum = " & SequenceNum & ";"
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            dr.Read()
            Dim b(dr.GetBytes(0, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
            dr.GetBytes(0, 0, b, 0, b.Length)
            dr.Close()
            Try
                'Write the binary data to a file with extension in the user's temp folder (using provided file name or default)
                tempFilePath = tempFilePath & outputFileName & tempFileExt
                Dim fs As New System.IO.FileStream(tempFilePath, IO.FileMode.Create, IO.FileAccess.Write)
                fs.Write(b, 0, b.Length)
                fs.Close()
                'Open the temp file using the user's default program for that extension
                Dim P As New System.Diagnostics.Process
                Dim s As New System.Diagnostics.ProcessStartInfo(tempFilePath)
                s.UseShellExecute = True
                s.WindowStyle = ProcessWindowStyle.Normal
                P.StartInfo = s
                P.Start()
            Catch ex As Exception
                ExceptionHandler.CatchWindowsException(ex)
            End Try
        Else
            MsgBox("This file may contain Protected Health Information. Please enable PHI before attempting to open.", MsgBoxStyle.OkOnly, "Warning")
        End If
    End Sub

    Public Shared Sub DeleteFile(ByVal tableName As String, ByVal SubNum As Integer, ByVal SequenceNum As Integer)
        If CheckDelete() = True Then
            Dim cmd As New SqlCommand("Delete from " & tableName & " where SubNum = " & SubNum & " and SequenceNum = " & SequenceNum & ";", WarehouseShell.conn)
            cmd.ExecuteNonQuery()
        End If
    End Sub

    Public Shared Function CheckDelete() As Boolean
        Dim result As MsgBoxResult = MsgBox("Are you sure you want to delete this file?", MsgBoxStyle.YesNo)
        If result = MsgBoxResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function

End Class