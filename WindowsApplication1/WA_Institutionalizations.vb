Public Class WA_Institutionalizations
    Implements IFormMethods
    Private formTables As New DataSet

    'Sub to enable input/edit fields. Also clears fields on False!
    Private Sub enableInputFields(ByVal value As Boolean)
        If value = True Then
            comboInstitution.Enabled = True
            txtSubjectInstID.Enabled = True
            txtWard.Enabled = True
            txtFloor.Enabled = True
            txtRoom.Enabled = True
            txtStartDate.Enabled = True
            txtEndDate.Enabled = True
            txtComment.Enabled = True
            btnSave.Enabled = True
        ElseIf value = False Then
            comboInstitution.Enabled = False
            comboInstitution.SelectedIndex = -1
            txtSubjectInstID.Enabled = False
            txtSubjectInstID.Clear()
            txtWard.Enabled = False
            txtWard.Clear()
            txtFloor.Enabled = False
            txtFloor.Clear()
            txtRoom.Enabled = False
            txtRoom.Clear()
            txtStartDate.Enabled = False
            txtStartDate.Clear()
            txtEndDate.Enabled = False
            txtEndDate.Clear()
            txtComment.Enabled = False
            txtComment.Clear()
            btnSave.Enabled = False
        End If
    End Sub

    'Always loads form in same mode (because form shows existing records and allows user to add/edit records from functions inside form)
    Private Sub WA_PMCRInstitutionalizations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formTables.Tables.Add(Database.ReturnTable("viewInstitutionalizations", "InstitutionalizationID, InstitutionID, Name, InstitutionAssignedID as 'Subject Inst ID', Ward, Floor, Room, " &
                                                                              "StartDate as 'Start Date', EndDate as 'End Date', Comment", "SubNum = " & WarehouseShell.SubNum))
        dgvInstitutionalizations.DataSource = formTables.Tables("viewInstitutionalizations")
        enableInputFields(False)
        'Disable the btnEdit if no Institutionalization records are returned for this subject.
        'This stops the application from throwing an error if the user clicks btnEdit and there is no record selected in the DateGridView.
        If Database.ExistingRecordCheck("Institutionalizations", "SubNum = " & WarehouseShell.SubNum) = False Then
            btnEdit.Enabled = False
        End If
    End Sub

    'Define button click events
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim row As DataGridViewRow = dgvInstitutionalizations.SelectedRows(0)
        IIf(row.Cells("Name").Value Is Nothing, vbOK, comboInstitution.SelectedValue = row.Cells("Name").Value)
        IIf(row.Cells("Subject Inst ID").Value Is Nothing, vbOK, txtSubjectInstID.Text = row.Cells("Subject Inst ID").Value)
        IIf(row.Cells("Ward").Value Is Nothing, vbOK, txtWard.Text = row.Cells("Ward").Value)
        IIf(row.Cells("Floor").Value Is Nothing, vbOK, txtFloor.Text = row.Cells("Floor").Value)
        IIf(row.Cells("Room").Value Is Nothing, vbOK, txtRoom.Text = row.Cells("Room").Value)
        IIf(row.Cells("Start Date").Value Is Nothing, vbOK, txtStartDate.Text = row.Cells("Start Date").Value)
        IIf(row.Cells("End Date").Value Is Nothing, vbOK, txtEndDate.Text = row.Cells("End Date").Value)
        IIf(row.Cells("Comment").Value Is Nothing, vbOK, txtComment.Text = row.Cells("Comment").Value)
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
        btnSave.PerformClick()
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class