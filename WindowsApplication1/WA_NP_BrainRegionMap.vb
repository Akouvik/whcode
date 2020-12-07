Public Class WA_NP_BrainRegionMap
    Implements IFormMethods
    Private formTables As New DataSet

    Private Sub WA_NP_BrainRegionMap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_NPRegionMap")
        LoadBaseForm()
        SetDefaultValues()
        LoadExistingValues()
        EnableInputFields(False)
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        SaveTop.Text = "Edit this record"
        SaveBottom.Text = SaveTop.Text
        ActiveControl = SaveTop
    End Sub

    Private Sub EnableInputFields(ByVal Enable As Boolean)
        For Each item As Control In Controls()
            If TypeOf item Is ComboBox_ Then
                CType(item, ComboBox_).Enabled = Enable
            ElseIf TypeOf item Is TextBox_ Then
                CType(item, TextBox_).makeReadOnly(Not Enable)
            End If
        Next
    End Sub

    Private Sub LoadBaseForm()
        formTables.Tables.Add(Database.ReturnTable("lkpNPRegionMap"))
        For Each item As Control In Controls()
            If TypeOf item Is ComboBox_ Then
                CType(item, ComboBox_).assignLookup(formTables, "lkpNPRegionMap", , , , "Label")
            End If
        Next
    End Sub

    Private Sub SetDefaultValues()
        For Each item As Control In Controls()
            If TypeOf item Is ComboBox_ Then
                CType(item, ComboBox_).SelectedValue = -1
            ElseIf TypeOf item Is TextBox_ Then
                CType(item, TextBox_).Clear()
            End If
        Next
    End Sub

    Private Sub LoadExistingValues()
        formTables.Tables.Add(Database.ReturnTable("NPRegionMap", , "SubNum = " & WarehouseShell.SubNum))
        For Each row As DataRow In formTables.Tables("NPRegionMap").Rows()
            Dim regionNum As Integer = row.Item("RegionNum")
            Dim cmb As ComboBox_ = DirectCast(Controls("Region" & regionNum), ComboBox_)
            cmb.SelectedValue = row.Item("RegionLkp")
            If row.Item("RegionLkp") = 999 Then
                Dim spec As TextBox_ = DirectCast(Controls("Region" & regionNum & "Spec"), TextBox_)
                spec.Text = row.Item("RegionNameSpec").ToString
            End If
        Next
    End Sub

    Private Function PreSaveValidation() As Boolean
        Dim Result As Boolean = True
        Dim errMsg As String = "The following errors exist and need to be corrected before record can be saved:" & vbNewLine & vbNewLine

        For Each cmb As Control In Controls()
            If TypeOf cmb Is ComboBox_ Then
                Dim regionNum As String = cmb.Name.Substring(6)
                Dim spec As TextBox_ = DirectCast(Controls("Region" & regionNum & "Spec"), TextBox_)
                If CType(cmb, ComboBox_).SelectedValue = 999 And spec.Text.ToString = "" Then
                    Result = False
                    errMsg += "- Region # " & regionNum & ": Please enter a Region Specify value or change your Region Name selection for this region." & vbNewLine
                ElseIf CType(cmb, ComboBox_).SelectedValue <> 999 And spec.Text.ToString <> "" Then
                    Result = False
                    errMsg += "- Region # " & regionNum & ": Please only enter Region Specify value if you selected ""Other- Specify"" for the Region Name." & vbNewLine
                End If
            End If
        Next

        If Result = False Then
            MsgBox(errMsg, , "Errors Exist!")
        End If

        Return Result
    End Function

    Private Sub Save()
        If PreSaveValidation() Then
            Dim cmd As New SqlCommand("", WarehouseShell.conn)
            For Each cmb As Control In Controls()
                If TypeOf cmb Is ComboBox_ Then
                    If CType(cmb, ComboBox_).SelectedValue <> -1 Then
                        Dim regionNum As String = cmb.Name.Substring(6)
                        If Database.ExistingRecordCheck("NPRegionMap", "SubNum = " & WarehouseShell.SubNum & " and RegionNum = " & regionNum) Then
                            cmd.CommandText = "Update NPRegionMap set " &
                                "RegionLkp = " & CType(cmb, ComboBox_).getSQLValue & ", " &
                                "RegionNameSpec = " & DirectCast(Controls("Region" & regionNum & "Spec"), TextBox_).getSQLValue() & " " &
                                "where SubNum = " & WarehouseShell.SubNum & " and RegionNum = " & regionNum & ";"
                            cmd.ExecuteNonQuery()
                        Else
                            cmd.CommandText = "Insert into NPRegionMap (SubNum, RegionNum, RegionLkp, RegionNameSpec) Values ( " &
                                WarehouseShell.SubNum & ", " &
                                regionNum & ", " &
                                CType(cmb, ComboBox_).getSQLValue() & ", " &
                                DirectCast(Controls("Region" & regionNum & "Spec"), TextBox_).getSQLValue() & ");"
                            cmd.ExecuteNonQuery()
                        End If
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub SaveTop_Click(sender As Object, e As EventArgs) Handles SaveTop.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            EnableInputFields(True)
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
            SaveTop.Text = "Save Changes"
            SaveBottom.Text = SaveTop.Text
        Else
            Save()
            EnableInputFields(False)
            SaveTop.Text = "Edit this record"
            SaveBottom.Text = SaveTop.Text
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        End If
    End Sub
    Private Sub SaveBottom_Click(sender As Object, e As EventArgs) Handles SaveBottom.Click
        SaveTop.PerformClick()
    End Sub

    'Imported IFormMethods
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
        SaveBottom.PerformClick()
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class