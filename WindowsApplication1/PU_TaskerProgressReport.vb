Public Class PU_TaskerProgressReport

    Private myReportID As Integer = Nothing
    Private formTable As New DataSet
    Private tooltip1 As New ToolTip

    'Define on-load actions
    Private Sub PU_WeeklyTaskerUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DirectCast(WarehouseShell.WorkingAreaForm, WA_TissueTasker).ReportID = 0 Then
            txtReportDate.Text = Format(Now(), "MM-dd-yyyy").ToString
            loadFileData()
            generateReportID()
        Else
            myReportID = DirectCast(WarehouseShell.WorkingAreaForm, WA_TissueTasker).ReportID
            loadFileData()
            formTable.Tables.Add(Database.ReturnTable("TissueTaskerProgressReports", , "ReportID = '" & myReportID & "' and ProjectID = '" & DirectCast(WarehouseShell.WorkingAreaForm, WA_TissueTasker).ProjectID & "'"))
            txtReportDate.setValue(formTable, "TissueTaskerProgressReports", "ReportDate")
            txtSamplesCompleted.setValue(formTable, "TissueTaskerProgressReports", "SamplesCompleted")
            txtNote.setValue(formTable, "TissueTaskerProgressReports", "Note")
        End If
    End Sub

    Private Sub generateReportID()
        If Database.ExistingRecordCheck("TissueTaskerProgressReports", "ProjectID = " & DirectCast(WarehouseShell.WorkingAreaForm, WA_TissueTasker).ProjectID) = True Then
            Dim cmd As New SqlCommand("Select max(ReportID) + 1 from TissueTaskerProgressReports where ProjectID = '" & DirectCast(WarehouseShell.WorkingAreaForm, WA_TissueTasker).ProjectID & "';", WarehouseShell.conn)
            myReportID = cmd.ExecuteScalar()
        Else
            myReportID = 1
        End If
    End Sub

    'Sub to load File data (ran on load, regardless of mode)
    Private Sub loadFileData()
        If SystemFiles1toMany.CheckFile("fileTissueTaskerUpdates", WarehouseShell.RecordID, myReportID) Then
            btnReport.Text = "View Weekly Update"
            btnReport.BackColor = Color.Chartreuse
            btnRemove.Enabled = True
        Else
            btnReport.Text = "Add Weekly Update"
            btnReport.BackColor = Color.Linen
            btnRemove.Enabled = False
        End If
    End Sub

    'Define button click events
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If DirectCast(WarehouseShell.WorkingAreaForm, WA_TissueTasker).ReportID = 0 Then
            Try
                Dim cmd As New SqlCommand("EXEC dbo.InsertTissueTaskerProgressReportsRecord " &
                    "@ReportID = " & myReportID &
                    ", @ProjectID = " & DirectCast(WarehouseShell.WorkingAreaForm, WA_TissueTasker).ProjectID &
                    ", @ReportDate = " & txtReportDate.getSQLValue() &
                    ", @SamplesCompleted = " & txtSamplesCompleted.getSQLValue() &
                    ", @Note = " & txtNote.getSQLValue() & ";", WarehouseShell.conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                cmd.CommandText = "Update TissueTasker Set TotalComplete = (select top(1) SamplesCompleted from TissueTaskerProgressReports where ProjectID = " & DirectCast(WarehouseShell.WorkingAreaForm, WA_TissueTasker).ProjectID & " order by ReportID desc) where ProjectID = " & DirectCast(WarehouseShell.WorkingAreaForm, WA_TissueTasker).ProjectID & ";"
                cmd.ExecuteNonQuery()
                WarehouseShell.LoadWorkingAreaForm(WarehouseShell.formType.WA_TissueTasker)
                Me.Dispose()
            Catch ex As SqlException
                ExceptionHandler.CatchSQLException(ex)
            End Try
        Else
            Try
                Dim cmd As New SqlCommand("EXEC dbo.UpdateTissueTaskerProgressReportsRecord " &
                    "@ReportID = " & myReportID &
                    ", @ProjectID = " & DirectCast(WarehouseShell.WorkingAreaForm, WA_TissueTasker).ProjectID &
                    ", @ReportDate = " & txtReportDate.getSQLValue() &
                    ", @SamplesCompleted = " & txtSamplesCompleted.getSQLValue() &
                    ", @Note = " & txtNote.getSQLValue() & ";", WarehouseShell.conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Changes saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                cmd.CommandText = "Update TissueTasker Set TotalComplete = (select top(1) SamplesCompleted from TissueTaskerProgressReports where ProjectID = " & DirectCast(WarehouseShell.WorkingAreaForm, WA_TissueTasker).ProjectID & " order by ReportID desc) where ProjectID = " & DirectCast(WarehouseShell.WorkingAreaForm, WA_TissueTasker).ProjectID & ";"
                cmd.ExecuteNonQuery()
                WarehouseShell.LoadWorkingAreaForm(WarehouseShell.formType.WA_TissueTasker)
                Me.Dispose()
            Catch ex As SqlException
                ExceptionHandler.CatchSQLException(ex)
            End Try
        End If
    End Sub
    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        If DirectCast(WarehouseShell.WorkingAreaForm, WA_TissueTasker).ReportID <> myReportID Then
            tooltip1.Show("Please save this update before attempting to upload an Update document.", btnReport, 0, 20, 5000)
        Else
            If btnReport.BackColor = Color.Chartreuse Then
                SystemFiles1toMany.OpenFile("fileTissueTaskerUpdates", WarehouseShell.RecordID, myReportID, "Tissue Tasker " & WarehouseShell.RecordID & " Update " & myReportID)
            Else
                SystemFiles1toMany.SaveFile("fileTissueTaskerUpdates", WarehouseShell.RecordID, myReportID)
                loadFileData()
            End If
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DirectCast(WarehouseShell.WorkingAreaForm, WA_TissueTasker).ReportID = 0
        Me.Dispose()
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        SystemFiles1toMany.DeleteFile("fileTissueTaskerUpdates", WarehouseShell.RecordID, myReportID)
        loadFileData()
    End Sub
End Class