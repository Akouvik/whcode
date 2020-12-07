Public Class WA_PMCR
    Implements IFormMethods
    Public activeForm As IFormMethods
    Public headerExisits As Boolean = False
    Private Sub WA_PMCR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChartReview.SelectedTab = tabHeader
        activeForm = New WA_PMCR_Header
        activeForm.Parent(tabHeader)
        activeForm.Show()
        If Database.ExistingRecordCheck("PMCR_Header", "SubNum = " & WarehouseShell.SubNum) Then
            headerExisits = True
        End If
    End Sub

    'Form helper methods
    Public Sub loadTab(ByVal tab As TabPage)
        Select Case tab.Name
            Case "tabHeader"
                ChartReview.SelectedTab = tabHeader
            Case "tabDemographics"
                ChartReview.SelectedTab = tabDemographics
            Case "tabInformants"
                ChartReview.SelectedTab = tabInformants
            Case "tabHypoxia"
                ChartReview.SelectedTab = tabHypoxia
            Case "tabDiagnoses"
                ChartReview.SelectedTab = tabDiagnoses
            Case "tabMedications"
                ChartReview.SelectedTab = tabMedications
            Case "tabCVD"
                ChartReview.SelectedTab = tabCVD
            Case "tabHachinski"
                ChartReview.SelectedTab = tabHachinski
            Case "tabDepression"
                ChartReview.SelectedTab = tabDepression
            Case "tabMCIRS"
                ChartReview.SelectedTab = tabMCIRS
            Case "tabCDR"
                ChartReview.SelectedTab = tabCDR
            Case "tabAD8"
                ChartReview.SelectedTab = tabAD8
            Case "tabDementia1"
                ChartReview.SelectedTab = tabDementia1
            Case "tabDementia2"
                ChartReview.SelectedTab = tabDementia2
            Case "tabParkinsonism"
                ChartReview.SelectedTab = tabParkinsonism
            Case "tabVitalsAndLabs"
                ChartReview.SelectedTab = tabVitalsAndLabs
            Case "tabDEAD1"
                ChartReview.SelectedTab = tabDEAD1
            Case "tabDEAD2"
                ChartReview.SelectedTab = tabDEAD2
            Case "tabDEAD3"
                ChartReview.SelectedTab = tabDEAD3
            Case "tabDEAD4"
                ChartReview.SelectedTab = tabDEAD4
            Case "tab3D1"
                ChartReview.SelectedTab = tab3D1
            Case "tab3D2"
                ChartReview.SelectedTab = tab3D2
            Case "tab3D3"
                ChartReview.SelectedTab = tab3D3
            Case "tab3D4"
                ChartReview.SelectedTab = tab3D4
        End Select
    End Sub

    'Tab page change actions
    Private Sub ChartReview_Deselecting(sender As Control, e As TabControlCancelEventArgs) Handles ChartReview.Deselecting
        If TypeOf (activeForm) Is WA_PMCR_Header Then
            If headerExisits = False Then
                MsgBox("Header must be saved before any other tab may be modified.", MsgBoxStyle.OkOnly)
                e.Cancel() = True
                Exit Sub
            End If
        End If
        'Make sure there is no unsaved data
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View And WarehouseShell.DataMode <> WarehouseShell.userDataMode.Undefined Then
            Dim checkform As New PU_SaveWork
            Dim myResult As DialogResult = checkform.ShowDialog()
            checkform.Dispose()
            If myResult = DialogResult.Cancel Then
                e.Cancel() = True 'this breaks out of the entire tab change event (no subsequent ops will run)
            ElseIf myResult = DialogResult.OK Then
                activeForm.SaveWork()
                If Not IsNothing(activeForm) Then
                    activeForm.MyDispose()
                End If
            Else
                If Not IsNothing(activeForm) Then
                    activeForm.MyDispose()
                End If
            End If
        Else
            If Not IsNothing(activeForm) Then
                activeForm.MyDispose()
            End If
        End If
    End Sub
    Private Sub ChartReview_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles ChartReview.Selecting
        Select Case e.TabPage.Name
            Case "tabHeader"
                activeForm = New WA_PMCR_Header
                activeForm.Parent(tabHeader)
                activeForm.Show()
            Case "tabDemographics"
                Dim demoClass As WA_Demographics = New WA_Demographics()
                demoClass.txtSubNum.Visible = False
                demoClass.lblSubNum.Visible = False
                activeForm = demoClass
                activeForm.Parent(tabDemographics)
                activeForm.Show()
            Case "tabInformants"
                activeForm = New WA_PMCR_Informants
                activeForm.Parent(tabInformants)
                activeForm.Show()
            Case "tabHypoxia"
                activeForm = New WA_PMCR_Hypoxia
                activeForm.Parent(tabHypoxia)
                activeForm.Show()
            Case "tabDiagnoses"
                activeForm = New WA_PMCR_Diagnoses
                activeForm.Parent(tabDiagnoses)
                activeForm.Show()
            Case "tabMedications"
                activeForm = New WA_PMCR_Medications
                activeForm.Parent(tabMedications)
                activeForm.Show()
            Case "tabCVD"
                activeForm = New WA_PMCR_CVD
                activeForm.Parent(tabCVD)
                activeForm.Show()
            Case "tabHachinski"
                activeForm = New WA_PMCR_Hachinski
                activeForm.Parent(tabHachinski)
                activeForm.Show()
            Case "tabDepression"
                activeForm = New WA_PMCR_Depression
                activeForm.Parent(tabDepression)
                activeForm.Show()
            Case "tabMCIRS"
                activeForm = New WA_PMCR_MCIRS
                activeForm.Parent(tabMCIRS)
                activeForm.Show()
            Case "tabCDR"
                activeForm = New WA_PMCR_CDR
                activeForm.Parent(tabCDR)
                activeForm.Show()
            Case "tabAD8"
                activeForm = New WA_PMCR_AD8
                activeForm.Parent(tabAD8)
                activeForm.Show()
            Case "tabDementia1"
                activeForm = New WA_PMCR_Dementia1
                activeForm.Parent(tabDementia1)
                activeForm.Show()
            Case "tabDementia2"
                activeForm = New WA_PMCR_Dementia2
                activeForm.Parent(tabDementia2)
                activeForm.Show()
            Case "tabParkinsonism"
                activeForm = New WA_PMCR_Parkinsonism
                activeForm.Parent(tabParkinsonism)
                activeForm.Show()
            Case "tabVitalsAndLabs"
                activeForm = New WA_PMCR_Vitals_And_Labs
                activeForm.Parent(tabVitalsAndLabs)
                activeForm.Show()
            Case "tabDEAD1"
                activeForm = New WA_PMCR_Dead1
                activeForm.Parent(tabDEAD1)
                activeForm.Show()
            Case "tabDEAD2"
                activeForm = New WA_PMCR_Dead2
                activeForm.Parent(tabDEAD2)
                activeForm.Show()
            Case "tabDEAD3"
                activeForm = New WA_PMCR_Dead3
                activeForm.Parent(tabDEAD3)
                activeForm.Show()
            Case "tabDEAD4"
                activeForm = New WA_PMCR_Dead4
                activeForm.Parent(tabDEAD4)
                activeForm.Show()
            Case "tab3D1"
                activeForm = New WA_PMCR_3D1
                activeForm.Parent(tab3D1)
                activeForm.Show()
            Case "tab3D2"
                activeForm = New WA_PMCR_3D2
                activeForm.Parent(tab3D2)
                activeForm.Show()
            Case "tab3D3"
                activeForm = New WA_PMCR_3D3
                activeForm.Parent(tab3D3)
                activeForm.Show()
            Case "tab3D4"
                activeForm = New WA_PMCR_3D4
                activeForm.Parent(tab3D4)
                activeForm.Show()
            Case "tabCDR_INF"
                activeForm = New WA_PMCR_CDR_INF
                activeForm.Parent(tabCDR_INF)
                activeForm.Show()
        End Select
    End Sub

    'Imported IFormMethods interface methods (some used, some not, based on which form is using the interface)
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
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub

    Private Sub ChartReview_Deselecting(sender As Object, e As TabControlCancelEventArgs) Handles ChartReview.Deselecting

    End Sub
End Class