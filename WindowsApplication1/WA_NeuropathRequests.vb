Public Class WA_NeuropathRequests
    Implements IFormMethods
    Private formTables As New DataSet
    Private bs As New BindingSource
    Private BB As Decimal = 0

    Private Sub WA_NeuropathRequests_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setBB()
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        WarehouseShell.highlightSelectedNode("NPRequests")
        refreshDGV()
    End Sub

    Private Sub refreshDGV()
        dgvNPRequest.DataSource = Nothing

        If formTables.Tables().Contains("viewNeuropathRequests") Then
            formTables.Tables().Remove("viewNeuropathRequests")
        End If

        formTables.Tables.Add(Database.ReturnTable("viewNeuropathRequests", , "SubNum = " & WarehouseShell.SubNum))
        dgvNPRequest.DataSource = formTables.Tables("viewNeuropathRequests")
        dgvNPRequest.Columns("SubNum").Visible = False
        dgvNPRequest.Columns("BB").Visible = False
        dgvNPRequest.Columns("RTVal").Visible = False
        dgvNPRequest.Columns("DMVal").Visible = False
        dgvNPRequest.Columns("Address1").Visible = False
        dgvNPRequest.Columns("Address2").Visible = False
        dgvNPRequest.Columns("Address3").Visible = False
        dgvNPRequest.Columns("Address4").Visible = False
        dgvNPRequest.Columns("City").Visible = False
        dgvNPRequest.Columns("State").Visible = False
        dgvNPRequest.Columns("Zip").Visible = False
        dgvNPRequest.Columns("Email").Visible = False
        dgvNPRequest.Columns("Phone").Visible = False
        dgvNPRequest.Columns("Fax").Visible = False
        dgvNPRequest.Columns("SBVal").Visible = False
        dgvNPRequest.Columns("Consentor").Visible = False

        If dgvNPRequest.RowCount = 0 Then
            btnViewEdit.Enabled = False
        Else
            btnViewEdit.Enabled = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If User.PermissionCheck("WA_NeuropathRequests", "Modify") Then
            If BB <> 0 Then
                Dim pu As New PU_NeuropathRequest(BB)
                pu.ShowDialog()
                pu.Dispose()
                refreshDGV()
            Else
                MsgBox("Neuropath Requests use BB# and may not be added until the Autopsy Face Sheet is completed for this subject.", MsgBoxStyle.OkOnly, "Error")
            End If
        End If
    End Sub
    Private Sub btnViewEdit_Click(sender As Object, e As EventArgs) Handles btnViewEdit.Click
        Dim myRecordID As Integer = dgvNPRequest.SelectedRows(0).Cells("ID").Value
        Dim pu As New PU_NeuropathRequest(BB, myRecordID)
        pu.ShowDialog()
        pu.Dispose()
        refreshDGV()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If User.PermissionCheck("WA_NeuropathRequests", "Modify") Then
            Dim dateSent As String = dgvNPRequest.SelectedRows(0).Cells("DateSent").Value.ToString
            Dim id As String = dgvNPRequest.SelectedRows(0).Cells("ID").Value.ToString

            If dateSent = "" Then
                Dim cmd As New SqlCommand("delete from NeuropathRequests where RecordID = " & id, WarehouseShell.conn)
                cmd.ExecuteNonQuery()
                refreshDGV()
            Else
                MsgBox("This request has already been shipped and cannot be deleted.", MsgBoxStyle.OkOnly, "Error")
            End If
        End If
    End Sub

    Private Sub dgvNPRequest_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNPRequest.CellContentDoubleClick
        If dgvNPRequest.SelectedRows.Count > 0 Then
            btnViewEdit.PerformClick()
        End If
    End Sub

    Private Sub setBB()
        If Database.ExistingRecordCheck("AutopsyFaceSheet", "SubNum = " & WarehouseShell.SubNum) Then
            Dim cmd As New SqlCommand("select BB from AutopsyFaceSheet where SubNum = " & WarehouseShell.SubNum, WarehouseShell.conn)
            BB = cmd.ExecuteScalar()
        End If
    End Sub

    'Imported IFormMethods interface methods (some used, some not, based on which form is using the interface)
    Public Sub ShowPHI(showPHI As Boolean) Implements IFormMethods.ShowPHI
    End Sub
    Public Sub Parent1(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Public Sub Show1() Implements IFormMethods.Show
        Show()
    End Sub
    Public Sub TopLevel1(val As Boolean) Implements IFormMethods.TopLevel
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class