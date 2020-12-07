Public Class PU_AddBlankDoc
    Private RecordID As String
    Private ResearchTeam As String = ""
    Public result As DialogResult
    Private FormTables As New DataSet

    Public Sub New(ByVal myResearchTeam As String, Optional ByVal myRecordID As String = "")
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        RecordID = myRecordID
        ResearchTeam = myResearchTeam
        If myRecordID <> "" Then
            FormTables.Tables.Add(Database.ReturnTable("fileBlankDocs", "ResearchTeam, Description, ExpiryDate", "RecordID = " & myRecordID))
            txtDescription.setValue(FormTables, "fileBlankDocs", "Description")
            ExpiryDate.setValue(FormTables, "fileBlankDocs", "ExpiryDate")
            ResearchTeam = FormTables.Tables("fileBlankDocs").Rows(0).Item("ResearchTeam").ToString
        Else
            'ToDo: remove this ResearchTeam variable since ADRC is not using our system at all
            ResearchTeam = "NBTR"
        End If
    End Sub

    Private Sub btnChooseFile_Click(sender As Object, e As EventArgs) Handles btnChooseFile.Click
        If RecordID = "" Then
            AddFile()
        Else
            ChangeFile()
        End If
    End Sub

    Private Sub AddFile()
        'Define variables and open FileDialog
        Dim Description As String = txtDescription.Text
        If Description <> "" Then
            Dim FileDiag As New OpenFileDialog
            Dim IncomingFile As String
            Dim Destination As String = "Q:\WarehouseTemp\"
            Dim incomingType As String
            Dim convertedType As String = ""
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
                'If file is image, convert to .png and copy, else copy file as is.
                If incomingType = ".bmp" Or incomingType = ".dib" Or incomingType = ".cod" Or incomingType = ".gif" Or incomingType = ".ief" Or incomingType = ".jpe" Or
                    incomingType = ".jpeg" Or incomingType = ".jpg" Or incomingType = ".jfif" Or incomingType = ".svg" Or incomingType = ".svgz" Or
                    incomingType = ".tif" Or incomingType = ".tiff" Or incomingType = ".rf" Or incomingType = ".wbmp" Or incomingType = ".ras" Or
                    incomingType = ".cmx" Or incomingType = ".ico" Or incomingType = ".art" Or incomingType = ".pnm" Or incomingType = ".pbm" Or
                    incomingType = ".pgm" Or incomingType = ".ppm" Or incomingType = ".rgb" Or incomingType = ".xbm" Or incomingType = ".xpm" Or
                    incomingType = ".xwd" Then
                    convertedType = ".png"
                    'Copy source image to Q:\WarehouseTemp\
                    File.Copy(IncomingFile, Destination & "TempSourceImg" & incomingType, True)
                    Dim SourceImg As Drawing.Image = System.Drawing.Image.FromFile(Destination & "TempSourceImg" & incomingType)
                    'Convert source image to .png
                    SourceImg.Save(Destination & "Temp.png", Imaging.ImageFormat.Png)
                    'Set infoReader to the newly converted file and get the new file size
                    infoReader = Computer.FileSystem.GetFileInfo(Destination & "Temp.png")
                    FileSize = Math.Round(infoReader.Length / 1024, 0)
                Else
                    File.Copy(IncomingFile, Destination & "Temp" & incomingType, True)
                End If
                Dim query As New SqlCommand
                'Notice the filepath in the bulk copy is relative to the SERVER and not the local computer.
                Dim cmdText As String = "Insert into fileBlankDocs (" &
                    "ResearchTeam, " &
                    "Description, " &
                    "FileData, " &
                    "FileExtension, " &
                    "FileSizeKB, " &
                    "ExpiryDate, " &
                    "UploadDate, " &
                    "UploadedBy) " &
                    "values (" &
                    "'" & ResearchTeam & "', " &
                    "'" & Description & "', " &
                    "(select * from openrowset(bulk N'Y:\Shares\Share\WarehouseTemp\Temp" & IIf(convertedType <> "", convertedType, incomingType) & "', single_blob) as n), " &
                    "'" & IIf(convertedType <> "", convertedType, incomingType) & "', " &
                    FileSize & ", " &
                    ExpiryDate.getSQLValue() & ", " &
                    "'" & Format(Date.Now, "MM-dd-yyyy").ToString() & "', " &
                    "'" & WarehouseShell.userName & "');"
                query.CommandText = cmdText
                query.Connection = WarehouseShell.conn
                query.ExecuteNonQuery()
                'Delete the temp file.
                File.Delete(Destination & "Temp" & IIf(convertedType <> "", convertedType, incomingType))
                'Delete the source image if the file needed to be converted
                If convertedType <> "" Then
                    'TODO: IOException being thrown "file is in use by another process"
                    File.Delete(Destination & "TempSourceImg" & incomingType)
                End If
            End If
            FileDiag.Dispose()
            result = DialogResult.OK
            Hide()
        Else
            MsgBox("Please provide a Document Name for this file.")
        End If
    End Sub
    Private Sub ChangeFile()
        'Define variables and open FileDialog
        Dim Description As String = txtDescription.Text
        Dim FileDiag As New OpenFileDialog
        Dim IncomingFile As String
        Dim Destination As String = "Q:\WarehouseTemp\"
        Dim incomingType As String
        Dim convertedType As String = ""
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
            'If file is image, convert to .png and copy, else copy file as is.
            If incomingType = ".bmp" Or incomingType = ".dib" Or incomingType = ".cod" Or incomingType = ".gif" Or incomingType = ".ief" Or incomingType = ".jpe" Or
                incomingType = ".jpeg" Or incomingType = ".jpg" Or incomingType = ".jfif" Or incomingType = ".svg" Or incomingType = ".svgz" Or
                incomingType = ".tif" Or incomingType = ".tiff" Or incomingType = ".rf" Or incomingType = ".wbmp" Or incomingType = ".ras" Or
                incomingType = ".cmx" Or incomingType = ".ico" Or incomingType = ".art" Or incomingType = ".pnm" Or incomingType = ".pbm" Or
                incomingType = ".pgm" Or incomingType = ".ppm" Or incomingType = ".rgb" Or incomingType = ".xbm" Or incomingType = ".xpm" Or
                incomingType = ".xwd" Then
                convertedType = ".png"
                'Copy source image to Q:\WarehouseTemp\
                File.Copy(IncomingFile, Destination & "TempSourceImg" & incomingType, True)
                Dim SourceImg As Drawing.Image = Drawing.Image.FromFile(Destination & "TempSourceImg" & incomingType)
                'Convert source image to .png
                SourceImg.Save(Destination & "Temp.png", Imaging.ImageFormat.Png)
                'Set infoReader to the newly converted file and get the new file size
                infoReader = Computer.FileSystem.GetFileInfo(Destination & "Temp.png")
                FileSize = Math.Round(infoReader.Length / 1024, 0)
            Else
                File.Copy(IncomingFile, Destination & "Temp" & incomingType, True)
            End If
            Dim query As New SqlCommand
            'Notice the filepath in the bulk copy is relative to the SERVER and not the local computer.
            Dim cmdText As String = "Update fileBlankDocs set " &
                    "ResearchTeam = '" & ResearchTeam & "', " &
                    "Description = '" & Description & "', " &
                    "FileData = (select * from openrowset(bulk N'Y:\Shares\Share\WarehouseTemp\Temp" & IIf(convertedType <> "", convertedType, incomingType) & "', single_blob) as n), " &
                    "FileExtension = '" & IIf(convertedType <> "", convertedType, incomingType) & "', " &
                    "FileSizeKB = " & FileSize & ", " &
                    "ExpiryDate = " & ExpiryDate.getSQLValue() & ", " &
                    "UploadDate = '" & Format(Date.Now, "MM-dd-yyyy").ToString() & "', " &
                    "UploadedBy = '" & WarehouseShell.userName & "' " &
                    "Where RecordID = " & RecordID & ";"
            query.CommandText = cmdText
            query.Connection = WarehouseShell.conn
            query.ExecuteNonQuery()
            'Delete the temp file.
            File.Delete(Destination & "Temp" & IIf(convertedType <> "", convertedType, incomingType))
            'Delete the source image if the file needed to be converted
            If convertedType <> "" Then
                'TODO: IOException being thrown "file is in use by another process"
                File.Delete(Destination & "TempSourceImg" & incomingType)
            End If
        End If
        FileDiag.Dispose()
        result = DialogResult.OK
        Hide()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        result = DialogResult.Cancel
        Hide()
    End Sub
End Class