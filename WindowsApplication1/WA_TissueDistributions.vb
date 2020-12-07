Public Class WA_TissueDistributions
    Implements IFormMethods
    Private formTables As New DataSet
    Private bs As BindingSource

    Private Sub WA_TissueDistributions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formTables.Tables.Add(Database.ReturnTable("viewTissueDistributions", "Project, SubProject, NBTRRequestNum as 'NBTR#', InstituteName, RequestingPI, BrainRegion, Qty, DateShipped"))
        bs = New BindingSource
        bs.DataSource = formTables.Tables("viewTissueDistributions")
        dgvDistribution.DataSource = bs
        dgvDistribution.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        dgvDistribution.MultiSelect = True
        dgvDistribution.Columns("Project").Width = 400
        dgvDistribution.Columns("SubProject").Width = 130
        dgvDistribution.Columns("NBTR#").Width = 55
        dgvDistribution.Columns("InstituteName").Width = 200
        dgvDistribution.Columns("RequestingPI").Width = 140
        dgvDistribution.Columns("BrainRegion").Width = 110
        dgvDistribution.Columns("Qty").Width = 40
        dgvDistribution.Columns("DateShipped").Width = 75
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
    End Sub

    Public Sub TopLevel(val As Boolean) Implements IFormMethods.TopLevel
    End Sub
    Private Sub IFormMethods_Parent(ByRef val As Object) Implements IFormMethods.Parent
        Me.Parent = val
    End Sub
    Private Sub IFormMethods_Show() Implements IFormMethods.Show
        Show()
    End Sub
    Public Sub ShowPHI(val As Boolean) Implements IFormMethods.ShowPHI
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
    End Sub
End Class