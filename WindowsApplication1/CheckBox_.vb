Public Class CheckBox_
    Inherits CheckBox

    Public Sub New()
        FlatStyle = System.Windows.Forms.FlatStyle.Flat
        BackColor = Color.Tan
    End Sub

    'Change the BackColor on Enter/Leave
    Private Sub CheckBox_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        BackColor = Color.LightSkyBlue
    End Sub
    Private Sub CheckBox_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        BackColor = Color.Tan
    End Sub

    Public Sub setValue(ByVal formTable As DataSet, ByVal tableName As String, ByVal fieldName As String)
        If formTable.Tables(tableName).Rows(0).Item(fieldName).ToString = "1" Then
            Checked = True
        Else
            Checked = False
        End If
    End Sub

    Public Function getSQLValue() As String
        If Checked Then
            Return "1"
        Else
            Return "0"
        End If
    End Function

End Class