Public Class PU_PurchaseRequest
    Private formTables As New DataSet
    Private requestID As Integer
    Private ListenForChanges As Boolean
    Private submitted As Boolean
    Private reviewed As Boolean

    Public Sub New(ByVal myRequestID As Integer)
        InitializeComponent()
        requestID = myRequestID
        submitted = False
        reviewed = False
    End Sub

    Private Sub PU_PurchaseRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBaseForm()
        FormatDGV()
        If RequestID <> 0 Then
            LoadExistingData()
            btnRequestHeader.Text = "Edit Request Header"
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            EnableItemButtons(True)
            EnableHeaderInputFields(False)
            submitted = Database.ExistingRecordCheck("PurchaseRequests", "RequestID = " & requestID & " and SubmittedForReview = 1")
            reviewed = Database.ExistingRecordCheck("PurchaseRequests", "RequestID = " & requestID & " and ReviewComplete = 1")
        Else
            SetDefaultValues()
            btnRequestHeader.Text = "Save Request Header"
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
            EnableHeaderInputFields(True)
            EnableItemButtons(False)
        End If
        FormatSubmitButton()
        SetRequestStatus()
    End Sub

    Private Sub EnableHeaderInputFields(ByVal bool As Boolean)
        Requestor.Enabled = bool
        RequestDate.makeReadOnly(Not bool)
        ChargeTo.Enabled = bool
        Source.Enabled = bool
        btnSource.Enabled = bool
        Comments.makeReadOnly(Not bool)
    End Sub

    Private Sub EnableItemButtons(ByVal bool As Boolean)
        btnAddItem.Enabled = bool
        If dgvLineItems.Rows.Count > 0 Then
            btnEditItem.Enabled = bool
            btnDelete.Enabled = bool
        Else
            btnEditItem.Enabled = False
            btnDelete.Enabled = False
        End If
    End Sub

    Private Sub LoadBaseForm()
        formTables.Tables.Add(Database.ReturnTable("refUser",, " Active = 1"))
        formTables.Tables.Add(Database.ReturnTable("lkpPurchaseRequestChargeTo"))
        formTables.Tables.Add(Database.ReturnTable("lkpPurchaseRequestSource"))
        Requestor.assignLookup(formTables, "refUser", "UserName", "Name", , "Name")
        ChargeTo.assignLookup(formTables, "lkpPurchaseRequestChargeTo",,,, "Label")
        Source.assignLookup(formTables, "lkpPurchaseRequestSource",,,, "Label")
    End Sub

    Private Sub SetDefaultValues()
        Requestor.SelectedValue = WarehouseShell.userName
        RequestDate.Text = Now().ToString("MM/dd/yyyy")
        ChargeTo.SelectedValue = 12
        Source.SelectedValue = 1
    End Sub

    Private Sub LoadExistingData()
        formTables.Tables.Add(Database.ReturnTable("PurchaseRequests", , "RequestID = " & requestID))
        Requestor.setValue(formTables, "PurchaseRequests", "Requestor")
        RequestDate.setValue(formTables, "PurchaseRequests", "RequestDate")
        ChargeTo.setValue(formTables, "PurchaseRequests", "ChargeTo")
        Source.setValue(formTables, "PurchaseRequests", "Source")
        Comments.setValue(formTables, "PurchaseRequests", "Comments")
    End Sub

    Private Sub FormatSubmitButton()
        If WarehouseShell.userName <> "harouv01" Then
            btnSubmit.Text = "Submit for Review"
        Else
            btnSubmit.Text = "Approve Request"
        End If
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            btnSubmit.Enabled = True
        Else
            btnSubmit.Enabled = False
        End If
    End Sub

    Private Sub btnRequestHeader_Click(sender As Object, e As EventArgs) Handles btnRequestHeader.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If Not reviewed Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                EnableHeaderInputFields(True)
                btnRequestHeader.Text = "Save Request Header"
            Else
                MsgBox("This request has already been reviewed and may not be further edited.", MsgBoxStyle.OkOnly, "Warning")
            End If
        Else
            If PreSaveValidation() Then
                Dim sqlCommand As New SqlCommand
                sqlCommand.Connection = WarehouseShell.conn

                Dim parameters = "@RequestID = " & requestID &
                    ", @RequestDate = " & RequestDate.getSQLValue() &
                    ", @Source = " & Source.getSQLValue() &
                    ", @ChargeTo = " & ChargeTo.getSQLValue() &
                    ", @Requestor = " & Requestor.getSQLValue() &
                    ", @Comments = " & Comments.getSQLValue() &
                    ", @LastModBy = '" & WarehouseShell.userName & "';"

                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    sqlCommand.CommandText = "EXEC dbo.modPurchaseRequestsRecord @Action = 1, " & parameters
                    sqlCommand.ExecuteScalar()
                    WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    sqlCommand.CommandText = "select max(RequestID) as Req from PurchaseRequests;"
                    requestID = sqlCommand.ExecuteScalar()
                Else
                    sqlCommand.CommandText = "EXEC dbo.modPurchaseRequestsRecord @Action = 2, " & parameters
                    sqlCommand.ExecuteScalar()
                    WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                End If

                btnRequestHeader.Text = "Edit Request Header"
                EnableHeaderInputFields(False)
                EnableItemButtons(True)
            End If
        End If
        FormatSubmitButton()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If WarehouseShell.userName = "harouv01" Then
            ReviewComplete()
        Else
            RequestReview()
        End If
    End Sub

    Private Sub btnSource_Click(sender As Object, e As EventArgs) Handles btnSource.Click
        Dim pu As New PU_PurchaseRequestAddSourceOrCategory("Source")
        pu.ShowDialog()
        If pu.lkpID <> 0 Then
            formTables.Tables.Remove("lkpPurchaseRequestSource")
            formTables.Tables.Add(Database.ReturnTable("lkpPurchaseRequestSource"))
            Source.assignLookup(formTables, "lkpPurchaseRequestSource",,,, "Label")
            Source.SelectedValue = pu.lkpID
            pu.Dispose()
        End If
    End Sub

    Private Sub RequestReview()
        If dgvLineItems.RowCount > 0 Then
            'determine if the user is submitting or RESUBMITTING the request
            Dim submitResubmit As String = IIf(Database.ExistingRecordCheck("PurchaseRequests", "RequestID = " & requestID & " and SubmittedForReview = 0;"), "submitted", "RESUBMITTED")

            'update the record to show that it has been submitted for review
            Dim cmd As New SqlCommand("update PurchaseRequests set SubmittedForReview = 1 where RequestID = " & requestID & ";", WarehouseShell.conn)
            Try
                cmd.ExecuteNonQuery()
            Catch ex As SqlException
                ExceptionHandler.CatchSQLException(ex)
            End Try

            'email harry to alert him of the new submit
            Dim subject As String = ""
            Dim body As String = ""

            subject = "'Purchase Request #" & requestID & " " & submitResubmit & " for Review'"
            body = "'Purchase request #" & requestID & " has been " & submitResubmit & " and is ready for your review.'"
            cmd.CommandText = "
                exec msdb.dbo.sp_send_dbmail
                @recipients = 'vahram.haroutunian@mssm.edu',
                @from_address = 'NBTR@mssm.edu',
                @subject = " & subject & ",
                @body = " & body & ";"
            Try
                cmd.ExecuteNonQuery()
            Catch ex As SqlException
                ExceptionHandler.CatchSQLException(ex)
            End Try

            'let user know the request has been submitted
            MsgBox("This purchase request has been " & submitResubmit & " for review.", MsgBoxStyle.OkOnly, "Success")

            submitted = True
            SetRequestStatus()
        End If
    End Sub

    Private Sub ReviewComplete()
        'make sure each item has been approved or denied
        Dim cmd As New SqlCommand("select count(*) from PurchaseRequestItems where RequestID = " & requestID & " and Approved in (1, 2);", WarehouseShell.conn)
        Dim reviewedItemCount As Integer = cmd.ExecuteScalar()

        If reviewedItemCount = dgvLineItems.RowCount Then
            'update the record to show that is has been reviewed
            cmd.CommandText = "update PurchaseRequests set ReviewComplete = 1 where RequestID = " & requestID & ";"
            Try
                cmd.ExecuteNonQuery()
            Catch ex As SqlException
                ExceptionHandler.CatchSQLException(ex)
            End Try

            'email requestor to let them know the request has been reviewed
            Dim subject As String = "Purchase Request #" & requestID & " has been reviewed."
            Dim body As String = ""
            'check if any items were approved
            cmd.CommandText = "select count(*) from PurchaseRequestItems where RequestID = " & requestID & " and Approved = 1;"
            Dim approvedCount As Integer = cmd.ExecuteScalar()
            If approvedCount > 0 Then
                body = "Your purchase request #" & requestID & " has been reviewed and the attached items have been approved for purchase."
            Else
                body = "Your purchase request #" & requestID & " has been reviewed and no items were approved for purchase."
            End If

            'create the SQL email command
            cmd.CommandText = "select Email from refUser where UserName = '" & Requestor.SelectedValue & "';"
            Dim recipients As String = cmd.ExecuteScalar()
            cmd.CommandText = "
            declare @Column1Name nvarchar(max) 
            declare @Query nvarchar(max) 
            set @Column1Name = '[sep=,' + CHAR(13) + CHAR(10) + 'RequestID]' 
            set @Query = 'set nocount on; 
                select 
                    RequestID as ' + @Column1Name + ',
                    ''""'' + [Charge To] + ''""'' as [Charge To],
                    ''""'' + [Source/Vendor] + ''""'' as [Source/Vendor],
                    ''""'' + Category + ''""'' as Category,
                    ''""'' + [Item Description] + ''""'' as [Item Description],
                    Qty,
                    [Unit Cost],
                    SubTotal,
                    ''""'' + Recipient + ''""'' as Recipient,
                    ''""'' + [Harry Notes] + ''""'' as [Harry Notes]
                from 
                    Warehouse.dbo.viewPurchaseRequestApprovedAttachement
                where
                    RequestID = " & requestID & "';

            exec msdb.dbo.sp_send_dbmail
                @from_address = 'NBTR@mssm.edu',
                @recipients = '" & recipients & "',
                @subject = '" & subject & "',
                @body = '" & body & "',
                @query = @Query,
                @attach_query_result_as_file = 1,
                @query_attachment_filename = 'Purchase_Request_Approved_Items.csv',
                @query_result_separator = ',',
                @query_result_no_padding = 1,
                @query_result_width = 32767;"
            Try
                cmd.ExecuteNonQuery()
                MsgBox("This purchase requests has now been reviewed. The requestor has been sent an email with the approved items listed (if any).", MsgBoxStyle.OkOnly, "Success")

                reviewed = True
                SetRequestStatus()
            Catch ex As SqlException
                ExceptionHandler.CatchSQLException(ex)
            End Try
        Else
            MsgBox("Please make sure all items are either approved or denied.", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Sub SetRequestStatus()
        chkSubmitted.Checked = submitted
        chkReviewed.Checked = reviewed
    End Sub

    Private Sub FormatDGV()
        ListenForChanges = False

        If formTables.Tables.Contains("viewPurchaseRequestItems") Then
            formTables.Tables.Remove("viewPurchaseRequestItems")
        End If
        formTables.Tables.Add(Database.ReturnTable("viewPurchaseRequestItems", , "RequestID = " & requestID))
        dgvLineItems.DataSource = formTables.Tables("viewPurchaseRequestItems")
        dgvLineItems.ReadOnly = False
        dgvLineItems.Columns().Item("RequestID").Visible = False
        dgvLineItems.Columns().Item("RecordID").Visible = False
        'TODO: Set column widths and ReadOnly columns (with If statement for Harry)
        dgvLineItems.Columns().Item("Item Description").ReadOnly = True
        dgvLineItems.Columns().Item("Qty").ReadOnly = True
        dgvLineItems.Columns().Item("Unit Cost").ReadOnly = True
        dgvLineItems.Columns().Item("SubTotal").ReadOnly = True

        If WarehouseShell.userName <> "harouv01" Then
            dgvLineItems.Columns().Item("Approved").ReadOnly = True
            dgvLineItems.Columns().Item("Denied").ReadOnly = True
            dgvLineItems.Columns().Item("Harry Notes").ReadOnly = True
        Else
            dgvLineItems.Columns().Item("Approved").ReadOnly = False
            dgvLineItems.Columns().Item("Denied").ReadOnly = False
            dgvLineItems.Columns().Item("Harry Notes").ReadOnly = False
        End If

        dgvLineItems.AutoResizeColumns()

        ListenForChanges = True
    End Sub

    Private Sub dgvLineItems_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLineItems.CellContentDoubleClick
        Dim row As DataGridViewRow = dgvLineItems.Rows(e.RowIndex)
        EditItem(row)
    End Sub

    Private Sub CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLineItems.CellContentClick
        If ListenForChanges Then
            If e.ColumnIndex = 8 Or e.ColumnIndex = 9 Then
                If dgvLineItems.Columns(e.ColumnIndex).ReadOnly = False Then
                    Dim row As DataGridViewRow = dgvLineItems.Rows(e.RowIndex)
                    Dim recordID As Integer = row.Cells("RecordID").Value
                    Dim result As Integer

                    ListenForChanges = False

                    If e.ColumnIndex = 8 Then
                        If row.Cells("Approved").Value = False Then
                            row.Cells("Approved").Value = True
                            result = 1
                        Else
                            result = 3
                        End If
                        row.Cells("Denied").Value = False
                    Else
                        If row.Cells("Denied").Value = False Then
                            row.Cells("Denied").Value = True
                            result = 2
                        Else
                            result = 3
                        End If
                        row.Cells("Approved").Value = False
                    End If

                    ListenForChanges = True

                    UpdateApproval(recordID, result)
                End If
            End If
        End If
    End Sub

    Private Sub CellContentChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLineItems.CellValueChanged
        If ListenForChanges Then
            If e.ColumnIndex = 10 Then
                Dim row As DataGridViewRow = dgvLineItems.Rows(e.RowIndex)
                Dim recordID As Integer = row.Cells("RecordID").Value
                Dim notes As String = row.Cells("Harry Notes").Value.ToString
                Dim cmd As New SqlCommand("update PurchaseRequestItems Set Notes = '" & notes & "' where RecordID = " & recordID & ";", WarehouseShell.conn)

                Try
                    cmd.ExecuteNonQuery()
                Catch ex As SqlException
                    ExceptionHandler.CatchSQLException(ex)
                End Try
            End If
        End If
    End Sub

    Private Sub UpdateApproval(ByVal recordID As Integer, ByVal val As Integer)
        Dim cmd As New SqlCommand("update PurchaseRequestItems Set Approved = " & val & " where RecordID = " & recordID & ";", WarehouseShell.conn)

        Try
            cmd.ExecuteNonQuery()
        Catch ex As SqlException
            ExceptionHandler.CatchSQLException(ex)
        End Try
    End Sub

    Private Function PreSaveValidation() As Boolean
        Dim result As Boolean = True
        Dim errMsg As String = "The following errors exist and need to be corrected before record can be saved:" & vbNewLine & vbNewLine

        If Requestor.SelectedValue = "blank01" Then
            result = False
            errMsg += "- Please select a Requestor." & vbNewLine
        End If

        If RequestDate.Text = "  /  /" Then
            result = False
            errMsg += "- Please enter a Request Date." & vbNewLine
        End If

        If result = False Then
            MsgBox(errMsg, , "Errors Exist!")
        End If

        Return result
    End Function

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If Not reviewed Then
            Dim pu As New PU_PurchaseRequestItem(requestID, 0)
            pu.ShowDialog()
            FormatDGV()
            If dgvLineItems.RowCount >= 1 Then
                btnEditItem.Enabled = True
                btnDelete.Enabled = True
            End If
        Else
            MsgBox("This request has already been reviewed and may not be further edited.", MsgBoxStyle.OkOnly, "Warning")
        End If

    End Sub

    Private Sub btnEditItem_Click(sender As Object, e As EventArgs) Handles btnEditItem.Click
        If Not reviewed Then
            Dim cell As DataGridViewCell = dgvLineItems.SelectedCells(0)
            Dim row As DataGridViewRow = dgvLineItems.Rows(cell.RowIndex)
            If row.Cells("Approved").Value = False And row.Cells("Denied").Value = False Then
                EditItem(row)
            Else
                MsgBox("Items that have already been Approved or Denied cannot be edited. If you need to make a change, please remove this item and create a new item.", MsgBoxStyle.OkOnly, "Warning")
            End If
        Else
            MsgBox("This request has already been reviewed and may not be further edited.", MsgBoxStyle.OkOnly, "Warning")
        End If
    End Sub

    Private Sub EditItem(ByVal row As DataGridViewRow)
        Dim recordID As Integer = row.Cells("recordID").Value
        Dim pu As New PU_PurchaseRequestItem(requestID, recordID)
        pu.ShowDialog()
        FormatDGV()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim cell As DataGridViewCell = dgvLineItems.SelectedCells(0)
        Dim recordID As String = dgvLineItems.Rows(cell.RowIndex).Cells("RecordID").Value.ToString
        Dim cmd As New SqlCommand("delete from PurchaseRequestItems where RecordID = " & recordID & ";", WarehouseShell.conn)
        Dim result As DialogResult = MsgBox("You are about to delete this item. Would you like to continue?", MsgBoxStyle.YesNo, "Warning")
        If result = DialogResult.Yes Then
            Try
                cmd.ExecuteNonQuery()
                FormatDGV()
            Catch ex As SqlException
                ExceptionHandler.CatchSQLException(ex)
            End Try
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Or WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit Then
            Dim result As DialogResult = MsgBox("You have unsaved changes to this request. Would you like to continue?", MsgBoxStyle.YesNo, "Warning")
            If DialogResult = DialogResult.Yes Then
                Exit Sub
            End If
        End If
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        Dispose()
    End Sub
End Class