Public Class PU_PurchaseRequestAddSourceOrCategory
    Private sourceOrCategory As String
    Public lkpID As Integer

    Public Sub New(ByVal mySourceOrCategory As String)
        InitializeComponent()
        sourceOrCategory = mySourceOrCategory
    End Sub

    Private Sub PU_PurchaseRequestAddSourceOrProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If sourceOrCategory = "Source" Then
            Text = "Add a New Source"
        Else
            Text = "Add a New Category"
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Label.Text <> "" Then
            Dim cmd As New SqlCommand("Insert into " & IIf(sourceOrCategory = "Source", "lkpPurchaseRequestSource", "lkpPurchaseRequestCategory") & " (Label) values (" & Label.getSQLValue() & ");", WarehouseShell.conn)
            Try
                cmd.ExecuteNonQuery()
                cmd.CommandText = "select top(1) Value from " & IIf(sourceOrCategory = "Source", "lkpPurchaseRequestSource", "lkpPurchaseRequestCategory") & " order by Value desc;"
                lkpID = cmd.ExecuteScalar()
                Hide()
            Catch ex As SqlException
                ExceptionHandler.CatchSQLException(ex)
            End Try
        Else
            MsgBox("Please enter a " & IIf(sourceOrCategory = "Source", "Source", "Category") & "name or click Cancel button.", MsgBoxStyle.OkOnly, "Error!")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        lkpID = 0
        Hide()
    End Sub
End Class