Public Class PU_PurchaseRequestItem
    Private RequestID As Integer
    Private RecordID As Integer
    Private mode As String
    Private formTables As New DataSet

    Public Sub New(ByVal myRequestID As Integer, ByVal myRecordID As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        RequestID = myRequestID
        RecordID = myRecordID
    End Sub

    Private Sub PU_PurchaseRequestItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBaseForm()
        If RecordID <> 0 Then
            mode = "Edit"
            LoadExistingData()
        Else
            mode = "Insert"
            Category.SelectedValue = 6
            Recipient.SelectedValue = WarehouseShell.userName
        End If
    End Sub

    Private Sub LoadBaseForm()
        formTables.Tables.Add(Database.ReturnTable("lkpPurchaseRequestCategory"))
        formTables.Tables.Add(Database.ReturnTable("refUser",, "Active = 1"))
        Category.assignLookup(formTables, "lkpPurchaseRequestCategory")
        Recipient.assignLookup(formTables, "refUser", "UserName", "Name",, "Name")
    End Sub

    Private Sub LoadExistingData()
        Dim table As DataTable = Database.ReturnTable("PurchaseRequestItems", , "RecordID = " & RecordID)
        Category.SelectedValue = table.Rows(0).Item("Category")
        ItemDescription.Text = table.Rows(0).Item("ItemDescription").ToString
        Quantity.Text = table.Rows(0).Item("Quantity").ToString
        UnitCost.Text = table.Rows(0).Item("UnitCost").ToString
        Recipient.SelectedValue = table.Rows(0).Item("Recipient")
    End Sub

    Private Sub textbox_KeyDown(sender As Object, e As KeyEventArgs) Handles ItemDescription.KeyDown, Quantity.KeyDown, UnitCost.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnSaveAdd.PerformClick()
        End If
    End Sub

    Private Sub btnCategory_Click(sender As Object, e As EventArgs) Handles btnCategory.Click
        Dim pu As New PU_PurchaseRequestAddSourceOrCategory("Category")
        pu.ShowDialog()
        If pu.lkpID <> 0 Then
            formTables.Tables.Remove("lkpPurchaseRequestCategory")
            formTables.Tables.Add(Database.ReturnTable("lkpPurchaseRequestCategory"))
            Category.assignLookup(formTables, "lkpPurchaseRequestCategory",,,, "Label")
            Category.SelectedValue = pu.lkpID
            pu.Dispose()
        End If
    End Sub

    Private Function PreSaveValidation() As Boolean
        Dim result As Boolean = True
        Dim errMsg As String = "The following errors exist and need to be corrected before record can be saved:" & vbNewLine & vbNewLine

        If ItemDescription.Text = "" Then
            result = False
            errMsg += "- Please enter an Item Description." & vbNewLine
        End If

        If Quantity.Text = "" Then
            result = False
            errMsg += "- Please enter a Qty." & vbNewLine
        End If

        If UnitCost.Text = "" Then
            result = False
            errMsg += "- Please enter a Unit Cost." & vbNewLine
        End If

        If Recipient.SelectedValue = "blank01" Then
            result = False
            errMsg += "- Please select a Recipient." & vbNewLine
        End If

        If result = False Then
            MsgBox(errMsg, , "Errors Exist!")
        End If

        Return result
    End Function

    Private Sub ResetForm()
        ItemDescription.Text = ""
        Quantity.Text = ""
        UnitCost.Text = ""
        ItemDescription.Select()
    End Sub

    Private Sub btnSaveClose_Click(sender As Object, e As EventArgs) Handles btnSaveClose.Click
        If PreSaveValidation() Then
            Dim sqlCommand As New SqlCommand
            sqlCommand.Connection = WarehouseShell.conn

            Dim parameters = "@RecordID = " & RecordID &
                ", @RequestID = " & RequestID &
                ", @Category = " & Category.getSQLValue() &
                ", @ItemDescription = " & ItemDescription.getSQLValue() &
                ", @Quantity = " & Quantity.getSQLValue() &
                ", @UnitCost = " & UnitCost.getSQLValue() &
                ", @Recipient = " & Recipient.getSQLValue() &
                ", @LastModBy = '" & WarehouseShell.userName & "'" &
                ", @LastModDate = '" & Now().ToShortDateString() & "';"

            If mode = "Insert" Then
                Try
                    sqlCommand.CommandText = "EXEC dbo.modPurchaseRequestItemsRecord @Action = 1, " & parameters
                    sqlCommand.ExecuteScalar()
                    Dispose()
                Catch ex As SqlException
                    ExceptionHandler.CatchSQLException(ex)
                End Try
            Else
                Try
                    sqlCommand.CommandText = "EXEC dbo.modPurchaseRequestItemsRecord @Action = 2, " & parameters
                    sqlCommand.ExecuteScalar()
                    Dispose()
                Catch ex As SqlException
                    ExceptionHandler.CatchSQLException(ex)
                End Try
            End If
        End If
    End Sub

    Private Sub btnSaveAdd_Click(sender As Object, e As EventArgs) Handles btnSaveAdd.Click
        If PreSaveValidation() Then
            Dim sqlCommand As New SqlCommand
            sqlCommand.Connection = WarehouseShell.conn

            Dim parameters = "@RecordID = " & RecordID &
                ", @RequestID = " & RequestID &
                ", @Category = " & Category.getSQLValue() &
                ", @ItemDescription = " & ItemDescription.getSQLValue() &
                ", @Quantity = " & Quantity.getSQLValue() &
                ", @UnitCost = " & UnitCost.getSQLValue() &
                ", @Recipient = " & Recipient.getSQLValue() &
                ", @LastModBy = '" & WarehouseShell.userName & "'" &
                ", @LastModDate = '" & Now().ToShortDateString() & "';"

            If mode = "Insert" Then
                Try
                    sqlCommand.CommandText = "EXEC dbo.modPurchaseRequestItemsRecord @Action = 1, " & parameters
                    sqlCommand.ExecuteScalar()
                Catch ex As SqlException
                    ExceptionHandler.CatchSQLException(ex)
                End Try
            Else
                Try
                    sqlCommand.CommandText = "EXEC dbo.modPurchaseRequestItemsRecord @Action = 2, " & parameters
                    sqlCommand.ExecuteScalar()
                Catch ex As SqlException
                    ExceptionHandler.CatchSQLException(ex)
                End Try
            End If

            mode = "Insert"
            ResetForm()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dispose()
    End Sub
End Class