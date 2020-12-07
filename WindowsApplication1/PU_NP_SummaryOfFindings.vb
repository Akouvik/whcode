Public Class PU_NP_SummaryOfFindings
    Public myString As String = ""

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If rdo1.Checked Then
            myString = "no significant neuropathological conditions."
        ElseIf rdo2.Checked Then
            myString = "that mental illness was not caused by any significant neuropathological conditions."
        ElseIf rdo3.Checked Then
            myString = "the presence of Alzheimer’s disease."
        ElseIf rdo4.Checked Then
            myString = "significant stroke or similar vascular abnormalities."
        ElseIf rdo5.Checked Then
            myString = "the presence of diffuse Lewy body neuropathology."
        ElseIf rdo6.Checked Then
            myString = "a combination of Alzheimer’s disease and vascular abnormalities."
        ElseIf rdo7.Checked Then
            myString = "a combination of Alzheimer’s disease and Lewy body disease."
        ElseIf rdo8.Checked Then
            myString = "the presence of Parkinson’s disease."
        ElseIf rdo9.Checked Then
            If txtOther.Text = "" Then
                MsgBox("Please enter an appropriate value for Other, or select a different radio button.", , "Error")
                Exit Sub
            End If
            myString = txtOther.Text
        End If
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
    End Sub
End Class