Public Class PU_TissueRequest_SelectBrainRegion
    Public returnString As String = ""

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        For Each control As Control In Controls()
            If TypeOf control Is CheckBox_ Then
                If CType(control, CheckBox_).Checked Then
                    returnString += CType(control, CheckBox_).Text & "; "
                End If
            ElseIf TypeOf control Is TextBox_ Then
                If Len(CType(control, TextBox_).Text) > 0 Then
                    returnString += CType(control, TextBox_).Text & "; "
                End If
            End If
        Next

        If Len(returnString) > 0 Then
            returnString = returnString.Substring(0, Len(returnString) - 2)
        End If

        Hide()
    End Sub

    Private Sub btrnCancel_Click(sender As Object, e As EventArgs) Handles btrnCancel.Click
        returnString = "Cancel"
        Hide()
    End Sub

End Class