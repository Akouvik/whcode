Imports iTextSharp.text.pdf

Public Class PU_NeuropathRequest
    Private formTables As New DataSet
    Public NPString1 As String 'used in the generation of NP Reports (to be mialed)
    Private BB As Decimal
    Private RecordID As Integer


    Public Sub New(ByVal myBB As Decimal, Optional ByVal myRecordID As Integer = 0)
        InitializeComponent()
        BB = myBB
        RecordID = myRecordID
    End Sub

    Private Sub PU_NeuropathRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formTables.Tables.Add(Database.ReturnTable("lkpNPReqType"))
        formTables.Tables.Add(Database.ReturnTable("lkpNPReqDelMethod"))
        formTables.Tables.Add(Database.ReturnTable("refUser", "RaterID, Name", "Active = 1"))
        formTables.Tables.Add(Database.ReturnTable("lkpSalutation"))
        cmbReqType.assignLookup(formTables, "lkpNPReqType")
        cmbDelMethod.assignLookup(formTables, "lkpNPReqDelMethod")
        cmbSentBy.assignLookup(formTables, "refUser", "RaterID", "Name", , "Name")
        cmbSalutation.assignLookup(formTables, "lkpSalutation")
        If RecordID <> 0 Then 'user is attempting to view/edit an existing request
            'set existing values
            formTables.Tables.Add(Database.ReturnTable("NeuropathRequests", , "RecordID = " & RecordID))
            cmbReqType.setValue(formTables, "NeuropathRequests", "RequestType")
            cmbReqType.Enabled = False
            cmbDelMethod.setValue(formTables, "NeuropathRequests", "DeliveryMethod")
            dtReqDate.setValue(formTables, "NeuropathRequests", "RequestDate")
            txtConsentor.setValue(formTables, "NeuropathRequests", "Consentor")
            txtName.setValue(formTables, "NeuropathRequests", "Name")
            cmbSalutation.setValue(formTables, "NeuropathRequests", "Salutation")
            txtAdd1.setValue(formTables, "NeuropathRequests", "Address1")
            txtAdd2.setValue(formTables, "NeuropathRequests", "Address2")
            txtAdd3.setValue(formTables, "NeuropathRequests", "Address3")
            txtAdd4.setValue(formTables, "NeuropathRequests", "Address4")
            txtCity.setValue(formTables, "NeuropathRequests", "City")
            txtState.setValue(formTables, "NeuropathRequests", "State")
            txtZip.setValue(formTables, "NeuropathRequests", "Zip")
            txtEmail.setValue(formTables, "NeuropathRequests", "Email")
            txtPhone.setValue(formTables, "NeuropathRequests", "Phone")
            txtFax.setValue(formTables, "NeuropathRequests", "Fax")
            dtDateSent.setValue(formTables, "NeuropathRequests", "DateSent")
            cmbSentBy.setValue(formTables, "NeuropathRequests", "SentBy")
            'set mailer buttons
            setMailerButtons()
            'set title text
            Text = "View / Edit Neuropath Request"
            'set Next of Kin checkbox
            SetNextOfKin()
        Else
            'set title text
            Text = "Add New Neuropath Request"
            'default Request Date to today
            cmbDelMethod.SelectedValue = -1
            cmbSalutation.SelectedValue = -1
            dtReqDate.Text = Format(Now(), "MM-dd-yyyy")
            txtConsentor.Text = getDefaultConsentor()
            cmbSentBy.SelectedValue = -1
            btnMailer.Visible = False
            btnMailerDelete.Visible = False
        End If
        loadFileData()
    End Sub

    Private Sub SetNextOfKin()
        If WarehouseShell.userName = "harouv01" Or WarehouseShell.userName = "arnesj01" Or WarehouseShell.userName = "koueda01" Then
            NextOfKin.Visible = True
            If Database.ExistingRecordCheck("NoK", "SubNum = " & WarehouseShell.SubNum) Then
                Dim NoK As String = Database.ReturnString("NoK", "NoKName", "SubNum = " & WarehouseShell.SubNum)
                If formTables.Tables("NeuropathRequests").Rows(0).Item("Consentor").ToString <> NoK Then
                    NextOfKin.Checked = False
                Else
                    NextOfKin.Checked = True
                End If
            Else
                NextOfKin.Checked = False
            End If
        End If
    End Sub

    Private Sub loadFileData()
        If Database.ExistingRecordCheck("fileNeuropathFull", "SubNum = " & WarehouseShell.SubNum) Then
            btnNeuropath.BackColor = Color.Chartreuse
            btnNeuropath.Text = "View Neuropath"
        Else
            btnNeuropath.BackColor = Color.Linen
            btnNeuropath.Text = "Upload Neuropath"
        End If
    End Sub

    Private Sub setMailerButtons()
        Dim cmd As New SqlCommand("", WarehouseShell.conn)
        Dim query As String = ""
        If cmbReqType.SelectedValue = 1 Then 'Summary Request
            If Database.ExistingRecordCheck("fileNeuropathSummary", "SequenceNum = " & RecordID) Then
                btnMailer.BackColor = Color.Chartreuse
                btnMailer.Text = "View Summary"
                btnMailerDelete.Visible = True
            Else
                btnMailer.BackColor = Color.Linen
                btnMailer.Text = "Generate Summary"
                btnMailerDelete.Visible = False
            End If
        Else
            If Database.ExistingRecordCheck("fileNeuropathFullCoverSheet", "SequenceNum = " & RecordID) Then
                btnMailer.BackColor = Color.Chartreuse
                btnMailer.Text = "View Cover Sheet"
                btnMailerDelete.Visible = True
            Else
                btnMailer.BackColor = Color.Linen
                btnMailer.Text = "Generate Cover Sheet"
                btnMailerDelete.Visible = False
            End If
        End If
    End Sub

    Private Function getDefaultConsentor() As String
        Dim result As String = ""
        If Database.ExistingRecordCheck("AutopsyFaceSheet", "SubNum = " & WarehouseShell.SubNum) Then
            Dim cmd As New SqlCommand("select Consentor from AutopsyFaceSheet where SubNum = " & WarehouseShell.SubNum, WarehouseShell.conn)
            result = cmd.ExecuteScalar()
        End If
        Return result
    End Function

    'File Save/Open Events
    Private Sub btnNeuropath_Click(sender As Object, e As EventArgs) Handles btnNeuropath.Click
        If SubjectFiles1to1.CheckFile("fileNeuropathFull", WarehouseShell.SubNum) Then
            SubjectFiles1to1.OpenFile("fileNeuropathFull", WarehouseShell.SubNum, "BB " & BB & " Full Neuropath Report")
        Else
            SubjectFiles1to1.SaveFile("fileNeuropathFull", WarehouseShell.SubNum)
        End If
        loadFileData()
    End Sub

    Private Sub btnMailer_Click(sender As Object, e As EventArgs) Handles btnMailer.Click
        If cmbReqType.SelectedValue = 1 Then
            If Database.ExistingRecordCheck("fileNeuropathSummary", "SequenceNum = " & RecordID) Then
                SubjectFiles1toMany.OpenFile("fileNeuropathSummary", WarehouseShell.SubNum, "BB " & BB & " Summary Neuropath Report", RecordID)
            Else
                generateSummary()
            End If
        Else
            If Database.ExistingRecordCheck("fileNeuropathFullCoversheet", "SequenceNum = " & RecordID) Then
                SubjectFiles1toMany.OpenFile("fileNeuropathFullCoverSheet", WarehouseShell.SubNum, "BB " & BB & " Full Neuropath Cover Sheet", RecordID)
            Else
                generateNPFullCoverSheet()
            End If
        End If
    End Sub
    Private Sub btnMailerDelete_Click(sender As Object, e As EventArgs) Handles btnMailerDelete.Click
        If SubjectFiles1toMany.CheckDelete() Then
            If cmbReqType.SelectedValue = 1 Then
                SubjectFiles1toMany.DeleteFile("fileNeuropathSummary", WarehouseShell.SubNum, RecordID)
            Else
                SubjectFiles1toMany.DeleteFile("fileNeuropathFullCoverSheet", WarehouseShell.SubNum, RecordID)
            End If
            setMailerButtons()
        End If
    End Sub

    Private Sub generateSummary()
        If WarehouseShell.userName = "harouv01" Or WarehouseShell.userName = "arnesj01" Then
            Dim pu As New PU_NP_SummaryOfFindings
            If pu.ShowDialog() = Windows.Forms.DialogResult.OK Then
                NPString1 = pu.myString
                If formTables.Tables.Contains("Subject") Then
                    formTables.Tables.Remove("Subject")
                End If
                formTables.Tables.Add(Database.ReturnTable("Subject", "concat(FirstName, ' ', LastName) as Name, SexLabel as Sex", "SubNum = " & WarehouseShell.SubNum))

                Dim dateString As String = Format(Date.Now, "MMMM dd, yyyy").ToString

                Dim addressString As String =
                    IIf(cmbSalutation.SelectedValue <> -1, cmbSalutation.Text & " ", "") & txtName.Text & vbNewLine &
                    IIf(txtAdd1.Text = "", "", txtAdd1.Text & vbNewLine) &
                    IIf(txtAdd2.Text = "", "", txtAdd2.Text & vbNewLine) &
                    IIf(txtAdd3.Text = "", "", txtAdd3.Text & vbNewLine) &
                    IIf(txtAdd4.Text = "", "", txtAdd4.Text & vbNewLine) &
                    IIf(txtCity.Text = "", "", txtCity.Text & ", ") & IIf(txtState.Text = "", "", txtState.Text & " ") & IIf(txtZip.Text = "", "", txtZip.Text)

                Dim dearWhoString As String = "Dear " & IIf(cmbSalutation.SelectedValue <> -1, cmbSalutation.Text & " ", "") & txtName.Text & ","

                Dim para1String As String = "The Icahn School of Medicine at Mount Sinai, Clinical and Biological Studies of the Brain, would like to share the findings of the brain autopsy on " &
                                           formTables.Tables("Subject").Rows(0).Item("Name").ToString & " that was performed following " & IIf(formTables.Tables("Subject").Rows(0).Item("Sex").ToString = "Male (1)", "his", "her") & " death."

                Dim para2String As String = "The neuropathology assessment of " & formTables.Tables("Subject").Rows(0).Item("Name").ToString &
                    "'s brain has now been completed and our team has met to review the medical records and to discuss the findings. The neuropathological examination of the brain revealed " & NPString1 & vbNewLine &
                    vbNewLine &
                    "We would be happy to send a copy of the detailed medical neuropathology report to a physician that you designate. " & vbNewLine &
                    vbNewLine &
                    "We want to once again express our appreciation for your participation in our program and to assure you that we will continue to work hard to learn all that we can in order to help enhance psychological, mental and brain health." & vbNewLine &
                    vbNewLine &
                    "Sincerely," & vbNewLine &
                    vbNewLine &
                    "V. Haroutunian, Ph.D." & vbNewLine &
                    "Director, Mount Sinai NIH Brain and Tissue Repository" & vbNewLine &
                    "For the Clinical and Biological Studies of the Brain team"
                Try
                    'Define which template to use
                    Dim pdfTemplate As String = "Q:\Warehouse Files\PDF Export Templates\NP Summary of Findings Template.pdf"
                    'Define the output file name
                    Dim outputFileName As String = "BB " & BB & " Summary of Findings.pdf"
                    'combine the output file name with the user's temp file path location so we can create and fill the PDF
                    Dim filledPDF As String = IO.Path.GetTempPath() & outputFileName

                    'Use the PDF API to start the the new file
                    Dim pdfReader As PdfReader = New PdfReader(pdfTemplate)
                    Dim pdfStamper As New PdfStamper(pdfReader, New FileStream(filledPDF, FileMode.Create))
                    Dim pdfFormFields As AcroFields = pdfStamper.AcroFields

                    'Fill the fields with values
                    pdfFormFields.SetField("Date", dateString)
                    pdfFormFields.SetField("Address", addressString)
                    pdfFormFields.SetField("DearWho", dearWhoString)
                    pdfFormFields.SetField("Para1", para1String)
                    pdfFormFields.SetField("Para2", para2String)

                    'Flatten the form to dissuade manual editing of outputs
                    pdfStamper.FormFlattening = True

                    'Close the stamper (to finalize the Filled PDF)
                    pdfStamper.Close()
                    pdfStamper.Dispose()
                    pdfReader.Dispose()
                    formTables.Tables.Remove("Subject")

                    saveNPSummary()

                    'Launch the filled PDF for the user
                    Dim P As New Process
                    Dim s As New ProcessStartInfo(filledPDF)
                    s.UseShellExecute = True
                    s.WindowStyle = ProcessWindowStyle.Normal
                    P.StartInfo = s
                    P.Start()
                Catch ex As Exception
                    ExceptionHandler.CatchWindowsException(ex)
                End Try
            End If
            pu.Dispose()
        Else
            MsgBox("This button is reserved for Dr. Haroutunian to create a formatted Summary of Findings.")
        End If
    End Sub
    Private Sub saveNPSummary()
        'Define variables and open FileDialog
        Dim IncomingFile As String = IO.Path.GetTempPath() & "BB " & BB & " Summary of Findings.pdf"
        Dim Destination As String = "Q:\WarehouseTemp\"
        Dim infoReader As FileInfo = Computer.FileSystem.GetFileInfo(IncomingFile)
        Dim FileSize As Integer = Math.Round(infoReader.Length / 1024, 0)

        'If file is image, convert to .png and copy, else copy file as is.

        File.Copy(IncomingFile, Destination & "Temp.pdf", True)
        Dim query As New SqlCommand
        'Add the file to the database
        Dim cmdText As String = "Insert into fileNeuropathSummary" &
                " (SubNum, " &
                "SequenceNum, " &
                "FileData, " &
                "FileExtension, " &
                "FileSizeKB, " &
                "UploadDate) " &
                "values (" &
                WarehouseShell.SubNum & ", " &
                RecordID & ", " &
                " (select * from openrowset(bulk N'Y:\Shares\Share\WarehouseTemp\Temp.pdf', single_blob) as n), " &
                "'.pdf', " &
                FileSize & ", " &
                "'" & Format(Date.Now, "MM-dd-yyyy").ToString() & "');"
        query.CommandText = cmdText
        query.Connection = WarehouseShell.conn
        query.ExecuteNonQuery()
        'Delete the temp file.
        File.Delete(Destination & "Temp.pdf")
        'Update file buttons
        setMailerButtons()
    End Sub

    Private Sub generateNPFullCoverSheet()
        If WarehouseShell.userName = "harouv01" Or WarehouseShell.userName = "arnesj01" Then
            'make sure requisite data is there for file save
            If txtName.Text = "" Then
                MsgBox("Please enter the name (or department) of the person receiving the Full Clinical Neuropath Report.")
                Exit Sub
            End If
            If txtConsentor.Text = "" Then
                MsgBox("Consentor name (person authorizing release of Report) cannot be blank.")
                Exit Sub
            End If

            'grab reference data needed by popup
            formTables.Tables.Add(Database.ReturnTable("Subject", "concat(FirstName, ' ', LastName) as Name, SexLabel as Sex, ADRCCohort", "SubNum = " & WarehouseShell.SubNum))

            Dim pu As New PU_NP_FullClinicalNeuropath(txtName.Text, txtConsentor.Text, formTables.Tables("Subject").Rows(0).Item("Name").ToString)
            If pu.ShowDialog() = Windows.Forms.DialogResult.OK Then
                NPString1 = pu.myString
                Dim bodyString As String = Format(Date.Now, "MMMM dd, yyyy").ToString & vbNewLine & vbNewLine &
                    IIf(cmbSalutation.SelectedValue <> -1, cmbSalutation.Text & " ", "") & txtName.Text & vbNewLine &
                    IIf(txtAdd1.Text <> "", txtAdd1.Text & vbNewLine, "") &
                    IIf(txtAdd2.Text <> "", txtAdd2.Text & vbNewLine, "") &
                    IIf(txtAdd3.Text <> "", txtAdd3.Text & vbNewLine, "") &
                    IIf(txtAdd4.Text <> "", txtAdd4.Text & vbNewLine, "") &
                    IIf(txtCity.Text <> "" And txtState.Text <> "", txtCity.Text & ", " & txtState.Text & " " & txtZip.Text & vbNewLine, "") &
                    vbNewLine &
                    vbNewLine &
                    "Dear " & IIf(cmbSalutation.SelectedValue <> -1, cmbSalutation.Text & " ", "") & txtName.Text &
                    vbNewLine &
                    vbNewLine &
                    NPString1
                Try
                    'Define which template to use
                    Dim pdfTemplate As String = "Q:\Warehouse Files\PDF Export Templates\NP Full Clinical Neuropath Template.pdf"
                    'Define the output file name
                    Dim outputFileName As String = "BB " & BB & " Full Clinical Neuropath Cover Sheet.pdf"
                    'combine the output file name with the user's temp file path location so we can create and fill the PDF
                    Dim filledPDF As String = IO.Path.GetTempPath() & outputFileName

                    'Use the PDF API to start the the new file
                    Dim pdfReader As PdfReader = New PdfReader(pdfTemplate)
                    Dim pdfStamper As New PdfStamper(pdfReader, New FileStream(filledPDF, FileMode.Create))
                    Dim pdfFormFields As AcroFields = pdfStamper.AcroFields

                    'Fill the fields with values
                    pdfFormFields.SetField("Body", bodyString)

                    'Flatten the form to dissuade manual editing of outputs
                    pdfStamper.FormFlattening = True

                    'Close the stamper (to finalize the Filled PDF)
                    pdfStamper.Dispose()
                    pdfReader.Dispose()
                    formTables.Tables.Remove("Subject") 'clean up table added for reference

                    saveNPFullCoverSheet()
                    loadFileData()

                    'Launch the filled PDF for the user
                    Dim P As New Process
                    Dim s As New ProcessStartInfo(filledPDF)
                    s.UseShellExecute = True
                    s.WindowStyle = ProcessWindowStyle.Normal
                    P.StartInfo = s
                    P.Start()
                Catch ex As Exception
                    ExceptionHandler.CatchWindowsException(ex)
                End Try
            End If

            pu.Dispose() 'clean up popup

            Try
                Dim cmd As New SqlCommand("Update NeuropathRequests set MessageString = '" & NPString1 & "' where RecordID = " & RecordID & ";", WarehouseShell.conn)
                cmd.ExecuteNonQuery()
            Catch ex As SqlException
                ExceptionHandler.CatchSQLException(ex)
            End Try
        Else
            MsgBox("This button is reserved for Dr. Haroutunian to create a formatted Summary of Findings.")
        End If
    End Sub
    Private Sub saveNPFullCoverSheet()
        'Define variables
        Dim IncomingFile As String = IO.Path.GetTempPath() & "BB " & BB & " Full Clinical Neuropath Cover Sheet.pdf"
        Dim Destination As String = "Q:\WarehouseTemp\"
        Dim infoReader As FileInfo = My.Computer.FileSystem.GetFileInfo(IncomingFile)
        Dim FileSize As Integer = Math.Round(infoReader.Length / 1024, 0)

        'Copy file to Q drive

        File.Copy(IncomingFile, Destination & "Temp.pdf", True)
        Dim query As New SqlCommand
        'Notice the filepath in the bulk copy is relative to the SERVER and not the local computer.
        Dim cmdText As String = "Insert into fileNeuropathFullCoverSheet" &
                " (SubNum" &
                ", SequenceNum" &
                ", FileData" &
                ", FileExtension" &
                ", FileSizeKB" &
                ", UploadDate) " &
                "values (" &
                WarehouseShell.SubNum & ", " &
                RecordID & ", " &
                " (select * from openrowset(bulk N'Y:\Shares\Share\WarehouseTemp\Temp.pdf', single_blob) as n), " &
                "'.pdf', " &
                FileSize & ", " &
                "'" & Format(Date.Now, "MM-dd-yyyy").ToString() & "');"
        query.CommandText = cmdText
        query.Connection = WarehouseShell.conn
        query.ExecuteNonQuery()
        'Delete the temp file.
        File.Delete(Destination & "Temp.pdf")
        'Update file buttons
        setMailerButtons()
    End Sub

    Private Function preSaveValidation() As Boolean
        Dim result As Boolean = True
        Dim errMsg As String = "The following errors must be corrected before this record can be saved:" & vbNewLine & vbNewLine

        If (cmbDelMethod.SelectedValue = 2 Or cmbDelMethod.SelectedValue = 4) And txtEmail.Text = "" Then
            errMsg += "- If delivery method includes ""Email"", please provide an email address for delivery." & vbNewLine
            result = False
        ElseIf cmbDelMethod.SelectedValue = 3 And txtFax.Text = "" Then
            errMsg += "- If delivery method is ""Fax"", Please provide a fax number for delivery." & vbNewLine
            result = False
        ElseIf cmbDelMethod.SelectedValue = -1 Then
            errMsg += "- A Delivery Method must be selected." & vbNewLine
            result = False
        End If

        If txtConsentor.Text = "" Then
            errMsg += "- Consentor must not be blank. This SHOULD be the person who consented to the donation. If it is not, there must be a VALID reason that this person is able to consent to the release of NP findings." & vbNewLine
            result = False
        End If

        If txtName.Text = "" Then
            errMsg += "- Name(To) must be provided. This name is inserted into the PDF mailer exports (so mind your punctuation!)." & vbNewLine
            result = False
        End If

        If cmbSalutation.SelectedValue = -1 Then
            errMsg += "- Please select salutation." & vbNewLine
            result = False
        End If

        If txtAdd1.Text = "" Then
            errMsg += "- Please provide Address 1." & vbNewLine
            result = False
        End If

        If txtCity.Text = "" Then
            errMsg += "- Please provide City." & vbNewLine
            result = False
        End If

        If txtState.Text = "" Then
            errMsg += "- Please provide State." & vbNewLine
            result = False
        End If

        If txtZip.Text = "" Then
            errMsg += "- Please provide Zip." & vbNewLine
            result = False
        End If

        If result = False Then
            MsgBox(errMsg, MsgBoxStyle.OkOnly, "Error!")
        End If

        Return result
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If preSaveValidation() Then
            Dim cmd As New SqlCommand("", WarehouseShell.conn)
            Dim cmdText As String = "@RecordID = " & RecordID &
                ", @SubNum = " & WarehouseShell.SubNum &
                ", @RequestType = " & cmbReqType.getSQLValue() &
                ", @DeliveryMethod = " & cmbDelMethod.getSQLValue() &
                ", @RequestDate = " & dtReqDate.getSQLValue() &
                ", @Consentor = " & txtConsentor.getSQLValue() &
                ", @Name = " & txtName.getSQLValue() &
                ", @Salutation = " & cmbSalutation.getSQLValue() &
                ", @Address1 = " & txtAdd1.getSQLValue() &
                ", @Address2 = " & txtAdd2.getSQLValue() &
                ", @Address3 = " & txtAdd3.getSQLValue() &
                ", @Address4 = " & txtAdd4.getSQLValue() &
                ", @City = " & txtCity.getSQLValue() &
                ", @State = " & txtState.getSQLValue() &
                ", @Zip = " & txtZip.getSQLValue() &
                ", @Email = " & txtEmail.getSQLValue() &
                ", @Phone = " & txtPhone.getSQLValue() &
                ", @Fax = " & txtFax.getSQLValue() &
                ", @DateSent = " & dtDateSent.getSQLValue() &
                ", @SentBy = " & cmbSentBy.getSQLValue() &
                ", @LastModBy = '" & WarehouseShell.userName & "';"

            If RecordID = 0 Then
                cmd.CommandText = "Exec modNeuropathRequests @Action = 1, " & cmdText
            Else
                cmd.CommandText = "Exec modNeuropathRequests @Action = 2, " & cmdText
            End If

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Record Saved", MsgBoxStyle.OkOnly, "Success!")
                Close()
            Catch ex As SqlException
                ExceptionHandler.CatchSQLException(ex)
            End Try
        End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class