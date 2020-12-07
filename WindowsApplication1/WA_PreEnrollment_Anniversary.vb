Imports iTextSharp.text.pdf

Public Class WA_PreEnrollment_Anniversary
    Implements IFormMethods
    Private formTables As New DataSet

    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
    End Sub
    Public Sub ShowPHI(val As Boolean) Implements IFormMethods.ShowPHI
        'TODO: Code here to show/hide PHI
    End Sub
    Public Sub TopLevel(val As Boolean) Implements IFormMethods.TopLevel
    End Sub
    Private Sub IFormMethods_Parent(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Private Sub IFormMethods_Show() Implements IFormMethods.Show
        Show()
    End Sub

    Private Sub WA_PreEnrollment_Anniversary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formTables.Tables.Add(Database.ReturnTable("viewPreEnrollments", "SubNum, SSN, SalutationLabel, [First Name], Middle, [Last Name], DoB, [Date Interested], DonationTypeValue, Address1, Address2, City, State, Zip, HomePhone, MobilePhone, Email, PrefMethContactValue, SexValue", "MONTH([Date Interested]) = MONTH(GETDATE()) and YEAR([Date Interested]) <> YEAR(GETDATE()) and [Date of Death] is null", "[Date Interested]"))
        dgvPreEnrollmentAnniversary.DataSource = formTables.Tables("viewPreEnrollments")
        dgvPreEnrollmentAnniversary.Columns("SalutationLabel").Visible = False
        dgvPreEnrollmentAnniversary.Columns("DonationTypeValue").Visible = False
        dgvPreEnrollmentAnniversary.Columns("SSN").Visible = False
        dgvPreEnrollmentAnniversary.Columns("Middle").Visible = False
        dgvPreEnrollmentAnniversary.Columns("DoB").Visible = False
        dgvPreEnrollmentAnniversary.Columns("HomePhone").Visible = False
        dgvPreEnrollmentAnniversary.Columns("MobilePhone").Visible = False
        dgvPreEnrollmentAnniversary.Columns("Email").Visible = False
        dgvPreEnrollmentAnniversary.Columns("PrefMethContactValue").Visible = False
        dgvPreEnrollmentAnniversary.Columns("SexValue").Visible = False
        dgvPreEnrollmentAnniversary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub btnGenMailers_Click(sender As Object, e As EventArgs) Handles btnGenMailers.Click
        If formTables.Tables("viewPreEnrollments").Rows.Count > 0 Then
            MsgBox("Please allow a minute or two for this operation to complete. When complete, you will see another message directing you to the location where you can find the generated letters.", MsgBoxStyle.OkOnly)
            For Each row As DataRow In formTables.Tables("viewPreEnrollments").Rows
                GenAnniversaryMailer(row.Item("First Name").ToString, row.Item("Last Name").ToString)
                GenPreEnrollmentCard(row)
                GenNokMailer(row)
            Next
            MsgBox("Please go to 'Q Drive > Warehouse Files > Data Warehouse Exports > PreEnrollment Anniversary Mailers' and print the created mailers. REMEMBER TO DELETE the mailers after they have been printed to avoid sending duplicate mailers next month!!!", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub GenAnniversaryMailer(ByVal FirstName As String, ByVal LastName As String)
        Try
            'Define which template to use
            Dim pdfTemplate As String = "Q:\Warehouse Files\PDF Export Templates\PreEnrollment Anniversary Letter.pdf"
            'Define the output file name
            Dim outputFileName As String = FirstName & " " & LastName & " PreEnrollment Anniversary Letter.pdf"
            'combine the output file name with the user's temp file path location so we can create and fill the PDF
            Dim filledPDF As String = "Q:\Warehouse Files\Data Warehouse Exports\PreEnrollment Anniversary Mailers\" & outputFileName

            'Use the PDF API to start the the new file
            Dim pdfReader As PdfReader = New PdfReader(pdfTemplate)
            Dim pdfStamper As New PdfStamper(pdfReader, New FileStream(filledPDF, FileMode.Create))
            Dim pdfFormFields As AcroFields = pdfStamper.AcroFields

            'Fill the fields with values
            pdfFormFields.SetField("header", "Dear " & FirstName & " " & LastName & ",")

            'Flatten the form to dissuade manual editing of outputs
            pdfStamper.FormFlattening = True

            'Close the stamper (to finalize the Filled PDF)
            pdfStamper.Close()
            pdfReader.Dispose()
        Catch ex As Exception
            ExceptionHandler.CatchWindowsException(ex)
        End Try
    End Sub
    Private Sub GenPreEnrollmentCard(ByVal row As DataRow)
        Try
            'Define which template to use
            Dim pdfTemplate As String = "Q:\Warehouse Files\PDF Export Templates\NBTR Enrollment Card Template.pdf"
            'Define the output file name
            Dim outputFileName As String = row.Item("First Name").ToString & " " & row.Item("Last Name").ToString & " NBTR Enrollment Card.pdf"
            'combine the output file name with the user's temp file path location so we can create and fill the PDF
            Dim filledPDF As String = "Q:\Warehouse Files\Data Warehouse Exports\PreEnrollment Anniversary Mailers\" & outputFileName

            'Use the PDF API to start the the new file
            Dim pdfReader As PdfReader = New PdfReader(pdfTemplate)
            Dim pdfStamper As New PdfStamper(pdfReader, New FileStream(filledPDF, FileMode.Create))
            Dim pdfFormFields As AcroFields = pdfStamper.AcroFields

            'Fill the fields with values
            pdfFormFields.SetField("Prefix", row.Item("SalutationLabel").ToString)
            Dim ssn As String = row.Item("SSN").ToString
            If ssn.Length >= 4 Then
                pdfFormFields.SetField("SSN", ssn.Substring(ssn.Length - 4))
            End If

            pdfFormFields.SetField("FirstName", row.Item("First Name").ToString)
            pdfFormFields.SetField("Middle", row.Item("Middle").ToString)
            pdfFormFields.SetField("LastName", row.Item("Last Name").ToString)
            pdfFormFields.SetField("Address1", row.Item("Address1").ToString)
            pdfFormFields.SetField("Address2", row.Item("Address2").ToString)
            pdfFormFields.SetField("City", row.Item("City").ToString)
            pdfFormFields.SetField("State", row.Item("State").ToString)
            pdfFormFields.SetField("Zip", row.Item("Zip").ToString)

            'reduce home phone to numbers only and apply to PDF if appropriate
            Dim homePhone As String = row.Item("HomePhone").ToString
            homePhone = RegularExpressions.Regex.Replace(homePhone, "[^\d]", "")
            If homePhone.Length = 10 Then
                pdfFormFields.SetField("PhoneAreaCode", homePhone.Substring(0, 3))
                pdfFormFields.SetField("PhonePrefix", homePhone.Substring(3, 3))
                pdfFormFields.SetField("PhoneNumber", homePhone.Substring(6, 4))
            End If

            'reduce mobile phone to numbers only and apply to PDF if appropriate
            Dim mobilePhone As String = row.Item("MobilePhone").ToString
            mobilePhone = RegularExpressions.Regex.Replace(mobilePhone, "[^\d]", "")
            If mobilePhone.Length = 10 Then
                pdfFormFields.SetField("MobileAreaCode", mobilePhone.Substring(0, 3))
                pdfFormFields.SetField("MobilePrefix", mobilePhone.Substring(3, 3))
                pdfFormFields.SetField("MobileNumber", mobilePhone.Substring(6, 4))
            End If
            pdfFormFields.SetField("Email", row.Item("Email").ToString)

            If Not IsDBNull(row.Item("DoB")) Then
                Dim dob As Date = row.Item("DoB")
                pdfFormFields.SetField("DobMonth", DatePart(DateInterval.Month, dob).ToString)
                pdfFormFields.SetField("DobDay", DatePart(DateInterval.Day, dob).ToString)
                pdfFormFields.SetField("DobYear", DatePart(DateInterval.Year, dob).ToString)
            End If

            pdfFormFields.SetField("Male", row.Item("SexValue").ToString)
            pdfFormFields.SetField("Female", row.Item("SexValue").ToString)

            pdfFormFields.SetField("BrainOnly", row.Item("DonationTypeValue").ToString)
            pdfFormFields.SetField("BrainAndSpinalCord", row.Item("DonationTypeValue").ToString)

            'Flatten the form to dissuade manual editing of outputs
            pdfStamper.FormFlattening = True

            'Close the stamper (to finalize the Filled PDF)
            pdfStamper.Close()
            pdfReader.Dispose()
        Catch ex As Exception
            ExceptionHandler.CatchWindowsException(ex)
        End Try
    End Sub
    Private Sub GenNokMailer(ByVal row As DataRow)
        Try
            'Define which template to use
            Dim pdfTemplate As String = "Q:\Warehouse Files\PDF Export Templates\NBTR NOK Designation Template.pdf"
            'Define the output file name
            Dim outputFileName As String = row.Item("First Name").ToString & " " & row.Item("Last Name").ToString & " NoK Designation.pdf"
            'combine the output file name with the user's temp file path location so we can create and fill the PDF
            Dim filledPDF As String = "Q:\Warehouse Files\Data Warehouse Exports\PreEnrollment Anniversary Mailers\" & outputFileName

            'Use the PDF API to start the the new file
            Dim pdfReader As PdfReader = New PdfReader(pdfTemplate)
            Dim pdfStamper As New PdfStamper(pdfReader, New FileStream(filledPDF, FileMode.Create))
            Dim pdfFormFields As AcroFields = pdfStamper.AcroFields

            'Grab the associated NoK record
            formTables.Tables.Add(Database.ReturnTable("NoK", , "SubNum = " & row.Item("SubNum").ToString))
            Dim NokRecord As DataRow = formTables.Tables("NoK").Rows(0)

            'Fill the fields with values
            pdfFormFields.SetField("FirstName", row.Item("First Name").ToString)
            pdfFormFields.SetField("Middle", row.Item("Middle").ToString)
            pdfFormFields.SetField("LastName", row.Item("Last Name").ToString)
            pdfFormFields.SetField("NokName", NokRecord.Item("NoKName").ToString)

            Dim homePhone As String = NokRecord.Item("NoKHomePhone").ToString
            homePhone = RegularExpressions.Regex.Replace(homePhone, "[^\d]", "")
            If homePhone.Length = 10 Then
                pdfFormFields.SetField("NokHomeArea", homePhone.Substring(0, 3))
                pdfFormFields.SetField("NokHomePrefix", homePhone.Substring(3, 3))
                pdfFormFields.SetField("NokHomeNumber", homePhone.Substring(6, 4))
            End If

            Dim MobilePhone As String = NokRecord.Item("NoKMobilePhone").ToString
            MobilePhone = RegularExpressions.Regex.Replace(MobilePhone, "[^\d]", "")
            If MobilePhone.Length = 10 Then
                pdfFormFields.SetField("NokMobileArea", MobilePhone.Substring(0, 3))
                pdfFormFields.SetField("NokMobilePrefix", MobilePhone.Substring(3, 3))
                pdfFormFields.SetField("NokMobileNumber", MobilePhone.Substring(6, 4))
            End If

            pdfFormFields.SetField("NokEmail", NokRecord.Item("NoKEmail").ToString)

            If NokRecord.Item("NoKName").ToString <> "" Then
                Dim NokRel As String = NokRecord.Item("NokRelation").ToString
                If NokRel = "18" Then
                    pdfFormFields.SetField("NokHCP", "1")
                ElseIf NokRel = "5" Or NokRel = "138" Or NokRel = "4" Then
                    pdfFormFields.SetField("NokSpouse", "1")
                ElseIf NokRel = "2" Or NokRel = "16" Or NokRel = "1" Or NokRel = "15" Then
                    pdfFormFields.SetField("NokChild", "1")
                ElseIf NokRel = "24" Or NokRel = "23" Or NokRel = "28" Then
                    pdfFormFields.SetField("NokParent", "1")
                ElseIf NokRel = "8" Or NokRel = "9" Or NokRel = "6" Or NokRel = "7" Then
                    pdfFormFields.SetField("NokSibling", "1")
                ElseIf NokRel = "17" Then
                    pdfFormFields.SetField("NokGuardian", "1")
                Else
                    pdfFormFields.SetField("NokOther", "1")
                End If
            End If

            pdfFormFields.SetField("NokAdd1", NokRecord.Item("NoKAddress1").ToString)
            pdfFormFields.SetField("NokAdd2", NokRecord.Item("NoKAddress2").ToString)
            pdfFormFields.SetField("NokCityStateZip", NokRecord.Item("NoKCity").ToString & ", " & NokRecord.Item("NoKState").ToString & " " & NokRecord.Item("NoKZip").ToString)

            pdfFormFields.SetField("POCName", NokRecord.Item("AltPOCName").ToString)

            Dim PocHomePhone As String = NokRecord.Item("AltPOCHomePhone").ToString
            PocHomePhone = RegularExpressions.Regex.Replace(PocHomePhone, "[^\d]", "")
            If PocHomePhone.Length = 10 Then
                pdfFormFields.SetField("PocHomeArea", PocHomePhone.Substring(0, 3))
                pdfFormFields.SetField("PocHomePrefix", PocHomePhone.Substring(3, 3))
                pdfFormFields.SetField("PocHomeNumber", PocHomePhone.Substring(6, 4))
            End If

            Dim PocMobilePhone As String = NokRecord.Item("AltPOCMobilePhone").ToString
            PocMobilePhone = RegularExpressions.Regex.Replace(PocMobilePhone, "[^\d]", "")
            If PocMobilePhone.Length = 10 Then
                pdfFormFields.SetField("PocMobileArea", PocMobilePhone.Substring(0, 3))
                pdfFormFields.SetField("PocMobilePrefix", PocMobilePhone.Substring(3, 3))
                pdfFormFields.SetField("PocMobileNumber", PocMobilePhone.Substring(6, 4))
            End If

            pdfFormFields.SetField("PocEmail", NokRecord.Item("AltPOCEmail").ToString)

            If NokRecord.Item("AltPOCName").ToString <> "" Then
                Dim POCRel As String = NokRecord.Item("AltPOCRelation").ToString
                If POCRel = "18" Then
                    pdfFormFields.SetField("PocHCP", "1")
                ElseIf POCRel = "5" Or POCRel = "138" Or POCRel = "4" Then
                    pdfFormFields.SetField("PocSpouse", "1")
                ElseIf POCRel = "2" Or POCRel = "16" Or POCRel = "1" Or POCRel = "15" Then
                    pdfFormFields.SetField("PocChild", "1")
                ElseIf POCRel = "8" Or POCRel = "9" Or POCRel = "6" Or POCRel = "7" Then
                    pdfFormFields.SetField("PocSibling", "1")
                ElseIf POCRel = "17" Then
                    pdfFormFields.SetField("PocGuardian", "1")
                Else
                    pdfFormFields.SetField("PocOther", "1")
                End If
            End If

            pdfFormFields.SetField("PocAdd1", NokRecord.Item("AltPOCAddress1").ToString)
            pdfFormFields.SetField("PocAdd2", NokRecord.Item("AltPOCAddress2").ToString)
            pdfFormFields.SetField("PocCityStateZip", NokRecord.Item("AltPOCCity").ToString & ", " & NokRecord.Item("AltPOCState").ToString & " " & NokRecord.Item("AltPOCZip").ToString)

            formTables.Tables.Remove("NoK")
            'Flatten the form to dissuade manual editing of outputs
            pdfStamper.FormFlattening = True

            'Close the stamper (to finalize the Filled PDF)
            pdfStamper.Close()
            pdfReader.Dispose()
        Catch ex As Exception
            ExceptionHandler.CatchWindowsException(ex)
        End Try
    End Sub
End Class