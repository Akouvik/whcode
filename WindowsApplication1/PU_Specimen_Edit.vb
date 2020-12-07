﻿Public Class PU_Specimen_Edit
    Private tooltip1 As New ToolTip
    Private formtables As New DataSet
    Private record As DataGridViewRow

    Public Sub New(ByVal myRecord As DataGridViewRow)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        record = myRecord
    End Sub
    Private Sub PU_Specimen_MoveAliquot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadBaseForm()
        loadRecord()
        numBB.Focus()
    End Sub

    'Grab applicable lookup tables and assign the actual lookup values
    Private Sub loadBaseForm()
        'Load all required lookup tables into the formTables DataSet
        formtables.Tables.Add(Database.ReturnTable("lkpStorageType"))
        formtables.Tables.Add(Database.ReturnTable("lkpBrainRegion"))
        formtables.Tables.Add(Database.ReturnTable("lkpUoM"))
        formtables.Tables.Add(Database.ReturnTable("lkpLocationType"))
        cmbStorageType.assignLookup(formtables, "lkpStorageType",,,, "Label")
        cmbBrainRegion.assignLookup(formtables, "lkpBrainRegion",,,, "Label")
        cmbUoM.assignLookup(formtables, "lkpUoM",,,, "Label")
        cmbLocType.assignLookup(formtables, "lkpLocationType",,,, "Label")
    End Sub

    'Sub to set default values for combo boxes.
    Private Sub loadRecord()
        intBarcode.Text = record.Cells("Barcode").Value.ToString
        numBB.Text = record.Cells("BB").Value.ToString
        cmbStorageType.SelectedValue = record.Cells("StorageTypeValue").Value
        cmbBrainRegion.SelectedValue = record.Cells("BrainRegionValue").Value
        txtBrainRegionDetail.Text = record.Cells("BrainRegionDetail").Value.ToString
        cmbUoM.SelectedValue = record.Cells("UoMValue").Value
        intSize.Text = record.Cells("Size").Value.ToString
        cmbLocType.SelectedValue = record.Cells("LocationTypeValue").Value
        intLocNum.Text = record.Cells("LocationNum").Value.ToString
        intShelfNum.Text = record.Cells("Shelf").Value.ToString
        intShelfCol.Text = record.Cells("ShelfColumn").Value.ToString
        intShelfRow.Text = record.Cells("ShelfRow").Value.ToString
        intBoxNum.Text = record.Cells("BoxNum").Value.ToString
        intBoxCol.Text = record.Cells("BoxColumn").Value.ToString
        intBoxRow.Text = record.Cells("BoxRow").Value.ToString
        intProjectID.Text = record.Cells("ProjectID").Value.ToString
        txtNote.Text = record.Cells("Note").Value.ToString
    End Sub

    Private Function preSaveValidation() As Boolean
        Dim result As Boolean = True
        Dim errorMessage As String = "The following errors have been identified and must be corrected before record can be saved:" & vbNewLine & vbNewLine
        Dim chkCommand As New SqlCommand("", WarehouseShell.conn)

        'Check for valid BB #
        If numBB.Text = "" Then
            errorMessage += "- Must provide BB #." & vbNewLine
            result = False
        Else
            If Not (Database.ExistingRecordCheck("AutopsyFaceSheet", "BB = " & numBB.Text) Or numBB.Text = "0.0") Then
                errorMessage += "- Invalid BB #." & vbNewLine
                result = False
            End If
        End If

        'Check for valid StorageType
        If cmbStorageType.SelectedValue = -1 Then
            errorMessage += "- Must provide Storage Type." & vbNewLine
            result = False
        End If

        'Check for valid Brain Region
        If cmbBrainRegion.SelectedValue = -1 Then
            errorMessage += "- Must provide Brain Region." & vbNewLine
            result = False
        End If

        'Check for valid UoM
        If cmbUoM.SelectedValue = -1 Then
            errorMessage += "- Must provide UoM." & vbNewLine
            result = False
        End If

        'Check for valid Size
        If intSize.Text = "" Then
            errorMessage += "- Must provide Size." & vbNewLine
            result = False
        End If

        'Check for valid Loc Type
        If cmbLocType.SelectedValue = -1 Then
            errorMessage += "- Must provide Loc Type." & vbNewLine
            result = False
        End If

        'Check for valid Loc #
        If intLocNum.Text = "" Then
            errorMessage += "- Must Provide a Loc #." & vbNewLine
            result = False
        Else
            If cmbLocType.SelectedValue = 1 Then
                If Not (CType(intLocNum.Text, Integer) > 0 And CType(intLocNum.Text, Integer) < 41) Then
                    errorMessage += "- Loc # must be between 1-40 for Loc Type 'Freezer'." & vbNewLine
                    result = False
                End If
            ElseIf cmbLocType.SelectedValue = 2 Then
                If Not (CType(intLocNum.Text, Integer) > 100 And CType(intLocNum.Text, Integer) < 110) Then
                    errorMessage += "- Loc # must be between 101-111 for Loc Type 'Dry Rack'." & vbNewLine
                    result = False
                End If
            End If
        End If

        'Check for valid Shelf #
        If intShelfNum.Text = "" Then
            errorMessage += "- Must Provide a Shelf #." & vbNewLine
            result = False
        End If
        If cmbLocType.SelectedValue = 1 Then
            If Not (CType(intShelfNum.Text, Integer) > 0 And CType(intShelfNum.Text, Integer) < 6) Then
                errorMessage += "- Shelf # must be between 1 and 5 for Loc Type 'Freezer'." & vbNewLine
                result = False
            End If
        ElseIf cmbLocType.SelectedValue = 2 Then
            If Not (CType(intShelfNum.Text, Integer) > 0 And CType(intShelfNum.Text, Integer) < 112) Then
                errorMessage += "- Shelf # must be between 1 and 10 for Loc Type 'Dry Rack'." & vbNewLine
                result = False
            End If
        End If

        'TODO: Check for valid Shelf Col

        'TODO: Check for valid Shelf Row

        'Check for valid Box #
        If intBoxNum.Text <> "" Then
            chkCommand.CommandText = "select max(Shipped) from Specimen where BoxNum = " & intBoxNum.Text
            If Not IsDBNull(chkCommand.ExecuteScalar) Then
                If chkCommand.ExecuteScalar() = 1 Then
                    errorMessage += "- This box has already been distributed (please contact Josh)." & vbNewLine
                    result = False
                End If
            End If
        End If

        'Check for valid Box Row
        If intBoxCol.Text <> "" Then
            If Not (CType(intBoxCol.Text, Integer) > 0 And CType(intBoxCol.Text, Integer) < 11) Then
                errorMessage += "- Box Col must be between 1 and 10." & vbNewLine
                result = False
            End If
        End If

        If intBoxRow.Text <> "" Then
            If Not (CType(intBoxRow.Text, Integer) > 0 And CType(intBoxRow.Text, Integer) < 11) Then
                errorMessage += "- Box Row must be between 1 and 10." & vbNewLine
                result = False
            End If
        End If

        'Check for valid ProjectID
        If intProjectID.Text <> "" Then
            chkCommand.CommandText = "select count(*) from TissueTasker where ProjectID = " & intProjectID.Text
            If chkCommand.ExecuteScalar() = 0 Then
                errorMessage += "- Invalid Project ID." & vbNewLine
                result = False
            End If
        End If

        'Show msgbox if result = False
        If result = False Then
            MsgBox(errorMessage, MsgBoxStyle.OkOnly, "Error!")
        End If

        Return result
    End Function

    Private Function saveRecord() As Boolean
        Dim cmd As New SqlCommand("Exec editSpecimen " &
                                  "@Barcode = " & intBarcode.getSQLValue() &
                                  ", @BB = " & numBB.getSQLValue() &
                                  ", @StorageType = " & cmbStorageType.getSQLValue() &
                                  ", @BrainRegion = " & cmbBrainRegion.getSQLValue() &
                                  ", @BrainRegionDetail = " & txtBrainRegionDetail.getSQLValue() &
                                  ", @UoM = " & cmbUoM.getSQLValue() &
                                  ", @Size = " & intSize.getSQLValue() &
                                  ", @LocationType = " & cmbLocType.getSQLValue() &
                                  ", @LocationNum = " & intLocNum.getSQLValue() &
                                  ", @Shelf = " & intShelfNum.getSQLValue() &
                                  ", @ShelfColumn = " & intShelfCol.getSQLValue() &
                                  ", @ShelfRow = " & intShelfRow.getSQLValue() &
                                  ", @BoxNum = " & intBoxNum.getSQLValue() &
                                  ", @BoxColumn = " & intBoxCol.getSQLValue() &
                                  ", @BoxRow = " & intBoxRow.getSQLValue() &
                                  ", @ProjectID = " & intProjectID.getSQLValue() &
                                  ", @Note = " & txtNote.getSQLValue() &
                                  ", @LastModBy = '" & WarehouseShell.userName & "'" &
                                  ";", WarehouseShell.conn)
        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As SqlException
            ExceptionHandler.CatchSQLException(ex)
            Return False
        End Try
    End Function

    Private Sub btnSaveAndClose_Click(sender As Object, e As EventArgs) Handles btnSaveAndClose.Click
        If preSaveValidation() Then
            If saveRecord() Then
                Dispose()
            End If
        End If
    End Sub
    Private Sub btnCancelClose_Click(sender As Object, e As EventArgs) Handles btnCancelClose.Click
        Dispose()
    End Sub
End Class