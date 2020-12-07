Public Class LoginForm

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles OK.Click
        If WarehouseShell.Login(UsernameTextBox.Text, PasswordTextBox.Text) Then
            DialogResult = DialogResult.OK
        Else
            DialogResult = DialogResult.Abort
        End If
    End Sub
    'Tell application to close if Cancel button is clicked
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Cancel.Click
        DialogResult = DialogResult.Cancel
    End Sub

End Class