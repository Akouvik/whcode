Public Class WA_ReportsSplash
    Implements IFormMethods

    Private Sub Josh_Click(sender As Object, e As EventArgs) Handles Josh.Click
        'Dim di As New DirectoryInfo("R:\Team Folders\NP Scans\")
        'Dim aryFi As FileInfo() = di.GetFiles("*.pdf")

        'For Each fi In aryFi
        '    Dim BB As String = fi.Name.Substring(0, fi.Name.Length - 4)
        '    If Database.ExistingRecordCheck("AutopsyFaceSheet", "BB = " & BB) Then
        '        Dim tSubNum As New DataTable
        '        tSubNum = Database.ReturnTable("AutopsyFaceSheet", "SubNum", "BB = " & BB)
        '        Dim SubNum As Integer = tSubNum.Rows(0).Item(0)
        '        If Not SubjectFiles1to1.CheckFile("fileNeuropathFull", SubNum) Then
        '            If UploadDoc(fi, SubNum) Then
        '                fi.Delete()
        '            End If
        '        Else
        '            Rename(fi.FullName, fi.FullName.Substring(0, fi.FullName.Length - 4) & "- Already Exists.pdf")
        '        End If
        '    Else
        '        Rename(fi.FullName, fi.FullName.Substring(0, fi.FullName.Length - 4) & "- BB Not Found.pdf")
        '    End If
        'Next
        'Exports.MoveImages()
        WH_Imports.ImportMRI()
    End Sub

    Private Function UploadDoc(myIncomingFile As FileInfo, SubNum As Integer) As Boolean
        Try
            File.Copy(myIncomingFile.FullName, "Q:\WarehouseTemp\Temp.pdf")
            Dim query As New SqlCommand("", WarehouseShell.conn)
            Dim cmdText As String = "Insert into fileNeuropathFull (" &
                "SubNum, " &
                "FileData, " &
                "FileExtension, " &
                "FileSizeKB, " &
                "UploadDate) " &
                "values (" &
                SubNum & ", " &
                "(select * from openrowset(bulk N'Y:\Shares\Share\WarehouseTemp\Temp.pdf', single_blob) as n), " &
                "'.pdf', " &
                Math.Round(myIncomingFile.Length / 1024, 0) & ", " &
                "'" & Format(Date.Now, "MM-dd-yyyy").ToString() & "');"
            query.CommandText = cmdText
            query.ExecuteNonQuery()
            File.Delete("Q:\WarehouseTemp\Temp.pdf")
            Return True
        Catch ex As Exception
            ExceptionHandler.CatchWindowsException(ex)
            Return False
        End Try

    End Function

    Private Sub WA_ReportsSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If WarehouseShell.userName = "arnesj01" Or WarehouseShell.userName = "koueda01" Or WarehouseShell.userName = "bustam03" Then
            Josh.Visible = True
        Else
            Josh.Visible = False
        End If
    End Sub

    Public Sub TopLevel(val As Boolean) Implements IFormMethods.TopLevel
    End Sub
    Public Sub ShowPHI(val As Boolean) Implements IFormMethods.ShowPHI
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
    Private Sub IFormMethods_Parent(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Private Sub IFormMethods_Show() Implements IFormMethods.Show
        Show()
    End Sub
End Class