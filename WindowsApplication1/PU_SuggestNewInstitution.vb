Public Class PU_SuggestNewInstitution
    Public RecordID As String = ""
    Public Identifier As String = ""
    Public Form As String = ""
    Public Field As String = ""

    Private Sub PU_SuggestNewInstitution_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enableInputFields()
    End Sub

    Private Sub enableInputFields()
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
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim insertCommand As New SqlCommand("EXEC dbo.InsertInstitutionSuggestionsRecord " &
            "@InstituteName = " & txtName.getSQLValue() &
            ", @Address1 = " & txtAddress1.getSQLValue() &
            ", @Address2 = " & txtAddress2.getSQLValue() &
            ", @Address3 = " & txtAddress3.getSQLValue() &
            ", @Address4 = " & txtAddress4.getSQLValue() &
            ", @City = " & txtCity.getSQLValue() &
            ", @State = " & txtState.getSQLValue() &
            ", @ZIP = " & txtZIP.getSQLValue() &
            ", @POCName = " & txtPOCName.getSQLValue() &
            ", @POCRole = " & txtPOCRole.getSQLValue() &
            ", @Telephone = " & txtTelephone.getSQLValue() &
            ", @Fax = " & txtFax.getSQLValue() &
            ", @Notes = " & txtNotes.getSQLValue() &
            ", @UserName = '" & WarehouseShell.userName &
            "', @Instrument = '" & Form &
            "', @Identifier = '" & Identifier &
            "', @Field = '" & Field & "';", WarehouseShell.conn)
            insertCommand.ExecuteScalar()
            MessageBox.Show("Your request has been submitted for approval.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.Dispose()
        Catch ex As SqlException
            ExceptionHandler.CatchSQLException(ex)
        End Try
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
End Class