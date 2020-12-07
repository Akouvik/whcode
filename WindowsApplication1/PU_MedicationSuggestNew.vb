Public Class PU_MedicationSuggestNew

    Private Function preSaveValidation() As Boolean
        Dim errMsg As String = ""
        Dim result As Boolean = True

        'check criteria
        If txtBrandName.Text = "" Then
            errMsg += "- Please provide a Brand Name (copy the Generic Name if unknown or not applicable)." & vbNewLine
            result = False
        End If
        If txtGenericName.Text = "" Then
            errMsg += "- Please provide a Generic Name." & vbNewLine
            result = False
        End If
        If numTotalDailyDosage.Text <> "" And txtDosageUnits.Text = "" Then
            errMsg += "- Please provide Dosage Units." & vbNewLine
            result = False
        End If

        'handle results
        If result = False Then
            errMsg = "Please correct the following errors:" & vbNewLine & vbNewLine & errMsg
            MsgBox(errMsg, MsgBoxStyle.OkOnly, "Error")
        End If
        Return result
    End Function

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If preSaveValidation() Then
            Dim cmd As New SqlCommand("Exec insertMedicationSuggestionsRecord " & WarehouseShell.SubNum &
                                  ", " & txtBrandName.getSQLValue() &
                                  ", " & txtGenericName.getSQLValue() &
                                  ", " & numTotalDailyDosage.getSQLValue() &
                                  ", " & txtDosageUnits.getSQLValue() &
                                  ", " & dtStarted.getSQLValue() &
                                  ", " & dtEnded.getSQLValue() &
                                  ", '" & WarehouseShell.userName &
                                  "', " & "null" &
                                  ", " & "0" &
                                  ", " & "0" &
                                  ", " & "null;", WarehouseShell.conn)
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Request submitted. If approved, this medication will be directly added to your current subject using the information you supplied. If not approved, you will receive a follow up email with instructions.", MsgBoxStyle.OkOnly)
            Catch ex As SqlException
                ExceptionHandler.CatchSQLException(ex)
            Finally
                Close()
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

End Class