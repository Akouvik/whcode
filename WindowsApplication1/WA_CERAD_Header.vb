Imports iTextSharp.text.pdf

Public Class WA_CERAD_Header
    Implements IFormMethods
    Private formTables As New DataSet
    Private toolTip1 As New ToolTip
    Private errProvider As New ErrorProvider

    Private Sub WA_CERAD_Header_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_CERAD_Header")
        loadBaseForm()
        If Database.ExistingRecordCheck("CERAD_Header", "SubNum = " & WarehouseShell.SubNum) Then
            loadExistingData()
            btnNPReport.Enabled = True
            loadFileData()
            btnCERADHeader.Text = "Edit this record"
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            lblNoRecord.Visible = False
            comboNeuropathologist.Focus()
        Else
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            btnCERADHeader.Text = "Add New Record"
            loadFileData()
            lblNoRecord.Visible = True
        End If
        enableInputFields(False)
        If WarehouseShell.userName = "harouv01" Or WarehouseShell.userName = "arnesj01" Then
            chkHarryReviewed.Visible = True
        End If
    End Sub
    Private Sub loadBaseForm()
        formTables.Tables.Add(Database.ReturnTable("refUser"))
        formTables.Tables.Add(Database.ReturnTable("lkpNPType"))
        comboNeuropathologist.DataSource = New DataView(formTables.Tables("refUser"), "Neuropathologist = 1", "Name", DataViewRowState.CurrentRows)
        comboNeuropathologist.DisplayMember = "Name"
        comboNeuropathologist.ValueMember = "RaterID"
        cmbNPType.assignLookup(formTables, "lkpNPType")
        cmbNPType.SelectedValue = -1
    End Sub
    Private Sub loadExistingData()
        'Grab the CERADB record for this SubNum
        formTables.Tables.Add(Database.ReturnTable("CERAD_Header", , "SubNum = " & WarehouseShell.SubNum))
        'Apply the existing values to the input fields
        chkHarryReviewed.setValue(formTables, "CERAD_Header", "HarryReviewed")
        cmbNPType.setValue(formTables, "CERAD_Header", "NeuropathType")
        comboNeuropathologist.setValue(formTables, "CERAD_Header", "Neuropathologist")
        txtCERADDate.setValue(formTables, "CERAD_Header", "NeuropathDate")
        txtXENum.setValue(formTables, "CERAD_Header", "XENum")
    End Sub
    Private Sub loadFileData()
        If SubjectFiles1to1.CheckFile("fileNeuropathFull_Provisional", WarehouseShell.SubNum) Then
            btnNPReportProvisional.Text = "View Provisional NP Report"
            btnNPReportProvisional.BackColor = Color.Chartreuse
            btnNPReportProvisionalRemove.Visible = True
        Else
            btnNPReportProvisional.Text = "Add Provisional NP Report"
            btnNPReportProvisional.BackColor = Color.Linen
            btnNPReportProvisionalRemove.Visible = False
        End If
        If SubjectFiles1to1.CheckFile("fileNeuropathFull", WarehouseShell.SubNum) Then
            btnNPReport.Text = "View NP Report"
            btnNPReport.BackColor = Color.Chartreuse
            btnNPReportRemove.Visible = True
        Else
            btnNPReport.Text = "Add NP Report"
            btnNPReport.BackColor = Color.Linen
            btnNPReportRemove.Visible = False
        End If
    End Sub
    Private Sub enableInputFields(ByVal bool As Boolean)
        chkHarryReviewed.Enabled = bool
        cmbNPType.Enabled = bool
        comboNeuropathologist.Enabled = bool
        txtCERADDate.Enabled = bool
        txtXENum.Enabled = bool
        If bool = True Then
            btnNPReportProvisional.Enabled = bool
            btnNPReport.Enabled = bool
        Else
            If SubjectFiles1to1.CheckFile("fileNeuropathFull_Provisional", WarehouseShell.SubNum) Then
                btnNPReportProvisional.Enabled = True
                If SubjectFiles1to1.CheckFile("fileNeuropathFull_Provisional", WarehouseShell.SubNum) Then
                    btnNPReportProvisionalRemove.Enabled = True
                Else
                    btnNPReportProvisionalRemove.Enabled = False
                End If
            Else
                btnNPReportProvisional.Enabled = bool
                btnNPReportProvisionalRemove.Enabled = bool
            End If
            If SubjectFiles1to1.CheckFile("fileNeuropathFull", WarehouseShell.SubNum) Then
                btnNPReport.Enabled = True
                If SubjectFiles1to1.CheckFile("fileNeuropathFull", WarehouseShell.SubNum) Then
                    btnNPReportRemove.Enabled = True
                Else
                    btnNPReportRemove.Enabled = False
                End If
            Else
                btnNPReport.Enabled = bool
                btnNPReportRemove.Enabled = bool
            End If

        End If
    End Sub

    Private Sub btnCERADHeader_Click(sender As Object, e As EventArgs) Handles btnCERADHeader.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_CERAD_Header", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                enableInputFields(True)
                btnCERADHeader.Text = "Save changes"
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If User.PermissionCheck("WA_CERAD_Header", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
                comboNeuropathologist.SelectedValue = 4
                enableInputFields(True)
                btnCERADHeader.Text = "Save new record"
                lblNoRecord.Visible = False
            End If
        Else
            If preSaveValidation() Then
                Dim sqlCommand As New SqlCommand
                sqlCommand.Connection = WarehouseShell.conn
                Dim cmdString = "@SubNum = " & WarehouseShell.SubNum &
                    ", @HarryReviewed = " & chkHarryReviewed.getSQLValue() &
                    ", @NeuropathType = " & cmbNPType.getSQLValue() &
                    ", @Neuropathologist = " & comboNeuropathologist.getSQLValue() &
                    ", @NeuropathDate = " & txtCERADDate.getSQLValue() &
                    ", @XENum = " & txtXENum.getSQLValue() &
                    ";"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    sqlCommand.CommandText = "EXEC dbo.modCERAD_HeaderRecord @Action = 1, " & cmdString
                    Try
                        sqlCommand.ExecuteNonQuery()
                        MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        enableInputFields(False)
                        btnCERADHeader.Text = "Edit this record"
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else
                    sqlCommand.CommandText = "EXEC dbo.modCERAD_HeaderRecord @Action = 2, " & cmdString
                    Try
                        sqlCommand.ExecuteNonQuery()
                        MessageBox.Show("Record successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        enableInputFields(False)
                        btnCERADHeader.Text = "Edit this record"
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

        'Make sure there is an XENum
        If txtXENum.Text = "" Then
            errorMessage += "- Please enter an XE #." & vbNewLine
            result = False
        End If
        If Not txtXENum.Text Like "XE##-###" Then
            errorMessage += "- This is not a valid XE # format (XE##-###)." & vbNewLine
            result = False
        End If

        'If trying to complete ANY type CERAD, make sure there's an uploaded neuropath report and CERAD-IJ is completed
        If txtCERADDate.Text <> "  /  /" Then
            If Database.ExistingRecordCheck("fileNeuropathFull", "SubNum = " & WarehouseShell.SubNum) = False Then
                errorMessage += "- Full and Screen CERAD cannot be completed unless a Neuropath Report has been uploaded." & vbNewLine
                result = False
            End If
        End If
        If txtCERADDate.Text <> "  /  /" Then
            If Database.ExistingRecordCheck("CERADIJ", "SubNum = " & WarehouseShell.SubNum) = False Or Database.ExistingRecordCheck("ARTAG", "SubNum = " & WarehouseShell.SubNum) = False Then
                errorMessage += "- Full and Screen CERAD cannot be completed unless CERAD-IJ has been completed." & vbNewLine
                result = False
            End If
        End If

        'Check for valid Date Completed
        Dim dt As DateTime
        If DateTime.TryParse(txtCERADDate.Text, dt) Then
            If dt > Now Then
                errorMessage += "- Date completed cannot be in the future." & vbNewLine
                result = False
                'ElseIf dt < DateOfDeath-> return error

            End If
        Else
            If txtCERADDate.Text <> "  /  /" Then
                errorMessage += "- Date completed must be a valid date." & vbNewLine
                result = False
            End If
        End If


        'Handle false result
        If result = False Then
            errorMessage = "The following errors must be corrected before this record can be saved:" & vbNewLine & vbNewLine & errorMessage
            MsgBox(errorMessage, MsgBoxStyle.OkOnly, "Error")
        End If
        Return result
    End Function

    Private Sub txtCERADDate_Validating(sender As Object, e As EventArgs) Handles txtCERADDate.Validating
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.Undefined And WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
            If txtCERADDate.Text = "  /  /" Then
                errProvider.SetError(txtCERADDate, "Must provide a valid date.")

            Else
                Dim DoB As Date = Database.ReturnDate("Subject", "DoB", "SubNum = " & WarehouseShell.SubNum)
                Dim EnteredDate As Date = CDate(txtCERADDate.Text)
                If EnteredDate < DoB Then
                    errProvider.SetError(txtCERADDate, "Date cannot be before subject's date of death.")
                Else
                    errProvider.Clear()
                End If
            End If
        End If
    End Sub

    Private Sub btnNPReportProvisional_Click(sender As Object, e As EventArgs) Handles btnNPReportProvisional.Click
        If SubjectFiles1to1.CheckFile("fileNeuropathFull_Provisional", WarehouseShell.SubNum) Then
            SubjectFiles1to1.OpenFile("fileNeuropathFull_Provisional", WarehouseShell.SubNum, "SubNum " & WarehouseShell.SubNum & " Full Neuropath Report (Provisional)")
        Else
            If User.PermissionCheck("WA_CERAD_Header", "Modify") Then
                SubjectFiles1to1.SaveFile("fileNeuropathFull_Provisional", WarehouseShell.SubNum)
                'Make sure user actually uploaded a file, and run subs if he/she did
                If SubjectFiles1to1.CheckFile("fileNeuropathFull", WarehouseShell.SubNum) Then
                    updateNPReportCounter()
                    loadFileData()
                End If
            End If
        End If
    End Sub
    Private Sub btnNPReportProvisionalRemove_Click(sender As Object, e As EventArgs) Handles btnNPReportProvisionalRemove.Click
        If User.PermissionCheck("WA_CERAD_Header", "Modify") Then
            SubjectFiles1to1.DeleteFile("fileNeuropathFull_Provisional", WarehouseShell.SubNum)
            loadFileData()
        End If
    End Sub
    Private Sub btnNPReport_Click(sender As Object, e As EventArgs) Handles btnNPReport.Click
        If SubjectFiles1to1.CheckFile("fileNeuropathFull", WarehouseShell.SubNum) Then
            SubjectFiles1to1.OpenFile("fileNeuropathFull", WarehouseShell.SubNum, "SubNum " & WarehouseShell.SubNum & " Full Neuropath Report")
        Else
            If User.PermissionCheck("WA_CERAD_Header", "Modify") Then
                SubjectFiles1to1.SaveFile("fileNeuropathFull", WarehouseShell.SubNum)
                'Make sure user actually uploaded a file, and run subs if he/she did
                If SubjectFiles1to1.CheckFile("fileNeuropathFull", WarehouseShell.SubNum) Then
                    updateNPReportCounter()
                    loadFileData()
                End If
            End If
        End If
    End Sub
    Private Sub btnNPReportRemove_Click(sender As Object, e As EventArgs) Handles btnNPReportRemove.Click
        If User.PermissionCheck("WA_CERAD_Header", "Modify") Then
            SubjectFiles1to1.DeleteFile("fileNeuropathFull", WarehouseShell.SubNum)
            loadFileData()
        End If
    End Sub
    Private Sub updateNPReportProvisionalCounter()
        Try
            Dim cmd As New SqlCommand("Update Subject set NPReportProvisionalCounter += 1 where SubNum = " & WarehouseShell.SubNum & ";", WarehouseShell.conn)
            cmd.ExecuteNonQuery()
        Catch ex As SqlException
            ExceptionHandler.CatchSQLException(ex)
        End Try
    End Sub
    Private Sub updateNPReportCounter()
        Try
            Dim cmd As New SqlCommand("Update Subject set NPReportCounter += 1 where SubNum = " & WarehouseShell.SubNum & ";", WarehouseShell.conn)
            cmd.ExecuteNonQuery()
        Catch ex As SqlException
            ExceptionHandler.CatchSQLException(ex)
        End Try
    End Sub

    Private Sub btnExportPDF_Click(sender As Object, e As EventArgs) Handles btnExportPDF.Click
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
            MsgBox("This record must be saved before PDF Export can be created.", MsgBoxStyle.OkOnly, "Warning")
        Else
            Try
                'Make sure none of the viewPDFExport tables are already in formTables
                clearPDFTables()
                'Define which template to use
                Dim pdfTemplate As String = "Q:\Warehouse Files\PDF Export Templates\CERAD.pdf"
                'Define the output file name
                Dim outputFileName As String = "Subnum " & WarehouseShell.SubNum & " CERAD.pdf"
                'combine the output file name with the user's temp file path location so we can create and fill the PDF
                Dim filledPDF As String = IO.Path.GetTempPath() & outputFileName

                'Use the PDF API to start the the new file
                Dim pdfReader As PdfReader = New PdfReader(pdfTemplate)
                Dim pdfStamper As New PdfStamper(pdfReader, New FileStream(filledPDF, FileMode.Create))
                Dim pdfFormFields As AcroFields = pdfStamper.AcroFields

                'Fill the fields with values

                'CERADA (and page headers)
                formTables.Tables.Add(Database.ReturnTable("viewCERADA_PDFExport", , "SubNum = " & WarehouseShell.SubNum))
                pdfFormFields.SetField("Name_1", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("Name_1").ToString)
                pdfFormFields.SetField("DoD_1", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("DoD_1").ToString)
                pdfFormFields.SetField("BB_1", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("BB_1").ToString)
                pdfFormFields.SetField("SubNum_1", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("SubNum").ToString)
                pdfFormFields.SetField("XENum_1", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("XENum_1").ToString)
                pdfFormFields.SetField("Name_2", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("Name_1").ToString)
                pdfFormFields.SetField("DoD_2", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("DoD_1").ToString)
                pdfFormFields.SetField("BB_2", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("BB_1").ToString)
                pdfFormFields.SetField("SubNum_2", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("SubNum").ToString)
                pdfFormFields.SetField("XENum_2", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("XENum_1").ToString)
                pdfFormFields.SetField("Name_3", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("Name_1").ToString)
                pdfFormFields.SetField("DoD_3", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("DoD_1").ToString)
                pdfFormFields.SetField("BB_3", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("BB_1").ToString)
                pdfFormFields.SetField("SubNum_3", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("SubNum").ToString)
                pdfFormFields.SetField("XENum_3", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("XENum_1").ToString)
                pdfFormFields.SetField("Name_4", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("Name_1").ToString)
                pdfFormFields.SetField("DoD_4", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("DoD_1").ToString)
                pdfFormFields.SetField("BB_4", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("BB_1").ToString)
                pdfFormFields.SetField("SubNum_4", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("SubNum").ToString)
                pdfFormFields.SetField("XENum_4", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("XENum_1").ToString)
                pdfFormFields.SetField("Name_5", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("Name_1").ToString)
                pdfFormFields.SetField("DoD_5", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("DoD_1").ToString)
                pdfFormFields.SetField("BB_5", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("BB_1").ToString)
                pdfFormFields.SetField("SubNum_5", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("SubNum").ToString)
                pdfFormFields.SetField("XENum_5", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("XENum_1").ToString)
                pdfFormFields.SetField("Name_6", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("Name_1").ToString)
                pdfFormFields.SetField("DoD_6", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("DoD_1").ToString)
                pdfFormFields.SetField("BB_6", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("BB_1").ToString)
                pdfFormFields.SetField("SubNum_6", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("SubNum").ToString)
                pdfFormFields.SetField("XENum_6", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("XENum_1").ToString)
                pdfFormFields.SetField("Name_7", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("Name_1").ToString)
                pdfFormFields.SetField("DoD_7", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("DoD_1").ToString)
                pdfFormFields.SetField("BB_7", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("BB_1").ToString)
                pdfFormFields.SetField("SubNum_7", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("SubNum").ToString)
                pdfFormFields.SetField("XENum_7", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("XENum_1").ToString)
                pdfFormFields.SetField("Name_8", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("Name_1").ToString)
                pdfFormFields.SetField("DoD_8", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("DoD_1").ToString)
                pdfFormFields.SetField("BB_8", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("BB_1").ToString)
                pdfFormFields.SetField("SubNum_8", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("SubNum").ToString)
                pdfFormFields.SetField("XENum_8", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("XENum_1").ToString)
                pdfFormFields.SetField("Name_9", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("Name_1").ToString)
                pdfFormFields.SetField("DoD_9", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("DoD_1").ToString)
                pdfFormFields.SetField("BB_9", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("BB_1").ToString)
                pdfFormFields.SetField("SubNum_9", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("SubNum").ToString)
                pdfFormFields.SetField("XENum_9", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("XENum_1").ToString)
                pdfFormFields.SetField("Date", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("Date").ToString)
                pdfFormFields.SetField("Name", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("Name_1").ToString)
                pdfFormFields.SetField("CERADNum", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("CERADNum").ToString)
                pdfFormFields.SetField("AutopsyLocation", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("AutopsyLocation").ToString)
                pdfFormFields.SetField("NeuropathLocation", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("NeuropathLocation").ToString)
                pdfFormFields.SetField("XENum", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("XENum_1").ToString)
                pdfFormFields.SetField("NeuropathName", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("NeuropathName").ToString)
                pdfFormFields.SetField("BB", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("BB_1").ToString)
                pdfFormFields.SetField("Sex", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("Sex").ToString)
                pdfFormFields.SetField("Age", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("Age").ToString)
                pdfFormFields.SetField("DoB", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("DoB").ToString)
                pdfFormFields.SetField("DateTimeDeath", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("DateTimeDeath").ToString)
                pdfFormFields.SetField("PlaceOfDeath", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("PlaceOfDeath").ToString)
                pdfFormFields.SetField("DateOfAutopsy", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("DateOfAutopsy").ToString)
                pdfFormFields.SetField("PMI", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("PMI").ToString)
                pdfFormFields.SetField("Race", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("Race").ToString)
                pdfFormFields.SetField("ClinicalCategory", formTables.Tables("viewCERADA_PDFExport").Rows(0).Item("ClinicalCategory").ToString)

                'CERADB
                If Database.ExistingRecordCheck("viewCERADB_PDFExport", "SubNum = " & WarehouseShell.SubNum) Then
                    formTables.Tables.Add(Database.ReturnTable("viewCERADB_PDFExport", , "SubNum = " & WarehouseShell.SubNum))
                    pdfFormFields.SetField("chkB1AlzNo", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1AlzNo").ToString)
                    pdfFormFields.SetField("chkB1AlzYes", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1AlzYes").ToString)
                    pdfFormFields.SetField("chkB1AlzUnk", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1AlzUnk").ToString)
                    pdfFormFields.SetField("chkB1OthDemNo", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1OthDemNo").ToString)
                    pdfFormFields.SetField("chkB1OthDemYes", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1OthDemYes").ToString)
                    pdfFormFields.SetField("chkB1OthDemUnk", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1OthDemUnk").ToString)
                    pdfFormFields.SetField("txtB1OthDemSpec", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("txtB1OthDemSpec").ToString)
                    pdfFormFields.SetField("chkB1ParkNo", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1ParkNo").ToString)
                    pdfFormFields.SetField("chkB1ParkYes", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1ParkYes").ToString)
                    pdfFormFields.SetField("chkB1ParkUnk", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1ParkUnk").ToString)
                    pdfFormFields.SetField("chkB1HDNo", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1HDNo").ToString)
                    pdfFormFields.SetField("chkB1HDYes", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1HDYes").ToString)
                    pdfFormFields.SetField("chkB1HDUnk", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1HDUnk").ToString)
                    pdfFormFields.SetField("txtB1HDSpec", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("txtB1HDSpec").ToString)
                    pdfFormFields.SetField("chkB1HypertensionNo", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1HypertensionNo").ToString)
                    pdfFormFields.SetField("chkB1HypertensionYes", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1HypertensionYes").ToString)
                    pdfFormFields.SetField("chkB1HypertensionUnk", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1HypertensionUnk").ToString)
                    pdfFormFields.SetField("chkB1StrokeNo", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1StrokeNo").ToString)
                    pdfFormFields.SetField("chkB1StrokeYes", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1StrokeYes").ToString)
                    pdfFormFields.SetField("chkB1StrokeUnk", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1StrokeUnk").ToString)
                    pdfFormFields.SetField("chkB1SeizNo", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1SeizNo").ToString)
                    pdfFormFields.SetField("chkB1SeizYes", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1SeizYes").ToString)
                    pdfFormFields.SetField("chkB1SeizUnk", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1SeizUnk").ToString)
                    pdfFormFields.SetField("chkB1ThyroidNo", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1ThyroidNo").ToString)
                    pdfFormFields.SetField("chkB1ThyroidYes", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1ThyroidYes").ToString)
                    pdfFormFields.SetField("chkB1ThyroidUnk", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1ThyroidUnk").ToString)
                    pdfFormFields.SetField("chkB1DiabetesNo", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1DiabetesNo").ToString)
                    pdfFormFields.SetField("chkB1DiabetesYes", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1DiabetesYes").ToString)
                    pdfFormFields.SetField("chkB1DiabetesUnk", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1DiabetesUnk").ToString)
                    pdfFormFields.SetField("chkB1AlcNo", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1AlcNo").ToString)
                    pdfFormFields.SetField("chkB1AlcYes", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1AlcYes").ToString)
                    pdfFormFields.SetField("chkB1AlcUnk", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1AlcUnk").ToString)
                    pdfFormFields.SetField("chkB1DrugNo", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1DrugNo").ToString)
                    pdfFormFields.SetField("chkB1DrugYes", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1DrugYes").ToString)
                    pdfFormFields.SetField("chkB1DrugUnk", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1DrugUnk").ToString)
                    pdfFormFields.SetField("chkB1HeadNo", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1HeadNo").ToString)
                    pdfFormFields.SetField("chkB1HeadYes", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1HeadYes").ToString)
                    pdfFormFields.SetField("chkB1HeadUnk", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1HeadUnk").ToString)
                    pdfFormFields.SetField("chkB1B12No", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1B12No").ToString)
                    pdfFormFields.SetField("chkB1B12Yes", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1B12Yes").ToString)
                    pdfFormFields.SetField("chkB1B12Unk", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1B12Unk").ToString)
                    pdfFormFields.SetField("chkB1AffectNo", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1AffectNo").ToString)
                    pdfFormFields.SetField("chkB1AffectYes", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1AffectYes").ToString)
                    pdfFormFields.SetField("chkB1AffectUnk", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1AffectUnk").ToString)
                    pdfFormFields.SetField("chkB1OthPsychNo", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1OthPsychNo").ToString)
                    pdfFormFields.SetField("chkB1OthPsychYes", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1OthPsychYes").ToString)
                    pdfFormFields.SetField("chkB1OthPsychUnk", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1OthPsychUnk").ToString)
                    pdfFormFields.SetField("txtB1OthPsychSpec", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("txtB1OthPsychSpec").ToString)
                    pdfFormFields.SetField("chkB1OthNeuroNo", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1OthNeuroNo").ToString)
                    pdfFormFields.SetField("chkB1OthNeuroYes", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1OthNeuroYes").ToString)
                    pdfFormFields.SetField("chkB1OthNeuroUnk", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("chkB1OthNeuroUnk").ToString)
                    pdfFormFields.SetField("txtB1OthNeuroSpec", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("txtB1OthNeuroSpec").ToString)
                    pdfFormFields.SetField("txtB2GenAutDone", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("txtB2GenAutDone").ToString)
                    pdfFormFields.SetField("txtB2a", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("txtB2a").ToString)
                    pdfFormFields.SetField("txtB2aCode", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("txtB2aCode").ToString)
                    pdfFormFields.SetField("txtB2b", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("txtB2b").ToString)
                    pdfFormFields.SetField("txtB2bCode", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("txtB2bCode").ToString)
                    pdfFormFields.SetField("txtB2c", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("txtB2c").ToString)
                    pdfFormFields.SetField("txtB2cCode", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("txtB2cCode").ToString)
                    pdfFormFields.SetField("txtB2d", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("txtB2d").ToString)
                    pdfFormFields.SetField("txtB2dCode", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("txtB2dCode").ToString)
                    pdfFormFields.SetField("txtB2e", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("txtB2e").ToString)
                    pdfFormFields.SetField("txtB2eCode", formTables.Tables("viewCERADB_PDFExport").Rows(0).Item("txtB2eCode").ToString)
                End If

                'CERADC
                If Database.ExistingRecordCheck("viewCERADC_PDFExport", "SubNum = " & WarehouseShell.SubNum) Then
                    formTables.Tables.Add(Database.ReturnTable("viewCERADC_PDFExport", , "SubNum = " & WarehouseShell.SubNum))
                    pdfFormFields.SetField("txtC1Weight", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("txtC1Weight").ToString)
                    pdfFormFields.SetField("chkC1Fresh", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC1Fresh").ToString)
                    pdfFormFields.SetField("chkC1Fixed", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC1Fixed").ToString)
                    pdfFormFields.SetField("txtC1aRight", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("txtC1aRight").ToString)
                    pdfFormFields.SetField("txtC1aLeft", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("txtC1aLeft").ToString)
                    pdfFormFields.SetField("txtC1b", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("txtC1b").ToString)
                    pdfFormFields.SetField("txtC2", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("txtC2").ToString)
                    pdfFormFields.SetField("txtC2SpinAbnorm", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("txtC2SpinAbnorm").ToString)
                    pdfFormFields.SetField("txtC2SpinAbnormSpec", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("txtC2SpinAbnormSpec").ToString)
                    pdfFormFields.SetField("txtC3", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("txtC3").ToString)
                    pdfFormFields.SetField("txtC3Spec", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("txtC3Spec").ToString)
                    pdfFormFields.SetField("txtC4", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("txtC4").ToString)
                    pdfFormFields.SetField("chkC4a0", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC4a0").ToString)
                    pdfFormFields.SetField("chkC4a1", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC4a1").ToString)
                    pdfFormFields.SetField("chkC4a3", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC4a3").ToString)
                    pdfFormFields.SetField("chkC4a5", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC4a5").ToString)
                    pdfFormFields.SetField("chkC4a9", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC4a9").ToString)
                    pdfFormFields.SetField("chkC4bFrontal0", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC4bFrontal0").ToString)
                    pdfFormFields.SetField("chkC4bFrontal1", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC4bFrontal1").ToString)
                    pdfFormFields.SetField("chkC4bFrontal3", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC4bFrontal3").ToString)
                    pdfFormFields.SetField("chkC4bFrontal5", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC4bFrontal5").ToString)
                    pdfFormFields.SetField("chkC4bFrontal9", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC4bFrontal9").ToString)
                    pdfFormFields.SetField("chkC4bParietal0", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC4bParietal0").ToString)
                    pdfFormFields.SetField("chkC4bParietal1", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC4bParietal1").ToString)
                    pdfFormFields.SetField("chkC4bParietal3", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC4bParietal3").ToString)
                    pdfFormFields.SetField("chkC4bParietal5", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC4bParietal5").ToString)
                    pdfFormFields.SetField("chkC4bParietal9", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC4bParietal9").ToString)
                    pdfFormFields.SetField("chkC4bTemporal0", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC4bTemporal0").ToString)
                    pdfFormFields.SetField("chkC4bTemporal1", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC4bTemporal1").ToString)
                    pdfFormFields.SetField("chkC4bTemporal3", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC4bTemporal3").ToString)
                    pdfFormFields.SetField("chkC4bTemporal5", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC4bTemporal5").ToString)
                    pdfFormFields.SetField("chkC4bTemporal9", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC4bTemporal9").ToString)
                    pdfFormFields.SetField("chkC4bOccipital0", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC4bOccipital0").ToString)
                    pdfFormFields.SetField("chkC4bOccipital1", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC4bOccipital1").ToString)
                    pdfFormFields.SetField("chkC4bOccipital3", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC4bOccipital3").ToString)
                    pdfFormFields.SetField("chkC4bOccipital5", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC4bOccipital5").ToString)
                    pdfFormFields.SetField("chkC4bOccipital9", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC4bOccipital9").ToString)
                    pdfFormFields.SetField("chkC4bCerebellar0", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC4bCerebellar0").ToString)
                    pdfFormFields.SetField("chkC4bCerebellar1", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC4bCerebellar1").ToString)
                    pdfFormFields.SetField("chkC4bCerebellar3", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC4bCerebellar3").ToString)
                    pdfFormFields.SetField("chkC4bCerebellar5", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC4bCerebellar5").ToString)
                    pdfFormFields.SetField("chkC4bCerebellar9", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("chkC4bCerebellar9").ToString)
                    pdfFormFields.SetField("txtC4c", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("txtC4c").ToString)
                    pdfFormFields.SetField("txtC4cSpec", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("txtC4cSpec").ToString)
                    pdfFormFields.SetField("txtC4d", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("txtC4d").ToString)
                    pdfFormFields.SetField("txtC4e", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("txtC4e").ToString)
                    pdfFormFields.SetField("txtC5a", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("txtC5a").ToString)
                    pdfFormFields.SetField("txtC5b", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("txtC5b").ToString)
                    pdfFormFields.SetField("txtC6", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("txtC6").ToString)
                    pdfFormFields.SetField("txtC6Spec", formTables.Tables("viewCERADC_PDFExport").Rows(0).Item("txtC6Spec").ToString)
                End If

                'CERADD
                If Database.ExistingRecordCheck("viewCERADD_PDFExport", "SubNum = " & WarehouseShell.SubNum) Then
                    formTables.Tables.Add(Database.ReturnTable("viewCERADD_PDFExport", , "SubNum = " & WarehouseShell.SubNum))
                    pdfFormFields.SetField("txtD1a", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("txtD1a").ToString)
                    pdfFormFields.SetField("txtD1b", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("txtD1b").ToString)
                    pdfFormFields.SetField("txtD1bSpec", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("txtD1bSpec").ToString)
                    pdfFormFields.SetField("txtD1c", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("txtD1c").ToString)
                    pdfFormFields.SetField("txtD1cSpec", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("txtD1cSpec").ToString)
                    pdfFormFields.SetField("txtD2", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("txtD2").ToString)
                    pdfFormFields.SetField("chkD3InfNo", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3InfNo").ToString)
                    pdfFormFields.SetField("chkD3InfYes", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3InfYes").ToString)
                    pdfFormFields.SetField("chkD3InfUnk", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3InfUnk").ToString)
                    pdfFormFields.SetField("chkD3LacNo", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3LacNo").ToString)
                    pdfFormFields.SetField("chkD3LacYes", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3LacYes").ToString)
                    pdfFormFields.SetField("chkD3LacUnk", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3LacUnk").ToString)
                    pdfFormFields.SetField("chkD3HemNo", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3HemNo").ToString)
                    pdfFormFields.SetField("chkD3HemYes", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3HemYes").ToString)
                    pdfFormFields.SetField("chkD3HemUnk", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3HemUnk").ToString)
                    pdfFormFields.SetField("txtD3aNum", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("txtD3aNum").ToString)
                    pdfFormFields.SetField("txtD3aSize1", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("txtD3aSize1").ToString)
                    pdfFormFields.SetField("txtD3aSize2", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("txtD3aSize2").ToString)
                    pdfFormFields.SetField("chkD3aAntNo", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3aAntNo").ToString)
                    pdfFormFields.SetField("chkD3aAntYes", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3aAntYes").ToString)
                    pdfFormFields.SetField("chkD3aAntUnk", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3aAntUnk").ToString)
                    pdfFormFields.SetField("chkD3aMidNo", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3aMidNo").ToString)
                    pdfFormFields.SetField("chkD3aMidYes", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3aMidYes").ToString)
                    pdfFormFields.SetField("chkD3aMidUnk", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3aMidUnk").ToString)
                    pdfFormFields.SetField("chkD3aPosNo", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3aPosNo").ToString)
                    pdfFormFields.SetField("chkD3aPosYes", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3aPosYes").ToString)
                    pdfFormFields.SetField("chkD3aPosUnk", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3aPosUnk").ToString)
                    pdfFormFields.SetField("chkD3aVerNo", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3aVerNo").ToString)
                    pdfFormFields.SetField("chkD3aVerYes", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3aVerYes").ToString)
                    pdfFormFields.SetField("chkD3aVerUnk", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3aVerUnk").ToString)
                    pdfFormFields.SetField("chkD3bBasNone", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3bBasNone").ToString)
                    pdfFormFields.SetField("chkD3bBas14", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3bBas14").ToString)
                    pdfFormFields.SetField("chkD3bBas59", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3bBas59").ToString)
                    pdfFormFields.SetField("chkD3bBas10", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3bBas10").ToString)
                    pdfFormFields.SetField("chkD3bCerNone", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3bCerNone").ToString)
                    pdfFormFields.SetField("chkD3bCer14", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3bCer14").ToString)
                    pdfFormFields.SetField("chkD3bCer59", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3bCer59").ToString)
                    pdfFormFields.SetField("chkD3bCer10", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3bCer10").ToString)
                    pdfFormFields.SetField("chkD3bBSNone", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3bBSNone").ToString)
                    pdfFormFields.SetField("chkD3bBS14", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3bBS14").ToString)
                    pdfFormFields.SetField("chkD3bBS59", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3bBS59").ToString)
                    pdfFormFields.SetField("chkD3bBS10", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3bBS10").ToString)
                    pdfFormFields.SetField("chkD3bOthNone", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3bOthNone").ToString)
                    pdfFormFields.SetField("chkD3bOth14", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3bOth14").ToString)
                    pdfFormFields.SetField("chkD3bOth59", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3bOth59").ToString)
                    pdfFormFields.SetField("chkD3bOth10", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3bOth10").ToString)
                    pdfFormFields.SetField("txtD3bOthSpec", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("txtD3bOthSpec").ToString)
                    pdfFormFields.SetField("chkD3cBasNone", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3cBasNone").ToString)
                    pdfFormFields.SetField("chkD3cBas14", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3cBas14").ToString)
                    pdfFormFields.SetField("chkD3cBas59", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3cBas59").ToString)
                    pdfFormFields.SetField("chkD3cBas10", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3cBas10").ToString)
                    pdfFormFields.SetField("chkD3cCerNone", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3cCerNone").ToString)
                    pdfFormFields.SetField("chkD3cCer14", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3cCer14").ToString)
                    pdfFormFields.SetField("chkD3cCer59", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3cCer59").ToString)
                    pdfFormFields.SetField("chkD3cCer10", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3cCer10").ToString)
                    pdfFormFields.SetField("chkD3cBSNone", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3cBSNone").ToString)
                    pdfFormFields.SetField("chkD3cBS14", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3cBS14").ToString)
                    pdfFormFields.SetField("chkD3cBS59", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3cBS59").ToString)
                    pdfFormFields.SetField("chkD3cBS10", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3cBS10").ToString)
                    pdfFormFields.SetField("chkD3cOthNone", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3cOthNone").ToString)
                    pdfFormFields.SetField("chkD3cOth14", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3cOth14").ToString)
                    pdfFormFields.SetField("chkD3cOth59", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3cOth59").ToString)
                    pdfFormFields.SetField("chkD3cOth10", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("chkD3cOth10").ToString)
                    pdfFormFields.SetField("txtD3cOthSpec", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("txtD3cOthSpec").ToString)
                    pdfFormFields.SetField("txtD3dSml", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("txtD3dSml").ToString)
                    pdfFormFields.SetField("txtD3dMed", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("txtD3dMed").ToString)
                    pdfFormFields.SetField("txtD3dLrg", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("txtD3dLrg").ToString)
                    pdfFormFields.SetField("txtD3dCorSml", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("txtD3dCorSml").ToString)
                    pdfFormFields.SetField("txtD3dCorMed", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("txtD3dCorMed").ToString)
                    pdfFormFields.SetField("txtD3dCorLrg", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("txtD3dCorLrg").ToString)
                    pdfFormFields.SetField("txtD3dCWMSml", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("txtD3dCWMSml").ToString)
                    pdfFormFields.SetField("txtD3dCWMMed", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("txtD3dCWMMed").ToString)
                    pdfFormFields.SetField("txtD3dCWMLrg", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("txtD3dCWMLrg").ToString)
                    pdfFormFields.SetField("txtD3dDGSml", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("txtD3dDGSml").ToString)
                    pdfFormFields.SetField("txtD3dDGMed", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("txtD3dDGMed").ToString)
                    pdfFormFields.SetField("txtD3dDGLrg", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("txtD3dDGLrg").ToString)
                    pdfFormFields.SetField("txtD3dBSSml", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("txtD3dBSSml").ToString)
                    pdfFormFields.SetField("txtD3dBSMed", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("txtD3dBSMed").ToString)
                    pdfFormFields.SetField("txtD3dBSLrg", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("txtD3dBSLrg").ToString)
                    pdfFormFields.SetField("txtD3dCerSml", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("txtD3dCerSml").ToString)
                    pdfFormFields.SetField("txtD3dCerMed", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("txtD3dCerMed").ToString)
                    pdfFormFields.SetField("txtD3dCerLrg", formTables.Tables("viewCERADD_PDFExport").Rows(0).Item("txtD3dCerLrg").ToString)
                End If

                'CERADE
                If Database.ExistingRecordCheck("viewCERADE_PDFExport", "SubNum = " & WarehouseShell.SubNum) Then
                    formTables.Tables.Add(Database.ReturnTable("viewCERADE_PDFExport", , "SubNum = " & WarehouseShell.SubNum))
                    pdfFormFields.SetField("txtE1a", formTables.Tables("viewCERADE_PDFExport").Rows(0).Item("txtE1a").ToString)
                    pdfFormFields.SetField("txtE1b", formTables.Tables("viewCERADE_PDFExport").Rows(0).Item("txtE1b").ToString)
                    pdfFormFields.SetField("txtE2", formTables.Tables("viewCERADE_PDFExport").Rows(0).Item("txtE2").ToString)
                    pdfFormFields.SetField("txtE2Spec", formTables.Tables("viewCERADE_PDFExport").Rows(0).Item("txtE2Spec").ToString)
                    pdfFormFields.SetField("txtE2a", formTables.Tables("viewCERADE_PDFExport").Rows(0).Item("txtE2a").ToString)
                    pdfFormFields.SetField("txtE2aSpec", formTables.Tables("viewCERADE_PDFExport").Rows(0).Item("txtE2aSpec").ToString)
                    pdfFormFields.SetField("txtE2b", formTables.Tables("viewCERADE_PDFExport").Rows(0).Item("txtE2b").ToString)
                    pdfFormFields.SetField("txtE2c", formTables.Tables("viewCERADE_PDFExport").Rows(0).Item("txtE2c").ToString)
                    pdfFormFields.SetField("chkE2cOccNo", formTables.Tables("viewCERADE_PDFExport").Rows(0).Item("chkE2cOccNo").ToString)
                    pdfFormFields.SetField("chkE2cOccYes", formTables.Tables("viewCERADE_PDFExport").Rows(0).Item("chkE2cOccYes").ToString)
                    pdfFormFields.SetField("chkE2cOccUnk", formTables.Tables("viewCERADE_PDFExport").Rows(0).Item("chkE2cOccUnk").ToString)
                    pdfFormFields.SetField("chkE2cParNo", formTables.Tables("viewCERADE_PDFExport").Rows(0).Item("chkE2cParNo").ToString)
                    pdfFormFields.SetField("chkE2cParYes", formTables.Tables("viewCERADE_PDFExport").Rows(0).Item("chkE2cParYes").ToString)
                    pdfFormFields.SetField("chkE2cParUnk", formTables.Tables("viewCERADE_PDFExport").Rows(0).Item("chkE2cParUnk").ToString)
                    pdfFormFields.SetField("chkE2cFroNo", formTables.Tables("viewCERADE_PDFExport").Rows(0).Item("chkE2cFroNo").ToString)
                    pdfFormFields.SetField("chkE2cFroYes", formTables.Tables("viewCERADE_PDFExport").Rows(0).Item("chkE2cFroYes").ToString)
                    pdfFormFields.SetField("chkE2cFroUnk", formTables.Tables("viewCERADE_PDFExport").Rows(0).Item("chkE2cFroUnk").ToString)
                    pdfFormFields.SetField("chkE2cTemNo", formTables.Tables("viewCERADE_PDFExport").Rows(0).Item("chkE2cTemNo").ToString)
                    pdfFormFields.SetField("chkE2cTemYes", formTables.Tables("viewCERADE_PDFExport").Rows(0).Item("chkE2cTemYes").ToString)
                    pdfFormFields.SetField("chkE2cTemUnk", formTables.Tables("viewCERADE_PDFExport").Rows(0).Item("chkE2cTemUnk").ToString)
                End If

                'CERADF
                If Database.ExistingRecordCheck("viewCERADF_PDFExport", "SubNum = " & WarehouseShell.SubNum) Then
                    formTables.Tables.Add(Database.ReturnTable("viewCERADF_PDFExport", , "SubNum = " & WarehouseShell.SubNum))
                    pdfFormFields.SetField("txtF1", formTables.Tables("viewCERADF_PDFExport").Rows(0).Item("txtF1").ToString)
                    pdfFormFields.SetField("txtF1a", formTables.Tables("viewCERADF_PDFExport").Rows(0).Item("txtF1a").ToString)
                    pdfFormFields.SetField("txtF1b", formTables.Tables("viewCERADF_PDFExport").Rows(0).Item("txtF1b").ToString)
                    pdfFormFields.SetField("txtF1c", formTables.Tables("viewCERADF_PDFExport").Rows(0).Item("txtF1c").ToString)
                    pdfFormFields.SetField("txtF1aLoc", formTables.Tables("viewCERADF_PDFExport").Rows(0).Item("txtF1aLoc").ToString)
                    pdfFormFields.SetField("txtF1bLoc", formTables.Tables("viewCERADF_PDFExport").Rows(0).Item("txtF1bLoc").ToString)
                    pdfFormFields.SetField("txtF1cLoc", formTables.Tables("viewCERADF_PDFExport").Rows(0).Item("txtF1cLoc").ToString)
                End If

                'CERADG1
                If Database.ExistingRecordCheck("viewCERADG1_PDFExport", "SubNum = " & WarehouseShell.SubNum) Then
                    formTables.Tables.Add(Database.ReturnTable("viewCERADG1_PDFExport", , "SubNum = " & WarehouseShell.SubNum))
                    pdfFormFields.SetField("chkG1HENo", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("chkG1HENo").ToString)
                    pdfFormFields.SetField("chkG1HEYes", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("chkG1HEYes").ToString)
                    pdfFormFields.SetField("chkG1ConNo", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("chkG1ConNo").ToString)
                    pdfFormFields.SetField("chkG1ConYes", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("chkG1ConYes").ToString)
                    pdfFormFields.SetField("chkG1ThioNo", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("chkG1ThioNo").ToString)
                    pdfFormFields.SetField("chkG1ThioYes", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("chkG1ThioYes").ToString)
                    pdfFormFields.SetField("chkG1SilNo", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("chkG1SilNo").ToString)
                    pdfFormFields.SetField("chkG1SilYes", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("chkG1SilYes").ToString)
                    pdfFormFields.SetField("txtG1SilSpec", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG1SilSpec").ToString)
                    pdfFormFields.SetField("chkG1OthNo", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("chkG1OthNo").ToString)
                    pdfFormFields.SetField("chkG1OthYes", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("chkG1OthYes").ToString)
                    pdfFormFields.SetField("txtG1OthSpec", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG1OthSpec").ToString)
                    pdfFormFields.SetField("txtG21WOCoresHip", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG21WOCoresHip").ToString)
                    pdfFormFields.SetField("txtG21WOCoresEnt", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG21WOCoresEnt").ToString)
                    pdfFormFields.SetField("txtG21WOCoresAmy", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG21WOCoresAmy").ToString)
                    pdfFormFields.SetField("txtG21WCoresHip", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG21WCoresHip").ToString)
                    pdfFormFields.SetField("txtG21WCoresEnt", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG21WCoresEnt").ToString)
                    pdfFormFields.SetField("txtG21WCoresAmy", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG21WCoresAmy").ToString)
                    pdfFormFields.SetField("txtG22Hip", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG22Hip").ToString)
                    pdfFormFields.SetField("txtG22Ent", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG22Ent").ToString)
                    pdfFormFields.SetField("txtG22Amy", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG22Amy").ToString)
                    pdfFormFields.SetField("txtG23ParHip", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG23ParHip").ToString)
                    pdfFormFields.SetField("txtG23ParEnt", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG23ParEnt").ToString)
                    pdfFormFields.SetField("txtG23ParAmy", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG23ParAmy").ToString)
                    pdfFormFields.SetField("txtG23MenHip", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG23MenHip").ToString)
                    pdfFormFields.SetField("txtG23MenEnt", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG23MenEnt").ToString)
                    pdfFormFields.SetField("txtG23MenAmy", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG23MenAmy").ToString)
                    pdfFormFields.SetField("txtG23HemHip", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG23HemHip").ToString)
                    pdfFormFields.SetField("txtG23HemEnt", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG23HemEnt").ToString)
                    pdfFormFields.SetField("txtG23HemAmy", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG23HemAmy").ToString)
                    pdfFormFields.SetField("txtG24Hip", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG24Hip").ToString)
                    pdfFormFields.SetField("txtG24Ent", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG24Ent").ToString)
                    pdfFormFields.SetField("txtG24Amy", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG24Amy").ToString)
                    pdfFormFields.SetField("txtG25Hip", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG25Hip").ToString)
                    pdfFormFields.SetField("txtG25Ent", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG25Ent").ToString)
                    pdfFormFields.SetField("txtG25Amy", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG25Amy").ToString)
                    pdfFormFields.SetField("txtG26Hip", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG26Hip").ToString)
                    pdfFormFields.SetField("txtG26Ent", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG26Ent").ToString)
                    pdfFormFields.SetField("txtG26Amy", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG26Amy").ToString)
                    pdfFormFields.SetField("txtG27Hip", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG27Hip").ToString)
                    pdfFormFields.SetField("txtG27Ent", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG27Ent").ToString)
                    pdfFormFields.SetField("txtG27Amy", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG27Amy").ToString)
                    pdfFormFields.SetField("txtG28Hip", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG28Hip").ToString)
                    pdfFormFields.SetField("txtG28Ent", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG28Ent").ToString)
                    pdfFormFields.SetField("txtG28Amy", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG28Amy").ToString)
                    pdfFormFields.SetField("txtG29Hip", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG29Hip").ToString)
                    pdfFormFields.SetField("txtG29Ent", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG29Ent").ToString)
                    pdfFormFields.SetField("txtG29Amy", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG29Amy").ToString)
                    pdfFormFields.SetField("txtG210Hip", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG210Hip").ToString)
                    pdfFormFields.SetField("txtG210Ent", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG210Ent").ToString)
                    pdfFormFields.SetField("txtG210Amy", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG210Amy").ToString)
                    pdfFormFields.SetField("txtG210Spec", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG210Spec").ToString)
                    pdfFormFields.SetField("txtG2Hippo", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG2Hippo").ToString)
                    pdfFormFields.SetField("txtG2Entor", formTables.Tables("viewCERADG1_PDFExport").Rows(0).Item("txtG2Entor").ToString)
                End If

                'CERADG2
                If Database.ExistingRecordCheck("viewCERADG2_PDFExport", "SubNum = " & WarehouseShell.SubNum) Then
                    formTables.Tables.Add(Database.ReturnTable("viewCERADG2_PDFExport", , "SubNum = " & WarehouseShell.SubNum))
                    pdfFormFields.SetField("txtG2BMArea", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG2BMArea").ToString)
                    pdfFormFields.SetField("txtG21WOCoresMid", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG21WOCoresMid").ToString)
                    pdfFormFields.SetField("txtG21WOCoresSup", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG21WOCoresSup").ToString)
                    pdfFormFields.SetField("txtG21WOCoresInf", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG21WOCoresInf").ToString)
                    pdfFormFields.SetField("txtG21WOCoresOcc", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG21WOCoresOcc").ToString)
                    pdfFormFields.SetField("txtG21WCoresMid", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG21WCoresMid").ToString)
                    pdfFormFields.SetField("txtG21WCoresSup", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG21WCoresSup").ToString)
                    pdfFormFields.SetField("txtG21WCoresInf", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG21WCoresInf").ToString)
                    pdfFormFields.SetField("txtG21WCoresOcc", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG21WCoresOcc").ToString)
                    pdfFormFields.SetField("txtG22Mid", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG22Mid").ToString)
                    pdfFormFields.SetField("txtG22Sup", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG22Sup").ToString)
                    pdfFormFields.SetField("txtG22Inf", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG22Inf").ToString)
                    pdfFormFields.SetField("txtG22Occ", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG22Occ").ToString)
                    pdfFormFields.SetField("txtG23ParMid", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG23ParMid").ToString)
                    pdfFormFields.SetField("txtG23ParSup", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG23ParSup").ToString)
                    pdfFormFields.SetField("txtG23ParInf", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG23ParInf").ToString)
                    pdfFormFields.SetField("txtG23ParOcc", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG23ParOcc").ToString)
                    pdfFormFields.SetField("txtG23MenMid", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG23MenMid").ToString)
                    pdfFormFields.SetField("txtG23MenSup", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG23MenSup").ToString)
                    pdfFormFields.SetField("txtG23MenInf", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG23MenInf").ToString)
                    pdfFormFields.SetField("txtG23MenOcc", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG23MenOcc").ToString)
                    pdfFormFields.SetField("txtG23HemMid", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG23HemMid").ToString)
                    pdfFormFields.SetField("txtG23HemSup", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG23HemSup").ToString)
                    pdfFormFields.SetField("txtG23HemInf", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG23HemInf").ToString)
                    pdfFormFields.SetField("txtG23HemOcc", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG23HemOcc").ToString)
                    pdfFormFields.SetField("txtG24Mid", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG24Mid").ToString)
                    pdfFormFields.SetField("txtG24Sup", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG24Sup").ToString)
                    pdfFormFields.SetField("txtG24Inf", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG24Inf").ToString)
                    pdfFormFields.SetField("txtG24Occ", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG24Occ").ToString)
                    pdfFormFields.SetField("txtG25Mid", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG25Mid").ToString)
                    pdfFormFields.SetField("txtG25Sup", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG25Sup").ToString)
                    pdfFormFields.SetField("txtG25Inf", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG25Inf").ToString)
                    pdfFormFields.SetField("txtG25Occ", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG25Occ").ToString)
                    pdfFormFields.SetField("txtG26Mid", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG26Mid").ToString)
                    pdfFormFields.SetField("txtG26Sup", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG26Sup").ToString)
                    pdfFormFields.SetField("txtG26Inf", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG26Inf").ToString)
                    pdfFormFields.SetField("txtG26Occ", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG26Occ").ToString)
                    pdfFormFields.SetField("txtG27Mid", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG27Mid").ToString)
                    pdfFormFields.SetField("txtG27Sup", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG27Sup").ToString)
                    pdfFormFields.SetField("txtG27Inf", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG27Inf").ToString)
                    pdfFormFields.SetField("txtG27Occ", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG27Occ").ToString)
                    pdfFormFields.SetField("txtG28Mid", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG28Mid").ToString)
                    pdfFormFields.SetField("txtG28Sup", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG28Sup").ToString)
                    pdfFormFields.SetField("txtG28Inf", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG28Inf").ToString)
                    pdfFormFields.SetField("txtG28Occ", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG28Occ").ToString)
                    pdfFormFields.SetField("txtG28OthSpec", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG28OthSpec").ToString)
                    pdfFormFields.SetField("txtG3OthSpec", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG3OthSpec").ToString)
                    pdfFormFields.SetField("txtG31Sub", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG31Sub").ToString)
                    pdfFormFields.SetField("txtG31Nuc", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG31Nuc").ToString)
                    pdfFormFields.SetField("txtG31Loc", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG31Loc").ToString)
                    pdfFormFields.SetField("txtG31DVN", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG31DVN").ToString)
                    pdfFormFields.SetField("txtG31Cer", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG31Cer").ToString)
                    pdfFormFields.SetField("txtG31Oth", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG31Oth").ToString)
                    pdfFormFields.SetField("txtG32Sub", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG32Sub").ToString)
                    pdfFormFields.SetField("txtG32Nuc", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG32Nuc").ToString)
                    pdfFormFields.SetField("txtG32DRN", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG32DRN").ToString)
                    pdfFormFields.SetField("txtG32Loc", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG32Loc").ToString)
                    pdfFormFields.SetField("txtG32DVN", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG32DVN").ToString)
                    pdfFormFields.SetField("txtG32Cer", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG32Cer").ToString)
                    pdfFormFields.SetField("txtG32Oth", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG32Oth").ToString)
                    pdfFormFields.SetField("txtG33Sub", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG33Sub").ToString)
                    pdfFormFields.SetField("txtG33Nuc", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG33Nuc").ToString)
                    pdfFormFields.SetField("txtG33DRN", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG33DRN").ToString)
                    pdfFormFields.SetField("txtG33Loc", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG33Loc").ToString)
                    pdfFormFields.SetField("txtG33DVN", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG33DVN").ToString)
                    pdfFormFields.SetField("txtG33Cer", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG33Cer").ToString)
                    pdfFormFields.SetField("txtG33Oth", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG33Oth").ToString)
                    pdfFormFields.SetField("txtG34Sub", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG34Sub").ToString)
                    pdfFormFields.SetField("txtG34Nuc", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG34Nuc").ToString)
                    pdfFormFields.SetField("txtG34DRN", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG34DRN").ToString)
                    pdfFormFields.SetField("txtG34Loc", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG34Loc").ToString)
                    pdfFormFields.SetField("txtG34DVN", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG34DVN").ToString)
                    pdfFormFields.SetField("txtG34Cer", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG34Cer").ToString)
                    pdfFormFields.SetField("txtG34Oth", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG34Oth").ToString)
                    pdfFormFields.SetField("txtG35Sub", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG35Sub").ToString)
                    pdfFormFields.SetField("txtG35Nuc", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG35Nuc").ToString)
                    pdfFormFields.SetField("txtG35DRN", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG35DRN").ToString)
                    pdfFormFields.SetField("txtG35Loc", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG35Loc").ToString)
                    pdfFormFields.SetField("txtG35DVN", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG35DVN").ToString)
                    pdfFormFields.SetField("txtG35Cer", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG35Cer").ToString)
                    pdfFormFields.SetField("txtG35Oth", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG35Oth").ToString)
                    pdfFormFields.SetField("txtG36Sub", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG36Sub").ToString)
                    pdfFormFields.SetField("txtG36Nuc", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG36Nuc").ToString)
                    pdfFormFields.SetField("txtG36DRN", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG36DRN").ToString)
                    pdfFormFields.SetField("txtG36Loc", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG36Loc").ToString)
                    pdfFormFields.SetField("txtG36DVN", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG36DVN").ToString)
                    pdfFormFields.SetField("txtG36Cer", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG36Cer").ToString)
                    pdfFormFields.SetField("txtG36Oth", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG36Oth").ToString)
                    pdfFormFields.SetField("txtG37Sub", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG37Sub").ToString)
                    pdfFormFields.SetField("txtG37Nuc", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG37Nuc").ToString)
                    pdfFormFields.SetField("txtG37DRN", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG37DRN").ToString)
                    pdfFormFields.SetField("txtG37Loc", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG37Loc").ToString)
                    pdfFormFields.SetField("txtG37DVN", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG37DVN").ToString)
                    pdfFormFields.SetField("txtG37Cer", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG37Cer").ToString)
                    pdfFormFields.SetField("txtG37Oth", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG37Oth").ToString)
                    pdfFormFields.SetField("txtG37Spec", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("txtG37Spec").ToString)
                    pdfFormFields.SetField("chkG3SubNo", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("chkG3SubNo").ToString)
                    pdfFormFields.SetField("chkG3SubYes", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("chkG3SubYes").ToString)
                    pdfFormFields.SetField("chkG3SubUnk", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("chkG3SubUnk").ToString)
                    pdfFormFields.SetField("chkG3LocNo", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("chkG3LocNo").ToString)
                    pdfFormFields.SetField("chkG3LocYes", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("chkG3LocYes").ToString)
                    pdfFormFields.SetField("chkG3LocUnk", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("chkG3LocUnk").ToString)
                    pdfFormFields.SetField("chkG3DorNo", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("chkG3DorNo").ToString)
                    pdfFormFields.SetField("chkG3DorYes", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("chkG3DorYes").ToString)
                    pdfFormFields.SetField("chkG3DorUnk", formTables.Tables("viewCERADG2_PDFExport").Rows(0).Item("chkG3DorUnk").ToString)
                End If

                'CERADH
                If Database.ExistingRecordCheck("viewCERADH_PDFExport", "SubNum = " & WarehouseShell.SubNum) Then
                    formTables.Tables.Add(Database.ReturnTable("viewCERADH_PDFExport", , "SubNum = " & WarehouseShell.SubNum))
                    pdfFormFields.SetField("txtH1", formTables.Tables("viewCERADH_PDFExport").Rows(0).Item("txtH1").ToString)
                    pdfFormFields.SetField("chkH2Fro", formTables.Tables("viewCERADH_PDFExport").Rows(0).Item("chkH2Fro").ToString)
                    pdfFormFields.SetField("chkH2Tem", formTables.Tables("viewCERADH_PDFExport").Rows(0).Item("chkH2Tem").ToString)
                    pdfFormFields.SetField("chkH2Par", formTables.Tables("viewCERADH_PDFExport").Rows(0).Item("chkH2Par").ToString)
                    pdfFormFields.SetField("chkH3HipNo", formTables.Tables("viewCERADH_PDFExport").Rows(0).Item("chkH3HipNo").ToString)
                    pdfFormFields.SetField("chkH3HipYes", formTables.Tables("viewCERADH_PDFExport").Rows(0).Item("chkH3HipYes").ToString)
                    pdfFormFields.SetField("chkH3HipNA", formTables.Tables("viewCERADH_PDFExport").Rows(0).Item("chkH3HipNA").ToString)
                    pdfFormFields.SetField("chkH3EntNo", formTables.Tables("viewCERADH_PDFExport").Rows(0).Item("chkH3EntNo").ToString)
                    pdfFormFields.SetField("chkH3EntYes", formTables.Tables("viewCERADH_PDFExport").Rows(0).Item("chkH3EntYes").ToString)
                    pdfFormFields.SetField("chkH3EntNA", formTables.Tables("viewCERADH_PDFExport").Rows(0).Item("chkH3EntNA").ToString)
                    pdfFormFields.SetField("chkH3FreNo", formTables.Tables("viewCERADH_PDFExport").Rows(0).Item("chkH3FreNo").ToString)
                    pdfFormFields.SetField("chkH3FreYes", formTables.Tables("viewCERADH_PDFExport").Rows(0).Item("chkH3FreYes").ToString)
                    pdfFormFields.SetField("chkH3FreNA", formTables.Tables("viewCERADH_PDFExport").Rows(0).Item("chkH3FreNA").ToString)
                    pdfFormFields.SetField("chkH3OthNo", formTables.Tables("viewCERADH_PDFExport").Rows(0).Item("chkH3OthNo").ToString)
                    pdfFormFields.SetField("chkH3OthYes", formTables.Tables("viewCERADH_PDFExport").Rows(0).Item("chkH3OthYes").ToString)
                    pdfFormFields.SetField("chkH3OthNA", formTables.Tables("viewCERADH_PDFExport").Rows(0).Item("chkH3OthNA").ToString)
                    pdfFormFields.SetField("txtH3Spec", formTables.Tables("viewCERADH_PDFExport").Rows(0).Item("txtH3Spec").ToString)
                    pdfFormFields.SetField("txtH4", formTables.Tables("viewCERADH_PDFExport").Rows(0).Item("txtH4").ToString)
                End If

                'CERADI
                If Database.ExistingRecordCheck("viewCERADI_PDFExport", "SubNum = " & WarehouseShell.SubNum) Then
                    formTables.Tables.Add(Database.ReturnTable("viewCERADI_PDFExport", , "SubNum = " & WarehouseShell.SubNum))
                    pdfFormFields.SetField("txtI1", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI1").ToString)
                    pdfFormFields.SetField("chkI1a", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("chkI1a").ToString)
                    pdfFormFields.SetField("chkI1b", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("chkI1b").ToString)
                    pdfFormFields.SetField("chkI1c", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("chkI1c").ToString)
                    pdfFormFields.SetField("txtI2", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI2").ToString)
                    pdfFormFields.SetField("txtI3", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI3").ToString)
                    pdfFormFields.SetField("txtI4", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI4").ToString)
                    pdfFormFields.SetField("chkI4a", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("chkI4a").ToString)
                    pdfFormFields.SetField("chkI4b", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("chkI4b").ToString)
                    pdfFormFields.SetField("txtI5", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI5").ToString)
                    pdfFormFields.SetField("chkI5a", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("chkI5a").ToString)
                    pdfFormFields.SetField("chkI5b", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("chkI5b").ToString)
                    pdfFormFields.SetField("txtI6", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI6").ToString)
                    pdfFormFields.SetField("txtI7a", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI7a").ToString)
                    pdfFormFields.SetField("txtI7b", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI7b").ToString)
                    pdfFormFields.SetField("txtI7c", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI7c").ToString)
                    pdfFormFields.SetField("txtI7d", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI7d").ToString)
                    pdfFormFields.SetField("txtI7e", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI7e").ToString)
                    pdfFormFields.SetField("txtI7f", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI7f").ToString)
                    pdfFormFields.SetField("txtI7fSpec", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI7fSpec").ToString)
                    pdfFormFields.SetField("txtI8", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI8").ToString)
                    pdfFormFields.SetField("txtI9", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI9").ToString)
                    pdfFormFields.SetField("txtI10", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI10").ToString)
                    pdfFormFields.SetField("txtI11a", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI11a").ToString)
                    pdfFormFields.SetField("txtI11b", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI11b").ToString)
                    pdfFormFields.SetField("txtI12", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI12").ToString)
                    pdfFormFields.SetField("txtI13", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI13").ToString)
                    pdfFormFields.SetField("txtI13Spec", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI13Spec").ToString)
                    pdfFormFields.SetField("txtI14a", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI14a").ToString)
                    pdfFormFields.SetField("txtI14aSpec", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI14aSpec").ToString)
                    pdfFormFields.SetField("txtI14b", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI14b").ToString)
                    pdfFormFields.SetField("txtI14bSpec", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI14bSpec").ToString)
                    pdfFormFields.SetField("txtI15", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI15").ToString)
                    pdfFormFields.SetField("txtI16a", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI16a").ToString)
                    pdfFormFields.SetField("txtI16aSpec", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI16aSpec").ToString)
                    pdfFormFields.SetField("txtI16b", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI16b").ToString)
                    pdfFormFields.SetField("txtI16bSpec", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI16bSpec").ToString)
                    pdfFormFields.SetField("txtI16c", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI16c").ToString)
                    pdfFormFields.SetField("txtI16cSpec", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI16cSpec").ToString)
                    pdfFormFields.SetField("txtI17", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI17").ToString)
                    pdfFormFields.SetField("txtI18", formTables.Tables("viewCERADI_PDFExport").Rows(0).Item("txtI18").ToString)
                End If

                'CERADJ
                If Database.ExistingRecordCheck("viewCERADJ_PDFExport", "SubNum = " & WarehouseShell.SubNum) Then
                    formTables.Tables.Add(Database.ReturnTable("viewCERADJ_PDFExport", , "SubNum = " & WarehouseShell.SubNum))
                    pdfFormFields.SetField("txtJRank1", formTables.Tables("viewCERADJ_PDFExport").Rows(0).Item("txtJRank1").ToString)
                    pdfFormFields.SetField("txtJRank2", formTables.Tables("viewCERADJ_PDFExport").Rows(0).Item("txtJRank2").ToString)
                    pdfFormFields.SetField("txtJRank3", formTables.Tables("viewCERADJ_PDFExport").Rows(0).Item("txtJRank3").ToString)
                    pdfFormFields.SetField("txtJRank4", formTables.Tables("viewCERADJ_PDFExport").Rows(0).Item("txtJRank4").ToString)
                    pdfFormFields.SetField("txtJDx1", formTables.Tables("viewCERADJ_PDFExport").Rows(0).Item("txtJDx1").ToString)
                    pdfFormFields.SetField("txtJDx2", formTables.Tables("viewCERADJ_PDFExport").Rows(0).Item("txtJDx2").ToString)
                    pdfFormFields.SetField("txtJDx3", formTables.Tables("viewCERADJ_PDFExport").Rows(0).Item("txtJDx3").ToString)
                    pdfFormFields.SetField("txtJDx4", formTables.Tables("viewCERADJ_PDFExport").Rows(0).Item("txtJDx4").ToString)
                    pdfFormFields.SetField("Braak_Alz", formTables.Tables("viewCERADJ_PDFExport").Rows(0).Item("Braak_Alz").ToString)
                    pdfFormFields.SetField("Braak_Park", formTables.Tables("viewCERADJ_PDFExport").Rows(0).Item("Braak_Park").ToString)
                    pdfFormFields.SetField("ABC_A", formTables.Tables("viewCERADJ_PDFExport").Rows(0).Item("ABC_A").ToString)
                    pdfFormFields.SetField("ABC_B", formTables.Tables("viewCERADJ_PDFExport").Rows(0).Item("ABC_B").ToString)
                    pdfFormFields.SetField("ABC_C", formTables.Tables("viewCERADJ_PDFExport").Rows(0).Item("ABC_C").ToString)
                    pdfFormFields.SetField("ABC_Result", formTables.Tables("viewCERADJ_PDFExport").Rows(0).Item("ABC_Result").ToString)
                End If

                'CERAD_Addendum
                If Database.ExistingRecordCheck("CERAD_Addendum", "SubNum = " & WarehouseShell.SubNum) Then
                    formTables.Tables.Add(Database.ReturnTable("viewCERAD_Addendum", , "SubNum = " & WarehouseShell.SubNum))
                    pdfFormFields.SetField("8a", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("Path8aLabel").ToString)
                    pdfFormFields.SetField("8b", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("Path8bLabel").ToString)
                    pdfFormFields.SetField("8c", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("Path8cLabel").ToString)
                    pdfFormFields.SetField("8d", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("Path8dLabel").ToString)
                    pdfFormFields.SetField("11", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("Path11Label").ToString)
                    pdfFormFields.SetField("12f", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("Path12fLabel").ToString)
                    pdfFormFields.SetField("12g", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("Path12gLabel").ToString)
                    pdfFormFields.SetField("12h", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("Path12hLabel").ToString)
                    pdfFormFields.SetField("12k", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("Path12kLabel").ToString)
                    pdfFormFields.SetField("17a", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("Path17aLabel").ToString)
                    pdfFormFields.SetField("17b", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("Path17bNote").ToString)
                    pdfFormFields.SetField("18b", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("Path18bLabel").ToString)
                    pdfFormFields.SetField("18c", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("Path18cLabel").ToString)
                    pdfFormFields.SetField("19", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("Path19Label").ToString)
                    pdfFormFields.SetField("20a", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("Path20aLabel").ToString)
                    pdfFormFields.SetField("20b", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("Path20bLabel").ToString)
                    pdfFormFields.SetField("20c", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("Path20cLabel").ToString)
                    pdfFormFields.SetField("20d", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("Path20dLabel").ToString)
                    pdfFormFields.SetField("20e", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("Path20eLabel").ToString)
                    pdfFormFields.SetField("20f", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("Path20fLabel").ToString)
                    pdfFormFields.SetField("20g", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("Path20gLabel").ToString)
                    pdfFormFields.SetField("20h", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("Path20hLabel").ToString)
                    pdfFormFields.SetField("20i", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("Path20iLabel").ToString)
                    pdfFormFields.SetField("20i_Spec", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("Path20iNote").ToString)
                    pdfFormFields.SetField("20j", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("Path20jLabel").ToString)
                    pdfFormFields.SetField("20j_Spec", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("Path20jNote").ToString)
                    pdfFormFields.SetField("20k", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("Path20kLabel").ToString)
                    pdfFormFields.SetField("20k_Spec", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("Path20kNote").ToString)
                    pdfFormFields.SetField("AlphaSynInd", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("AlphaPathIndLabel").ToString)
                    pdfFormFields.SetField("AlphaSyndType", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("AlphaPathLabel").ToString)
                    pdfFormFields.SetField("AS_Fron", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a1a"), "1", "0"))
                    pdfFormFields.SetField("AS_Sup", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a2a"), "1", "0"))
                    pdfFormFields.SetField("AS_Par", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a3a"), "1", "0"))
                    pdfFormFields.SetField("AS_Amyg", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a4a"), "1", "0"))
                    pdfFormFields.SetField("AS_Ins", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a5a"), "1", "0"))
                    pdfFormFields.SetField("AS_Cing", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a6a"), "1", "0"))
                    pdfFormFields.SetField("AS_Hippo", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a7a"), "1", "0"))
                    pdfFormFields.SetField("AS_Sub", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a8a"), "1", "0"))
                    pdfFormFields.SetField("AS_Thal", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a9a"), "1", "0"))
                    pdfFormFields.SetField("AS_Med", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a10a"), "1", "0"))
                    pdfFormFields.SetField("AS_Pons", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a11a"), "1", "0"))
                    pdfFormFields.SetField("AS_Cerv", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a12a"), "1", "0"))
                    pdfFormFields.SetField("AS_PrimVis", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a13a"), "1", "0"))
                    pdfFormFields.SetField("AS_Cere", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a14a"), "1", "0"))
                    pdfFormFields.SetField("AS_Caud", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a15a"), "1", "0"))
                    pdfFormFields.SetField("AS_Peri", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a16a"), "1", "0"))
                    pdfFormFields.SetField("AS_PrimMot", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a17a"), "1", "0"))
                    pdfFormFields.SetField("AS_Olf", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a18a"), "1", "0"))
                    pdfFormFields.SetField("AS_Thor", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a19a"), "1", "0"))
                    pdfFormFields.SetField("AS_Lumb", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a20a"), "1", "0"))
                    pdfFormFields.SetField("Ubi_Ind", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("UbiquitinPathLabel").ToString)
                    pdfFormFields.SetField("Ubi_Fron", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a1a"), "1", "0"))
                    pdfFormFields.SetField("Ubi_Sup", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a2a"), "1", "0"))
                    pdfFormFields.SetField("Ubi_Par", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a3a"), "1", "0"))
                    pdfFormFields.SetField("Ubi_Amyg", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a4a"), "1", "0"))
                    pdfFormFields.SetField("Ubi_Ins", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a5a"), "1", "0"))
                    pdfFormFields.SetField("Ubi_Cing", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a6a"), "1", "0"))
                    pdfFormFields.SetField("Ubi_Hippo", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a7a"), "1", "0"))
                    pdfFormFields.SetField("Ubi_Sub", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a8a"), "1", "0"))
                    pdfFormFields.SetField("Ubi_Thal", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a9a"), "1", "0"))
                    pdfFormFields.SetField("Ubi_Med", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a10a"), "1", "0"))
                    pdfFormFields.SetField("Ubi_Pons", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a11a"), "1", "0"))
                    pdfFormFields.SetField("Ubi_Cerv", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a12a"), "1", "0"))
                    pdfFormFields.SetField("Ubi_PrimVis", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a13a"), "1", "0"))
                    pdfFormFields.SetField("Ubi_Cere", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a14a"), "1", "0"))
                    pdfFormFields.SetField("Ubi_Caud", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a15a"), "1", "0"))
                    pdfFormFields.SetField("Ubi_Peri", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a16a"), "1", "0"))
                    pdfFormFields.SetField("Ubi_PrimMot", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a17a"), "1", "0"))
                    pdfFormFields.SetField("Ubi_Olf", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a18a"), "1", "0"))
                    pdfFormFields.SetField("Ubi_Thor", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a19a"), "1", "0"))
                    pdfFormFields.SetField("Ubi_Lumb", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a20a"), "1", "0"))
                    pdfFormFields.SetField("TDP_Ind", formTables.Tables("viewCERAD_Addendum").Rows(0).Item("TDPPathLabel").ToString)
                    pdfFormFields.SetField("TDP_Fron", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a1a"), "1", "0"))
                    pdfFormFields.SetField("TDP_Sup", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a2a"), "1", "0"))
                    pdfFormFields.SetField("TDP_Par", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a3a"), "1", "0"))
                    pdfFormFields.SetField("TDP_Amyg", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a4a"), "1", "0"))
                    pdfFormFields.SetField("TDP_Ins", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a5a"), "1", "0"))
                    pdfFormFields.SetField("TDP_Cing", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a6a"), "1", "0"))
                    pdfFormFields.SetField("TDP_Hippo", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a7a"), "1", "0"))
                    pdfFormFields.SetField("TDP_Sub", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a8a"), "1", "0"))
                    pdfFormFields.SetField("TDP_Thal", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a9a"), "1", "0"))
                    pdfFormFields.SetField("TDP_Med", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a10a"), "1", "0"))
                    pdfFormFields.SetField("TDP_Pons", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a11a"), "1", "0"))
                    pdfFormFields.SetField("TDP_Cerv", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a12a"), "1", "0"))
                    pdfFormFields.SetField("TDP_PrimVis", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a13a"), "1", "0"))
                    pdfFormFields.SetField("TDP_Cere", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a14a"), "1", "0"))
                    pdfFormFields.SetField("TDP_Caud", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a15a"), "1", "0"))
                    pdfFormFields.SetField("TDP_Peri", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a16a"), "1", "0"))
                    pdfFormFields.SetField("TDP_PrimMot", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a17a"), "1", "0"))
                    pdfFormFields.SetField("TDP_Olf", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a18a"), "1", "0"))
                    pdfFormFields.SetField("TDP_Thor", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a19a"), "1", "0"))
                    pdfFormFields.SetField("TDP_Lumb", IIf(formTables.Tables("viewCERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a20a"), "1", "0"))
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
    Private Sub clearPDFTables()
        If formTables.Tables.Contains("viewCERADA_PDFExport") Then
            formTables.Tables.Remove("viewCERADA_PDFExport")
        End If
        If formTables.Tables.Contains("viewCERADB_PDFExport") Then
            formTables.Tables.Remove("viewCERADB_PDFExport")
        End If
        If formTables.Tables.Contains("viewCERADC_PDFExport") Then
            formTables.Tables.Remove("viewCERADC_PDFExport")
        End If
        If formTables.Tables.Contains("viewCERADD_PDFExport") Then
            formTables.Tables.Remove("viewCERADD_PDFExport")
        End If
        If formTables.Tables.Contains("viewCERADE_PDFExport") Then
            formTables.Tables.Remove("viewCERADE_PDFExport")
        End If
        If formTables.Tables.Contains("viewCERADF_PDFExport") Then
            formTables.Tables.Remove("viewCERADF_PDFExport")
        End If
        If formTables.Tables.Contains("viewCERADG1_PDFExport") Then
            formTables.Tables.Remove("viewCERADG1_PDFExport")
        End If
        If formTables.Tables.Contains("viewCERADG2_PDFExport") Then
            formTables.Tables.Remove("viewCERADG2_PDFExport")
        End If
        If formTables.Tables.Contains("viewCERADH_PDFExport") Then
            formTables.Tables.Remove("viewCERADH_PDFExport")
        End If
        If formTables.Tables.Contains("viewCERADI_PDFExport") Then
            formTables.Tables.Remove("viewCERADI_PDFExport")
        End If
        If formTables.Tables.Contains("viewCERADJ_PDFExport") Then
            formTables.Tables.Remove("viewCERADJ_PDFExport")
        End If
    End Sub

    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
        btnCERADHeader.PerformClick()
    End Sub
    Public Sub ShowPHI(val As Boolean) Implements IFormMethods.ShowPHI
    End Sub
    Public Sub TopLevel(val As Boolean) Implements IFormMethods.TopLevel
    End Sub
    Private Sub IFormMethods_Parent(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Private Sub IFormMethods_Show() Implements IFormMethods.Show
        Show()
    End Sub

    Private Sub txtCERADDate_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtCERADDate.MaskInputRejected

    End Sub

    Private Sub txtCERADDate_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCERADDate.Validating

    End Sub
End Class