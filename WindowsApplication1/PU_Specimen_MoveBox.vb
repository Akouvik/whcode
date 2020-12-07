Public Class PU_Specimen_MoveBox
    Private tooltip1 As New ToolTip
    Private formTables As New DataSet

    Private Sub PU_Specimen_MoveBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBaseForm()
        intBoxNum.Focus()
    End Sub

    Private Sub LoadBaseForm()
        formTables.Tables.Add(Database.ReturnTable("lkpLocationType"))
        cmbLocType.assignLookup(formTables, "lkpLocationType")
        cmbLocType.SelectedValue = 1
    End Sub

    Private Function preSaveValidation() As Boolean
        Dim result As Boolean = True
        Dim errorMessage As String = "The following errors have been identified and must be corrected before record can be saved:" & vbNewLine & vbNewLine
        Dim chkCommand As New SqlCommand("", WarehouseShell.conn)

        'Check for valid Box #
        If intBoxNum.Text = "" Then
            errorMessage += "- You must provide a Box #." & vbNewLine
            result = False
        Else
            chkCommand.CommandText = "select count(*) from Specimen where BoxNum = " & intBoxNum.Text
            If chkCommand.ExecuteScalar() = 0 Then
                errorMessage += "- There are no specimens associated with this box (nothing to be moved)." & vbNewLine
                result = False
            Else
                chkCommand.CommandText = "select max(Shipped) from Specimen where BoxNum = " & intBoxNum.Text
                If chkCommand.ExecuteScalar() = 1 Then
                    errorMessage += "- The specimens associated with this box have already been distributed (please contact Josh)." & vbNewLine
                    result = False
                End If
            End If
        End If

        'Check for valid Loc #
        If intLocNum.Text = "" Then
            errorMessage += "- Must Provide a Loc #." & vbNewLine
            result = False
        Else
            If cmbLocType.Text = "Freezer" Then
                If Not (CType(intLocNum.Text, Integer) > 0 And CType(intLocNum.Text, Integer) < 41) Then
                    errorMessage += "- Loc # must be between 1-40 for Loc Type 'Freezer'." & vbNewLine
                    result = False
                End If
            ElseIf cmbLocType.Text = "Dry Rack" Then
                If Not (CType(intLocNum.Text, Integer) > 100 And CType(intLocNum.Text, Integer) < 101) Then
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
        If cmbLocType.Text = "Freezer" Then
            If Not (CType(intShelfNum.Text, Integer) > 0 And CType(intShelfNum.Text, Integer) < 6) Then
                errorMessage += "- Shelf # must be between 1-5 for Loc Type 'Freezer'." & vbNewLine
                result = False
            End If
        ElseIf cmbLocType.Text = "Dry Rack" Then
            If Not (CType(intLocNum.Text, Integer) > 0 And CType(intLocNum.Text, Integer) < 11) Then
                errorMessage += "- Shelf # must be between 1-10 for Loc Type 'Dry Rack'." & vbNewLine
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
        Dim cmd As New SqlCommand("Exec moveSpecimenBox " &
                                  "@BoxNum = " & intBoxNum.getSQLValue() &
                                  ", @LocationType = " & cmbLocType.getSQLValue() &
                                  ", @LocationNum = " & intLocNum.getSQLValue() &
                                  ", @ShelfNum = " & intShelfNum.getSQLValue() &
                                  ", @ShelfColumn = " & intShelfCol.getSQLValue() &
                                  ", @ShelfRow = " & intShelfRow.getSQLValue() &
                                  ";", WarehouseShell.conn)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Update successful!", MsgBoxStyle.OkOnly, "Success!")
            Return True
        Catch ex As SqlException
            ExceptionHandler.CatchSQLException(ex)
            Return False
        End Try
    End Function

    Private Sub intBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles intBoxNum.KeyDown, intLocNum.KeyDown, intShelfNum.KeyDown, intShelfCol.KeyDown, intShelfRow.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSaveAndContinue.PerformClick()
        End If
    End Sub

    'Button click events
    Private Sub btnSaveAndContinue_Click(sender As Object, e As EventArgs) Handles btnSaveAndContinue.Click
        If preSaveValidation() Then
            If saveRecord() Then
                intBoxNum.Clear()
                intBoxNum.Focus()
            End If
        End If
    End Sub
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