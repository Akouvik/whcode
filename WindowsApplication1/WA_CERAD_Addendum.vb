Public Class WA_CERAD_Addendum
    Implements IFormMethods
    Private insertString As String = Nothing
    Private updateString As String = Nothing
    Private formTables As New DataSet
    Private tooltip1 As New ToolTip

    'Load form and set data mode
    Private Sub WA_CERAD_Addendum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_CERAD_Addendum")
        WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
        If Database.ExistingRecordCheck("CERAD_Addendum", "SubNum = " & WarehouseShell.SubNum) = True Then
            loadBaseForm()
            defaultValues()
            enableInputFields(False)
            loadExistingData()
            btnCERAD_AddendumBottom.Text = "Edit this record"
            btnCERAD_AddendumTop.Text = btnCERAD_AddendumBottom.Text
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            btnCERAD_AddendumTop.Focus()
        Else
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            btnCERAD_AddendumBottom.Text = "Add New Record"
            btnCERAD_AddendumTop.Text = btnCERAD_AddendumBottom.Text
            enableInputFields(False)
            lblNoRecord.Visible = True
        End If
    End Sub
    'Grab applicable lookup tables and assign the actual lookup values
    Private Sub loadBaseForm()
        'Load all required lookup tables into the comboValues DataSet
        formTables.Tables.Add(Database.ReturnTable("lkpYNNAUnk1239"))
        formTables.Tables.Add(Database.ReturnTable("lkpCERADPath11"))
        formTables.Tables.Add(Database.ReturnTable("lkpCERADPath17a"))
        formTables.Tables.Add(Database.ReturnTable("lkpCERADPath18b"))
        formTables.Tables.Add(Database.ReturnTable("lkpCERADPath18c"))
        formTables.Tables.Add(Database.ReturnTable("lkpCERADPath19"))
        formTables.Tables.Add(Database.ReturnTable("lkpCERADPath20"))
        formTables.Tables.Add(Database.ReturnTable("lkpCERADPath8a"))
        formTables.Tables.Add(Database.ReturnTable("lkpCERADPath8b"))
        formTables.Tables.Add(Database.ReturnTable("lkpCERADPath8cd"))
        formTables.Tables.Add(Database.ReturnTable("lkpNBB_AlphaSynPathType"))
        formTables.Tables.Add(Database.ReturnTable("lkpNBB_YNUnkNA"))
        'Assign lookup values to each individual combobox
        combo8a.assignLookup(formTables, "lkpCERADPath8a")
        combo8b.assignLookup(formTables, "lkpCERADPath8b")
        combo8c.assignLookup(formTables, "lkpCERADPath8cd")
        combo8d.assignLookup(formTables, "lkpCERADPath8cd")
        combo11.assignLookup(formTables, "lkpCERADPath11")
        combo12f.assignLookup(formTables, "lkpYNNAUnk1239")
        combo12g.assignLookup(formTables, "lkpYNNAUnk1239")
        combo12h.assignLookup(formTables, "lkpYNNAUnk1239")
        combo12k.assignLookup(formTables, "lkpYNNAUnk1239")
        combo17a.assignLookup(formTables, "lkpCERADPath17a")
        combo18b.assignLookup(formTables, "lkpCERADPath18b")
        combo18c.assignLookup(formTables, "lkpCERADPath18c")
        combo19.assignLookup(formTables, "lkpCERADPath19")
        combo20a.assignLookup(formTables, "lkpCERADPath20")
        combo20b.assignLookup(formTables, "lkpCERADPath20")
        combo20c.assignLookup(formTables, "lkpCERADPath20")
        combo20d.assignLookup(formTables, "lkpCERADPath20")
        combo20e.assignLookup(formTables, "lkpCERADPath20")
        combo20f.assignLookup(formTables, "lkpCERADPath20")
        combo20g.assignLookup(formTables, "lkpCERADPath20")
        combo20h.assignLookup(formTables, "lkpCERADPath20")
        combo20i.assignLookup(formTables, "lkpCERADPath20")
        combo20j.assignLookup(formTables, "lkpCERADPath20")
        combo20k.assignLookup(formTables, "lkpCERADPath20")
        cmbAlphaSynPathInd.assignLookup(formTables, "lkpNBB_YNUnkNA")
        cmbAlphaSynPathType.assignLookup(formTables, "lkpNBB_AlphaSynPathType")
        cmbUbiquitinPath.assignLookup(formTables, "lkpNBB_YNUnkNA")
        cmbTDP43Path.assignLookup(formTables, "lkpNBB_YNUnkNA")
        pnlAlphaSynLoc.Visible = False
        pnlUbiquitinLoc.Visible = False
        pnlTDP43Loc.Visible = False
    End Sub
    'Sub to set default values for the form. Not called for view or edit modes.
    Private Sub defaultValues()
        'Set all of the combo boxes to -1 (blank)
        combo8a.SelectedValue = -1
        combo8b.SelectedValue = -1
        combo8c.SelectedValue = -1
        combo8d.SelectedValue = -1
        combo11.SelectedValue = -1
        combo12f.SelectedValue = -1
        combo12g.SelectedValue = -1
        combo12h.SelectedValue = -1
        combo12k.SelectedValue = -1
        combo17a.SelectedValue = -1
        combo18b.SelectedValue = -1
        combo18c.SelectedValue = -1
        combo19.SelectedValue = -1
        combo20a.SelectedValue = -1
        combo20b.SelectedValue = -1
        combo20c.SelectedValue = -1
        combo20c.SelectedValue = -1
        combo20d.SelectedValue = -1
        combo20e.SelectedValue = -1
        combo20f.SelectedValue = -1
        combo20g.SelectedValue = -1
        combo20h.SelectedValue = -1
        combo20i.SelectedValue = -1
        combo20j.SelectedValue = -1
        combo20k.SelectedValue = -1
        cmbAlphaSynPathInd.SelectedValue = "-1"
        cmbAlphaSynPathType.SelectedValue = "-1"
        cmbUbiquitinPath.SelectedValue = "-1"
        cmbTDP43Path.SelectedValue = "-1"
    End Sub
    'Sub to load existing values into form for View/Edit modes
    Private Sub loadExistingData()
        'Grab the CERADJ record for this SubNum
        formTables.Tables.Add(Database.ReturnTable("CERAD_Addendum", , "SubNum = " & WarehouseShell.SubNum))
        'Apply the existing values to the input fields
        combo8a.SelectedValue = formTables.Tables("CERAD_Addendum").Rows(0).Item("Path8a") 'literal values for combo boxes
        combo8b.SelectedValue = formTables.Tables("CERAD_Addendum").Rows(0).Item("Path8b")
        combo8c.SelectedValue = formTables.Tables("CERAD_Addendum").Rows(0).Item("Path8c")
        combo8d.SelectedValue = formTables.Tables("CERAD_Addendum").Rows(0).Item("Path8d")
        combo11.SelectedValue = formTables.Tables("CERAD_Addendum").Rows(0).Item("Path11")
        combo12f.SelectedValue = formTables.Tables("CERAD_Addendum").Rows(0).Item("Path12f")
        combo12g.SelectedValue = formTables.Tables("CERAD_Addendum").Rows(0).Item("Path12g")
        combo12h.SelectedValue = formTables.Tables("CERAD_Addendum").Rows(0).Item("Path12h")
        combo12k.SelectedValue = formTables.Tables("CERAD_Addendum").Rows(0).Item("Path12k")
        combo17a.SelectedValue = formTables.Tables("CERAD_Addendum").Rows(0).Item("Path17a")
        txt17b.Text = formTables.Tables("CERAD_Addendum").Rows(0).Item("Path17bNote").ToString 'string values for text fields
        combo18b.SelectedValue = formTables.Tables("CERAD_Addendum").Rows(0).Item("Path18b")
        combo18c.SelectedValue = formTables.Tables("CERAD_Addendum").Rows(0).Item("Path18c")
        combo19.SelectedValue = formTables.Tables("CERAD_Addendum").Rows(0).Item("Path19")
        combo20a.SelectedValue = formTables.Tables("CERAD_Addendum").Rows(0).Item("Path20a")
        combo20b.SelectedValue = formTables.Tables("CERAD_Addendum").Rows(0).Item("Path20b")
        combo20c.SelectedValue = formTables.Tables("CERAD_Addendum").Rows(0).Item("Path20c")
        combo20d.SelectedValue = formTables.Tables("CERAD_Addendum").Rows(0).Item("Path20d")
        combo20e.SelectedValue = formTables.Tables("CERAD_Addendum").Rows(0).Item("Path20e")
        combo20f.SelectedValue = formTables.Tables("CERAD_Addendum").Rows(0).Item("Path20f")
        combo20g.SelectedValue = formTables.Tables("CERAD_Addendum").Rows(0).Item("Path20g")
        combo20h.SelectedValue = formTables.Tables("CERAD_Addendum").Rows(0).Item("Path20h")
        combo20i.SelectedValue = formTables.Tables("CERAD_Addendum").Rows(0).Item("Path20i")
        txt20i.Text = formTables.Tables("CERAD_Addendum").Rows(0).Item("Path20iNote").ToString
        combo20j.SelectedValue = formTables.Tables("CERAD_Addendum").Rows(0).Item("Path20j")
        txt20j.Text = formTables.Tables("CERAD_Addendum").Rows(0).Item("Path20jNote").ToString
        combo20k.SelectedValue = formTables.Tables("CERAD_Addendum").Rows(0).Item("Path20k")
        txt20k.Text = formTables.Tables("CERAD_Addendum").Rows(0).Item("Path20kNote").ToString
        cmbAlphaSynPathInd.SelectedValue = formTables.Tables("CERAD_Addendum").Rows(0).Item("AlphaPathInd").ToString
        cmbAlphaSynPathType.SelectedValue = formTables.Tables("CERAD_Addendum").Rows(0).Item("AlphaPath").ToString
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("AlphaPathInd").ToString = "PV005350" Then
            pnlAlphaSynLoc.Visible = True
            loadExistingAlphaLocs()
        End If
        cmbUbiquitinPath.SelectedValue = formTables.Tables("CERAD_Addendum").Rows(0).Item("UbiquitinPath").ToString
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("UbiquitinPath").ToString = "PV005350" Then
            pnlUbiquitinLoc.Visible = True
            loadExistingUbiquitinLocs()
        End If
        cmbTDP43Path.SelectedValue = formTables.Tables("CERAD_Addendum").Rows(0).Item("TDPPath").ToString
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("TDPPath").ToString = "PV005350" Then
            pnlTDP43Loc.Visible = True
            loadExistingTDP43Locs()
        End If
    End Sub

    'Subs to enable-disable fields during data input based on conditional logic.
    Private Sub enableInputFields(ByVal value As Boolean)
        combo8a.Enabled = value
        combo8b.Enabled = value
        combo8c.Enabled = value
        combo8d.Enabled = value
        combo11.Enabled = value
        combo12f.Enabled = value
        combo12g.Enabled = value
        combo12h.Enabled = value
        combo12k.Enabled = value
        combo17a.Enabled = value
        txt17b.Enabled = value
        combo18b.Enabled = value
        combo18c.Enabled = value
        combo19.Enabled = value
        combo20a.Enabled = value
        combo20b.Enabled = value
        combo20c.Enabled = value
        combo20d.Enabled = value
        combo20e.Enabled = value
        combo20f.Enabled = value
        combo20g.Enabled = value
        combo20h.Enabled = value
        combo20i.Enabled = value
        txt20i.Enabled = value
        combo20j.Enabled = value
        txt20j.Enabled = value
        combo20k.Enabled = value
        txt20k.Enabled = value
        cmbAlphaSynPathInd.Enabled = value
        cmbAlphaSynPathType.Enabled = value
        enableAlphaSynLocs(value)
        cmbUbiquitinPath.Enabled = value
        enableUbiLocs(value)
        cmbTDP43Path.Enabled = value
        enableTDP43Locs(value)
    End Sub

    Private Sub cmbAlphaSynPathInd_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbAlphaSynPathInd.SelectedValueChanged
        If cmbAlphaSynPathInd.Text = "Yes" Then
            pnlAlphaSynLoc.Visible = True
        Else
            pnlAlphaSynLoc.Visible = False
        End If
    End Sub
    Private Function calcAlphaLocs() As String
        Dim result As String = ""
        Dim x As CheckBox_
        For Each x In grpAlphaSynPathLoc.Controls
            If x.Checked Then
                If result = "" Then
                    result += x.Tag.ToString
                Else
                    result += ";" & x.Tag.ToString
                End If
            End If
        Next
        If result = "" Then
            Return "null"
        Else
            Return "'" & result & "'"
        End If
    End Function
    Private Sub clearAlphaLocs()
        Dim x As CheckBox_
        For Each x In grpAlphaSynPathLoc.Controls
            x.Checked = False
        Next
    End Sub
    Private Sub loadExistingAlphaLocs()
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a1a") Then
            chkAlphaFrontalCortex.Checked = True
        Else
            chkAlphaFrontalCortex.Checked = False
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a2a") Then
            chkAlphaSupTempSulc.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a3a") Then
            chkAlphaParietalCortex.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a4a") Then
            chkAlphaAmyg.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a5a") Then
            chkAlphaInsula.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a6a") Then
            chkAlphaCingGyr.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a7a") Then
            chkAlphaHippo.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a8a") Then
            chkAlphaSubNigra.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a9a") Then
            chkAlphaThal.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a10a") Then
            chkAlphaMedulla.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a11a") Then
            chkAlphaPons.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a12a") Then
            chkAlphaCervSpinCord.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a13a") Then
            chkAlphaPrimVisCortex.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a14a") Then
            chkAlphaCere.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a15a") Then
            chkAlphaCaudNuc.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a16a") Then
            chkAlphaPeriWhtMat.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a17a") Then
            chkAlphaPrimMotCortex.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a18a") Then
            chkAlphaOlfTracts.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a19a") Then
            chkAlphaThorSpinCord.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("AlphaLocs").ToString.Contains("a20a") Then
            chkAlphaLumbSpinCord.Checked = True
        End If
    End Sub
    Private Sub enableAlphaSynLocs(ByVal bool As Boolean)
        If bool = True Then
            Dim x As CheckBox_
            For Each x In grpAlphaSynPathLoc.Controls
                x.Enabled = True
            Next
        Else
            Dim x As CheckBox_
            For Each x In grpAlphaSynPathLoc.Controls
                x.Enabled = False
            Next
        End If
    End Sub

    Private Sub cmbUbiquitinPath_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbUbiquitinPath.SelectedValueChanged
        If cmbUbiquitinPath.Text = "Yes" Then
            pnlUbiquitinLoc.Visible = True
        Else
            pnlUbiquitinLoc.Visible = False
        End If
    End Sub
    Private Function calcUbiquitinLocs() As String
        Dim result As String = ""
        Dim x As CheckBox_
        For Each x In grpUbiquitin.Controls
            If x.Checked Then
                If result = "" Then
                    result += x.Tag.ToString
                Else
                    result += ";" & x.Tag.ToString
                End If
            End If
        Next
        If result = "" Then
            Return "null"
        Else
            Return "'" & result & "'"
        End If
    End Function
    Private Sub clearUbiquitinLocs()
        Dim x As CheckBox_
        For Each x In grpUbiquitin.Controls
            x.Checked = False
        Next
    End Sub
    Private Sub loadExistingUbiquitinLocs()
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a1a") Then
            chkUbiFrontalCortex.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a2a") Then
            chkUbiSupTempSulc.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a3a") Then
            chkUbiParietalCortex.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a4a") Then
            chkUbiAmyg.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a5a") Then
            chkUbiInsula.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a6a") Then
            chkUbiCingGyr.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a7a") Then
            chkUbiHippo.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a8a") Then
            chkUbiSubNigra.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a9a") Then
            chkUbiThal.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a10a") Then
            chkUbiMedulla.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a11a") Then
            chkUbiPons.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a12a") Then
            chkUbiCervSpinCord.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a13a") Then
            chkUbiPrimVisCortex.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a14a") Then
            chkUbiCere.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a15a") Then
            chkUbiCaudNuc.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a16a") Then
            chkUbiPeriWhtMat.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a17a") Then
            chkUbiPrimMotCortex.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a18a") Then
            chkUbiOlfTracts.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a19a") Then
            chkUbiThorSpinCord.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("UbiquitinLocs").ToString.Contains("a20a") Then
            chkUbiLumbSpinCord.Checked = True
        End If
    End Sub
    Private Sub enableUbiLocs(ByVal bool As Boolean)
        If bool = True Then
            Dim x As CheckBox_
            For Each x In grpUbiquitin.Controls
                x.Enabled = True
            Next
        Else
            Dim x As CheckBox_
            For Each x In grpUbiquitin.Controls
                x.Enabled = False
            Next
        End If
    End Sub

    Private Sub cmbTDP43Path_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbTDP43Path.SelectedValueChanged
        If cmbTDP43Path.Text = "Yes" Then
            pnlTDP43Loc.Visible = True
        Else
            pnlTDP43Loc.Visible = False
        End If
    End Sub
    Private Function calcTDP43Locs() As String
        Dim result As String = ""
        Dim x As CheckBox_
        For Each x In grpTDP43.Controls
            If x.Checked Then
                If result = "" Then
                    result += x.Tag.ToString
                Else
                    result += ";" & x.Tag.ToString
                End If
            End If
        Next
        If result = "" Then
            Return "null"
        Else
            Return "'" & result & "'"
        End If
    End Function
    Private Sub clearTDP43Locs()
        Dim x As CheckBox_
        For Each x In grpAlphaSynPathLoc.Controls
            x.Checked = False
        Next
    End Sub
    Private Sub loadExistingTDP43Locs()
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a1a") Then
            chkTDPFrontalCortex.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a2a") Then
            chkTDPSupTempSulc.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a3a") Then
            chkTDPParietalCortex.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a4a") Then
            chkTDPAmyg.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a5a") Then
            chkTDPInsula.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a6a") Then
            chkTDPCingGyr.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a7a") Then
            chkTDPHippo.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a8a") Then
            chkTDPSubNigra.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a9a") Then
            chkTDPThal.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a10a") Then
            chkTDPMedulla.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a11a") Then
            chkTDPPons.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a12a") Then
            chkTDPCervSpinCord.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a13a") Then
            chkTDPPrimVisCortex.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a14a") Then
            chkTDPCere.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a15a") Then
            chkTDPCaudNuc.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a16a") Then
            chkTDPPeriWhtMat.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a17a") Then
            chkTDPPrimMotCortex.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a18a") Then
            chkTDPOlfTracts.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a19a") Then
            chkTDPThorSpinCord.Checked = True
        End If
        If formTables.Tables("CERAD_Addendum").Rows(0).Item("TDPLocs").ToString.Contains("a20a") Then
            chkTDPLumbSpinCord.Checked = True
        End If
    End Sub
    Private Sub enableTDP43Locs(ByVal bool As Boolean)
        If bool = True Then
            Dim x As CheckBox_
            For Each x In grpTDP43.Controls
                x.Enabled = True
            Next
        Else
            Dim x As CheckBox_
            For Each x In grpTDP43.Controls
                x.Enabled = False
            Next
        End If
    End Sub


    'Define button click events
    Private Sub btnCERAD_Addendum_Click(sender As Object, e As EventArgs) Handles btnCERAD_AddendumTop.Click, btnCERAD_AddendumBottom.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_CERAD_Addendum", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                enableInputFields(True)
                btnCERAD_AddendumBottom.Text = "Save changes"
                btnCERAD_AddendumTop.Text = btnCERAD_AddendumBottom.Text
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If Database.ExistingRecordCheck("CERAD_Header", "SubNum = " & WarehouseShell.SubNum) Then
                If User.PermissionCheck("WA_CERAD_Addendum", "Modify") Then
                    WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
                    loadBaseForm()
                    defaultValues()
                    enableInputFields(True)
                    btnCERAD_AddendumBottom.Text = "Save new record"
                    btnCERAD_AddendumTop.Text = btnCERAD_AddendumBottom.Text
                    lblNoRecord.Visible = False
                End If
            Else
                MsgBox("Please create a CERAD Header for this subject before attempting to add CERAD information.", MsgBoxStyle.OkOnly, "Error!")
            End If
        Else
            If preSaveValidation() Then
                Dim sqlCommand As New SqlCommand
                sqlCommand.Connection = WarehouseShell.conn
                Dim cmdString As String = "@SubNum = " & WarehouseShell.SubNum &
                    ", @Path8a = " & combo8a.getSQLValue() &
                    ", @Path8b = " & combo8b.getSQLValue() &
                    ", @Path8c = " & combo8c.getSQLValue() &
                    ", @Path8d = " & combo8d.getSQLValue() &
                    ", @Path11 = " & combo11.getSQLValue() &
                    ", @Path12f = " & combo12f.getSQLValue() &
                    ", @Path12g = " & combo12g.getSQLValue() &
                    ", @Path12h = " & combo12h.getSQLValue() &
                    ", @Path12k = " & combo12k.getSQLValue() &
                    ", @Path17a = " & combo17a.getSQLValue() &
                    ", @Path17bNote = " & txt17b.getSQLValue() &
                    ", @Path18b = " & combo18b.getSQLValue() &
                    ", @Path18c = " & combo18c.getSQLValue() &
                    ", @Path19 = " & combo19.getSQLValue() &
                    ", @Path20a = " & combo20a.getSQLValue() &
                    ", @Path20b = " & combo20b.getSQLValue() &
                    ", @Path20c = " & combo20c.getSQLValue() &
                    ", @Path20d = " & combo20d.getSQLValue() &
                    ", @Path20e = " & combo20e.getSQLValue() &
                    ", @Path20f = " & combo20f.getSQLValue() &
                    ", @Path20g = " & combo20g.getSQLValue() &
                    ", @Path20h = " & combo20h.getSQLValue() &
                    ", @Path20i = " & combo20i.getSQLValue() &
                    ", @Path20iNote = " & txt20i.getSQLValue() &
                    ", @Path20j = " & combo20j.getSQLValue() &
                    ", @Path20jNote = " & txt20j.getSQLValue() &
                    ", @Path20k = " & combo20k.getSQLValue() &
                    ", @Path20kNote = " & txt20k.getSQLValue() &
                    ", @AlphaPathInd = " & customComboNullCheckReturnSelectedValue(cmbAlphaSynPathInd) &
                    ", @AlphaPath = " & customComboNullCheckReturnSelectedValue(cmbAlphaSynPathType) &
                    ", @AlphaLocs = " & IIf(pnlAlphaSynLoc.Visible, calcAlphaLocs(), "null") &
                    ", @UbiquitinPath = " & customComboNullCheckReturnSelectedValue(cmbUbiquitinPath) &
                    ", @UbiquitinLocs = " & IIf(pnlUbiquitinLoc.Visible, calcUbiquitinLocs(), "null") &
                    ", @TDPPath = " & customComboNullCheckReturnSelectedValue(cmbTDP43Path) &
                    ", @TDPLocs = " & IIf(pnlTDP43Loc.Visible, calcTDP43Locs(), "null") &
                    ";"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    sqlCommand.CommandText = "EXEC dbo.modCERAD_AddendumRecord @Action = 1, " & cmdString
                    Try
                        sqlCommand.ExecuteNonQuery()
                        MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        enableInputFields(False)
                        btnCERAD_AddendumBottom.Text = "Edit this record"
                        btnCERAD_AddendumTop.Text = btnCERAD_AddendumBottom.Text
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else
                    sqlCommand.CommandText = "EXEC dbo.modCERAD_AddendumRecord @Action = 2, " & cmdString
                    Try
                        sqlCommand.ExecuteNonQuery()
                        MessageBox.Show("Record was successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        WarehouseShell.LoadWorkingAreaForm(WarehouseShell.formType.WA_CERAD_Addendum)
                        enableInputFields(False)
                        btnCERAD_AddendumBottom.Text = "Edit this record"
                        btnCERAD_AddendumTop.Text = btnCERAD_AddendumBottom.Text
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                End If
            End If
        End If
    End Sub

    Private Function preSaveValidation() As Boolean
        Dim result As Boolean = True
        Dim warningResult As DialogResult
        Dim errorMessage As String = ""
        Dim sqlCommand As New SqlCommand
        sqlCommand.Connection = WarehouseShell.conn

        'Check for warnings

        'Alpha-Synuclein Stain without Alpha-Synuclein Pathology Indicator
        sqlCommand.CommandText = "select Synuclein from CERADG1 where SubNum = " & WarehouseShell.SubNum & ";"
        Dim alphaSynStain As Integer = sqlCommand.ExecuteScalar()
        If alphaSynStain = 1 And cmbAlphaSynPathInd.SelectedValue <> "PV005350" Then
            warningResult = MsgBox("You have indicated that you used Alpha-Synuclein stain on the CERAD-G1 form, but you did not select ""Yes"" for Alpha-Synuclein Pathology Indicator. Are you SURE this is correct?", MsgBoxStyle.YesNo, "Warning!")
            If warningResult = DialogResult.No Then
                errorMessage += "- You have indicated that you used Alpha-Synuclein stain on the CERAD-G1 form, but you did not select ""Yes"" for Alpha-Synuclein Pathology Indicator." & vbNewLine & vbNewLine
                result = False
            End If
        End If

        'Alpha-Synuclein Pathology Indicator without Alpha-Synuclein Pathology Type
        If cmbAlphaSynPathInd.SelectedValue = "PV005350" And
            (cmbAlphaSynPathType.SelectedValue = "-1" _
            Or cmbAlphaSynPathType.SelectedValue = "0" _
            Or cmbAlphaSynPathType.SelectedValue = "PV005415" _
            Or cmbAlphaSynPathType.SelectedValue = "PV005416") _
        Then
            warningResult = MsgBox("You have indicated thate there was an Alpha-Synuclein Pathology Indicator but have not selected an Alpha-Synuclein Pathology Type. Are you SURE this is correct?", MsgBoxStyle.YesNo, "Warning!")
            If warningResult = DialogResult.No Then
                errorMessage += "- You have indicated thate there was an Alpha-Synuclein Pathology Indicator but have not selected an Alpha-Synuclein Pathology Type." & vbNewLine & vbNewLine
                result = False
            End If
        End If


        'Check for hard errors

        'Alpha-Synuclein Pathology Indicator without Alpha-Synuclein Stain checked
        If alphaSynStain = 0 And cmbAlphaSynPathInd.SelectedValue = "PV005350" Then
            MsgBox("You have selected ""Yes"" for Alpha-Synuclein Pathology Indicator, but you did not show that you used Alpha-Synuclein Stain on the CERAD-G1 form. Please remember to fix that after you save this record!", MsgBoxStyle.OkOnly, "Warning!")
        End If
        'Alpha-Synuclein Pathology Indicator without any locations checked
        If cmbAlphaSynPathType.Text <> "" And cmbAlphaSynPathType.Text <> "None" And cmbAlphaSynPathType.Text <> "Not assessed" And cmbAlphaSynPathType.Text <> "Unknown" Then
            If areLocationsChecked(grpAlphaSynPathLoc) = False Then
                errorMessage += "- You have selected Yes for Alpha-Synuclein Pathology Indicator, but you have not selected any locations." & vbNewLine & vbNewLine
                result = False
            End If
        End If


        'Manage results
        If result = False Then
            MsgBox("The following errors must be corrected before this record can be saved." & vbNewLine & vbNewLine & errorMessage, MsgBoxStyle.OkOnly, "Error!")
        End If
        Return result
    End Function
    Private Function areLocationsChecked(ByVal group As GroupBox) As Boolean
        Dim x As CheckBox_
        Dim count As Integer = 0
        For Each x In group.Controls
            If x.Checked = True Then
                count = count + 1
            End If
        Next
        If count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function customComboNullCheckReturnSelectedValue(ByRef variable As ComboBox)
        Dim Result As String
        Result = IIf(variable.Text = "", "NULL", "'" & Replace(variable.SelectedValue, "'", "''") & "'")
        Return Result
    End Function

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
        btnCERAD_AddendumBottom.PerformClick()
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class