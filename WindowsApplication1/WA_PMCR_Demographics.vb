Imports DataWarehouse

Public Class WA_PMCR_Demographics
    Implements IFormMethods
    Private formTables As New DataSet

    Private Sub WA_PMCR_Demographics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Database.ExistingRecordCheck("PMCR_Dementia1", "SubNum = " & WarehouseShell.SubNum) Then
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            loadBaseForm()
            loadExistingData()
            btnSaveBottom.Text = "Edit Record"
            btnSaveTop.Text = btnSaveBottom.Text
        Else 'If it doesn't exist, change mode to Undefined and show user banner
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            btnSaveBottom.Text = "Add New Record"
            btnSaveTop.Text = btnSaveBottom.Text
        End If
        enableInputFields(False)
    End Sub
    Private Sub loadBaseForm()
        formTables.Tables.Add(Database.ReturnTable("lkpYN12"))
        cmbRelWithDem.assignLookup(formTables, "lkpYN12")
        cmbVisNormWOLenses.assignLookup(formTables, "lkpYN12")
        cmbWearCorLenses.assignLookup(formTables, "lkpYN12")
        cmbVisNormWLenses.assignLookup(formTables, "lkpYN12")
        cmbHearNormWOAids.assignLookup(formTables, "lkpYN12")
        cmbWearHearAids.assignLookup(formTables, "lkpYN12")
    End Sub
    Private Sub loadExistingData()
        formTables.Tables.Add(Database.ReturnTable("PMCR_Demographics",, "SubNum = " & WarehouseShell.SubNum))
        cmbRelWithDem.setValue(formTables, "PMCR_Demographics", "RelWithDem")
        intRelWithDemCount.setValue(formTables, "PMCR_Demographics", "FullSibCount")
        intFullSibCount.setValue(formTables, "PMCR_Demographics", "FullSibDemCount")
        intFullSibDemCount.setValue(formTables, "PMCR_Demographics", "RelWithDem")
        intBioChildCount.setValue(formTables, "PMCR_Demographics", "RelWithDem")
        intBioChildDemCount.setValue(formTables, "PMCR_Demographics", "RelWithDem")
        intBloodRelDemCount.setValue(formTables, "PMCR_Demographics", "RelWithDem")
        cmbVisNormWOLenses.setValue(formTables, "PMCR_Demographics", "VisNormWOLenses")
        cmbWearCorLenses.setValue(formTables, "PMCR_Demographics", "WearCorLenses")
        cmbVisNormWLenses.setValue(formTables, "PMCR_Demographics", "VisNormWLenses")
        cmbHearNormWOAids.setValue(formTables, "PMCR_Demographics", "HearNormWOAids")
        cmbWearHearAids.setValue(formTables, "PMCR_Demographics", "WearHearAids")
    End Sub
    Private Sub enableInputFields(ByVal bool As Boolean)
        cmbRelWithDem.Enabled = bool
        intRelWithDemCount.Enabled = bool
        intFullSibCount.Enabled = bool
        intFullSibDemCount.Enabled = bool
        intBioChildCount.Enabled = bool
        intBioChildDemCount.Enabled = bool
        intBloodRelDemCount.Enabled = bool
        cmbVisNormWOLenses.Enabled = bool
        cmbWearCorLenses.Enabled = bool
        cmbVisNormWLenses.Enabled = bool
        cmbHearNormWOAids.Enabled = bool
        cmbWearHearAids.Enabled = bool
    End Sub

    Public Sub TopLevel(val As Boolean) Implements IFormMethods.TopLevel
        Throw New NotImplementedException()
    End Sub
    Public Sub ShowPHI(val As Boolean) Implements IFormMethods.ShowPHI
        Throw New NotImplementedException()
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
        Throw New NotImplementedException()
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Throw New NotImplementedException()
    End Sub
    Private Sub IFormMethods_Parent(ByRef val As Object) Implements IFormMethods.Parent
        Throw New NotImplementedException()
    End Sub
    Private Sub IFormMethods_Show() Implements IFormMethods.Show
        Throw New NotImplementedException()
    End Sub
End Class