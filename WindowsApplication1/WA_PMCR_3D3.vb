Public Class WA_PMCR_3D3
    Implements IFormMethods
    Private formTables As New DataSet

    Private Sub WA_PMCR_3D3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Database.ExistingRecordCheck("PMCR_3D3", "SubNum = " & WarehouseShell.SubNum) Then
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            loadBaseForm()
            loadExistingData()
            btn3D3Bottom.Text = "Edit Record"
            btn3D3Top.Text = btn3D3Bottom.Text
        Else 'If it doesn't exist, change mode to Undefined and show user banner
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            lblNoRecord.Visible = True
            btn3D3Bottom.Text = "Add New Record"
            btn3D3Top.Text = btn3D3Bottom.Text
        End If
        enableInputFields(False)
    End Sub
    Private Sub loadBaseForm()
        WarehouseShell.highlightSelectedNode("WA_PMCR_tab3D3")
        formTables.Tables.Add(Database.ReturnTable("lkpPMCR_3D3_Symptom"))
        cmb2A1A.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb2A1B.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb2A1C.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb2A1D.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb2A1E.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb2A2.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb2A3.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb2B.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb2C.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb2D.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb2E.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb2F.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb3A1A.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb3A1B.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb3A1C.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb3A1D.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb3A1E.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb3A2.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb3A3.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb3B.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb3C.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb3D.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb3E.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb3F.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb4A1A.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb4A1B.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb4A1C.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb4A1D.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb4A1E.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb4A2.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb4A3.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb4B.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb4C.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb4D.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb4E.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb4F.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb5A1A.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb5A1B.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb5A1C.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb5A1D.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb5A1E.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb5A2.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb5A3.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb5B.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb5C.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb5D.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb5E.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb5F.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb6A1A.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb6A1B.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb6A1C.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb6A1D.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb6A1E.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb6A2.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb6A3.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb6B.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb6C.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb6D.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb6E.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb6F.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb7A1A.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb7A1B.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb7A1C.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb7A1D.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb7A1E.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb7A2.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb7A3.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb7B.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb7C.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb7D.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb7E.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb7F.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb8A1A.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb8A1B.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb8A1C.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb8A1D.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb8A1E.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb8A2.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb8A3.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb8B.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb8C.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb8D.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb8E.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb8F.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb9A1A.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb9A1B.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb9A1C.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb9A1D.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb9A1E.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb9A2.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb9A3.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb9B.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb9C.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb9D.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb9E.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb9F.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb10A1A.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb10A1B.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb10A1C.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb10A1D.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb10A1E.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb10A2.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb10A3.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb10B.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb10C.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb10D.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb10E.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
        cmb10F.assignLookup(formTables, "lkpPMCR_3D3_Symptom")
    End Sub
    Private Sub setDefaultValues()
        cmb2A1A.SelectedValue = -1
        cmb2A1B.SelectedValue = -1
        cmb2A1C.SelectedValue = -1
        cmb2A1D.SelectedValue = -1
        cmb2A1E.SelectedValue = -1
        cmb2A2.SelectedValue = -1
        cmb2A3.SelectedValue = -1
        cmb2B.SelectedValue = -1
        cmb2C.SelectedValue = -1
        cmb2D.SelectedValue = -1
        cmb2E.SelectedValue = -1
        cmb2F.SelectedValue = -1
        cmb3A1A.SelectedValue = -1
        cmb3A1B.SelectedValue = -1
        cmb3A1C.SelectedValue = -1
        cmb3A1D.SelectedValue = -1
        cmb3A1E.SelectedValue = -1
        cmb3A2.SelectedValue = -1
        cmb3A3.SelectedValue = -1
        cmb3B.SelectedValue = -1
        cmb3C.SelectedValue = -1
        cmb3D.SelectedValue = -1
        cmb3E.SelectedValue = -1
        cmb3F.SelectedValue = -1
        cmb4A1A.SelectedValue = -1
        cmb4A1B.SelectedValue = -1
        cmb4A1C.SelectedValue = -1
        cmb4A1D.SelectedValue = -1
        cmb4A1E.SelectedValue = -1
        cmb4A2.SelectedValue = -1
        cmb4A3.SelectedValue = -1
        cmb4B.SelectedValue = -1
        cmb4C.SelectedValue = -1
        cmb4D.SelectedValue = -1
        cmb4E.SelectedValue = -1
        cmb4F.SelectedValue = -1
        cmb5A1A.SelectedValue = -1
        cmb5A1B.SelectedValue = -1
        cmb5A1C.SelectedValue = -1
        cmb5A1D.SelectedValue = -1
        cmb5A1E.SelectedValue = -1
        cmb5A2.SelectedValue = -1
        cmb5A3.SelectedValue = -1
        cmb5B.SelectedValue = -1
        cmb5C.SelectedValue = -1
        cmb5D.SelectedValue = -1
        cmb5E.SelectedValue = -1
        cmb5F.SelectedValue = -1
        cmb6A1A.SelectedValue = -1
        cmb6A1B.SelectedValue = -1
        cmb6A1C.SelectedValue = -1
        cmb6A1D.SelectedValue = -1
        cmb6A1E.SelectedValue = -1
        cmb6A2.SelectedValue = -1
        cmb6A3.SelectedValue = -1
        cmb6B.SelectedValue = -1
        cmb6C.SelectedValue = -1
        cmb6D.SelectedValue = -1
        cmb6E.SelectedValue = -1
        cmb6F.SelectedValue = -1
        cmb7A1A.SelectedValue = -1
        cmb7A1B.SelectedValue = -1
        cmb7A1C.SelectedValue = -1
        cmb7A1D.SelectedValue = -1
        cmb7A1E.SelectedValue = -1
        cmb7A2.SelectedValue = -1
        cmb7A3.SelectedValue = -1
        cmb7B.SelectedValue = -1
        cmb7C.SelectedValue = -1
        cmb7D.SelectedValue = -1
        cmb7E.SelectedValue = -1
        cmb7F.SelectedValue = -1
        cmb8A1A.SelectedValue = -1
        cmb8A1B.SelectedValue = -1
        cmb8A1C.SelectedValue = -1
        cmb8A1D.SelectedValue = -1
        cmb8A1E.SelectedValue = -1
        cmb8A2.SelectedValue = -1
        cmb8A3.SelectedValue = -1
        cmb8B.SelectedValue = -1
        cmb8C.SelectedValue = -1
        cmb8D.SelectedValue = -1
        cmb8E.SelectedValue = -1
        cmb8F.SelectedValue = -1
        cmb9A1A.SelectedValue = -1
        cmb9A1B.SelectedValue = -1
        cmb9A1C.SelectedValue = -1
        cmb9A1D.SelectedValue = -1
        cmb9A1E.SelectedValue = -1
        cmb9A2.SelectedValue = -1
        cmb9A3.SelectedValue = -1
        cmb9B.SelectedValue = -1
        cmb9C.SelectedValue = -1
        cmb9D.SelectedValue = -1
        cmb9E.SelectedValue = -1
        cmb9F.SelectedValue = -1
        cmb10A1A.SelectedValue = -1
        cmb10A1B.SelectedValue = -1
        cmb10A1C.SelectedValue = -1
        cmb10A1D.SelectedValue = -1
        cmb10A1E.SelectedValue = -1
        cmb10A2.SelectedValue = -1
        cmb10A3.SelectedValue = -1
        cmb10B.SelectedValue = -1
        cmb10C.SelectedValue = -1
        cmb10D.SelectedValue = -1
        cmb10E.SelectedValue = -1
        cmb10F.SelectedValue = -1
    End Sub
    Private Sub loadExistingData() 'load all non-DGV values (handle DGV loads with separate subs)
        'Grab the individual record, based on RecordID, and assign values to their appropriate fields
        formTables.Tables.Add(Database.ReturnTable("PMCR_3D3", , "SubNum = " & WarehouseShell.SubNum))
        cmb2A1A.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo1019A1A")
        cmb2A1B.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo1019A1B")
        cmb2A1C.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo1019A1C")
        cmb2A1D.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo1019A1D")
        cmb2A1E.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo1019A1E")
        cmb2A2.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo1019A2")
        cmb2A3.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo1019A3")
        cmb2B.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo1019B")
        cmb2C.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo1019C")
        cmb2D.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo1019D")
        cmb2E.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo1019E")
        cmb2F.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo1019F")
        cmb3A1A.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo2029A1A")
        cmb3A1B.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo2029A1B")
        cmb3A1C.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo2029A1C")
        cmb3A1D.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo2029A1D")
        cmb3A1E.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo2029A1E")
        cmb3A2.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo2029A2")
        cmb3A3.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo2029A3")
        cmb3B.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo2029B")
        cmb3C.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo2029C")
        cmb3D.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo2029D")
        cmb3E.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo2029E")
        cmb3F.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo2029F")
        cmb4A1A.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo3039A1A")
        cmb4A1B.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo3039A1B")
        cmb4A1C.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo3039A1C")
        cmb4A1D.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo3039A1D")
        cmb4A1E.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo3039A1E")
        cmb4A2.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo3039A2")
        cmb4A3.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo3039A3")
        cmb4B.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo3039B")
        cmb4C.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo3039C")
        cmb4D.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo3039D")
        cmb4E.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo3039E")
        cmb4F.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo3039F")
        cmb5A1A.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo4049A1A")
        cmb5A1B.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo4049A1B")
        cmb5A1C.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo4049A1C")
        cmb5A1D.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo4049A1D")
        cmb5A1E.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo4049A1E")
        cmb5A2.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo4049A2")
        cmb5A3.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo4049A3")
        cmb5B.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo4049B")
        cmb5C.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo4049C")
        cmb5D.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo4049D")
        cmb5E.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo4049E")
        cmb5F.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo4049F")
        cmb6A1A.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo5059A1A")
        cmb6A1B.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo5059A1B")
        cmb6A1C.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo5059A1C")
        cmb6A1D.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo5059A1D")
        cmb6A1E.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo5059A1E")
        cmb6A2.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo5059A2")
        cmb6A3.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo5059A3")
        cmb6B.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo5059B")
        cmb6C.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo5059C")
        cmb6D.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo5059D")
        cmb6E.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo5059E")
        cmb6F.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo5059F")
        cmb7A1A.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo6069A1A")
        cmb7A1B.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo6069A1B")
        cmb7A1C.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo6069A1C")
        cmb7A1D.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo6069A1D")
        cmb7A1E.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo6069A1E")
        cmb7A2.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo6069A2")
        cmb7A3.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo6069A3")
        cmb7B.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo6069B")
        cmb7C.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo6069C")
        cmb7D.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo6069D")
        cmb7E.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo6069E")
        cmb7F.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo6069F")
        cmb8A1A.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo7079A1A")
        cmb8A1B.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo7079A1B")
        cmb8A1C.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo7079A1C")
        cmb8A1D.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo7079A1D")
        cmb8A1E.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo7079A1E")
        cmb8A2.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo7079A2")
        cmb8A3.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo7079A3")
        cmb8B.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo7079B")
        cmb8C.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo7079C")
        cmb8D.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo7079D")
        cmb8E.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo7079E")
        cmb8F.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo7079F")
        cmb9A1A.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo8089A1A")
        cmb9A1B.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo8089A1B")
        cmb9A1C.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo8089A1C")
        cmb9A1D.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo8089A1D")
        cmb9A1E.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo8089A1E")
        cmb9A2.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo8089A2")
        cmb9A3.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo8089A3")
        cmb9B.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo8089B")
        cmb9C.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo8089C")
        cmb9D.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo8089D")
        cmb9E.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo8089E")
        cmb9F.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo8089F")
        cmb10A1A.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo9099A1A")
        cmb10A1B.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo9099A1B")
        cmb10A1C.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo9099A1C")
        cmb10A1D.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo9099A1D")
        cmb10A1E.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo9099A1E")
        cmb10A2.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo9099A2")
        cmb10A3.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo9099A3")
        cmb10B.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo9099B")
        cmb10C.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo9099C")
        cmb10D.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo9099D")
        cmb10E.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo9099E")
        cmb10F.SelectedValue = formTables.Tables("PMCR_3D3").Rows(0).Item("Schizo9099F")
        formTables.Tables.Add(Database.ReturnTable("viewPMCR_3D3_Notes", , "SubNum = " & WarehouseShell.SubNum))
        txt2AText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("2ANotes").ToString
        txt2BText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("2BNotes").ToString
        txt2CText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("2CNotes").ToString
        txt2DText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("2DNotes").ToString
        txt3AText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("3ANotes").ToString
        txt3BText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("3BNotes").ToString
        txt3CText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("3CNotes").ToString
        txt3DText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("3DNotes").ToString
        txt4AText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("4ANotes").ToString
        txt4BText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("4BNotes").ToString
        txt4CText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("4CNotes").ToString
        txt4DText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("4DNotes").ToString
        txt5AText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("5ANotes").ToString
        txt5BText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("5BNotes").ToString
        txt5CText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("5CNotes").ToString
        txt5DText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("5DNotes").ToString
        txt6AText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("6ANotes").ToString
        txt6BText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("6BNotes").ToString
        txt6CText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("6CNotes").ToString
        txt6DText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("6DNotes").ToString
        txt7AText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("7ANotes").ToString
        txt7BText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("7BNotes").ToString
        txt7CText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("7CNotes").ToString
        txt7DText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("7DNotes").ToString
        txt8AText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("8ANotes").ToString
        txt8BText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("8BNotes").ToString
        txt8CText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("8CNotes").ToString
        txt8DText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("8DNotes").ToString
        txt9AText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("9ANotes").ToString
        txt9BText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("9BNotes").ToString
        txt9CText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("9CNotes").ToString
        txt9DText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("9DNotes").ToString
        txt10AText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("10ANotes").ToString
        txt10BText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("10BNotes").ToString
        txt10CText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("10CNotes").ToString
        txt10DText.Text = formTables.Tables("viewPMCR_3D3_Notes").Rows(0).Item("10DNotes").ToString
    End Sub
    Private Sub enableInputFields(ByVal bool As Boolean)
        If bool = True Then
            grp3D3.Enabled = True
        Else
            grp3D3.Enabled = False
        End If
    End Sub
    Private Sub btn3D3_Click(sender As Object, e As EventArgs) Handles btn3D3Bottom.Click, btn3D3Top.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_PMCR_3D3", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                btn3D3Bottom.Text = "Save Changes"
                btn3D3Top.Text = btn3D3Bottom.Text
                enableInputFields(True)
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If User.PermissionCheck("WA_PMCR_3D3", "Modify") Then
                loadBaseForm()
                setDefaultValues()
                lblNoRecord.Visible = False
                btn3D3Bottom.Text = "Save New Record"
                btn3D3Top.Text = "Save New Record"
                enableInputFields(True)
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
            End If
        Else 'By default, user is attempting to Insert or Edit a record. Run preSaveValidation.
            If preSaveValidation() Then 'If preSaveValidation returns true, take Insert or Update actions.
                'Same parameters for Insert or Update SP's, so define here
                Dim parameters = " @SubNum = " & WarehouseShell.SubNum &
                    ", @Schizo1019A1A = " & cmb2A1A.getSQLValue() &
                    ", @Schizo1019A1B = " & cmb2A1B.getSQLValue() &
                    ", @Schizo1019A1C = " & cmb2A1C.getSQLValue() &
                    ", @Schizo1019A1D = " & cmb2A1D.getSQLValue() &
                    ", @Schizo1019A1E = " & cmb2A1E.getSQLValue() &
                    ", @Schizo1019A2 = " & cmb2A2.getSQLValue() &
                    ", @Schizo1019A3 = " & cmb2A3.getSQLValue() &
                    ", @Schizo1019B = " & cmb2B.getSQLValue() &
                    ", @Schizo1019C = " & cmb2C.getSQLValue() &
                    ", @Schizo1019D = " & cmb2D.getSQLValue() &
                    ", @Schizo1019E = " & cmb2E.getSQLValue() &
                    ", @Schizo1019F = " & cmb2F.getSQLValue() &
                    ", @Schizo2029A1A = " & cmb3A1A.getSQLValue() &
                    ", @Schizo2029A1B = " & cmb3A1B.getSQLValue() &
                    ", @Schizo2029A1C = " & cmb3A1C.getSQLValue() &
                    ", @Schizo2029A1D = " & cmb3A1D.getSQLValue() &
                    ", @Schizo2029A1E = " & cmb3A1E.getSQLValue() &
                    ", @Schizo2029A2 = " & cmb3A2.getSQLValue() &
                    ", @Schizo2029A3 = " & cmb3A3.getSQLValue() &
                    ", @Schizo2029B = " & cmb3B.getSQLValue() &
                    ", @Schizo2029C = " & cmb3C.getSQLValue() &
                    ", @Schizo2029D = " & cmb3D.getSQLValue() &
                    ", @Schizo2029E = " & cmb3E.getSQLValue() &
                    ", @Schizo2029F = " & cmb3F.getSQLValue() &
                    ", @Schizo3039A1A = " & cmb4A1A.getSQLValue() &
                    ", @Schizo3039A1B = " & cmb4A1B.getSQLValue() &
                    ", @Schizo3039A1C = " & cmb4A1C.getSQLValue() &
                    ", @Schizo3039A1D = " & cmb4A1D.getSQLValue() &
                    ", @Schizo3039A1E = " & cmb4A1E.getSQLValue() &
                    ", @Schizo3039A2 = " & cmb4A2.getSQLValue() &
                    ", @Schizo3039A3 = " & cmb4A3.getSQLValue() &
                    ", @Schizo3039B = " & cmb4B.getSQLValue() &
                    ", @Schizo3039C = " & cmb4C.getSQLValue() &
                    ", @Schizo3039D = " & cmb4D.getSQLValue() &
                    ", @Schizo3039E = " & cmb4E.getSQLValue() &
                    ", @Schizo3039F = " & cmb4F.getSQLValue() &
                    ", @Schizo4049A1A = " & cmb5A1A.getSQLValue() &
                    ", @Schizo4049A1B = " & cmb5A1B.getSQLValue() &
                    ", @Schizo4049A1C = " & cmb5A1C.getSQLValue() &
                    ", @Schizo4049A1D = " & cmb5A1D.getSQLValue() &
                    ", @Schizo4049A1E = " & cmb5A1E.getSQLValue() &
                    ", @Schizo4049A2 = " & cmb5A2.getSQLValue() &
                    ", @Schizo4049A3 = " & cmb5A3.getSQLValue() &
                    ", @Schizo4049B = " & cmb5B.getSQLValue() &
                    ", @Schizo4049C = " & cmb5C.getSQLValue() &
                    ", @Schizo4049D = " & cmb5D.getSQLValue() &
                    ", @Schizo4049E = " & cmb5E.getSQLValue() &
                    ", @Schizo4049F = " & cmb5F.getSQLValue() &
                    ", @Schizo5059A1A = " & cmb6A1A.getSQLValue() &
                    ", @Schizo5059A1B = " & cmb6A1B.getSQLValue() &
                    ", @Schizo5059A1C = " & cmb6A1C.getSQLValue() &
                    ", @Schizo5059A1D = " & cmb6A1D.getSQLValue() &
                    ", @Schizo5059A1E = " & cmb6A1E.getSQLValue() &
                    ", @Schizo5059A2 = " & cmb6A2.getSQLValue() &
                    ", @Schizo5059A3 = " & cmb6A3.getSQLValue() &
                    ", @Schizo5059B = " & cmb6B.getSQLValue() &
                    ", @Schizo5059C = " & cmb6C.getSQLValue() &
                    ", @Schizo5059D = " & cmb6D.getSQLValue() &
                    ", @Schizo5059E = " & cmb6E.getSQLValue() &
                    ", @Schizo5059F = " & cmb6F.getSQLValue() &
                    ", @Schizo6069A1A = " & cmb7A1A.getSQLValue() &
                    ", @Schizo6069A1B = " & cmb7A1B.getSQLValue() &
                    ", @Schizo6069A1C = " & cmb7A1C.getSQLValue() &
                    ", @Schizo6069A1D = " & cmb7A1D.getSQLValue() &
                    ", @Schizo6069A1E = " & cmb7A1E.getSQLValue() &
                    ", @Schizo6069A2 = " & cmb7A2.getSQLValue() &
                    ", @Schizo6069A3 = " & cmb7A3.getSQLValue() &
                    ", @Schizo6069B = " & cmb7B.getSQLValue() &
                    ", @Schizo6069C = " & cmb7C.getSQLValue() &
                    ", @Schizo6069D = " & cmb7D.getSQLValue() &
                    ", @Schizo6069E = " & cmb7E.getSQLValue() &
                    ", @Schizo6069F = " & cmb7F.getSQLValue() &
                    ", @Schizo7079A1A = " & cmb8A1A.getSQLValue() &
                    ", @Schizo7079A1B = " & cmb8A1B.getSQLValue() &
                    ", @Schizo7079A1C = " & cmb8A1C.getSQLValue() &
                    ", @Schizo7079A1D = " & cmb8A1D.getSQLValue() &
                    ", @Schizo7079A1E = " & cmb8A1E.getSQLValue() &
                    ", @Schizo7079A2 = " & cmb8A2.getSQLValue() &
                    ", @Schizo7079A3 = " & cmb8A3.getSQLValue() &
                    ", @Schizo7079B = " & cmb8B.getSQLValue() &
                    ", @Schizo7079C = " & cmb8C.getSQLValue() &
                    ", @Schizo7079D = " & cmb8D.getSQLValue() &
                    ", @Schizo7079E = " & cmb8E.getSQLValue() &
                    ", @Schizo7079F = " & cmb8F.getSQLValue() &
                    ", @Schizo8089A1A = " & cmb9A1A.getSQLValue() &
                    ", @Schizo8089A1B = " & cmb9A1B.getSQLValue() &
                    ", @Schizo8089A1C = " & cmb9A1C.getSQLValue() &
                    ", @Schizo8089A1D = " & cmb9A1D.getSQLValue() &
                    ", @Schizo8089A1E = " & cmb9A1E.getSQLValue() &
                    ", @Schizo8089A2 = " & cmb9A2.getSQLValue() &
                    ", @Schizo8089A3 = " & cmb9A3.getSQLValue() &
                    ", @Schizo8089B = " & cmb9B.getSQLValue() &
                    ", @Schizo8089C = " & cmb9C.getSQLValue() &
                    ", @Schizo8089D = " & cmb9D.getSQLValue() &
                    ", @Schizo8089E = " & cmb9E.getSQLValue() &
                    ", @Schizo8089F = " & cmb9F.getSQLValue() &
                    ", @Schizo9099A1A = " & cmb10A1A.getSQLValue() &
                    ", @Schizo9099A1B = " & cmb10A1B.getSQLValue() &
                    ", @Schizo9099A1C = " & cmb10A1C.getSQLValue() &
                    ", @Schizo9099A1D = " & cmb10A1D.getSQLValue() &
                    ", @Schizo9099A1E = " & cmb10A1E.getSQLValue() &
                    ", @Schizo9099A2 = " & cmb10A2.getSQLValue() &
                    ", @Schizo9099A3 = " & cmb10A3.getSQLValue() &
                    ", @Schizo9099B = " & cmb10B.getSQLValue() &
                    ", @Schizo9099C = " & cmb10C.getSQLValue() &
                    ", @Schizo9099D = " & cmb10D.getSQLValue() &
                    ", @Schizo9099E = " & cmb10E.getSQLValue() &
                    ", @Schizo9099F = " & cmb10F.getSQLValue() &
                    ", @LastModBy = '" & WarehouseShell.userName & "';"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    Dim cmd As New SqlCommand("Exec modPMCR_3D3Record @Action = 1, " & parameters, WarehouseShell.conn)
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Save successful", MsgBoxStyle.OkOnly)
                        enableInputFields(False)
                        btn3D3Bottom.Text = "Edit Record"
                        btn3D3Top.Text = "Edit Record"
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else 'If this clause is invoked, datamode must be Edit
                    Dim cmd As New SqlCommand("Exec modPMCR_3D3Record @Action = 2, " & parameters, WarehouseShell.conn)
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Save successful", MsgBoxStyle.OkOnly)
                        enableInputFields(False)
                        btn3D3Bottom.Text = "Edit Record"
                        btn3D3Top.Text = "Edit Record"
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                End If
            End If
        End If
    End Sub
    Private Function preSaveValidation() As Boolean
        Return True
    End Function

    'Imported IForm Methods
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
    Public Sub Parent1(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
        btn3D3Bottom.PerformClick()
    End Sub
    Public Sub Show1() Implements IFormMethods.Show
        Show()
    End Sub
    Public Sub ShowPHI(val As Boolean) Implements IFormMethods.ShowPHI
    End Sub
    Public Sub TopLevel(val As Boolean) Implements IFormMethods.TopLevel
        TopLevel(val)
    End Sub
End Class