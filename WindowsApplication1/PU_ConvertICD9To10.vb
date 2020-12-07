Public Class PU_ConvertICD9To10
    Private icdCode As String
    Private autoFill_txtDxCodeType As TextBox_
    Private autoFill_txtDxCode As TextBox_
    Private autoFill_txtDxText As TextBox_

    Public Sub New(ByVal code As String, ByVal txtDxCodeType As TextBox_, ByVal txtDxCode As TextBox_, ByVal txtDxText As TextBox_)
        InitializeComponent()
        icdCode = code
        autoFill_txtDxCodeType = txtDxCodeType
        autoFill_txtDxCode = txtDxCode
        autoFill_txtDxText = txtDxText
    End Sub

    Private Sub pu_FormPermissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormatDGV()
    End Sub

    Private Function FormatDGV()
        Dim icdTenTable As New DataTable
        Dim qs As String = "select DXCode,DxText from lkpICD10 join lkpICDCode on lkpICD10.DxCode = lkpICDCode.ICD10 where lkpICDCode.ICD9 like " & "'" & icdCode & "'" & ";"

        Dim cmd As New SqlCommand(qs, WarehouseShell.conn)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        icdTenTable.Load(reader)
        dgvICDConversion.DataSource = icdTenTable
        dgvICDConversion.AutoResizeColumns()
        Return qs
    End Function

    Private Sub dgvICDConversion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvICDConversion.CellContentClick
        autoFill_txtDxCodeType.Text = "ICD-10 "
        autoFill_txtDxCode.Text = dgvICDConversion.SelectedRows(0).Cells("DXCode").Value.ToString()
        autoFill_txtDxText.Text = dgvICDConversion.SelectedRows(0).Cells("DxText").Value.ToString()
        Me.Hide()
    End Sub

    Private Sub Button_1_Click(sender As Object, e As EventArgs) Handles Button_1.Click
        Me.Hide()
    End Sub
End Class