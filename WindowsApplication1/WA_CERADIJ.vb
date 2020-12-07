Public Class WA_CERADIJ
    Implements IFormMethods
    Private formTables As New DataSet

    'Load form subs
    Private Sub WA_CERADIJ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_CERADIJ")
        If Database.ExistingRecordCheck("CERADIJ", "SubNum = " & WarehouseShell.SubNum) = True Then
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            loadBaseForm()
            enableInputFields(False)
            setDefaultValues()
            loadExistingData()
            btnCERADIJBottom.Text = "Edit this record"
            btnCERADIJTop.Text = btnCERADIJBottom.Text
            btnCERADIJTop.Focus()
        Else
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            btnCERADIJTop.Text = "Add New Record"
            btnCERADIJBottom.Text = btnCERADIJTop.Text
            enableInputFields(False)
            lblNoRecord.Visible = True
        End If
    End Sub
    Private Sub loadBaseForm()
        'Load all required lookup tables into the comboValues DataSet
        formTables.Tables.Add(Database.ReturnTable("lkpCERADNY01"))
        formTables.Tables.Add(Database.ReturnTable("lkpCERADabc"))
        formTables.Tables.Add(Database.ReturnTable("lkpCERADab"))
        formTables.Tables.Add(Database.ReturnTable("lkpCERADRank"))
        formTables.Tables.Add(Database.ReturnTable("lkpCERADBraak"))
        formTables.Tables.Add(Database.ReturnTable("lkpCERAD_ABC_Result"))
        formTables.Tables.Add(Database.ReturnTable("lkpCERAD_ABC_Scores"))
        'Assign lookup values to each individual combobox
        comboNormalBrain.assignLookup(formTables, "lkpCERADNY01")
        comboNormalBrainSpecify.assignLookup(formTables, "lkpCERADabc")
        comboDefiniteAlzheimers.assignLookup(formTables, "lkpCERADNY01")
        comboProbableAlzheimers.assignLookup(formTables, "lkpCERADNY01")
        comboPossibleAlzheimers.assignLookup(formTables, "lkpCERADNY01")
        comboPossibleAlzheimersSpecify.assignLookup(formTables, "lkpCERADab")
        comboDefiniteParkinsons.assignLookup(formTables, "lkpCERADNY01")
        comboDefiniteParkinsonsSpecify.assignLookup(formTables, "lkpCERADab")
        comboUncertainParkinsons.assignLookup(formTables, "lkpCERADNY01")
        comboInfarct.assignLookup(formTables, "lkpCERADNY01")
        comboLacune.assignLookup(formTables, "lkpCERADNY01")
        comboLacuneInfarct.assignLookup(formTables, "lkpCERADNY01")
        comboBinswangers.assignLookup(formTables, "lkpCERADNY01")
        comboHemo.assignLookup(formTables, "lkpCERADNY01")
        combo7Other.assignLookup(formTables, "lkpCERADNY01")
        comboPicks.assignLookup(formTables, "lkpCERADNY01")
        comboLobar.assignLookup(formTables, "lkpCERADNY01")
        comboCJD.assignLookup(formTables, "lkpCERADNY01")
        comboDownsWAD.assignLookup(formTables, "lkpCERADNY01")
        comboDownsWOAD.assignLookup(formTables, "lkpCERADNY01")
        comboHuntingtons.assignLookup(formTables, "lkpCERADNY01")
        comboLeuko.assignLookup(formTables, "lkpCERADNY01")
        comboTumorPrim.assignLookup(formTables, "lkpCERADNY01")
        comboTumorSec.assignLookup(formTables, "lkpCERADNY01")
        comboAIDS.assignLookup(formTables, "lkpCERADNY01")
        comboOtherA.assignLookup(formTables, "lkpCERADNY01")
        comboOtherB.assignLookup(formTables, "lkpCERADNY01")
        comboOtherC.assignLookup(formTables, "lkpCERADNY01")
        cmbLewyWOAD.assignLookup(formTables, "lkpCERADNY01")
        cmbLewyWAD.assignLookup(formTables, "lkpCERADNY01")
        comboRank1.assignLookup(formTables, "lkpCERADRank")
        comboRank2.assignLookup(formTables, "lkpCERADRank")
        comboRank3.assignLookup(formTables, "lkpCERADRank")
        comboRank4.assignLookup(formTables, "lkpCERADRank")
        comboBraak_Alz.assignLookup(formTables, "lkpCERADBraak")
        comboBraak_Park.assignLookup(formTables, "lkpCERADBraak")
        cmbABC_A.assignLookup(formTables, "lkpCERAD_ABC_Scores")
        cmbABC_B.assignLookup(formTables, "lkpCERAD_ABC_Scores")
        cmbABC_C.assignLookup(formTables, "lkpCERAD_ABC_Scores")
        cmbABC_Result.assignLookup(formTables, "lkpCERAD_ABC_Result")
    End Sub
    Private Sub setDefaultValues()
        'Set all of the combo boxes to -1 (blank)
        comboNormalBrain.SelectedValue = 0
        comboNormalBrainSpecify.SelectedValue = "-1"
        comboDefiniteAlzheimers.SelectedValue = 0
        comboProbableAlzheimers.SelectedValue = 0
        comboPossibleAlzheimers.SelectedValue = 0
        comboPossibleAlzheimersSpecify.SelectedValue = "-1"
        comboDefiniteParkinsons.SelectedValue = 0
        comboDefiniteParkinsonsSpecify.SelectedValue = "-1"
        comboUncertainParkinsons.SelectedValue = 0
        comboInfarct.SelectedValue = 0
        comboLacune.SelectedValue = 0
        comboLacuneInfarct.SelectedValue = 0
        comboBinswangers.SelectedValue = 0
        comboHemo.SelectedValue = 0
        combo7Other.SelectedValue = 0
        comboPicks.SelectedValue = 0
        comboLobar.SelectedValue = 0
        comboCJD.SelectedValue = 0
        comboDownsWAD.SelectedValue = 0
        comboDownsWOAD.SelectedValue = 0
        comboHuntingtons.SelectedValue = 0
        comboLeuko.SelectedValue = 0
        comboTumorPrim.SelectedValue = 0
        comboTumorSec.SelectedValue = 0
        comboAIDS.SelectedValue = 0
        comboOtherA.SelectedValue = 0
        comboOtherB.SelectedValue = 0
        comboOtherC.SelectedValue = 0
        cmbLewyWOAD.SelectedValue = 0
        cmbLewyWAD.SelectedValue = 0
        comboRank1.SelectedValue = 0
        comboRank2.SelectedValue = 0
        comboRank3.SelectedValue = 0
        comboRank4.SelectedValue = 0
        comboRank1.SelectedValue = -1
        comboRank2.SelectedValue = -1
        comboRank3.SelectedValue = -1
        comboRank4.SelectedValue = -1
        comboBraak_Alz.SelectedValue = -1
        comboBraak_Park.SelectedValue = -1
        cmbABC_A.SelectedValue = -1
        cmbABC_B.SelectedValue = -1
        cmbABC_C.SelectedValue = -1
        cmbABC_Result.SelectedValue = -1
    End Sub
    Private Sub loadExistingData()
        'Grab the CERADIJ record for this SubNum
        formTables.Tables.Add(Database.ReturnTable("CERADIJ", , "SubNum = " & WarehouseShell.SubNum))
        'Apply the existing values to the input fields
        comboNormalBrain.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("NormalBrain") 'literal values for combo boxes
        comboNormalBrainSpecify.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("NormalBrainCat")
        comboDefiniteAlzheimers.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("DefAlzheimers")
        comboProbableAlzheimers.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("ProbAlzheimers")
        comboPossibleAlzheimers.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("PossAlzheimers")
        comboPossibleAlzheimersSpecify.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("PossAlzheimersCat")
        comboDefiniteParkinsons.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("DefParkinsons")
        comboDefiniteParkinsonsSpecify.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("DefParkinsonsCat")
        comboUncertainParkinsons.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("UncertainParkinsons")
        comboInfarct.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("Infarct")
        comboLacune.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("Lacune")
        comboLacuneInfarct.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("LacuneAndInfarct")
        comboBinswangers.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("Binswangers")
        comboHemo.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("Hemo")
        combo7Other.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("OtherVasc")
        txt7OtherNote.Text = formTables.Tables("CERADIJ").Rows(0).Item("OtherVascNote").ToString 'string values for text boxes
        comboPicks.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("Picks")
        comboLobar.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("Lobar")
        comboCJD.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("CJD")
        comboDownsWAD.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("DownsWAD")
        comboDownsWOAD.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("DownsWOAD")
        comboHuntingtons.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("Huntingtons")
        comboLeuko.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("Leuko")
        txtLeukoNote.Text = formTables.Tables("CERADIJ").Rows(0).Item("LeukoNote").ToString
        comboTumorPrim.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("TumorPrim")
        txtTumorPrimNote.Text = formTables.Tables("CERADIJ").Rows(0).Item("TumorPrimNote").ToString
        comboTumorSec.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("TumorSec")
        txtTumorSecNote.Text = formTables.Tables("CERADIJ").Rows(0).Item("TumorSecNote").ToString
        comboAIDS.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("AIDS")
        comboOtherA.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("OtherA")
        txtOtherANote.Text = formTables.Tables("CERADIJ").Rows(0).Item("OtherANote").ToString
        comboOtherB.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("OtherB")
        txtOtherBNote.Text = formTables.Tables("CERADIJ").Rows(0).Item("OtherBNote").ToString
        comboOtherC.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("OtherC")
        txtOtherCNote.Text = formTables.Tables("CERADIJ").Rows(0).Item("OtherCNote").ToString
        cmbLewyWOAD.setValue(formTables, "CERADIJ", "LewyWOAD")
        cmbLewyWAD.setValue(formTables, "CERADIJ", "LewyWAD")
        'Once the CERADI values are loaded, generate the possible dropdown values for the CERADJ Dx's
        buildComboValues()
        comboRank1.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("Rank1")
        comboRank2.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("Rank2")
        comboRank3.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("Rank3")
        comboRank4.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("Rank4")
        comboDX1.SelectedItem = formTables.Tables("CERADIJ").Rows(0).Item("Dx1") 'SelectedItem instead of SelectedValue because dropdown list is created dynamically by buildComboValues()
        txtDX1.Text = formTables.Tables("CERADIJ").Rows(0).Item("Dx1Text").ToString
        txtDX1Note.Text = formTables.Tables("CERADIJ").Rows(0).Item("Dx1Note").ToString
        comboDX2.SelectedItem = formTables.Tables("CERADIJ").Rows(0).Item("Dx2")
        txtDX2.Text = formTables.Tables("CERADIJ").Rows(0).Item("Dx2Text").ToString
        txtDX2Note.Text = formTables.Tables("CERADIJ").Rows(0).Item("Dx2Note").ToString
        comboDX3.SelectedItem = formTables.Tables("CERADIJ").Rows(0).Item("Dx3")
        txtDX3.Text = formTables.Tables("CERADIJ").Rows(0).Item("Dx3Text").ToString
        txtDX3Note.Text = formTables.Tables("CERADIJ").Rows(0).Item("Dx3Note").ToString
        comboDX4.SelectedItem = formTables.Tables("CERADIJ").Rows(0).Item("Dx4")
        txtDX4.Text = formTables.Tables("CERADIJ").Rows(0).Item("Dx4Text").ToString
        txtDX4Note.Text = formTables.Tables("CERADIJ").Rows(0).Item("Dx4Note").ToString
        comboBraak_Alz.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("Braak_Alz")
        comboBraak_Park.SelectedValue = formTables.Tables("CERADIJ").Rows(0).Item("Braak_Park")
        cmbABC_A.setValue(formTables, "CERADIJ", "ABC_A")
        cmbABC_B.setValue(formTables, "CERADIJ", "ABC_B")
        cmbABC_C.setValue(formTables, "CERADIJ", "ABC_C")
        cmbABC_Result.setValue(formTables, "CERADIJ", "ABC_Result")
    End Sub
    Private Sub enableInputFields(ByVal value As Boolean)
        comboNormalBrain.Enabled = value
        comboNormalBrainSpecify.Enabled = value
        comboDefiniteAlzheimers.Enabled = value
        comboProbableAlzheimers.Enabled = value
        comboPossibleAlzheimers.Enabled = value
        comboPossibleAlzheimersSpecify.Enabled = value
        comboDefiniteParkinsons.Enabled = value
        comboDefiniteParkinsonsSpecify.Enabled = value
        comboUncertainParkinsons.Enabled = value
        comboInfarct.Enabled = value
        comboLacune.Enabled = value
        comboLacuneInfarct.Enabled = value
        comboBinswangers.Enabled = value
        comboHemo.Enabled = value
        combo7Other.Enabled = value
        txt7OtherNote.Enabled = value
        comboPicks.Enabled = value
        comboLobar.Enabled = value
        comboCJD.Enabled = value
        comboDownsWAD.Enabled = value
        comboDownsWOAD.Enabled = value
        comboHuntingtons.Enabled = value
        comboLeuko.Enabled = value
        txtLeukoNote.Enabled = value
        comboTumorPrim.Enabled = value
        txtTumorPrimNote.Enabled = value
        comboTumorSec.Enabled = value
        txtTumorSecNote.Enabled = value
        comboAIDS.Enabled = value
        comboOtherA.Enabled = value
        txtOtherANote.Enabled = value
        comboOtherB.Enabled = value
        txtOtherBNote.Enabled = value
        comboOtherC.Enabled = value
        txtOtherCNote.Enabled = value
        cmbLewyWOAD.Enabled = value
        cmbLewyWAD.Enabled = value
        comboRank1.Enabled = value
        comboRank2.Enabled = value
        comboRank3.Enabled = value
        comboRank4.Enabled = value
        comboDX1.Enabled = value
        comboDX2.Enabled = value
        comboDX3.Enabled = value
        comboDX4.Enabled = value
        comboBraak_Alz.Enabled = value
        comboBraak_Park.Enabled = value
        cmbABC_A.Enabled = value
        cmbABC_B.Enabled = value
        cmbABC_C.Enabled = value
        cmbABC_Result.Enabled = False
    End Sub

    'Define button click events
    Private Sub btnCERADIJBottom_Click(sender As Object, e As EventArgs) Handles btnCERADIJBottom.Click, btnCERADIJTop.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_CERADIJ", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                enableInputFields(True)
                btnCERADIJBottom.Text = "Save changes"
                btnCERADIJTop.Text = btnCERADIJBottom.Text
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If Database.ExistingRecordCheck("CERAD_Header", "SubNum = " & WarehouseShell.SubNum) Then
                If User.PermissionCheck("WA_CERADIJ", "Modify") Then
                    loadBaseForm()
                    setDefaultValues()
                    enableInputFields(True)
                    btnCERADIJBottom.Text = "Save new record"
                    btnCERADIJTop.Text = btnCERADIJBottom.Text
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
                        ", @NormalBrain = " & comboNormalBrain.getSQLValue() &
                        ", @NormalBrainCat = " & comboNormalBrainSpecify.getSQLValue() &
                        ", @DefAlzheimers = " & comboDefiniteAlzheimers.getSQLValue() &
                        ", @ProbAlzheimers = " & comboProbableAlzheimers.getSQLValue() &
                        ", @PossAlzheimers = " & comboPossibleAlzheimers.getSQLValue() &
                        ", @PossAlzheimersCat = " & comboPossibleAlzheimersSpecify.getSQLValue() &
                        ", @DefParkinsons = " & comboDefiniteParkinsons.getSQLValue() &
                        ", @DefParkinsonsCat = " & comboDefiniteParkinsonsSpecify.getSQLValue() &
                        ", @UncertainParkinsons = " & comboUncertainParkinsons.getSQLValue() &
                        ", @Infarct = " & comboInfarct.getSQLValue() &
                        ", @Lacune = " & comboLacune.getSQLValue() &
                        ", @LacuneAndInfarct = " & comboLacuneInfarct.getSQLValue() &
                        ", @Binswangers = " & comboBinswangers.getSQLValue() &
                        ", @Hemo = " & comboHemo.getSQLValue() &
                        ", @OtherVasc = " & combo7Other.getSQLValue() &
                        ", @OtherVascNote = " & txt7OtherNote.getSQLValue() &
                        ", @Picks = " & comboPicks.getSQLValue() &
                        ", @Lobar = " & comboLobar.getSQLValue() &
                        ", @CJD = " & comboCJD.getSQLValue() &
                        ", @DownsWAD = " & comboDownsWAD.getSQLValue() &
                        ", @DownsWOAD = " & comboDownsWOAD.getSQLValue() &
                        ", @Huntingtons = " & comboHuntingtons.getSQLValue() &
                        ", @Leuko = " & comboLeuko.getSQLValue() &
                        ", @LeukoNote = " & txtLeukoNote.getSQLValue() &
                        ", @TumorPrim = " & comboTumorPrim.getSQLValue() &
                        ", @TumorPrimNote = " & txtTumorPrimNote.getSQLValue() &
                        ", @TumorSec = " & comboTumorSec.getSQLValue() &
                        ", @TumorSecNote = " & txtTumorSecNote.getSQLValue() &
                        ", @AIDS = " & comboAIDS.getSQLValue() &
                        ", @OtherA = " & comboOtherA.getSQLValue() &
                        ", @OtherANote = " & txtOtherANote.getSQLValue() &
                        ", @OtherB = " & comboOtherB.getSQLValue() &
                        ", @OtherBNote = " & txtOtherBNote.getSQLValue() &
                        ", @OtherC = " & comboOtherC.getSQLValue() &
                        ", @OtherCNote = " & txtOtherCNote.getSQLValue() &
                        ", @LewyWOAD = " & cmbLewyWOAD.getSQLValue() &
                        ", @LewyWAD = " & cmbLewyWAD.getSQLValue() &
                        ", @Rank1 = " & comboRank1.getSQLValue() &
                        ", @Dx1 = " & comboDX1.getSQLLabel() &
                        ", @Dx1Text = " & txtDX1.getSQLValue() &
                        ", @Dx1Note = " & txtDX1Note.getSQLValue() &
                        ", @Rank2 = " & comboRank2.getSQLValue() &
                        ", @Dx2 = " & comboDX2.getSQLLabel() &
                        ", @Dx2Text = " & txtDX2.getSQLValue() &
                        ", @Dx2Note = " & txtDX2Note.getSQLValue() &
                        ", @Rank3 = " & comboRank3.getSQLValue() &
                        ", @Dx3 = " & comboDX3.getSQLLabel() &
                        ", @Dx3Text = " & txtDX3.getSQLValue() &
                        ", @Dx3Note = " & txtDX3Note.getSQLValue() &
                        ", @Rank4 = " & comboRank4.getSQLValue() &
                        ", @Dx4 = " & comboDX4.getSQLLabel() &
                        ", @Dx4Text = " & txtDX4.getSQLValue() &
                        ", @Dx4Note = " & txtDX4Note.getSQLValue() &
                        ", @Braak_Alz = " & comboBraak_Alz.getSQLValue() &
                        ", @Braak_Park = " & comboBraak_Park.getSQLValue() &
                        ", @ABC_A = " & cmbABC_A.getSQLValue() &
                        ", @ABC_B = " & cmbABC_B.getSQLValue() &
                        ", @ABC_C = " & cmbABC_C.getSQLValue() &
                        ", @ABC_Result = " & cmbABC_Result.getSQLValue() &
                        ", @LastModBy = '" & WarehouseShell.userName & "';"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    sqlCommand.CommandText = "EXEC dbo.modCERADIJRecord @Action = 1, " & cmdString
                    Try
                        sqlCommand.ExecuteNonQuery()
                        MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        enableInputFields(False)
                        btnCERADIJBottom.Text = "Edit this record"
                        btnCERADIJTop.Text = btnCERADIJBottom.Text
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else
                    sqlCommand.CommandText = "EXEC dbo.modCERADIJRecord @Action = 2, " & cmdString
                    Try
                        sqlCommand.ExecuteNonQuery()
                        MessageBox.Show("Record successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        enableInputFields(False)
                        btnCERADIJBottom.Text = "Edit this record"
                        btnCERADIJTop.Text = btnCERADIJBottom.Text
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
        If comboNormalBrain.SelectedValue = 1 And (comboNormalBrainSpecify.SelectedValue = "-1" Or IsNothing(comboNormalBrainSpecify.SelectedValue)) Then
            errorMessage = "You have selected Yes for Normal Brain, but have not selected a Normal Brain Category. Please select a category or select No in the Normal Brain dropdown box."
            result = False
        End If
        If comboNormalBrain.SelectedValue <> 1 And comboNormalBrainSpecify.SelectedValue <> "-1" Then
            errorMessage = "You have selected a Normal Brain Category, but have not selected Yes in the Normal Brain dropdown box. Please clear the category or select Yes in the Normal Brain dropdown box."
            result = False
        End If
        If comboPossibleAlzheimers.SelectedValue = 1 And comboPossibleAlzheimersSpecify.SelectedValue = "-1" Then
            errorMessage = "You have selected Yes for Possible Alzheimer's disease, but have not selected a Possible Alzheimer's disease Category. Please select a category or select No in the Possible Alzheimer's disease dropdown box."
            result = False
        End If
        If comboPossibleAlzheimers.SelectedValue <> 1 And comboPossibleAlzheimersSpecify.SelectedValue <> "-1" Then
            errorMessage = "You have selected a Possible Alzheimer's disease Category, but have not selected Yes in the Possible Alzheimer's disease dropdown box. Please clear the category or select Yes in the Possible Alzheimer's disease dropdown box."
            result = False
        End If
        If comboDefiniteParkinsons.SelectedValue = 1 And comboDefiniteParkinsonsSpecify.SelectedValue = "-1" Then
            errorMessage = "You have selected Yes for Definite Parkinson's disease, but have not selected a Definite Parkinson's disease Category. Please select a category or select No in the Definite Parkinson's disease dropdown box."
            result = False
        End If
        If comboDefiniteParkinsons.SelectedValue <> 1 And comboDefiniteParkinsonsSpecify.SelectedValue <> "-1" Then
            errorMessage = "You have selected a Definite Parkinson's disease Category, but have not selected Yes in the Definite Parkinson's disease dropdown box. Please clear the category or select Yes in the Definite Parkinson's disease dropdown box."
            result = False
        End If
        If combo7Other.SelectedValue = 1 And txt7OtherNote.Text = "" Then
            errorMessage = "You have selected Yes for Vascular Disease- Other but have not entered a Vascular Disease- Other specify note. Please add a note or select No in the Vascular Disease- Other dropdown box."
            result = False
        End If
        If combo7Other.SelectedValue <> 1 And txt7OtherNote.Text <> "" Then
            errorMessage = "You have entered a Vascular Disease- Other specify note, but have not selected Yes in the Vascular Disease- Other dropdown box. Please clear the note or select Yes in the Vascular Disease- Other dropdown box."
            result = False
        End If
        If comboLeuko.SelectedValue = 1 And txtLeukoNote.Text = "" Then
            errorMessage = "You have selected Yes for Leukoencephaopathy but have not entered a Leukoencephaopathy specify note. Please add a note or select No in the Leukoencephaopathy dropdown box."
            result = False
        End If
        If comboLeuko.SelectedValue <> 1 And txtLeukoNote.Text <> "" Then
            errorMessage = "You have entered a Leukoencephaopathy specify note, but have not selected Yes in the Leukoencephaopathy dropdown box. Please clear the note or select Yes in the Leukoencephaopathy dropdown box."
            result = False
        End If
        If comboTumorPrim.SelectedValue = 1 And txtTumorPrimNote.Text = "" Then
            errorMessage = "You have selected Yes for Tumor- Primary but have not entered a Tumor- Primary specify note. Please add a note or select No in the Tumor- Primary dropdown box."
            result = False
        End If
        If comboTumorPrim.SelectedValue <> 1 And txtTumorPrimNote.Text <> "" Then
            errorMessage = "You have entered a Tumor- Primary specify note, but have not selected Yes in the Tumor- Primary dropdown box. Please clear the note or select Yes in the Tumor- Primary dropdown box."
            result = False
        End If
        If comboTumorSec.SelectedValue = 1 And txtTumorSecNote.Text = "" Then
            errorMessage = "You have selected Yes for Tumor- Secondary but have not entered a Tumor- Secondary specify note. Please add a note or select No in the Tumor- Secondary dropdown box."
            result = False
        End If
        If comboTumorSec.SelectedValue <> 1 And txtTumorSecNote.Text <> "" Then
            errorMessage = "You have entered a Tumor- Secondary specify note, but have not selected Yes in the Tumor- Secondary dropdown box. Please clear the note or select Yes in the Tumor- Secondary dropdown box."
            result = False
        End If
        If comboOtherA.SelectedValue = 1 And txtOtherANote.Text = "" Then
            errorMessage = "You have selected Yes for a. Other but have not entered an a. Other specify note. Please add a note or select No in the a. Other dropdown box."
            result = False
        End If
        If comboOtherA.SelectedValue <> 1 And txtOtherANote.Text <> "" Then
            errorMessage = "You have entered an a. Other specify note, but have not selected Yes in the a. Other dropdown box. Please clear the note or select Yes in the a. Other dropdown box."
            result = False
        End If
        If comboOtherB.SelectedValue = 1 And txtOtherBNote.Text = "" Then
            errorMessage = "You have selected Yes for b. Other but have not entered a b. Other specify note. Please add a note or select No in the b. Other dropdown box."
            result = False
        End If
        If comboOtherB.SelectedValue <> 1 And txtOtherBNote.Text <> "" Then
            errorMessage = "You have entered a b. Other specify note, but have not selected Yes in the b. Other dropdown box. Please clear the note or select Yes in the b. Other dropdown box."
            result = False
        End If
        If comboOtherC.SelectedValue = 1 And txtOtherCNote.Text = "" Then
            errorMessage = "You have selected Yes for c. Other but have not entered a c. Other specify note. Please add a note or select No in the c. Other dropdown box."
            result = False
        End If
        If comboOtherC.SelectedValue <> 1 And txtOtherCNote.Text <> "" Then
            errorMessage = "You have entered a c. Other specify note, but have not selected Yes in the c. Other dropdown box. Please clear the note or select Yes in the c. Other dropdown box."
            result = False
        End If

        'Invalid ABC score combination
        If cmbABC_Result.SelectedValue = 9 Then
            errorMessage += "- You have entered in invalid ABC score combination (usually a ""C"" score > 0 with an ""A"" score = 0)."
            result = False
        End If

        If result = False Then
            MsgBox(errorMessage & vbNewLine & vbNewLine & "These errors must be corrected before the record can be saved.", MsgBoxStyle.Exclamation, "Input Validation Error")
        End If
        Return result
    End Function

    'Helper subs
    Private Sub rebuildComboValues(sender As Object, e As EventArgs) Handles comboNormalBrain.SelectedValueChanged, comboNormalBrainSpecify.SelectedValueChanged, comboDefiniteAlzheimers.SelectedValueChanged, comboProbableAlzheimers.SelectedValueChanged, comboPossibleAlzheimers.SelectedValueChanged, comboPossibleAlzheimersSpecify.SelectedValueChanged, comboDefiniteParkinsons.SelectedValueChanged, comboDefiniteParkinsonsSpecify.SelectedValueChanged, comboUncertainParkinsons.SelectedValueChanged, comboInfarct.SelectedValueChanged, comboLacune.SelectedValueChanged, comboLacuneInfarct.SelectedValueChanged, comboBinswangers.SelectedValueChanged, comboHemo.SelectedValueChanged, combo7Other.SelectedValueChanged, comboPicks.SelectedValueChanged, comboLobar.SelectedValueChanged, comboCJD.SelectedValueChanged, comboDownsWAD.SelectedValueChanged, comboDownsWOAD.SelectedValueChanged, comboHuntingtons.SelectedValueChanged, comboLeuko.SelectedValueChanged, comboTumorPrim.SelectedValueChanged, comboTumorSec.SelectedValueChanged, comboAIDS.SelectedValueChanged, comboOtherA.SelectedValueChanged, comboOtherB.SelectedValueChanged, comboOtherC.SelectedValueChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View And WarehouseShell.DataMode <> WarehouseShell.userDataMode.Undefined Then
            buildComboValues()
        End If
    End Sub
    Private Sub setDxText(sender As Object, e As EventArgs) Handles comboDX1.SelectedValueChanged, comboDX2.SelectedValueChanged, comboDX3.SelectedValueChanged, comboDX4.SelectedValueChanged
        If sender Is comboDX1 Then
            txtDX1.Text = assignTextValues(comboDX1.Text)
            txtDX1Note.Text = assignNoteValues(comboDX1.Text)
        ElseIf sender Is comboDX2 Then
            txtDX2.Text = assignTextValues(comboDX2.Text)
            txtDX2Note.Text = assignNoteValues(comboDX2.Text)
        ElseIf sender Is comboDX3 Then
            txtDX3.Text = assignTextValues(comboDX3.Text)
            txtDX3Note.Text = assignNoteValues(comboDX3.Text)
        ElseIf sender Is comboDX4 Then
            txtDX4.Text = assignTextValues(comboDX4.Text)
            txtDX4Note.Text = assignNoteValues(comboDX4.Text)
        End If

    End Sub
    Private Function assignTextValues(ByVal SelectedText As String)
        Dim myText As String = ""
        Select Case SelectedText
            Case ""
                myText = ""
            Case "1a"
                myText = "Normal brain (a)"
            Case "1b"
                myText = "Normal brain (b)"
            Case "1c"
                myText = "Normal brain (c)"
            Case "1na"
                myText = "Normal brain (N/A)"
            Case "2"
                myText = "Definite Alzheimer's disease"
            Case "3"
                myText = "Probable Alzheimer's disease"
            Case "4a"
                myText = "Possible Alzheimer's disease (a)"
            Case "4b"
                myText = "Possible Alzheimer's disease (b)"
            Case "5a"
                myText = "Definite Parkinson's disease (a)"
            Case "5b"
                myText = "Definite Parkinson's disease (b)"
            Case "6"
                myText = "Uncertain Parkinson's disease"
            Case "7a"
                myText = "Vascular disease- Infarct(s) only"
            Case "7b"
                myText = "Vascular disease- Lacunar state only"
            Case "7c"
                myText = "Vascular disease- Combined lacunar and large infarctions"
            Case "7d"
                myText = "Vascular disease- Binswanger's disease"
            Case "7e"
                myText = "Vascular disease- Hemorrhage"
            Case "7f"
                myText = "Vascular disease- Other"
            Case "8"
                myText = "Pick's disease (with pick bodies)"
            Case "9"
                myText = "Lobar atrohpy (without pick bodies)"
            Case "10"
                myText = "CJD, spongiform encephalopathy"
            Case "11a"
                myText = "Clinical Down's syndrome with AD pathology"
            Case "11b"
                myText = "Clinical Down's syndrome without AD pathology"
            Case "12"
                myText = "Huntington's disease"
            Case "13"
                myText = "Leukoencephalopathy"
            Case "14a"
                myText = "Tumor- Primary"
            Case "14b"
                myText = "Tumor- Secondary"
            Case "15"
                myText = "AIDS encephalopathy due to HIV infection"
            Case "16a"
                myText = "Other (a)"
            Case "16b"
                myText = "Other (b)"
            Case "16c"
                myText = "Other (c)"
            Case "17"
                myText = "Lewy bodies without AD changes"
            Case "18"
                myText = "Lewy bodies with AD changes"
        End Select
        Return myText
    End Function
    Private Function assignNoteValues(ByVal SelectedText As String)
        Dim myText As String = ""
        Select Case SelectedText
            Case "7f"
                myText = txt7OtherNote.Text
            Case "13"
                myText = txtLeukoNote.Text
            Case "14a"
                myText = txtTumorPrimNote.Text
            Case "14b"
                myText = txtTumorSecNote.Text
            Case "16a"
                myText = txtOtherANote.Text
            Case "16b"
                myText = txtOtherBNote.Text
            Case "16c"
                myText = txtOtherCNote.Text
            Case Else
                myText = ""
        End Select
        Return myText
    End Function
    Private Sub buildComboValues()
        comboDX1.Items.Clear()
        comboDX2.Items.Clear()
        comboDX3.Items.Clear()
        comboDX4.Items.Clear()

        comboDX1.Items.Add("")
        comboDX2.Items.Add("")
        comboDX3.Items.Add("")
        comboDX4.Items.Add("")
        If comboNormalBrain.SelectedValue = 1 Then
            If comboNormalBrainSpecify.SelectedValue = "a " Then
                comboDX1.Items.Add("1a")
                comboDX2.Items.Add("1a")
                comboDX3.Items.Add("1a")
                comboDX4.Items.Add("1a")
            ElseIf comboNormalBrainSpecify.SelectedValue = "b " Then
                comboDX1.Items.Add("1b")
                comboDX2.Items.Add("1b")
                comboDX3.Items.Add("1b")
                comboDX4.Items.Add("1b")
            ElseIf comboNormalBrainSpecify.SelectedValue = "c " Then
                comboDX1.Items.Add("1c")
                comboDX2.Items.Add("1c")
                comboDX3.Items.Add("1c")
                comboDX4.Items.Add("1c")
            ElseIf comboNormalBrainSpecify.SelectedValue = "na" Then
                comboDX1.Items.Add("1na")
                comboDX2.Items.Add("1na")
                comboDX3.Items.Add("1na")
                comboDX4.Items.Add("1na")
            End If
        End If
        If comboDefiniteAlzheimers.SelectedValue = 1 Then
            comboDX1.Items.Add("2")
            comboDX2.Items.Add("2")
            comboDX3.Items.Add("2")
            comboDX4.Items.Add("2")
        End If
        If comboProbableAlzheimers.SelectedValue = 1 Then
            comboDX1.Items.Add("3")
            comboDX2.Items.Add("3")
            comboDX3.Items.Add("3")
            comboDX4.Items.Add("3")
        End If
        If comboPossibleAlzheimers.SelectedValue = 1 Then
            If comboPossibleAlzheimersSpecify.SelectedValue = "a " Then
                comboDX1.Items.Add("4a")
                comboDX2.Items.Add("4a")
                comboDX3.Items.Add("4a")
                comboDX4.Items.Add("4a")
            ElseIf comboPossibleAlzheimersSpecify.SelectedValue = "b " Then
                comboDX1.Items.Add("4b")
                comboDX2.Items.Add("4b")
                comboDX3.Items.Add("4b")
                comboDX4.Items.Add("4b")
            End If
        End If
        If comboDefiniteParkinsons.SelectedValue = 1 Then
            If comboDefiniteParkinsonsSpecify.SelectedValue = "a " Then
                comboDX1.Items.Add("5a")
                comboDX2.Items.Add("5a")
                comboDX3.Items.Add("5a")
                comboDX4.Items.Add("5a")
            ElseIf comboDefiniteParkinsonsSpecify.SelectedValue = "b " Then
                comboDX1.Items.Add("5b")
                comboDX2.Items.Add("5b")
                comboDX3.Items.Add("5b")
                comboDX4.Items.Add("5b")
            End If
        End If
        If comboUncertainParkinsons.SelectedValue = 1 Then
            comboDX1.Items.Add("6")
            comboDX2.Items.Add("6")
            comboDX3.Items.Add("6")
            comboDX4.Items.Add("6")
        End If
        If comboInfarct.SelectedValue = 1 Then
            comboDX1.Items.Add("7a")
            comboDX2.Items.Add("7a")
            comboDX3.Items.Add("7a")
            comboDX4.Items.Add("7a")
        End If
        If comboLacune.SelectedValue = 1 Then
            comboDX1.Items.Add("7b")
            comboDX2.Items.Add("7b")
            comboDX3.Items.Add("7b")
            comboDX4.Items.Add("7b")
        End If
        If comboLacuneInfarct.SelectedValue = 1 Then
            comboDX1.Items.Add("7c")
            comboDX2.Items.Add("7c")
            comboDX3.Items.Add("7c")
            comboDX4.Items.Add("7c")
        End If
        If comboBinswangers.SelectedValue = 1 Then
            comboDX1.Items.Add("7d")
            comboDX2.Items.Add("7d")
            comboDX3.Items.Add("7d")
            comboDX4.Items.Add("7d")
        End If
        If comboHemo.SelectedValue = 1 Then
            comboDX1.Items.Add("7e")
            comboDX2.Items.Add("7e")
            comboDX3.Items.Add("7e")
            comboDX4.Items.Add("7e")
        End If
        If combo7Other.SelectedValue = 1 Then
            comboDX1.Items.Add("7f")
            comboDX2.Items.Add("7f")
            comboDX3.Items.Add("7f")
            comboDX4.Items.Add("7f")
        End If
        If comboPicks.SelectedValue = 1 Then
            comboDX1.Items.Add("8")
            comboDX2.Items.Add("8")
            comboDX3.Items.Add("8")
            comboDX4.Items.Add("8")
        End If
        If comboLobar.SelectedValue = 1 Then
            comboDX1.Items.Add("9")
            comboDX2.Items.Add("9")
            comboDX3.Items.Add("9")
            comboDX4.Items.Add("9")
        End If
        If comboCJD.SelectedValue = 1 Then
            comboDX1.Items.Add("10")
            comboDX2.Items.Add("10")
            comboDX3.Items.Add("10")
            comboDX4.Items.Add("10")
        End If
        If comboDownsWAD.SelectedValue = 1 Then
            comboDX1.Items.Add("11a")
            comboDX2.Items.Add("11a")
            comboDX3.Items.Add("11a")
            comboDX4.Items.Add("11a")
        End If
        If comboDownsWOAD.SelectedValue = 1 Then
            comboDX1.Items.Add("11b")
            comboDX2.Items.Add("11b")
            comboDX3.Items.Add("11b")
            comboDX4.Items.Add("11b")
        End If
        If comboHuntingtons.SelectedValue = 1 Then
            comboDX1.Items.Add("12")
            comboDX2.Items.Add("12")
            comboDX3.Items.Add("12")
            comboDX4.Items.Add("12")
        End If
        If comboLeuko.SelectedValue = 1 Then
            comboDX1.Items.Add("13")
            comboDX2.Items.Add("13")
            comboDX3.Items.Add("13")
            comboDX4.Items.Add("13")
        End If
        If comboTumorPrim.SelectedValue = 1 Then
            comboDX1.Items.Add("14a")
            comboDX2.Items.Add("14a")
            comboDX3.Items.Add("14a")
            comboDX4.Items.Add("14a")
        End If
        If comboTumorSec.SelectedValue = 1 Then
            comboDX1.Items.Add("14b")
            comboDX2.Items.Add("14b")
            comboDX3.Items.Add("14b")
            comboDX4.Items.Add("14b")
        End If
        If comboAIDS.SelectedValue = 1 Then
            comboDX1.Items.Add("15")
            comboDX2.Items.Add("15")
            comboDX3.Items.Add("15")
            comboDX4.Items.Add("15")
        End If
        If comboOtherA.SelectedValue = 1 Then
            comboDX1.Items.Add("16a")
            comboDX2.Items.Add("16a")
            comboDX3.Items.Add("16a")
            comboDX4.Items.Add("16a")
        End If
        If comboOtherB.SelectedValue = 1 Then
            comboDX1.Items.Add("16b")
            comboDX2.Items.Add("16b")
            comboDX3.Items.Add("16b")
            comboDX4.Items.Add("16b")
        End If
        If comboOtherC.SelectedValue = 1 Then
            comboDX1.Items.Add("16c")
            comboDX2.Items.Add("16c")
            comboDX3.Items.Add("16c")
            comboDX4.Items.Add("16c")
        End If
        If cmbLewyWOAD.SelectedValue = 1 Then
            comboDX1.Items.Add("17")
            comboDX2.Items.Add("17")
            comboDX3.Items.Add("17")
            comboDX4.Items.Add("17")
        End If
        If cmbLewyWAD.SelectedValue = 1 Then
            comboDX1.Items.Add("18")
            comboDX2.Items.Add("18")
            comboDX3.Items.Add("18")
            comboDX4.Items.Add("18")
        End If
    End Sub
    Private Sub cmbABC_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbABC_A.SelectedValueChanged, cmbABC_B.SelectedValueChanged, cmbABC_C.SelectedValueChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.Undefined And WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
            If cmbABC_A.SelectedValue <> -1 And cmbABC_B.SelectedValue <> -1 And cmbABC_C.SelectedValue <> -1 Then
                If cmbABC_A.SelectedValue = 0 Then
                    If cmbABC_C.SelectedValue = 0 Then
                        cmbABC_Result.SelectedValue = 0
                    Else
                        cmbABC_Result.SelectedValue = 9
                    End If
                ElseIf cmbABC_A.SelectedValue = 1 Then
                    If cmbABC_C.SelectedValue = 0 Or cmbABC_C.SelectedValue = 1 Then
                        cmbABC_Result.SelectedValue = 1
                    Else
                        If cmbABC_B.SelectedValue = 0 Or cmbABC_B.SelectedValue = 1 Then
                            cmbABC_Result.SelectedValue = 1
                        Else
                            cmbABC_Result.SelectedValue = 2
                        End If
                    End If
                ElseIf cmbABC_A.SelectedValue = 2 Then
                    If cmbABC_B.SelectedValue = 0 Or cmbABC_B.SelectedValue = 1 Then
                        cmbABC_Result.SelectedValue = 1
                    Else
                        cmbABC_Result.SelectedValue = 2
                    End If
                ElseIf cmbABC_A.SelectedValue = 3 Then
                    If cmbABC_C.SelectedValue = 0 Or cmbABC_C.SelectedValue = 1 Then
                        If cmbABC_B.SelectedValue = 0 Or cmbABC_B.SelectedValue = 1 Then
                            cmbABC_Result.SelectedValue = 1
                        Else
                            cmbABC_Result.SelectedValue = 2
                        End If
                    Else
                        If cmbABC_B.SelectedValue = 0 Or cmbABC_B.SelectedValue = 1 Then
                            cmbABC_Result.SelectedValue = 1
                        ElseIf cmbABC_B.SelectedValue = 2 Then
                            cmbABC_Result.SelectedValue = 2
                        Else
                            cmbABC_Result.SelectedValue = 3
                        End If
                    End If
                End If
            End If
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
        btnCERADIJBottom.PerformClick()
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class