Public Class PU_Specimen_Consume
    Private Sub btnSaveAndClose_Click(sender As Object, e As EventArgs) Handles btnSaveAndClose.Click
        If txtNote.Text = "" Then
            MsgBox("Please provide consumed for reason.", MsgBoxStyle.OkOnly, "Error")
        Else
            Hide()
        End If
    End Sub
End Class