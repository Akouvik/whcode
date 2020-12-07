Public Class WA_MiscSubjectFiles
    Implements IFormMethods

    Private MiscResults As DataTable
    Private MedResults As DataTable
    Private Reader As SqlDataAdapter

    Private Sub WA_MiscSubjectFiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_MiscSubjectFiles")
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        formatMiscDGV()
        formatMedDGV()
    End Sub

    'Misc Files
    Private Sub formatMiscDGV()
        MiscResults = New DataTable("MiscResult")
        Reader = New SqlDataAdapter("Select RecordID, ResearchTeam, Description, FileExtension as FileType, FileSizeKB, UploadDate, UploadedBy from fileMiscSubjectFiles where SubNum = " & WarehouseShell.SubNum, WarehouseShell.conn)
        Reader.Fill(MiscResults)
        dgvMiscFiles.DataSource = MiscResults
        dgvMiscFiles.Columns("RecordID").Visible = False
        dgvMiscFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        If dgvMiscFiles.Rows.Count > 0 Then
            btnMiscDeleteFile.Enabled = True
        Else
            btnMiscDeleteFile.Enabled = False
        End If
    End Sub
    Private Sub btnMiscAddFile_Click(sender As Object, e As EventArgs) Handles btnMiscAddFile.Click
        If User.PermissionCheck("WA_MiscSubjectFiles", "Modify") Then
            Dim pu As New PU_AddMiscSubjectFile
            pu.ShowDialog()
            Dim result As DialogResult = pu.result
            If result = DialogResult.OK Then
                formatMiscDGV()
            End If
            pu.Dispose()
        End If
    End Sub
    Private Sub dgvMiscFiles_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMiscFiles.CellContentDoubleClick
        Dim RecordID As String = dgvMiscFiles.SelectedRows(0).Cells("RecordID").Value.ToString
        Dim outputFileName As String = dgvMiscFiles.SelectedRows(0).Cells("Description").Value.ToString
        'This sub uses https://support.microsoft.com/en-us/kb/316887 & System.Diagnostics to grab the blob file from filestream, copy it with extension to the user's temp file, then open it using whatever default program they have for that extension.
        Dim tempFilePath As String = IO.Path.GetTempPath()
        Dim tempFileExt As String
        'These lines get the file extension from the tableName table and assigns it to tempFileExt (and set the connection property for this and subsequent SqlCommands)
        Dim cmd As New SqlCommand
        cmd.Connection = WarehouseShell.conn
        cmd.CommandText = "Select FileExtension from fileMiscSubjectFiles where RecordID = " & RecordID & ";"
        tempFileExt = cmd.ExecuteScalar().ToString
        'Grab the binary data from FileStream and load it into the SqlDataReader
        cmd.CommandText = "Select FileData from fileMiscSubjectFiles where RecordID = " & RecordID & ";"
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        dr.Read()
        Dim b(dr.GetBytes(0, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
        dr.GetBytes(0, 0, b, 0, b.Length)
        dr.Close()
        Try
            'Write the binary data to a file with extension in the user's temp folder (using provided file name or default)
            tempFilePath = tempFilePath & outputFileName & tempFileExt
            Dim fs As New FileStream(tempFilePath, IO.FileMode.Create, IO.FileAccess.Write)
            fs.Write(b, 0, b.Length)
            fs.Close()
            'Open the temp file using the user's default program for that extension
            Dim P As New Process
            Dim s As New ProcessStartInfo(tempFilePath)
            s.UseShellExecute = True
            s.WindowStyle = ProcessWindowStyle.Normal
            P.StartInfo = s
            P.Start()
        Catch ex As Exception
            ExceptionHandler.CatchWindowsException(ex)
        End Try
    End Sub
    Private Sub btnMiscDeleteFile_Click(sender As Object, e As EventArgs) Handles btnMiscDeleteFile.Click
        If User.PermissionCheck("WA_MiscSubjectFiles", "Modify") Then
            Dim desc As String = dgvMiscFiles.SelectedRows(0).Cells("Description").Value.ToString
            Dim check As DialogResult = MsgBox("WARNING- You are about to delete the '" & desc & "' file for this subject. Please confirm that you would like to continue.", MsgBoxStyle.OkCancel, "CAUTION")
            If check = DialogResult.OK Then
                Dim recordID As Integer = dgvMiscFiles.SelectedRows(0).Cells("RecordID").Value
                Dim cmd As New SqlCommand("Delete from fileMiscSubjectFiles where RecordID = " & recordID & ";", WarehouseShell.conn)
                cmd.ExecuteNonQuery()
                formatMiscDGV()
            End If
        End If
    End Sub

    'Scanned Med Records
    Private Sub formatMedDGV()
        MedResults = New DataTable("MedResult")
        Reader = New SqlDataAdapter("Select * from filePointerMedicalRecords where SubNum = " & WarehouseShell.SubNum & " order by SeqNum asc", WarehouseShell.conn)
        Reader.Fill(MedResults)
        dgvMedFiles.DataSource = MedResults
        dgvMedFiles.Columns("RecordID").Visible = False
        dgvMedFiles.Columns("SubNum").Visible = False
        dgvMedFiles.Columns("BB").Visible = False
        dgvMedFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        If dgvMedFiles.Rows.Count > 0 Then
            btnMedDeleteFile.Enabled = True
        Else
            btnMedDeleteFile.Enabled = False
        End If
    End Sub
    Private Sub btnMedAddFile_Click(sender As Object, e As EventArgs) Handles btnMedAddFile.Click
        If User.PermissionCheck("WA_MiscSubjectFiles", "Modify") Then
            Dim pu As New PU_AddMedRecordScan(WarehouseShell.SubNum)
            pu.ShowDialog()
            Dim result As DialogResult = pu.result
            If result = DialogResult.OK Then
                formatMedDGV()
            End If
            pu.Dispose()
        End If
    End Sub
    Private Sub dgvMedFiles_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMedFiles.CellContentDoubleClick
        Dim folder As String = "Q:\Warehouse Files\Uploaded Files\General Medical Records\"
        Dim outputFileName As String = dgvMedFiles.SelectedRows(0).Cells("FileName").Value.ToString
        Dim filePath As String = folder & outputFileName
        Try
            Dim P As New Process
            Dim s As New ProcessStartInfo(filePath)
            s.UseShellExecute = True
            s.WindowStyle = ProcessWindowStyle.Normal
            P.StartInfo = s
            P.Start()
        Catch ex As Exception
            ExceptionHandler.CatchWindowsException(ex)
        End Try
    End Sub
    Private Sub btnMedDeleteFile_Click(sender As Object, e As EventArgs) Handles btnMedDeleteFile.Click
        If User.PermissionCheck("WA_MiscSubjectFiles", "Modify") Then
            Dim team As String = dgvMedFiles.SelectedRows(0).Cells("ResearchTeam").Value.ToString
            If team = "NBTR" Then
                If User.CheckPermission("Dissectionist, DonationCoordinator, LabTech, LabTechLead, Neuropathologist, NPTech, PMCRAssessor, Prosector") Then
                    deleteMedFile()
                    formatMedDGV()
                Else
                    MsgBox("You do not have permission to delete this file.", MsgBoxStyle.OkOnly, "Permission Error")
                End If
            ElseIf team = "ADRC" Then
                If User.CheckPermission("ADRCEdit") Then
                    deleteMedFile()
                    formatMedDGV()
                Else
                    MsgBox("You do not have permission to delete this file.", MsgBoxStyle.OkOnly, "Permission Error")
                End If
            End If
        End If
    End Sub
    Private Sub deleteMedFile()
        Dim result As DialogResult = MsgBox("Are you sure you want to delete the selected file?", MsgBoxStyle.YesNo, "Warning")
        If result = DialogResult.Yes Then
            Dim folder As String = "Q:\Warehouse Files\Uploaded Files\General Medical Records\"
            Dim file As String = dgvMedFiles.SelectedRows(0).Cells("FileName").Value.ToString
            Dim recordID As String = dgvMedFiles.SelectedRows(0).Cells("RecordID").Value.ToString
            Try
                Computer.FileSystem.DeleteFile(folder & file)
            Catch ex As Exception
                ExceptionHandler.CatchWindowsException(ex)
            End Try
            Dim cmd As New SqlCommand("delete from filePointerMedicalRecords where RecordID = " & recordID, WarehouseShell.conn)
            cmd.ExecuteNonQuery()
        End If
    End Sub

    'Imported IFormMethods
    Public Sub ShowPHI(showPHI As Boolean) Implements IFormMethods.ShowPHI
    End Sub
    Public Sub Parent1(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Public Sub Show1() Implements IFormMethods.Show
        Show()
    End Sub
    Public Sub TopLevel1(val As Boolean) Implements IFormMethods.TopLevel
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class