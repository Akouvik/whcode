Public Class TextBoxDateAny
    Inherits MaskedTextBox

    Private myToolTip As New ToolTip

    'Initialize the control
    Public Sub New()
        MyBase.New()
        Me.Mask = "00/00/0000"
        Me.ValidatingType = GetType(System.DateTime)
        Me.Width = 67
        Me.Height = 20
    End Sub

    'Getters and Setters
    Public Sub setValue(ByVal formTable As DataSet, ByVal tableName As String, ByVal fieldName As String)
        If IsDate(formTable.Tables(tableName).Rows(0).Item(fieldName)) Then
            Me.Text = Format(formTable.Tables(tableName).Rows(0).Item(fieldName), "MM-dd-yyyy").ToString 'Format date style before converting to string
        End If
    End Sub
    Public Function getSQLValue() As String
        Return IIf(Me.Text = "  /  /", "NULL", "'" & Me.Text & "'") 'Pass non-null value as a string and let SQL Server implicitly convert
    End Function

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
            e.Handled = True
            myToolTip.Show("This field only accepts numbers or the backspace key.", sender, 0, 20, 5000)
        End If
    End Sub

    'Validate that the value entered is empty or a valid date <= today's date.
    Private Sub Me_TypeValidationCompleted(ByVal sender As Object, ByVal e As TypeValidationEventArgs) Handles Me.TypeValidationCompleted
        If (Not e.IsValidInput) And Me.Text <> "  /  /" Then
            myToolTip.Show("Must be a valid date in the format mm/dd/yyyy or empty.", Me, 0, 20, 5000)
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