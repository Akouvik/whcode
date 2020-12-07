Public Class PU_GenderHistoryAdd
    'TODO: Add date validation to btnAddRecord click event.
    Private Sub btnAddRecord_Click(sender As Object, e As EventArgs)
        If comboGender.SelectedIndex > -1 Then
            'code here to add record
            'code here to refresh displayed data table
            MessageBox.Show("Record successfully added.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            comboGender.SelectedIndex = -1
            txtDate.Clear()
            txtSource.Clear()
        Else
            MessageBox.Show("No gender selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            comboGender.Focus()
        End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        If comboGender.SelectedIndex = -1 And txtSource.Text = "" And txtDate.Text = "  /  /" Then
            Me.Close()
        Else
            DialogResult = MessageBox.Show("The gender information you have entered will not be saved. Continue?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If DialogResult = Windows.Forms.DialogResult.OK Then
                Me.Close()
            Else
                comboGender.Focus()
            End If
        End If
    End Sub
End Class