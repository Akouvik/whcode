Imports Excel = Microsoft.Office.Interop.Excel


Public Class PU_BarcodeGenerator
    Private result As Integer = 0
    Private oldLastUsedBarcode As Integer
    Private newLastUsedBarcodeBarcode As Integer

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If intBarcodes.Text <> "" Then
            Dim cmd As New SqlCommand("select Max(LastUsedBarcode) from BarcodeMaster;", WarehouseShell.conn)
            oldLastUsedBarcode = cmd.ExecuteScalar()
            result = CType(intBarcodes.Text, Integer)
            newLastUsedBarcodeBarcode = oldLastUsedBarcode + result
            generateExcel()
            updateBarcodeMaster()
        End If
        Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub generateExcel()
        Try
            Dim appXL As Excel.Application
            Dim wbXl As Excel.Workbook
            Dim shXL As Excel.Worksheet
            ' Start Excel and get Application object.
            appXL = CreateObject("Excel.Application")
            'Add a workbook and fill it
            wbXl = appXL.Workbooks.Add
            shXL = wbXl.ActiveSheet
            shXL.Range("A1").Value = "Barcode"
            shXL.Range("B1").Value = "BB"
            shXL.Range("C1").Value = "StorageType"
            shXL.Range("D1").Value = "BrainRegion"
            shXL.Range("E1").Value = "BrainRegionDetail"
            shXL.Range("F1").Value = "UoM"
            shXL.Range("G1").Value = "Size"
            shXL.Range("H1").Value = "LocationType"
            shXL.Range("I1").Value = "LocationNum"
            shXL.Range("J1").Value = "Shelf"
            shXL.Range("K1").Value = "ShelfColumn"
            shXL.Range("L1").Value = "ShelfRow"
            shXL.Range("M1").Value = "BoxNum"
            shXL.Range("N1").Value = "BoxRow"
            shXL.Range("O1").Value = "DateCreated"
            shXL.Range("P1").Value = "ProjectID"
            shXL.Range("Q1").Value = "Note"
            For i As Integer = 1 To result
                shXL.Range("A" & i + 1).Value = oldLastUsedBarcode + 1
                oldLastUsedBarcode += 1
            Next
            shXL.Range("A1", "Z1").EntireColumn.AutoFit()
            'Hand off the filled Excel file to the user
            MsgBox("An Excel form will now be opened on your computer. Check the taskbar at the bottom of your screen if you do not see the Excel form when you click OK below.", MsgBoxStyle.OkOnly)
            appXL.Visible = True
            appXL.UserControl = True
            'Release the resources
            shXL = Nothing
            wbXl = Nothing
            appXL.Quit()
            appXL = Nothing
        Catch ex As Exception
            ExceptionHandler.CatchWindowsException(ex)
        End Try
    End Sub

    Private Sub updateBarcodeMaster()
        Dim cmd As New SqlCommand("Insert into BarcodeMaster (LastUsedBarcode, Qty, Purpose) values (" & newLastUsedBarcodeBarcode & ", " & result & ", '" & txtPurpose.Text & "');", WarehouseShell.conn)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As SqlException
            ExceptionHandler.CatchSQLException(ex)
        End Try
    End Sub

    Private Sub input_KeyDown(sender As Object, e As KeyEventArgs) Handles intBarcodes.KeyDown, txtPurpose.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSubmit.PerformClick()
        End If
    End Sub

    Private Sub PU_BarcodeGenerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class