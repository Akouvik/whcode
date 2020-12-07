Public Class WA_ExistingSubjectRecords
    Implements IFormMethods
    Private formTables As New DataSet
    Private myHeight As Int32 = 60

    Private Sub WA_ExistingSubjectRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_ExistingSubjectRecords")
        'Call each of the form subs. These subs moved outside of the OnLoad sub for ease of reading (could have been left in as one large chain of individual If statements).
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        loadSubjectRecord()
        loadAutopsyFaceSheet()
        loadAutopsyDissectionMap()
        loadShortInitialSummary()
        loadCERADHeader()
        loadCERADB()
        loadCERADC()
        loadCERADD()
        loadCERADE()
        loadCERADF()
        loadCERADG1()
        loadCERADG2()
        loadCERADH()
        loadCERADIJ()
        loadCERADAddendum()
        loadPlaqueCounts()
        loadTangleCounts()
        loadNPSummary()
        loadConsensusDx()
        loadPMCR()
        Height = myHeight
        'set DNC/DND
        DoNotContact()
        DoNotDissect()
        'InfectiousState()
        DoNotDistribute()
    End Sub

    'All the subs to populate the individual panels and DGV's (or hide them if there are no associated records).
    Private Sub loadSubjectRecord()
        If Database.ExistingRecordCheck("Subject", "SubNum = " & WarehouseShell.SubNum) = True Then
            'Load the relevant fields into a new table in the formTables DataSet.
            formTables.Tables.Add(Database.ReturnTable("viewSubject", "SubNum, BB, NACCID as 'NACC ID'", "SubNum = " & WarehouseShell.SubNum))
            'Set the DGV source to the newly added table
            dgvSubject.DataSource = formTables.Tables("viewSubject")
            dgvSubject.AutoResizeColumns()
            myHeight += pnlSubject.Height
        Else
            'Hide the panel if there are no records.
            dgvSubject.Visible = False
        End If
    End Sub
    Private Sub loadAutopsyFaceSheet()
        If Database.ExistingRecordCheck("AutopsyFaceSheet", "SubNum = " & WarehouseShell.SubNum) = True Then
            'Load the relevant fields into a new table in the formTables DataSet.
            formTables.Tables.Add(Database.ReturnTable("viewAutopsyFaceSheet", "BB, PMI, DateOfDeath as 'DoD', TempDX as 'Temp DX', Prosector1Label as 'Prosector', PlaceOfDeathLabel as " &
                                                             "'Place of Death', ReferringInstitutionLabel as 'Referring Institution'", "SubNum = " & WarehouseShell.SubNum))
            'Set the DGV source to the newly added table
            dgvAutopsyFaceSheet.DataSource = formTables.Tables("viewAutopsyFaceSheet")
            dgvAutopsyFaceSheet.AutoResizeColumns()
            myHeight += pnlAutopsyFaceSheet.Height
        Else
            'Hide the panel if there are no records.
            pnlAutopsyFaceSheet.Visible = False
        End If
    End Sub
    Private Sub loadAutopsyDissectionMap()
        If Database.ExistingRecordCheck("AutopsyDissectionMap", "SubNum = " & WarehouseShell.SubNum) = True Then
            'Load the relevant fields into a new table in the formTables DataSet.
            formTables.Tables.Add(Database.ReturnTable("viewAutopsyDissectionMap", "HemisphereLabel as 'Hemisphere'", "SubNum = " & WarehouseShell.SubNum))
            'Set the DGV source to the newly added table
            dgvAutopsyDissectionMap.DataSource = formTables.Tables("viewAutopsyDissectionMap")
            dgvAutopsyDissectionMap.AutoResizeColumns()
            myHeight += pnlAutopsyDissectionMap.Height
        Else
            'Hide the panel if there are no records.
            pnlAutopsyDissectionMap.Visible = False
        End If
    End Sub
    Private Sub loadShortInitialSummary()
        If Database.ExistingRecordCheck("ShortInitialSummary", "SubNum = " & WarehouseShell.SubNum) = True Then
            'Load the relevant fields into a new table in the formTables DataSet.
            formTables.Tables.Add(Database.ReturnTable("ShortInitialSummary", "BB, SummaryDate as 'Summary Date'", "SubNum = " & WarehouseShell.SubNum))
            'Set the DGV source to the newly added table
            dgvShortInitialSummary.DataSource = formTables.Tables("ShortInitialSummary")
            dgvShortInitialSummary.AutoResizeColumns()
            myHeight += pnlShortInitialSummary.Height
        Else
            'Hide the panel if there are no records.
            pnlShortInitialSummary.Visible = False
        End If
    End Sub
    Private Sub loadCERADHeader()
        If Database.ExistingRecordCheck("CERAD_Header", "SubNum = " & WarehouseShell.SubNum) = True Then
            'Load the relevant fields into a new table in the formTables DataSet.
            formTables.Tables.Add(Database.ReturnTable("viewCERAD_Header", "NeuropathologistName as Neuropathologist, XENum as 'XE Num', NeuropathDate as 'Date Completed'", "SubNum = " & WarehouseShell.SubNum))
            'Set the DGV source to the newly added table
            dgvCERADHeader.DataSource = formTables.Tables("viewCERAD_Header")
            dgvCERADHeader.AutoResizeColumns()
            myHeight += pnlCERADHeader.Height
        Else
            'Hide the panel if there are no records.
            pnlCERADHeader.Visible = False
        End If
    End Sub
    Private Sub loadCERADB()
        If Database.ExistingRecordCheck("CERADB", "SubNum = " & WarehouseShell.SubNum) = True Then
            'Load the relevant fields into a new table in the formTables DataSet.
            formTables.Tables.Add(Database.ReturnTable("viewCERADB", "AlzheimersLabel as Alzheimers, ParkinsonsLabel as Parkinsons, DiabetesLabel as Diabetes", "SubNum = " & WarehouseShell.SubNum))
            'Set the DGV source to the newly added table
            dgvCERADB.DataSource = formTables.Tables("viewCERADB")
            dgvCERADB.AutoResizeColumns()
            myHeight += pnlCERADB.Height
        Else
            'Hide the panel if there are no records.
            pnlCERADB.Visible = False
        End If
    End Sub
    Private Sub loadCERADC()
        If Database.ExistingRecordCheck("CERADC", "SubNum = " & WarehouseShell.SubNum) = True Then
            'Load the relevant fields into a new table in the formTables DataSet.
            formTables.Tables.Add(Database.ReturnTable("viewCERADC", "TotalBrainWeight as 'Total Brain Weight', FixedOrFreshLabel as 'Fixed or Fresh'", "SubNum = " & WarehouseShell.SubNum))
            'Set the DGV source to the newly added table
            dgvCERADC.DataSource = formTables.Tables("viewCERADC")
            dgvCERADC.AutoResizeColumns()
            myHeight += pnlCERADC.Height
        Else
            'Hide the panel if there are no records.
            pnlCERADC.Visible = False
        End If
    End Sub
    Private Sub loadCERADD()
        If Database.ExistingRecordCheck("CERADD", "SubNum = " & WarehouseShell.SubNum) = True Then
            'Load the relevant fields into a new table in the formTables DataSet.
            formTables.Tables.Add(Database.ReturnTable("viewCERADD", "AtherosclerosisLabel as 'Atherosclerosis'", "SubNum = " & WarehouseShell.SubNum))
            'Set the DGV source to the newly added table
            dgvCERADD.DataSource = formTables.Tables("viewCERADD")
            dgvCERADD.AutoResizeColumns()
            myHeight += pnlCERADD.Height
        Else
            'Hide the panel if there are no records.
            pnlCERADD.Visible = False
        End If
    End Sub
    Private Sub loadCERADE()
        If Database.ExistingRecordCheck("CERADE", "SubNum = " & WarehouseShell.SubNum) = True Then
            'Load the relevant fields into a new table in the formTables DataSet.
            formTables.Tables.Add(Database.ReturnTable("viewCERADE", "ArteriosclerosisLabel as 'Arteriosclerosis', ArteriolarsclerosisLabel as Arteriolarsclerosis", "SubNum = " & WarehouseShell.SubNum))
            'Set the DGV source to the newly added table
            dgvCERADE.DataSource = formTables.Tables("viewCERADE")
            dgvCERADE.AutoResizeColumns()
            myHeight += pnlCERADE.Height
        Else
            'Hide the panel if there are no records.
            pnlCERADE.Visible = False
        End If
    End Sub
    Private Sub loadCERADF()
        If Database.ExistingRecordCheck("CERADF", "SubNum = " & WarehouseShell.SubNum) = True Then
            'Load the relevant fields into a new table in the formTables DataSet.
            formTables.Tables.Add(Database.ReturnTable("viewCERADF", "AbnormalitiesLabel as 'Microscopic Abnormalities'", "SubNum = " & WarehouseShell.SubNum))
            'Set the DGV source to the newly added table
            dgvCERADF.DataSource = formTables.Tables("viewCERADF")
            dgvCERADF.AutoResizeColumns()
            myHeight += pnlCERADF.Height
        Else
            'Hide the panel if there are no records.
            pnlCERADF.Visible = False
        End If
    End Sub
    Private Sub loadCERADG1()
        If Database.ExistingRecordCheck("CERADG1", "SubNum = " & WarehouseShell.SubNum) = True Then
            'Load the relevant fields into a new table in the formTables DataSet.
            formTables.Tables.Add(Database.ReturnTable("viewCERADG1", "HandE as 'H & E', CongoRed as 'Congo Red'", "SubNum = " & WarehouseShell.SubNum))
            'Set the DGV source to the newly added table
            dgvCERADG1.DataSource = formTables.Tables("viewCERADG1")
            dgvCERADG1.AutoResizeColumns()
            myHeight += pnlCERADG1.Height
        Else
            'Hide the panel if there are no records.
            pnlCERADG1.Visible = False
        End If
    End Sub
    Private Sub loadCERADG2()
        If Database.ExistingRecordCheck("CERADG2", "SubNum = " & WarehouseShell.SubNum) = True Then
            'Load the relevant fields into a new table in the formTables DataSet.
            formTables.Tables.Add(Database.ReturnTable("viewCERADG2", "MidPlaquesLabel as 'Neuritic Plaques MF'", "SubNum = " & WarehouseShell.SubNum))
            'Set the DGV source to the newly added table
            dgvCERADG2.DataSource = formTables.Tables("viewCERADG2")
            dgvCERADG2.AutoResizeColumns()
            myHeight += pnlCERADG2.Height
        Else
            'Hide the panel if there are no records.
            pnlCERADG2.Visible = False
        End If
    End Sub
    Private Sub loadCERADH()
        If Database.ExistingRecordCheck("CERADH", "SubNum = " & WarehouseShell.SubNum) = True Then
            'Load the relevant fields into a new table in the formTables DataSet.
            formTables.Tables.Add(Database.ReturnTable("viewCERADH", "PlaqueScoreLabel as 'Age-Related Plaque Score'", "SubNum = " & WarehouseShell.SubNum))
            'Set the DGV source to the newly added table
            dgvCERADH.DataSource = formTables.Tables("viewCERADH")
            dgvCERADH.AutoResizeColumns()
            myHeight += pnlCERADH.Height
        Else
            'Hide the panel if there are no records.
            pnlCERADH.Visible = False
        End If
    End Sub
    Private Sub loadCERADIJ()
        If Database.ExistingRecordCheck("CERADIJ", "SubNum = " & WarehouseShell.SubNum) = True Then
            'Load the relevant fields into a new table in the formTables DataSet.
            formTables.Tables.Add(Database.ReturnTable("viewCERADIJ", "NormalBrainLabel as 'Normal Brain', DefAlzheimersLabel as 'Definite Alzheimer''s'", "SubNum = " & WarehouseShell.SubNum))
            'Set the DGV source to the newly added table
            dgvCERADI.DataSource = formTables.Tables("viewCERADIJ")
            dgvCERADI.AutoResizeColumns()
            myHeight += pnlCERADI.Height
        Else
            'Hide the panel if there are no records.
            pnlCERADI.Visible = False
        End If
    End Sub
    Private Sub loadCERADAddendum()
        If Database.ExistingRecordCheck("CERAD_Addendum", "SubNum = " & WarehouseShell.SubNum) = True Then
            'Load the relevant fields into a new table in the formTables DataSet.
            formTables.Tables.Add(Database.ReturnTable("viewCERAD_Addendum", "Path8aLabel as 'Path 8a', Path8bLabel as 'Path 8b', Path8cLabel as 'Path 8c', Path8dLabel as 'Path 8d'", "SubNum = " & WarehouseShell.SubNum))
            'Set the DGV source to the newly added table
            dgvCERADAddendum.DataSource = formTables.Tables("viewCERAD_Addendum")
            dgvCERADAddendum.AutoResizeColumns()
            myHeight += pnlCERADAddendum.Height
        Else
            'Hide the panel if there are no records.
            pnlCERADAddendum.Visible = False
        End If
    End Sub
    Private Sub loadPlaqueCounts()
        If Database.ExistingRecordCheck("PlaqueCounts", "SubNum = " & WarehouseShell.SubNum) = True Then
            'Load the relevant fields into a new table in the formTables DataSet.
            formTables.Tables.Add(Database.ReturnTable("PlaqueCounts", "Mean, MFGAverage as 'MFG Avg', OFGAverage as 'OFG Avg', STGAverage as 'STG Avg', IPLAverage as 'IPL Avg', OCAverage as 'OC Avg', HippoAverage as 'Hippo Avg', EntCtxAverage as 'EntCtx Avg'", "SubNum = " & WarehouseShell.SubNum))
            'Set the DGV source to the newly added table
            dgvPlaqueCounts.DataSource = formTables.Tables("PlaqueCounts")
            dgvPlaqueCounts.AutoResizeColumns()
            myHeight += pnlPlaqueCounts.Height
        Else
            'Hide the panel if there are no records.
            pnlPlaqueCounts.Visible = False
        End If
    End Sub
    Private Sub loadTangleCounts()
        If Database.ExistingRecordCheck("TangleCounts", "SubNum = " & WarehouseShell.SubNum) = True Then
            'Load the relevant fields into a new table in the formTables DataSet.
            formTables.Tables.Add(Database.ReturnTable("TangleCounts", "Mean, MFGAverage as 'MFG Avg', OFGAverage as 'OFG Avg', STGAverage as 'STG Avg', IPLAverage as 'IPL Avg', OCAverage as 'OC Avg', HippoAverage as 'Hippo Avg', EntCtxAverage as 'EntCtx Avg'", "SubNum = " & WarehouseShell.SubNum))
            'Set the DGV source to the newly added table
            dgvTangleCounts.DataSource = formTables.Tables("TangleCounts")
            dgvTangleCounts.AutoResizeColumns()
            myHeight += pnlTangleCounts.Height
        Else
            'Hide the panel if there are no records.
            pnlTangleCounts.Visible = False
        End If
    End Sub
    Private Sub loadNPSummary()
        If Database.ExistingRecordCheck("NPSummary", "SubNum = " & WarehouseShell.SubNum) = True Then
            'Load the relevant fields into a new table in the formTables DataSet.
            formTables.Tables.Add(Database.ReturnTable("NPSummary", "NP1Text as NP1", "SubNum = " & WarehouseShell.SubNum))
            'Set the DGV source to the newly added table
            dgvNPSummary.DataSource = formTables.Tables("NPSummary")
            dgvNPSummary.AutoResizeColumns()
            myHeight += pnlNPSummary.Height
        Else
            'Hide the panel if there are no records.
            pnlNPSummary.Visible = False
        End If
    End Sub
    Private Sub loadConsensusDx()
        If Database.ExistingRecordCheck("ConsensusDx", "SubNum = " & WarehouseShell.SubNum) = True Then
            'Load the relevant fields into a new table in the formTables DataSet.
            formTables.Tables.Add(Database.ReturnTable("viewConsensusDx", "FinPrimDx as 'Final Primary', FinPrimDxText as 'Final Primary Text'", "SubNum = " & WarehouseShell.SubNum))
            'Set the DGV source to the newly added table
            dgvConsensusDx.DataSource = formTables.Tables("viewConsensusDx")
            dgvConsensusDx.AutoResizeColumns()
            myHeight += pnlConsensusDx.Height
        Else
            'Hide the panel if there are no records.
            pnlConsensusDx.Visible = False
        End If
    End Sub
    Private Sub loadPMCR()
        If Database.ExistingRecordCheck("PMCR_Header", "SubNum = " & WarehouseShell.SubNum & " and AssessmentDate is not null") = True Then
            'Load the relevant fields into a new table in the formTables DataSet.
            formTables.Tables.Add(Database.ReturnTable("PMCR_Header", "SubNum, AssessmentDate as 'Date'", "SubNum = " & WarehouseShell.SubNum))
            'Set the DGV source to the newly added table
            dgvPMCR_Header.DataSource = formTables.Tables("PMCR_Header")
            dgvPMCR_Header.AutoResizeColumns()
            myHeight += dgvPMCR_Header.Height
        Else
            'Hide the panel if there are no records.
            WarehouseShell.RecordID = "0"
            pnlPMCR_Header.Visible = False
        End If
    End Sub

    'Subs to allow the user to double-click a record to initiate the a button-click-like event DoubleClickHandler (need 1 for every DGV).
    Private Sub DoubleClickHandler(ByVal myForm As WarehouseShell.formType, Optional ByVal myRecordID As String = "")
        WarehouseShell.RecordID = myRecordID
        WarehouseShell.LoadWorkingAreaForm(myForm)
    End Sub
    Private Sub dgvSubject_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubject.CellDoubleClick
        DoubleClickHandler(WarehouseShell.formType.WA_Demographics)
    End Sub
    Private Sub dgvAutopsyFaceSheet_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAutopsyFaceSheet.CellDoubleClick
        DoubleClickHandler(WarehouseShell.formType.WA_AutopsyFaceSheet)
    End Sub
    Private Sub dgvAutopsyDissectionMap_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAutopsyDissectionMap.CellDoubleClick
        DoubleClickHandler(WarehouseShell.formType.WA_AutopsyDissectionMap)
    End Sub
    Private Sub dgvCERADHeader_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCERADHeader.CellDoubleClick
        DoubleClickHandler(WarehouseShell.formType.WA_CERAD_Header)
    End Sub
    Private Sub dgvCERADB_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCERADB.CellDoubleClick
        DoubleClickHandler(WarehouseShell.formType.WA_CERADB)
    End Sub
    Private Sub dgvCERADC_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCERADC.CellDoubleClick
        DoubleClickHandler(WarehouseShell.formType.WA_CERADC)
    End Sub
    Private Sub dgvCERADD_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCERADD.CellDoubleClick
        DoubleClickHandler(WarehouseShell.formType.WA_CERADD)
    End Sub
    Private Sub dgvCERADE_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCERADE.CellDoubleClick
        DoubleClickHandler(WarehouseShell.formType.WA_CERADE)
    End Sub
    Private Sub dgvCERADF_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCERADF.CellDoubleClick
        DoubleClickHandler(WarehouseShell.formType.WA_CERADF)
    End Sub
    Private Sub dgvCERADG1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCERADG1.CellDoubleClick
        DoubleClickHandler(WarehouseShell.formType.WA_CERADG1)
    End Sub
    Private Sub dgvCERADG2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCERADG2.CellDoubleClick
        DoubleClickHandler(WarehouseShell.formType.WA_CERADG2)
    End Sub
    Private Sub dgvCERADH_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCERADH.CellDoubleClick
        DoubleClickHandler(WarehouseShell.formType.WA_CERADH)
    End Sub
    Private Sub dgvCERADI_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCERADI.CellDoubleClick
        DoubleClickHandler(WarehouseShell.formType.WA_CERADIJ)
    End Sub
    Private Sub dgvCERADAddendum_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCERADAddendum.CellDoubleClick
        DoubleClickHandler(WarehouseShell.formType.WA_CERAD_Addendum)
    End Sub
    Private Sub dgvPlaqueCounts_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPlaqueCounts.CellDoubleClick
        DoubleClickHandler(WarehouseShell.formType.WA_PlaqueCounts)
    End Sub
    Private Sub dgvTangleCounts_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTangleCounts.CellDoubleClick
        DoubleClickHandler(WarehouseShell.formType.WA_TangleCounts)
    End Sub
    Private Sub dgvNPSummary_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNPSummary.CellDoubleClick
        DoubleClickHandler(WarehouseShell.formType.WA_NPSummary)
    End Sub
    Private Sub dgvConsensusDx_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsensusDx.CellDoubleClick
        DoubleClickHandler(WarehouseShell.formType.WA_ConsenusDx)
    End Sub
    Private Sub dgvPMCR_Header_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPMCR_Header.CellDoubleClick
        WarehouseShell.LoadWorkingAreaForm(WarehouseShell.formType.WA_PMCR)
    End Sub

    'Allow user to click label to launch form
    Private Sub lbl_Click(sender As Object, e As EventArgs) Handles lblSubject.Click, lblAutopsyFaceSheet.Click, lblAutopsyDissectionMap.Click, lblShortInitialSummary.Click,
            lblCERADHeader.Click, lblCERADB.Click, lblCERADC.Click, lblCERADD.Click, lblCERADE.Click, lblCERADF.Click, lblCERADG1.Click, lblCERADG2.Click, lblCERADH.Click,
            lblCERADIJ.Click, pnlCERADAddendum.Click, lblPlaqueCounts.Click, lblTangleCounts.Click, lblNPSummary.Click, lblConsensusDx.Click, lblPMCR.Click
        If sender Is lblSubject Then
            DoubleClickHandler(WarehouseShell.formType.WA_Demographics)
        ElseIf sender Is lblAutopsyFaceSheet Then
            DoubleClickHandler(WarehouseShell.formType.WA_AutopsyFaceSheet)
        ElseIf sender Is lblAutopsyDissectionMap Then
            DoubleClickHandler(WarehouseShell.formType.WA_AutopsyDissectionMap)
        ElseIf sender Is lblShortInitialSummary Then
            DoubleClickHandler(WarehouseShell.formType.WA_ShortInitialSummary)
        ElseIf sender Is lblCERADHeader Then
            DoubleClickHandler(WarehouseShell.formType.WA_CERAD_Header)
        ElseIf sender Is lblCERADB Then
            DoubleClickHandler(WarehouseShell.formType.WA_CERADB)
        ElseIf sender Is lblCERADC Then
            DoubleClickHandler(WarehouseShell.formType.WA_CERADC)
        ElseIf sender Is lblCERADD Then
            DoubleClickHandler(WarehouseShell.formType.WA_CERADD)
        ElseIf sender Is lblCERADE Then
            DoubleClickHandler(WarehouseShell.formType.WA_CERADE)
        ElseIf sender Is lblCERADF Then
            DoubleClickHandler(WarehouseShell.formType.WA_CERADF)
        ElseIf sender Is lblCERADG1 Then
            DoubleClickHandler(WarehouseShell.formType.WA_CERADG1)
        ElseIf sender Is lblCERADG2 Then
            DoubleClickHandler(WarehouseShell.formType.WA_CERADG2)
        ElseIf sender Is lblCERADH Then
            DoubleClickHandler(WarehouseShell.formType.WA_CERADH)
        ElseIf sender Is lblCERADIJ Then
            DoubleClickHandler(WarehouseShell.formType.WA_CERADIJ)
        ElseIf sender Is lblCERADAddendum Then
            DoubleClickHandler(WarehouseShell.formType.WA_CERAD_Addendum)
        ElseIf sender Is lblPlaqueCounts Then
            DoubleClickHandler(WarehouseShell.formType.WA_PlaqueCounts)
        ElseIf sender Is lblTangleCounts Then
            DoubleClickHandler(WarehouseShell.formType.WA_TangleCounts)
        ElseIf sender Is lblNPSummary Then
            DoubleClickHandler(WarehouseShell.formType.WA_NPSummary)
        ElseIf sender Is lblConsensusDx Then
            DoubleClickHandler(WarehouseShell.formType.WA_ConsenusDx)
        ElseIf sender Is lblPMCR Then
            WarehouseShell.LoadWorkingAreaForm(WarehouseShell.formType.WA_PMCR)
        End If
    End Sub

    'Mouse enter/leave hand/arrow indicators
    Private Sub lbl_MouseEnter(sender As Object, e As EventArgs) Handles lblSubject.MouseEnter, lblAutopsyFaceSheet.MouseEnter, lblAutopsyDissectionMap.MouseEnter, lblShortInitialSummary.MouseEnter,
            lblCERADHeader.MouseEnter, lblCERADB.MouseEnter, lblCERADC.MouseEnter, lblCERADD.MouseEnter, lblCERADE.MouseEnter, lblCERADF.MouseEnter, lblCERADG1.MouseEnter, lblCERADG2.MouseEnter, lblCERADH.MouseEnter,
            lblCERADIJ.MouseEnter, pnlCERADAddendum.MouseEnter, lblPlaqueCounts.MouseEnter, lblTangleCounts.MouseEnter, lblNPSummary.MouseEnter, lblConsensusDx.MouseEnter, lblPMCR.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub
    Private Sub lbl_MouseLeave(sender As Object, e As EventArgs) Handles lblSubject.MouseLeave, lblAutopsyFaceSheet.MouseLeave, lblAutopsyDissectionMap.MouseLeave, lblShortInitialSummary.MouseLeave,
            lblCERADHeader.MouseLeave, lblCERADB.MouseLeave, lblCERADC.MouseLeave, lblCERADD.MouseLeave, lblCERADE.MouseLeave, lblCERADF.MouseLeave, lblCERADG1.MouseLeave, lblCERADG2.MouseLeave, lblCERADH.MouseLeave,
            lblCERADIJ.MouseLeave, pnlCERADAddendum.MouseLeave, lblPlaqueCounts.MouseLeave, lblTangleCounts.MouseLeave, lblNPSummary.MouseLeave, lblConsensusDx.MouseLeave, lblPMCR.MouseLeave
        Me.Cursor = Cursors.Arrow
    End Sub

    'Set DNC value
    Private Sub DoNotContact()
        Dim cmd As New SqlCommand("select DoNotContact from Subject where SubNum = " & WarehouseShell.SubNum, WarehouseShell.conn)
        Dim result As Integer = cmd.ExecuteScalar()
        If result = 1 Then
            DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).SubjectState(True, "DNCT")
        Else
            DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).SubjectState(False, "DNCF")
        End If
    End Sub
    'Private Sub DoNotDissect()
    '    Dim cmd As New SqlCommand("select TBICohort from Subject where SubNum = " & WarehouseShell.SubNum, WarehouseShell.conn)
    '    Dim result As Integer = cmd.ExecuteScalar()
    '    If result = 1 Then
    '        DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).SubjectState(True, "DNDT")
    '    Else
    '        DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).SubjectState(False, "DNDF")
    '    End If
    'End Sub
    Private Sub DoNotDissect()
        Dim cmd As New SqlCommand("select DoNotDissect from Subject where SubNum = " & WarehouseShell.SubNum, WarehouseShell.conn)
        Dim result As Integer = cmd.ExecuteScalar()
        If result = 1 Then
            DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).SubjectState(True, "DNDissT")
        Else
            DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).SubjectState(False, "DNDissF")
        End If
    End Sub
    'Private Sub InfectiousState()
    '    Dim cmd As New SqlCommand("select Infectious from Subject where Subnum= " & WarehouseShell.SubNum, WarehouseShell.conn)
    '    Dim result As Integer = cmd.ExecuteScalar()
    '    If result = 1 Then
    '        DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).SubjectState(True, "IST")
    '    Else
    '        DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).SubjectState(False, "ISF")
    '    End If
    'End Sub
    Private Sub DoNotDistribute()
        Dim cmd As New SqlCommand("select DoNotDistribute from Subject where Subnum= " & WarehouseShell.SubNum, WarehouseShell.conn)
        Dim result As Integer = cmd.ExecuteScalar()
        If result = 1 Then
            DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).SubjectState(True, "DNDistT")
        Else
            DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).SubjectState(False, "DNDistF")
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
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class