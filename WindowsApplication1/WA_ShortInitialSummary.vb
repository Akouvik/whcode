Imports iTextSharp.text.pdf
Imports System.IO

Public Class WA_ShortInitialSummary
    Implements IFormMethods

    Private selectedPath As Integer = 0
    Private dataTables As New DataSet
    Private tooltip1 As New ToolTip

    'Form load subs
    Private Sub WA_ShortInitialSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_ShortInitialSummary")
        ShowPHI(WarehouseShell.ShowingPHI)
        If Database.ExistingRecordCheck("ShortInitialSummary", "SubNum = " & WarehouseShell.SubNum) Then
            loadBaseForm()
            loadExistingData()
            btnShortInitialSummaryBottom.Text = "Edit this record"
            btnShortInitialSummaryTop.Text = btnShortInitialSummaryBottom.Text
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            enableInputFields(False)
        Else
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            btnShortInitialSummaryBottom.Text = "Add New Record"
            btnShortInitialSummaryTop.Text = btnShortInitialSummaryBottom.Text
            enableInputFields(False)
            lblNoRecord.Visible = True
        End If
    End Sub
    Private Sub loadBaseForm()
        dataTables.Tables.Add(Database.ReturnTable("refInstitution", "InstitutionID, Name", , "Name"))
        cmbRefInst.DataSource = New DataView(dataTables.Tables("refInstitution"))
        cmbRefInst.ValueMember = "InstitutionID"
        cmbRefInst.DisplayMember = "Name"
        cmbAutLoc.DataSource = New DataView(dataTables.Tables("refInstitution"))
        cmbAutLoc.ValueMember = "InstitutionID"
        cmbAutLoc.DisplayMember = "Name"
    End Sub
    Private Sub loadDefaultValues()
        Dim Result As New DataTable("defaultValues")
        Dim cmd As New SqlCommand("Select a.SubNum, a.BB, concat(b.FirstName, ' ', b.MI, ' ', b.LastName) as Name, a.ReferringInstitutionValue, a.AutopsyLocationValue from Subject as b left join AutopsyFaceSheet as a on b.SubNum = a.SubNum where b.SubNum = " & WarehouseShell.SubNum & ";", WarehouseShell.conn)
        Dim Reader As New SqlDataAdapter(cmd)
        Reader.Fill(Result)
        txtSubNum.Text = Result.Rows(0).Item("SubNum").ToString
        txtBB.Text = Result.Rows(0).Item("BB").ToString
        txtName.Text = Result.Rows(0).Item("Name").ToString
        cmbRefInst.SelectedValue = Result.Rows(0).Item("ReferringInstitutionValue")
        cmbAutLoc.SelectedValue = Result.Rows(0).Item("AutopsyLocationValue")
        dtDate.Text = Format(Now(), "MMddyyyy")
        Result.Dispose()
    End Sub
    Private Sub loadExistingData()
        If dataTables.Tables.Contains("viewShortInitialSummary") Then
            dataTables.Tables.Remove("viewShortInitialSummary")
        End If
        dataTables.Tables.Add(Database.ReturnTable("viewShortInitialSummary", , "SubNum = " & WarehouseShell.SubNum))
        txtSubNum.Text = dataTables.Tables("viewShortInitialSummary").Rows(0).Item("SubNum").ToString
        txtBB.Text = dataTables.Tables("viewShortInitialSummary").Rows(0).Item("BB").ToString
        txtName.Text = dataTables.Tables("viewShortInitialSummary").Rows(0).Item("Name").ToString
        cmbRefInst.SelectedValue = dataTables.Tables("viewShortInitialSummary").Rows(0).Item("ReferringInstitutionValue")
        cmbAutLoc.SelectedValue = dataTables.Tables("viewShortInitialSummary").Rows(0).Item("AutopsyLocationValue")
        If IsDate(dataTables.Tables("viewShortInitialSummary").Rows(0).Item("SummaryDate")) Then
            dtDate.Text = Format(dataTables.Tables("viewShortInitialSummary").Rows(0).Item("SummaryDate"), "MMddyyyy")
        End If
        txtSummary.Text = dataTables.Tables("viewShortInitialSummary").Rows(0).Item("SummaryText").ToString
        txtHarryText.Text = dataTables.Tables("viewShortInitialSummary").Rows(0).Item("HarryText").ToString
        selectedPath = dataTables.Tables("viewShortInitialSummary").Rows(0).Item("Path")
        Path(selectedPath)
    End Sub

    Private Sub enableInputFields(ByVal bool As Boolean)
        If bool = True Then
            dtDate.Enabled = True
            txtSummary.makeReadOnly(False)
            If WarehouseShell.userName = "harouv01" Or WarehouseShell.userName = "arnesj01" Then
                txtHarryText.makeReadOnly(False)
            End If
        Else
            dtDate.Enabled = False
            txtSummary.makeReadOnly(True)
            txtHarryText.makeReadOnly(True)
        End If
    End Sub

    'Define button click events
    Private Sub btnShortInitialSummaryBottom_Click(sender As Object, e As EventArgs) Handles btnShortInitialSummaryBottom.Click, btnShortInitialSummaryTop.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_ShortInitialSummary", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                btnShortInitialSummaryBottom.Text = "Save changes"
                btnShortInitialSummaryTop.Text = btnShortInitialSummaryBottom.Text
                enableInputFields(True)
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If User.PermissionCheck("WA_ShortInitialSummary", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
                loadBaseForm()
                loadDefaultValues()
                enableInputFields(True)
                btnShortInitialSummaryBottom.Text = "Save new record"
                btnShortInitialSummaryTop.Text = btnShortInitialSummaryBottom.Text
                lblNoRecord.Visible = False
            End If
        Else
            If preSaveValidation() Then
                Dim sqlCommand As New SqlCommand
                sqlCommand.Connection = WarehouseShell.conn
                Dim cmdString = "@SubNum = " & WarehouseShell.SubNum &
                    ", @BB = " & txtBB.getSQLValue() &
                    ", @SummaryDate = " & dtDate.getSQLValue() &
                    ", @Path = " & selectedPath &
                    ", @SummaryText = " & txtSummary.getSQLValue() &
                    ", @HarryText = " & txtHarryText.getSQLValue() & ";"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    sqlCommand.CommandText = "Exec modShortInitialSummaryRecord @Action = 1, " & cmdString
                    Try
                        sqlCommand.ExecuteNonQuery()
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        enableInputFields(False)
                        btnShortInitialSummaryBottom.Text = "Edit this record"
                        btnShortInitialSummaryTop.Text = btnShortInitialSummaryBottom.Text
                        If selectedPath <> 0 Then 'Means that Harry or Josh enetered this complete (with NP Path) and it is ready for distro
                            emailShortInitialSummary("New")
                        End If
                        loadExistingData()
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else
                    sqlCommand.CommandText = "Exec modShortInitialSummaryRecord @Action = 2, " & cmdString
                    Try
                        sqlCommand.ExecuteNonQuery()
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        MessageBox.Show("Record successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        enableInputFields(False)
                        btnShortInitialSummaryBottom.Text = "Edit this record"
                        btnShortInitialSummaryTop.Text = btnShortInitialSummaryBottom.Text
                        If dataTables.Tables("viewShortInitialSummary").Rows(0).Item("Path") = 0 And selectedPath <> 0 Then
                            emailShortInitialSummary("New")
                        ElseIf dataTables.Tables("viewShortInitialSummary").Rows(0).Item("Path") <> 0 And selectedPath <> dataTables.Tables("viewShortInitialSummary").Rows(0).Item("Path") Then
                            emailShortInitialSummary("Update")
                        End If
                        loadExistingData()
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                End If
            Else
                MsgBox("Summary text cannot be blank. Please fix this before attempting to save.", vbOKOnly, "Error!")
            End If
        End If
    End Sub

    'Helper subs
    Private Sub Path(mySelectedPath As Integer)
        'Clear all highlighting/bolding           
        lblResIntNo.Font = New Drawing.Font(lblResIntNo.Font, FontStyle.Regular)
        lblPath1_1.Font = New Drawing.Font(lblPath1_1.Font, FontStyle.Regular)
        lblPath1_2.Font = New Drawing.Font(lblPath1_2.Font, FontStyle.Regular)
        lblResIntYes.Font = New Drawing.Font(lblResIntYes.Font, FontStyle.Regular)
        lblHarryDesYes.Font = New Drawing.Font(lblHarryDesYes.Font, FontStyle.Regular)
        lblPath2_1.Font = New Drawing.Font(lblPath2_1.Font, FontStyle.Regular)
        lblPath2_2.Font = New Drawing.Font(lblPath2_2.Font, FontStyle.Regular)
        lblHarryDesNo.Font = New Drawing.Font(lblHarryDesNo.Font, FontStyle.Regular)
        lblPath3_1.Font = New Drawing.Font(lblPath3_1.Font, FontStyle.Regular)
        If mySelectedPath = 1 Then
            lblResIntNo.Font = New Drawing.Font(lblResIntNo.Font, FontStyle.Bold)
            lblPath1_1.Font = New Drawing.Font(lblPath1_1.Font, FontStyle.Bold)
            lblPath1_2.Font = New Drawing.Font(lblPath1_2.Font, FontStyle.Bold)
        ElseIf mySelectedPath = 2 Then
            lblResIntYes.Font = New Drawing.Font(lblResIntYes.Font, FontStyle.Bold)
            lblHarryDesYes.Font = New Drawing.Font(lblHarryDesYes.Font, FontStyle.Bold)
            lblPath2_1.Font = New Drawing.Font(lblPath2_1.Font, FontStyle.Bold)
            lblPath2_2.Font = New Drawing.Font(lblPath2_2.Font, FontStyle.Bold)
        ElseIf mySelectedPath = 3 Then
            lblResIntYes.Font = New Drawing.Font(lblResIntYes.Font, FontStyle.Bold)
            lblHarryDesNo.Font = New Drawing.Font(lblHarryDesNo.Font, FontStyle.Bold)
            lblPath3_1.Font = New Drawing.Font(lblPath3_1.Font, FontStyle.Bold)
        End If
        'set selectedPath variable = input (selectedPath used to store and retreive data from database)
        selectedPath = mySelectedPath
    End Sub
    Private Sub lblPath1_Click(sender As Object, e As EventArgs) Handles lblPath1_1.Click, lblPath1_2.Click, lblResIntNo.Click, lblHarryDesYes.Click, lblPath2_1.Click, lblPath2_2.Click, lblHarryDesNo.Click, lblPath3_1.Click
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
            If WarehouseShell.userName = "harouv01" Or WarehouseShell.userName = "arnesj01" Or WarehouseShell.userName = "test" Then
                If sender Is lblResIntNo Or sender Is lblPath1_1 Or sender Is lblPath1_2 Then
                    Path(1)
                ElseIf sender Is lblHarryDesYes Or sender Is lblPath2_1 Or sender Is lblPath2_2 Then
                    Path(2)
                ElseIf sender Is lblHarryDesNo Or sender Is lblPath3_1 Then
                    Path(3)
                End If
            Else
                tooltip1.Show("Only Dr. Haroutunian can select a path here.", sender, 0, 20, 5000)
            End If
        End If
    End Sub

    'PDF Events
    Private Sub btnPDFTop_Click(sender As Object, e As EventArgs) Handles btnPDFTop.Click, btnPDFBottom.Click
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
            tooltip1.Show("This record must be saved before PDF Export can be created.", btnPDFTop, 0, 20, 5000)
        Else
            genPDFExport(System.IO.Path.GetTempPath(), "BB " & txtBB.Text & " Short Initial Summary.pdf")
            launchGeneratedPDF(System.IO.Path.GetTempPath() & "BB " & txtBB.Text & " Short Initial Summary.pdf")
        End If
    End Sub
    Private Sub genPDFExport(ByVal outputPath As String, ByVal outputName As String)
        Try
            'Define which template to use
            Dim pdfTemplate As String = "Q:\Warehouse Files\PDF Export Templates\Short Initial Summary.pdf"
            'combine the output file name with the user's temp file path location so we can create and fill the PDF
            Dim filledPDF As String = outputPath & outputName

            'Use the PDF API to start the the new file
            Dim pdfReader As PdfReader = New PdfReader(pdfTemplate)
            Dim pdfStamper As New PdfStamper(pdfReader, New FileStream(filledPDF, FileMode.Create))
            Dim pdfFormFields As AcroFields = pdfStamper.AcroFields

            'Fill the fields with values
            pdfFormFields.SetField("Name", txtName.Text)
            pdfFormFields.SetField("BB", txtBB.Text)
            pdfFormFields.SetField("SubNum", txtSubNum.Text)
            pdfFormFields.SetField("Location", cmbAutLoc.Text)
            If dtDate.Text <> "  /  /" Then
                pdfFormFields.SetField("Date of Summary", dtDate.Text)
            End If
            pdfFormFields.SetField("Summary", txtSummary.Text)
            pdfFormFields.SetField("Harrys Notes", txtHarryText.Text)
            If selectedPath = 1 Then
                pdfFormFields.SetField("chkPath1", "Yes")
            End If
            If selectedPath = 2 Then
                pdfFormFields.SetField("chkPath2", "Yes")
            End If
            If selectedPath = 3 Then
                pdfFormFields.SetField("chkPath3", "Yes")
            End If

            'Flatten the form to dissuade manual editing of outputs
            pdfStamper.FormFlattening = True

            'Close the stamper (to finalize the Filled PDF)
            pdfStamper.Close()
            pdfReader.Dispose()

        Catch ex As Exception
            ExceptionHandler.CatchWindowsException(ex)
        End Try
    End Sub
    Private Sub launchGeneratedPDF(ByVal FileLocationAndName As String)
        Dim P As New System.Diagnostics.Process
        Dim s As New System.Diagnostics.ProcessStartInfo(FileLocationAndName)
        s.UseShellExecute = True
        s.WindowStyle = ProcessWindowStyle.Normal
        P.StartInfo = s
        P.Start()
    End Sub

    'Email trigger sub (sends initial/updated SIS on save)
    Private Sub emailShortInitialSummary(ByVal emailType As String)
        'Create the PDF doc
        genPDFExport("Q:\Warehouse Files\TempFiles\", "BB " & txtBB.Text & " Short Initial Summary.pdf")
        'Generate the email
        Dim emailCMD As New SqlCommand
        emailCMD.Connection = WarehouseShell.conn
        If emailType = "New" Then
            emailCMD.CommandText = "EXEC mailWithAttach " &
                "@myRecipients = 'dushyant.purohit@mountsinai.org'" &
                ", @myCopy_Recipients = 'vahram.haroutunian@mssm.edu; michael.wysocki@mssm.edu; stephen.panopoulos@mssm.edu; joshua.arneson@mssm.edu'" &
                ", @mySubject = '[SECURE] BB " & txtBB.Text & " NEW Short Initial Summary'" &
                ", @myBody = 'Please find attached NEW short initial summary for BB " & txtBB.Text & "'" &
                ", @myFile_Attachments = 'Y:\Shares\Share\Warehouse Files\TempFiles\BB " & txtBB.Text & " Short Initial Summary.pdf'" &
                ", @mySensitivity = 'Confidential'"
            emailCMD.ExecuteNonQuery()
        Else
            emailCMD.CommandText = "EXEC mailWithAttach " &
                "@myRecipients = 'dushyant.purohit@mountsinai.org'" &
                ", @myCopy_Recipients = 'vahram.haroutunian@mssm.edu; michael.wysocki@mssm.edu; stephen.panopoulos@mssm.edu; joshua.arneson@mssm.edu'" &
                ", @mySubject = '[SECURE] BB " & txtBB.Text & " UPDATED Short Initial Summary'" &
                ", @myBody = 'Please find attached UPDATED short initial summary for BB " & txtBB.Text & "'" &
                ", @myFile_Attachments = 'Y:\Shares\Share\Warehouse Files\TempFiles\BB " & txtBB.Text & " Short Initial Summary.pdf'" &
                ", @mySensitivity = 'Confidential'"
            emailCMD.ExecuteNonQuery()
        End If
        'Delete the temp file used as attachment
        System.IO.File.Delete("Q:\Warehouse Files\TempFiles\BB " & txtBB.Text & " Short Initial Summary.pdf")
    End Sub

    Private Function preSaveValidation() As Boolean
        Dim result As Boolean = True
        If txtSummary.Text = "" Then
            result = False
        End If
        Return result
    End Function

    'Imported IFormMethods interface methods (some used, some not, based on which form is using the interface)
    Public Sub Parent1(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Public Sub Show1() Implements IFormMethods.Show
        Show()
    End Sub
    Public Sub ShowPHI(val As Boolean) Implements IFormMethods.ShowPHI
        If val = True Then
            txtName.PasswordChar = ""
        Else
            txtName.PasswordChar = "*"
        End If
    End Sub
    Public Sub TopLevel1(val As Boolean) Implements IFormMethods.TopLevel
        TopLevel = val
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
        btnShortInitialSummaryBottom.PerformClick()
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class