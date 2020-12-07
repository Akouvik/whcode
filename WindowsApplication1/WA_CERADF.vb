Public Class WA_CERADF
    Implements IFormMethods
    Private formTables As New DataSet
    Private errorMessage As String = ""

    'Load form subs
    Private Sub WA_CERADF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_CERADF")
        If Database.ExistingRecordCheck("CERADF", "SubNum = " & WarehouseShell.SubNum) = True Then
            loadBaseForm()
            enableInputFields(False)
            loadExistingData()
            btnCERADFBottom.Text = "Edit this record"
            btnCERADFTop.Text = btnCERADFBottom.Text
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            btnCERADFTop.Focus()
        Else
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            btnCERADFTop.Text = "Add New Record"
            btnCERADFBottom.Text = btnCERADFTop.Text
            enableInputFields(False)
            lblNoRecord.Visible = True
        End If
    End Sub
    Private Sub loadBaseForm()
        'Load all required lookup tables into the comboValues DataSet
        formTables.Tables.Add(Database.ReturnTable("lkpCERADNYUnk019"))
        'Assign lookup values to each individual combobox
        comboAbnormalities.assignLookup(formTables, "lkpCERADNYUnk019")
    End Sub
    Private Sub defaultValues()
        'Set Abnormalities combo box to 0 (No)
        comboAbnormalities.SelectedValue = 0
    End Sub
    Private Sub loadExistingData()
        'Grab the CERADF record for this SubNum
        formTables.Tables.Add(Database.ReturnTable("CERADF", , "SubNum = " & WarehouseShell.SubNum))
        'Apply the existing values to the input fields
        comboAbnormalities.setValue(formTables, "CERADF", "Abnormalities")
        txtAbnormalA.setValue(formTables, "CERADF", "AbnormalityANote")
        txtAbnormalALocation.setValue(formTables, "CERADF", "AbnormalityALoc")
        txtAbnormalB.setValue(formTables, "CERADF", "AbnormalityBNote")
        txtAbnormalBLocation.setValue(formTables, "CERADF", "AbnormalityBLoc")
        txtAbnormalC.setValue(formTables, "CERADF", "AbnormalityCNote")
        txtAbnormalCLocation.setValue(formTables, "CERADF", "AbnormalityCLoc")
    End Sub

    'Subs to enable-disable fields during data input based on conditional logic.
    Private Sub enableInputFields(ByVal value As Boolean)
        If value = True Then
            comboAbnormalities.Enabled = True
        Else
            comboAbnormalities.Enabled = False
            txtAbnormalA.Enabled = False
            txtAbnormalALocation.Enabled = False
            txtAbnormalB.Enabled = False
            txtAbnormalBLocation.Enabled = False
            txtAbnormalC.Enabled = False
            txtAbnormalCLocation.Enabled = False
        End If
    End Sub
    Private Sub comboAbnormalities_LostFocus(sender As Object, e As EventArgs) Handles comboAbnormalities.LostFocus
        If comboAbnormalities.SelectedValue = 1 Then
            txtAbnormalA.Enabled = True
            txtAbnormalA.Focus()
        Else
            txtAbnormalA.Clear()
            txtAbnormalA.Enabled = False
            txtAbnormalALocation.Clear()
            txtAbnormalALocation.Enabled = False
            txtAbnormalB.Clear()
            txtAbnormalB.Enabled = False
            txtAbnormalBLocation.Clear()
            txtAbnormalBLocation.Enabled = False
            txtAbnormalC.Clear()
            txtAbnormalC.Enabled = False
            txtAbnormalCLocation.Clear()
            txtAbnormalCLocation.Enabled = False
        End If
    End Sub
    Private Sub txtAbnormalA_LostFocus(sender As Object, e As EventArgs) Handles txtAbnormalA.LostFocus
        If txtAbnormalA.Text <> "" Then
            txtAbnormalALocation.Enabled = True
            txtAbnormalB.Enabled = True
            txtAbnormalALocation.Focus()
        Else
            txtAbnormalALocation.Clear()
            txtAbnormalALocation.Enabled = False
            txtAbnormalB.Clear()
            txtAbnormalB.Enabled = False
            txtAbnormalBLocation.Clear()
            txtAbnormalBLocation.Enabled = False
            txtAbnormalC.Clear()
            txtAbnormalC.Enabled = False
            txtAbnormalCLocation.Clear()
            txtAbnormalCLocation.Enabled = False
            btnCERADFBottom.Focus()
        End If
    End Sub
    Private Sub txtAbnormalB_LostFocus(sender As Object, e As EventArgs) Handles txtAbnormalB.LostFocus
        If txtAbnormalB.Text <> "" Then
            txtAbnormalBLocation.Enabled = True
            txtAbnormalC.Enabled = True
            txtAbnormalBLocation.Focus()
        Else
            txtAbnormalBLocation.Clear()
            txtAbnormalBLocation.Enabled = False
            txtAbnormalC.Clear()
            txtAbnormalC.Enabled = False
            txtAbnormalCLocation.Clear()
            txtAbnormalCLocation.Enabled = False
            btnCERADFBottom.Focus()
        End If
    End Sub
    Private Sub txtAbnormalC_LostFocus(sender As Object, e As EventArgs) Handles txtAbnormalC.LostFocus
        If txtAbnormalC.Text <> "" Then
            txtAbnormalCLocation.Enabled = True
            txtAbnormalCLocation.Focus()
        Else
            txtAbnormalCLocation.Clear()
            txtAbnormalCLocation.Enabled = False
            btnCERADFBottom.Focus()
        End If
    End Sub

    'Define button click events
    Private Sub btnCERADF_Click(sender As Object, e As EventArgs) Handles btnCERADFBottom.Click, btnCERADFTop.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_CERADF", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                enableInputFields(True)
                btnCERADFBottom.Text = "Save changes"
                btnCERADFTop.Text = btnCERADFBottom.Text
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If Database.ExistingRecordCheck("CERAD_Header", "SubNum = " & WarehouseShell.SubNum) Then
                If User.PermissionCheck("WA_CERADF", "Modify") Then
                    WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
                    loadBaseForm()
                    defaultValues()
                    enableInputFields(True)
                    btnCERADFBottom.Text = "Save new record"
                    btnCERADFTop.Text = btnCERADFBottom.Text
                    lblNoRecord.Visible = False
                End If
            Else
                MsgBox("Please create a CERAD Header for this subject before attempting to add CERAD information.", MsgBoxStyle.OkOnly, "Error!")
            End If
        Else
            If preSaveValidation() Then
                Dim sqlCommand As New SqlCommand
                sqlCommand.Connection = WarehouseShell.conn
                Dim cmdString = "@SubNum = " & WarehouseShell.SubNum &
                    ", @Abnormalities = " & comboAbnormalities.getSQLValue() &
                    ", @AbnormalityANote = " & txtAbnormalA.getSQLValue() &
                    ", @AbnormalityALoc = " & txtAbnormalALocation.getSQLValue() &
                    ", @AbnormalityBNote = " & txtAbnormalB.getSQLValue() &
                    ", @AbnormalityBLoc = " & txtAbnormalBLocation.getSQLValue() &
                    ", @AbnormalityCNote = " & txtAbnormalC.getSQLValue() &
                    ", @AbnormalityCLoc = " & txtAbnormalCLocation.getSQLValue() & ";"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    sqlCommand.CommandText = "EXEC dbo.modCERADFRecord @Action = 1, " & cmdString
                    Try
                        sqlCommand.ExecuteNonQuery()
                        MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        enableInputFields(False)
                        btnCERADFBottom.Text = "Edit this record"
                        btnCERADFTop.Text = btnCERADFBottom.Text
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else
                    sqlCommand.CommandText = "EXEC dbo.modCERADFRecord @Action = 2, " & cmdString
                    Try
                        sqlCommand.ExecuteNonQuery()
                        MessageBox.Show("Record successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        enableInputFields(False)
                        btnCERADFBottom.Text = "Edit this record"
                        btnCERADFTop.Text = btnCERADFBottom.Text
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                End If
            Else
                MsgBox(errorMessage & vbNewLine & vbNewLine & "These errors must be corrected before the record can be saved.", MsgBoxStyle.Exclamation, "Input Validation Error")
            End If
        End If
    End Sub
    Private Function preSaveValidation() As Boolean
        Dim result As Boolean = True
        Return result
    End Function

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
        btnCERADFBottom.PerformClick()
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class