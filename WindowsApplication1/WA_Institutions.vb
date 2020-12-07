Public Class WA_Institutions
    Implements IFormMethods
    Private formTables As New DataSet
    Private myBindingSource As New BindingSource
    Private RecordID As String = ""

    Private Sub WA_Institutions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enableInputFields(False)
        txtFilter.Focus()
        formTables.Tables.Add(Database.ReturnTable("refInstitution", "InstitutionID, Name as Institute, Address1, Address2, Address3, Address4, City, State, ZIP " & _
            "as Zip, POCName as 'POC Name', POCRole as 'POC Role', Telephone, Fax, Notes"))
        myBindingSource.DataSource = formTables.Tables("lkpINstitution")
        dgvInstitutions.DataSource = myBindingSource
        dgvInstitutions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvInstitutions.Columns("InstitutionID").Visible = False
        dgvInstitutions.Columns("Address1").Visible = False
        dgvInstitutions.Columns("Address2").Visible = False
        dgvInstitutions.Columns("Address3").Visible = False
        dgvInstitutions.Columns("Address4").Visible = False
        dgvInstitutions.Columns("State").Visible = False
        dgvInstitutions.Columns("Zip").Visible = False
        dgvInstitutions.Columns("Fax").Visible = False
        dgvInstitutions.Columns("Notes").Visible = False
        btnEdit.Visible = False
        If User.CheckPermission("EditInstitutionList") = True Then
            btnAdd.Enabled = True
        End If
    End Sub
    'DGV subs
    Private Sub txtFilter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFilter.KeyDown
        'If the user presses the Enter key while in the filter text box, apply filter
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If txtFilter.Text = "" Then
                myBindingSource.Filter = ""
            Else
                Dim myFilter As String = txtFilter.Text
                myBindingSource.Filter = "Institute like '%" & myFilter & "%' or City like '%" & myFilter & "%' or [POC Name] like '%" & myFilter & "%' or [POC Role] like '%" & _
                    myFilter & "%' or Telephone like '%" & myFilter & "%'"
            End If
        End If
    End Sub
    Private Sub dgvInstitutions_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInstitutions.CellDoubleClick
        'Check for potentially unsaved work and allow user to decide how to proceed.
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit Or WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
            Dim checkform As New PU_SaveWork
            Dim myResult As DialogResult = checkform.ShowDialog
            checkform.Dispose()
            If myResult = Windows.Forms.DialogResult.OK Then
                SaveWork()
            ElseIf myResult = DialogResult.Cancel Then
                Exit Sub
            End If
        End If
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        enableInputFields(False)
        If User.CheckPermission("EditInstitutionList") = True Then
            btnEdit.Visible = True
        End If
        btnEdit.Visible = True
        RecordID = dgvInstitutions.SelectedRows(0).Cells("InstitutionID").Value.ToString()
        txtInstitute.Text = dgvInstitutions.SelectedRows(0).Cells("Institute").Value.ToString()
        txtAddress1.Text = dgvInstitutions.SelectedRows(0).Cells("Address1").Value.ToString()
        txtAddress2.Text = dgvInstitutions.SelectedRows(0).Cells("Address2").Value.ToString()
        txtAddress3.Text = dgvInstitutions.SelectedRows(0).Cells("Address3").Value.ToString()
        txtAddress4.Text = dgvInstitutions.SelectedRows(0).Cells("Address4").Value.ToString()
        txtCity.Text = dgvInstitutions.SelectedRows(0).Cells("City").Value.ToString()
        txtState.Text = dgvInstitutions.SelectedRows(0).Cells("State").Value.ToString()
        txtZip.Text = dgvInstitutions.SelectedRows(0).Cells("Zip").Value.ToString()
        txtPOCName.Text = dgvInstitutions.SelectedRows(0).Cells("POC Name").Value.ToString()
        txtPOCRole.Text = dgvInstitutions.SelectedRows(0).Cells("POC Role").Value.ToString()
        txtTelephone.Text = dgvInstitutions.SelectedRows(0).Cells("Telephone").Value.ToString()
        txtFax.Text = dgvInstitutions.SelectedRows(0).Cells("Fax").Value.ToString()
        txtNotes.Text = dgvInstitutions.SelectedRows(0).Cells("Notes").Value.ToString()
    End Sub
    'Data entry field subs
    Private Sub enableInputFields(ByVal value As Boolean)
        If value = True Then
            txtInstitute.Enabled = True
            txtAddress1.Enabled = True
            txtAddress2.Enabled = True
            txtAddress3.Enabled = True
            txtAddress4.Enabled = True
            txtCity.Enabled = True
            txtState.Enabled = True
            txtZip.Enabled = True
            txtPOCName.Enabled = True
            txtPOCRole.Enabled = True
            txtTelephone.Enabled = True
            txtFax.Enabled = True
            txtNotes.Enabled = True
        Else
            txtInstitute.Enabled = False
            txtAddress1.Enabled = False
            txtAddress2.Enabled = False
            txtAddress3.Enabled = False
            txtAddress4.Enabled = False
            txtCity.Enabled = False
            txtState.Enabled = False
            txtZip.Enabled = False
            txtPOCName.Enabled = False
            txtPOCRole.Enabled = False
            txtTelephone.Enabled = False
            txtFax.Enabled = False
            txtNotes.Enabled = False
        End If
    End Sub
    Private Sub clearInputFields()
        txtInstitute.Text = ""
        txtAddress1.Text = ""
        txtAddress2.Text = ""
        txtAddress3.Text = ""
        txtAddress4.Text = ""
        txtCity.Text = ""
        txtState.Text = ""
        txtZip.Text = ""
        txtPOCName.Text = ""
        txtPOCRole.Text = ""
        txtTelephone.Text = ""
        txtFax.Text = ""
        txtNotes.Text = ""
    End Sub
    'Button click events
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit Then
            'Check for potentially unsaved work and allow user to decide how to proceed.
            Dim checkform As New PU_SaveWork
            Dim myResult As DialogResult = checkform.ShowDialog
            checkform.Dispose()
            If myResult = Windows.Forms.DialogResult.OK Then
                SaveWork()
            ElseIf myResult = DialogResult.Cancel Then
                Exit Sub
            End If
            'Set the data mode to insert
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
            'Clear the input fields
            clearInputFields()
            'Hide the edit button and update the add button text
            btnEdit.Visible = False
            btnAdd.Text = "Save New Record"
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            clearInputFields()
            enableInputFields(True)
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
            'Hide the edit button and update the add button text
            btnEdit.Visible = False
            btnAdd.Text = "Save New Record"
        Else
            Try
                Dim cmd As New SqlCommand("Exec InsertrefInstitutionRecord" &
                    " @Name = " & txtInstitute.getSQLValue() &
                    ", @Address1 = " & txtAddress1.getSQLValue() &
                    ", @Address2 = " & txtAddress2.getSQLValue() &
                    ", @Address3 = " & txtAddress3.getSQLValue() &
                    ", @Address4 = " & txtAddress4.getSQLValue() &
                    ", @City = " & txtCity.getSQLValue() &
                    ", @State = " & txtState.getSQLValue() &
                    ", @Zip = " & txtZip.getSQLValue() &
                    ", @POCName = " & txtPOCName.getSQLValue() &
                    ", @POCRole = " & txtPOCRole.getSQLValue() &
                    ", @Telephone = " & txtTelephone.getSQLValue() &
                    ", @Fax = " & txtFax.getSQLValue() &
                    ", @Notes = " & txtNotes.getSQLValue() & ";", WarehouseShell.conn)
                cmd.ExecuteScalar()
                MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                WarehouseShell.LoadWorkingAreaForm(WarehouseShell.formType.WA_Institutions)
            Catch ex As SqlException
                ExceptionHandler.CatchSQLException(ex)
            End Try
        End If
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
            enableInputFields(True)
            btnEdit.Text = "Save Changes"
            btnAdd.Visible = False
        Else 'DataMode must be in Edit mode
            Try
                Dim cmd As New SqlCommand("Exec UpdaterefInstitutionRecord " &
                    "@InstitutionID = '" & RecordID &
                    "', @Name = " & txtInstitute.getSQLValue() &
                    ", @Address1 = " & txtAddress1.getSQLValue() &
                    ", @Address2 = " & txtAddress2.getSQLValue() &
                    ", @Address3 = " & txtAddress3.getSQLValue() &
                    ", @Address4 = " & txtAddress4.getSQLValue() &
                    ", @City = " & txtCity.getSQLValue() &
                    ", @State = " & txtState.getSQLValue() &
                    ", @Zip = " & txtZip.getSQLValue() &
                    ", @POCName = " & txtPOCName.getSQLValue() &
                    ", @POCRole = " & txtPOCRole.getSQLValue() &
                    ", @Telephone = " & txtTelephone.getSQLValue() &
                    ", @Fax = " & txtFax.getSQLValue() &
                    ", @Notes = " & txtNotes.getSQLValue() & ";", WarehouseShell.conn)
                cmd.ExecuteScalar()
                MessageBox.Show("Record was successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                enableInputFields(False)
                WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                btnEdit.Text = "Edit Selected Record"
                btnAdd.Visible = True
            Catch ex As SqlException
                ExceptionHandler.CatchSQLException(ex)
            End Try
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
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
            btnAdd.PerformClick()
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit Then
            btnEdit.PerformClick()
        End If
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class