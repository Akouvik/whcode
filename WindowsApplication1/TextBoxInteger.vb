Public Class TextBoxInteger
    Inherits TextBox

    Private myToolTip As New ToolTip

    'Getters and Setters
    Public Function getSQLValue() As String
        Return IIf(Me.Text = "", "NULL", "'" & Replace(Me.Text, "'", "''") & "'")
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

    'Filter key inputs to allow only numbers and the backspace key.
    Private Sub KeyPressed(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
        ElseIf (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) And Asc(e.KeyChar) <> 8 Then
            myToolTip.Show("This box accepts numbers only.", Me, 0, 20, 2500)
            e.Handled = True
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