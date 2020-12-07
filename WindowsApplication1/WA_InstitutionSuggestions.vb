Public Class WA_InstitutionSuggestions
    Implements IFormMethods
    Private formTables As New DataSet
    Private myBindingSource As New BindingSource
    Private RecordID As String
    Private ApprovedBy As String

    Private Sub WA_InstitutionSuggestions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnHideApproved.Focus()
        enableInputFields(False)
        formTables.Tables.Add(Database.ReturnTable("InstitutionSuggestions", "RecordID, InstituteName as Institute, Address1, Address2, Address3, Address4, City, State, ZIP " & _
            "as Zip, POCName as 'POC Name', POCRole as 'POC Role', Telephone, Fax, Notes, SuggestedBy as 'Suggested By', Instrument, Identifier, Field, Status"))
        myBindingSource.DataSource = formTables.Tables("InstitutionSuggestions")
        dgvInstitutionSuggestions.DataSource = myBindingSource
        dgvInstitutionSuggestions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvInstitutionSuggestions.Columns("RecordID").Visible = False
        dgvInstitutionSuggestions.Columns("Address1").Visible = False
        dgvInstitutionSuggestions.Columns("Address2").Visible = False
        dgvInstitutionSuggestions.Columns("Address3").Visible = False
        dgvInstitutionSuggestions.Columns("Address4").Visible = False
        dgvInstitutionSuggestions.Columns("State").Visible = False
        dgvInstitutionSuggestions.Columns("Zip").Visible = False
        dgvInstitutionSuggestions.Columns("POC Name").Visible = False
        dgvInstitutionSuggestions.Columns("POC Role").Visible = False
        dgvInstitutionSuggestions.Columns("Telephone").Visible = False
        dgvInstitutionSuggestions.Columns("Fax").Visible = False
        dgvInstitutionSuggestions.Columns("Notes").Visible = False
        dgvInstitutionSuggestions.Columns("Instrument").Visible = False
        dgvInstitutionSuggestions.Columns("Identifier").Visible = False
        dgvInstitutionSuggestions.Columns("Field").Visible = False
    End Sub

    Private Sub enableInputFields(ByVal value As Boolean)
        If value = True Then
            txtName.Enabled = True
            txtAddress1.Enabled = True
            txtAddress2.Enabled = True
            txtAddress3.Enabled = True
            txtAddress4.Enabled = True
            txtCity.Enabled = True
            txtState.Enabled = True
            txtZIP.Enabled = True
            txtPOCName.Enabled = True
            txtPOCRole.Enabled = True
            txtTelephone.Enabled = True
            txtFax.Enabled = True
            txtNotes.Enabled = True
            txtDenyMessage.Enabled = True
        Else
            txtName.Enabled = False
            txtAddress1.Enabled = False
            txtAddress2.Enabled = False
            txtAddress3.Enabled = False
            txtAddress4.Enabled = False
            txtCity.Enabled = False
            txtState.Enabled = False
            txtZIP.Enabled = False
            txtPOCName.Enabled = False
            txtPOCRole.Enabled = False
            txtTelephone.Enabled = False
            txtFax.Enabled = False
            txtNotes.Enabled = False
            txtDenyMessage.Enabled = False
        End If
    End Sub

    'Define click events
    Private Sub dgvInstitutionSuggestions_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInstitutionSuggestions.CellDoubleClick
        RecordID = dgvInstitutionSuggestions.SelectedRows(0).Cells("RecordID").Value.ToString()
        txtName.Text = dgvInstitutionSuggestions.SelectedRows(0).Cells("Institute").Value.ToString()
        txtAddress1.Text = dgvInstitutionSuggestions.SelectedRows(0).Cells("Address1").Value.ToString()
        txtAddress2.Text = dgvInstitutionSuggestions.SelectedRows(0).Cells("Address2").Value.ToString()
        txtAddress3.Text = dgvInstitutionSuggestions.SelectedRows(0).Cells("Address3").Value.ToString()
        txtAddress4.Text = dgvInstitutionSuggestions.SelectedRows(0).Cells("Address4").Value.ToString()
        txtCity.Text = dgvInstitutionSuggestions.SelectedRows(0).Cells("City").Value.ToString()
        txtState.Text = dgvInstitutionSuggestions.SelectedRows(0).Cells("State").Value.ToString()
        txtZIP.Text = dgvInstitutionSuggestions.SelectedRows(0).Cells("Zip").Value.ToString()
        txtPOCName.Text = dgvInstitutionSuggestions.SelectedRows(0).Cells("POC Name").Value.ToString()
        txtPOCRole.Text = dgvInstitutionSuggestions.SelectedRows(0).Cells("POC Role").Value.ToString()
        txtTelephone.Text = dgvInstitutionSuggestions.SelectedRows(0).Cells("Telephone").Value.ToString()
        txtFax.Text = dgvInstitutionSuggestions.SelectedRows(0).Cells("Fax").Value.ToString()
        txtNotes.Text = dgvInstitutionSuggestions.SelectedRows(0).Cells("Notes").Value.ToString()
        txtSuggestedBy.Text = dgvInstitutionSuggestions.SelectedRows(0).Cells("Suggested By").Value.ToString()
        txtFromForm.Text = dgvInstitutionSuggestions.SelectedRows(0).Cells("Instrument").Value.ToString()
        txtIdentifier.Text = dgvInstitutionSuggestions.SelectedRows(0).Cells("Identifier").Value.ToString()
        txtFromField.Text = dgvInstitutionSuggestions.SelectedRows(0).Cells("Field").Value.ToString()
        If dgvInstitutionSuggestions.SelectedRows(0).Cells("Status").Value.ToString() = "" Then
            btnApprove.Enabled = True
            btnDeny.Enabled = True
            enableInputFields(True)
        Else
            btnApprove.Enabled = False
            btnDeny.Enabled = False
            enableInputFields(False)
        End If
    End Sub
    Private Sub btnHideApproved_Click(sender As Object, e As EventArgs) Handles btnHideApproved.Click
        If btnHideApproved.Text = "Hide Resolved" Then
            myBindingSource.Filter = "Resolved = 'No'"
            btnHideApproved.Text = "Show Resolved"
        Else
            myBindingSource.Filter = ""
            btnHideApproved.Text = "Hide Resolved"
        End If
    End Sub
    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        'Grab the approver's Name from the refUser table
        Try
            Dim cmd As New SqlCommand("Select Name from refUser where UserName = '" & WarehouseShell.userName & "';", WarehouseShell.conn)
            ApprovedBy = cmd.ExecuteScalar()
            cmd.CommandText = "Exec ApproveInstitutionSuggestionRecord" &
                " @RecordID = " & RecordID &
                ", @InstituteName = " & txtName.getSQLValue() &
                ", @Address1 = " & txtAddress1.getSQLValue() &
                ", @Address2 = " & txtAddress2.getSQLValue() &
                ", @Address3 = " & txtAddress3.getSQLValue() &
                ", @Address4 = " & txtAddress4.getSQLValue() &
                ", @City = " & txtCity.getSQLValue() &
                ", @State = " & txtState.getSQLValue() &
                ", @Zip = " & txtZIP.getSQLValue() &
                ", @POCName = " & txtPOCName.getSQLValue() &
                ", @POCRole = " & txtPOCRole.getSQLValue() &
                ", @Telephone = " & txtTelephone.getSQLValue() &
                ", @Fax = " & txtFax.getSQLValue() &
                ", @Notes = " & txtNotes.getSQLValue() &
                ", @SuggestedBy = " & txtSuggestedBy.getSQLValue() &
                ", @Instrument = " & txtFromForm.getSQLValue() &
                ", @Identifier = " & txtIdentifier.getSQLValue() &
                ", @Field = " & txtFromField.getSQLValue() &
                ", @ApprovedBy = '" & ApprovedBy & "';"
            cmd.ExecuteScalar()
            MessageBox.Show("New Institution successfully added to Institution look-up list", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            WarehouseShell.LoadWorkingAreaForm(WarehouseShell.formType.WA_InstitutionSuggestions)
        Catch ex As SqlException
            ExceptionHandler.CatchSQLException(ex)
        End Try
    End Sub
    Private Sub btnDeny_Click(sender As Object, e As EventArgs) Handles btnDeny.Click
        Try
            Dim cmd As New SqlCommand("Exec DenyInstitutionSuggestionRecord" &
                " @RecordID = " & RecordID &
                ", @RequestedBy = " & txtSuggestedBy.getSQLValue() &
                ", @DeniedBy = '" & WarehouseShell.userName &
                "', @DenialMessage = " & IIf(txtDenyMessage.Text = "", "''", "'" & Replace(txtDenyMessage.Text, "'", "''") & "'") &
                ";", WarehouseShell.conn)
            cmd.ExecuteScalar()
            MessageBox.Show("Suggestion successfully denied.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            WarehouseShell.LoadWorkingAreaForm(WarehouseShell.formType.WA_InstitutionSuggestions)
        Catch ex As SqlException
            ExceptionHandler.CatchSQLException(ex)
        End Try
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