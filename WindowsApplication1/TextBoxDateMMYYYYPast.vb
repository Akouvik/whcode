Public Class TextBoxDateMMYYYYPast
    Inherits MaskedTextBox

    Private myToolTip As New ToolTip

    Public Sub New()
        MyBase.New()
        Mask = "00/0000"
        ValidatingType = GetType(System.DateTime)
        Width = 67
        Height = 20
    End Sub

    Public Sub setValue(ByVal formTable As DataSet, ByVal tableName As String, ByVal fieldName As String)
        If formTable.Tables(tableName).Rows(0).Item(fieldName).ToString <> "" Then
            Text = formTable.Tables(tableName).Rows(0).Item(fieldName).ToString
        Else
            Clear()
        End If
    End Sub
    Public Function getSQLValue() As String
        Return IIf(Text.Replace("-", "/") = "  /", "NULL", "'" & Text.Replace("-", "/") & "'") 'Pass non-null value as a string and let SQL Server implicitly convert
    End Function


    'Change the BackColor on Enter/Leave
    Private Sub TextBoxDate_Enter(sender As Object, e As EventArgs) Handles Me.Enter
        BackColor = Color.LightSkyBlue
    End Sub
    Private Sub TextBoxEx_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        BackColor = Color.White
    End Sub

    'Filter key inputs to allow only numbers and the backspace key.
    Private Sub KeyPressed(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
        ElseIf (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            myToolTip.Show("This field only accepts numbers or the backspace key.", sender, 0, 20, 5000)
        End If
    End Sub

    'Validate that the value entered is empty or a valid date <= today's date.
    Private Sub Me_TypeValidationCompleted(ByVal sender As Object, ByVal e As TypeValidationEventArgs) Handles Me.TypeValidationCompleted
        If (Not e.IsValidInput) And Me.Text <> "  /" Then
            myToolTip.Show("Must be a valid date in the format mm/yyyy or empty.", Me, 0, 20, 5000)
            Focus()
        Else
            ' Now that the type has passed basic type validation, enforce more specific type rules. 
            Dim UserDate As Date = CDate(e.ReturnValue)
            If (UserDate > Date.Now) Then
                myToolTip.Show("Must not be greater than today's date.", Me, 0, 20, 5000)
                Focus()
                e.Cancel = True
            End If
        End If
    End Sub
End Class