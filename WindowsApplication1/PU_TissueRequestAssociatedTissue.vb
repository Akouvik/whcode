Public Class PU_TissueRequestAssociatedTissue
    Private myDataSet As New DataSet
    Private dgvbs As BindingSource

    Private Sub PU_TissueRequestAssociatedTissue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvAssociatedTissue.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        dgvAssociatedTissue.MultiSelect = True
        If Database.ExistingRecordCheck("Specimen", "ProjectID = " & DirectCast(WarehouseShell.WorkingAreaForm, WA_TissueRequest).ProjectID) = True Then
            myDataSet.Tables.Add(Database.ReturnTable("viewSpecimen", "Barcode, BB, SubNum, StorageType as 'Storage Type', BrainRegion as 'Brain Region', UoM, Size, LocationType as 'Loc Type', LocationNum as 'Loc #', Shelf as 'Shelf #', BoxNum as 'Box #', Note", "ProjectID = " & DirectCast(WarehouseShell.WorkingAreaForm, WA_TissueRequest).ProjectID))
            dgvbs = New BindingSource
            dgvbs.DataSource = myDataSet.Tables("viewSpecimen")
            dgvAssociatedTissue.DataSource = dgvbs
            addRowNums()
        Else
            MsgBox("No tissue is currently associated with this request in the database.", MsgBoxStyle.OkOnly, )
            Me.Dispose()
        End If
    End Sub

    Private Sub addRowNums()
        Dim rowNum As Integer = 1
        For Each row As DataGridViewRow In dgvAssociatedTissue.Rows
            If row.IsNewRow Then Continue For
            row.HeaderCell.Value = rowNum.ToString
            rowNum = rowNum + 1
        Next
        dgvAssociatedTissue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvAssociatedTissue.RowHeadersVisible = True
    End Sub
    
    Private Sub Button_1_Click(sender As Object, e As EventArgs) Handles Button_1.Click
        Try
            Clipboard.SetDataObject(dgvAssociatedTissue.GetClipboardContent())
        Catch ex As Exception
            ExceptionHandler.CatchWindowsException(ex)
        End Try
    End Sub
End Class