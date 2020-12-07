Imports Korzh.EasyQuery.Db
Imports System.Reflection

Public Class WA_DNA_RNA_Volume
    Implements IFormMethods
    Private Reader As SqlDataAdapter
    Private Results As DataTable

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Dim _assembly As Assembly = Assembly.GetExecutingAssembly()
        eqModel.LoadFromStream(_assembly.GetManifestResourceStream("DataWarehouse.modelDNA_RNA_Volume.xml"))
    End Sub

    Private Sub WA_DNA_RNA_Volume_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_DNA_RNA_Volume")
        Results = New DataTable("Result")
        Reader = New SqlDataAdapter("Select * from viewDNA_RNA_Volume order by BB asc", WarehouseShell.conn)
        Reader.Fill(Results)
        formatDGV()
    End Sub

    Private Sub formatDGV()
        dgvResults.DataSource = Results
        lblTotalRows.Text = "Total Rows: " & Results.Rows.Count
    End Sub

    Private Sub btnQuery_Click(sender As Object, e As EventArgs) Handles btnQuery.Click
        Dim builder As New SqlQueryBuilder(eqQuery)
        If builder.CanBuild Then
            builder.BuildSQL()
            Dim sql As String = builder.Result.SQL
            Results = New DataTable("Result")
            Try
                Reader = New SqlDataAdapter(sql, WarehouseShell.conn)
                Reader.Fill(Results)
                formatDGV()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        pnlQuery.Query.Clear()
        Results = New DataTable("Result")
        Reader = New SqlDataAdapter("Select * from viewDNA_RNA_Volume order by BB asc", WarehouseShell.conn)
        Reader.Fill(Results)
        formatDGV()
    End Sub

    Private Sub btnCopyResults_Click(sender As Object, e As EventArgs) Handles btnCopyResults.Click
        Try
            Clipboard.SetDataObject(dgvResults.GetClipboardContent())
        Catch ex As Exception
            ExceptionHandler.CatchWindowsException(ex)
        End Try
    End Sub

    'IForm Methods
    Public Sub TopLevel(val As Boolean) Implements IFormMethods.TopLevel
    End Sub
    Private Sub IFormMethods_Parent(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Private Sub IFormMethods_Show() Implements IFormMethods.Show
    End Sub
    Public Sub ShowPHI(val As Boolean) Implements IFormMethods.ShowPHI
        Show()
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class