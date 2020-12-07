Public Class TextBoxIntLess40
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
        If Me.Text <> "" Then
            If CType(Me.Text, Integer) > 40 Or Me.Text = "0" Then
                myToolTip.Show("This must be a number between 1-40.", Me, 0, 20, 5000)
                Me.Focus()
            End If
        End If
    End Sub

    'Filter key inputs to allow only numbers and the backspace key.
    Private Sub KeyPressed(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
        ElseIf (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) And Asc(e.KeyChar) <> 8 Then
            myToolTip.Show("This field only accepts numbers.", Me, 0, 20, 5000)
            e.Handled = True
        End If
    End Sub
End Class