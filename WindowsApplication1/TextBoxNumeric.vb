Public Class TextBoxNumeric
    Inherits TextBox

    'Getters and Setters
    Public Function getSQLValue() As String
        Return IIf(Text = "", "NULL", "'" & Text & "'") 'pass as SQL string and let SQL Server implicitly convert
    End Function
    Public Sub setValue(formTable As DataSet, tableName As String, fieldName As String)
        Me.Text = formTable.Tables(tableName).Rows(0).Item(fieldName).ToString()
    End Sub

    'Change the BackColor on Enter/Leave
    Private Sub TextBoxDate_Enter(sender As Object, e As EventArgs) Handles Me.Enter
        Me.BackColor = Color.LightSkyBlue
    End Sub
    Private Sub TextBoxEx_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.BackColor = Color.White
    End Sub

    'Filter key inputs to allow only numbers, the "." key, and the backspace key.
    Private Sub Me_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim mytooltip As New ToolTip
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
        ElseIf (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 46 Then
            e.Handled = True
            mytooltip.Show("This field accepts only numbers and decimals.", Me, 0, 20, 5000)
        End If
    End Sub

    Public Sub makeReadOnly(ByVal bool As Boolean)
        If bool Then
            [ReadOnly] = True
            BackColor = SystemColors.Control
            ForeColor = SystemColors.GrayText
        Else
            [ReadOnly] = False
            BackColor = SystemColors.Window
            ForeColor = SystemColors.WindowText
        End If
    End Sub
End Class