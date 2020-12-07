Public Class PU_PHIPassword

    Private Sub PU_PHIPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DialogResult = Nothing
        txtPassword.Focus()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtPassword.Text = "" Then
            MsgBox("Please enter a password!", , "Error")
            txtPassword.Focus()
        Else
            If txtPassword.Text = WarehouseShell.password Then
                Me.DialogResult = Windows.Forms.DialogResult.Yes
            Else
                MsgBox("Invalid password entered!", , "Error")
                txtPassword.Clear()
                txtPassword.Focus()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class