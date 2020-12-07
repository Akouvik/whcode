Public Class WA_CERADE
    Implements IFormMethods
    Private insertString As String = Nothing
    Private updateString As String = Nothing
    Private formTables As New DataSet
    Private tooltip1 As New ToolTip
    Private errorMessage As String = ""

    'Load form and set data mode
    Private Sub WA_CERADE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_CERADE")
        If Database.ExistingRecordCheck("CERADE", "SubNum = " & WarehouseShell.SubNum) = True Then
            loadBaseForm()
            enableInputFields(False)
            loadExistingData()
            btnCERADEBottom.Text = "Edit this record"
            btnCERADETop.Text = btnCERADEBottom.Text
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            btnCERADETop.Focus()
        Else
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            btnCERADETop.Text = "Add New Record"
            btnCERADEBottom.Text = btnCERADETop.Text
            enableInputFields(False)
            lblNoRecord.Visible = True
        End If
    End Sub
    Private Sub loadBaseForm()
        'Load all required lookup tables into the comboValues DataSet
        formTables.Tables.Add(Database.ReturnTable("lkpCERADNYUnk019"))
        formTables.Tables.Add(Database.ReturnTable("lkpCERADStainPallor"))
        'Assign lookup values to each individual combobox
        assignComboLookups(comboArteriosclerosis, "lkpCERADNYUnk019")
        assignComboLookups(comboArteriolarsclerosis, "lkpCERADNYUnk019")
        assignComboLookups(comboOtherMicroscopic, "lkpCERADNYUnk019")
        assignComboLookups(comboMicroinfarcts, "lkpCERADNYUnk019")
        assignComboLookups(comboWhiteMatterDiffusePallor, "lkpCERADNYUnk019")
        assignComboLookups(comboWhiteMatterStain, "lkpCERADStainPallor")
        assignComboLookups(comboOccipital, "lkpCERADNYUnk019")
        assignComboLookups(comboParietal, "lkpCERADNYUnk019")
        assignComboLookups(comboFrontal, "lkpCERADNYUnk019")
        assignComboLookups(comboTemporal, "lkpCERADNYUnk019")
    End Sub
    Private Sub assignComboLookups(ByVal ComboName As ComboBox, ByVal tableName As String)
        ComboName.DataSource = New DataView(formTables.Tables(tableName))
        ComboName.DisplayMember = "Label"
        ComboName.ValueMember = "Value"
    End Sub
    Private Sub defaultValues()
        'Set all of the combo boxes to -1 (blank)
        comboArteriosclerosis.SelectedValue = 0
        comboArteriolarsclerosis.SelectedValue = 0
        comboOtherMicroscopic.SelectedValue = 0
        comboMicroinfarcts.SelectedValue = 0
        comboWhiteMatterDiffusePallor.SelectedValue = 0
        comboWhiteMatterStain.SelectedValue = 0
        comboOccipital.SelectedValue = -1
        comboParietal.SelectedValue = -1
        comboFrontal.SelectedValue = -1
        comboTemporal.SelectedValue = -1
    End Sub
    Private Sub loadExistingData()
        'Grab the CERADE record for this SubNum
        formTables.Tables.Add(Database.ReturnTable("CERADE", , "SubNum = " & WarehouseShell.SubNum))
        'Apply the existing values to the input fields
        comboArteriosclerosis.SelectedValue = formTables.Tables("CERADE").Rows(0).Item("Arteriosclerosis") 'literal values for combo boxes
        comboArteriolarsclerosis.SelectedValue = formTables.Tables("CERADE").Rows(0).Item("Arteriolarsclerosis")
        comboOtherMicroscopic.SelectedValue = formTables.Tables("CERADE").Rows(0).Item("OtherVascDisease")
        txtOtherMicroscopicNote.Text = formTables.Tables("CERADE").Rows(0).Item("OtherVascDiseaseNote").ToString 'string values for text boxes
        comboMicroinfarcts.SelectedValue = formTables.Tables("CERADE").Rows(0).Item("Microinfarcts")
        txtMicroinfarctsNote.Text = formTables.Tables("CERADE").Rows(0).Item("MicroinfarctsNote").ToString
        comboWhiteMatterDiffusePallor.SelectedValue = formTables.Tables("CERADE").Rows(0).Item("Binswangers")
        txtWhiteMatterDiffusePallorNote.Text = formTables.Tables("CERADE").Rows(0).Item("BinswangersNote").ToString
        comboWhiteMatterStain.SelectedValue = formTables.Tables("CERADE").Rows(0).Item("PallorWOVascDis")
        comboOccipital.SelectedValue = formTables.Tables("CERADE").Rows(0).Item("OccipitalPallor")
        comboParietal.SelectedValue = formTables.Tables("CERADE").Rows(0).Item("ParietalPallor")
        comboFrontal.SelectedValue = formTables.Tables("CERADE").Rows(0).Item("FrontalPallor")
        comboTemporal.SelectedValue = formTables.Tables("CERADE").Rows(0).Item("TemporalPallor")
    End Sub

    'Subs to enable-disable fields during data input based on conditional logic.
    Private Sub enableInputFields(ByVal value As Boolean)
        If value = True Then
            comboArteriosclerosis.Enabled = True
            comboArteriolarsclerosis.Enabled = True
            comboOtherMicroscopic.Enabled = True
            txtOtherMicroscopicNote.Enabled = True
            comboMicroinfarcts.Enabled = True
            txtMicroinfarctsNote.Enabled = True
            comboWhiteMatterDiffusePallor.Enabled = True
            txtWhiteMatterDiffusePallorNote.Enabled = True
            comboWhiteMatterStain.Enabled = True
            comboOccipital.Enabled = True
            comboParietal.Enabled = True
            comboFrontal.Enabled = True
            comboTemporal.Enabled = True
        Else
            comboArteriosclerosis.Enabled = False
            comboArteriolarsclerosis.Enabled = False
            comboOtherMicroscopic.Enabled = False
            txtOtherMicroscopicNote.Enabled = False
            comboMicroinfarcts.Enabled = False
            txtMicroinfarctsNote.Enabled = False
            comboWhiteMatterDiffusePallor.Enabled = False
            txtWhiteMatterDiffusePallorNote.Enabled = False
            comboWhiteMatterStain.Enabled = False
            comboOccipital.Enabled = False
            comboParietal.Enabled = False
            comboFrontal.Enabled = False
            comboTemporal.Enabled = False
        End If
    End Sub

    'Define button click events
    Private Sub btnCERADE_Click(sender As Object, e As EventArgs) Handles btnCERADEBottom.Click, btnCERADETop.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_CERADE", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                enableInputFields(True)
                btnCERADEBottom.Text = "Save changes"
                btnCERADETop.Text = btnCERADEBottom.Text
            Else
                MsgBox("You do not have permission to edit this form.", MsgBoxStyle.OkOnly, "Warning")
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If Database.ExistingRecordCheck("CERAD_Header", "SubNum = " & WarehouseShell.SubNum) Then
                If User.PermissionCheck("WA_CERADE", "Modify") Then
                    WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
                    loadBaseForm()
                    defaultValues()
                    enableInputFields(True)
                    btnCERADEBottom.Text = "Save new record"
                    btnCERADETop.Text = btnCERADEBottom.Text
                    lblNoRecord.Visible = False
                Else
                    MsgBox("You do not have permission to create this form.", MsgBoxStyle.OkOnly, "Warning")
                End If
            Else
                MsgBox("Please create a CERAD Header for this subject before attempting to add CERAD information.", MsgBoxStyle.OkOnly, "Error!")
            End If
        Else
            If preSaveValidate() = True Then
                Dim sqlCommand As New SqlCommand
                sqlCommand.Connection = WarehouseShell.conn
                Dim cmdString = "@SubNum = " & WarehouseShell.SubNum &
                        ", @Arteriosclerosis = " & comboArteriosclerosis.getSQLValue() &
                        ", @Arteriolarsclerosis = " & comboArteriolarsclerosis.getSQLValue() &
                        ", @OtherVascDisease = " & comboOtherMicroscopic.getSQLValue() &
                        ", @OtherVascDiseaseNote = " & txtOtherMicroscopicNote.getSQLValue() &
                        ", @Microinfarcts = " & comboMicroinfarcts.getSQLValue() &
                        ", @MicroinfarctsNote = " & txtMicroinfarctsNote.getSQLValue() &
                        ", @Binswangers = " & comboWhiteMatterDiffusePallor.getSQLValue() &
                        ", @BinswangersNote = " & txtWhiteMatterDiffusePallorNote.getSQLValue() &
                        ", @PallorWOVascDis = " & comboWhiteMatterStain.getSQLValue() &
                        ", @OccipitalPallor = " & comboOccipital.getSQLValue() &
                        ", @ParietalPallor = " & comboParietal.getSQLValue() &
                        ", @FrontalPallor = " & comboFrontal.getSQLValue() &
                        ", @TemporalPallor = " & comboTemporal.getSQLValue() & ";"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    sqlCommand.CommandText = "EXEC dbo.modCERADERecord @Action = 1, " & cmdString
                    Try
                        sqlCommand.ExecuteNonQuery()
                        MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        enableInputFields(False)
                        btnCERADEBottom.Text = "Edit this record"
                        btnCERADETop.Text = btnCERADEBottom.Text
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else
                    sqlCommand.CommandText = "EXEC dbo.modCERADERecord @Action = 2, " & cmdString
                    Try
                        sqlCommand.ExecuteNonQuery()
                        MessageBox.Show("Record was successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        enableInputFields(False)
                        btnCERADEBottom.Text = "Edit this record"
                        btnCERADETop.Text = btnCERADEBottom.Text
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                End If
            Else
                MsgBox(errorMessage & vbNewLine & vbNewLine & "These errors must be corrected before the record can be saved.", MsgBoxStyle.Exclamation, "Input Validation Error")
            End If
        End If
    End Sub

    Private Function preSaveValidate() As Boolean
        Dim result As Boolean = True
        'Validate comboOtherDementia
        If IsNothing(comboOtherMicroscopic.SelectedValue) Then
            If txtOtherMicroscopicNote.Text <> "" Then
                result = False
                errorMessage = "You have entered an Other Microscopic Vascular Disease note without selecting ""Yes"" in the Other Microscopic Vascular Disease dropdown box. Please clear the note or select ""Yes"" in the dropdown box."
            End If
        ElseIf comboOtherMicroscopic.SelectedValue <> 1 Then
            If txtOtherMicroscopicNote.Text <> "" Then
                result = False
                errorMessage = "You have entered an Other Microscopic Vascular Disease note without selecting ""Yes"" in the Other Microscopic Vascular Disease dropdown box. Please clear the note or select ""Yes"" in the dropdown box."
            End If
        ElseIf comboOtherMicroscopic.SelectedValue = 1 Then
            If txtOtherMicroscopicNote.Text = "" Then
                result = False
                errorMessage = "You have selected ""Yes"" in the Other Microscopic Vascular Disease dropdown box without specifying a note. Please add a note or change the value in the Other Microscopic Vascular Disease dropdown box."
            End If
        End If
        If IsNothing(comboMicroinfarcts.SelectedValue) Then
            If txtMicroinfarctsNote.Text <> "" Then
                result = False
                errorMessage = "You have entered a Microinfarcts note without selecting ""Yes"" in the Microinfarcts dropdown box. Please clear the note or select ""Yes"" in the dropdown box."
            End If
        ElseIf comboMicroinfarcts.SelectedValue <> 1 Then
            If txtMicroinfarctsNote.Text <> "" Then
                result = False
                errorMessage = "You have entered a Microinfarcts note without selecting ""Yes"" in the Microinfarcts dropdown box. Please clear the note or select ""Yes"" in the dropdown box."
            End If
        ElseIf comboMicroinfarcts.SelectedValue = 1 Then
            If txtMicroinfarctsNote.Text = "" Then
                result = False
                errorMessage = "You have selected ""Yes"" in the Microinfarcts dropdown box without specifying a note. Please add a note or change the value in the Microinfarcts dropdown box."
            End If
        End If
        If IsNothing(comboWhiteMatterDiffusePallor.SelectedValue) Then
            If txtWhiteMatterDiffusePallorNote.Text <> "" Then
                result = False
                errorMessage = "You have entered a Binswanger's note without selecting ""Yes"" in the Binswanger's dropdown box. Please clear the note or select ""Yes"" in the dropdown box."
            End If
        ElseIf comboWhiteMatterDiffusePallor.SelectedValue <> 1 Then
            If txtWhiteMatterDiffusePallorNote.Text <> "" Then
                result = False
                errorMessage = "You have entered a Binswanger's note without selecting ""Yes"" in the Binswanger's dropdown box. Please clear the note or select ""Yes"" in the dropdown box."
            End If
        ElseIf comboWhiteMatterDiffusePallor.SelectedValue = 1 Then
            If txtWhiteMatterDiffusePallorNote.Text = "" Then
                result = False
                errorMessage = "You have selected ""Yes"" in the Binswanger's dropdown box without specifying a note. Please add a note or change the value in the Binswanger's dropdown box."
            End If
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
        btnCERADEBottom.PerformClick()
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class