Public Class WA_CERADH
    Implements IFormMethods
    Private insertString As String = Nothing
    Private updateString As String = Nothing
    Private formTables As New DataSet
    Private tooltip1 As New ToolTip

    'Load form subs
    Private Sub WA_CERADH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_CERADH")
        If Database.ExistingRecordCheck("CERADH", "SubNum = " & WarehouseShell.SubNum) = True Then
            loadBaseForm()
            enableInputFields(False)
            loadExistingData()
            btnCERADHBottom.Text = "Edit this record"
            btnCERADHTop.Text = btnCERADHBottom.Text
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            btnCERADHTop.Focus()
        Else
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            btnCERADHTop.Text = "Add New Record"
            btnCERADHBottom.Text = btnCERADHTop.Text
            enableInputFields(False)
            lblNoRecord.Visible = True
        End If
    End Sub
    Private Sub loadBaseForm()
        'Load all required lookup tables into the comboValues DataSet
        formTables.Tables.Add(Database.ReturnTable("lkpCERADAgePlaqueScore"))
        formTables.Tables.Add(Database.ReturnTable("lkpCERADNYUnk019"))
        'Assign lookup values to each individual combobox
        assignComboLookups(comboPlaqueScore, "lkpCERADAgePlaqueScore")
        assignComboLookups(comboHippoChanges, "lkpCERADNYUnk019")
        assignComboLookups(comboEntorChanges, "lkpCERADNYUnk019")
        assignComboLookups(comboTangleFrequency, "lkpCERADNYUnk019")
        assignComboLookups(comboOtherCriteria, "lkpCERADNYUnk019")
    End Sub
    Private Sub assignComboLookups(ByVal ComboName As ComboBox, ByVal tableName As String)
        ComboName.DataSource = New DataView(formTables.Tables(tableName))
        ComboName.DisplayMember = "Label"
        ComboName.ValueMember = "Value"
    End Sub
    Private Sub defaultValues()
        'Set all of the combo boxes to No/None
        comboPlaqueScore.SelectedValue = "-1"
        comboHippoChanges.SelectedValue = 0
        comboEntorChanges.SelectedValue = 0
        comboTangleFrequency.SelectedValue = 0
        comboOtherCriteria.SelectedValue = 0
    End Sub
    Private Sub loadExistingData()
        'Grab the CERADH record for this SubNum
        formTables.Tables.Add(Database.ReturnTable("CERADH", , "SubNum = " & WarehouseShell.SubNum))
        'Apply the existing values to the input fields
        comboPlaqueScore.SelectedValue = formTables.Tables("CERADH").Rows(0).Item("PlaqueScore") 'literal values for combo boxes
        If formTables.Tables("CERADH").Rows(0).Item("Frontal").ToString = "1" Then
            chkFrontal.Checked = True
        Else
            chkFrontal.Checked = False
        End If
        If formTables.Tables("CERADH").Rows(0).Item("Parietal").ToString = "1" Then
            chkParietal.Checked = True
        Else
            chkParietal.Checked = False
        End If
        If formTables.Tables("CERADH").Rows(0).Item("Temporal").ToString = "1" Then
            chkTemporal.Checked = True
        Else
            chkTemporal.Checked = False
        End If
        comboHippoChanges.SelectedValue = formTables.Tables("CERADH").Rows(0).Item("HippoChanges")
        comboEntorChanges.SelectedValue = formTables.Tables("CERADH").Rows(0).Item("EntorChanges")
        comboTangleFrequency.SelectedValue = formTables.Tables("CERADH").Rows(0).Item("TangleFreq")
        comboOtherCriteria.SelectedValue = formTables.Tables("CERADH").Rows(0).Item("OtherCriteria")
        txtOtherCriteriaNote.Text = formTables.Tables("CERADH").Rows(0).Item("OtherCriteriaNote").ToString 'string values for text boxes
        txtComments.Text = formTables.Tables("CERADH").Rows(0).Item("Comments").ToString
    End Sub

    'Subs to enable-disable fields during data input based on conditional logic.
    Private Sub enableInputFields(ByVal value As Boolean)
        If value = True Then
            comboPlaqueScore.Enabled = True
            chkFrontal.Enabled = True
            chkParietal.Enabled = True
            chkTemporal.Enabled = True
            comboHippoChanges.Enabled = True
            comboEntorChanges.Enabled = True
            comboTangleFrequency.Enabled = True
            comboOtherCriteria.Enabled = True
            txtOtherCriteriaNote.Enabled = True
            txtComments.Enabled = True
        Else
            comboPlaqueScore.Enabled = False
            chkFrontal.Enabled = False
            chkParietal.Enabled = False
            chkTemporal.Enabled = False
            comboHippoChanges.Enabled = False
            comboEntorChanges.Enabled = False
            comboTangleFrequency.Enabled = False
            comboOtherCriteria.Enabled = False
            txtOtherCriteriaNote.Enabled = False
            txtComments.Enabled = False
        End If
    End Sub
    Private Sub comboPlaqueScore_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboPlaqueScore.SelectedValueChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View And WarehouseShell.DataMode <> WarehouseShell.userDataMode.Undefined Then
            If comboPlaqueScore.SelectedValue.ToString <> "C" And comboPlaqueScore.SelectedValue.ToString <> "-1" Then
                tooltip1.Show("Please make sure to select ""Yes"" or ""No"" for each of the 4 dropdown boxes below (no Blanks/Unknowns allowed).", comboPlaqueScore, 0, 20, 3000)
            End If
        End If
    End Sub

    'Define button click events
    Private Sub btnCERADH_Click(sender As Object, e As EventArgs) Handles btnCERADHBottom.Click, btnCERADHTop.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_CERADH", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                enableInputFields(True)
                btnCERADHBottom.Text = "Save changes"
                btnCERADHTop.Text = btnCERADHBottom.Text
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If Database.ExistingRecordCheck("CERAD_Header", "SubNum = " & WarehouseShell.SubNum) Then
                If User.PermissionCheck("WA_CERADH", "Modify") Then
                    loadBaseForm()
                    defaultValues()
                    enableInputFields(True)
                    btnCERADHBottom.Text = "Save new record"
                    btnCERADHTop.Text = btnCERADHBottom.Text
                    lblNoRecord.Visible = False
                    WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
                End If
            Else
                MsgBox("Please create a CERAD Header for this subject before attempting to add CERAD information.", MsgBoxStyle.OkOnly, "Error!")
            End If
        Else
            If preSaveValidation() Then
                Dim sqlCommand As New SqlCommand
                sqlCommand.Connection = WarehouseShell.conn
                Dim cmdString = "@SubNum = " & WarehouseShell.SubNum &
                        ", @PlaqueScore = " & comboPlaqueScore.getSQLValue() &
                        ", @Frontal = " & chkFrontal.getSQLValue() &
                        ", @Parietal = " & chkParietal.getSQLValue() &
                        ", @Temporal = " & chkTemporal.getSQLValue() &
                        ", @HippoChanges = " & comboHippoChanges.getSQLValue() &
                        ", @EntorChanges = " & comboEntorChanges.getSQLValue() &
                        ", @TangleFreq = " & comboTangleFrequency.getSQLValue() &
                        ", @OtherCriteria = " & comboOtherCriteria.getSQLValue() &
                        ", @OtherCriteriaNote = " & txtOtherCriteriaNote.getSQLValue() &
                        ", @Comments = " & txtComments.getSQLValue() & ";"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    sqlCommand.CommandText = "EXEC dbo.modCERADHRecord @Action = 1, " & cmdString
                    Try
                        sqlCommand.ExecuteNonQuery()
                        MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        enableInputFields(False)
                        btnCERADHBottom.Text = "Edit this record"
                        btnCERADHTop.Text = btnCERADHBottom.Text
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else
                    sqlCommand.CommandText = "EXEC dbo.modCERADHRecord @Action = 2, " & cmdString
                    Try
                        sqlCommand.ExecuteNonQuery()
                        MessageBox.Show("Record successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        enableInputFields(False)
                        btnCERADHBottom.Text = "Edit this record"
                        btnCERADHTop.Text = btnCERADHBottom.Text
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                End If
            End If
        End If
    End Sub

    Private Function preSaveValidation() As Boolean
        Dim result As Boolean = True
        Dim errorMessage As String = ""

        'Make sure a score is selected
        If comboPlaqueScore.SelectedValue.ToString = "-1" Then
            errorMessage += "- Please select an Age-Related Plaque Score Result (Section 1)." & vbNewLine
            result = False
        End If

        'Make sure at least one checkbox is checked
        Dim checkCount As Integer = 0
        If chkFrontal.Checked Then
            checkCount += 1
        End If
        If chkParietal.Checked Then
            checkCount += 1
        End If
        If chkTemporal.Checked Then
            checkCount += 1
        End If
        If checkCount = 0 Then
            errorMessage += "- Please select one or more cortical section checkboxes in Section 2." & vbNewLine
            result = False
        End If

        'Check specify dependencies
        If comboOtherCriteria.SelectedValue = 1 And txtOtherCriteriaNote.Text = "" Then
            errorMessage += "- You have selected Yes for Other Criteria without providing a specify note (Section 3). Please add a note or select No in the dropdown box." & vbNewLine
            result = False
        End If
        If comboOtherCriteria.SelectedValue <> 1 And txtOtherCriteriaNote.Text <> "" Then
            errorMessage += "- You have provided an Other Criteria Specify note without selecting Yes in the Other Criteria dowpdown box (Section 3). Please select Yes or clear the note." & vbNewLine
            result = False
        End If

        'Make sure part 3 is done if A or B is selected (-1 handled above)
        If comboPlaqueScore.SelectedValue.ToString <> "C" And comboPlaqueScore.SelectedValue.ToString <> "-1" Then
            If comboHippoChanges.SelectedValue = -1 Or comboHippoChanges.SelectedValue = 9 Then
                errorMessage += "- Section 3: ""Changes in the hippocampus?"" cannot be left blank or unknown" & vbNewLine
                result = False
            End If
            If comboEntorChanges.SelectedValue = -1 Or comboEntorChanges.SelectedValue = 9 Then
                errorMessage += "- Section 3: ""Changes in the entorhinal cortex?"" cannot be left blank or unknown." & vbNewLine
                result = False
            End If
            If comboTangleFrequency.SelectedValue = -1 Or comboTangleFrequency.SelectedValue = 9 Then
                errorMessage += "- Section 3: ""Frequency of neurofibrillary tangles...?"" cannot be left blank or unknown." & vbNewLine
                result = False
            End If
            If comboOtherCriteria.SelectedValue = -1 Or comboOtherCriteria.SelectedValue = 9 Then
                errorMessage += "- Section 3: ""Other criteria (specify)"" cannot be left blank or unknown." & vbNewLine
                result = False
            End If
        End If

        'Handle false result
        If result = False Then
            errorMessage = "The following errors must be corrected before this record can be saved:" & vbNewLine & vbNewLine & errorMessage
            MsgBox(errorMessage, MsgBoxStyle.OkOnly, "Error")
        End If
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
        btnCERADHBottom.PerformClick()
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class