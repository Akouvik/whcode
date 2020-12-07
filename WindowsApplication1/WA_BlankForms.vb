Public Class WA_BlankForms
    Implements IFormMethods
    Private formTables As New DataSet
    Private tempFilePath As String = IO.Path.GetTempPath()

    Private Sub WA_BlankForms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormatNBTR()
    End Sub

    Private Sub FormatNBTR()
        'Check if user has permissions to view NBTR Docs
        If User.CheckPermission("Dissectionist, DonationCoordinator, LabTech, LabTechLead, Neuropathologist, NPTech, PMCRAssessor, Prosector") Then
            'Remove existing NBTR table if it exists
            If formTables.Tables.Contains("viewFileBlankDocs_NBTR") Then
                formTables.Tables.Remove("viewFileBlankDocs_NBTR")
            End If
            'Grab a fresh copy of the NBTR table
            formTables.Tables.Add(Database.ReturnTable("viewFileBlankDocs_NBTR"))
            dgvNBTR.DataSource = formTables.Tables("viewFileBlankDocs_NBTR")
            dgvNBTR.Columns("RecordID").Visible = False
            'Format the dgv and grp height
            FormatDGVHeight(dgvNBTR)
            dgvNBTR.AutoResizeColumns()
            dgvNBTR.Sort(dgvNBTR.Columns("Description"), ComponentModel.ListSortDirection.Ascending)
            grpNBTR.Visible = True
            'Enable/disable buttons based on permission
            If User.CheckPermission("Dissectionist, DonationCoordinator, LabTech, LabTechLead, Neuropathologist, NPTech, PMCRAssessor, Prosector") Then
                btnNBTRAdd.Enabled = True
            Else
                btnNBTRAdd.Enabled = False
            End If
            'Enable/disable buttons based on returned rows
            If dgvNBTR.Rows.Count > 0 Then
                btnNBTROpen.Enabled = True
                If User.CheckPermission("Dissectionist, DonationCoordinator, LabTech, LabTechLead, Neuropathologist, NPTech, PMCRAssessor, Prosector") Then
                    btnNBTRRemove.Enabled = True
                    btnNBTRReplace.Enabled = True
                Else
                    btnNBTRRemove.Enabled = False
                    btnNBTRReplace.Enabled = False
                End If
            Else
                btnNBTROpen.Enabled = False
                btnNBTRRemove.Enabled = False
                btnNBTRReplace.Enabled = False
            End If
        Else
            grpNBTR.Visible = False
        End If
    End Sub
    Private Sub btnNBTROpen_Click(sender As Object, e As EventArgs) Handles btnNBTROpen.Click
        Dim RecordID As String = dgvNBTR.SelectedRows(0).Cells("RecordID").Value.ToString
        Dim outputFileName As String = dgvNBTR.SelectedRows(0).Cells("Description").Value.ToString
        'This sub uses https://support.microsoft.com/en-us/kb/316887 & System.Diagnostics to grab the blob file from filestream, copy it with extension to the user's temp file, then open it using whatever default program they have for that extension.
        Dim tempFilePath As String = IO.Path.GetTempPath()
        Dim tempFileExt As String
        'These lines get the file extension from the tableName table and assigns it to tempFileExt (and set the connection property for this and subsequent SqlCommands)
        Dim cmd As New SqlCommand
        cmd.Connection = WarehouseShell.conn
        cmd.CommandText = "Select FileExtension from fileBlankDocs where RecordID = " & RecordID & ";"
        tempFileExt = cmd.ExecuteScalar().ToString
        'Grab the binary data from FileStream and load it into the SqlDataReader
        cmd.CommandText = "Select FileData from fileBlankDocs where RecordID = " & RecordID & ";"
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
    Private Sub dgvNBTR_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNBTR.CellContentDoubleClick
        btnNBTROpen.PerformClick()
    End Sub
    Private Sub btnNBTRReplace_Click(sender As Object, e As EventArgs) Handles btnNBTRReplace.Click
        If User.PermissionCheck("WA_BlankForms", "Modify") Then
            Dim RecordID As String = dgvNBTR.SelectedRows(0).Cells("RecordID").Value.ToString()
            Dim pu As New PU_AddBlankDoc("NBTR", RecordID)
            pu.ShowDialog()
            Dim result As DialogResult = pu.result
            If result = DialogResult.OK Then
                FormatNBTR()
            End If
            pu.Dispose()
        End If
    End Sub
    Private Sub btnNBTRRemove_Click(sender As Object, e As EventArgs) Handles btnNBTRRemove.Click
        If User.PermissionCheck("WA_BlankForms", "Modify") Then
            Dim result As DialogResult = MsgBox("Are you sure you'd like to delete the selected document?", MsgBoxStyle.YesNo, "Warning")
            If result = DialogResult.Yes Then
                Dim RecordID As String = dgvNBTR.SelectedRows(0).Cells("RecordID").Value.ToString()
                Dim cmdText As String = "delete from fileBlankDocs where RecordID = " & RecordID & ";"
                Dim cmd As New SqlCommand(cmdText, WarehouseShell.conn)
                Try
                    cmd.ExecuteNonQuery()
                    FormatNBTR()
                Catch ex As SqlException
                    ExceptionHandler.CatchSQLException(ex)
                End Try
            End If
        End If
    End Sub
    Private Sub btnNBTRAdd_Click(sender As Object, e As EventArgs) Handles btnNBTRAdd.Click
        If User.PermissionCheck("WA_BlankForms", "Modify") Then
            Dim pu As New PU_AddBlankDoc("NBTR")
            pu.ShowDialog()
            Dim result As DialogResult = pu.result
            If result = DialogResult.OK Then
                FormatNBTR()
            End If
            pu.Dispose()
        End If
    End Sub

    Private Sub FormatDGVHeight(ByVal dgv As DataGridView)
        Dim height As Integer = dgv.Rows.GetRowsHeight(DataGridViewElementStates.None) + 25
        If height > 800 Then
            height = 800
        ElseIf height = 25 Then
            height = 35
        End If
        dgv.Height = height
        dgv.Parent.Height = height + 54
    End Sub

    Public Sub TopLevel(val As Boolean) Implements IFormMethods.TopLevel
    End Sub
    Public Sub ShowPHI(val As Boolean) Implements IFormMethods.ShowPHI
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
    Private Sub IFormMethods_Parent(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Private Sub IFormMethods_Show() Implements IFormMethods.Show
        Show()
    End Sub
End Class