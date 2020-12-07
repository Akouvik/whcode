Public Class ExceptionHandler

    Public Shared Sub CatchSQLException(ByVal exception As SqlException)
        Dim ErrMsg As String
        Dim contactInfo As String = "If this problem persists, please SCREENSHOT THIS ERROR MESSAGE and contact the Data Manager at (347) 915-8911 or joshua.arneson@mssm.edu"
        Select Case exception.Number
            Case 18456
                ErrMsg = "The username or password you entered in not valid." & vbNewLine & vbNewLine & contactInfo
            Case 53
                ErrMsg = "There was a problem communicating with the database. Please verify that you are connected to the Mount Sinai network." & vbNewLine & vbNewLine & contactInfo
            Case Else
                ErrMsg = exception.Number & "- " & exception.Message & vbNewLine & vbNewLine & contactInfo
        End Select
        MsgBox(ErrMsg, MsgBoxStyle.Critical, "Error")
    End Sub

    Public Shared Sub CatchWindowsException(ByVal myException As Exception)
        Dim ErrMsg As String
        Dim contactInfo As String = "If this problem persists, please SCREENSHOT THIS ERROR MESSAGE and contact the Data Manager at (347) 915-8911 or joshua.arneson@mssm.edu"
        Select Case myException.HResult
            Case 18456
                ErrMsg = "The username or password you entered in not valid."
            Case 53
                ErrMsg = "There was a problem communicating with the database. Please verify that you are connected to the Mount Sinai network." & vbNewLine & vbNewLine & contactInfo
                'Case -2147467259
                '    ErrMsg = "There was a problem accessing the referenced file. Please verify that your ""Q"" drive is accessible in ""My Computer""." & vbNewLine & vbNewLine & contactInfo
            Case -2147024864
                ErrMsg = "The file you have requested is already open on your computer." & vbNewLine & vbNewLine & contactInfo
            Case Else
                ErrMsg = myException.HResult & "- " & myException.Message & vbNewLine & vbNewLine & contactInfo
        End Select
        MsgBox(ErrMsg, MsgBoxStyle.Critical, "Error")
    End Sub

End Class