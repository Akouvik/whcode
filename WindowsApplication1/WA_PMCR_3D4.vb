Public Class WA_PMCR_3D4
    Implements IFormMethods
    Private formTables As New DataSet

    Private Sub WA_PMCR_3D4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Database.ExistingRecordCheck("PMCR_3D4", "SubNum = " & WarehouseShell.SubNum) Then
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            loadBaseForm()
            loadExistingData()
            btn3D4Bottom.Text = "Edit Record"
            btn3D4Top.Text = btn3D4Bottom.Text
        Else 'If it doesn't exist, change mode to Undefined and show user banner
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            lblNoRecord.Visible = True
            btn3D4Bottom.Text = "Add New Record"
            btn3D4Top.Text = btn3D4Bottom.Text
        End If
        enableInputFields(False)
    End Sub

    Private Sub loadBaseForm()
        WarehouseShell.highlightSelectedNode("WA_PMCR_tab3D4")
        'Nothing else needed here
    End Sub
    Private Sub loadExistingData() 'load all non-DGV values (handle DGV loads with separate subs)
        'Grab the individual record, based on RecordID, and assign values to their appropriate fields
        formTables.Tables.Add(Database.ReturnTable("PMCR_3D4", , "SubNum = " & WarehouseShell.SubNum))
        chkPsySurg70.setValue(formTables, "PMCR_3D4", "PsychoSurgePre70")
        chkPsySurg7080.setValue(formTables, "PMCR_3D4", "PsychoSurge7080")
        chkPsySurg80.setValue(formTables, "PMCR_3D4", "PsychoSurge80Pres")
        chkPsySurg12.setValue(formTables, "PMCR_3D4", "PsychoSurge12")
        chkPsySurg11.setValue(formTables, "PMCR_3D4", "PsychoSurge11")
        chkPsySurg10.setValue(formTables, "PMCR_3D4", "PsychoSurge10")
        chkPsySurg9.setValue(formTables, "PMCR_3D4", "PsychoSurge9")
        chkPsySurg8.setValue(formTables, "PMCR_3D4", "PsychoSurge8")
        chkPsySurg7.setValue(formTables, "PMCR_3D4", "PsychoSurge7")
        chkPsySurg6.setValue(formTables, "PMCR_3D4", "PsychoSurge6")
        chkPsySurg5.setValue(formTables, "PMCR_3D4", "PsychoSurge5")
        chkPsySurg4.setValue(formTables, "PMCR_3D4", "PsychoSurge4")
        chkPsySurg3.setValue(formTables, "PMCR_3D4", "PsychoSurge3")
        chkPsySurg2.setValue(formTables, "PMCR_3D4", "PsychoSurge2")
        chkPsySurg1.setValue(formTables, "PMCR_3D4", "PsychoSurge1")
        chkInsShock70.setValue(formTables, "PMCR_3D4", "InsShockPre70")
        chkInsShock7080.setValue(formTables, "PMCR_3D4", "InsShock7080")
        chkInsShock80.setValue(formTables, "PMCR_3D4", "InsShock80Pres")
        chkInsShock12.setValue(formTables, "PMCR_3D4", "InsShock12")
        chkInsShock11.setValue(formTables, "PMCR_3D4", "InsShock11")
        chkInsShock10.setValue(formTables, "PMCR_3D4", "InsShock10")
        chkInsShock9.setValue(formTables, "PMCR_3D4", "InsShock9")
        chkInsShock8.setValue(formTables, "PMCR_3D4", "InsShock8")
        chkInsShock7.setValue(formTables, "PMCR_3D4", "InsShock7")
        chkInsShock6.setValue(formTables, "PMCR_3D4", "InsShock6")
        chkInsShock5.setValue(formTables, "PMCR_3D4", "InsShock5")
        chkInsShock4.setValue(formTables, "PMCR_3D4", "InsShock4")
        chkInsShock3.setValue(formTables, "PMCR_3D4", "InsShock3")
        chkInsShock2.setValue(formTables, "PMCR_3D4", "InsShock2")
        chkInsShock1.setValue(formTables, "PMCR_3D4", "InsShock1")
        chkECT70.setValue(formTables, "PMCR_3D4", "ECTPre70")
        chkECT7080.setValue(formTables, "PMCR_3D4", "ECT7080")
        chkECT80.setValue(formTables, "PMCR_3D4", "ECT80Pres")
        chkECT12.setValue(formTables, "PMCR_3D4", "ECT12")
        chkECT11.setValue(formTables, "PMCR_3D4", "ECT11")
        chkECT10.setValue(formTables, "PMCR_3D4", "ECT10")
        chkECT9.setValue(formTables, "PMCR_3D4", "ECT9")
        chkECT8.setValue(formTables, "PMCR_3D4", "ECT8")
        chkECT7.setValue(formTables, "PMCR_3D4", "ECT7")
        chkECT6.setValue(formTables, "PMCR_3D4", "ECT6")
        chkECT5.setValue(formTables, "PMCR_3D4", "ECT5")
        chkECT4.setValue(formTables, "PMCR_3D4", "ECT4")
        chkECT3.setValue(formTables, "PMCR_3D4", "ECT3")
        chkECT2.setValue(formTables, "PMCR_3D4", "ECT2")
        chkECT1.setValue(formTables, "PMCR_3D4", "ECT1")
        chkAnticonv70.setValue(formTables, "PMCR_3D4", "AnticonPre70")
        chkAnticonv7080.setValue(formTables, "PMCR_3D4", "Anticon7080")
        chkAnticonv80.setValue(formTables, "PMCR_3D4", "Anticon80Pres")
        chkAnticonv12.setValue(formTables, "PMCR_3D4", "Anticon12")
        chkAnticonv11.setValue(formTables, "PMCR_3D4", "Anticon11")
        chkAnticonv10.setValue(formTables, "PMCR_3D4", "Anticon10")
        chkAnticonv9.setValue(formTables, "PMCR_3D4", "Anticon9")
        chkAnticonv8.setValue(formTables, "PMCR_3D4", "Anticon8")
        chkAnticonv7.setValue(formTables, "PMCR_3D4", "Anticon7")
        chkAnticonv6.setValue(formTables, "PMCR_3D4", "Anticon6")
        chkAnticonv5.setValue(formTables, "PMCR_3D4", "Anticon5")
        chkAnticonv4.setValue(formTables, "PMCR_3D4", "Anticon4")
        chkAnticonv3.setValue(formTables, "PMCR_3D4", "Anticon3")
        chkAnticonv2.setValue(formTables, "PMCR_3D4", "Anticon2")
        chkAnticonv1.setValue(formTables, "PMCR_3D4", "Anticon1")
        chkNeuroleptic70.setValue(formTables, "PMCR_3D4", "NeurolepticPre70")
        chkNeuroleptic7080.setValue(formTables, "PMCR_3D4", "Neuroleptic7080")
        chkNeuroleptic80.setValue(formTables, "PMCR_3D4", "Neuroleptic80Pres")
        chkNeuroleptic12.setValue(formTables, "PMCR_3D4", "Neuroleptic12")
        chkNeuroleptic11.setValue(formTables, "PMCR_3D4", "Neuroleptic11")
        chkNeuroleptic10.setValue(formTables, "PMCR_3D4", "Neuroleptic10")
        chkNeuroleptic9.setValue(formTables, "PMCR_3D4", "Neuroleptic9")
        chkNeuroleptic8.setValue(formTables, "PMCR_3D4", "Neuroleptic8")
        chkNeuroleptic7.setValue(formTables, "PMCR_3D4", "Neuroleptic7")
        chkNeuroleptic6.setValue(formTables, "PMCR_3D4", "Neuroleptic6")
        chkNeuroleptic5.setValue(formTables, "PMCR_3D4", "Neuroleptic5")
        chkNeuroleptic4.setValue(formTables, "PMCR_3D4", "Neuroleptic4")
        chkNeuroleptic3.setValue(formTables, "PMCR_3D4", "Neuroleptic3")
        chkNeuroleptic2.setValue(formTables, "PMCR_3D4", "Neuroleptic2")
        chkNeuroleptic1.setValue(formTables, "PMCR_3D4", "Neuroleptic1")
        chkAntichol70.setValue(formTables, "PMCR_3D4", "AnticholPre70")
        chkAntichol7080.setValue(formTables, "PMCR_3D4", "Antichol7080")
        chkAntichol80.setValue(formTables, "PMCR_3D4", "Antichol80Pres")
        chkAntichol12.setValue(formTables, "PMCR_3D4", "Antichol12")
        chkAntichol11.setValue(formTables, "PMCR_3D4", "Antichol11")
        chkAntichol10.setValue(formTables, "PMCR_3D4", "Antichol10")
        chkAntichol9.setValue(formTables, "PMCR_3D4", "Antichol9")
        chkAntichol8.setValue(formTables, "PMCR_3D4", "Antichol8")
        chkAntichol7.setValue(formTables, "PMCR_3D4", "Antichol7")
        chkAntichol6.setValue(formTables, "PMCR_3D4", "Antichol6")
        chkAntichol5.setValue(formTables, "PMCR_3D4", "Antichol5")
        chkAntichol4.setValue(formTables, "PMCR_3D4", "Antichol4")
        chkAntichol3.setValue(formTables, "PMCR_3D4", "Antichol3")
        chkAntichol2.setValue(formTables, "PMCR_3D4", "Antichol2")
        chkAntichol1.setValue(formTables, "PMCR_3D4", "Antichol1")
        chkTricyc70.setValue(formTables, "PMCR_3D4", "TricycPre70")
        chkTricyc7080.setValue(formTables, "PMCR_3D4", "Tricyc7080")
        chkTricyc80.setValue(formTables, "PMCR_3D4", "Tricyc80Pres")
        chkTricyc12.setValue(formTables, "PMCR_3D4", "Tricyc12")
        chkTricyc11.setValue(formTables, "PMCR_3D4", "Tricyc11")
        chkTricyc10.setValue(formTables, "PMCR_3D4", "Tricyc10")
        chkTricyc9.setValue(formTables, "PMCR_3D4", "Tricyc9")
        chkTricyc8.setValue(formTables, "PMCR_3D4", "Tricyc8")
        chkTricyc7.setValue(formTables, "PMCR_3D4", "Tricyc7")
        chkTricyc6.setValue(formTables, "PMCR_3D4", "Tricyc6")
        chkTricyc5.setValue(formTables, "PMCR_3D4", "Tricyc5")
        chkTricyc4.setValue(formTables, "PMCR_3D4", "Tricyc4")
        chkTricyc3.setValue(formTables, "PMCR_3D4", "Tricyc3")
        chkTricyc2.setValue(formTables, "PMCR_3D4", "Tricyc2")
        chkTricyc1.setValue(formTables, "PMCR_3D4", "Tricyc1")
        chkMAOI70.setValue(formTables, "PMCR_3D4", "MAOIPre70")
        chkMAOI7080.setValue(formTables, "PMCR_3D4", "MAOI7080")
        chkMAOI80.setValue(formTables, "PMCR_3D4", "MAOI80Pres")
        chkMAOI12.setValue(formTables, "PMCR_3D4", "MAOI12")
        chkMAOI11.setValue(formTables, "PMCR_3D4", "MAOI11")
        chkMAOI10.setValue(formTables, "PMCR_3D4", "MAOI10")
        chkMAOI9.setValue(formTables, "PMCR_3D4", "MAOI9")
        chkMAOI8.setValue(formTables, "PMCR_3D4", "MAOI8")
        chkMAOI7.setValue(formTables, "PMCR_3D4", "MAOI7")
        chkMAOI6.setValue(formTables, "PMCR_3D4", "MAOI6")
        chkMAOI5.setValue(formTables, "PMCR_3D4", "MAOI5")
        chkMAOI4.setValue(formTables, "PMCR_3D4", "MAOI4")
        chkMAOI3.setValue(formTables, "PMCR_3D4", "MAOI3")
        chkMAOI2.setValue(formTables, "PMCR_3D4", "MAOI2")
        chkMAOI1.setValue(formTables, "PMCR_3D4", "MAOI1")
        chkBenzo70.setValue(formTables, "PMCR_3D4", "BenzoPre70")
        chkBenzo7080.setValue(formTables, "PMCR_3D4", "Benzo7080")
        chkBenzo80.setValue(formTables, "PMCR_3D4", "Benzo80Pres")
        chkBenzo12.setValue(formTables, "PMCR_3D4", "Benzo12")
        chkBenzo11.setValue(formTables, "PMCR_3D4", "Benzo11")
        chkBenzo10.setValue(formTables, "PMCR_3D4", "Benzo10")
        chkBenzo9.setValue(formTables, "PMCR_3D4", "Benzo9")
        chkBenzo8.setValue(formTables, "PMCR_3D4", "Benzo8")
        chkBenzo7.setValue(formTables, "PMCR_3D4", "Benzo7")
        chkBenzo6.setValue(formTables, "PMCR_3D4", "Benzo6")
        chkBenzo5.setValue(formTables, "PMCR_3D4", "Benzo5")
        chkBenzo4.setValue(formTables, "PMCR_3D4", "Benzo4")
        chkBenzo3.setValue(formTables, "PMCR_3D4", "Benzo3")
        chkBenzo2.setValue(formTables, "PMCR_3D4", "Benzo2")
        chkBenzo1.setValue(formTables, "PMCR_3D4", "Benzo1")
        chkCA70.setValue(formTables, "PMCR_3D4", "CABlockPre70")
        chkCA7080.setValue(formTables, "PMCR_3D4", "CABlock7080")
        chkCA80.setValue(formTables, "PMCR_3D4", "CABlock80Pres")
        chkCA12.setValue(formTables, "PMCR_3D4", "CABlock12")
        chkCA11.setValue(formTables, "PMCR_3D4", "CABlock11")
        chkCA10.setValue(formTables, "PMCR_3D4", "CABlock10")
        chkCA9.setValue(formTables, "PMCR_3D4", "CABlock9")
        chkCA8.setValue(formTables, "PMCR_3D4", "CABlock8")
        chkCA7.setValue(formTables, "PMCR_3D4", "CABlock7")
        chkCA6.setValue(formTables, "PMCR_3D4", "CABlock6")
        chkCA5.setValue(formTables, "PMCR_3D4", "CABlock5")
        chkCA4.setValue(formTables, "PMCR_3D4", "CABlock4")
        chkCA3.setValue(formTables, "PMCR_3D4", "CABlock3")
        chkCA2.setValue(formTables, "PMCR_3D4", "CABlock2")
        chkCA1.setValue(formTables, "PMCR_3D4", "CABlock1")
        chkOthSed70.setValue(formTables, "PMCR_3D4", "OthSedPre70")
        chkOthSed7080.setValue(formTables, "PMCR_3D4", "OthSed7080")
        chkOthSed80.setValue(formTables, "PMCR_3D4", "OthSed80Pres")
        chkOthSed12.setValue(formTables, "PMCR_3D4", "OthSed12")
        chkOthSed11.setValue(formTables, "PMCR_3D4", "OthSed11")
        chkOthSed10.setValue(formTables, "PMCR_3D4", "OthSed10")
        chkOthSed9.setValue(formTables, "PMCR_3D4", "OthSed9")
        chkOthSed8.setValue(formTables, "PMCR_3D4", "OthSed8")
        chkOthSed7.setValue(formTables, "PMCR_3D4", "OthSed7")
        chkOthSed6.setValue(formTables, "PMCR_3D4", "OthSed6")
        chkOthSed5.setValue(formTables, "PMCR_3D4", "OthSed5")
        chkOthSed4.setValue(formTables, "PMCR_3D4", "OthSed4")
        chkOthSed3.setValue(formTables, "PMCR_3D4", "OthSed3")
        chkOthSed2.setValue(formTables, "PMCR_3D4", "OthSed2")
        chkOthSed1.setValue(formTables, "PMCR_3D4", "OthSed1")
    End Sub
    Private Sub enableInputFields(ByVal bool As Boolean)
        If bool = True Then
            grp3D4.Enabled = True
        Else
            grp3D4.Enabled = False
        End If
    End Sub
    Private Sub btn3D4_Click(sender As Object, e As EventArgs) Handles btn3D4Bottom.Click, btn3D4Top.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_PMCR_3D4", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                btn3D4Bottom.Text = "Save Changes"
                btn3D4Top.Text = btn3D4Bottom.Text
                enableInputFields(True)
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If User.PermissionCheck("WA_PMCR_3D4", "Modify") Then
                loadBaseForm()
                lblNoRecord.Visible = False
                btn3D4Bottom.Text = "Save New Record"
                btn3D4Top.Text = "Save New Record"
                enableInputFields(True)
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
            End If
        Else 'By default, user is attempting to Insert or Edit a record. Run preSaveValidation.
            If preSaveValidation() Then 'If preSaveValidation returns true, take Insert or Update actions.
                'Same parameters for Insert or Update SP's, so define here
                Dim parameters = " @SubNum = " & WarehouseShell.SubNum &
                    ", @PsychoSurgePre70 = " & chkPsySurg70.getSQLValue() &
                    ", @PsychoSurge7080 = " & chkPsySurg7080.getSQLValue() &
                    ", @PsychoSurge80Pres = " & chkPsySurg80.getSQLValue() &
                    ", @PsychoSurge12 = " & chkPsySurg12.getSQLValue() &
                    ", @PsychoSurge11 = " & chkPsySurg11.getSQLValue() &
                    ", @PsychoSurge10 = " & chkPsySurg10.getSQLValue() &
                    ", @PsychoSurge9 = " & chkPsySurg9.getSQLValue() &
                    ", @PsychoSurge8 = " & chkPsySurg8.getSQLValue() &
                    ", @PsychoSurge7 = " & chkPsySurg7.getSQLValue() &
                    ", @PsychoSurge6 = " & chkPsySurg6.getSQLValue() &
                    ", @PsychoSurge5 = " & chkPsySurg5.getSQLValue() &
                    ", @PsychoSurge4 = " & chkPsySurg4.getSQLValue() &
                    ", @PsychoSurge3 = " & chkPsySurg3.getSQLValue() &
                    ", @PsychoSurge2 = " & chkPsySurg2.getSQLValue() &
                    ", @PsychoSurge1 = " & chkPsySurg1.getSQLValue() &
                    ", @InsShockPre70 = " & chkInsShock70.getSQLValue() &
                    ", @InsShock7080 = " & chkInsShock7080.getSQLValue() &
                    ", @InsShock80Pres = " & chkInsShock80.getSQLValue() &
                    ", @InsShock12 = " & chkInsShock12.getSQLValue() &
                    ", @InsShock11 = " & chkInsShock11.getSQLValue() &
                    ", @InsShock10 = " & chkInsShock10.getSQLValue() &
                    ", @InsShock9 = " & chkInsShock9.getSQLValue() &
                    ", @InsShock8 = " & chkInsShock8.getSQLValue() &
                    ", @InsShock7 = " & chkInsShock7.getSQLValue() &
                    ", @InsShock6 = " & chkInsShock6.getSQLValue() &
                    ", @InsShock5 = " & chkInsShock5.getSQLValue() &
                    ", @InsShock4 = " & chkInsShock4.getSQLValue() &
                    ", @InsShock3 = " & chkInsShock3.getSQLValue() &
                    ", @InsShock2 = " & chkInsShock2.getSQLValue() &
                    ", @InsShock1 = " & chkInsShock1.getSQLValue() &
                    ", @ECTPre70 = " & chkECT70.getSQLValue() &
                    ", @ECT7080 = " & chkECT7080.getSQLValue() &
                    ", @ECT80Pres = " & chkECT80.getSQLValue() &
                    ", @ECT12 = " & chkECT12.getSQLValue() &
                    ", @ECT11 = " & chkECT11.getSQLValue() &
                    ", @ECT10 = " & chkECT10.getSQLValue() &
                    ", @ECT9 = " & chkECT9.getSQLValue() &
                    ", @ECT8 = " & chkECT8.getSQLValue() &
                    ", @ECT7 = " & chkECT7.getSQLValue() &
                    ", @ECT6 = " & chkECT6.getSQLValue() &
                    ", @ECT5 = " & chkECT5.getSQLValue() &
                    ", @ECT4 = " & chkECT4.getSQLValue() &
                    ", @ECT3 = " & chkECT3.getSQLValue() &
                    ", @ECT2 = " & chkECT2.getSQLValue() &
                    ", @ECT1 = " & chkECT1.getSQLValue() &
                    ", @AnticonPre70 = " & chkAnticonv70.getSQLValue() &
                    ", @Anticon7080 = " & chkAnticonv7080.getSQLValue() &
                    ", @Anticon80Pres = " & chkAnticonv80.getSQLValue() &
                    ", @Anticon12 = " & chkAnticonv12.getSQLValue() &
                    ", @Anticon11 = " & chkAnticonv11.getSQLValue() &
                    ", @Anticon10 = " & chkAnticonv10.getSQLValue() &
                    ", @Anticon9 = " & chkAnticonv9.getSQLValue() &
                    ", @Anticon8 = " & chkAnticonv8.getSQLValue() &
                    ", @Anticon7 = " & chkAnticonv7.getSQLValue() &
                    ", @Anticon6 = " & chkAnticonv6.getSQLValue() &
                    ", @Anticon5 = " & chkAnticonv5.getSQLValue() &
                    ", @Anticon4 = " & chkAnticonv4.getSQLValue() &
                    ", @Anticon3 = " & chkAnticonv3.getSQLValue() &
                    ", @Anticon2 = " & chkAnticonv2.getSQLValue() &
                    ", @Anticon1 = " & chkAnticonv1.getSQLValue() &
                    ", @NeurolepticPre70 = " & chkNeuroleptic70.getSQLValue() &
                    ", @Neuroleptic7080 = " & chkNeuroleptic7080.getSQLValue() &
                    ", @Neuroleptic80Pres = " & chkNeuroleptic80.getSQLValue() &
                    ", @Neuroleptic12 = " & chkNeuroleptic12.getSQLValue() &
                    ", @Neuroleptic11 = " & chkNeuroleptic11.getSQLValue() &
                    ", @Neuroleptic10 = " & chkNeuroleptic10.getSQLValue() &
                    ", @Neuroleptic9 = " & chkNeuroleptic9.getSQLValue() &
                    ", @Neuroleptic8 = " & chkNeuroleptic8.getSQLValue() &
                    ", @Neuroleptic7 = " & chkNeuroleptic7.getSQLValue() &
                    ", @Neuroleptic6 = " & chkNeuroleptic6.getSQLValue() &
                    ", @Neuroleptic5 = " & chkNeuroleptic5.getSQLValue() &
                    ", @Neuroleptic4 = " & chkNeuroleptic4.getSQLValue() &
                    ", @Neuroleptic3 = " & chkNeuroleptic3.getSQLValue() &
                    ", @Neuroleptic2 = " & chkNeuroleptic2.getSQLValue() &
                    ", @Neuroleptic1 = " & chkNeuroleptic1.getSQLValue() &
                    ", @AnticholPre70 = " & chkAntichol70.getSQLValue() &
                    ", @Antichol7080 = " & chkAntichol7080.getSQLValue() &
                    ", @Antichol80Pres = " & chkAntichol80.getSQLValue() &
                    ", @Antichol12 = " & chkAntichol12.getSQLValue() &
                    ", @Antichol11 = " & chkAntichol11.getSQLValue() &
                    ", @Antichol10 = " & chkAntichol10.getSQLValue() &
                    ", @Antichol9 = " & chkAntichol9.getSQLValue() &
                    ", @Antichol8 = " & chkAntichol8.getSQLValue() &
                    ", @Antichol7 = " & chkAntichol7.getSQLValue() &
                    ", @Antichol6 = " & chkAntichol6.getSQLValue() &
                    ", @Antichol5 = " & chkAntichol5.getSQLValue() &
                    ", @Antichol4 = " & chkAntichol4.getSQLValue() &
                    ", @Antichol3 = " & chkAntichol3.getSQLValue() &
                    ", @Antichol2 = " & chkAntichol2.getSQLValue() &
                    ", @Antichol1 = " & chkAntichol1.getSQLValue() &
                    ", @TricycPre70 = " & chkTricyc70.getSQLValue() &
                    ", @Tricyc7080 = " & chkTricyc7080.getSQLValue() &
                    ", @Tricyc80Pres = " & chkTricyc80.getSQLValue() &
                    ", @Tricyc12 = " & chkTricyc12.getSQLValue() &
                    ", @Tricyc11 = " & chkTricyc11.getSQLValue() &
                    ", @Tricyc10 = " & chkTricyc10.getSQLValue() &
                    ", @Tricyc9 = " & chkTricyc9.getSQLValue() &
                    ", @Tricyc8 = " & chkTricyc8.getSQLValue() &
                    ", @Tricyc7 = " & chkTricyc7.getSQLValue() &
                    ", @Tricyc6 = " & chkTricyc6.getSQLValue() &
                    ", @Tricyc5 = " & chkTricyc5.getSQLValue() &
                    ", @Tricyc4 = " & chkTricyc4.getSQLValue() &
                    ", @Tricyc3 = " & chkTricyc3.getSQLValue() &
                    ", @Tricyc2 = " & chkTricyc2.getSQLValue() &
                    ", @Tricyc1 = " & chkTricyc1.getSQLValue() &
                    ", @MAOIPre70 = " & chkMAOI70.getSQLValue() &
                    ", @MAOI7080 = " & chkMAOI7080.getSQLValue() &
                    ", @MAOI80Pres = " & chkMAOI80.getSQLValue() &
                    ", @MAOI12 = " & chkMAOI12.getSQLValue() &
                    ", @MAOI11 = " & chkMAOI11.getSQLValue() &
                    ", @MAOI10 = " & chkMAOI10.getSQLValue() &
                    ", @MAOI9 = " & chkMAOI9.getSQLValue() &
                    ", @MAOI8 = " & chkMAOI8.getSQLValue() &
                    ", @MAOI7 = " & chkMAOI7.getSQLValue() &
                    ", @MAOI6 = " & chkMAOI6.getSQLValue() &
                    ", @MAOI5 = " & chkMAOI5.getSQLValue() &
                    ", @MAOI4 = " & chkMAOI4.getSQLValue() &
                    ", @MAOI3 = " & chkMAOI3.getSQLValue() &
                    ", @MAOI2 = " & chkMAOI2.getSQLValue() &
                    ", @MAOI1 = " & chkMAOI1.getSQLValue() &
                    ", @BenzoPre70 = " & chkBenzo70.getSQLValue() &
                    ", @Benzo7080 = " & chkBenzo7080.getSQLValue() &
                    ", @Benzo80Pres = " & chkBenzo80.getSQLValue() &
                    ", @Benzo12 = " & chkBenzo12.getSQLValue() &
                    ", @Benzo11 = " & chkBenzo11.getSQLValue() &
                    ", @Benzo10 = " & chkBenzo10.getSQLValue() &
                    ", @Benzo9 = " & chkBenzo9.getSQLValue() &
                    ", @Benzo8 = " & chkBenzo8.getSQLValue() &
                    ", @Benzo7 = " & chkBenzo7.getSQLValue() &
                    ", @Benzo6 = " & chkBenzo6.getSQLValue() &
                    ", @Benzo5 = " & chkBenzo5.getSQLValue() &
                    ", @Benzo4 = " & chkBenzo4.getSQLValue() &
                    ", @Benzo3 = " & chkBenzo3.getSQLValue() &
                    ", @Benzo2 = " & chkBenzo2.getSQLValue() &
                    ", @Benzo1 = " & chkBenzo1.getSQLValue() &
                    ", @CABlockPre70 = " & chkCA70.getSQLValue() &
                    ", @CABlock7080 = " & chkCA7080.getSQLValue() &
                    ", @CABlock80Pres = " & chkCA80.getSQLValue() &
                    ", @CABlock12 = " & chkCA12.getSQLValue() &
                    ", @CABlock11 = " & chkCA11.getSQLValue() &
                    ", @CABlock10 = " & chkCA10.getSQLValue() &
                    ", @CABlock9 = " & chkCA9.getSQLValue() &
                    ", @CABlock8 = " & chkCA8.getSQLValue() &
                    ", @CABlock7 = " & chkCA7.getSQLValue() &
                    ", @CABlock6 = " & chkCA6.getSQLValue() &
                    ", @CABlock5 = " & chkCA5.getSQLValue() &
                    ", @CABlock4 = " & chkCA4.getSQLValue() &
                    ", @CABlock3 = " & chkCA3.getSQLValue() &
                    ", @CABlock2 = " & chkCA2.getSQLValue() &
                    ", @CABlock1 = " & chkCA1.getSQLValue() &
                    ", @OthSedPre70 = " & chkOthSed70.getSQLValue() &
                    ", @OthSed7080 = " & chkOthSed7080.getSQLValue() &
                    ", @OthSed80Pres = " & chkOthSed80.getSQLValue() &
                    ", @OthSed12 = " & chkOthSed12.getSQLValue() &
                    ", @OthSed11 = " & chkOthSed11.getSQLValue() &
                    ", @OthSed10 = " & chkOthSed10.getSQLValue() &
                    ", @OthSed9 = " & chkOthSed9.getSQLValue() &
                    ", @OthSed8 = " & chkOthSed8.getSQLValue() &
                    ", @OthSed7 = " & chkOthSed7.getSQLValue() &
                    ", @OthSed6 = " & chkOthSed6.getSQLValue() &
                    ", @OthSed5 = " & chkOthSed5.getSQLValue() &
                    ", @OthSed4 = " & chkOthSed4.getSQLValue() &
                    ", @OthSed3 = " & chkOthSed3.getSQLValue() &
                    ", @OthSed2 = " & chkOthSed2.getSQLValue() &
                    ", @OthSed1 = " & chkOthSed1.getSQLValue() &
                    ", @LastModBy = '" & WarehouseShell.userName & "';"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    Dim cmd As New SqlCommand("Exec modPMCR_3D4Record @Action = 1, " & parameters, WarehouseShell.conn)
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Save successful", MsgBoxStyle.OkOnly)
                        enableInputFields(False)
                        btn3D4Bottom.Text = "Edit Record"
                        btn3D4Top.Text = "Edit Record"
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else 'If this clause is invoked, datamode must be Edit
                    Dim cmd As New SqlCommand("Exec modPMCR_3D4Record @Action = 2, " & parameters, WarehouseShell.conn)
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Save successful", MsgBoxStyle.OkOnly)
                        enableInputFields(False)
                        btn3D4Bottom.Text = "Edit Record"
                        btn3D4Top.Text = "Edit Record"
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                End If
            End If
        End If
    End Sub
    Private Function preSaveValidation() As Boolean
        Return True
    End Function

    'Imported IForm Methods
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
    Public Sub Parent1(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
        btn3D4Bottom.PerformClick()
    End Sub
    Public Sub Show1() Implements IFormMethods.Show
        Show()
    End Sub
    Public Sub ShowPHI(val As Boolean) Implements IFormMethods.ShowPHI
    End Sub
    Public Sub TopLevel(val As Boolean) Implements IFormMethods.TopLevel
        TopLevel(val)
    End Sub
End Class