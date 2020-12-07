Public Class PU_Labs_SuggestNew
    Private formTables As New DataSet

    Private Sub PU_Labs_SuggestNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formTables.Tables.Add(Database.ReturnTable("lkpLabSources"))
        cmbLabSource.assignLookup(formTables, "lkpLabSources")
        cmbLabSource.SelectedValue = 4
        ActiveControl = txtLabName
    End Sub

    Private Function preSaveValidation() As Boolean
        Dim result As Boolean = True
        Dim errMsg As String = "The following errors must be corrected before this request can be submitted:" & vbNewLine & vbNewLine

        If txtLabName.Text = "" Then
            errMsg += "- Lab Name must not be blank." & vbNewLine
            result = False
        End If

        If numResultQuant.Text = "" And txtResultQual.Text = "" Then
            errMsg += "- Either a Quantitative or Qualitative result must be entered." & vbNewLine
            result = False
        End If

        If numResultQuant.Text <> "" And txtUoM.Text = "" Then
            errMsg += "- Quantitative results require a Unit of Measure (UoM)." & vbNewLine
            result = False
        End If

        If result = False Then
            MsgBox(errMsg, MsgBoxStyle.OkOnly, "Error")
        End If

        Return result
    End Function

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If preSaveValidation() Then
            Dim cmdString As String = "Exec insertLabsSuggestion @SubNum = " & WarehouseShell.SubNum &
                ", @LabName = " & txtLabName.getSQLValue() &
                ", @UoM = " & txtUoM.getSQLValue() &
                ", @RangeLow = " & numRngFrom.getSQLValue() &
                ", @RangeHigh = " & numRngTo.getSQLValue() &
                ", @QuantitativeResult = " & numResultQuant.getSQLValue() &
                ", @QualitativeResult = " & txtResultQual.getSQLValue() &
                ", @Source = " & cmbLabSource.getSQLValue() &
                ", @LabDate = " & dtLabDate.getSQLValue() &
                ", @Approved = 0" &
                ", @Completed = 0;"
            Dim cmd As New SqlCommand(cmdString, WarehouseShell.conn)
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Request submitted. You will only receive a response if this request is disapproved. Otherwise, the data will be directly added for this subject when this resuest is approved.", MsgBoxStyle.OkOnly)
                Close()
            Catch ex As SqlException
                ExceptionHandler.CatchSQLException(ex)
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class