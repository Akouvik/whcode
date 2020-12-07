Public Class TextBox_
    Inherits TextBox

    'Change the BackColor on Enter/Leave
    Private Sub TextBoxDate_Enter(sender As Object, e As EventArgs) Handles Me.Enter
        BackColor = Color.LightSkyBlue
    End Sub
    Private Sub TextBoxEx_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        BackColor = Color.White
    End Sub

    'Getters and setters
    Public Function getSQLValue() As String
        Dim myText As String = Text
        'myText = Replace(myText, "&", "&&")
        myText = Replace(myText, "'", "''")
        myText = IIf(myText = "", "NULL", "'" & myText & "'")
        Return myText
    End Function
    Public Sub setValue(formTable As DataSet, tableName As String, fieldName As String)
        Text = formTable.Tables(tableName).Rows(0).Item(fieldName).ToString()
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