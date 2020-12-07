Imports iTextSharp.text.pdf
Imports System.IO
Imports System

Public Class WA_TissueTasker
    Implements IFormMethods

    Private insertString As String = Nothing
    Private updateString As String = Nothing
    Private formTables As New DataSet
    Public ReportID As Integer = 0
    Public ProjectID As String
    'Private Project As String
    'Private SubProject As String
    'Private SampleDescription As String
    'Private NBTRReqNum As String
    'Private NumSamples As String
    'Private NumGenerics As String

    'Public Sub New(ByVal myProject As String, ByVal mySubProject As String, ByVal mySampleDescription As String, ByVal myNBTRReqNum As String, ByVal myNumSamples As String, ByVal myNumGenerics As String)

    ' This call is required by the designer.
    '    InitializeComponent()

    '    ' Add any initialization after the InitializeComponent() call.
    '    Project = myProject
    '    SubProject = mySubProject
    '    SampleDescription = mySampleDescription
    '    NBTRReqNum = myNBTRReqNum
    '    NumSamples = myNumSamples
    '    NumGenerics = myNumGenerics
    'End Sub

    'Take on load actions
    Private Sub WA_TissueTasker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_TissueTasker")
        ProjectID = WarehouseShell.RecordID
        assignComboLookups()
        defaultValues()
        If Database.ExistingRecordCheck("viewTissueTasker", "ProjectID = " & WarehouseShell.RecordID) Then
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            'load the upper task data
            enableInputFields(False)
            formTables.Tables.Add(Database.ReturnTable("viewTissueTasker", , " ProjectID = " & WarehouseShell.RecordID))
            loadExistingData()
            btnTissueTaskerBottom.Text = "Edit this record"
            btnTissueTaskerTop.Text = btnTissueTaskerBottom.Text
            'load the weekly task report data (hiding the ReportID)
            formTables.Tables.Add(Database.ReturnTable("TissueTaskerProgressReports", "ReportID, ReportDate as 'Report Date', SamplesCompleted as '# Samples Completed'", "ProjectID = " & ProjectID))
            Dim report As New BindingSource
            report.DataSource = formTables.Tables("TissueTaskerProgressReports")
            dgvProgressReports.DataSource = report
            dgvProgressReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            loadFileData()
        Else
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
            enableInputFields(True)
            'Use load file data to set the btnTissueTaskerFile text and color appropriately
            loadFileData()
            txtProject.Text = WarehouseShell.StringArray(0)
            txtSubProject.Text = WarehouseShell.StringArray(1)
            txtTissueRequirements.Text = WarehouseShell.StringArray(2)
            intNBTRReqNum.Text = WarehouseShell.StringArray(3)
            txtTotalSamples.Text = WarehouseShell.StringArray(4)
            cmbBlackCaps.SelectedValue = WarehouseShell.StringArray(5)
            WarehouseShell.StringArray = Nothing
            ProjectID = WarehouseShell.RecordID
            txtTaskID.Text = ProjectID
            btnTissueTaskerBottom.Text = "Save record"
            btnTissueTaskerTop.Text = btnTissueTaskerBottom.Text
        End If
    End Sub

    'Sub to assign ComboBox lookup values (saves some typing in the loadBaseForm sub).
    Private Sub assignComboLookups()
        formTables.Tables.Add(Database.ReturnTable("lkp0_10"))
        cmbBlackCaps.assignLookup(formTables, "lkp0_10")
        formTables.Tables.Add(Database.ReturnTable("refUser"))
        comboAssignedTo1.assignLookup(formTables, "refUser", "RaterID", "Name", "LabTech = 1")
        comboAssignedTo2.assignLookup(formTables, "refUser", "RaterID", "Name", "LabTech = 1")
        comboAssignedTo3.assignLookup(formTables, "refUser", "RaterID", "Name", "LabTech = 1")
    End Sub
    Private Sub defaultValues()
        cmbBlackCaps.SelectedValue = 0
        comboAssignedTo1.SelectedValue = -1
        comboAssignedTo2.SelectedValue = -1
        comboAssignedTo3.SelectedValue = -1
        txtRequestDate.Text = Format(Now(), "MM-dd-yyyy").ToString
    End Sub

    'Enable/disable input fields based on WarehouseShell.DataMode
    Private Sub enableInputFields(ByVal value As Boolean)
        If value = True Then
            txtRequestDate.Enabled = True
            txtEstCompDt.Enabled = True
            txtTissueRequirements.makeReadOnly(False)
            txtCompDate.Enabled = True
            comboAssignedTo1.Enabled = True
            comboAssignedTo2.Enabled = True
            comboAssignedTo3.Enabled = True
        Else
            txtRequestDate.Enabled = False
            txtEstCompDt.Enabled = False
            txtTissueRequirements.makeReadOnly(True)
            txtCompDate.Enabled = False
            comboAssignedTo1.Enabled = False
            comboAssignedTo2.Enabled = False
            comboAssignedTo3.Enabled = False
        End If
    End Sub

    'Load existing data when in view mode
    Private Sub loadExistingData()
        txtTaskID.Text = formTables.Tables("viewTissueTasker").Rows(0).Item("ProjectID").ToString
        intNBTRReqNum.setValue(formTables, "viewTissueTasker", "NBTRRequestNum")
        txtProject.Text = formTables.Tables("viewTissueTasker").Rows(0).Item("Project").ToString
        txtSubProject.Text = formTables.Tables("viewTissueTasker").Rows(0).Item("SubProject").ToString
        txtOldProject.Text = formTables.Tables("viewTissueTasker").Rows(0).Item("OldProject").ToString
        txtOldSubProject.Text = formTables.Tables("viewTissueTasker").Rows(0).Item("OldSubProject").ToString
        If IsDate(formTables.Tables("viewTissueTasker").Rows(0).Item("RequestDate")) Then
            txtRequestDate.Text = Format(formTables.Tables("viewTissueTasker").Rows(0).Item("RequestDate"), "MM-dd-yyyy").ToString 'Format date style before converting to string
        End If
        txtEstCompDt.setValue(formTables, "viewTissueTasker", "EstCompDt")
        'If IsDate(formTables.Tables("viewTissueTasker").Rows(0).Item("EstComp")) Then
        '    txtEstCompDt.Text = Format(formTables.Tables("viewTissueTasker").Rows(0).Item("FulfillBy"), "MM-dd-yyyy").ToString
        'End If
        txtTotalSamples.Text = formTables.Tables("viewTissueTasker").Rows(0).Item("NumSamples").ToString
        cmbBlackCaps.setValue(formTables, "viewTissueTasker", "NumGenerics")
        txtTissueRequirements.Text = formTables.Tables("viewTissueTasker").Rows(0).Item("TissueRequirements").ToString
        txtSamplesCompleted.Text = formTables.Tables("viewTissueTasker").Rows(0).Item("TotalComplete").ToString
        If IsDate(formTables.Tables("viewTissueTasker").Rows(0).Item("CompDate")) Then
            txtCompDate.Text = Format(formTables.Tables("viewTissueTasker").Rows(0).Item("CompDate"), "MM-dd-yyyy").ToString
        End If
        comboAssignedTo1.SelectedValue = formTables.Tables("viewTissueTasker").Rows(0).Item("AssignedTo1Value")
        comboAssignedTo2.SelectedValue = formTables.Tables("viewTissueTasker").Rows(0).Item("AssignedTo2Value")
        comboAssignedTo3.SelectedValue = formTables.Tables("viewTissueTasker").Rows(0).Item("AssignedTo3Value")
    End Sub

    'Sub to load File data (ran on load, regardless of mode)
    Private Sub loadFileData()
        If SystemFiles1to1.CheckFile("fileTissueTaskerSupportDoc", ProjectID) Then
            btnTissueTaskerFile.Text = "View Supporting Document"
            btnTissueTaskerFile.BackColor = Color.Chartreuse
            btnRemove.Enabled = True
        Else
            btnTissueTaskerFile.Text = "Add Supporting Document"
            btnTissueTaskerFile.BackColor = Color.Linen
            btnRemove.Enabled = False
        End If
    End Sub

    'Define button click events
    Private Sub btnTissueTaskerBottom_Click(sender As Object, e As EventArgs) Handles btnTissueTaskerBottom.Click, btnTissueTaskerTop.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_TissueTasker", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                enableInputFields(True)
                btnTissueTaskerBottom.Text = "Save changes"
                btnTissueTaskerTop.Text = btnTissueTaskerBottom.Text
            End If
        ElseIf preSaveValidation() Then
            Dim sqlCMD As New SqlCommand
            sqlCMD.Connection = WarehouseShell.conn
            Dim cmdString As String = "@ProjectID = " & ProjectID &
                            ", @Project = " & txtProject.getSQLValue() &
                            ", @SubProject = " & txtSubProject.getSQLValue() &
                            ", @RequestDate = " & txtRequestDate.getSQLValue() &
                            ", @EstCompDt = " & txtEstCompDt.getSQLValue() &
                            ", @TissueRequirements = " & txtTissueRequirements.getSQLValue() &
                            ", @CompDate = " & txtCompDate.getSQLValue() &
                            ", @AssignedTo1 = " & comboAssignedTo1.getSQLValue() &
                            ", @AssignedTo2 = " & comboAssignedTo2.getSQLValue() &
                            ", @AssignedTo3 = " & comboAssignedTo3.getSQLValue() &
                            ";"
            If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                If preSaveValidation() Then
                    Try
                        sqlCMD.CommandText = "EXEC modTissueTaskerRecord @Action = 1, " & cmdString
                        sqlCMD.ExecuteNonQuery()
                        MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        enableInputFields(False)
                        btnTissueTaskerBottom.Text = "Edit this record"
                        btnTissueTaskerTop.Text = btnTissueTaskerBottom.Text
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                End If
            Else
                If preSaveValidation() Then
                    Try
                        sqlCMD.CommandText = "EXEC modTissueTaskerRecord @Action = 2, " & cmdString
                        sqlCMD.ExecuteNonQuery()
                        MessageBox.Show("Changes saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        enableInputFields(False)
                        btnTissueTaskerBottom.Text = "Edit this record"
                        btnTissueTaskerTop.Text = btnTissueTaskerBottom.Text
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                End If
            End If
        End If
    End Sub
    Private Sub btnTissueTaskerFile_Click(sender As Object, e As EventArgs) Handles btnTissueTaskerFile.Click
        If btnTissueTaskerFile.BackColor = Color.Chartreuse Then
            SystemFiles1to1.OpenFile("fileTissueTaskerSupportDoc", ProjectID, "Tissue Tasker " & ProjectID & " Support Doc")
        Else
            SystemFiles1to1.SaveFile("fileTissueTaskerSupportDoc", ProjectID)
        End If
        loadFileData()
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If User.PermissionCheck("WA_TissueTasker", "Modify") Then
            SystemFiles1to1.DeleteFile("fileTissueTaskerSupportDoc", ProjectID)
            loadFileData()
        End If
    End Sub
    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        ReportID = 0
        PU_TaskerProgressReport.ShowDialog()
        PU_TaskerProgressReport.Dispose()
    End Sub
    Private Sub dgvProgressReports_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProgressReports.CellDoubleClick
        ReportID = dgvProgressReports.SelectedRows(0).Cells("ReportID").Value
        PU_TaskerProgressReport.ShowDialog()
        PU_TaskerProgressReport.Dispose()
    End Sub
    Private Sub btnExportPDF_Click(sender As Object, e As EventArgs) Handles btnExportPDF.Click
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
            Dim ttp As New ToolTip
            ttp.Show("Please save record before exporting.", btnExportPDF, 0, 20, 3000)
        Else
            Try
                'Define which template to use
                Dim pdfTemplate As String = "Q:\Warehouse Files\PDF Export Templates\Tissue Tasker.pdf"
                'Define the output file name
                Dim outputFileName As String = "Project " & ProjectID & " Tissue Tasker.pdf"
                'combine the output file name with the user's temp file path location so we can create and fill the PDF
                Dim filledPDF As String = Path.GetTempPath() & outputFileName

                'Use the PDF API to start the the new file
                Dim pdfReader As PdfReader = New PdfReader(pdfTemplate)
                Dim pdfStamper As New PdfStamper(pdfReader, New FileStream(filledPDF, FileMode.Create))
                Dim pdfFormFields As AcroFields = pdfStamper.AcroFields

                'Fill the fields with values
                pdfFormFields.SetField("TaskID", txtTaskID.Text)
                pdfFormFields.SetField("Project", txtProject.Text)
                pdfFormFields.SetField("SubProject", txtSubProject.Text)
                If txtRequestDate.Text <> "  /  /" Then
                    pdfFormFields.SetField("Request Date", txtRequestDate.Text)
                End If
                If txtEstCompDt.Text <> "  /  /" Then
                    pdfFormFields.SetField("Fulfill By", txtEstCompDt.Text)
                End If
                pdfFormFields.SetField("Tot Samples Req", txtTotalSamples.Text)
                pdfFormFields.SetField("Tissue Requirements", txtTissueRequirements.Text)
                pdfFormFields.SetField("Samples Comp", txtSamplesCompleted.Text)
                If txtCompDate.Text <> "  /  /" Then
                    pdfFormFields.SetField("Date Completed", txtCompDate.Text)
                End If

                'Flatten the form to dissuade manual editing of outputs
                pdfStamper.FormFlattening = True

                'Close the stamper (to finalize the Filled PDF)
                pdfStamper.Close()
                pdfReader.Dispose()

                'Launch the filled PDF for the user
                Dim P As New System.Diagnostics.Process
                Dim s As New System.Diagnostics.ProcessStartInfo(filledPDF)
                s.UseShellExecute = True
                s.WindowStyle = ProcessWindowStyle.Normal
                P.StartInfo = s
                P.Start()
            Catch ex As Exception
                ExceptionHandler.CatchWindowsException(ex)
            End Try
        End If
    End Sub

    Private Function preSaveValidation() As Boolean
        Dim result As Boolean = True
        If txtCompDate.Text <> "  /  /" Then
            Dim chkCMD As New SqlCommand("Select count(*) as QTY from Specimen where ProjectID = " & ProjectID & ";", WarehouseShell.conn)
            Dim myCount As Integer = chkCMD.ExecuteScalar()
            If myCount <> CType(txtSamplesCompleted.Text, Integer) Then
                If Not User.CheckPermission("LabTechLead") Then
                    MsgBox("The number of samples in the database for this task does not match the number completed on this form. The Lab tech Lead must complete this tasker.", , "Error!")
                    result = False
                End If
            End If
        End If
        Return result
    End Function

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
        TopLevel = val
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
        btnTissueTaskerBottom.PerformClick()
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class