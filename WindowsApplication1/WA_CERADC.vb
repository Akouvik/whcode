Public Class WA_CERADC
    Implements IFormMethods
    Private formTables As New DataSet
    Private tooltip1 As New ToolTip

    'Load form based on current WarehouseShell.DataMode
    'Also checks to make sure a current record doesn't already exist if user is in INSERT mode.
    Private Sub WA_CERADC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_CERADC")
        If Database.ExistingRecordCheck("CERADC", "SubNum = " & WarehouseShell.SubNum) = True Then
            loadBaseForm()
            defaultValues()
            enableInputFields(False)
            loadExistingData()
            btnCERADCBottom.Text = "Edit this record"
            btnCERADCTop.Text = btnCERADCBottom.Text
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            btnCERADCTop.Focus()
        Else
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            btnCERADCBottom.Text = "Add New Record"
            btnCERADCTop.Text = btnCERADCBottom.Text
            enableInputFields(False)
            lblNoRecord.Visible = True
        End If
    End Sub
    'Grab applicable lookup tables and assign the actual lookup values
    Private Sub loadBaseForm()
        'Load all required lookup tables into the comboValues DataSet
        formTables.Tables.Add(Database.ReturnTable("lkpCERADFixedFresh"))
        formTables.Tables.Add(Database.ReturnTable("lkpNYUnk019NoBlanks"))
        formTables.Tables.Add(Database.ReturnTable("lkpNY01NoBlanks"))
        formTables.Tables.Add(Database.ReturnTable("lkpCERADSeverity01359"))
        'Assign lookup values to each individual combobox
        comboFixedOrFresh.assignLookup(formTables, "lkpCERADFixedFresh")
        comboBrainstemCerebellumInc.assignLookup(formTables, "lkpNY01NoBlanks")
        comboSpinalCordExamined.assignLookup(formTables, "lkpNY01NoBlanks")
        comboSpinalCordAbnormal.assignLookup(formTables, "lkpNYUnk019NoBlanks")
        comboAbnormalMeninges.assignLookup(formTables, "lkpNY01NoBlanks")
        comboBrainAtrophy.assignLookup(formTables, "lkpNY01NoBlanks")
        comboVentriclesEnlarged.assignLookup(formTables, "lkpCERADSeverity01359")
        comboFrontalLocation.assignLookup(formTables, "lkpCERADSeverity01359")
        comboParietalLocation.assignLookup(formTables, "lkpCERADSeverity01359")
        comboTemporalLocation.assignLookup(formTables, "lkpCERADSeverity01359")
        comboOccipitalLocation.assignLookup(formTables, "lkpCERADSeverity01359")
        comboCerebellarLocation.assignLookup(formTables, "lkpCERADSeverity01359")
        comboUnusualSulcal.assignLookup(formTables, "lkpNY01NoBlanks")
        comboAtrophyHippocampus.assignLookup(formTables, "lkpNY01NoBlanks")
        comboAtrophyEntor.assignLookup(formTables, "lkpNY01NoBlanks")
        comboPallorSubNigra.assignLookup(formTables, "lkpNY01NoBlanks")
        comboPallorLocusCeruleus.assignLookup(formTables, "lkpNY01NoBlanks")
        comboOtherCNSLesions.assignLookup(formTables, "lkpNY01NoBlanks")
    End Sub
    'Sub to set default values for the form. NOT called for view or edit modes.
    Private Sub defaultValues()
        'Default the Fixed or Fresh field to Fresh
        comboFixedOrFresh.SelectedValue = 1

        'Load Brain Weights from AFS
        loadBrainWeights()

        'Default the rest of the combo boxes to -1 (blank string DisplayValues)
        comboBrainstemCerebellumInc.SelectedValue = 0
        comboSpinalCordExamined.SelectedValue = 0
        comboSpinalCordAbnormal.SelectedValue = 9
        comboAbnormalMeninges.SelectedValue = 0
        comboBrainAtrophy.SelectedValue = 0
        comboVentriclesEnlarged.SelectedValue = 0
        comboFrontalLocation.SelectedValue = 0
        comboParietalLocation.SelectedValue = 0
        comboTemporalLocation.SelectedValue = 0
        comboOccipitalLocation.SelectedValue = 0
        comboCerebellarLocation.SelectedValue = 0
        comboUnusualSulcal.SelectedValue = 0
        comboAtrophyHippocampus.SelectedValue = 0
        comboAtrophyEntor.SelectedValue = 0
        comboPallorSubNigra.SelectedValue = 0
        comboPallorLocusCeruleus.SelectedValue = 0
        comboOtherCNSLesions.SelectedValue = 0
    End Sub
    Private Sub loadBrainWeights()
        If Database.ExistingRecordCheck("AutopsyFaceSheet", "SubNum = " & WarehouseShell.SubNum) Then
            formTables.Tables.Add(Database.ReturnTable("AutopsyFaceSheet", "BrainWtTot, BrainWtRt, BrainWtLt", "SubNum = " & WarehouseShell.SubNum))
            txtTotalBrainWeight.setValue(formTables, "AutopsyFaceSheet", "BrainWtTot")
            txtRightBrainWeight.setValue(formTables, "AutopsyFaceSheet", "BrainWtRt")
            txtLeftBrainWeight.setValue(formTables, "AutopsyFaceSheet", "BrainWtLt")
        End If
    End Sub
    'Sub to load existing values into form for View/Edit modes
    Private Sub loadExistingData()
        'Grab the CERADC record for this SubNum
        formTables.Tables.Add(Database.ReturnTable("CERADC", , "SubNum = " & WarehouseShell.SubNum))
        'Apply the existing values to the input fields
        txtTotalBrainWeight.setValue(formTables, "CERADC", "TotalBrainWeight")
        comboFixedOrFresh.setValue(formTables, "CERADC", "FixedOrFresh")
        txtRightBrainWeight.setValue(formTables, "CERADC", "RightBrainWeight")
        txtLeftBrainWeight.setValue(formTables, "CERADC", "LeftBrainWeight")
        comboBrainstemCerebellumInc.setValue(formTables, "CERADC", "BSandCerebInc")
        comboSpinalCordExamined.setValue(formTables, "CERADC", "SpinalExamined")
        comboSpinalCordAbnormal.setValue(formTables, "CERADC", "SpinalAbnormal")
        txtSpinalCordAbnormalNote.setValue(formTables, "CERADC", "SpinalAbnormalNote")
        comboAbnormalMeninges.setValue(formTables, "CERADC", "AbnormalMeninges")
        txtAbnormalMeningesNote.setValue(formTables, "CERADC", "AbnormalMeningesNote")
        comboBrainAtrophy.setValue(formTables, "CERADC", "BrainAtrophy")
        comboVentriclesEnlarged.setValue(formTables, "CERADC", "VentriclesEnlarged")
        comboFrontalLocation.setValue(formTables, "CERADC", "Frontal")
        comboParietalLocation.setValue(formTables, "CERADC", "Parietal")
        comboTemporalLocation.setValue(formTables, "CERADC", "Temporal")
        comboOccipitalLocation.setValue(formTables, "CERADC", "Occipital")
        comboCerebellarLocation.setValue(formTables, "CERADC", "Cerebellar")
        comboUnusualSulcal.setValue(formTables, "CERADC", "UnusualSulcal")
        txtUnusualSulcalNote.setValue(formTables, "CERADC", "UnusualSulcalNote")
        comboAtrophyHippocampus.setValue(formTables, "CERADC", "HippoAtrophy")
        comboAtrophyEntor.setValue(formTables, "CERADC", "EntorAtrophy")
        comboPallorSubNigra.setValue(formTables, "CERADC", "SubNigraPallor")
        comboPallorLocusCeruleus.setValue(formTables, "CERADC", "LocusCeruleusPallor")
        comboOtherCNSLesions.setValue(formTables, "CERADC", "OtherGrossCNS")
        txtOtherCNSLesionsNote.setValue(formTables, "CERADC", "OtherGrossCNSNote")
    End Sub
    'Subs to enable-disable fields during data input based on conditional logic.
    Private Sub enableInputFields(ByVal value As Boolean)
        If value = True Then
            txtTotalBrainWeight.Enabled = True
            comboFixedOrFresh.Enabled = True
            txtLeftBrainWeight.Enabled = True
            txtRightBrainWeight.Enabled = True
            comboBrainstemCerebellumInc.Enabled = True
            comboSpinalCordExamined.Enabled = True
            comboSpinalCordAbnormal.Enabled = True
            txtSpinalCordAbnormalNote.makeReadOnly(False)
            comboAbnormalMeninges.Enabled = True
            txtAbnormalMeningesNote.makeReadOnly(False)
            comboBrainAtrophy.Enabled = True
            comboVentriclesEnlarged.Enabled = True
            comboFrontalLocation.Enabled = True
            comboParietalLocation.Enabled = True
            comboTemporalLocation.Enabled = True
            comboOccipitalLocation.Enabled = True
            comboCerebellarLocation.Enabled = True
            comboUnusualSulcal.Enabled = True
            txtUnusualSulcalNote.makeReadOnly(False)
            comboAtrophyHippocampus.Enabled = True
            comboAtrophyEntor.Enabled = True
            comboPallorSubNigra.Enabled = True
            comboPallorLocusCeruleus.Enabled = True
            comboOtherCNSLesions.Enabled = True
            txtOtherCNSLesionsNote.makeReadOnly(False)
        Else
            txtTotalBrainWeight.Enabled = False
            comboFixedOrFresh.Enabled = False
            txtLeftBrainWeight.Enabled = False
            txtRightBrainWeight.Enabled = False
            comboBrainstemCerebellumInc.Enabled = False
            comboSpinalCordExamined.Enabled = False
            comboSpinalCordAbnormal.Enabled = False
            txtSpinalCordAbnormalNote.makeReadOnly(True)
            comboAbnormalMeninges.Enabled = False
            txtAbnormalMeningesNote.makeReadOnly(True)
            comboBrainAtrophy.Enabled = False
            comboVentriclesEnlarged.Enabled = False
            comboFrontalLocation.Enabled = False
            comboParietalLocation.Enabled = False
            comboTemporalLocation.Enabled = False
            comboOccipitalLocation.Enabled = False
            comboCerebellarLocation.Enabled = False
            comboUnusualSulcal.Enabled = False
            txtUnusualSulcalNote.makeReadOnly(True)
            comboAtrophyHippocampus.Enabled = False
            comboAtrophyEntor.Enabled = False
            comboPallorSubNigra.Enabled = False
            comboPallorLocusCeruleus.Enabled = False
            comboOtherCNSLesions.Enabled = False
            txtOtherCNSLesionsNote.makeReadOnly(True)
        End If
    End Sub

    'Define button click events
    Private Sub btnCERADC_Click(sender As Object, e As EventArgs) Handles btnCERADCBottom.Click, btnCERADCTop.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_CERADC", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                enableInputFields(True)
                btnCERADCBottom.Text = "Save changes"
                btnCERADCTop.Text = btnCERADCBottom.Text
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If Database.ExistingRecordCheck("CERAD_Header", "SubNum = " & WarehouseShell.SubNum) Then
                If User.PermissionCheck("WA_CERADC", "Modify") Then
                    WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
                    loadBaseForm()
                    defaultValues()
                    enableInputFields(True)
                    btnCERADCBottom.Text = "Save new record"
                    btnCERADCTop.Text = btnCERADCBottom.Text
                    lblNoRecord.Visible = False
                End If
            Else
                MsgBox("Please create a CERAD Header for this subject before attempting to add CERAD information.", MsgBoxStyle.OkOnly, "Error!")
            End If
        Else
            If preSaveValidation() Then
                Dim sqlCommand As New SqlCommand
                sqlCommand.Connection = WarehouseShell.conn
                Dim cmdString As String = "@SubNum = " & WarehouseShell.SubNum &
                    ", @TotalBrainWeight = " & txtTotalBrainWeight.getSQLValue() &
                    ", @FixedOrFresh = " & comboFixedOrFresh.getSQLValue() &
                    ", @RightBrainWeight = " & txtRightBrainWeight.getSQLValue() &
                    ", @LeftBrainWeight = " & txtLeftBrainWeight.getSQLValue() &
                    ", @BSandCerebInc = " & comboBrainstemCerebellumInc.getSQLValue() &
                    ", @SpinalExamined = " & comboSpinalCordExamined.getSQLValue() &
                    ", @SpinalAbnormal = " & comboSpinalCordAbnormal.getSQLValue() &
                    ", @SpinalAbnormalNote = " & txtSpinalCordAbnormalNote.getSQLValue() &
                    ", @AbnormalMeninges = " & comboAbnormalMeninges.getSQLValue() &
                    ", @AbnormalMeningesNote = " & txtAbnormalMeningesNote.getSQLValue() &
                    ", @BrainAtrophy = " & comboBrainAtrophy.getSQLValue() &
                    ", @VentriclesEnlarged = " & comboVentriclesEnlarged.getSQLValue() &
                    ", @Frontal = " & comboFrontalLocation.getSQLValue() &
                    ", @Parietal = " & comboParietalLocation.getSQLValue() &
                    ", @Temporal = " & comboTemporalLocation.getSQLValue() &
                    ", @Occipital = " & comboOccipitalLocation.getSQLValue() &
                    ", @Cerebellar = " & comboCerebellarLocation.getSQLValue() &
                    ", @UnusualSulcal = " & comboUnusualSulcal.getSQLValue() &
                    ", @UnusualSulcalNote = " & txtUnusualSulcalNote.getSQLValue() &
                    ", @HippoAtrophy = " & comboAtrophyHippocampus.getSQLValue() &
                    ", @EntorAtrophy = " & comboAtrophyEntor.getSQLValue() &
                    ", @SubNigraPallor = " & comboPallorSubNigra.getSQLValue() &
                    ", @LocusCeruleusPallor = " & comboPallorLocusCeruleus.getSQLValue() &
                    ", @OtherGrossCNS = " & comboOtherCNSLesions.getSQLValue() &
                    ", @OtherGrossCNSNote = " & txtOtherCNSLesionsNote.getSQLValue() & ";"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    sqlCommand.CommandText = "EXEC dbo.modCERADCRecord @Action = 1, " & cmdString
                    Try
                        sqlCommand.ExecuteNonQuery()
                        MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        enableInputFields(False)
                        btnCERADCBottom.Text = "Edit this record"
                        btnCERADCTop.Text = btnCERADCBottom.Text
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else
                    sqlCommand.CommandText = "EXEC dbo.modCERADCRecord @Action = 2, " & cmdString
                    Try
                        sqlCommand.ExecuteNonQuery()
                        MessageBox.Show("Record was successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        enableInputFields(False)
                        btnCERADCBottom.Text = "Edit this record"
                        btnCERADCTop.Text = btnCERADCBottom.Text
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

        'Validate brain hemisphere weights against AutopsyFaceSheet weights (within 10%)
        If txtRightBrainWeight.Text <> "" Then
            If Database.ExistingRecordCheck("AutopsyFaceSheet", "SubNum = " & WarehouseShell.SubNum) Then
                Dim chkCmd As New SqlCommand("select BrainWtRt from AutopsyFaceSheet where SubNum = " & WarehouseShell.SubNum & ";", WarehouseShell.conn)
                If IsNumeric(chkCmd.ExecuteScalar()) Then
                    Dim AutBrnWt As Integer = chkCmd.ExecuteScalar()
                    Dim diffPercent As Decimal = CType(txtRightBrainWeight.Text, Decimal) / AutBrnWt
                    If diffPercent > 1.1 Or diffPercent < 0.9 Then
                        Dim check As MsgBoxResult = MsgBox("Your right hemisphere brain weight is more than 10% different than the weight measured on the autopsy face sheet. Would you like to coninue saving?", MsgBoxStyle.YesNo, "Warning!")
                        If check = MsgBoxResult.No Then
                            Return False
                            Exit Function
                        End If
                    End If
                End If
            End If
        End If
        If txtLeftBrainWeight.Text <> "" Then
            If Database.ExistingRecordCheck("AutopsyFaceSheet", "SubNum = " & WarehouseShell.SubNum) Then
                Dim chkCmd As New SqlCommand("select BrainWtLt from AutopsyFaceSheet where SubNum = " & WarehouseShell.SubNum & ";", WarehouseShell.conn)
                If IsNumeric(chkCmd.ExecuteScalar()) Then
                    Dim AutBrnWt As Integer = chkCmd.ExecuteScalar()
                    Dim diffPercent As Decimal = 1 - (CType(txtLeftBrainWeight.Text, Decimal) / AutBrnWt)
                    If diffPercent > 0.1 Or diffPercent < -0.1 Then
                        Dim checkResult As New MsgBoxResult
                        checkResult = MsgBox("Your left hemisphere brain weight is more than 10% different than the weight measured on the autopsy face sheet. Would you like to coninue saving?", MsgBoxStyle.YesNo, "Warning!")
                        If checkResult = MsgBoxResult.No Then
                            Return False
                            Exit Function
                        End If
                    End If
                End If
            End If
        End If

        'Validate comboSpinalCordExamined/Abnormal relationship
        If comboSpinalCordExamined.SelectedValue <> 1 And comboSpinalCordAbnormal.SelectedValue <> 9 Then
            Return False
            errorMessage += "- You have selected Yes or No for Spinal Cord Abnormalities (Item 2a), but have not selected Yes for Spinal Cord Examined (Item 2). Please set Spinal Cord Abnormalities to Unk or select Yes for Spinal Cord Examined." & vbNewLine
        ElseIf comboSpinalCordExamined.SelectedValue = 1 And comboSpinalCordAbnormal.SelectedValue = 9 Then
            result = False
            errorMessage += "- You have selected Yes for Spinal Cord Examined (Item 2), but have not selected Yes or No for Spinal Cord Abnormalities (Item 2a). Please select Yes or No for Spinal Cord Abnormailities or select No for Spinal Cord Examined." & vbNewLine
        End If

        'Validate comboSpinalCordAbnormal/Specify relationship
        If comboSpinalCordAbnormal.SelectedValue <> 1 And txtSpinalCordAbnormalNote.Text <> "" Then
            result = False
            errorMessage += "- You have entered a Spinal Cord Abnormality Note (Item 2b) without selecting Yes for Spinal Cord Abnormalities (Item 2a). Please clear the Note or select Yes for Spinal Cord Abnormalities." & vbNewLine
        ElseIf comboSpinalCordAbnormal.SelectedValue = 1 And txtSpinalCordAbnormalNote.Text = "" Then
            result = False
            errorMessage += "- You have entered Yes for Spinal Cord Abnormalities (Item 2a) without providing a note in the Specify (Item 2b). Please add the note or select No or Unk for Spinal Cord Abnormalities." & vbNewLine
        End If

        'Validate comboAbnormalMeninges
        If comboAbnormalMeninges.SelectedValue <> 1 And txtAbnormalMeningesNote.Text <> "" Then
            result = False
            errorMessage += "- You have entered an Abnormal Meninges Note (Item 3a) without selecting Yes for Abnormal Meninges (Item 3). Please clear the note or select Yes for Abnormal Meninges." & vbNewLine
        ElseIf comboAbnormalMeninges.SelectedValue = 1 And txtAbnormalMeningesNote.Text = "" Then
            result = False
            errorMessage = "- You have selected Yes for Abnormal Meninges (Item 3) without specifying a note (Item 3a). Please add a note or change the value for Abnormal Meninges to No." & vbNewLine
        End If

        'Validate comboUnusualSulcal
        If IsNothing(comboUnusualSulcal.SelectedValue) Then
            If txtUnusualSulcalNote.Text <> "" Then
                result = False
                errorMessage = "You have entered an Unusual Sulcal or Ventricular Features note without selecting ""Yes"" in the Unusual Sulcal or Ventricular Features dropdown box. Please clear the note or select ""Yes"" in the dropdown box."
            End If
        ElseIf comboUnusualSulcal.SelectedValue <> 1 Then
            If txtUnusualSulcalNote.Text <> "" Then
                result = False
                errorMessage = "You have entered an Unusual Sulcal or Ventricular Features note without selecting ""Yes"" in the Unusual Sulcal or Ventricular Features dropdown box. Please clear the note or select ""Yes"" in the dropdown box."
            End If
        ElseIf comboUnusualSulcal.SelectedValue = 1 Then
            If txtUnusualSulcalNote.Text = "" Then
                result = False
                errorMessage = "You have selected ""Yes"" in the Unusual Sulcal or Ventricular Features dropdown box without specifying a note. Please add a note or change the value of the Unusual Sulcal or Ventricular Features dropdown box."
            End If
        End If

        'Validate comboOtherCNSLesions
        If IsNothing(comboOtherCNSLesions.SelectedValue) Then
            If txtOtherCNSLesionsNote.Text <> "" Then
                result = False
                errorMessage = "You have entered an Other CNS Lesions note without selecting ""Yes"" in the Other CNS Lesions dropdown box. Please clear the note or select ""Yes"" in the dropdown box."
            End If
        ElseIf comboOtherCNSLesions.SelectedValue <> 1 Then
            If txtOtherCNSLesionsNote.Text <> "" Then
                result = False
                errorMessage = "You have entered an Other CNS Lesions note without selecting ""Yes"" in the Other CNS Lesions dropdown box. Please clear the note or select ""Yes"" in the dropdown box."
            End If
        ElseIf comboOtherCNSLesions.SelectedValue = 1 Then
            If txtOtherCNSLesionsNote.Text = "" Then
                result = False
                errorMessage = "You have selected ""Yes"" in the Other CNS Lesions dropdown box without specifying a note. Please add a note or change the value of the Other CNS Lesions dropdown box."
            End If
        End If

        'Handle result
        If result = False Then
            MsgBox("The following errors must be corrected before this form can be saved:" & vbNewLine & vbNewLine & errorMessage, MsgBoxStyle.OkOnly, "Error")
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
        btnCERADCBottom.PerformClick()
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class