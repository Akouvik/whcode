Imports System.IO

Public Class WA_AutopsyDissectionMap
    Implements IFormMethods

    Private insertString As String = Nothing
    Private updateString As String = Nothing
    Private formTables As New DataSet
    Private tooltip1 As New ToolTip
    Private SliceBox As TextBox_ = Nothing

    'Load form and set data mode
    Private Sub WA_DissectionMapping_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_AutopsyDissectionMap")
        If Database.ExistingRecordCheck("AutopsyDissectionMap", "SubNum = " & WarehouseShell.SubNum) = True Then
            loadBaseForm()
            loadFileData()
            loadExistingData()
            btnDissectionMapBottom.Text = "Edit this record"
            btnDissectionMapTop.Text = btnDissectionMapBottom.Text
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            enableInputFields(False)
        Else
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            btnDissectionMapTop.Text = "Add New Record"
            btnDissectionMapBottom.Text = btnDissectionMapTop.Text
            loadFileData()
            enableInputFields(False)
            lblNoRecord.Visible = True
        End If
    End Sub
    'Grab applicable lookup tables and assign the actual lookup values
    Private Sub loadBaseForm()
        'Load all required lookup tables into the comboValues DataSet
        formTables.Tables.Add(Database.ReturnTable("lkpDissectionMapHemispheres", , , "Label desc"))
        'Assign lookup values to each individual combobox
        comboHemisphere.assignLookup(formTables, "lkpDissectionMapHemispheres")
    End Sub
    'Sub to set default value for combo boxes. NOT called for view or edit modes.
    Private Sub defaultComboValues()
        comboHemisphere.SelectedIndex = 1
        chkHepFollowed.Checked = True
        chkToxFollowed.Checked = True
        chkPaxFollowed.Checked = True
        chkRightFixed.Checked = True
        chkLeftFrozen.Checked = True
    End Sub
    'Sub to load existing values into form for View/Edit modes
    Private Sub loadExistingData()
        formTables.Tables.Add(Database.ReturnTable("viewAutopsyDissectionMap", , "SubNum = " & WarehouseShell.SubNum))
        comboHemisphere.SelectedValue = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("HemisphereValue")
        tagLoadCombo("MuscleTaken", chkMuscle)
        tagLoadCombo("HairTaken", chkHair)
        tagLoadCombo("SkinTaken", chkSkin)
        tagLoadCombo("DuraTaken", chkDura)
        tagLoadCombo("LrgBldVslTaken", chkLrgBldVsl)
        tagLoadCombo("LeptoTaken", chkLepto)
        tagLoadCombo("ChoroidTaken", chkChoroid)
        tagLoadCombo("RtOLFTaken", chkRtOLF)
        tagLoadCombo("LtOLFTaken", chkLtOLF)
        tagLoadCombo("Cere1Taken", chkCere1)
        tagLoadCombo("Cere2Taken", chkCere2)
        tagLoadCombo("Cere3Taken", chkCere3)
        tagLoadCombo("Cere4Taken", chkCere4)
        tagLoadCombo("PituitTaken", chkPituit)
        tagLoadCombo("BSMidTaken", chkBSMid)
        tagLoadCombo("BSPonsTaken", chkBSPons)
        tagLoadCombo("BSMedTaken", chkBSMed)
        tagLoadCombo("Oth1Taken", chkOth1)
        tagLoadCombo("Oth2Taken", chkOth2)
        tagLoadCombo("Oth3Taken", chkOth3)
        txtMuscleTagNum.setValue(formTables, "viewAutopsyDissectionMap", "MuscleTagNum")
        txtHairTagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("HairTagNum").ToString
        txtSkinTagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("SkinTagNum").ToString
        txtDuraTagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("DuraTagNum").ToString
        txtLrgBldVslTagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("LrgBldVslTagNum").ToString
        txtLeptoTagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("LeptoTagNum").ToString
        txtChoroidTagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("ChoroidTagNum").ToString
        txtRtOLFTagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("RtOLFTagNum").ToString
        txtLtOLFTagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("LtOLFTagNum").ToString
        txtCere1TagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Cere1TagNum").ToString
        txtCere2TagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Cere2TagNum").ToString
        txtCere3TagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Cere3TagNum").ToString
        txtCere4TagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Cere4TagNum").ToString
        txtPituitTagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("PituitTagNum").ToString
        txtBSMidTagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("BSMidTagNum").ToString
        txtBSPonsTagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("BSPonsTagNum").ToString
        txtBSMedTagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("BSMedTagNum").ToString
        txtOth1TagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Oth1TagNum").ToString
        txtOth2TagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Oth2TagNum").ToString
        txtOth3TagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Oth3TagNum").ToString
        txtOth1Desc.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Oth1Desc").ToString
        txtOth2Desc.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Oth2Desc").ToString
        txtOth3Desc.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Oth3Desc").ToString
        txtSlice1TagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice1TagNum").ToString
        txtSlice2TagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice2TagNum").ToString
        txtSlice3TagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice3TagNum").ToString
        txtSlice4TagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice4TagNum").ToString
        txtSlice5TagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice5TagNum").ToString
        txtSlice6TagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice6TagNum").ToString
        txtSlice7TagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice7TagNum").ToString
        txtSlice8TagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice8TagNum").ToString
        txtSlice9TagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice9TagNum").ToString
        txtSlice10TagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice10TagNum").ToString
        txtSlice11TagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice11TagNum").ToString
        txtSlice12TagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice12TagNum").ToString
        txtSlice13TagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice13TagNum").ToString
        txtSlice14TagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice14TagNum").ToString
        txtSlice15TagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice15TagNum").ToString
        txtSlice16TagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice16TagNum").ToString
        txtSlice17tagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice17TagNum").ToString
        txtSlice18TagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice18TagNum").ToString
        txtSlice19TagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice19TagNum").ToString
        txtSlice20TagNum.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice20TagNum").ToString
        txtSlice1.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice1MapLevels").ToString
        txtSlice2.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice2MapLevels").ToString
        txtSlice3.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice3MapLevels").ToString
        txtSlice4.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice4MapLevels").ToString
        txtSlice5.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice5MapLevels").ToString
        txtSlice6.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice6MapLevels").ToString
        txtSlice7.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice7MapLevels").ToString
        txtSlice8.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice8MapLevels").ToString
        txtSlice9.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice9MapLevels").ToString
        txtSlice10.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice10MapLevels").ToString
        txtSlice11.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice11MapLevels").ToString
        txtSlice12.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice12MapLevels").ToString
        txtSlice13.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice13MapLevels").ToString
        txtSlice14.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice14MapLevels").ToString
        txtSlice15.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice15MapLevels").ToString
        txtSlice16.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice16MapLevels").ToString
        txtSlice17.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice17MapLevels").ToString
        txtSlice18.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice18MapLevels").ToString
        txtSlice19.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice19MapLevels").ToString
        txtSlice20.Text = formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice20MapLevels").ToString
        txtGrossObservations.Text = IIf(formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("GrossObservations").ToString() = "NULL", "", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("GrossObservations").ToString())
        chkHepFollowed.setValue(formTables, "viewAutopsyDissectionMap", "HepFollowed")
        chkToxFollowed.setValue(formTables, "viewAutopsyDissectionMap", "ToxFollowed")
        chkPaxFollowed.setValue(formTables, "viewAutopsyDissectionMap", "PaxFollowed")
        chkPanosFollowed.setValue(formTables, "viewAutopsyDissectionMap", "PanosFollowed")
        chkRightFixed.setValue(formTables, "viewAutopsyDissectionMap", "RightFixed")
        chkLeftFixed.setValue(formTables, "viewAutopsyDissectionMap", "LeftFixed")
        chkRightFrozen.setValue(formTables, "viewAutopsyDissectionMap", "RightFrozen")
        chkLeftFrozen.setValue(formTables, "viewAutopsyDissectionMap", "LeftFrozen")
    End Sub

    'Sub to load image data (ran on load, regardless of mode)
    Private Sub loadFileData()
        If CheckFile("Composite") Then
            btnComposite.Text = "View"
            btnComposite.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnCompositeRemove.Enabled = True
            Else
                btnCompositeRemove.Enabled = False
            End If
        Else
            btnComposite.Text = "Add"
            btnComposite.BackColor = Color.Linen
            btnCompositeRemove.Enabled = False
        End If
        If CheckFile("Dorsal") Then
            btnDorsal.Text = "View"
            btnDorsal.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnDorsalRemove.Enabled = True
            Else
                btnDorsalRemove.Enabled = False
            End If
        Else
            btnDorsal.Text = "Add"
            btnDorsal.BackColor = Color.Linen
            btnDorsalRemove.Enabled = False
        End If
        If CheckFile("Ventral") Then
            btnVentral.Text = "View"
            btnVentral.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnVentralRemove.Enabled = True
            Else
                btnVentralRemove.Enabled = False
            End If
        Else
            btnVentral.Text = "Add"
            btnVentral.BackColor = Color.Linen
            btnVentralRemove.Enabled = False
        End If
        If CheckFile("Right Lateral") Then
            btnRightLateral.Text = "View"
            btnRightLateral.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnRightLateralRemove.Enabled = True
            Else
                btnRightLateralRemove.Enabled = False
            End If
        Else
            btnRightLateral.Text = "Add"
            btnRightLateral.BackColor = Color.Linen
            btnRightLateralRemove.Enabled = False
        End If
        If CheckFile("Right Medial") Then
            btnRightMedial.Text = "View"
            btnRightMedial.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnRightMedialRemove.Enabled = True
            Else
                btnRightMedialRemove.Enabled = False
            End If
        Else
            btnRightMedial.Text = "Add"
            btnRightMedial.BackColor = Color.Linen
            btnRightMedialRemove.Enabled = False
        End If
        If CheckFile("Left Lateral") Then
            btnLeftLateral.Text = "View"
            btnLeftLateral.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnLeftLateralRemove.Enabled = True
            Else
                btnLeftLateralRemove.Enabled = False
            End If
        Else
            btnLeftLateral.Text = "Add"
            btnLeftLateral.BackColor = Color.Linen
            btnLeftLateralRemove.Enabled = False
        End If
        If CheckFile("Left Medial") Then
            btnLeftMedial.Text = "View"
            btnLeftMedial.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnLeftMedialRemove.Enabled = True
            Else
                btnLeftMedialRemove.Enabled = False
            End If
        Else
            btnLeftMedial.Text = "Add"
            btnLeftMedial.BackColor = Color.Linen
            btnLeftMedialRemove.Enabled = False
        End If
        If CheckFile("Sections 1") Then
            btnSections1.Text = "View"
            btnSections1.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnSections1Remove.Enabled = True
            Else
                btnSections1Remove.Enabled = False
            End If
        Else
            btnSections1.Text = "Add"
            btnSections1.BackColor = Color.Linen
            btnSections1Remove.Enabled = False
        End If
        If CheckFile("Sections 2") Then
            btnSections2.Text = "View"
            btnSections2.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnSections2Remove.Enabled = True
            Else
                btnSections2Remove.Enabled = False
            End If
        Else
            btnSections2.Text = "Add"
            btnSections2.BackColor = Color.Linen
            btnSections2Remove.Enabled = False
        End If
        If CheckFile("Dura") Then
            btnDura.Text = "View"
            btnDura.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnDuraRemove.Enabled = True
            Else
                btnDuraRemove.Enabled = False
            End If
        Else
            btnDura.Text = "Add"
            btnDura.BackColor = Color.Linen
            btnDuraRemove.Enabled = False
        End If
        If CheckFile("Other 1") Then
            btnOther1.Text = "View"
            btnOther1.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnOther1Remove.Enabled = True
            Else
                btnOther1Remove.Enabled = False
            End If
        Else
            btnOther1.Text = "Add"
            btnOther1.BackColor = Color.Linen
            btnOther1Remove.Enabled = False
        End If
        If CheckFile("Other 2") Then
            btnOther2.Text = "View"
            btnOther2.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnOther2Remove.Enabled = True
            Else
                btnOther2Remove.Enabled = False
            End If
        Else
            btnOther2.Text = "Add"
            btnOther2.BackColor = Color.Linen
            btnOther2Remove.Enabled = False
        End If
        If CheckFile("Other 3") Then
            btnOther3.Text = "View"
            btnOther3.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnOther3Remove.Enabled = True
            Else
                btnOther3Remove.Enabled = False
            End If
        Else
            btnOther3.Text = "Add"
            btnOther3.BackColor = Color.Linen
            btnOther3Remove.Enabled = False
        End If
        If CheckFile("Other 4") Then
            btnOther4.Text = "View"
            btnOther4.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnOther4Remove.Enabled = True
            Else
                btnOther4Remove.Enabled = False
            End If
        Else
            btnOther4.Text = "Add"
            btnOther4.BackColor = Color.Linen
            btnOther4Remove.Enabled = False
        End If
        If CheckFile("Other 5") Then
            btnOther5.Text = "View"
            btnOther5.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnOther5Remove.Enabled = True
            Else
                btnOther5Remove.Enabled = False
            End If
        Else
            btnOther5.Text = "Add"
            btnOther5.BackColor = Color.Linen
            btnOther5Remove.Enabled = False
        End If
        If CheckFile("Other 6") Then
            btnOther6.Text = "View"
            btnOther6.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnOther6Remove.Enabled = True
            Else
                btnOther6Remove.Enabled = False
            End If
        Else
            btnOther6.Text = "Add"
            btnOther6.BackColor = Color.Linen
            btnOther6Remove.Enabled = False
        End If
        If CheckFile("Other 7") Then
            btnOther7.Text = "View"
            btnOther7.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnOther7Remove.Enabled = True
            Else
                btnOther7Remove.Enabled = False
            End If
        Else
            btnOther7.Text = "Add"
            btnOther7.BackColor = Color.Linen
            btnOther7Remove.Enabled = False
        End If
        If CheckFile("Other 8") Then
            btnOther8.Text = "View"
            btnOther8.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnOther8Remove.Enabled = True
            Else
                btnOther8Remove.Enabled = False
            End If
        Else
            btnOther8.Text = "Add"
            btnOther8.BackColor = Color.Linen
            btnOther8Remove.Enabled = False
        End If
        If CheckFile("Other 9") Then
            btnOther9.Text = "View"
            btnOther9.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnOther9Remove.Enabled = True
            Else
                btnOther9Remove.Enabled = False
            End If
        Else
            btnOther9.Text = "Add"
            btnOther9.BackColor = Color.Linen
            btnOther9Remove.Enabled = False
        End If
        If CheckFile("Other 10") Then
            btnOther10.Text = "View"
            btnOther10.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnOther10Remove.Enabled = True
            Else
                btnOther10Remove.Enabled = False
            End If
        Else
            btnOther10.Text = "Add"
            btnOther10.BackColor = Color.Linen
            btnOther10Remove.Enabled = False
        End If
        If CheckFile("Other 11") Then
            btnOther11.Text = "View"
            btnOther11.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnOther11Remove.Enabled = True
            Else
                btnOther11Remove.Enabled = False
            End If
        Else
            btnOther11.Text = "Add"
            btnOther11.BackColor = Color.Linen
            btnOther11Remove.Enabled = False
        End If
        If CheckFile("Other 12") Then
            btnOther12.Text = "View"
            btnOther12.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnOther12Remove.Enabled = True
            Else
                btnOther12Remove.Enabled = False
            End If
        Else
            btnOther12.Text = "Add"
            btnOther12.BackColor = Color.Linen
            btnOther12Remove.Enabled = False
        End If
        If CheckFile("Other 13") Then
            btnOther13.Text = "View"
            btnOther13.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnOther13Remove.Enabled = True
            Else
                btnOther13Remove.Enabled = False
            End If
        Else
            btnOther13.Text = "Add"
            btnOther13.BackColor = Color.Linen
            btnOther13Remove.Enabled = False
        End If
        If CheckFile("Other 14") Then
            btnOther14.Text = "View"
            btnOther14.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnOther14Remove.Enabled = True
            Else
                btnOther14Remove.Enabled = False
            End If
        Else
            btnOther14.Text = "Add"
            btnOther14.BackColor = Color.Linen
            btnOther14Remove.Enabled = False
        End If
        If CheckFile("Lateral Fixed") Then
            btnLateralFixed.Text = "View"
            btnLateralFixed.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnLateralFixedRemove.Enabled = True
            Else
                btnLateralFixedRemove.Enabled = False
            End If
        Else
            btnLateralFixed.Text = "Add"
            btnLateralFixed.BackColor = Color.Linen
            btnLateralFixedRemove.Enabled = False
        End If
        If CheckFile("Medial Fixed") Then
            btnMedialFixed.Text = "View"
            btnMedialFixed.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnMedialFixedRemove.Enabled = True
            Else
                btnMedialFixedRemove.Enabled = False
            End If
        Else
            btnMedialFixed.Text = "Add"
            btnMedialFixed.BackColor = Color.Linen
            btnMedialFixedRemove.Enabled = False
        End If
        If CheckFile("Fixed 3") Then
            btnFixed03.Text = "View"
            btnFixed03.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnFixed3Remove.Enabled = True
            Else
                btnFixed3Remove.Enabled = False
            End If
        Else
            btnFixed03.Text = "Add"
            btnFixed03.BackColor = Color.Linen
            btnFixed3Remove.Enabled = False
        End If
        If CheckFile("Fixed 4") Then
            btnFixed04.Text = "View"
            btnFixed04.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnFixed4Remove.Enabled = True
            Else
                btnFixed4Remove.Enabled = False
            End If
        Else
            btnFixed04.Text = "Add"
            btnFixed04.BackColor = Color.Linen
            btnFixed4Remove.Enabled = False
        End If
        If CheckFile("Fixed 5") Then
            btnFixed05.Text = "View"
            btnFixed05.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnFixed5Remove.Enabled = True
            Else
                btnFixed5Remove.Enabled = False
            End If
        Else
            btnFixed05.Text = "Add"
            btnFixed05.BackColor = Color.Linen
            btnFixed5Remove.Enabled = False
        End If
        If CheckFile("Fixed 6") Then
            btnFixed06.Text = "View"
            btnFixed06.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnFixed6Remove.Enabled = True
            Else
                btnFixed6Remove.Enabled = False
            End If
        Else
            btnFixed06.Text = "Add"
            btnFixed06.BackColor = Color.Linen
            btnFixed6Remove.Enabled = False
        End If
        If CheckFile("Fixed 7") Then
            btnFixed07.Text = "View"
            btnFixed07.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnFixed7Remove.Enabled = True
            Else
                btnFixed7Remove.Enabled = False
            End If
        Else
            btnFixed07.Text = "Add"
            btnFixed07.BackColor = Color.Linen
            btnFixed7Remove.Enabled = False
        End If
        If CheckFile("Fixed 8") Then
            btnFixed08.Text = "View"
            btnFixed08.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnFixed8Remove.Enabled = True
            Else
                btnFixed8Remove.Enabled = False
            End If
        Else
            btnFixed08.Text = "Add"
            btnFixed08.BackColor = Color.Linen
            btnFixed8Remove.Enabled = False
        End If
        If CheckFile("Fixed 9") Then
            btnFixed09.Text = "View"
            btnFixed09.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnFixed9Remove.Enabled = True
            Else
                btnFixed9Remove.Enabled = False
            End If
        Else
            btnFixed09.Text = "Add"
            btnFixed09.BackColor = Color.Linen
            btnFixed9Remove.Enabled = False
        End If
        If CheckFile("Fixed 10") Then
            btnFixed10.Text = "View"
            btnFixed10.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnFixed10Remove.Enabled = True
            Else
                btnFixed10Remove.Enabled = False
            End If
        Else
            btnFixed10.Text = "Add"
            btnFixed10.BackColor = Color.Linen
            btnFixed10Remove.Enabled = False
        End If
        If CheckFile("Fixed 11") Then
            btnFixed11.Text = "View"
            btnFixed11.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnFixed11Remove.Enabled = True
            Else
                btnFixed11Remove.Enabled = False
            End If
        Else
            btnFixed11.Text = "Add"
            btnFixed11.BackColor = Color.Linen
            btnFixed11Remove.Enabled = False
        End If
        If CheckFile("Fixed 12") Then
            btnFixed12.Text = "View"
            btnFixed12.BackColor = Color.Chartreuse
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
                btnFixed12Remove.Enabled = True
            Else
                btnFixed12Remove.Enabled = False
            End If
        Else
            btnFixed12.Text = "Add"
            btnFixed12.BackColor = Color.Linen
            btnFixed12Remove.Enabled = False
        End If
    End Sub
    'loadExistingData helper subs
    Private Sub tagLoadCombo(ByVal field As String, ByVal chk As CheckBox)
        If IsNumeric(formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item(field)) Then
            If formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item(field) = 1 Then
                chk.Checked = True
            End If
        End If
    End Sub
    'Subs to enable-disable fields during data input based on conditional logic.
    Private Sub enableInputFields(ByVal value As Boolean)
        If value = True Then
            comboHemisphere.Enabled = True
            chkMuscle.Enabled = True
            If chkMuscle.Checked Then
                txtMuscleTagNum.Enabled = True
            End If
            chkHair.Enabled = True
            If chkHair.Checked Then
                txtHairTagNum.Enabled = True
            End If
            chkSkin.Enabled = True
            If chkSkin.Checked Then
                txtSkinTagNum.Enabled = True
            End If
            chkDura.Enabled = True
            If chkDura.Checked Then
                txtDuraTagNum.Enabled = True
            End If
            chkLrgBldVsl.Enabled = True
            If chkLrgBldVsl.Checked Then
                txtLrgBldVslTagNum.Enabled = True
            End If
            chkLepto.Enabled = True
            If chkLepto.Checked Then
                txtLeptoTagNum.Enabled = True
            End If
            chkChoroid.Enabled = True
            If chkChoroid.Checked Then
                txtChoroidTagNum.Enabled = True
            End If
            chkRtOLF.Enabled = True
            If chkRtOLF.Checked Then
                txtRtOLFTagNum.Enabled = True
            End If
            chkLtOLF.Enabled = True
            If chkLtOLF.Checked Then
                txtLtOLFTagNum.Enabled = True
            End If
            chkCere1.Enabled = True
            If chkCere1.Checked Then
                txtCere1TagNum.Enabled = True
            End If
            chkCere2.Enabled = True
            If chkCere2.Checked Then
                txtCere2TagNum.Enabled = True
            End If
            chkCere3.Enabled = True
            If chkCere3.Checked Then
                txtCere3TagNum.Enabled = True
            End If
            chkCere4.Enabled = True
            If chkCere4.Checked Then
                txtCere4TagNum.Enabled = True
            End If
            chkPituit.Enabled = True
            If chkPituit.Checked Then
                txtPituitTagNum.Enabled = True
            End If
            chkBSMid.Enabled = True
            If chkBSMid.Checked Then
                txtBSMidTagNum.Enabled = True
            End If
            chkBSPons.Enabled = True
            If chkBSPons.Checked Then
                txtBSPonsTagNum.Enabled = True
            End If
            chkBSMed.Enabled = True
            If chkBSMed.Checked Then
                txtBSMedTagNum.Enabled = True
            End If
            chkOth1.Enabled = True
            If chkOth1.Checked Then
                txtOth1TagNum.Enabled = True
                txtOth1Desc.Enabled = True
            End If
            chkOth2.Enabled = True
            If chkOth2.Checked Then
                txtOth2TagNum.Enabled = True
                txtOth2Desc.Enabled = True
            End If
            chkOth3.Enabled = True
            If chkOth3.Checked Then
                txtOth3TagNum.Enabled = True
                txtOth3Desc.Enabled = True
            End If
            txtSlice1TagNum.Enabled = True
            txtSlice2TagNum.Enabled = True
            txtSlice3TagNum.Enabled = True
            txtSlice4TagNum.Enabled = True
            txtSlice5TagNum.Enabled = True
            txtSlice6TagNum.Enabled = True
            txtSlice7TagNum.Enabled = True
            txtSlice8TagNum.Enabled = True
            txtSlice9TagNum.Enabled = True
            txtSlice10TagNum.Enabled = True
            txtSlice11TagNum.Enabled = True
            txtSlice12TagNum.Enabled = True
            txtSlice13TagNum.Enabled = True
            txtSlice14TagNum.Enabled = True
            txtSlice15TagNum.Enabled = True
            txtSlice16TagNum.Enabled = True
            txtSlice17tagNum.Enabled = True
            txtSlice18TagNum.Enabled = True
            txtSlice19TagNum.Enabled = True
            txtSlice20TagNum.Enabled = True
            btnSlice1.Enabled = True
            btnSlice2.Enabled = True
            btnSlice3.Enabled = True
            btnSlice4.Enabled = True
            btnSlice5.Enabled = True
            btnSlice6.Enabled = True
            btnSlice7.Enabled = True
            btnSlice8.Enabled = True
            btnSlice9.Enabled = True
            btnSlice10.Enabled = True
            btnSlice11.Enabled = True
            btnSlice12.Enabled = True
            btnSlice13.Enabled = True
            btnSlice14.Enabled = True
            btnSlice15.Enabled = True
            btnSlice16.Enabled = True
            btnSlice17.Enabled = True
            btnSlice18.Enabled = True
            btnSlice19.Enabled = True
            btnSlice20.Enabled = True
            txtGrossObservations.Enabled = True
            chkHepFollowed.Enabled = True
            chkToxFollowed.Enabled = True
            chkPaxFollowed.Enabled = True
            chkPanosFollowed.Enabled = True
            chkRightFixed.Enabled = True
            chkLeftFixed.Enabled = True
            chkRightFrozen.Enabled = True
            chkLeftFrozen.Enabled = True
            btnComposite.Enabled = True
            btnDorsal.Enabled = True
            btnVentral.Enabled = True
            btnRightLateral.Enabled = True
            btnRightMedial.Enabled = True
            btnLeftLateral.Enabled = True
            btnLeftMedial.Enabled = True
            btnSections1.Enabled = True
            btnSections2.Enabled = True
            btnDura.Enabled = True
            btnOther1.Enabled = True
            btnOther2.Enabled = True
            btnOther3.Enabled = True
            btnOther4.Enabled = True
            btnOther5.Enabled = True
            btnOther6.Enabled = True
            btnOther7.Enabled = True
            btnOther8.Enabled = True
            btnOther9.Enabled = True
            btnOther10.Enabled = True
            btnOther11.Enabled = True
            btnOther12.Enabled = True
            btnOther13.Enabled = True
            btnOther14.Enabled = True
            btnLateralFixed.Enabled = True
            btnMedialFixed.Enabled = True
            btnFixed03.Enabled = True
            btnFixed04.Enabled = True
            btnFixed05.Enabled = True
            btnFixed06.Enabled = True
            btnFixed07.Enabled = True
            btnFixed08.Enabled = True
            btnFixed09.Enabled = True
            btnFixed10.Enabled = True
            btnFixed11.Enabled = True
            btnFixed12.Enabled = True
        Else
            enableMapLevelCheckboxes(False)
            comboHemisphere.Enabled = False
            txtMuscleTagNum.Enabled = False
            chkMuscle.Enabled = False
            txtHairTagNum.Enabled = False
            chkHair.Enabled = False
            txtSkinTagNum.Enabled = False
            chkSkin.Enabled = False
            txtDuraTagNum.Enabled = False
            chkDura.Enabled = False
            txtLrgBldVslTagNum.Enabled = False
            chkLrgBldVsl.Enabled = False
            txtLeptoTagNum.Enabled = False
            chkLepto.Enabled = False
            txtChoroidTagNum.Enabled = False
            chkChoroid.Enabled = False
            txtRtOLFTagNum.Enabled = False
            chkRtOLF.Enabled = False
            txtLtOLFTagNum.Enabled = False
            chkLtOLF.Enabled = False
            txtCere1TagNum.Enabled = False
            chkCere1.Enabled = False
            txtCere2TagNum.Enabled = False
            chkCere2.Enabled = False
            txtCere3TagNum.Enabled = False
            chkCere3.Enabled = False
            txtCere4TagNum.Enabled = False
            chkCere4.Enabled = False
            txtPituitTagNum.Enabled = False
            chkPituit.Enabled = False
            txtBSMidTagNum.Enabled = False
            chkBSMid.Enabled = False
            txtBSPonsTagNum.Enabled = False
            chkBSPons.Enabled = False
            txtBSMedTagNum.Enabled = False
            chkBSMed.Enabled = False
            txtOth1TagNum.Enabled = False
            txtOth1Desc.Enabled = False
            chkOth1.Enabled = False
            txtOth2TagNum.Enabled = False
            txtOth2Desc.Enabled = False
            chkOth2.Enabled = False
            txtOth3TagNum.Enabled = False
            txtOth3Desc.Enabled = False
            chkOth3.Enabled = False
            txtSlice1TagNum.Enabled = False
            txtSlice2TagNum.Enabled = False
            txtSlice3TagNum.Enabled = False
            txtSlice4TagNum.Enabled = False
            txtSlice5TagNum.Enabled = False
            txtSlice6TagNum.Enabled = False
            txtSlice7TagNum.Enabled = False
            txtSlice8TagNum.Enabled = False
            txtSlice9TagNum.Enabled = False
            txtSlice10TagNum.Enabled = False
            txtSlice11TagNum.Enabled = False
            txtSlice12TagNum.Enabled = False
            txtSlice13TagNum.Enabled = False
            txtSlice14TagNum.Enabled = False
            txtSlice15TagNum.Enabled = False
            txtSlice16TagNum.Enabled = False
            txtSlice17tagNum.Enabled = False
            txtSlice18TagNum.Enabled = False
            txtSlice19TagNum.Enabled = False
            txtSlice20TagNum.Enabled = False
            btnSlice1.Enabled = False
            btnSlice2.Enabled = False
            btnSlice3.Enabled = False
            btnSlice4.Enabled = False
            btnSlice5.Enabled = False
            btnSlice6.Enabled = False
            btnSlice7.Enabled = False
            btnSlice8.Enabled = False
            btnSlice9.Enabled = False
            btnSlice10.Enabled = False
            btnSlice11.Enabled = False
            btnSlice12.Enabled = False
            btnSlice13.Enabled = False
            btnSlice14.Enabled = False
            btnSlice15.Enabled = False
            btnSlice16.Enabled = False
            btnSlice17.Enabled = False
            btnSlice18.Enabled = False
            btnSlice19.Enabled = False
            btnSlice20.Enabled = False
            txtGrossObservations.Enabled = False
            chkHepFollowed.Enabled = False
            chkToxFollowed.Enabled = False
            chkPaxFollowed.Enabled = False
            chkPanosFollowed.Enabled = False
            chkRightFixed.Enabled = False
            chkLeftFixed.Enabled = False
            chkRightFrozen.Enabled = False
            chkLeftFrozen.Enabled = False
            If btnComposite.Text = "View" Then
                btnComposite.Enabled = True
            Else
                btnComposite.Enabled = False
            End If
            If btnDorsal.Text = "View" Then
                btnDorsal.Enabled = True
            Else
                btnDorsal.Enabled = False
            End If
            If btnVentral.Text = "View" Then
                btnVentral.Enabled = True
            Else
                btnVentral.Enabled = False
            End If
            If btnRightLateral.Text = "View" Then
                btnRightLateral.Enabled = True
            Else
                btnRightLateral.Enabled = False
            End If
            If btnRightMedial.Text = "View" Then
                btnRightMedial.Enabled = True
            Else
                btnRightMedial.Enabled = False
            End If
            If btnLeftLateral.Text = "View" Then
                btnLeftLateral.Enabled = True
            Else
                btnLeftLateral.Enabled = False
            End If
            If btnLeftMedial.Text = "View" Then
                btnLeftMedial.Enabled = True
            Else
                btnLeftMedial.Enabled = False
            End If
            If btnSections1.Text = "View" Then
                btnSections1.Enabled = True
            Else
                btnSections1.Enabled = False
            End If
            If btnSections2.Text = "View" Then
                btnSections2.Enabled = True
            Else
                btnSections2.Enabled = False
            End If
            If btnDura.Text = "View" Then
                btnDura.Enabled = True
            Else
                btnDura.Enabled = False
            End If
            If btnOther1.Text = "View" Then
                btnOther1.Enabled = True
            Else
                btnOther1.Enabled = False
            End If
            If btnOther2.Text = "View" Then
                btnOther2.Enabled = True
            Else
                btnOther2.Enabled = False
            End If
            If btnOther3.Text = "View" Then
                btnOther3.Enabled = True
            Else
                btnOther3.Enabled = False
            End If
            If btnOther4.Text = "View" Then
                btnOther4.Enabled = True
            Else
                btnOther4.Enabled = False
            End If
            If btnOther5.Text = "View" Then
                btnOther5.Enabled = True
            Else
                btnOther5.Enabled = False
            End If
            If btnOther6.Text = "View" Then
                btnOther6.Enabled = True
            Else
                btnOther6.Enabled = False
            End If
            If btnOther7.Text = "View" Then
                btnOther7.Enabled = True
            Else
                btnOther7.Enabled = False
            End If
            If btnOther8.Text = "View" Then
                btnOther8.Enabled = True
            Else
                btnOther8.Enabled = False
            End If
            If btnOther9.Text = "View" Then
                btnOther9.Enabled = True
            Else
                btnOther9.Enabled = False
            End If
            If btnOther10.Text = "View" Then
                btnOther10.Enabled = True
            Else
                btnOther10.Enabled = False
            End If
            If btnOther11.Text = "View" Then
                btnOther11.Enabled = True
            Else
                btnOther11.Enabled = False
            End If
            If btnOther12.Text = "View" Then
                btnOther12.Enabled = True
            Else
                btnOther12.Enabled = False
            End If
            If btnOther13.Text = "View" Then
                btnOther13.Enabled = True
            Else
                btnOther13.Enabled = False
            End If
            If btnOther14.Text = "View" Then
                btnOther14.Enabled = True
            Else
                btnOther14.Enabled = False
            End If
            If btnLateralFixed.Text = "View" Then
                btnLateralFixed.Enabled = True
            Else
                btnLateralFixed.Enabled = False
            End If
            If btnMedialFixed.Text = "View" Then
                btnMedialFixed.Enabled = True
            Else
                btnMedialFixed.Enabled = False
            End If
            If btnFixed03.Text = "View" Then
                btnFixed03.Enabled = True
            Else
                btnFixed03.Enabled = False
            End If
            If btnFixed04.Text = "View" Then
                btnFixed04.Enabled = True
            Else
                btnFixed04.Enabled = False
            End If
            If btnFixed05.Text = "View" Then
                btnFixed05.Enabled = True
            Else
                btnFixed05.Enabled = False
            End If
            If btnFixed06.Text = "View" Then
                btnFixed06.Enabled = True
            Else
                btnFixed06.Enabled = False
            End If
            If btnFixed07.Text = "View" Then
                btnFixed07.Enabled = True
            Else
                btnFixed07.Enabled = False
            End If
            If btnFixed08.Text = "View" Then
                btnFixed08.Enabled = True
            Else
                btnFixed08.Enabled = False
            End If
            If btnFixed09.Text = "View" Then
                btnFixed09.Enabled = True
            Else
                btnFixed09.Enabled = False
            End If
            If btnFixed10.Text = "View" Then
                btnFixed10.Enabled = True
            Else
                btnFixed10.Enabled = False
            End If
            If btnFixed11.Text = "View" Then
                btnFixed11.Enabled = True
            Else
                btnFixed11.Enabled = False
            End If
            If btnFixed12.Text = "View" Then
                btnFixed12.Enabled = True
            Else
                btnFixed12.Enabled = False
            End If
        End If
        loadFileData()
    End Sub

    'Real time validation subs
    Private Sub chkOth1_CheckChanged(sender As Object, e As EventArgs) Handles chkOth1.CheckedChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
            validateChkBoxDescription(chkOth1, txtOth1Desc, txtOth1TagNum)
        End If
    End Sub
    Private Sub chkOth2_CheckChanged(sender As Object, e As EventArgs) Handles chkOth2.CheckedChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
            validateChkBoxDescription(chkOth2, txtOth2Desc, txtOth2TagNum)
        End If
    End Sub
    Private Sub chkOth3_CheckChanged(sender As Object, e As EventArgs) Handles chkOth3.CheckedChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
            validateChkBoxDescription(chkOth3, txtOth3Desc, txtOth3TagNum)
        End If
    End Sub
    'Sub to save some typing where validating check boxes have values in their associated text fields if box is checked.
    Private Sub validateChkBoxDescription(ByVal chk As CheckBox_, ByVal txt As TextBox, ByVal tagBox As TextBoxIntLess40)
        If chk.Checked = True And txt.Text = "" Then
            tagBox.Enabled = True
            txt.Enabled = True
            txt.Focus()
            tooltip1.Show("Please provide a description for this tag or uncheck the box.", chk, 0, 20, 5000)
        ElseIf chk.Checked = True And txt.Text <> "" Then
            tagBox.Enabled = True
            txt.Enabled = True
            txt.Focus()
        ElseIf chk.Checked = False Then
            txt.Enabled = False
            txt.Clear()
            tagBox.Enabled = False
            tagBox.Clear()
        End If
    End Sub

    'Dynamic locking/unlocking subs
    Private Sub chkMuscle_CheckChanged(sender As Object, e As EventArgs) Handles chkMuscle.CheckedChanged, chkHair.CheckedChanged, chkSkin.CheckedChanged, chkDura.CheckedChanged, chkLrgBldVsl.CheckedChanged, chkLepto.CheckedChanged, chkChoroid.CheckedChanged, chkRtOLF.CheckedChanged, chkLtOLF.CheckedChanged, chkCere1.CheckedChanged, chkCere2.CheckedChanged, chkCere3.CheckedChanged, chkCere4.CheckedChanged, chkPituit.CheckedChanged, chkBSMid.CheckedChanged, chkBSPons.CheckedChanged, chkBSMed.CheckedChanged
        If sender Is chkMuscle Then
            unlockTagNums(sender, txtMuscleTagNum)
        ElseIf sender Is chkHair Then
            unlockTagNums(sender, txtHairTagNum)
        ElseIf sender Is chkSkin Then
            unlockTagNums(sender, txtSkinTagNum)
        ElseIf sender Is chkDura Then
            unlockTagNums(sender, txtDuraTagNum)
        ElseIf sender Is chkLrgBldVsl Then
            unlockTagNums(sender, txtLrgBldVslTagNum)
        ElseIf sender Is chkLepto Then
            unlockTagNums(sender, txtLeptoTagNum)
        ElseIf sender Is chkChoroid Then
            unlockTagNums(sender, txtChoroidTagNum)
        ElseIf sender Is chkRtOLF Then
            unlockTagNums(sender, txtRtOLFTagNum)
        ElseIf sender Is chkLtOLF Then
            unlockTagNums(sender, txtLtOLFTagNum)
        ElseIf sender Is chkCere1 Then
            unlockTagNums(sender, txtCere1TagNum)
        ElseIf sender Is chkCere2 Then
            unlockTagNums(sender, txtCere2TagNum)
        ElseIf sender Is chkCere3 Then
            unlockTagNums(sender, txtCere3TagNum)
        ElseIf sender Is chkCere4 Then
            unlockTagNums(sender, txtCere4TagNum)
        ElseIf sender Is chkPituit Then
            unlockTagNums(sender, txtPituitTagNum)
        ElseIf sender Is chkBSMid Then
            unlockTagNums(sender, txtBSMidTagNum)
        ElseIf sender Is chkBSPons Then
            unlockTagNums(sender, txtBSPonsTagNum)
        ElseIf sender Is chkBSMed Then
            unlockTagNums(sender, txtBSMedTagNum)
        End If
    End Sub
    Private Sub unlockTagNums(ByVal chk As CheckBox_, ByVal txt As TextBoxIntLess40)
        If chk.Checked Then
            txt.Enabled = True
        Else
            txt.Enabled = False
            txt.Clear()
        End If
    End Sub

    'Define button click events
    'Form level button
    Private Sub btnDissectionMapBottom_Click(sender As Object, e As EventArgs) Handles btnDissectionMapBottom.Click, btnDissectionMapTop.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_AutopsyDissectionMap", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                enableInputFields(True)
                btnDissectionMapBottom.Text = "Save changes"
                btnDissectionMapTop.Text = btnDissectionMapBottom.Text
            Else
                MsgBox("You do not have permission to edit this form.", MsgBoxStyle.OkOnly, "Warning")
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If User.PermissionCheck("WA_AutopsyDissectionMap", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
                loadBaseForm()
                defaultComboValues()
                enableInputFields(True)
                btnDissectionMapBottom.Text = "Save new record"
                btnDissectionMapTop.Text = btnDissectionMapBottom.Text
                lblNoRecord.Visible = False
            Else
                MsgBox("You do not have permission to create this form.", MsgBoxStyle.OkOnly, "Warning")
            End If
        Else
            If preSaveValidation() Then
                Dim cmd As New SqlCommand
                cmd.Connection = WarehouseShell.conn
                Dim cmdString As String = ", @SubNum = " & WarehouseShell.SubNum &
                    ", @HemisphereValue = " & comboHemisphere.getSQLValue() &
                    ", @MuscleTaken = " & chkMuscle.getSQLValue() &
                    ", @MuscleTagNum = " & txtMuscleTagNum.getSQLValue() &
                    ", @HairTaken = " & chkHair.getSQLValue() &
                    ", @HairTagNum = " & txtHairTagNum.getSQLValue() &
                    ", @SkinTaken = " & chkSkin.getSQLValue() &
                    ", @SkinTagNum = " & txtSkinTagNum.getSQLValue() &
                    ", @DuraTaken = " & chkDura.getSQLValue() &
                    ", @DuraTagNum = " & txtDuraTagNum.getSQLValue() &
                    ", @LrgBldVslTaken = " & chkLrgBldVsl.getSQLValue() &
                    ", @LrgBldVslTagNum = " & txtLrgBldVslTagNum.getSQLValue() &
                    ", @LeptoTaken = " & chkLepto.getSQLValue() &
                    ", @LeptoTagNum = " & txtLeptoTagNum.getSQLValue() &
                    ", @ChoroidTaken = " & chkChoroid.getSQLValue() &
                    ", @ChoroidTagNum = " & txtChoroidTagNum.getSQLValue() &
                    ", @RtOLFTaken = " & chkRtOLF.getSQLValue() &
                    ", @RtOLFTagNum = " & txtRtOLFTagNum.getSQLValue() &
                    ", @LtOLFTaken = " & chkLtOLF.getSQLValue() &
                    ", @LtOLFTagNum = " & txtLtOLFTagNum.getSQLValue() &
                    ", @Cere1Taken = " & chkCere1.getSQLValue() &
                    ", @Cere1TagNum = " & txtCere1TagNum.getSQLValue() &
                    ", @Cere2Taken = " & chkCere2.getSQLValue() &
                    ", @Cere2TagNum = " & txtCere2TagNum.getSQLValue() &
                    ", @Cere3Taken = " & chkCere3.getSQLValue() &
                    ", @Cere3TagNum = " & txtCere3TagNum.getSQLValue() &
                    ", @Cere4Taken = " & chkCere4.getSQLValue() &
                    ", @Cere4TagNum = " & txtCere4TagNum.getSQLValue() &
                    ", @PituitTaken = " & chkPituit.getSQLValue() &
                    ", @PituitTagNum = " & txtPituitTagNum.getSQLValue() &
                    ", @BSMidTaken = " & chkBSMid.getSQLValue() &
                    ", @BSMidTagNum = " & txtBSMidTagNum.getSQLValue() &
                    ", @BSPonsTaken = " & chkBSPons.getSQLValue() &
                    ", @BSPonsTagNum = " & txtBSPonsTagNum.getSQLValue() &
                    ", @BSMedTaken = " & chkBSMed.getSQLValue() &
                    ", @BSMedTagNum = " & txtBSMedTagNum.getSQLValue() &
                    ", @Oth1Taken = " & chkOth1.getSQLValue() &
                    ", @Oth1TagNum = " & txtOth1TagNum.getSQLValue() &
                    ", @Oth1Desc = " & txtOth1Desc.getSQLValue() &
                    ", @Oth2Taken = " & chkOth2.getSQLValue() &
                    ", @Oth2TagNum = " & txtOth2TagNum.getSQLValue() &
                    ", @Oth2Desc = " & txtOth2Desc.getSQLValue() &
                    ", @Oth3Taken = " & chkOth3.getSQLValue() &
                    ", @Oth3TagNum = " & txtOth3TagNum.getSQLValue() &
                    ", @Oth3Desc = " & txtOth3Desc.getSQLValue() &
                    ", @Slice1TagNum = " & txtSlice1TagNum.getSQLValue() &
                    ", @Slice1MapLevels = " & txtSlice1.getSQLValue() &
                    ", @Slice2TagNum = " & txtSlice2TagNum.getSQLValue() &
                    ", @Slice2MapLevels = " & txtSlice2.getSQLValue() &
                    ", @Slice3TagNum = " & txtSlice3TagNum.getSQLValue() &
                    ", @Slice3MapLevels = " & txtSlice3.getSQLValue() &
                    ", @Slice4TagNum = " & txtSlice4TagNum.getSQLValue() &
                    ", @Slice4MapLevels = " & txtSlice4.getSQLValue() &
                    ", @Slice5TagNum = " & txtSlice5TagNum.getSQLValue() &
                    ", @Slice5MapLevels = " & txtSlice5.getSQLValue() &
                    ", @Slice6TagNum = " & txtSlice6TagNum.getSQLValue() &
                    ", @Slice6MapLevels = " & txtSlice6.getSQLValue() &
                    ", @Slice7TagNum = " & txtSlice7TagNum.getSQLValue() &
                    ", @Slice7MapLevels = " & txtSlice7.getSQLValue() &
                    ", @Slice8TagNum = " & txtSlice8TagNum.getSQLValue() &
                    ", @Slice8MapLevels = " & txtSlice8.getSQLValue() &
                    ", @Slice9TagNum = " & txtSlice9TagNum.getSQLValue() &
                    ", @Slice9MapLevels = " & txtSlice9.getSQLValue() &
                    ", @Slice10TagNum = " & txtSlice10TagNum.getSQLValue() &
                    ", @Slice10MapLevels = " & txtSlice10.getSQLValue() &
                    ", @Slice11TagNum = " & txtSlice11TagNum.getSQLValue() &
                    ", @Slice11MapLevels = " & txtSlice11.getSQLValue() &
                    ", @Slice12TagNum = " & txtSlice12TagNum.getSQLValue() &
                    ", @Slice12MapLevels = " & txtSlice12.getSQLValue() &
                    ", @Slice13TagNum = " & txtSlice13TagNum.getSQLValue() &
                    ", @Slice13MapLevels = " & txtSlice13.getSQLValue() &
                    ", @Slice14TagNum = " & txtSlice14TagNum.getSQLValue() &
                    ", @Slice14MapLevels = " & txtSlice14.getSQLValue() &
                    ", @Slice15TagNum = " & txtSlice15TagNum.getSQLValue() &
                    ", @Slice15MapLevels = " & txtSlice15.getSQLValue() &
                    ", @Slice16TagNum = " & txtSlice16TagNum.getSQLValue() &
                    ", @Slice16MapLevels = " & txtSlice16.getSQLValue() &
                    ", @Slice17TagNum = " & txtSlice17tagNum.getSQLValue() &
                    ", @Slice17MapLevels = " & txtSlice17.getSQLValue() &
                    ", @Slice18TagNum = " & txtSlice18TagNum.getSQLValue() &
                    ", @Slice18MapLevels = " & txtSlice18.getSQLValue() &
                    ", @Slice19TagNum = " & txtSlice19TagNum.getSQLValue() &
                    ", @Slice19MapLevels = " & txtSlice19.getSQLValue() &
                    ", @Slice20TagNum = " & txtSlice20TagNum.getSQLValue() &
                    ", @Slice20MapLevels = " & txtSlice20.getSQLValue() &
                    ", @GrossObservations = " & txtGrossObservations.getSQLValue() &
                    ", @HepFollowed = " & chkHepFollowed.getSQLValue() &
                    ", @ToxFollowed = " & chkToxFollowed.getSQLValue() &
                    ", @PaxFollowed = " & chkPaxFollowed.getSQLValue() &
                    ", @PanosFollowed = " & chkPanosFollowed.getSQLValue() &
                    ", @RightFixed = " & chkRightFixed.getSQLValue() &
                    ", @LeftFixed = " & chkLeftFixed.getSQLValue() &
                    ", @RightFrozen = " & chkRightFrozen.getSQLValue() &
                    ", @LeftFrozen = " & chkLeftFrozen.getSQLValue() &
                    ";"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    Try
                        cmd.CommandText = "Execute dbo.modAutopsyDissectionMapRecord @Action = 1" & cmdString
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        generateNewCaseEmail()
                        WarehouseShell.LoadWorkingAreaForm(WarehouseShell.formType.WA_AutopsyDissectionMap)
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else
                    Try
                        cmd.CommandText = "Execute dbo.modAutopsyDissectionMapRecord @Action = 2" & cmdString
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Record successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        WarehouseShell.LoadWorkingAreaForm(WarehouseShell.formType.WA_AutopsyDissectionMap)
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                End If
            End If
        End If
    End Sub
    'Dissection tag buttons
    Private Sub btnTag_Click(sender As Object, e As EventArgs) Handles btnSlice1.Click, btnSlice2.Click, btnSlice3.Click, btnSlice4.Click, btnSlice5.Click, btnSlice6.Click, btnSlice7.Click, btnSlice8.Click, btnSlice9.Click, btnSlice10.Click,
        btnSlice11.Click, btnSlice12.Click, btnSlice13.Click, btnSlice14.Click, btnSlice15.Click, btnSlice16.Click, btnSlice17.Click, btnSlice18.Click, btnSlice19.Click, btnSlice20.Click
        Dim myTag As String = DirectCast(sender, Button).Tag
        decolorSliceBoxes()
        SliceBox = Me.GroupBox1.Controls("txtSlice" & myTag)
        SliceBox.BackColor = Color.Chartreuse
        enableMapLevelCheckboxes(True)
        chkMap1.Focus()
    End Sub
    Private Sub enableMapLevelCheckboxes(ByVal bool As Boolean)
        If bool = True Then
            btnMapLevelSave.Enabled = True
            btnMapLevelSave.BackColor = Color.Chartreuse
            chkMap1.Enabled = True
            chkMap2.Enabled = True
            chkMap3.Enabled = True
            chkMap4.Enabled = True
            chkMap5.Enabled = True
            chkMap6.Enabled = True
            chkMap7.Enabled = True
            chkMap8.Enabled = True
            chkMap9.Enabled = True
            chkMap10.Enabled = True
            chkMap11.Enabled = True
            chkMap12.Enabled = True
            chkMap13.Enabled = True
            chkMap14.Enabled = True
            chkMap15.Enabled = True
            chkMap16.Enabled = True
            chkMap17.Enabled = True
            chkMap18.Enabled = True
            chkMap19.Enabled = True
            chkMap20.Enabled = True
            chkMap21.Enabled = True
            chkMap22.Enabled = True
            chkMap23.Enabled = True
            chkMap24.Enabled = True
            chkMap25.Enabled = True
            chkMap26.Enabled = True
            chkMap27.Enabled = True
            chkMap28.Enabled = True
            chkMap29.Enabled = True
            chkMap30.Enabled = True
            chkMap31.Enabled = True
            chkMap32.Enabled = True
            chkMap33.Enabled = True
        Else
            btnMapLevelSave.Enabled = False
            btnMapLevelSave.BackColor = Color.White
            chkMap1.Enabled = False
            chkMap1.Checked = False
            chkMap2.Enabled = False
            chkMap2.Checked = False
            chkMap3.Enabled = False
            chkMap3.Checked = False
            chkMap4.Enabled = False
            chkMap4.Checked = False
            chkMap5.Enabled = False
            chkMap5.Checked = False
            chkMap6.Enabled = False
            chkMap6.Checked = False
            chkMap7.Enabled = False
            chkMap7.Checked = False
            chkMap8.Enabled = False
            chkMap8.Checked = False
            chkMap9.Enabled = False
            chkMap9.Checked = False
            chkMap10.Enabled = False
            chkMap10.Checked = False
            chkMap11.Enabled = False
            chkMap11.Checked = False
            chkMap12.Enabled = False
            chkMap12.Checked = False
            chkMap13.Enabled = False
            chkMap13.Checked = False
            chkMap14.Enabled = False
            chkMap14.Checked = False
            chkMap15.Checked = False
            chkMap15.Enabled = False
            chkMap16.Checked = False
            chkMap16.Enabled = False
            chkMap17.Checked = False
            chkMap17.Enabled = False
            chkMap18.Checked = False
            chkMap18.Enabled = False
            chkMap19.Checked = False
            chkMap19.Enabled = False
            chkMap20.Checked = False
            chkMap20.Enabled = False
            chkMap21.Checked = False
            chkMap21.Enabled = False
            chkMap22.Checked = False
            chkMap22.Enabled = False
            chkMap23.Enabled = False
            chkMap23.Checked = False
            chkMap24.Enabled = False
            chkMap24.Checked = False
            chkMap25.Enabled = False
            chkMap25.Checked = False
            chkMap26.Enabled = False
            chkMap26.Checked = False
            chkMap27.Enabled = False
            chkMap27.Checked = False
            chkMap28.Enabled = False
            chkMap28.Checked = False
            chkMap29.Enabled = False
            chkMap29.Checked = False
            chkMap30.Enabled = False
            chkMap30.Checked = False
            chkMap31.Enabled = False
            chkMap31.Checked = False
            chkMap32.Enabled = False
            chkMap32.Checked = False
            chkMap33.Enabled = False
            chkMap33.Checked = False
        End If
    End Sub
    Private Sub btnMapLevelSave_Click(sender As Object, e As EventArgs) Handles btnMapLevelSave.Click
        Dim iCount As Integer = 33
        Dim myString As String = ""
        Dim i As Integer
        Dim chk As CheckBox

        For i = 1 To iCount
            chk = GroupBox1.Controls("chkMap" & i)
            If chk.Checked = True Then
                myString &= i.ToString() & " "
            End If
        Next

        SliceBox.Text = myString

        If CType(SliceBox.Tag, Integer) < 20 Then
            SliceBox = GroupBox1.Controls("txtSlice" & CType(SliceBox.Tag, Integer) + 1)
            decolorSliceBoxes()
            SliceBox.BackColor = Color.Chartreuse
            uncheckMapLevelBoxes()
        Else
            SliceBox = Nothing
            enableMapLevelCheckboxes(False)
            uncheckMapLevelBoxes()
            decolorSliceBoxes()
            txtGrossObservations.Focus()
        End If

    End Sub
    Private Sub enterKeyMonitor(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkMap1.KeyDown, chkMap2.KeyDown, chkMap3.KeyDown, chkMap4.KeyDown, chkMap5.KeyDown, chkMap6.KeyDown, chkMap7.KeyDown, chkMap8.KeyDown, chkMap9.KeyDown, chkMap10.KeyDown, chkMap11.KeyDown, chkMap12.KeyDown, chkMap13.KeyDown, chkMap14.KeyDown, chkMap15.KeyDown, chkMap16.KeyDown, chkMap17.KeyDown, chkMap18.KeyDown, chkMap19.KeyDown, chkMap20.KeyDown, chkMap21.KeyDown, chkMap22.KeyDown, chkMap23.KeyDown, chkMap24.KeyDown, chkMap25.KeyDown, chkMap26.KeyDown, chkMap27.KeyDown, chkMap28.KeyDown, chkMap29.KeyDown, chkMap30.KeyDown, chkMap31.KeyDown, chkMap32.KeyDown, chkMap33.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            btnMapLevelSave.PerformClick()
        End If
    End Sub
    Private Sub decolorSliceBoxes()
        txtSlice1.BackColor = Color.White
        txtSlice2.BackColor = Color.White
        txtSlice3.BackColor = Color.White
        txtSlice4.BackColor = Color.White
        txtSlice5.BackColor = Color.White
        txtSlice6.BackColor = Color.White
        txtSlice7.BackColor = Color.White
        txtSlice8.BackColor = Color.White
        txtSlice9.BackColor = Color.White
        txtSlice10.BackColor = Color.White
        txtSlice11.BackColor = Color.White
        txtSlice12.BackColor = Color.White
        txtSlice13.BackColor = Color.White
        txtSlice14.BackColor = Color.White
        txtSlice15.BackColor = Color.White
        txtSlice16.BackColor = Color.White
        txtSlice17.BackColor = Color.White
        txtSlice18.BackColor = Color.White
        txtSlice19.BackColor = Color.White
        txtSlice20.BackColor = Color.White
    End Sub
    Private Sub uncheckMapLevelBoxes()
        chkMap1.Checked = False
        chkMap2.Checked = False
        chkMap3.Checked = False
        chkMap4.Checked = False
        chkMap5.Checked = False
        chkMap6.Checked = False
        chkMap7.Checked = False
        chkMap8.Checked = False
        chkMap9.Checked = False
        chkMap10.Checked = False
        chkMap11.Checked = False
        chkMap12.Checked = False
        chkMap13.Checked = False
        chkMap14.Checked = False
        chkMap15.Checked = False
        chkMap16.Checked = False
        chkMap17.Checked = False
        chkMap18.Checked = False
        chkMap19.Checked = False
        chkMap20.Checked = False
        chkMap21.Checked = False
        chkMap22.Checked = False
        chkMap23.Checked = False
        chkMap24.Checked = False
        chkMap25.Checked = False
        chkMap26.Checked = False
        chkMap27.Checked = False
        chkMap28.Checked = False
        chkMap29.Checked = False
        chkMap30.Checked = False
        chkMap31.Checked = False
        chkMap32.Checked = False
        chkMap33.Checked = False
    End Sub

    Private Sub generateNewCaseEmail()

        'create and set needed variables
        Dim cmd As New SqlCommand("Select Case when ADRCCohort is null then 0 else ADRCCohort end as ADRC from Subject where SubNum = " & WarehouseShell.SubNum, WarehouseShell.conn)
        Dim ADRC As Integer = cmd.ExecuteScalar
        cmd.CommandText = "Select BB from AutopsyFaceSheet where SubNum = " & WarehouseShell.SubNum
        Dim BB As String = cmd.ExecuteScalar.ToString
        cmd.CommandText = "Select case when Age is null then 'unknown' else cast(Age as nvarchar(max)) end as Age from viewSubject where SubNum = " & WarehouseShell.SubNum
        Dim Age As String = cmd.ExecuteScalar.ToString
        cmd.CommandText = "Select case when SexValue = 1 then 'male' when SexValue = 2 then 'female' else 'unknown sex' end as Sex from Subject where SubNum = " & WarehouseShell.SubNum
        Dim Sex As String = cmd.ExecuteScalar
        cmd.CommandText = "Select case when PlaceOfDeathLabel is null then 'location unknown' else PlaceOfDeathLabel end as PlaceOfDeathLabel from viewAutopsyFaceSheet where SubNum = " & WarehouseShell.SubNum
        Dim PoD As String = cmd.ExecuteScalar()


        'Create ADRC or NBTR mailing
        'If ADRC <> 1 Then
        '    cmd.CommandText = "Exec dbo.mailWithAttach " &
        '        "@myRecipients = 'stephen.panopoulos@mssm.edu; dushyant.purohit@mountsinai.org; gregory.austin@mssm.edu; christine.marino@mssm.edu; karen.soto@mssm.edu; steven.ramirez@mssm.edu'" &
        '        ", @myCopy_Recipients = 'vahram.haroutunian@mssm.edu; maxwell.bustamante@mssm.edu; joshua.arneson@mssm.edu; michael.wysocki@mssm.edu; ana.latouf@mssm.edu; racquel.arneson@mssm.edu'" &
        '        ", @mySubject = '[SECURE] New NBTR Case BB " & BB & "'" &
        '        ", @myBody = 'For All," & vbNewLine & vbNewLine &
        '        "A new NBTR case was added to the warehouse. BB " & BB & ", " & IIf(Age = "unknown", "age unknown", Age & " yr old ") & Sex & " from " & PoD & "." & vbNewLine & vbNewLine &
        '        "Relevant data has been uploaded to the Data Warehouse." & vbNewLine & vbNewLine &
        '        "*Automated message from Data Warehouse*'" &
        '        ", @myFile_Attachments = ''" &
        '        ", @mySensitivity = 'Confidential';"
        '    cmd.ExecuteNonQuery()
        'Else
        '    cmd.CommandText = "Exec dbo.mailWithAttach " &
        '        "@myRecipients = 'jimmy.akrivos@mssm.edu; gargi.padki@mssm.edu; michael.kinsella@mssm.edu; carolyn.zhu@mssm.edu; mary.sano@mssm.edu; dushyant.purohit@mountsinai.org; christine.marino@mssm.edu; karen.soto@mssm.edu; steven.ramirez@mssm.edu'" &
        '        ", @myCopy_Recipients = 'vahram.haroutunian@mssm.edu; maxwell.bustamante@mssm.edu; joshua.arneson@mssm.edu; michael.wysocki@mssm.edu; danny.benitez@mssm.edu; ana.latouf@mssm.edu; racquel.arneson@mssm.edu'" &
        '        ", @mySubject = '[SECURE] New ADRC Case BB " & BB & "'" &
        '        ", @myBody = 'For All," & vbNewLine & vbNewLine &
        '        "A new ADRC case was added to the warehouse. BB " & BB & ", " & Age & " yr old " & Sex & " from " & PoD & "." & vbNewLine & vbNewLine &
        '        "Relevant data has been uploaded to the Data Warehouse." & vbNewLine & vbNewLine &
        '        "*Automated message from Data Warehouse*'" &
        '        ", @myFile_Attachments = ''" &
        '        ", @mySensitivity = 'Confidential';"
        '    cmd.ExecuteNonQuery()
        'End If

    End Sub

    'Slice Viewer
    Private Sub btnSliceViewer_Click(sender As Object, e As EventArgs) Handles btnSliceViewer.Click
        PU_SliceViewer.Show()
    End Sub

    Private Function CheckFile(ByVal Description As String) As Boolean
        Dim query As New SqlCommand
        query.CommandText = "Select count(*) from fileAutopsyMacroImages where SubNum = " & WarehouseShell.SubNum & " and Description = '" & Description & "';"
        query.Connection = WarehouseShell.conn
        If query.ExecuteScalar().ToString = 1 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub OpenFile(ByVal Description As String, ByVal myFileName As String)
        'This sub uses https://support.microsoft.com/en-us/kb/316887 & System.Diagnostics to grab the blob file from filestream, copy it with extension to the user's temp file, then open it using whatever default program they have for that extension.
        Dim tempFilePath As String = Path.GetTempPath()
        'Dim tempFileName As String
        Dim tempFileExt As String
        'These lines get the file extension from the fileAutopsyMacroImages table and assigns it to tempFileExt (and set the connection property for this and subsequent SqlCommands)
        Dim cmd As New SqlCommand
        cmd.Connection = WarehouseShell.conn
        cmd.CommandText = "Select FileExtension from fileAutopsyMacroImages where SubNum = " & WarehouseShell.SubNum & " and Description = '" & Description & "';"
        tempFileExt = cmd.ExecuteScalar().ToString
        'Grab the binary data from FileStream and load it into the SqlDataReader
        cmd.CommandText = "Select FileData from fileAutopsyMacroImages where SubNum = " & WarehouseShell.SubNum & " and Description = '" & Description & "';"
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        dr.Read()
        Dim b(dr.GetBytes(0, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
        dr.GetBytes(0, 0, b, 0, b.Length)
        dr.Close()
        Try
            'Write the binary data to a file with extension in the user's temp folder (using provided file name or default)
            tempFilePath = tempFilePath & myFileName & tempFileExt
            Dim fs As New System.IO.FileStream(tempFilePath, IO.FileMode.Create, IO.FileAccess.Write)
            fs.Write(b, 0, b.Length)
            fs.Close()
            'Open the temp file using the user's default program for that extension
            Dim P As New System.Diagnostics.Process
            Dim s As New System.Diagnostics.ProcessStartInfo(tempFilePath)
            s.UseShellExecute = True
            s.WindowStyle = ProcessWindowStyle.Normal
            P.StartInfo = s
            P.Start()
        Catch ex As Exception
            ExceptionHandler.CatchWindowsException(ex)
        End Try
    End Sub
    Private Sub SaveFile(ByVal Description As String)
        'Define variables and open FileDialog
        Dim FileDiag As New OpenFileDialog
        Dim IncomingFile As String
        Dim Destination As String = "Q:\WarehouseTemp\"
        Dim incomingType As String = ""
        Dim convertedType As String = ""
        Dim FileSize As Integer
        Dim infoReader As System.IO.FileInfo
        FileDiag.ShowDialog()
        'TODO- Make sure that a file was selected in the FileDiag window
        IncomingFile = FileDiag.FileName
        'Handle user cancelling out of FileDiag
        If IncomingFile <> "" Then
            infoReader = My.Computer.FileSystem.GetFileInfo(IncomingFile)
            FileSize = Math.Round(infoReader.Length / 1024, 0)
            incomingType = infoReader.Extension
            'If file is image, convert to .png and copy, else copy file as is.
            If incomingType = ".bmp" Or incomingType = ".dib" Or incomingType = ".cod" Or incomingType = ".gif" Or incomingType = ".ief" Or incomingType = ".jpe" Or
                incomingType = ".jpeg" Or incomingType = ".jpg" Or incomingType = ".jfif" Or incomingType = ".svg" Or incomingType = ".svgz" Or
                incomingType = ".tif" Or incomingType = ".tiff" Or incomingType = ".rf" Or incomingType = ".wbmp" Or incomingType = ".ras" Or
                incomingType = ".cmx" Or incomingType = ".ico" Or incomingType = ".art" Or incomingType = ".pnm" Or incomingType = ".pbm" Or
                incomingType = ".pgm" Or incomingType = ".ppm" Or incomingType = ".rgb" Or incomingType = ".xbm" Or incomingType = ".xpm" Or
                incomingType = ".xwd" Then
                convertedType = ".png"
                'Copy source image to Q:\WarehouseTemp\
                System.IO.File.Copy(IncomingFile, Destination & "TempSourceImg" & incomingType, True)
                Dim SourceImg As Drawing.Image = Drawing.Image.FromFile(Destination & "TempSourceImg" & incomingType)
                'Convert source image to .png
                SourceImg.Save(Destination & "Temp.png", Imaging.ImageFormat.Png)
                'Set infoReader to the newly converted file and get the new file size
                infoReader = My.Computer.FileSystem.GetFileInfo(Destination & "Temp.png")
                FileSize = Math.Round(infoReader.Length / 1024, 0)
            Else
                System.IO.File.Copy(IncomingFile, Destination & "Temp" & incomingType, True)
            End If
            Dim query As New SqlCommand
            'Notice the filepath in the bulk copy is relative to the SERVER and not the local computer.
            query.CommandText = "Insert into fileAutopsyMacroImages(SubNum, Description, FileData, FileExtension, FileSizeKB, UploadDate) values (" &
                WarehouseShell.SubNum & ", '" & Description & "', " & "(select * from openrowset(bulk N'Y:\Shares\Share\WarehouseTemp\Temp" & IIf(convertedType <> "", convertedType, incomingType) & "', single_blob) as n), '" &
                IIf(convertedType <> "", convertedType, incomingType) & "', " & FileSize & ", '" & Format(Date.Now, "MM-dd-yyyy").ToString() & "');"
            query.Connection = WarehouseShell.conn
            query.ExecuteNonQuery()
            'Delete the temp file.
            System.IO.File.Delete(Destination & "Temp" & IIf(convertedType <> "", convertedType, incomingType))
            'Delete the source image if the file needed to be converted
            If convertedType <> "" Then
                'TODO: IOException being thrown "file is in use by another process"
                'System.IO.File.Delete(Destination & "TempSourceImg" & incomingType)
            End If
        End If
        FileDiag.Dispose()
    End Sub
    Private Sub DeleteFile(ByVal Description As String)
        Dim cmd As New SqlCommand("Delete from fileAutopsyMacroImages where SubNum = " & WarehouseShell.SubNum & " and Description = '" & Description & "';", WarehouseShell.conn)
        cmd.ExecuteNonQuery()
    End Sub

    'File Save/Open buttons
    Private Sub btnComposite_Click(sender As Object, e As EventArgs) Handles btnComposite.Click
        If CheckFile("Composite") Then
            OpenFile("Composite", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Composite")
        End If
        loadFileData()
    End Sub
    Private Sub btnDorsal_Click(sender As Object, e As EventArgs) Handles btnDorsal.Click
        If CheckFile("Dorsal") Then
            OpenFile("Dorsal", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Dorsal")
        End If
        loadFileData()
    End Sub
    Private Sub btnVentral_Click(sender As Object, e As EventArgs) Handles btnVentral.Click
        If CheckFile("Ventral") Then
            OpenFile("Ventral", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Ventral")
        End If
        loadFileData()
    End Sub
    Private Sub btnRightLateral_Click(sender As Object, e As EventArgs) Handles btnRightLateral.Click
        If CheckFile("Right Lateral") Then
            OpenFile("Right Lateral", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Right Lateral")
        End If
        loadFileData()
    End Sub
    Private Sub btnRightMedial_Click(sender As Object, e As EventArgs) Handles btnRightMedial.Click
        If CheckFile("Right Medial") Then
            OpenFile("Right Medial", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Right Medial")
        End If
        loadFileData()
    End Sub
    Private Sub btnLeftLateral_Click(sender As Object, e As EventArgs) Handles btnLeftLateral.Click
        If CheckFile("Left Lateral") Then
            OpenFile("Left Lateral", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Left Lateral")
        End If
        loadFileData()
    End Sub
    Private Sub btnLeftMedial_Click(sender As Object, e As EventArgs) Handles btnLeftMedial.Click
        If CheckFile("Left Medial") Then
            OpenFile("Left Medial", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Left Medial")
        End If
        loadFileData()
    End Sub
    Private Sub btnSections1_Click(sender As Object, e As EventArgs) Handles btnSections1.Click
        If CheckFile("Sections 1") Then
            OpenFile("Sections 1", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Sections 1")
        End If
        loadFileData()
    End Sub
    Private Sub btnSections2_Click(sender As Object, e As EventArgs) Handles btnSections2.Click
        If CheckFile("Sections 2") Then
            OpenFile("Sections 2", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Sections 2")
        End If
        loadFileData()
    End Sub
    Private Sub btnDura_Click(sender As Object, e As EventArgs) Handles btnDura.Click
        If CheckFile("Dura") Then
            OpenFile("Dura", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Dura")
        End If
        loadFileData()
    End Sub
    Private Sub btnOther1_Click(sender As Object, e As EventArgs) Handles btnOther1.Click
        If CheckFile("Other 1") Then
            OpenFile("Other 1", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Other 1")
        End If
        loadFileData()
    End Sub
    Private Sub btnOther2_Click(sender As Object, e As EventArgs) Handles btnOther2.Click
        If CheckFile("Other 2") Then
            OpenFile("Other 2", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Other 2")
        End If
        loadFileData()
    End Sub
    Private Sub btnOther3_Click(sender As Object, e As EventArgs) Handles btnOther3.Click
        If CheckFile("Other 3") Then
            OpenFile("Other 3", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Other 3")
        End If
        loadFileData()
    End Sub
    Private Sub btnOther4_Click(sender As Object, e As EventArgs) Handles btnOther4.Click
        If CheckFile("Other 4") Then
            OpenFile("Other 4", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Other 4")
        End If
        loadFileData()
    End Sub
    Private Sub btnOther5_Click(sender As Object, e As EventArgs) Handles btnOther5.Click
        If CheckFile("Other 5") Then
            OpenFile("Other 5", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Other 5")
        End If
        loadFileData()
    End Sub
    Private Sub btnOther6_Click(sender As Object, e As EventArgs) Handles btnOther6.Click
        If CheckFile("Other 6") Then
            OpenFile("Other 6", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Other 6")
        End If
        loadFileData()
    End Sub
    Private Sub btnOther7_Click(sender As Object, e As EventArgs) Handles btnOther7.Click
        If CheckFile("Other 7") Then
            OpenFile("Other 7", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Other 7")
        End If
        loadFileData()
    End Sub
    Private Sub btnOther8_Click(sender As Object, e As EventArgs) Handles btnOther8.Click
        If CheckFile("Other 8") Then
            OpenFile("Other 8", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Other 8")
        End If
        loadFileData()
    End Sub
    Private Sub btnOther9_Click(sender As Object, e As EventArgs) Handles btnOther9.Click
        If CheckFile("Other 9") Then
            OpenFile("Other 9", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Other 9")
        End If
        loadFileData()
    End Sub
    Private Sub btnOther10_Click(sender As Object, e As EventArgs) Handles btnOther10.Click
        If CheckFile("Other 10") Then
            OpenFile("Other 10", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Other 10")
        End If
        loadFileData()
    End Sub
    Private Sub btnOther11_Click(sender As Object, e As EventArgs) Handles btnOther11.Click
        If CheckFile("Other 11") Then
            OpenFile("Other 11", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Other 11")
        End If
        loadFileData()
    End Sub
    Private Sub btnOther12_Click(sender As Object, e As EventArgs) Handles btnOther12.Click
        If CheckFile("Other 12") Then
            OpenFile("Other 12", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Other 12")
        End If
        loadFileData()
    End Sub
    Private Sub btnOther13_Click(sender As Object, e As EventArgs) Handles btnOther13.Click
        If CheckFile("Other 13") Then
            OpenFile("Other 13", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Other 13")
        End If
        loadFileData()
    End Sub
    Private Sub btnOther14_Click(sender As Object, e As EventArgs) Handles btnOther14.Click
        If CheckFile("Other 14") Then
            OpenFile("Other 14", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Other 14")
        End If
        loadFileData()
    End Sub
    Private Sub btnLateralFixed_Click(sender As Object, e As EventArgs) Handles btnLateralFixed.Click
        If CheckFile("Lateral Fixed") Then
            OpenFile("Lateral Fixed", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Lateral Fixed")
        End If
        loadFileData()
    End Sub
    Private Sub btnMedialFixed_Click(sender As Object, e As EventArgs) Handles btnMedialFixed.Click
        If CheckFile("Medial Fixed") Then
            OpenFile("Medial Fixed", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Medial Fixed")
        End If
        loadFileData()
    End Sub
    Private Sub btnFixed03_Click(sender As Object, e As EventArgs) Handles btnFixed03.Click
        If CheckFile("Fixed 3") Then
            OpenFile("Fixed 3", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Fixed 3")
        End If
        loadFileData()
    End Sub
    Private Sub btnFixed04_Click(sender As Object, e As EventArgs) Handles btnFixed04.Click
        If CheckFile("Fixed 4") Then
            OpenFile("Fixed 4", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Fixed 4")
        End If
        loadFileData()
    End Sub
    Private Sub btnFixed05_Click(sender As Object, e As EventArgs) Handles btnFixed05.Click
        If CheckFile("Fixed 5") Then
            OpenFile("Fixed 5", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Fixed 5")
        End If
        loadFileData()
    End Sub
    Private Sub btnFixed06_Click(sender As Object, e As EventArgs) Handles btnFixed06.Click
        If CheckFile("Fixed 6") Then
            OpenFile("Fixed 6", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Fixed 6")
        End If
        loadFileData()
    End Sub
    Private Sub btnFixed07_Click(sender As Object, e As EventArgs) Handles btnFixed07.Click
        If CheckFile("Fixed 7") Then
            OpenFile("Fixed 7", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Fixed 7")
        End If
        loadFileData()
    End Sub
    Private Sub btnFixed08_Click(sender As Object, e As EventArgs) Handles btnFixed08.Click
        If CheckFile("Fixed 8") Then
            OpenFile("Fixed 8", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Fixed 8")
        End If
        loadFileData()
    End Sub
    Private Sub btnFixed09_Click(sender As Object, e As EventArgs) Handles btnFixed09.Click
        If CheckFile("Fixed 9") Then
            OpenFile("Fixed 9", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Fixed 9")
        End If
        loadFileData()
    End Sub
    Private Sub btnFixed10_Click(sender As Object, e As EventArgs) Handles btnFixed10.Click
        If CheckFile("Fixed 10") Then
            OpenFile("Fixed 10", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Fixed 10")
        End If
        loadFileData()
    End Sub
    Private Sub btnFixed11_Click(sender As Object, e As EventArgs) Handles btnFixed11.Click
        If CheckFile("Fixed 11") Then
            OpenFile("Fixed 11", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Fixed 11")
        End If
        loadFileData()
    End Sub
    Private Sub btnFixed12_Click(sender As Object, e As EventArgs) Handles btnFixed12.Click
        If CheckFile("Fixed 12") Then
            OpenFile("Fixed 12", WarehouseShell.SubNum & "- Composite")
        Else
            SaveFile("Fixed 12")
        End If
        loadFileData()
    End Sub

    'File Delete buttons
    Private Sub btnCompositeRemove_Click(sender As Object, e As EventArgs) Handles btnCompositeRemove.Click
        If checkDelete() = True Then
            DeleteFile("Composite")
            loadFileData()
        End If
    End Sub
    Private Sub btnDorsalRemove_Click(sender As Object, e As EventArgs) Handles btnDorsalRemove.Click
        If checkDelete() = True Then
            DeleteFile("Dorsal")
            loadFileData()
        End If
    End Sub
    Private Sub btnVentralRemove_Click(sender As Object, e As EventArgs) Handles btnVentralRemove.Click
        If checkDelete() = True Then
            DeleteFile("Ventral")
            loadFileData()
        End If
    End Sub
    Private Sub btnRightLateralRemove_Click(sender As Object, e As EventArgs) Handles btnRightLateralRemove.Click
        If checkDelete() = True Then
            DeleteFile("Right Lateral")
            loadFileData()
        End If
    End Sub
    Private Sub btnRightMedialRemove_Click(sender As Object, e As EventArgs) Handles btnRightMedialRemove.Click
        If checkDelete() = True Then
            DeleteFile("Right Medial")
            loadFileData()
        End If
    End Sub
    Private Sub btnLeftLateralRemove_Click(sender As Object, e As EventArgs) Handles btnLeftLateralRemove.Click
        If checkDelete() = True Then
            DeleteFile("Left Lateral")
            loadFileData()
        End If
    End Sub
    Private Sub btnLeftMedialRemove_Click(sender As Object, e As EventArgs) Handles btnLeftMedialRemove.Click
        If checkDelete() = True Then
            DeleteFile("Left Medial")
            loadFileData()
        End If
    End Sub
    Private Sub btnSections1Remove_Click(sender As Object, e As EventArgs) Handles btnSections1Remove.Click
        If checkDelete() = True Then
            DeleteFile("Sections 1")
            loadFileData()
        End If
    End Sub
    Private Sub btnSections2Remove_Click(sender As Object, e As EventArgs) Handles btnSections2Remove.Click
        If checkDelete() = True Then
            DeleteFile("Sections 2")
            loadFileData()
        End If
    End Sub
    Private Sub btnDuraRemove_Click(sender As Object, e As EventArgs) Handles btnDuraRemove.Click
        If checkDelete() = True Then
            DeleteFile("Dura")
            loadFileData()
        End If
    End Sub
    Private Sub btnOther1Remove_Click(sender As Object, e As EventArgs) Handles btnOther1Remove.Click
        If checkDelete() = True Then
            DeleteFile("Other 1")
            loadFileData()
        End If
    End Sub
    Private Sub btnOther2Remove_Click(sender As Object, e As EventArgs) Handles btnOther2Remove.Click
        If checkDelete() = True Then
            DeleteFile("Other 2")
            loadFileData()
        End If
    End Sub
    Private Sub btnOther3Remove_Click(sender As Object, e As EventArgs) Handles btnOther3Remove.Click
        If checkDelete() = True Then
            DeleteFile("Other 3")
            loadFileData()
        End If
    End Sub
    Private Sub btnOther4Remove_Click(sender As Object, e As EventArgs) Handles btnOther4Remove.Click
        If checkDelete() = True Then
            DeleteFile("Other 4")
            loadFileData()
        End If
    End Sub
    Private Sub btnOther5Remove_Click(sender As Object, e As EventArgs) Handles btnOther5Remove.Click
        If checkDelete() = True Then
            DeleteFile("Other 5")
            loadFileData()
        End If
    End Sub
    Private Sub btnOther6Remove_Click(sender As Object, e As EventArgs) Handles btnOther6Remove.Click
        If checkDelete() = True Then
            DeleteFile("Other 6")
            loadFileData()
        End If
    End Sub
    Private Sub btnOther7Remove_Click(sender As Object, e As EventArgs) Handles btnOther7Remove.Click
        If checkDelete() = True Then
            DeleteFile("Other 7")
            loadFileData()
        End If
    End Sub
    Private Sub btnOther8Remove_Click(sender As Object, e As EventArgs) Handles btnOther8Remove.Click
        If checkDelete() = True Then
            DeleteFile("Other 8")
            loadFileData()
        End If
    End Sub
    Private Sub btnOther9Remove_Click(sender As Object, e As EventArgs) Handles btnOther9Remove.Click
        If checkDelete() = True Then
            DeleteFile("Other 9")
            loadFileData()
        End If
    End Sub
    Private Sub btnOther10Remove_Click(sender As Object, e As EventArgs) Handles btnOther10Remove.Click
        If checkDelete() = True Then
            DeleteFile("Other 10")
            loadFileData()
        End If
    End Sub
    Private Sub btnOther11Remove_Click(sender As Object, e As EventArgs) Handles btnOther11Remove.Click
        If checkDelete() = True Then
            DeleteFile("Other 11")
            loadFileData()
        End If
    End Sub
    Private Sub btnOther12Remove_Click(sender As Object, e As EventArgs) Handles btnOther12Remove.Click
        If checkDelete() = True Then
            DeleteFile("Other 12")
            loadFileData()
        End If
    End Sub
    Private Sub btnOther13Remove_Click(sender As Object, e As EventArgs) Handles btnOther13Remove.Click
        If checkDelete() = True Then
            DeleteFile("Other 13")
            loadFileData()
        End If
    End Sub
    Private Sub btnOther14Remove_Click(sender As Object, e As EventArgs) Handles btnOther14Remove.Click
        If checkDelete() = True Then
            DeleteFile("Other 14")
            loadFileData()
        End If
    End Sub
    Private Sub btnLateralFixedRemove_Click(sender As Object, e As EventArgs) Handles btnLateralFixedRemove.Click
        If checkDelete() = True Then
            DeleteFile("Lateral Fixed")
            loadFileData()
        End If
    End Sub
    Private Sub btnMedialFixedRemove_Click(sender As Object, e As EventArgs) Handles btnMedialFixedRemove.Click
        If checkDelete() = True Then
            DeleteFile("Medial Fixed")
            loadFileData()
        End If
    End Sub
    Private Sub btnFixed3Remove_Click(sender As Object, e As EventArgs) Handles btnFixed3Remove.Click
        If checkDelete() = True Then
            DeleteFile("Fixed 3")
            loadFileData()
        End If
    End Sub
    Private Sub btnFixed4Remove_Click(sender As Object, e As EventArgs) Handles btnFixed4Remove.Click
        If checkDelete() = True Then
            DeleteFile("Fixed 4")
            loadFileData()
        End If
    End Sub
    Private Sub btnFixed5Remove_Click(sender As Object, e As EventArgs) Handles btnFixed5Remove.Click
        If checkDelete() = True Then
            DeleteFile("Fixed 5")
            loadFileData()
        End If
    End Sub
    Private Sub btnFixed6Remove_Click(sender As Object, e As EventArgs) Handles btnFixed6Remove.Click
        If checkDelete() = True Then
            DeleteFile("Fixed 6")
            loadFileData()
        End If
    End Sub
    Private Sub btnFixed7Remove_Click(sender As Object, e As EventArgs) Handles btnFixed7Remove.Click
        If checkDelete() = True Then
            DeleteFile("Fixed 7")
            loadFileData()
        End If
    End Sub
    Private Sub btnFixed8Remove_Click(sender As Object, e As EventArgs) Handles btnFixed8Remove.Click
        If checkDelete() = True Then
            DeleteFile("Fixed 8")
            loadFileData()
        End If
    End Sub
    Private Sub btnFixed9Remove_Click(sender As Object, e As EventArgs) Handles btnFixed9Remove.Click
        If checkDelete() = True Then
            DeleteFile("Fixed 9")
            loadFileData()
        End If
    End Sub
    Private Sub btnFixed10Remove_Click(sender As Object, e As EventArgs) Handles btnFixed10Remove.Click
        If checkDelete() = True Then
            DeleteFile("Fixed 10")
            loadFileData()
        End If
    End Sub
    Private Sub btnFixed11Remove_Click(sender As Object, e As EventArgs) Handles btnFixed11Remove.Click
        If checkDelete() = True Then
            DeleteFile("Fixed 11")
            loadFileData()
        End If
    End Sub
    Private Sub btnFixed12Remove_Click(sender As Object, e As EventArgs) Handles btnFixed12Remove.Click
        If checkDelete() = True Then
            DeleteFile("Fixed 12")
            loadFileData()
        End If
    End Sub

    'File delete check dialog box
    Private Function checkDelete() As Boolean
        'MsgBox("Are you sure you want to delete this file?", MsgBoxStyle.YesNo)
        Dim result As MsgBoxResult = MsgBox("Are you sure you want to delete this file?", MsgBoxStyle.YesNo)
        If result = MsgBoxResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function preSaveValidation() As Boolean
        Dim result As Boolean = True
        Dim errMessage As String = ""

        If checkDuplicateTagNums() Then
            result = False
            errMessage = "There are two or more items with the same Tag # in the dissection map. This must be corrected before this record can be saved."
        End If

        If result = False Then
            MsgBox(errMessage, , "Error")
        End If

        Return result
    End Function
    Private Function checkDuplicateTagNums() As Boolean
        Dim checkArray(39) As Integer
        Dim i As Integer = 0
        Dim result As Boolean = False

        'Loop through all of the TextBoxIntLess40's to increment the corresponding array position whenever a matching result is found
        While i < 40
            Dim textControl As Control
            For Each textControl In GroupBox1.Controls
                If TypeOf textControl Is TextBoxIntLess40 Then
                    If IsNumeric(textControl.Text) Then
                        If CType(textControl.Text, Integer) = i + 1 Then
                            checkArray(i) += 1
                        End If
                    End If
                End If
            Next
            i += 1
        End While

        'Loop through the array to see if any counts are greater than 1
        i = 0
        While i < 40
            If checkArray(i) > 1 Then
                result = True
            End If
            i += 1
        End While

        Return result
    End Function

    'Imported IFormMethodss interface methods (some used, some not, based on which form is using the interface)
    Public Sub ShowPHI(showPHI As Boolean) Implements IFormMethods.ShowPHI
    End Sub
    Public Sub Parent1(ByRef val As Object) Implements IFormMethods.Parent
        Me.Parent = val
    End Sub
    Public Sub Show1() Implements IFormMethods.Show
        Show()
    End Sub
    Public Sub TopLevel1(val As Boolean) Implements IFormMethods.TopLevel
        Me.TopLevel = val
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
        btnDissectionMapBottom.PerformClick()
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Me.Dispose()
    End Sub
End Class