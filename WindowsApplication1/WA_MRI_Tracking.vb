Imports iTextSharp.text.pdf

Public Class WA_MRI_Tracking
    Implements IFormMethods

    Private formTables As New DataSet 'Holds the returned form data from the database for edit/view modes

    Private Sub WA_MRI_Tracking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_MRI_Tracking")
        enableInputFields(False)
        If Database.ExistingRecordCheck("MRI_Tracking", "SubNum = " & WarehouseShell.SubNum) Then
            'Load the form data
            loadExistingData()
            Save.Text = "Edit"
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        Else
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            Save.Text = "Edit"
        End If
    End Sub

    Private Sub enableInputFields(ByVal val As Boolean)
        PreppedForShip.Enabled = val
        DroppedOffDate.ReadOnly = Not val
        ExpectedReturnDate.ReadOnly = Not val
        ActualReturnDate.ReadOnly = Not val
    End Sub

    Private Sub loadExistingData()
        'Grab the record for this subnum
        'Long-form return table because dates and times must be converted.
        formTables.Tables.Add(Database.ReturnTable("MRI_Tracking", , "SubNum = " & WarehouseShell.SubNum))
        'Apply the existing values to the input fields
        PreppedForShip.setValue(formTables, "MRI_Tracking", "PreppedForShip")
        DroppedOffDate.setValue(formTables, "MRI_Tracking", "DroppedOffDate")
        ExpectedReturnDate.setValue(formTables, "MRI_Tracking", "ExpectedReturnDate")
        ActualReturnDate.setValue(formTables, "MRI_Tracking", "ActualReturnDate")
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_MRI_Tracking", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                enableInputFields(True)
                Save.Text = "Save"
                'set default dates based off of existing dates
                If PreppedForShip.Checked And DroppedOffDate.Text = "  /  /" Then
                    DroppedOffDate.Text = Now()
                ElseIf DroppedOffDate.Text <> "  /  /" And ActualReturnDate.Text = "  /  /" Then
                    ActualReturnDate.Text = Format(Now(), "MM/dd/yyyy")
                End If
            Else
                MsgBox("You do not have permission to edit this form.", MsgBoxStyle.OkOnly, "Warning")
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If User.PermissionCheck("WA_MRI_Tracking", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
                enableInputFields(True)
                Save.Text = "Save"
            Else
                MsgBox("You do not have permission to create this form.", MsgBoxStyle.OkOnly, "Warning")
            End If
        Else
            Dim sqlCommand As New SqlCommand
            sqlCommand.Connection = WarehouseShell.conn
            Dim parameters = "@SubNum = " & WarehouseShell.SubNum &
                ", @PreppedForShip = " & PreppedForShip.getSQLValue() &
                ", @DroppedOffDate = " & DroppedOffDate.getSQLValue() &
                ", @ExpectedReturnDate = " & ExpectedReturnDate.getSQLValue() &
                ", @ActualReturnDate = " & ActualReturnDate.getSQLValue() & ";"
            If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                sqlCommand.CommandText = "EXEC dbo.modMRI_TrackingRecord @Action = 1, " & parameters
                sqlCommand.ExecuteScalar()
                MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                sqlCommand.CommandText = "EXEC dbo.modMRI_TrackingRecord @Action = 2, " & parameters
                sqlCommand.ExecuteScalar()
                MessageBox.Show("Record successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
            enableInputFields(False)
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            Save.Text = "Edit"
        End If
    End Sub

    Private Sub Export_Click(sender As Object, e As EventArgs) Handles Export.Click
        Try
            formTables.Tables.Add(Database.ReturnTable("AutopsyFaceSheet", , "SubNum = " & WarehouseShell.SubNum))
            formTables.Tables.Add(Database.ReturnTable("Subject", "FirstName, LastName, SSN, convert(varchar, DoB, 101) as DoB, SexLabel as Sex, RaceLabel as Race", "SubNum = " & WarehouseShell.SubNum))
            'Define which template to use
            Dim pdfTemplate As String = "Q:\Warehouse Files\PDF Export Templates\Autopsy Face Sheet.pdf"
            'Define the output file name
            Dim outputFileName As String = "BB " & formTables.Tables("AutopsyFaceSheet").Rows(0).Item("BB").ToString & " Autopsy Face Sheet.pdf"
            'combine the output file name with the user's temp file path location so we can create and fill the PDF
            Dim filledPDF As String = IO.Path.GetTempPath() & outputFileName

            'Use the PDF API to start the the new file
            Dim pdfReader As PdfReader = New PdfReader(pdfTemplate)
            pdfReader.SelectPages("1")
            Dim pdfStamper As New PdfStamper(pdfReader, New FileStream(filledPDF, FileMode.Create))
            Dim pdfFormFields As AcroFields = pdfStamper.AcroFields

            'Fill the fields with values
            pdfFormFields.SetField("BB", formTables.Tables("AutopsyFaceSheet").Rows(0).Item("BB").ToString)
            pdfFormFields.SetField("Sex", formTables.Tables("Subject").Rows(0).Item("Sex").ToString)
            pdfFormFields.SetField("Race", formTables.Tables("Subject").Rows(0).Item("Race").ToString)
            pdfFormFields.SetField("OthID", formTables.Tables("AutopsyFaceSheet").Rows(0).Item("ExternalID").ToString)
            pdfFormFields.SetField("TimeOfDeath", formTables.Tables("AutopsyFaceSheet").Rows(0).Item("TimeOfDeath").ToString)
            pdfFormFields.SetField("TimeOnIce", formTables.Tables("AutopsyFaceSheet").Rows(0).Item("TimeOnIce").ToString)
            pdfFormFields.SetField("PMI", formTables.Tables("AutopsyFaceSheet").Rows(0).Item("PMI").ToString)
            pdfFormFields.SetField("PrimCauseDeath", formTables.Tables("AutopsyFaceSheet").Rows(0).Item("PrimCauseDeath").ToString)
            pdfFormFields.SetField("SecCauseDeath", formTables.Tables("AutopsyFaceSheet").Rows(0).Item("SecCauseDeath").ToString)
            pdfFormFields.SetField("TempDiagnosis", formTables.Tables("AutopsyFaceSheet").Rows(0).Item("TempDx").ToString)
            pdfFormFields.SetField("TotalBrainWeight", formTables.Tables("AutopsyFaceSheet").Rows(0).Item("BrainWtTot").ToString)
            pdfFormFields.SetField("RightBrainWeight", formTables.Tables("AutopsyFaceSheet").Rows(0).Item("BrainWtRt").ToString)
            pdfFormFields.SetField("LeftBrainWeight", formTables.Tables("AutopsyFaceSheet").Rows(0).Item("BrainWtLt").ToString)
            pdfFormFields.SetField("CerBsWeight", formTables.Tables("AutopsyFaceSheet").Rows(0).Item("BrainWtCerBS").ToString)
            pdfFormFields.SetField("AutopsyNotes", formTables.Tables("AutopsyFaceSheet").Rows(0).Item("Notes").ToString)

            'Flatten the form to dissuade manual editing of outputs
            pdfStamper.FormFlattening = True

            'Close the stamper (to finalize the Filled PDF)
            pdfStamper.Close()
            pdfReader.Dispose()

            'clean up the extra formTables
            formTables.Tables.Remove("Subject")
            formTables.Tables.Remove("AutopsyFaceSheet")

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
        Save.PerformClick()
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class