Public Class PU_TissueProjectsWOTaskers

    Private table As New DataSet
    Private dgvbs As BindingSource

    Private Sub dgvTissueProjects_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTissueProjects.CellDoubleClick
        WarehouseShell.StringArray = {
            dgvTissueProjects.SelectedRows(0).Cells("Project").Value.ToString(),
            dgvTissueProjects.SelectedRows(0).Cells("SubProject").Value.ToString(),
            dgvTissueProjects.SelectedRows(0).Cells("InternalSampleDescription").Value.ToString(),
            dgvTissueProjects.SelectedRows(0).Cells("NBTRRequestNum").Value.ToString(),
            dgvTissueProjects.SelectedRows(0).Cells("NumSamples").Value.ToString(),
            dgvTissueProjects.SelectedRows(0).Cells("NumGenerics").Value.ToString()}
        'WarehouseShell.String1 = dgvTissueProjects.SelectedRows(0).Cells("Project").Value.ToString()
        'WarehouseShell.String2 = dgvTissueProjects.SelectedRows(0).Cells("SubProject").Value.ToString()
        WarehouseShell.RecordID = dgvTissueProjects.SelectedRows(0).Cells("ProjectID").Value.ToString()
        'WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
        WarehouseShell.LoadWorkingAreaForm(WarehouseShell.formType.WA_TissueTasker)
        Me.Dispose()
    End Sub

    Private Sub PU_TissueProjectsWOTaskers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        table.Tables.Add(Database.ReturnTable("TissueRequests", "ProjectID, Project, SubProject, InternalSampleDescription, NBTRRequestNum, NumSamples, NumGenerics", "ProjectID not in (select ProjectID from TissueTasker) and ProjectID > 55"))
        dgvbs = New BindingSource
        dgvbs.DataSource = table.Tables("TissueRequests")
        dgvTissueProjects.DataSource = dgvbs
        dgvTissueProjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvTissueProjects.Columns("InternalSampleDescription").Visible = False
        dgvTissueProjects.Columns("NBTRRequestNum").Visible = False
        dgvTissueProjects.Columns("NumSamples").Visible = False
        dgvTissueProjects.Columns("NumGenerics").Visible = False
    End Sub

End Class