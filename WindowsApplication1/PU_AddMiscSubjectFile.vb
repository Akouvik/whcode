Public Class PU_AddMiscSubjectFile
    Private ResearchTeam As String = ""
    Public result As DialogResult

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        ResearchTeam = "NBTR"
        'ToDo: remove this ResearchTeam variable since ADRC is not using our system at all
    End Sub

    Private Sub btnChooseFile_Click(sender As Object, e As EventArgs) Handles btnChooseFile.Click
        'Define variables and open FileDialog
        Dim Description As String = txtDescription.Text
        If Description <> "" Then
            Dim FileDiag As New OpenFileDialog
            Dim IncomingFile As String
            Dim Destination As String = "Q:\WarehouseTemp\"
            Dim incomingType As String
            Dim FileSize As Integer
            Dim infoReader As FileInfo
            Dim Username As String = WarehouseShell.userName
            FileDiag.ShowDialog()
            'TODO- Make sure that a file was selected in the FileDiag window
            IncomingFile = FileDiag.FileName
            'Handle user cancelling out of FileDiag
            If IncomingFile <> "" Then
                infoReader = Computer.FileSystem.GetFileInfo(IncomingFile)
                FileSize = Math.Round(infoReader.Length / 1024, 0)
                incomingType = infoReader.Extension.ToString
                File.Copy(IncomingFile, Destination & "Temp" & incomingType, True)
                Dim query As New SqlCommand
                'Notice the filepath in the bulk copy is relative to the SERVER and not the local computer.
                Dim cmdText As String = "Insert into fileMiscSubjectFiles (" &
                    "SubNum, " &
                    "ResearchTeam, " &
                    "Description, " &
                    "FileData, " &
                    "FileExtension, " &
                    "FileSizeKB, " &
                    "UploadDate, " &
                    "UploadedBy) " &
                    "values (" &
                    WarehouseShell.SubNum & ", " &
                    "'" & ResearchTeam & "', " &
                    "'" & Description & "', " &
                    "(select * from openrowset(bulk N'Y:\Shares\Share\WarehouseTemp\Temp" & incomingType & "', single_blob) as n), " &
                    "'" & incomingType & "', " &
                    FileSize & ", " &
                    "'" & Format(Date.Now, "MM-dd-yyyy").ToString() & "', " &
                    "'" & WarehouseShell.userName & "');"
                query.CommandText = cmdText
                query.Connection = WarehouseShell.conn
                query.ExecuteNonQuery()
                'Delete the temp file.
                File.Delete(Destination & "Temp" & incomingType)
            End If
            FileDiag.Dispose()
            Result = DialogResult.OK
            Hide()
        Else
            MsgBox("Please provide a Document Name for this file.")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        result = DialogResult.Cancel
        Hide()
    End Sub
End Class