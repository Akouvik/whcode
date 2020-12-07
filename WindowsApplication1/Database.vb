Imports Microsoft.Office.Interop

Public Class Database

    Public Shared Function ExistingRecordCheck(ByVal TableName As String, Optional ByVal myWhereFilter As String = "") As Boolean
        Try
            Dim cmd As New SqlCommand("Select count(*) from " & TableName & IIf(myWhereFilter <> "", " where " & myWhereFilter, "") & ";", WarehouseShell.conn)
            'Console.WriteLine("Select count(*) from " & TableName & IIf(myWhereFilter <> "", " where " & myWhereFilter, "") & ";")
            If cmd.ExecuteScalar() > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As SqlException
            ExceptionHandler.CatchSQLException(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function ReturnTable(ByVal tableName As String, Optional ByVal myFields As String = "", Optional ByVal myFilter As String = "", Optional ByVal orderBy As String = "") As DataTable
        Try
            'Designate the query and connection, then feed them into a new SQLDataAdapter
            Dim myQuery As String = "select " & IIf(myFields = "", "*", myFields) & " from " & tableName & IIf(myFilter = "", "", " where " & myFilter) & IIf(orderBy = "", "", " order by " & orderBy) & ";"
            Dim Reader As New SqlDataAdapter(myQuery, WarehouseShell.conn)

            'create a result table and use the adapter to fill the table
            Dim Result As New DataTable(tableName)
            Reader.Fill(Result)

            'return the filled table
            Return Result
        Catch ex As SqlException
            ExceptionHandler.CatchSQLException(ex)
            Return Nothing
        End Try
    End Function
    Public Shared Function ReturnString(ByVal tableName As String, ByVal field As String, ByVal filter As String) As String
        Return ReturnTable(tableName, field, filter).Rows(0).Item(field).ToString
    End Function
    Public Shared Function ReturnDate(ByVal tableName As String, ByVal field As String, ByVal filter As String) As Date
        Dim result As Date
        Dim table As New DataTable
        table = ReturnTable(tableName, field, filter)

        Try
            result = table.Rows(0).Item(field)
            table.Clear()
            Return result
        Catch ex As Exception
            ExceptionHandler.CatchWindowsException(ex)
            Return Nothing
        End Try
    End Function

    'Permissions checks
    'Public Shared Function CheckPermission(ByVal permissions As String) As Boolean


    '    Dim result = False
    '    Dim permission As String() = permissions.Split(New Char() {","c})
    '    For Each item As String In permission
    '        If ExistingRecordCheck("refUser", "UserName = '" & WarehouseShell.userName & "' and Active = 1 and (UserName in (select UserName from viewUserRoles where Role = '" & item.Trim() & "' or Role = 'Admin'))") Then
    '            result = True
    '            Exit For
    '        End If
    '    Next
    '    Return result
    'End Function

    Public Shared Function CheckNACCVisist(ByVal visit As String) As Boolean
        If visit Like "###" Then
            Return True
        Else
            Return False
        End If
    End Function
End Class