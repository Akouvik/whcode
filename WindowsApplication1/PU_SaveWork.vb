Public Class PU_SaveWork

    'Set message. This is NOT a MessageBox()!!!!
    Private Sub PU_SaveWork_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUserText.Text = "You have potentially unsaved work!" & vbNewLine & "How would you like to proceed?"
    End Sub

    'Define button click events

    Private Sub btnSaveCont_Click(sender As Object, e As EventArgs) Handles btnSaveCont.Click
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Private Sub btnContWOSave_Click(sender As Object, e As EventArgs) Handles btnContWOSave.Click
        DialogResult = Windows.Forms.DialogResult.Ignore
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class