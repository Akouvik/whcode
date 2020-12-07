Imports Microsoft.Office.Interop

Public Class WA_SlideScanBarcodeFile
    Implements IFormMethods

    Private formTables As New DataSet
    Private bs As New BindingSource
    Private maxExistingSeq As Integer = 0
    Private maxEnteredSeq As Integer = 0

    Private Sub WA_SlideScanBarcodeFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        WarehouseShell.highlightSelectedNode("WA_SlideScanBarcodeFile")

        'add combobox values and set default
        formTables.Tables.Add(Database.ReturnTable("lkpSlideStains"))
        cmbStain.assignLookup(formTables, "lkpSlideStains",,,, "Value")
        cmbStain.SelectedValue = 1

        'create working table
        createResultsTable()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If User.PermissionCheck("WA_SlideScanBarcodeFile", "Modify") Then
            If preSaveValidation() Then
                'set existing & entered max sequence nums
                resetSeq()
                setMaxEnteredSeq(txtXENum.Text, intRegion.Text, cmbStain.SelectedValue.ToString)
                setMaxExistingSeq(txtXENum.Text, intRegion.Text, cmbStain.SelectedValue.ToString)
                'get next available sequence num
                Dim SeqNum As Integer = IIf(maxEnteredSeq > maxExistingSeq, maxEnteredSeq + 1, maxExistingSeq + 1)

                'insert new row to datatable
                Dim enteredRow As DataRow = formTables.Tables("results").NewRow()
                enteredRow("XE #") = txtXENum.Text
                enteredRow("RegionNum") = intRegion.Text
                enteredRow("RegionName") = txtRegionName.Text
                enteredRow("StainValue") = cmbStain.SelectedValue.ToString
                enteredRow("Stain") = cmbStain.Text
                enteredRow("Seq #") = SeqNum.ToString
                enteredRow("Stain") = cmbStain.Text
                enteredRow("Barcode Data") = txtXENum.Text & "_" & intRegion.Text & "_" & cmbStain.Text & "_" & SeqNum.ToString
                enteredRow("Stain") = cmbStain.Text
                formTables.Tables("results").Rows.Add(enteredRow)

                'return focus to XE #
                ActiveControl = txtXENum
            End If
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If User.PermissionCheck("WA_SlideScanBarcodeFile", "Modify") Then
            If saveRecords() Then
                generateExcel()
                createResultsTable()
            Else
                'TODO: Handle failed Excel export
            End If
        End If
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        createResultsTable()
        resetSeq()
        txtXENum.Clear()
        intRegion.Clear()
        cmbStain.SelectedValue = 1
        txtXENum.Focus()
    End Sub

    'helper subs
    Private Sub resetSeq()
        maxExistingSeq = 0
        maxEnteredSeq = 0
    End Sub
    Private Sub createResultsTable()
        'clear the table if it already exists
        If formTables.Tables.Contains("results") Then
            formTables.Tables.Remove("results")
        End If

        Dim results As New DataTable("results")
        results.Columns.Add("XE #", Type.GetType("System.String"))
        results.Columns.Add("RegionNum", Type.GetType("System.String"))
        results.Columns.Add("RegionName", Type.GetType("System.String"))
        results.Columns.Add("StainValue", Type.GetType("System.String"))
        results.Columns.Add("Stain", Type.GetType("System.String"))
        results.Columns.Add("Seq #", Type.GetType("System.String"))
        results.Columns.Add("Barcode Data", Type.GetType("System.String"))
        formTables.Tables.Add(results)
        bs.DataSource = formTables.Tables("results")
        dgvResults.DataSource = bs
        dgvResults.Columns("StainValue").Visible = False
        dgvResults.Columns("RegionName").Visible = False

        resetSeq()
        ActiveControl = txtXENum
    End Sub
    Private Function preSaveValidation() As Boolean
        Dim result As Boolean = True
        Dim errMsg As String = "Please correct the following error(s) and try again:" & vbNewLine & vbNewLine

        If txtXENum.Text = "" Then
            errMsg += "- Please enter an XE number." & vbNewLine
            result = False
        ElseIf Not txtXENum.Text Like "XE##-###" Then
            errMsg += "- This is not a valid XE # format (i.e.- XE17-001)." & vbNewLine
            result = False
        ElseIf Database.ExistingRecordCheck("CERAD_Header", "XENum = " & txtXENum.getSQLValue()) = False Then
            errMsg += "- This XE # is not in the database." & vbNewLine
            result = False
        End If

        If Not (CType(intRegion.Text, Integer) >= 1 And CType(intRegion.Text, Integer) <= 40) Then
            errMsg += "- Region must be between 1-40." & vbNewLine
            result = False
        End If

        If txtRegionName.Text = "" Then
            errMsg += "- Region Name cannot be blank." & vbNewLine
            result = False
        End If

        If result = False Then
            MsgBox(errMsg, MsgBoxStyle.OkOnly, "Error")
        End If

        Return result
    End Function
    Private Sub setMaxEnteredSeq(ByVal XENum As String, ByVal region As String, ByVal stain As String)
        Dim result As Integer = 0

        If formTables.Tables("results").Rows.Count > 0 Then
            For c As Integer = 0 To formTables.Tables("results").Rows.Count - 1
                If formTables.Tables("results").Rows(c).Item("XE #") = XENum And formTables.Tables("results").Rows(c).Item("RegionNum") = region And formTables.Tables("results").Rows(c).Item("StainValue") = stain Then
                    If CType(formTables.Tables("results").Rows(c).Item("Seq #"), Integer) > result Then
                        result = CType(formTables.Tables("results").Rows(c).Item("Seq #"), Integer)
                    End If
                End If
            Next
        End If

        maxEnteredSeq = result
    End Sub
    Private Sub setMaxExistingSeq(ByVal XENum As String, ByVal region As String, ByVal stain As String)
        Dim result As Integer = 0
        If Database.ExistingRecordCheck("MicroscopicImages", "XENum = '" & XENum & "' and RegionNum = " & region & " and StainNum = " & stain) Then
            Dim cmd As New SqlCommand("select max(SeqNum) from MicroscopicImages where XENum = '" & XENum & "' and RegionNum = " & region & " and StainNum = " & stain & ";", WarehouseShell.conn)
            result = cmd.ExecuteScalar()
        End If
        maxExistingSeq = result
    End Sub
    Private Function saveRecords() As Boolean
        Dim cmd As New SqlCommand("", WarehouseShell.conn)
        Dim resultsRow As DataRow
        If formTables.Tables("results").Rows.Count() > 0 Then
            For Each resultsRow In formTables.Tables("results").Rows()
                Dim XENum As String = resultsRow("XE #")
                Dim RegionNum As String = resultsRow("RegionNum")
                Dim RegionName As String = IIf(resultsRow("RegionName") <> "", "'" & resultsRow("RegionName") & "'", "null")
                Dim StainNum As String = resultsRow("StainValue")
                Dim SeqNum As String = resultsRow("Seq #")
                Dim FileName As String = resultsRow("Barcode Data") & ".mrxs"
                cmd.CommandText = "insert into MicroscopicImages(XENum, RegionNum, RegionName, StainNum, SeqNum, FileName, UploadDate) values('" & XENum & "', " & RegionNum & ", " & RegionName & ", " & StainNum & ", " & SeqNum & ", '" & FileName & "', '" & Date.Now().Date & "');"
                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    ExceptionHandler.CatchSQLException(ex)
                    Return False
                End Try
            Next
            Return True
        Else
            MsgBox("Nothing to Save and Export!!!", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
    End Function
    Private Sub generateExcel()
        Dim resultsRowCount As Integer = formTables.Tables("results").Rows.Count()
        Try
            Dim appXL As Excel.Application
            Dim wbXl As Excel.Workbook
            Dim shXL As Excel.Worksheet
            ' Start Excel and get Application object.
            appXL = CreateObject("Excel.Application")
            'Add a workbook and fill it
            wbXl = appXL.Workbooks.Add
            shXL = wbXl.ActiveSheet
            shXL.Range("A1").Value = "XE #"
            shXL.Range("B1").Value = "Region #"
            shXL.Range("C1").Value = "Stain"
            shXL.Range("D1").Value = "Seq #"
            shXL.Range("E1").Value = "Barcode Data"
            Dim i As Integer = 1
            Dim resultsRow As DataRow
            For Each resultsRow In formTables.Tables("results").Rows()
                shXL.Range("A" & i + 1).Value = resultsRow("XE #")
                shXL.Range("B" & i + 1).Value = resultsRow("RegionNum")
                shXL.Range("C" & i + 1).Value = resultsRow("Stain")
                shXL.Range("D" & i + 1).Value = resultsRow("Seq #")
                shXL.Range("E" & i + 1).Value = resultsRow("Barcode Data")
                i += 1
            Next
            shXL.Range("A1", "Z1").EntireColumn.AutoFit()
            MsgBox("Records added to database." & vbNewLine & vbNewLine &
                   "An Excel file named ""SlideBarcodeFile.xlsx"" will now be saved to your desktop.", MsgBoxStyle.OkOnly)
            'Hand off the filled Excel file to the user
            wbXl.SaveAs(My.Computer.FileSystem.SpecialDirectories.Desktop & "\SlideBarcodeFile.xlsx",,,,,, Excel.XlSaveAsAccessMode.xlExclusive, Excel.XlSaveConflictResolution.xlLocalSessionChanges)
            'Release the resources
            shXL = Nothing
            wbXl = Nothing
            appXL.Quit()
            appXL = Nothing
        Catch ex As Exception
            ExceptionHandler.CatchWindowsException(ex)
        End Try
    End Sub


    Public Sub TopLevel(val As Boolean) Implements IFormMethods.TopLevel
    End Sub
    Private Sub IFormMethods_Parent(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Private Sub IFormMethods_Show() Implements IFormMethods.Show
        Show()
    End Sub
    Public Sub ShowPHI(val As Boolean) Implements IFormMethods.ShowPHI
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
        btnSave.PerformClick()
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class