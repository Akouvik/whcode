Public Class WA_TangleCounts
    Implements IFormMethods
    Private insertString As String = Nothing
    Private updateString As String = Nothing
    Private formTables As New DataSet

    'Form load subs
    Private Sub WA_TangleCounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_TangleCounts")
        If Database.ExistingRecordCheck("TangleCounts", "SubNum = " & WarehouseShell.SubNum) = True Then
            enableInputFields(False)
            formTables.Tables.Add(Database.ReturnTable("TangleCounts", , "SubNum = " & WarehouseShell.SubNum))
            loadExistingData()
            btnTangleCountsBottom.Text = "Edit this record"
            btnTangleCountsTop.Text = btnTangleCountsBottom.Text
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        Else
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            btnTangleCountsBottom.Text = "Add New Record"
            btnTangleCountsTop.Text = btnTangleCountsBottom.Text
            enableInputFields(False)
            lblNoRecord.Visible = True
        End If
    End Sub
    Private Sub loadExistingData()
        txtField.Text = formTables.Tables("TangleCounts").Rows(0).Item("Field").ToString 'string values for text boxes
        txtMFG1.Text = formTables.Tables("TangleCounts").Rows(0).Item("MFG1").ToString
        txtMFG2.Text = formTables.Tables("TangleCounts").Rows(0).Item("MFG2").ToString
        txtMFG3.Text = formTables.Tables("TangleCounts").Rows(0).Item("MFG3").ToString
        txtMFG4.Text = formTables.Tables("TangleCounts").Rows(0).Item("MFG4").ToString
        txtMFG5.Text = formTables.Tables("TangleCounts").Rows(0).Item("MFG5").ToString
        txtMFG6.Text = formTables.Tables("TangleCounts").Rows(0).Item("MFG6").ToString
        txtMFG7.Text = formTables.Tables("TangleCounts").Rows(0).Item("MFG7").ToString
        txtMFGAverage.Text = formTables.Tables("TangleCounts").Rows(0).Item("MFGAverage").ToString
        txtOFG1.Text = formTables.Tables("TangleCounts").Rows(0).Item("OFG1").ToString
        txtOFG2.Text = formTables.Tables("TangleCounts").Rows(0).Item("OFG2").ToString
        txtOFG3.Text = formTables.Tables("TangleCounts").Rows(0).Item("OFG3").ToString
        txtOFG4.Text = formTables.Tables("TangleCounts").Rows(0).Item("OFG4").ToString
        txtOFG5.Text = formTables.Tables("TangleCounts").Rows(0).Item("OFG5").ToString
        txtOFG6.Text = formTables.Tables("TangleCounts").Rows(0).Item("OFG6").ToString
        txtOFG7.Text = formTables.Tables("TangleCounts").Rows(0).Item("OFG7").ToString
        txtOFGAverage.Text = formTables.Tables("TangleCounts").Rows(0).Item("OFGAverage").ToString
        txtSTG1.Text = formTables.Tables("TangleCounts").Rows(0).Item("STG1").ToString
        txtSTG2.Text = formTables.Tables("TangleCounts").Rows(0).Item("STG2").ToString
        txtSTG3.Text = formTables.Tables("TangleCounts").Rows(0).Item("STG3").ToString
        txtSTG4.Text = formTables.Tables("TangleCounts").Rows(0).Item("STG4").ToString
        txtSTG5.Text = formTables.Tables("TangleCounts").Rows(0).Item("STG5").ToString
        txtSTG6.Text = formTables.Tables("TangleCounts").Rows(0).Item("STG6").ToString
        txtSTG7.Text = formTables.Tables("TangleCounts").Rows(0).Item("STG7").ToString
        txtSTGAverage.Text = formTables.Tables("TangleCounts").Rows(0).Item("STGAverage").ToString
        txtIPL1.Text = formTables.Tables("TangleCounts").Rows(0).Item("IPL1").ToString
        txtIPL2.Text = formTables.Tables("TangleCounts").Rows(0).Item("IPL2").ToString
        txtIPL3.Text = formTables.Tables("TangleCounts").Rows(0).Item("IPL3").ToString
        txtIPL4.Text = formTables.Tables("TangleCounts").Rows(0).Item("IPL4").ToString
        txtIPL5.Text = formTables.Tables("TangleCounts").Rows(0).Item("IPL5").ToString
        txtIPL6.Text = formTables.Tables("TangleCounts").Rows(0).Item("IPL6").ToString
        txtIPL7.Text = formTables.Tables("TangleCounts").Rows(0).Item("IPL7").ToString
        txtIPLAverage.Text = formTables.Tables("TangleCounts").Rows(0).Item("IPLAverage").ToString
        txtOC1.Text = formTables.Tables("TangleCounts").Rows(0).Item("OC1").ToString
        txtOC2.Text = formTables.Tables("TangleCounts").Rows(0).Item("OC2").ToString
        txtOC3.Text = formTables.Tables("TangleCounts").Rows(0).Item("OC3").ToString
        txtOC4.Text = formTables.Tables("TangleCounts").Rows(0).Item("OC4").ToString
        txtOC5.Text = formTables.Tables("TangleCounts").Rows(0).Item("OC5").ToString
        txtOC6.Text = formTables.Tables("TangleCounts").Rows(0).Item("OC6").ToString
        txtOC7.Text = formTables.Tables("TangleCounts").Rows(0).Item("OC7").ToString
        txtOCAverage.Text = formTables.Tables("TangleCounts").Rows(0).Item("OCAverage").ToString
        txtHippo1.Text = formTables.Tables("TangleCounts").Rows(0).Item("Hippo1").ToString
        txtHippo2.Text = formTables.Tables("TangleCounts").Rows(0).Item("Hippo2").ToString
        txtHippo3.Text = formTables.Tables("TangleCounts").Rows(0).Item("Hippo3").ToString
        txtHippo4.Text = formTables.Tables("TangleCounts").Rows(0).Item("Hippo4").ToString
        txtHippo5.Text = formTables.Tables("TangleCounts").Rows(0).Item("Hippo5").ToString
        txtHippo6.Text = formTables.Tables("TangleCounts").Rows(0).Item("Hippo6").ToString
        txtHippo7.Text = formTables.Tables("TangleCounts").Rows(0).Item("Hippo7").ToString
        txtHippoAverage.Text = formTables.Tables("TangleCounts").Rows(0).Item("HippoAverage").ToString
        txtEntCtx1.Text = formTables.Tables("TangleCounts").Rows(0).Item("EntCtx1").ToString
        txtEntCtx2.Text = formTables.Tables("TangleCounts").Rows(0).Item("EntCtx2").ToString
        txtEntCtx3.Text = formTables.Tables("TangleCounts").Rows(0).Item("EntCtx3").ToString
        txtEntCtx4.Text = formTables.Tables("TangleCounts").Rows(0).Item("EntCtx4").ToString
        txtEntCtx5.Text = formTables.Tables("TangleCounts").Rows(0).Item("EntCtx5").ToString
        txtEntCtx6.Text = formTables.Tables("TangleCounts").Rows(0).Item("EntCtx6").ToString
        txtEntCtx7.Text = formTables.Tables("TangleCounts").Rows(0).Item("EntCtx7").ToString
        txtEntCtxAverage.Text = formTables.Tables("TangleCounts").Rows(0).Item("EntCtxAverage").ToString
        txtMean.Text = formTables.Tables("TangleCounts").Rows(0).Item("Mean").ToString
    End Sub

    'Subs to enable-disable fields during data input based on conditional logic.
    Private Sub enableInputFields(ByVal value As Boolean)
        If value = True Then
            txtField.Enabled = True
            txtMFG1.Enabled = True
            txtMFG2.Enabled = True
            txtMFG3.Enabled = True
            txtMFG4.Enabled = True
            txtMFG5.Enabled = True
            txtMFG6.Enabled = True
            txtMFG7.Enabled = True
            txtOFG1.Enabled = True
            txtOFG2.Enabled = True
            txtOFG3.Enabled = True
            txtOFG4.Enabled = True
            txtOFG5.Enabled = True
            txtOFG6.Enabled = True
            txtOFG7.Enabled = True
            txtSTG1.Enabled = True
            txtSTG2.Enabled = True
            txtSTG3.Enabled = True
            txtSTG4.Enabled = True
            txtSTG5.Enabled = True
            txtSTG6.Enabled = True
            txtSTG7.Enabled = True
            txtIPL1.Enabled = True
            txtIPL2.Enabled = True
            txtIPL3.Enabled = True
            txtIPL4.Enabled = True
            txtIPL5.Enabled = True
            txtIPL6.Enabled = True
            txtIPL7.Enabled = True
            txtOC1.Enabled = True
            txtOC2.Enabled = True
            txtOC3.Enabled = True
            txtOC4.Enabled = True
            txtOC5.Enabled = True
            txtOC6.Enabled = True
            txtOC7.Enabled = True
            txtHippo1.Enabled = True
            txtHippo2.Enabled = True
            txtHippo3.Enabled = True
            txtHippo4.Enabled = True
            txtHippo5.Enabled = True
            txtHippo6.Enabled = True
            txtHippo7.Enabled = True
            txtEntCtx1.Enabled = True
            txtEntCtx2.Enabled = True
            txtEntCtx3.Enabled = True
            txtEntCtx4.Enabled = True
            txtEntCtx5.Enabled = True
            txtEntCtx6.Enabled = True
            txtEntCtx7.Enabled = True
        Else
            txtField.Enabled = False
            txtMFG1.Enabled = False
            txtMFG2.Enabled = False
            txtMFG3.Enabled = False
            txtMFG4.Enabled = False
            txtMFG5.Enabled = False
            txtMFG6.Enabled = False
            txtMFG7.Enabled = False
            txtOFG1.Enabled = False
            txtOFG2.Enabled = False
            txtOFG3.Enabled = False
            txtOFG4.Enabled = False
            txtOFG5.Enabled = False
            txtOFG6.Enabled = False
            txtOFG7.Enabled = False
            txtSTG1.Enabled = False
            txtSTG2.Enabled = False
            txtSTG3.Enabled = False
            txtSTG4.Enabled = False
            txtSTG5.Enabled = False
            txtSTG6.Enabled = False
            txtSTG7.Enabled = False
            txtIPL1.Enabled = False
            txtIPL2.Enabled = False
            txtIPL3.Enabled = False
            txtIPL4.Enabled = False
            txtIPL5.Enabled = False
            txtIPL6.Enabled = False
            txtIPL7.Enabled = False
            txtOC1.Enabled = False
            txtOC2.Enabled = False
            txtOC3.Enabled = False
            txtOC4.Enabled = False
            txtOC5.Enabled = False
            txtOC6.Enabled = False
            txtOC7.Enabled = False
            txtHippo1.Enabled = False
            txtHippo2.Enabled = False
            txtHippo3.Enabled = False
            txtHippo4.Enabled = False
            txtHippo5.Enabled = False
            txtHippo6.Enabled = False
            txtHippo7.Enabled = False
            txtEntCtx1.Enabled = False
            txtEntCtx2.Enabled = False
            txtEntCtx3.Enabled = False
            txtEntCtx4.Enabled = False
            txtEntCtx5.Enabled = False
            txtEntCtx6.Enabled = False
            txtEntCtx7.Enabled = False
        End If
    End Sub

    'Dynamic by-line averaging subs
    Private Sub txtField_LostFocus(sender As Object, e As EventArgs) Handles txtField.LostFocus
        MFGAVG()
        OFGAVG()
        STGAVG()
        IPLAVG()
        OCAVG()
        HippoAVG()
        EntCtxAVG()
        MEAN()
    End Sub
    Private Sub MFGAVG()
        Dim Sum As Double = Val(txtMFG1.Text & "") + Val(txtMFG2.Text & "") + Val(txtMFG3.Text & "") + Val(txtMFG4.Text & "") + Val(txtMFG5.Text & "") + Val(txtMFG6.Text & "") + Val(txtMFG7.Text & "")
        Dim Count As Double = IIf(IsNumeric(txtMFG1.Text), 1, 0) + IIf(IsNumeric(txtMFG2.Text), 1, 0) + IIf(IsNumeric(txtMFG3.Text), 1, 0) + IIf(IsNumeric(txtMFG4.Text), 1, 0) + IIf(IsNumeric(txtMFG5.Text), 1, 0) + IIf(IsNumeric(txtMFG6.Text), 1, 0) + IIf(IsNumeric(txtMFG7.Text), 1, 0)
        If Count > 0 Then
            txtMFGAverage.Text = (Math.Round((Sum / Count) / Val(txtField.Text), 2))
        End If
        MEAN()
    End Sub
    Private Sub txtMFG_LostFocus(sender As Object, e As EventArgs) Handles txtMFG1.LostFocus, txtMFG2.LostFocus, txtMFG3.LostFocus, txtMFG4.LostFocus, txtMFG5.LostFocus, txtMFG6.LostFocus, txtMFG7.LostFocus
        MFGAVG()
    End Sub
    Private Sub OFGAVG()
        Dim Sum As Double = Val(txtOFG1.Text & "") + Val(txtOFG2.Text & "") + Val(txtOFG3.Text & "") + Val(txtOFG4.Text & "") + Val(txtOFG5.Text & "") + Val(txtOFG6.Text & "") + Val(txtOFG7.Text & "")
        Dim Count As Double = IIf(IsNumeric(txtOFG1.Text), 1, 0) + IIf(IsNumeric(txtOFG2.Text), 1, 0) + IIf(IsNumeric(txtOFG3.Text), 1, 0) + IIf(IsNumeric(txtOFG4.Text), 1, 0) + IIf(IsNumeric(txtOFG5.Text), 1, 0) + IIf(IsNumeric(txtOFG6.Text), 1, 0) + IIf(IsNumeric(txtOFG7.Text), 1, 0)
        If Count > 0 Then
            txtOFGAverage.Text = Math.Round((Sum / Count) / Val(txtField.Text), 2)
        End If
        MEAN()
    End Sub
    Private Sub txtOFG_LostFocus(sender As Object, e As EventArgs) Handles txtOFG1.LostFocus, txtOFG2.LostFocus, txtOFG3.LostFocus, txtOFG4.LostFocus, txtOFG5.LostFocus, txtOFG6.LostFocus, txtOFG7.LostFocus
        OFGAVG()
    End Sub
    Private Sub STGAVG()
        Dim Sum As Double = Val(txtSTG1.Text & "") + Val(txtSTG2.Text & "") + Val(txtSTG3.Text & "") + Val(txtSTG4.Text & "") + Val(txtSTG5.Text & "") + Val(txtSTG6.Text & "") + Val(txtSTG7.Text & "")
        Dim Count As Double = IIf(IsNumeric(txtSTG1.Text), 1, 0) + IIf(IsNumeric(txtSTG2.Text), 1, 0) + IIf(IsNumeric(txtSTG3.Text), 1, 0) + IIf(IsNumeric(txtSTG4.Text), 1, 0) + IIf(IsNumeric(txtSTG5.Text), 1, 0) + IIf(IsNumeric(txtSTG6.Text), 1, 0) + IIf(IsNumeric(txtSTG7.Text), 1, 0)
        If Count > 0 Then
            txtSTGAverage.Text = Math.Round((Sum / Count) / Val(txtField.Text), 2)
        End If
        MEAN()
    End Sub
    Private Sub txtSTG_LostFocus(sender As Object, e As EventArgs) Handles txtSTG1.LostFocus, txtSTG2.LostFocus, txtSTG3.LostFocus, txtSTG4.LostFocus, txtSTG5.LostFocus, txtSTG6.LostFocus, txtSTG7.LostFocus
        STGAVG()
    End Sub
    Private Sub IPLAVG()
        Dim Sum As Double = Val(txtIPL1.Text & "") + Val(txtIPL2.Text & "") + Val(txtIPL3.Text & "") + Val(txtIPL4.Text & "") + Val(txtIPL5.Text & "") + Val(txtIPL6.Text & "") + Val(txtIPL7.Text & "")
        Dim Count As Double = IIf(IsNumeric(txtIPL1.Text), 1, 0) + IIf(IsNumeric(txtIPL2.Text), 1, 0) + IIf(IsNumeric(txtIPL3.Text), 1, 0) + IIf(IsNumeric(txtIPL4.Text), 1, 0) + IIf(IsNumeric(txtIPL5.Text), 1, 0) + IIf(IsNumeric(txtIPL6.Text), 1, 0) + IIf(IsNumeric(txtIPL7.Text), 1, 0)
        If Count > 0 Then
            txtIPLAverage.Text = Math.Round((Sum / Count) / Val(txtField.Text), 2)
        End If
        MEAN()
    End Sub
    Private Sub txtIPL_LostFocus(sender As Object, e As EventArgs) Handles txtIPL1.LostFocus, txtIPL2.LostFocus, txtIPL3.LostFocus, txtIPL4.LostFocus, txtIPL5.LostFocus, txtIPL6.LostFocus, txtIPL7.LostFocus
        IPLAVG()
    End Sub
    Private Sub OCAVG()
        Dim Sum As Double = Val(txtOC1.Text & "") + Val(txtOC2.Text & "") + Val(txtOC3.Text & "") + Val(txtOC4.Text & "") + Val(txtOC5.Text & "") + Val(txtOC6.Text & "") + Val(txtOC7.Text & "")
        Dim Count As Double = IIf(IsNumeric(txtOC1.Text), 1, 0) + IIf(IsNumeric(txtOC2.Text), 1, 0) + IIf(IsNumeric(txtOC3.Text), 1, 0) + IIf(IsNumeric(txtOC4.Text), 1, 0) + IIf(IsNumeric(txtOC5.Text), 1, 0) + IIf(IsNumeric(txtOC6.Text), 1, 0) + IIf(IsNumeric(txtOC7.Text), 1, 0)
        If Count > 0 Then
            txtOCAverage.Text = Math.Round((Sum / Count) / Val(txtField.Text), 2)
        End If
        MEAN()
    End Sub
    Private Sub txtOC_LostFocus(sender As Object, e As EventArgs) Handles txtOC1.LostFocus, txtOC2.LostFocus, txtOC3.LostFocus, txtOC4.LostFocus, txtOC5.LostFocus, txtOC6.LostFocus, txtOC7.LostFocus
        OCAVG()
    End Sub
    Private Sub HippoAVG()
        Dim Sum As Double = Val(txtHippo1.Text & "") + Val(txtHippo2.Text & "") + Val(txtHippo3.Text & "") + Val(txtHippo4.Text & "") + Val(txtHippo5.Text & "") + Val(txtHippo6.Text & "") + Val(txtHippo7.Text & "")
        Dim Count As Double = IIf(IsNumeric(txtHippo1.Text), 1, 0) + IIf(IsNumeric(txtHippo2.Text), 1, 0) + IIf(IsNumeric(txtHippo3.Text), 1, 0) + IIf(IsNumeric(txtHippo4.Text), 1, 0) + IIf(IsNumeric(txtHippo5.Text), 1, 0) + IIf(IsNumeric(txtHippo6.Text), 1, 0) + IIf(IsNumeric(txtHippo7.Text), 1, 0)
        If Count > 0 Then
            txtHippoAverage.Text = Math.Round((Sum / Count) / Val(txtField.Text), 2)
        End If
        MEAN()
    End Sub
    Private Sub txtHippo_LostFocus(sender As Object, e As EventArgs) Handles txtHippo1.LostFocus, txtHippo2.LostFocus, txtHippo3.LostFocus, txtHippo4.LostFocus, txtHippo5.LostFocus, txtHippo6.LostFocus, txtHippo7.LostFocus
        HippoAVG()
    End Sub
    Private Sub EntCtxAVG()
        Dim Sum As Double = Val(txtEntCtx1.Text & "") + Val(txtEntCtx2.Text & "") + Val(txtEntCtx3.Text & "") + Val(txtEntCtx4.Text & "") + Val(txtEntCtx5.Text & "") + Val(txtEntCtx6.Text & "") + Val(txtEntCtx7.Text & "")
        Dim Count As Double = IIf(IsNumeric(txtEntCtx1.Text), 1, 0) + IIf(IsNumeric(txtEntCtx2.Text), 1, 0) + IIf(IsNumeric(txtEntCtx3.Text), 1, 0) + IIf(IsNumeric(txtEntCtx4.Text), 1, 0) + IIf(IsNumeric(txtEntCtx5.Text), 1, 0) + IIf(IsNumeric(txtEntCtx6.Text), 1, 0) + IIf(IsNumeric(txtEntCtx7.Text), 1, 0)
        If Count > 0 Then
            txtEntCtxAverage.Text = Math.Round((Sum / Count) / Val(txtField.Text), 2)
        End If
        MEAN()
    End Sub
    Private Sub txtEntCtx_LostFocus(sender As Object, e As EventArgs) Handles txtEntCtx1.LostFocus, txtEntCtx2.LostFocus, txtEntCtx3.LostFocus, txtEntCtx4.LostFocus, txtEntCtx5.LostFocus, txtEntCtx6.LostFocus, txtEntCtx7.LostFocus
        EntCtxAVG()
    End Sub

    'Dynamic averaging subs to update Mean on AVG TextChanged
    Private Sub MEAN()
        Dim Sum As Double = Val(txtMFGAverage.Text & "") + Val(txtOFGAverage.Text & "") + Val(txtSTGAverage.Text & "") + Val(txtIPLAverage.Text & "") + Val(txtOCAverage.Text & "") + Val(txtHippoAverage.Text & "") + Val(txtEntCtxAverage.Text & "")
        Dim Count As Double = IIf(IsNumeric(txtMFGAverage.Text), 1, 0) + IIf(IsNumeric(txtOFGAverage.Text), 1, 0) + IIf(IsNumeric(txtSTGAverage.Text), 1, 0) + IIf(IsNumeric(txtIPLAverage.Text), 1, 0) + IIf(IsNumeric(txtOCAverage.Text), 1, 0) + IIf(IsNumeric(txtHippoAverage.Text), 1, 0) + IIf(IsNumeric(txtEntCtxAverage.Text), 1, 0)
        If Count > 0 Then
            txtMean.Text = Math.Round(Sum / Count, 2)
        End If
    End Sub

    'Define button click events
    Private Sub btnTangleCounts_Click(sender As Object, e As EventArgs) Handles btnTangleCountsBottom.Click, btnTangleCountsTop.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_TangleCounts", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                enableInputFields(True)
                btnTangleCountsBottom.Text = "Save changes"
                btnTangleCountsTop.Text = btnTangleCountsBottom.Text
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If User.PermissionCheck("WA_TangleCounts", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
                enableInputFields(True)
                btnTangleCountsBottom.Text = "Save new record"
                btnTangleCountsTop.Text = btnTangleCountsBottom.Text
                lblNoRecord.Visible = False
            End If
        Else
            Dim sqlCommand As New SqlCommand
            sqlCommand.Connection = WarehouseShell.conn
            Dim cmdString = "@SubNum = " & WarehouseShell.SubNum &
                ", @Field = " & txtField.getSQLValue() &
                ", @MFG1 = " & txtMFG1.getSQLValue() &
                ", @MFG2 = " & txtMFG2.getSQLValue() &
                ", @MFG3 = " & txtMFG3.getSQLValue() &
                ", @MFG4 = " & txtMFG4.getSQLValue() &
                ", @MFG5 = " & txtMFG5.getSQLValue() &
                ", @MFG6 = " & txtMFG6.getSQLValue() &
                ", @MFG7 = " & txtMFG7.getSQLValue() &
                ", @MFGAverage = " & txtMFGAverage.getSQLValue() &
                ", @OFG1 = " & txtOFG1.getSQLValue() &
                ", @OFG2 = " & txtOFG2.getSQLValue() &
                ", @OFG3 = " & txtOFG3.getSQLValue() &
                ", @OFG4 = " & txtOFG4.getSQLValue() &
                ", @OFG5 = " & txtOFG5.getSQLValue() &
                ", @OFG6 = " & txtOFG6.getSQLValue() &
                ", @OFG7 = " & txtOFG7.getSQLValue() &
                ", @OFGAverage = " & txtOFGAverage.getSQLValue() &
                ", @STG1 = " & txtSTG1.getSQLValue() &
                ", @STG2 = " & txtSTG2.getSQLValue() &
                ", @STG3 = " & txtSTG3.getSQLValue() &
                ", @STG4 = " & txtSTG4.getSQLValue() &
                ", @STG5 = " & txtSTG5.getSQLValue() &
                ", @STG6 = " & txtSTG6.getSQLValue() &
                ", @STG7 = " & txtSTG7.getSQLValue() &
                ", @STGAverage = " & txtSTGAverage.getSQLValue() &
                ", @IPL1 = " & txtIPL1.getSQLValue() &
                ", @IPL2 = " & txtIPL2.getSQLValue() &
                ", @IPL3 = " & txtIPL3.getSQLValue() &
                ", @IPL4 = " & txtIPL4.getSQLValue() &
                ", @IPL5 = " & txtIPL5.getSQLValue() &
                ", @IPL6 = " & txtIPL6.getSQLValue() &
                ", @IPL7 = " & txtIPL7.getSQLValue() &
                ", @IPLAverage = " & txtIPLAverage.getSQLValue() &
                ", @OC1 = " & txtOC1.getSQLValue() &
                ", @OC2 = " & txtOC2.getSQLValue() &
                ", @OC3 = " & txtOC3.getSQLValue() &
                ", @OC4 = " & txtOC4.getSQLValue() &
                ", @OC5 = " & txtOC5.getSQLValue() &
                ", @OC6 = " & txtOC6.getSQLValue() &
                ", @OC7 = " & txtOC7.getSQLValue() &
                ", @OCAverage = " & txtOCAverage.getSQLValue() &
                ", @Hippo1 = " & txtHippo1.getSQLValue() &
                ", @Hippo2 = " & txtHippo2.getSQLValue() &
                ", @Hippo3 = " & txtHippo3.getSQLValue() &
                ", @Hippo4 = " & txtHippo4.getSQLValue() &
                ", @Hippo5 = " & txtHippo5.getSQLValue() &
                ", @Hippo6 = " & txtHippo6.getSQLValue() &
                ", @Hippo7 = " & txtHippo7.getSQLValue() &
                ", @HippoAverage = " & txtHippoAverage.getSQLValue() &
                ", @EntCtx1 = " & txtEntCtx1.getSQLValue() &
                ", @EntCtx2 = " & txtEntCtx2.getSQLValue() &
                ", @EntCtx3 = " & txtEntCtx3.getSQLValue() &
                ", @EntCtx4 = " & txtEntCtx4.getSQLValue() &
                ", @EntCtx5 = " & txtEntCtx5.getSQLValue() &
                ", @EntCtx6 = " & txtEntCtx6.getSQLValue() &
                ", @EntCtx7 = " & txtEntCtx7.getSQLValue() &
                ", @EntCtxAverage = " & txtEntCtxAverage.getSQLValue() &
                ", @Mean = " & txtMean.getSQLValue() & ";"
            If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                sqlCommand.CommandText = "EXEC dbo.modTangleCountsRecord @Action = 1, " & cmdString
                Try
                    sqlCommand.ExecuteNonQuery()
                    MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    enableInputFields(False)
                    btnTangleCountsBottom.Text = "Edit this record"
                    btnTangleCountsTop.Text = btnTangleCountsBottom.Text
                Catch ex As SqlException
                    ExceptionHandler.CatchSQLException(ex)
                End Try
            Else
                sqlCommand.CommandText = "EXEC dbo.modTangleCountsRecord @Action = 2, " & cmdString
                Try
                    sqlCommand.ExecuteNonQuery()
                    MessageBox.Show("Record successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    enableInputFields(False)
                    btnTangleCountsBottom.Text = "Edit this record"
                    btnTangleCountsTop.Text = btnTangleCountsBottom.Text
                Catch ex As SqlException
                    ExceptionHandler.CatchSQLException(ex)
                End Try
            End If
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
        TopLevel = val
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
        btnTangleCountsBottom.PerformClick()
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class