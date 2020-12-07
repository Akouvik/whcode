Public Class WA_CERAD_ARTAG
    Implements IFormMethods
    Private formTables As New DataSet

    Private Sub WA_CERAD_ARTAG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_CERAD_ARTAG")
        If Database.ExistingRecordCheck("ARTAG", "SubNum = " & WarehouseShell.SubNum) = True Then
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            EnableInputFields(False)
            LoadBaseForm()
            LoadExistingData()
            btnARTAGBottom.Text = "Edit this record"
            btnARTAGTop.Text = btnARTAGBottom.Text
            btnARTAGTop.Focus()
            lblNoRecord.Visible = False
        Else
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            enableInputFields(False)
            btnARTAGTop.Text = "Add New Record"
            btnARTAGBottom.Text = btnARTAGTop.Text
            lblNoRecord.Visible = True
        End If
    End Sub

    Private Sub EnableInputFields(ByVal bool As Boolean)
        For Each item As Control In Controls()
            If TypeOf item Is ComboBox_ Then
                item.Enabled = bool
            End If
        Next
        AmygdalaSubependymal.Enabled = False
        AmygdalaGrayMatter.Enabled = False
        AmygdalaWhiteMatter.Enabled = False
        BasGangGrayMatter.Enabled = False
        BasGangWhiteMatter.Enabled = False
        FrontNeoSubependymal.Enabled = False
    End Sub

    Private Sub LoadBaseForm()
        'Load all required lookup tables into the comboValues DataSet
        formTables.Tables.Add(Database.ReturnTable("lkpARTAG_Severity"))
        formTables.Tables.Add(Database.ReturnTable("lkpARTAG_Localization"))
        formTables.Tables.Add(Database.ReturnTable("lkpNYNAUnk0189"))
        'Assign lookup values to each individual combobox
        ARTAG_Severity.assignLookup(formTables, "lkpARTAG_Severity")
        AmygdalaSubpial.assignLookup(formTables, "lkpARTAG_Localization")
        AmygdalaSubependymal.assignLookup(formTables, "lkpARTAG_Localization")
        AmygdalaGrayMatter.assignLookup(formTables, "lkpARTAG_Localization")
        AmygdalaWhiteMatter.assignLookup(formTables, "lkpARTAG_Localization")
        AmygdalaPerivascular.assignLookup(formTables, "lkpARTAG_Localization")
        FrontNeoSubpial.assignLookup(formTables, "lkpARTAG_Localization")
        FrontNeoSubependymal.assignLookup(formTables, "lkpARTAG_Localization")
        FrontNeoGrayMatter.assignLookup(formTables, "lkpARTAG_Localization")
        FrontNeoWhiteMatter.assignLookup(formTables, "lkpARTAG_Localization")
        FrontNeoPerivascular.assignLookup(formTables, "lkpARTAG_Localization")
        BasGangSubpial.assignLookup(formTables, "lkpARTAG_Localization")
        BasGangSubependymal.assignLookup(formTables, "lkpARTAG_Localization")
        BasGangGrayMatter.assignLookup(formTables, "lkpARTAG_Localization")
        BasGangWhiteMatter.assignLookup(formTables, "lkpARTAG_Localization")
        BasGangPerivascular.assignLookup(formTables, "lkpARTAG_Localization")
        MedOblSubpial.assignLookup(formTables, "lkpARTAG_Localization")
        MedOblSubependymal.assignLookup(formTables, "lkpARTAG_Localization")
        MedOblGrayMatter.assignLookup(formTables, "lkpARTAG_Localization")
        MedOblWhiteMatter.assignLookup(formTables, "lkpARTAG_Localization")
        MedOblPerivascular.assignLookup(formTables, "lkpARTAG_Localization")
        PathAffectDepthSulci.assignLookup(formTables, "lkpNYNAUnk0189")
        PathAffectGyralBankCrest.assignLookup(formTables, "lkpNYNAUnk0189")
    End Sub

    Private Sub SetDefaultComboValues()
        For Each item As Control In Controls()
            If TypeOf item Is ComboBox_ Then
                CType(item, ComboBox_).SelectedValue = 8
            End If
        Next
    End Sub

    Private Sub LoadExistingData()
        formTables.Tables.Add(Database.ReturnTable("ARTAG"))
        For Each item As Control In Controls()
            If TypeOf item Is ComboBox_ Then
                CType(item, ComboBox_).setValue(formTables, "ARTAG", item.Name)
            End If
        Next
    End Sub

    Private Sub btnARTAG_Click(sender As Object, e As EventArgs) Handles btnARTAGTop.Click, btnARTAGBottom.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_CERAD_ARTAG", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                EnableInputFields(True)
                btnARTAGBottom.Text = "Save changes"
                btnARTAGTop.Text = btnARTAGBottom.Text
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If Database.ExistingRecordCheck("CERAD_Header", "SubNum = " & WarehouseShell.SubNum) Then
                If User.PermissionCheck("WA_CERAD_ARTAG", "Modify") Then
                    WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
                    LoadBaseForm()
                    SetDefaultComboValues()
                    EnableInputFields(True)
                    btnARTAGBottom.Text = "Save new record"
                    btnARTAGTop.Text = btnARTAGBottom.Text
                    lblNoRecord.Visible = False
                End If
            Else
                MsgBox("Please create a CERAD Header for this subject before attempting to add ARTAG information.", MsgBoxStyle.OkOnly, "Error!")
            End If
        Else

            Dim sqlCommand As New SqlCommand
            sqlCommand.Connection = WarehouseShell.conn
            Dim cmdString = "@SubNum = " & WarehouseShell.SubNum &
                ", @ARTAG_Severity = " & ARTAG_Severity.getSQLValue() &
                ", @AmygdalaSubpial = " & AmygdalaSubpial.getSQLValue() &
                ", @AmygdalaSubependymal = " & AmygdalaSubependymal.getSQLValue() &
                ", @AmygdalaGrayMatter = " & AmygdalaGrayMatter.getSQLValue() &
                ", @AmygdalaWhiteMatter = " & AmygdalaWhiteMatter.getSQLValue() &
                ", @AmygdalaPerivascular = " & AmygdalaPerivascular.getSQLValue() &
                ", @FrontNeoSubpial = " & FrontNeoSubpial.getSQLValue() &
                ", @FrontNeoSubependymal = " & FrontNeoSubependymal.getSQLValue() &
                ", @FrontNeoGrayMatter = " & FrontNeoGrayMatter.getSQLValue() &
                ", @FrontNeoWhiteMatter = " & FrontNeoWhiteMatter.getSQLValue() &
                ", @FrontNeoPerivascular = " & FrontNeoPerivascular.getSQLValue() &
                ", @BasGangSubpial = " & BasGangSubpial.getSQLValue() &
                ", @BasGangSubependymal = " & BasGangSubependymal.getSQLValue() &
                ", @BasGangGrayMatter = " & BasGangGrayMatter.getSQLValue() &
                ", @BasGangWhiteMatter = " & BasGangWhiteMatter.getSQLValue() &
                ", @BasGangPerivascular = " & BasGangPerivascular.getSQLValue() &
                ", @MedOblSubpial = " & MedOblSubpial.getSQLValue() &
                ", @MedOblSubependymal = " & MedOblSubependymal.getSQLValue() &
                ", @MedOblGrayMatter = " & MedOblGrayMatter.getSQLValue() &
                ", @MedOblWhiteMatter = " & MedOblWhiteMatter.getSQLValue() &
                ", @MedOblPerivascular = " & MedOblPerivascular.getSQLValue() &
                ", @PathAffectDepthSulci = " & PathAffectDepthSulci.getSQLValue() &
                ", @PathAffectGyralBankCrest = " & PathAffectGyralBankCrest.getSQLValue() &
                ", @LastModBy = '" & WarehouseShell.userName & "';"
            If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                sqlCommand.CommandText = "EXEC dbo.modARTAGRecord @Action = 1, " & cmdString
                Try
                    sqlCommand.ExecuteNonQuery()
                    MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    EnableInputFields(False)
                    btnARTAGBottom.Text = "Edit this record"
                    btnARTAGTop.Text = btnARTAGBottom.Text
                Catch ex As SqlException
                    ExceptionHandler.CatchSQLException(ex)
                End Try
            Else
                sqlCommand.CommandText = "EXEC dbo.modARTAGRecord @Action = 2, " & cmdString
                Try
                    sqlCommand.ExecuteNonQuery()
                    MessageBox.Show("Record successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    EnableInputFields(False)
                    btnARTAGBottom.Text = "Edit this record"
                    btnARTAGTop.Text = btnARTAGBottom.Text
                Catch ex As SqlException
                    ExceptionHandler.CatchSQLException(ex)
                End Try
            End If
        End If
    End Sub


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
        btnARTAGBottom.PerformClick()
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class
