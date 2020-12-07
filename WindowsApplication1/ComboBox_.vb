Public Class ComboBox_
    Inherits ComboBox

    'Initialize the control
    Public Sub New()
        MyBase.New()
        AutoCompleteMode = AutoCompleteMode.SuggestAppend
        AutoCompleteSource = AutoCompleteSource.ListItems
        DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    'Setters and Getters
    Public Function getSQLValue() As String
        'returns single-quoted string in case value is text (normally numeric, but not always). SQL Server will implicitly convert numbers where applicable

        Return "'" & Replace(SelectedValue, "'", "''") & "'"
    End Function

    Public Function getSQLLabel() As String
        Return IIf(Text = "", "NULL", "'" & Replace(Text, "'", "''") & "'")
    End Function

    Public Sub assignLookup(ByVal formTable As DataSet, ByVal tableName As String, Optional ByVal valueName As String = "Value", Optional ByVal labelName As String = "Label", Optional ByVal filterString As String = "", Optional ByVal sortBy As String = "")
        If sortBy = "" Then
            DataSource = New DataView(formTable.Tables(tableName), filterString, labelName, DataViewRowState.CurrentRows)
        Else
            DataSource = New DataView(formTable.Tables(tableName), filterString, sortBy, DataViewRowState.CurrentRows)
        End If
        ValueMember = valueName
        DisplayMember = labelName
    End Sub

    Public Sub setValue(ByVal formTable As DataSet, ByVal tableName As String, ByVal fieldName As String)
        If formTable.Tables(tableName).Rows().Count > 0 Then
            SelectedValue = formTable.Tables(tableName).Rows(0).Item(fieldName)
        End If
    End Sub

    'Stop Mouse Scroll Wheels
    Protected Overrides Sub OnMouseWheel(ByVal e As MouseEventArgs)
        Dim mwe As HandledMouseEventArgs = DirectCast(e, HandledMouseEventArgs)
        mwe.Handled = True
    End Sub

End Class