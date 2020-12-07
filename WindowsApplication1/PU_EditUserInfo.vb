Public Class PU_EditUserInfo
    Private userName
    Private formTables As New DataSet
    Public result As String

    Public Sub New(Optional ByVal myUserName As String = "")
        InitializeComponent()
        userName = myUserName
    End Sub
    Private Sub PU_EditUserInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBaseForm()
        If userName = "" Then
            SetDefaultValues()
        Else
            LoadExistingData()
            txtUserName.Enabled = False
        End If
    End Sub
    Private Sub LoadBaseForm()
        formTables.Tables.Add(Database.ReturnTable("refMobileCarrierSMS"))
        cmbMobileCarrier.assignLookup(formTables, "refMobileCarrierSMS", "RecordID", "CarrierName", , "CarrierName")
    End Sub
    Private Sub LoadExistingData()
        formTables.Tables.Add(Database.ReturnTable("refUser", , "UserName = '" & userName & "'"))
        chkActive.setValue(formTables, "refUser", "Active")
        txtUserName.setValue(formTables, "refUser", "UserName")
        txtName.setValue(formTables, "refUser", "Name")
        txtEmail.setValue(formTables, "refUser", "Email")
        intMobile.setValue(formTables, "refUser", "Mobile")
        cmbMobileCarrier.setValue(formTables, "refUser", "MobileCarrier")
    End Sub
    Private Sub SetDefaultValues()
        cmbMobileCarrier.SelectedValue = -1
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim cmd As New SqlCommand("", WarehouseShell.conn)

        If userName = "" Then
            cmd.CommandText = "select Max(RaterID) from refUser;"
            Dim raterID As Integer = cmd.ExecuteScalar() + 1
            cmd.CommandText = "insert into refUser(RaterID, UserName, Name, Email, Mobile, MobileCarrier, Active) values (" &
                raterID &
                ", " & txtUserName.getSQLValue() &
                ", " & txtName.getSQLValue() &
                ", " & txtEmail.getSQLValue() &
                ", " & intMobile.getSQLValue() &
                ", " & cmbMobileCarrier.getSQLValue() &
                ", " & chkActive.getSQLValue() &
                ");"
        Else
            cmd.CommandText = "Update refUser set " &
                "Username = " & txtUserName.getSQLValue() &
                ", Name = " & txtName.getSQLValue() &
                ", Email = " & txtEmail.getSQLValue() &
                ", Mobile = " & intMobile.getSQLValue() &
                ", MobileCarrier = " & cmbMobileCarrier.getSQLValue() &
                ", Active = " & chkActive.getSQLValue() &
                " where UserName = '" & userName & "';"
        End If

        Try
            cmd.ExecuteNonQuery()
            result = "Ok"
            Me.Hide()
        Catch ex As SqlException
            ExceptionHandler.CatchSQLException(ex)
        End Try
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        result = "Cancel"
        Me.Hide()
    End Sub
End Class