Public Class WA_NoK
    Implements IFormMethods
    Private formTables As New DataSet

    'Main subs
    Private Sub WA_NoK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_NoK")
        loadBaseForm()
        setDefaultValues()
        enableInputFields(False)
        If Database.ExistingRecordCheck("NoK", "SubNum = " & WarehouseShell.SubNum) Then
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            lblNoRecord.Visible = False
            loadExistingData()
            btnNoKTop.Text = "Edit this record"
            btnNoKBottom.Text = btnNoKTop.Text
        Else
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            lblNoRecord.Visible = True
            btnNoKTop.Text = "Add new record"
            btnNoKBottom.Text = btnNoKTop.Text
        End If
        ShowPHI(WarehouseShell.ShowingPHI)
    End Sub
    Private Sub loadBaseForm()
        formTables.Tables.Add(Database.ReturnTable("lkpRelation"))
        formTables.Tables.Add(Database.ReturnTable("lkpLanguage"))
        'assign lookups to comboboxes
        NokRelation.assignLookup(formTables, "lkpRelation")
        NoKPrimLang.assignLookup(formTables, "lkpLanguage")
        NoKSecLang.assignLookup(formTables, "lkpLanguage")
        AltPOCRelation.assignLookup(formTables, "lkpRelation")
        AltPOCPrimLang.assignLookup(formTables, "lkpLanguage")
        AltPOCSecLang.assignLookup(formTables, "lkpLanguage")
    End Sub
    Private Sub setDefaultValues()
        NokRelation.SelectedValue = -1
        NoKPrimLang.SelectedValue = -1
        NoKSecLang.SelectedValue = -1
        AltPOCRelation.SelectedValue = -1
        AltPOCPrimLang.SelectedValue = -1
        AltPOCSecLang.SelectedValue = -1
    End Sub
    Private Sub enableInputFields(ByVal bool As Boolean)
        For Each item As Control In Controls
            If TypeOf item Is GroupBox Then
                For Each control As Control In item.Controls
                    If TypeOf control Is TextBox_ Then
                        CType(control, TextBox_).makeReadOnly(Not bool)
                    ElseIf TypeOf control Is ComboBox_ Then
                        control.Enabled = bool
                    End If
                Next
            End If
        Next
    End Sub
    Private Sub loadExistingData()
        formTables.Tables.Add(Database.ReturnTable("NoK",, "SubNum = " & WarehouseShell.SubNum))
        For Each item As Control In Controls
            If TypeOf item Is GroupBox Then
                For Each control As Control In item.Controls
                    If TypeOf control Is TextBox_ Then
                        CType(control, TextBox_).setValue(formTables, "NoK", control.Name)
                    ElseIf TypeOf control Is ComboBox_ Then
                        CType(control, ComboBox_).setValue(formTables, "NoK", control.Name)
                    End If
                Next
            End If
        Next
    End Sub
    Private Sub btnNoK_Click(sender As Object, e As EventArgs) Handles btnNoKTop.Click, btnNoKBottom.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If WarehouseShell.ShowingPHI = False Then
                MsgBox("Please enable PHI before attempting to add a new record.", MsgBoxStyle.OkOnly, "Error!")
            Else
                If Database.ExistingRecordCheck("AutopsyFaceSheet", "SubNum = " & WarehouseShell.SubNum) Then
                    If User.PermissionCheck("WA_NoK", "Modify") Then
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
                        lblNoRecord.Visible = False
                        enableInputFields(True)
                        btnNoKTop.Text = "Save Record"
                        btnNoKBottom.Text = btnNoKTop.Text
                    Else
                        MsgBox("This is a postmortem case and you lack the NBTR Edit user right required to create this form.", MsgBoxStyle.OkOnly, "Warning")
                    End If
                Else
                    WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
                    lblNoRecord.Visible = False
                    enableInputFields(True)
                    btnNoKTop.Text = "Save Record"
                    btnNoKBottom.Text = btnNoKTop.Text
                End If
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If WarehouseShell.ShowingPHI = False Then
                MsgBox("Please enable PHI before attempting to edit this record.", MsgBoxStyle.OkOnly, "Error!")
            Else
                If Database.ExistingRecordCheck("AutopsyFaceSheet", "SubNum = " & WarehouseShell.SubNum) Then
                    If User.CheckPermission("Dissectionist, DonationCoordinator, LabTech, LabTechLead, Neuropathologist, NPTech, PMCRAssessor, Prosector") Then
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                        enableInputFields(True)
                        btnNoKTop.Text = "Save Changes"
                        btnNoKBottom.Text = btnNoKTop.Text
                    Else
                        MsgBox("This is a postmortem case and you lack the NBTR Edit user right required to modify this form.", MsgBoxStyle.OkOnly, "Warning")
                    End If
                Else
                    WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                    enableInputFields(True)
                    btnNoKTop.Text = "Save Changes"
                    btnNoKBottom.Text = btnNoKTop.Text
                End If
            End If
        Else
            Try
                saveRecord()
                WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                enableInputFields(False)
                btnNoKTop.Text = "Edit this record"
                btnNoKBottom.Text = btnNoKTop.Text
            Catch ex As SqlException
                ExceptionHandler.CatchSQLException(ex)
            End Try
        End If
    End Sub
    Private Sub saveRecord()
        Dim SqlCommand As New SqlCommand
        SqlCommand.Connection = WarehouseShell.conn

        If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
            SqlCommand.CommandText = "EXEC modNoKRecord @Action = 1, " & getParams()
            SqlCommand.ExecuteNonQuery()
            MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            SqlCommand.CommandText = "EXEC modNoKRecord @Action = 2, " & getParams()
            SqlCommand.ExecuteNonQuery()
            MessageBox.Show("Record was successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub
    Private Function getParams() As String
        Dim params As String = "@SubNum = " & WarehouseShell.SubNum
        For Each item As Control In Controls
            If TypeOf item Is GroupBox Then
                For Each control As Control In item.Controls
                    If TypeOf control Is TextBox_ Then
                        params += ", @" & control.Name & " = " & CType(control, TextBox_).getSQLValue
                    ElseIf TypeOf control Is ComboBox_ Then
                        params += ", @" & control.Name & " = " & CType(control, ComboBox_).getSQLValue
                    End If
                Next
            End If
        Next
        params += ";"
        Return params
    End Function

    'Implemented IFormMethods subs
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
        btnNoKBottom.PerformClick()
    End Sub
    Public Sub ShowPHI(val As Boolean) Implements IFormMethods.ShowPHI
        If val = False Then
            NoKName.PasswordChar = "*"
            NoKAddress1.PasswordChar = "*"
            NoKAddress2.PasswordChar = "*"
            NoKCity.PasswordChar = "*"
            NoKState.PasswordChar = "*"
            NoKZip.PasswordChar = "*"
            NoKHomePhone.PasswordChar = "*"
            NoKMobilePhone.PasswordChar = "*"
            NoKWorkPhone.PasswordChar = "*"
            NoKEmail.PasswordChar = "*"
            AltPOCName.PasswordChar = "*"
            AltPOCAddress1.PasswordChar = "*"
            AltPOCAddress2.PasswordChar = "*"
            AltPOCCity.PasswordChar = "*"
            AltPOCState.PasswordChar = "*"
            AltPOCZip.PasswordChar = "*"
            AltPOCHomePhone.PasswordChar = "*"
            AltPOCMobilePhone.PasswordChar = "*"
            AltPOCWorkPhone.PasswordChar = "*"
            AltPOCEmail.PasswordChar = "*"
        Else
            NoKName.PasswordChar = ""
            NoKAddress1.PasswordChar = ""
            NoKAddress2.PasswordChar = ""
            NoKCity.PasswordChar = ""
            NoKState.PasswordChar = ""
            NoKZip.PasswordChar = ""
            NoKHomePhone.PasswordChar = ""
            NoKMobilePhone.PasswordChar = ""
            NoKWorkPhone.PasswordChar = ""
            NoKEmail.PasswordChar = ""
            AltPOCName.PasswordChar = ""
            AltPOCAddress1.PasswordChar = ""
            AltPOCAddress2.PasswordChar = ""
            AltPOCCity.PasswordChar = ""
            AltPOCState.PasswordChar = ""
            AltPOCZip.PasswordChar = ""
            AltPOCHomePhone.PasswordChar = ""
            AltPOCMobilePhone.PasswordChar = ""
            AltPOCWorkPhone.PasswordChar = ""
            AltPOCEmail.PasswordChar = ""
        End If
    End Sub
    Public Sub TopLevel(val As Boolean) Implements IFormMethods.TopLevel
    End Sub
    Private Sub IFormMethods_Parent(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Private Sub IFormMethods_Show() Implements IFormMethods.Show
        Show()
    End Sub
End Class