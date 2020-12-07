Public Class WA_CERADD
    Implements IFormMethods
    Private formTables As New DataSet
    Private errMsg As String = ""
    Private ValidationResult As Boolean = True

    'Form load subs
    Private Sub WA_CERADD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_CERADD")
        If Database.ExistingRecordCheck("CERADD", "SubNum = " & WarehouseShell.SubNum) = True Then
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            loadBaseForm()
            enableInputFields(False)
            loadExistingData()
            btnCERADDBottom.Text = "Edit this record"
            btnCERADDTop.Text = btnCERADDBottom.Text
            btnCERADDTop.Focus()
        Else
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            btnCERADDTop.Text = "Add New Record"
            btnCERADDBottom.Text = btnCERADDTop.Text
            enableInputFields(False)
            lblNoRecord.Visible = True
        End If
    End Sub
    Private Sub loadBaseForm()
        'Load all required lookup tables into the comboValues DataSet
        formTables.Tables.Add(Database.ReturnTable("lkpCERADSeverity0135"))
        formTables.Tables.Add(Database.ReturnTable("lkpNYUnk019"))
        formTables.Tables.Add(Database.ReturnTable("lkpCERADFrequency"))
        'Assign lookup values to each individual combobox
        'These don't allow blanks
        comboAtherosclerosis.assignLookup(formTables, "lkpCERADSeverity0135",,, "Value <> -1")
        comboSignificantObstruction.assignLookup(formTables, "lkpNYUnk019",,, "Value <> -1")
        comboGrossEvidence.assignLookup(formTables, "lkpNYUnk019",,, "Value <> -1")
        comboParenchymal.assignLookup(formTables, "lkpNYUnk019",,, "Value <> -1")
        'These allow blanks
        comboParenchymalInfarct.assignLookup(formTables, "lkpNYUnk019")
        comboParenchymalLacune.assignLookup(formTables, "lkpNYUnk019")
        comboParenchymalHemorrhage.assignLookup(formTables, "lkpNYUnk019")
        comboAnteriorCerebral.assignLookup(formTables, "lkpNYUnk019")
        comboMiddleCerebral.assignLookup(formTables, "lkpNYUnk019")
        comboPosteriorCerebral.assignLookup(formTables, "lkpNYUnk019")
        comboVertebroBasilar.assignLookup(formTables, "lkpNYUnk019")
        comboWaterAntMid.assignLookup(formTables, "lkpNYUnk019")
        comboWaterMidPos.assignLookup(formTables, "lkpNYUnk019")
        comboWaterOther.assignLookup(formTables, "lkpNYUnk019")
        comboOtherLentStriate.assignLookup(formTables, "lkpNYUnk019")
        comboBasalLacune.assignLookup(formTables, "lkpCERADSeverity0135")
        comboCerebralLacune.assignLookup(formTables, "lkpCERADSeverity0135")
        comboBrainstemLacune.assignLookup(formTables, "lkpCERADSeverity0135")
        comboOtherLacune.assignLookup(formTables, "lkpCERADSeverity0135")
        comboBasalInfarct.assignLookup(formTables, "lkpCERADSeverity0135")
        comboCerebralInfarct.assignLookup(formTables, "lkpCERADSeverity0135")
        comboBrainstemInfarct.assignLookup(formTables, "lkpCERADSeverity0135")
        comboOtherInfarct.assignLookup(formTables, "lkpCERADSeverity0135")
        comboCortexSmall.assignLookup(formTables, "lkpNYUnk019")
        comboCortexMedium.assignLookup(formTables, "lkpNYUnk019")
        comboCortexLarge.assignLookup(formTables, "lkpNYUnk019")
        comboCerebralSmall.assignLookup(formTables, "lkpNYUnk019")
        comboCerebralMedium.assignLookup(formTables, "lkpNYUnk019")
        comboCerebralLarge.assignLookup(formTables, "lkpNYUnk019")
        comboDeepSmall.assignLookup(formTables, "lkpNYUnk019")
        comboDeepMedium.assignLookup(formTables, "lkpNYUnk019")
        comboDeepLarge.assignLookup(formTables, "lkpNYUnk019")
        comboBrainstemSmall.assignLookup(formTables, "lkpNYUnk019")
        comboBrainstemMedium.assignLookup(formTables, "lkpNYUnk019")
        comboBrainstemLarge.assignLookup(formTables, "lkpNYUnk019")
        comboCerebellumSmall.assignLookup(formTables, "lkpNYUnk019")
        comboCerebellumMedium.assignLookup(formTables, "lkpNYUnk019")
        comboCerebellumLarge.assignLookup(formTables, "lkpNYUnk019")
    End Sub
    Private Sub defaultValues()
        'Set the required-value comboboxes to 0
        comboAtherosclerosis.SelectedValue = 0
        comboSignificantObstruction.SelectedValue = 0
        comboGrossEvidence.SelectedValue = 0
        comboParenchymal.SelectedValue = 0
        'Set the possibly-skipped comboboxes to -1 (blank)
        comboParenchymalInfarct.SelectedValue = -1
        comboParenchymalLacune.SelectedValue = -1
        comboParenchymalHemorrhage.SelectedValue = -1
        comboAnteriorCerebral.SelectedValue = -1
        comboMiddleCerebral.SelectedValue = -1
        comboPosteriorCerebral.SelectedValue = -1
        comboVertebroBasilar.SelectedValue = -1
        comboWaterAntMid.SelectedValue = -1
        comboWaterMidPos.SelectedValue = -1
        comboWaterOther.SelectedValue = -1
        comboOtherLentStriate.SelectedValue = -1
        comboBasalLacune.SelectedValue = -1
        comboCerebralLacune.SelectedValue = -1
        comboBrainstemLacune.SelectedValue = -1
        comboOtherLacune.SelectedValue = -1
        comboBasalInfarct.SelectedValue = -1
        comboCerebralInfarct.SelectedValue = -1
        comboBrainstemInfarct.SelectedValue = -1
        comboOtherInfarct.SelectedValue = -1
        comboCortexSmall.SelectedValue = -1
        comboCortexMedium.SelectedValue = -1
        comboCortexLarge.SelectedValue = -1
        comboCerebralSmall.SelectedValue = -1
        comboCerebralMedium.SelectedValue = -1
        comboCerebralLarge.SelectedValue = -1
        comboDeepSmall.SelectedValue = -1
        comboDeepMedium.SelectedValue = -1
        comboDeepLarge.SelectedValue = -1
        comboBrainstemSmall.SelectedValue = -1
        comboBrainstemMedium.SelectedValue = -1
        comboBrainstemLarge.SelectedValue = -1
        comboCerebellumSmall.SelectedValue = -1
        comboCerebellumMedium.SelectedValue = -1
        comboCerebellumLarge.SelectedValue = -1
    End Sub
    Private Sub loadExistingData()
        'Grab the CERADD record for this SubNum
        formTables.Tables.Add(Database.ReturnTable("CERADD", , "SubNum = " & WarehouseShell.SubNum))
        'Apply the existing values to the input fields
        comboAtherosclerosis.setValue(formTables, "CERADD", "Atherosclerosis")
        comboSignificantObstruction.setValue(formTables, "CERADD", "CerebralVesObst")
        txtSignificantObstructionNote.setValue(formTables, "CERADD", "CerebralVesObstNote")
        comboGrossEvidence.setValue(formTables, "CERADD", "OtherVascLesions")
        txtGrossEvidenceNote.setValue(formTables, "CERADD", "OtherVascLesionsNote")
        comboParenchymal.setValue(formTables, "CERADD", "ParenchVascLesions")
        comboParenchymalInfarct.setValue(formTables, "CERADD", "ParenchInfarct")
        comboParenchymalLacune.setValue(formTables, "CERADD", "ParenchLacune")
        comboParenchymalHemorrhage.setValue(formTables, "CERADD", "ParenchHemo")
        txtNumberOfLesions.setValue(formTables, "CERADD", "NumLesions")
        txtLargestSize1.setValue(formTables, "CERADD", "LargestLesion1")
        txtLargestSize2.setValue(formTables, "CERADD", "LargestLesion2")
        comboAnteriorCerebral.setValue(formTables, "CERADD", "AntCereLesion")
        comboMiddleCerebral.setValue(formTables, "CERADD", "MidCereLesion")
        comboPosteriorCerebral.setValue(formTables, "CERADD", "PostCereLesion")
        comboVertebroBasilar.setValue(formTables, "CERADD", "VertBasilLesion")
        comboBasalLacune.setValue(formTables, "CERADD", "BasalGangLacune")
        comboCerebralLacune.setValue(formTables, "CERADD", "CereWhtMatLacune")
        comboBrainstemLacune.setValue(formTables, "CERADD", "BSLacune")
        comboOtherLacune.setValue(formTables, "CERADD", "OthLacune")
        txtOtherLacuneNote.setValue(formTables, "CERADD", "OthLacuneNote")
        comboBasalInfarct.setValue(formTables, "CERADD", "BasalGangInfarct")
        comboCerebralInfarct.setValue(formTables, "CERADD", "CereWhtMatInfarct")
        comboBrainstemInfarct.setValue(formTables, "CERADD", "BSInfarct")
        comboOtherInfarct.setValue(formTables, "CERADD", "OthInfarct")
        txtOtherInfarctNote.setValue(formTables, "CERADD", "OthInfarctNote")
        txtNumberSmall.setValue(formTables, "CERADD", "SmlHemo")
        txtNumberMedium.setValue(formTables, "CERADD", "MedHemo")
        txtNumberLarge.setValue(formTables, "CERADD", "LrgHemo")
        comboCortexSmall.setValue(formTables, "CERADD", "SmlCortexHemo")
        comboCortexMedium.setValue(formTables, "CERADD", "MedCortexHemo")
        comboCortexLarge.setValue(formTables, "CERADD", "LrgCortexHemo")
        comboCerebralSmall.setValue(formTables, "CERADD", "SmlCereWhtMatHemo")
        comboCerebralMedium.setValue(formTables, "CERADD", "MedCereWhtMatHemo")
        comboCerebralLarge.setValue(formTables, "CERADD", "LrgCereWhtMatHemo")
        comboDeepSmall.setValue(formTables, "CERADD", "SmlDeepGrayHemo")
        comboDeepMedium.setValue(formTables, "CERADD", "MedDeepGrayHemo")
        comboDeepLarge.setValue(formTables, "CERADD", "LrgDeepGrayHemo")
        comboBrainstemSmall.setValue(formTables, "CERADD", "SmlBSHemo")
        comboBrainstemMedium.setValue(formTables, "CERADD", "MedBSHemo")
        comboBrainstemLarge.setValue(formTables, "CERADD", "LrgBSHemo")
        comboCerebellumSmall.SelectedValue = formTables.Tables("CERADD").Rows(0).Item("SmlCereHemo")
        comboCerebellumMedium.SelectedValue = formTables.Tables("CERADD").Rows(0).Item("MedCereHemo")
        comboCerebellumLarge.SelectedValue = formTables.Tables("CERADD").Rows(0).Item("LrgCereHemo")
        comboCerebellumSmall.setValue(formTables, "CERADD", "SmlCereHemo")
        comboCerebellumMedium.setValue(formTables, "CERADD", "MedCereHemo")
        comboCerebellumLarge.setValue(formTables, "CERADD", "LrgCereHemo")
    End Sub

    'Subs to enable-disable fields during data input based on conditional logic.
    Private Sub enableInputFields(ByVal value As Boolean)
        If value = True Then
            comboAtherosclerosis.Enabled = True
            comboSignificantObstruction.Enabled = True
            If comboSignificantObstruction.SelectedValue = 1 Then
                txtSignificantObstructionNote.Enabled = True
                txtSignificantObstructionNote.makeReadOnly(False)
            End If
            comboGrossEvidence.Enabled = True
            If comboGrossEvidence.SelectedValue = 1 Then
                txtGrossEvidenceNote.Enabled = True
                txtGrossEvidenceNote.makeReadOnly(False)
            End If
            comboParenchymal.Enabled = True
            'Enable child fields if Item 2 is yes
            If comboParenchymal.SelectedValue = 1 Then
                comboParenchymalInfarct.Enabled = True
                comboParenchymalLacune.Enabled = True
                comboParenchymalHemorrhage.Enabled = True
            End If
            'Enable 3a and 3c fields if Infarct is yes
            If comboParenchymalInfarct.SelectedValue = 1 Then
                '3a
                txtNumberOfLesions.Enabled = True
                txtLargestSize1.Enabled = True
                txtLargestSize2.Enabled = True
                comboAnteriorCerebral.Enabled = True
                comboMiddleCerebral.Enabled = True
                comboPosteriorCerebral.Enabled = True
                comboVertebroBasilar.Enabled = True
                comboWaterAntMid.Enabled = True
                comboWaterMidPos.Enabled = True
                comboWaterOther.Enabled = True
                txtWaterOther.Enabled = True
                txtWaterOther.makeReadOnly(False)
                comboOtherLentStriate.Enabled = True
                '3c
                comboBasalInfarct.Enabled = True
                comboCerebralInfarct.Enabled = True
                comboBrainstemInfarct.Enabled = True
                comboOtherInfarct.Enabled = True
                txtOtherInfarctNote.Enabled = True
                txtOtherInfarctNote.makeReadOnly(False)
            End If
            'Enable 3b fields if Lacune is yes
            If comboParenchymalLacune.SelectedValue = 1 Then
                comboBasalLacune.Enabled = True
                comboCerebralLacune.Enabled = True
                comboBrainstemLacune.Enabled = True
                comboOtherLacune.Enabled = True
                txtOtherLacuneNote.Enabled = True
                txtOtherLacuneNote.makeReadOnly(False)
            End If
            'Enable 3d fields if Hemorrhage is yes
            If comboParenchymalHemorrhage.SelectedValue = 1 Then
                txtNumberSmall.Enabled = True
                txtNumberMedium.Enabled = True
                txtNumberLarge.Enabled = True
                comboCortexSmall.Enabled = True
                comboCortexMedium.Enabled = True
                comboCortexLarge.Enabled = True
                comboCerebralSmall.Enabled = True
                comboCerebralMedium.Enabled = True
                comboCerebralLarge.Enabled = True
                comboDeepSmall.Enabled = True
                comboDeepMedium.Enabled = True
                comboDeepLarge.Enabled = True
                comboBrainstemSmall.Enabled = True
                comboBrainstemMedium.Enabled = True
                comboBrainstemLarge.Enabled = True
                comboCerebellumSmall.Enabled = True
                comboCerebellumMedium.Enabled = True
                comboCerebellumLarge.Enabled = True
            End If
        Else
            comboAtherosclerosis.Enabled = False
            comboSignificantObstruction.Enabled = False
            txtSignificantObstructionNote.Enabled = True
            txtSignificantObstructionNote.makeReadOnly(True)
            comboGrossEvidence.Enabled = False
            txtGrossEvidenceNote.Enabled = True
            txtGrossEvidenceNote.makeReadOnly(True)
            comboParenchymal.Enabled = False
            comboParenchymalInfarct.Enabled = False
            comboParenchymalLacune.Enabled = False
            comboParenchymalHemorrhage.Enabled = False
            txtNumberOfLesions.Enabled = False
            txtLargestSize1.Enabled = False
            txtLargestSize2.Enabled = False
            comboAnteriorCerebral.Enabled = False
            comboMiddleCerebral.Enabled = False
            comboPosteriorCerebral.Enabled = False
            comboVertebroBasilar.Enabled = False
            comboWaterAntMid.Enabled = False
            comboWaterMidPos.Enabled = False
            comboWaterOther.Enabled = False
            txtWaterOther.Enabled = True
            txtWaterOther.makeReadOnly(True)
            comboOtherLentStriate.Enabled = False
            comboBasalLacune.Enabled = False
            comboCerebralLacune.Enabled = False
            comboBrainstemLacune.Enabled = False
            comboOtherLacune.Enabled = False
            txtOtherLacuneNote.Enabled = True
            txtOtherLacuneNote.makeReadOnly(True)
            comboBasalInfarct.Enabled = False
            comboCerebralInfarct.Enabled = False
            comboBrainstemInfarct.Enabled = False
            comboOtherInfarct.Enabled = False
            txtOtherInfarctNote.Enabled = True
            txtOtherInfarctNote.makeReadOnly(True)
            txtNumberSmall.Enabled = False
            txtNumberMedium.Enabled = False
            txtNumberLarge.Enabled = False
            comboCortexSmall.Enabled = False
            comboCortexMedium.Enabled = False
            comboCortexLarge.Enabled = False
            comboCerebralSmall.Enabled = False
            comboCerebralMedium.Enabled = False
            comboCerebralLarge.Enabled = False
            comboDeepSmall.Enabled = False
            comboDeepMedium.Enabled = False
            comboDeepLarge.Enabled = False
            comboBrainstemSmall.Enabled = False
            comboBrainstemMedium.Enabled = False
            comboBrainstemLarge.Enabled = False
            comboCerebellumSmall.Enabled = False
            comboCerebellumMedium.Enabled = False
            comboCerebellumLarge.Enabled = False
        End If
    End Sub
    Private Sub comboSignificantObstruction_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboSignificantObstruction.SelectedValueChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View And WarehouseShell.DataMode <> WarehouseShell.userDataMode.Undefined Then
            If comboSignificantObstruction.SelectedValue = 1 Then
                txtSignificantObstructionNote.makeReadOnly(False)
            Else
                txtSignificantObstructionNote.makeReadOnly(True)
                txtSignificantObstructionNote.Clear()
            End If
        End If
    End Sub
    Private Sub comboGrossEvidence_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboGrossEvidence.SelectedValueChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View And WarehouseShell.DataMode <> WarehouseShell.userDataMode.Undefined Then
            If comboGrossEvidence.SelectedValue = 1 Then
                txtGrossEvidenceNote.makeReadOnly(False)
            Else
                txtGrossEvidenceNote.makeReadOnly(True)
                txtGrossEvidenceNote.Clear()
            End If
        End If
    End Sub
    Private Sub comboParenchymal_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboParenchymal.SelectedValueChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View And WarehouseShell.DataMode <> WarehouseShell.userDataMode.Undefined Then
            If comboParenchymal.SelectedValue = 1 Then
                'Enable dependent fields and set default values
                comboParenchymalInfarct.Enabled = True
                comboParenchymalLacune.Enabled = True
                comboParenchymalHemorrhage.Enabled = True
                comboParenchymalInfarct.SelectedValue = 0
                comboParenchymalLacune.SelectedValue = 0
                comboParenchymalHemorrhage.SelectedValue = 0
            Else
                'Cascade disable dependent fields and clear all values
                comboParenchymalInfarct.SelectedValue = -1
                comboParenchymalLacune.SelectedValue = -1
                comboParenchymalHemorrhage.SelectedValue = -1
                txtNumberOfLesions.Clear()
                txtLargestSize1.Clear()
                txtLargestSize2.Clear()
                comboAnteriorCerebral.SelectedValue = -1
                comboMiddleCerebral.SelectedValue = -1
                comboPosteriorCerebral.SelectedValue = -1
                comboVertebroBasilar.SelectedValue = -1
                comboWaterAntMid.SelectedValue = -1
                comboWaterMidPos.SelectedValue = -1
                comboWaterOther.SelectedValue = -1
                txtWaterOther.Clear()
                comboOtherLentStriate.SelectedValue = -1
                comboBasalLacune.SelectedValue = -1
                comboCerebralLacune.SelectedValue = -1
                comboBrainstemLacune.SelectedValue = -1
                comboOtherLacune.SelectedValue = -1
                txtOtherLacuneNote.Clear()
                comboBasalInfarct.SelectedValue = -1
                comboCerebralInfarct.SelectedValue = -1
                comboBrainstemInfarct.SelectedValue = -1
                comboOtherInfarct.SelectedValue = -1
                txtOtherInfarctNote.Clear()
                txtNumberSmall.Clear()
                txtNumberMedium.Clear()
                txtNumberLarge.Clear()
                comboCortexSmall.SelectedValue = -1
                comboCortexMedium.SelectedValue = -1
                comboCortexLarge.SelectedValue = -1
                comboCerebralSmall.SelectedValue = -1
                comboCerebralMedium.SelectedValue = -1
                comboCerebralLarge.SelectedValue = -1
                comboDeepSmall.SelectedValue = -1
                comboDeepMedium.SelectedValue = -1
                comboDeepLarge.SelectedValue = -1
                comboBrainstemSmall.SelectedValue = -1
                comboBrainstemMedium.SelectedValue = -1
                comboBrainstemLarge.SelectedValue = -1
                comboCerebellumSmall.SelectedValue = -1
                comboCerebellumMedium.SelectedValue = -1
                comboCerebellumLarge.SelectedValue = -1
                comboParenchymalInfarct.Enabled = False
                comboParenchymalLacune.Enabled = False
                comboParenchymalHemorrhage.Enabled = False
                txtNumberOfLesions.Enabled = False
                txtLargestSize1.Enabled = False
                txtLargestSize2.Enabled = False
                comboAnteriorCerebral.Enabled = False
                comboMiddleCerebral.Enabled = False
                comboPosteriorCerebral.Enabled = False
                comboVertebroBasilar.Enabled = False
                comboBasalLacune.Enabled = False
                comboCerebralLacune.Enabled = False
                comboBrainstemLacune.Enabled = False
                comboOtherLacune.Enabled = False
                txtOtherLacuneNote.Enabled = False
                comboBasalInfarct.Enabled = False
                comboCerebralInfarct.Enabled = False
                comboBrainstemInfarct.Enabled = False
                comboOtherInfarct.Enabled = False
                txtOtherInfarctNote.Enabled = False
                txtNumberSmall.Enabled = False
                txtNumberMedium.Enabled = False
                txtNumberLarge.Enabled = False
                comboCortexSmall.Enabled = False
                comboCortexMedium.Enabled = False
                comboCortexLarge.Enabled = False
                comboCerebralSmall.Enabled = False
                comboCerebralMedium.Enabled = False
                comboCerebralLarge.Enabled = False
                comboDeepSmall.Enabled = False
                comboDeepMedium.Enabled = False
                comboDeepLarge.Enabled = False
                comboBrainstemSmall.Enabled = False
                comboBrainstemMedium.Enabled = False
                comboBrainstemLarge.Enabled = False
                comboCerebellumSmall.Enabled = False
                comboCerebellumMedium.Enabled = False
                comboCerebellumLarge.Enabled = False
            End If
        End If
    End Sub
    Private Sub comboParenchymalInfarct_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboParenchymalInfarct.SelectedValueChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View And WarehouseShell.DataMode <> WarehouseShell.userDataMode.Undefined Then
            If comboParenchymalInfarct.SelectedValue = 1 Then
                'Enable dependent fields and set default values
                txtNumberOfLesions.Enabled = True
                txtLargestSize1.Enabled = True
                txtLargestSize2.Enabled = True
                comboAnteriorCerebral.Enabled = True
                comboMiddleCerebral.Enabled = True
                comboPosteriorCerebral.Enabled = True
                comboVertebroBasilar.Enabled = True
                comboWaterAntMid.Enabled = True
                comboWaterMidPos.Enabled = True
                comboWaterOther.Enabled = True
                txtWaterOther.Enabled = True
                comboOtherLentStriate.Enabled = True
                comboBasalInfarct.Enabled = True
                comboCerebralInfarct.Enabled = True
                comboBrainstemInfarct.Enabled = True
                comboOtherInfarct.Enabled = True
                txtOtherInfarctNote.Enabled = True
                comboAnteriorCerebral.SelectedValue = 0
                comboMiddleCerebral.SelectedValue = 0
                comboPosteriorCerebral.SelectedValue = 0
                comboVertebroBasilar.SelectedValue = 0
                comboWaterAntMid.SelectedValue = 0
                comboWaterMidPos.SelectedValue = 0
                comboWaterOther.SelectedValue = 0
                txtWaterOther.Clear()
                comboOtherLentStriate.SelectedValue = 0
                comboBasalInfarct.SelectedValue = 0
                comboCerebralInfarct.SelectedValue = 0
                comboOtherInfarct.SelectedValue = 0
                comboBasalInfarct.SelectedValue = 0
                comboCerebralInfarct.SelectedValue = 0
                comboBrainstemInfarct.SelectedValue = 0
                comboOtherInfarct.SelectedValue = 0
            Else
                'Cascade disable dependent fields and clear all values
                txtNumberOfLesions.Enabled = False
                txtLargestSize1.Enabled = False
                txtLargestSize2.Enabled = False
                comboAnteriorCerebral.Enabled = False
                comboMiddleCerebral.Enabled = False
                comboPosteriorCerebral.Enabled = False
                comboVertebroBasilar.Enabled = False
                comboWaterAntMid.Enabled = False
                comboWaterMidPos.Enabled = False
                comboWaterOther.Enabled = False
                txtWaterOther.Enabled = False
                comboOtherLentStriate.Enabled = False
                comboBasalInfarct.Enabled = False
                comboCerebralInfarct.Enabled = False
                comboBrainstemInfarct.Enabled = False
                comboOtherInfarct.Enabled = False
                txtOtherInfarctNote.Enabled = False
                txtNumberOfLesions.Text = "0"
                txtLargestSize1.Clear()
                txtLargestSize2.Clear()
                comboAnteriorCerebral.SelectedValue = 0
                comboMiddleCerebral.SelectedValue = 0
                comboPosteriorCerebral.SelectedValue = 0
                comboVertebroBasilar.SelectedValue = 0
                comboWaterAntMid.SelectedValue = 0
                comboWaterMidPos.SelectedValue = 0
                comboWaterOther.SelectedValue = 0
                txtWaterOther.Clear()
                comboOtherLentStriate.SelectedValue = 0
                comboBasalInfarct.SelectedValue = 0
                comboCerebralInfarct.SelectedValue = 0
                comboBrainstemInfarct.SelectedValue = 0
                comboOtherInfarct.SelectedValue = 0
                txtOtherInfarctNote.Clear()
            End If
        End If
    End Sub
    Private Sub comboParenchymalLacune_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboParenchymalLacune.SelectedValueChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View And WarehouseShell.DataMode <> WarehouseShell.userDataMode.Undefined Then
            If comboParenchymalLacune.SelectedValue = 1 Then
                'Enable dependent fields and set default values
                comboBasalLacune.Enabled = True
                comboCerebralLacune.Enabled = True
                comboBrainstemLacune.Enabled = True
                comboOtherLacune.Enabled = True
                txtOtherLacuneNote.Enabled = True
                comboBasalLacune.SelectedValue = 0
                comboCerebralLacune.SelectedValue = 0
                comboBrainstemLacune.SelectedValue = 0
                comboOtherLacune.SelectedValue = 0
                txtOtherLacuneNote.Clear()
            Else
                'Cascade disable dependent fields and clear all values
                comboBasalLacune.Enabled = False
                comboCerebralLacune.Enabled = False
                comboBrainstemLacune.Enabled = False
                comboOtherLacune.Enabled = False
                txtOtherLacuneNote.Enabled = False
                comboBasalLacune.SelectedValue = 0
                comboCerebralLacune.SelectedValue = 0
                comboBrainstemLacune.SelectedValue = 0
                comboOtherLacune.SelectedValue = 0
                txtOtherLacuneNote.Clear()
            End If
        End If
    End Sub
    Private Sub comboParenchymalHemorrhage_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboParenchymalHemorrhage.SelectedValueChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View And WarehouseShell.DataMode <> WarehouseShell.userDataMode.Undefined Then
            If comboParenchymalHemorrhage.SelectedValue = 1 Then
                'Enable dependent fields and set default values
                txtNumberSmall.Enabled = True
                txtNumberMedium.Enabled = True
                txtNumberLarge.Enabled = True
                comboCortexSmall.Enabled = True
                comboCortexMedium.Enabled = True
                comboCortexLarge.Enabled = True
                comboCerebralSmall.Enabled = True
                comboCerebralMedium.Enabled = True
                comboCerebralLarge.Enabled = True
                comboDeepSmall.Enabled = True
                comboDeepMedium.Enabled = True
                comboDeepLarge.Enabled = True
                comboBrainstemSmall.Enabled = True
                comboBrainstemMedium.Enabled = True
                comboBrainstemLarge.Enabled = True
                comboCerebellumSmall.Enabled = True
                comboCerebellumMedium.Enabled = True
                comboCerebellumLarge.Enabled = True
                comboCortexSmall.SelectedValue = 0
                comboCortexMedium.SelectedValue = 0
                comboCortexLarge.SelectedValue = 0
                comboCerebralSmall.SelectedValue = 0
                comboCerebralMedium.SelectedValue = 0
                comboCerebralLarge.SelectedValue = 0
                comboDeepSmall.SelectedValue = 0
                comboDeepMedium.SelectedValue = 0
                comboDeepLarge.SelectedValue = 0
                comboBrainstemSmall.SelectedValue = 0
                comboBrainstemMedium.SelectedValue = 0
                comboBrainstemLarge.SelectedValue = 0
                comboCerebellumSmall.SelectedValue = 0
                comboCerebellumMedium.SelectedValue = 0
                comboCerebellumLarge.SelectedValue = 0
                txtNumberSmall.Text = "0"
                txtNumberMedium.Text = "0"
                txtNumberLarge.Text = "0"
            Else
                'Cascade disable dependent fields and clear all values
                txtNumberSmall.Enabled = False
                txtNumberMedium.Enabled = False
                txtNumberLarge.Enabled = False
                comboCortexSmall.Enabled = False
                comboCortexMedium.Enabled = False
                comboCortexLarge.Enabled = False
                comboCerebralSmall.Enabled = False
                comboCerebralMedium.Enabled = False
                comboCerebralLarge.Enabled = False
                comboDeepSmall.Enabled = False
                comboDeepMedium.Enabled = False
                comboDeepLarge.Enabled = False
                comboBrainstemSmall.Enabled = False
                comboBrainstemMedium.Enabled = False
                comboBrainstemLarge.Enabled = False
                comboCerebellumSmall.Enabled = False
                comboCerebellumMedium.Enabled = False
                comboCerebellumLarge.Enabled = False
                txtNumberSmall.Text = "0"
                txtNumberMedium.Text = "0"
                txtNumberLarge.Text = "0"
                comboCortexSmall.SelectedValue = 0
                comboCortexMedium.SelectedValue = 0
                comboCortexLarge.SelectedValue = 0
                comboCerebralSmall.SelectedValue = 0
                comboCerebralMedium.SelectedValue = 0
                comboCerebralLarge.SelectedValue = 0
                comboDeepSmall.SelectedValue = 0
                comboDeepMedium.SelectedValue = 0
                comboDeepLarge.SelectedValue = 0
                comboBrainstemSmall.SelectedValue = 0
                comboBrainstemMedium.SelectedValue = 0
                comboBrainstemLarge.SelectedValue = 0
                comboCerebellumSmall.SelectedValue = 0
                comboCerebellumMedium.SelectedValue = 0
                comboCerebellumLarge.SelectedValue = 0
            End If
        End If
    End Sub

    'Define button click events
    Private Sub btnCERADD_Click(sender As Object, e As EventArgs) Handles btnCERADDBottom.Click, btnCERADDTop.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_CERADD", "Modify") Then
                enableInputFields(True)
                btnCERADDBottom.Text = "Save changes"
                btnCERADDTop.Text = btnCERADDBottom.Text
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
            Else
                MsgBox("You do not have permission to edit this form.", MsgBoxStyle.OkOnly, "Warning")
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If Database.ExistingRecordCheck("CERAD_Header", "SubNum = " & WarehouseShell.SubNum) Then
                If User.PermissionCheck("WA_CERADD", "Modify") Then
                    loadBaseForm()
                    defaultValues()
                    enableInputFields(True)
                    btnCERADDBottom.Text = "Save new record"
                    btnCERADDTop.Text = btnCERADDBottom.Text
                    lblNoRecord.Visible = False
                    WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
                Else
                    MsgBox("You do not have permission to create this form.", MsgBoxStyle.OkOnly, "Warning")
                End If
            Else
                MsgBox("Please create a CERAD Header for this subject before attempting to add CERAD information.", MsgBoxStyle.OkOnly, "Error!")
            End If
        Else
            preSaveValidation()
            If ValidationResult Then
                Dim sqlCommand As New SqlCommand
                sqlCommand.Connection = WarehouseShell.conn
                Dim cmdString = "@SubNum = " & WarehouseShell.SubNum &
                    ", @Atherosclerosis = " & comboAtherosclerosis.getSQLValue() &
                    ", @CerebralVesobst = " & comboSignificantObstruction.getSQLValue() &
                    ", @CerebralVesObstNote = " & txtSignificantObstructionNote.getSQLValue() &
                    ", @OtherVascLesions = " & comboGrossEvidence.getSQLValue() &
                    ", @OtherVascLesionsNote = " & txtGrossEvidenceNote.getSQLValue() &
                    ", @ParenchVascLesions = " & comboParenchymal.getSQLValue() &
                    ", @ParenchInfarct = " & comboParenchymalInfarct.getSQLValue() &
                    ", @ParenchLacune = " & comboParenchymalLacune.getSQLValue() &
                    ", @ParenchHemo = " & comboParenchymalHemorrhage.getSQLValue() &
                    ", @NumLesions = " & txtNumberOfLesions.getSQLValue() &
                    ", @LargestLesion1 = " & txtLargestSize1.getSQLValue() &
                    ", @LargestLesion2 = " & txtLargestSize2.getSQLValue() &
                    ", @AntCereLesion = " & comboAnteriorCerebral.getSQLValue() &
                    ", @MidCereLesion = " & comboMiddleCerebral.getSQLValue() &
                    ", @PostCereLesion = " & comboMiddleCerebral.getSQLValue() &
                    ", @VertBasilLesion = " & comboVertebroBasilar.getSQLValue() &
                    ", @WatershedAntMid = " & comboWaterAntMid.getSQLValue() &
                    ", @WatershedMidPos = " & comboWaterMidPos.getSQLValue() &
                    ", @WatershedOther = " & comboWaterOther.getSQLValue() &
                    ", @WatershedOtherNote = " & txtWaterOther.getSQLValue() &
                    ", @OtherLentStriate = " & comboOtherLentStriate.getSQLValue() &
                    ", @BasalGangLacune = " & comboBasalLacune.getSQLValue() &
                    ", @CereWhtMatLacune = " & comboCerebralLacune.getSQLValue() &
                    ", @BSLacune = " & comboBrainstemLacune.getSQLValue() &
                    ", @OthLacune = " & comboOtherLacune.getSQLValue() &
                    ", @OthLacuneNote = " & txtOtherLacuneNote.getSQLValue() &
                    ", @BasalGangInfarct = " & comboBasalInfarct.getSQLValue() &
                    ", @CereWhtMatInfarct = " & comboCerebralInfarct.getSQLValue() &
                    ", @BSInfarct = " & comboBrainstemInfarct.getSQLValue() &
                    ", @OthInfarct = " & comboOtherInfarct.getSQLValue() &
                    ", @OthInfarctNote = " & txtOtherInfarctNote.getSQLValue() &
                    ", @SmlHemo = " & txtNumberSmall.getSQLValue() &
                    ", @MedHemo = " & txtNumberMedium.getSQLValue() &
                    ", @LrgHemo = " & txtNumberLarge.getSQLValue() &
                    ", @SmlCortexHemo = " & comboCortexSmall.getSQLValue() &
                    ", @MedCortexHemo = " & comboCortexMedium.getSQLValue() &
                    ", @LrgCortexHemo = " & comboCortexLarge.getSQLValue() &
                    ", @SmlCereWhtMatHemo = " & comboCerebralSmall.getSQLValue() &
                    ", @MedCereWhtMatHemo = " & comboCerebralMedium.getSQLValue() &
                    ", @LrgCereWhtMatHemo = " & comboCerebralLarge.getSQLValue() &
                    ", @SmlDeepGrayHemo = " & comboDeepSmall.getSQLValue() &
                    ", @MedDeepGrayHemo = " & comboDeepMedium.getSQLValue() &
                    ", @LrgDeepGrayHemo = " & comboDeepLarge.getSQLValue() &
                    ", @SmlBSHemo = " & comboBrainstemSmall.getSQLValue() &
                    ", @MedBSHemo = " & comboBrainstemMedium.getSQLValue() &
                    ", @LrgBSHemo = " & comboBrainstemLarge.getSQLValue() &
                    ", @SmlCereHemo = " & comboCerebellumSmall.getSQLValue() &
                    ", @MedCereHemo = " & comboCerebellumMedium.getSQLValue() &
                    ", @LrgCereHemo = " & comboCerebellumLarge.getSQLValue() & ";"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    sqlCommand.CommandText = "EXEC dbo.modCERADDRecord @Action = 1, " & cmdString
                    Try
                        sqlCommand.ExecuteNonQuery()
                        MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        enableInputFields(False)
                        btnCERADDBottom.Text = "Edit this record"
                        btnCERADDTop.Text = btnCERADDBottom.Text
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else
                    sqlCommand.CommandText = "EXEC dbo.modCERADDRecord @Action = 2, " & cmdString
                    Try
                        sqlCommand.ExecuteNonQuery()
                        MessageBox.Show("Record successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        enableInputFields(False)
                        btnCERADDBottom.Text = "Edit this record"
                        btnCERADDTop.Text = btnCERADDBottom.Text
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                End If
            End If
        End If
    End Sub

    'PreSave Validation Subs
    Private Sub preSaveValidation()
        ValidationResult = True
        errMsg += "The following errors must be corrected before this record can be saved:" & vbNewLine & vbNewLine
        'run all validation subs
        validateComboSignificantObstruction()
        validateComboGrossEvidence()
        validateComboParenchInfarct()
        validateComboParenchLacune()
        validateComboParenchHemo()
        validateTxtNumberOfLesions()
        validateComboWaterOther()
        validateComboOtherLacune()
        validateComboOtherInfarct()

        'throw an error message if ValidationResult = false
        If ValidationResult = False Then
            MsgBox(errMsg, MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub
    'Validate comboSignificantObstruction
    Private Sub validateComboSignificantObstruction()
        If comboSignificantObstruction.SelectedValue <> 1 And txtSignificantObstructionNote.Text <> "" Then
            ValidationResult = False
            errMsg += "- You have entered a Significant Obstruction of Cerebral Vessels note without selecting ""Yes"" in Item 1b. Please clear the note or select ""Yes"" in item 1b." & vbNewLine
        ElseIf comboSignificantObstruction.SelectedValue = 1 And txtSignificantObstructionNote.Text = "" Then
            ValidationResult = False
            errMsg += "- You have selected ""Yes"" for Item 1b, but have not entered in a note in the Describe box. Please enter a note or change your response to Item 1b." & vbNewLine
        End If
    End Sub
    'Validate comboGrossEvidence
    Private Sub validateComboGrossEvidence()
        If comboGrossEvidence.SelectedValue <> 1 And txtGrossEvidenceNote.Text <> "" Then
            ValidationResult = False
            errMsg += "- You have entered a Gross Evidence of Vascular Lesions note without selecting ""Yes"" in Item 1c. Please clear the note or select ""Yes"" in item 1c." & vbNewLine
        ElseIf comboGrossEvidence.SelectedValue = 1 And txtGrossEvidenceNote.Text = "" Then
            ValidationResult = False
            errMsg += "- You have selected ""Yes"" for Item 1c, but have not entered in a note in the Describe box. Please enter a note or change your response to Item 1c." & vbNewLine
        End If
    End Sub
    'Validate comboParenchInfarct (it it's yes, make sure at least one dependent field has a positive response)
    Private Sub validateComboParenchInfarct()
        If comboParenchymalInfarct.SelectedValue = 1 Then
            Dim numPosResponses As Integer = 0
            'count positive responses
            If comboAnteriorCerebral.SelectedValue > 0 Then
                numPosResponses += 1
            End If
            If comboMiddleCerebral.SelectedValue > 0 Then
                numPosResponses += 1
            End If
            If comboPosteriorCerebral.SelectedValue > 0 Then
                numPosResponses += 1
            End If
            If comboVertebroBasilar.SelectedValue > 0 Then
                numPosResponses += 1
            End If
            If comboWaterAntMid.SelectedValue > 0 Then
                numPosResponses += 1
            End If
            If comboWaterMidPos.SelectedValue > 0 Then
                numPosResponses += 1
            End If
            If comboWaterOther.SelectedValue > 0 Then
                numPosResponses += 1
            End If
            If comboOtherLentStriate.SelectedValue > 0 Then
                numPosResponses += 1
            End If
            If comboBasalInfarct.SelectedValue > 0 Then
                numPosResponses += 1
            End If
            If comboCerebralInfarct.SelectedValue > 0 Then
                numPosResponses += 1
            End If
            If comboBrainstemInfarct.SelectedValue > 0 Then
                numPosResponses += 1
            End If
            If comboOtherInfarct.SelectedValue > 0 Then
                numPosResponses += 1
            End If

            If numPosResponses = 0 Then
                ValidationResult = False
                errMsg += "- You have indicated the presence of infarcts in Item 3, but there are no positive supporting responses in Items 3a or 3c." & vbNewLine
            End If
        End If
    End Sub
    'Validate comboParenchLacune (it it's yes, make sure at least one dependent field has a positive response)
    Private Sub validateComboParenchLacune()
        If comboParenchymalLacune.SelectedValue = 1 Then
            Dim numPosResponses As Integer = 0
            'count positive responses
            If comboBasalLacune.SelectedValue > 0 Then
                numPosResponses += 1
            End If
            If comboCerebralLacune.SelectedValue > 0 Then
                numPosResponses += 1
            End If
            If comboBrainstemLacune.SelectedValue > 0 Then
                numPosResponses += 1
            End If
            If comboOtherLacune.SelectedValue > 0 Then
                numPosResponses += 1
            End If

            If numPosResponses = 0 Then
                ValidationResult = False
                errMsg += "- You have indicated the presence of lacunes in Item 3, but there are no positive supporting responses in Item 3b." & vbNewLine
            End If
        End If
    End Sub
    'Validate comboParenchHemo (it it's yes, make sure at least one dependent field has a positive response)
    Private Sub validateComboParenchHemo()
        If comboParenchymalHemorrhage.SelectedValue = 1 Then
            'get counts of small, medium, and large positive responses from the comboboxes
            'small counts
            Dim countSmlHemo As Integer = 0
            If comboCortexSmall.SelectedValue = 1 Then
                countSmlHemo += 1
            End If
            If comboCerebralSmall.SelectedValue = 1 Then
                countSmlHemo += 1
            End If
            If comboDeepSmall.SelectedValue = 1 Then
                countSmlHemo += 1
            End If
            If comboBrainstemSmall.SelectedValue = 1 Then
                countSmlHemo += 1
            End If
            If comboCerebellumSmall.SelectedValue = 1 Then
                countSmlHemo += 1
            End If
            'medium counts
            Dim countMedHemo As Integer = 0
            If comboCortexMedium.SelectedValue = 1 Then
                countMedHemo += 1
            End If
            If comboCerebralMedium.SelectedValue = 1 Then
                countMedHemo += 1
            End If
            If comboDeepMedium.SelectedValue = 1 Then
                countMedHemo += 1
            End If
            If comboBrainstemMedium.SelectedValue = 1 Then
                countMedHemo += 1
            End If
            If comboCerebellumMedium.SelectedValue = 1 Then
                countMedHemo += 1
            End If
            'large counts
            Dim countLrgHemo As Integer = 0
            If comboCortexLarge.SelectedValue = 1 Then
                countLrgHemo += 1
            End If
            If comboCerebralLarge.SelectedValue = 1 Then
                countLrgHemo += 1
            End If
            If comboDeepLarge.SelectedValue = 1 Then
                countLrgHemo += 1
            End If
            If comboBrainstemLarge.SelectedValue = 1 Then
                countLrgHemo += 1
            End If
            If comboCerebellumLarge.SelectedValue = 1 Then
                countLrgHemo += 1
            End If

            'compare to textboxes
            'small
            If (txtNumberSmall.Text = "" Or txtNumberSmall.Text = "0") And countSmlHemo > 0 Then
                ValidationResult = False
                errMsg += "- In section 3d, you have left Number small blank or entered 0, but have provided 1 or more yes responses in the 5 regions under small." & vbNewLine
            ElseIf (txtNumberSmall.Text <> "" And txtNumberSmall.Text <> "0") And countSmlHemo = 0 Then
                ValidationResult = False
                errMsg += "- In section 3d, you have entered a number of small hemorrhages but have not provided any yes responses for the 5 regions under small." & vbNewLine
            End If
            'medium
            If (txtNumberMedium.Text = "" Or txtNumberMedium.Text = "0") And countMedHemo > 0 Then
                ValidationResult = False
                errMsg += "- In section 3d, you have left Number medium blank or entered 0, but have provided 1 or more yes responses in the 5 regions under medium." & vbNewLine
            ElseIf (txtNumberMedium.Text <> "" And txtNumberMedium.Text <> "0") And countMedHemo = 0 Then
                ValidationResult = False
                errMsg += "- In section 3d, you have entered a number of medium hemorrhages but have not provided any yes responses for the 5 regions under medium." & vbNewLine
            End If
            'large
            If (txtNumberLarge.Text = "" Or txtNumberLarge.Text = "0") And countLrgHemo > 0 Then
                ValidationResult = False
                errMsg += "- In section 3d, you have left Number large blank or entered 0, but have provided 1 or more yes responses in the 5 regions under large." & vbNewLine
            ElseIf (txtNumberLarge.Text <> "" And txtNumberLarge.Text <> "0") And countLrgHemo = 0 Then
                ValidationResult = False
                errMsg += "- In section 3d, you have entered a number of large hemorrhages but have not provided any yes responses for the 5 regions under large." & vbNewLine
            End If

            If countSmlHemo = 0 And countMedHemo = 0 And countLrgHemo = 0 Then
                ValidationResult = False
                errMsg += "- You have indicated the presence of hemorrhages in section 3, but have not provided any locations in section 3d." & vbNewLine
            End If

            If (txtNumberSmall.Text = "" Or txtNumberSmall.Text = "0") And (txtNumberMedium.Text = "" Or txtNumberMedium.Text = "0") And (txtNumberLarge.Text = "" Or txtNumberLarge.Text = "0") Then
                ValidationResult = False
                errMsg += "- You have indicated the presence of hemorrhages in section 3, but have not provided any valid numbers in Number small, Number medium, or Number large in section 3d" & vbNewLine
            End If
        End If
    End Sub
    'Validate txtNumberOfLesions
    Private Sub validateTxtNumberOfLesions()
        Dim count3a As Integer = 0
        If comboAnteriorCerebral.SelectedValue > 0 Then
            count3a += 1
        End If
        If comboMiddleCerebral.SelectedValue > 0 Then
            count3a += 1
        End If
        If comboPosteriorCerebral.SelectedValue > 0 Then
            count3a += 1
        End If
        If comboVertebroBasilar.SelectedValue > 0 Then
            count3a += 1
        End If
        If comboWaterAntMid.SelectedValue > 0 Then
            count3a += 1
        End If
        If comboWaterMidPos.SelectedValue > 0 Then
            count3a += 1
        End If
        If comboWaterOther.SelectedValue > 0 Then
            count3a += 1
        End If
        If comboOtherLentStriate.SelectedValue > 0 Then
            count3a += 1
        End If
        If count3a > 0 Then
            If txtNumberOfLesions.Text = "" Or txtLargestSize1.Text = "" Or txtLargestSize2.Text = "" Then
                ValidationResult = False
                errMsg += "- You have specified a positive response under Item 3a, but are missing one of the following: Number of Lesions, Largest size(1), Largest size (2). Please provide the missing value(s) or change your responses under Item 3a." & vbNewLine
            End If
        ElseIf count3a = 0 Then
            If (txtNumberOfLesions.Text <> "0" And txtNumberOfLesions.Text <> "") Or txtLargestSize1.Text <> "" Or txtLargestSize2.Text <> "" Then
                ValidationResult = False
                errMsg += "- In Item 3a, you have specified either a number of lesions or a size, but have not provided any locations for these lesions. Please clear the Number and Size of lesions fields or select 1 or more locations where these lesins were observed." & vbNewLine
            End If
        End If
    End Sub
    'Validate comboWaterOther
    Private Sub validateComboWaterOther()
        If comboWaterOther.SelectedValue <> 1 And txtWaterOther.Text <> "" Then
            ValidationResult = False
            errMsg += "- You have entered a Watershed Other note without selecting ""Yes"" in the Watershed Other dropdown box. Please clear the note or select ""Yes"" in the dropdown box." & vbNewLine
        ElseIf comboWaterOther.SelectedValue = 1 And txtWaterOther.Text = "" Then
            ValidationResult = False
            errMsg += "- You have selected ""Yes"" in the Watershed Other dropdown box but have not specified a note (Item 3a). Please add a note or change your selection in the dropdown box." & vbNewLine
        End If
    End Sub
    'Validate comboOtherLacune
    Private Sub validateComboOtherLacune()
        If comboOtherLacune.SelectedValue = 0 And txtOtherLacuneNote.Text <> "" Then
            ValidationResult = False
            errMsg += "- You have entered an Other Lacune note without selecting a frequency in the Other Lacune dropdown box (item 3b). Please clear the note or select ""Yes"" in the dropdown box." & vbNewLine
        ElseIf comboOtherLacune.SelectedValue > 0 And txtOtherLacuneNote.Text = "" Then
            ValidationResult = False
            errMsg += "- You have selected a frequency above None in the Other Lacune dropdown box but have not specified a note (item 3b). Please add a note or change your selection in the dropdown box." & vbNewLine
        End If
    End Sub
    'Validate comboOtherInfarct
    Private Sub validateComboOtherInfarct()
        If comboOtherInfarct.SelectedValue = 0 And txtOtherInfarctNote.Text <> "" Then
            ValidationResult = False
            errMsg += "- You have entered an Other Infarct note without selecting ""Yes"" in the Other Lacune dropdown box (item 3c). Please clear the note or select ""Yes"" in the dropdown box." & vbNewLine
        ElseIf comboOtherInfarct.SelectedValue > 0 And txtOtherInfarctNote.Text = "" Then
            ValidationResult = False
            errMsg += "- You have selected ""Yes"" in the Other Infarct dropdown box but have not specified a note (item 3c). Please add a note or change your selection in the dropdown box." & vbNewLine
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
        TopLevel = val
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
        btnCERADDBottom.PerformClick()
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class