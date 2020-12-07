Public Class JoshTest
    Private userName

    Public Sub New(ByVal myUserName As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        userName = myUserName
    End Sub

    Private Sub Role_CheckedChanged(sender As Object, e As EventArgs) Handles Admin.CheckedChanged, Prosector.CheckedChanged
        Dim cmd As New SqlCommand("", WarehouseShell.conn)
        If CType(sender, CheckBox_).Checked Then
            cmd.CommandText = "insert into UserRoles (UserName, RoleID) select '" & userName & "', Value from lkpUserRoles where Label = '" & CType(sender, CheckBox_).Name & "');"
        Else
            cmd.CommandText = "delete from UserRoles where UserName = '" & userName & "' and RoleID = (select RoleID from lkpUserRoles where Label = '" & CType(sender, CheckBox_).Name & "');"
        End If
    End Sub

    Private Sub JoshTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
