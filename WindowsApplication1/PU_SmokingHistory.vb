Public Class PU_SmokingHistory
    Implements IFormMethods
    Private formTable As New DataSet
    Private editMode As Boolean = False
    Private tooltip1 As New ToolTip
    Private myRecordID As String = ""

    Private Sub updateDGVData()
        If Database.ExistingRecordCheck("SmokingHistory", "SubNum = " & WarehouseShell.SubNum) Then
            formTable.Tables.Clear()
            formTable.Tables.Add(Database.ReturnTable("SmokingHistory", "RecordID, Convert(nvarchar(10), ReportDate, 101) as 'Report Date', SmokingHistoryValue, SmokingHistoryLabel " &
                                                                "as 'Smoking History', AgeStarted as 'Age Started', Convert(nvarchar(10), DateStopped, 101) as 'Approx Date Stopped', " &
                                                                "YearsSmoked as 'Years Smoked'", "SubNum = " & WarehouseShell.SubNum))
            dgvSmokingHistory.DataSource = formTable.Tables("SmokingHistory")
            dgvSmokingHistory.Columns("SmokingHistoryValue").Visible = False
            dgvSmokingHistory.Columns("RecordID").Visible = False
        End If
    End Sub

    Private Sub enableInputFields(ByVal value As Boolean)
        If value = True Then
            txtReportDate.Enabled = True
            comboStatus.Enabled = True
            txtAgeStarted.Enabled = True
            txtDateStopped.Enabled = True
            txtYearsSmoked.Enabled = True
        Else
            txtReportDate.Enabled = False
            comboStatus.Enabled = False
            txtAgeStarted.Enabled = False
            txtDateStopped.Enabled = False
            txtYearsSmoked.Enabled = False
        End If
    End Sub
    Private Sub clearInputFields()
        txtReportDate.Clear()
        comboStatus.SelectedValue = -1
        txtAgeStarted.Clear()
        txtDateStopped.Clear()
        txtYearsSmoked.Clear()
    End Sub

    'Take OnLoad actions
    Private Sub PU_SmokingHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load comboBox lookup (and set default value to -1)
        formTable.Tables.Add(Database.ReturnTable("lkpSmokingHistory"))
        comboStatus.DataSource = formTable.Tables("lkpSmokingHistory")
        comboStatus.ValueMember = "Value"
        comboStatus.DisplayMember = "Label"
        comboStatus.SelectedValue = -1
        enableInputFields(False)
        'Load the data grid view if any SmokingHistory records exist for this subject
        If Database.ExistingRecordCheck("SmokingHistory", "SubNum = " & WarehouseShell.SubNum) Then
            updateDGVData()
            btnEdit.Enabled = True
        Else
            btnEdit.Enabled = False
        End If
    End Sub

    'Define button click events
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        WarehouseShell.LoadWorkingAreaForm(WarehouseShell.formType.WA_Demographics)
        Me.Dispose()
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If editMode = False Then
            editMode = True
            btnEdit.Text = "Save Changes"
            tooltip1.Show("Please make changes above and click ""Save Changes"" when done making changes.", btnEdit, 0, 20, 5000)
            myRecordID = dgvSmokingHistory.SelectedRows(0).Cells("RecordID").Value.ToString
            If IsDate(dgvSmokingHistory.SelectedRows(0).Cells("Report Date").Value) Then
                txtReportDate.Text = dgvSmokingHistory.SelectedRows(0).Cells("Report Date").Value.ToString
            End If
            comboStatus.SelectedValue = dgvSmokingHistory.SelectedRows(0).Cells("SmokingHistoryValue").Value
            txtAgeStarted.Text = dgvSmokingHistory.SelectedRows(0).Cells("Age Started").Value.ToString
            If IsDate(dgvSmokingHistory.SelectedRows(0).Cells("Approx Date Stopped").Value) Then
                txtDateStopped.Text = dgvSmokingHistory.SelectedRows(0).Cells("Approx Date Stopped").Value.ToString
            End If
            txtYearsSmoked.Text = dgvSmokingHistory.SelectedRows(0).Cells("Years Smoked").Value.ToString
            dgvSmokingHistory.Enabled = False
        Else
            Dim updateCommand As New SqlCommand
            Dim returnedValue As Object
            Dim updateString As String = "@RecordID = '" & myRecordID &
                "', @ReportDate = " & txtReportDate.getSQLValue() &
                ", @SmokingHistoryValue = " & comboStatus.getSQLValue() &
                ", @SmokingHistoryLabel = " & comboStatus.getSQLLabel() &
                ", @AgeStarted = " & txtAgeStarted.getSQLValue() &
                ", @DateStopped = " & txtDateStopped.getSQLValue() &
                ", @YearsSmoked = " & txtYearsSmoked.getSQLValue() & ";"
            updateCommand.CommandText = "EXEC dbo.UpdateSmokingHistoryRecord " & updateString
            updateCommand.Connection = WarehouseShell.conn
            returnedValue = updateCommand.ExecuteScalar()
            MessageBox.Show("Changes saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            myRecordID = ""
            updateDGVData()
            btnEdit.Text = "Edit Selected Record"
            btnEdit.Enabled = True
            editMode = False
            dgvSmokingHistory.Enabled = True
            clearInputFields()
            enableInputFields(False)
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If editMode = False Then
            editMode = True
            btnEdit.Enabled = False
            enableInputFields(True)
            tooltip1.Show("Please enter new values in the boxes above and click this button to save the new data.", btnSave, 0, 20, 5000)
            btnSave.Text = "Save"
        Else
            Dim insertCommand As New SqlCommand
            Dim returnedValue As Object
            Dim insertString As String = "@SubNum = " & WarehouseShell.SubNum &
                ", @ReportDate = " & txtReportDate.getSQLValue() &
                ", @SmokingHistoryValue = " & comboStatus.getSQLValue() &
                ", @SmokingHistoryLabel = " & comboStatus.getSQLLabel() &
                ", @AgeStarted = " & txtAgeStarted.getSQLValue() &
                ", @DateStopped = " & txtDateStopped.getSQLValue() &
                ", @YearsSmoked = " & txtYearsSmoked.getSQLValue() & ";"
            insertCommand.CommandText = "EXEC dbo.InsertSmokingHistoryRecord " & insertString
            insertCommand.Connection = WarehouseShell.conn
            returnedValue = insertCommand.ExecuteScalar
            MessageBox.Show("New record saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            updateDGVData()
            clearInputFields()
            editMode = False
            btnSave.Text = "Save New"
            btnEdit.Enabled = True
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
        TopLevel = val
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class