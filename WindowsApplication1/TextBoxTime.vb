Public Class TextBoxTime
    Inherits MaskedTextBox

    Private myToolTip As New ToolTip

    'Initialize the control
    Public Sub New()
        MyBase.New()

        Me.Mask = "00:00"
        Me.ValidatingType = GetType(System.DateTime)
        Me.Width = 35
        Me.Height = 20
    End Sub

    'Getters and setters
    Public Function getSQLValue() As String
        Return IIf(Me.Text = "  :", "NULL", "'" & Me.Text & "'")
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

    Private Sub Me_TypeValidationCompleted(ByVal sender As Object, ByVal e As TypeValidationEventArgs) Handles Me.TypeValidationCompleted
        If (Not e.IsValidInput) And Me.Text <> "  :" Then
            myToolTip.Show("Must be a valid time in the format hh:mm (24 hour clock).", Me, 0, 20, 5000)
            Me.Focus()
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