Public Class Head_SubjectSelect
    Implements IFormMethods
    Private totalFlags As Integer = 0
    Private bs As BindingSource 'Used in the assignHeaderBindingSource sub.

    'Sub to clear the Subject table from system memory once a subject is selected and the WarehouseShell.SubNum is populated.
    'If this sub is not called, the application must hold the entire subject table in system memory even after it is no longer needed.
    'Called by the WA_SubjectSelect form in the Finalize() sub when the form closes.
    Public Sub assignHeaderBindingSource(ByRef Source As BindingSource, Optional ByVal Release As Boolean = False)
        If Release = True Then
            bs = Nothing
        Else
            bs = Source
        End If
    End Sub

    'Sub to lock/unlock input fields
    Public Sub enableInputFields(ByVal bool As Boolean)
        txtFirstName.Enabled = bool
        txtLastName.Enabled = bool
        dtDoB.Enabled = bool
        dtDoD.Enabled = bool
        txtSSN.Enabled = bool
        txtBBList.Enabled = bool
        intSubNum.Enabled = bool
        txtXENum.Enabled = bool
        txtNACCID.Enabled = bool
        btnFilter.Visible = bool
    End Sub

    'Sub to load the header with selected subject data from the WA_SubjectSelect from.
    'Called by the WA_SubjectSelect form in the btnSubjectSelect click sub.
    Public Sub UpdateHeaderData(ByVal SubNum As Integer)
        Dim table As New DataTable
        table = Database.ReturnTable("viewSubjectHeader",, "SubNum = " & SubNum)
        txtFirstName.Text = table.Rows(0).Item("FirstName").ToString
        txtLastName.Text = table.Rows(0).Item("LastName").ToString
        dtDoB.Text = If(IsDBNull(table.Rows(0).Item("DoB")), "  /  /", Format(table.Rows(0).Item("DoB"), "MM/dd/yyyy"))
        dtDoD.Text = If(IsDBNull(table.Rows(0).Item("DateOfDeath")), "  /  /", Format(table.Rows(0).Item("DateOfDeath"), "MM/dd/yyyy"))
        txtAge.Text = table.Rows(0).Item("Age").ToString
        txtSSN.Text = table.Rows(0).Item("SSN").ToString
        txtBBList.Text = table.Rows(0).Item("BB").ToString
        intSubNum.Text = table.Rows(0).Item("SubNum").ToString
        txtXENum.Text = table.Rows(0).Item("XENum").ToString
        txtNACCID.Text = table.Rows(0).Item("NACCID").ToString
        txtCDR.Text = table.Rows(0).Item("CDRScore").ToString
        txtPMI.Text = table.Rows(0).Item("PMI").ToString
        txtNP1.Text = table.Rows(0).Item("HarryNP1").ToString
        txtCohorts.Text = generateCohortString(intSubNum.Text)
    End Sub
    Public Sub manualUpdateHeaderData(ByVal SubNum As String, Optional ByVal BB As String = "", Optional ByVal FirstName As String = "", Optional ByVal LastName As String = "", Optional ByVal DateOfBirth As String = "  /  /", Optional ByVal DateOfDeath As String = "  /  /", Optional ByVal SSN As String = "", Optional ByVal Age As String = "", Optional ByVal XENum As String = "", Optional ByVal NACCID As String = "", Optional ByVal CDR As String = "", Optional ByVal PMI As String = "", Optional ByVal NP1 As String = "")
        'DO NOT remove the if statements. They allow this sub to be used to do partial updates!!!
        If FirstName <> "" Then
            txtFirstName.Text = FirstName
        End If
        If LastName <> "" Then
            txtLastName.Text = LastName
        End If
        If DateOfBirth <> "  /  /" Then
            dtDoB.Text = DateOfBirth
        End If
        If DateOfDeath <> "  /  /" Then
            dtDoD.Text = DateOfDeath
        End If
        If Age <> "" Then
            txtAge.Text = Age
        End If
        If SSN <> "" Then
            txtSSN.Text = SSN
        End If
        If BB <> "" Then
            txtBBList.Text = BB
        End If
        If SubNum <> "" Then
            intSubNum.Text = SubNum
        End If
        If XENum <> "" Then
            txtXENum.Text = XENum
        End If
        If NACCID <> "" Then
            txtNACCID.Text = NACCID
        End If
        If CDR <> "" Then
            txtCDR.Text = CDR
        End If
        If PMI <> "" Then
            lblPMI.Text = PMI
        End If
        If NP1 <> "" Then
            txtNP1.Text = NP1
        End If
        txtCohorts.Text = generateCohortString(SubNum)
    End Sub
    Private Function generateCohortString(ByVal subnum As String) As String
        Dim result As String = ""
        Dim table As DataTable = Database.ReturnTable("Subject", "NBTRCohort, ADRCCohort, IsraelCohort, PPGCohort, SchizoCohort, TBICohort, ReligiousOrderCohort, NACCCohort, ClinicalTrialsCohort", "SubNum = " & subnum)

        If table.Rows(0).Item("NBTRCohort").ToString = "1" Then
            result += "NB,"
        End If
        If table.Rows(0).Item("ADRCCohort").ToString = "1" Then
            result += "AD,"
        End If
        If table.Rows(0).Item("IsraelCohort").ToString = "1" Then
            result += "IS,"
        End If
        If table.Rows(0).Item("PPGCohort").ToString = "1" Then
            result += "PP,"
        End If
        If table.Rows(0).Item("SchizoCohort").ToString = "1" Then
            result += "SC,"
        End If
        If table.Rows(0).Item("TBICohort").ToString = "1" Then
            result += "TB,"
        End If
        If table.Rows(0).Item("ReligiousOrderCohort").ToString = "1" Then
            result += "RE,"
        End If
        If table.Rows(0).Item("NACCCohort").ToString = "1" Then
            result += "NA,"
        End If
        If table.Rows(0).Item("ClinicalTrialsCohort").ToString = "1" Then
            result += "CL,"
        End If

        If Len(result) > 0 Then
            result = result.Substring(0, Len(result) - 1)
        End If

        table = Nothing

        Return result
    End Function
    'On load events
    Private Sub Head_SubjectSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enableInputFields(True)
        ShowPHI(WarehouseShell.ShowingPHI)
    End Sub

    'Filter records in WA_SubjectSelect based on values entered in header.
    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click

        Dim filter As String = ""

        'Append string search filters to filter variable (where the filter input boxes are not empty)
        filter &= IIf(txtFirstName.Text = "", "", "[First Name] like '%" & Replace(txtFirstName.Text, "'", "''") & "%' and ")
        filter &= IIf(txtLastName.Text = "", "", "[Last Name] like '%" & Replace(txtLastName.Text, "'", "''") & "%' and ")
        filter &= IIf(dtDoB.Text = "  /  /", "", "DoB = '" & dtDoB.Text & "' and ")
        filter &= IIf(dtDoD.Text = "  /  /", "", "DoD = '" & dtDoD.Text & "' and ")
        filter &= IIf(txtSSN.Text = "", "", "SSN like '%" & txtSSN.Text & "%' and ")
        filter &= IIf(txtBBList.Text = "", "", "BB in (" & txtBBList.Text & ") and ")
        filter &= IIf(intSubNum.Text = "", "", "SubNum = " & intSubNum.Text & " and ")
        filter &= IIf(txtXENum.Text = "", "", "[XE #] like '%" & txtXENum.Text & "%' and ")
        filter &= IIf(txtNACCID.Text = "", "", "NACCID like '%" & txtNACCID.Text & "%' and ")

        If filter <> "" Then
            If WarehouseShell.ShowingPHI Then
                'Trim the last " and " from the end of the filter string and apply filter.
                filter = filter.Substring(0, filter.Length - 5)
                If WarehouseShell.Group = "NBTR" Then 'TODO: Clean up teams implementation here
                    DirectCast(WarehouseShell.WorkingAreaForm, WA_SubjectSelect).bs.Filter = filter
                End If
            Else
                MsgBox("Please enable PHI before attempting to filter.", MsgBoxStyle.OkOnly, "Warning")
            End If
        Else
            DirectCast(WarehouseShell.WorkingAreaForm, WA_SubjectSelect).bs.Filter = "" 'Empty filter string returns all values in the WA_SubjectSelect DataGridView. Needed in case the user deletes all filter textbox values.
        End If
    End Sub

    'Allow user to treat enter key as button click
    Private Sub textbox_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFirstName.KeyDown, txtLastName.KeyDown, dtDoB.KeyDown, dtDoD.KeyDown, txtSSN.KeyDown, txtBBList.KeyDown, intSubNum.KeyDown, txtXENum.KeyDown, txtNACCID.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnFilter.PerformClick()
        End If
    End Sub

    'Adjust Do Not Contact/Dissect settings
    Public Sub DoNotContact(ByVal bool As Boolean)
        If bool Then
            BackColor = Color.Red
            lblDNC.Visible = True
            totalFlags += 1
        Else
            If totalFlags = 0 Then
                BackColor = Color.LightSkyBlue
            End If
            lblDNC.Visible = False
        End If
    End Sub
    Public Sub DoNotDissect(ByVal bool As Boolean)
        If bool Then
            BackColor = Color.Red
            lblDNDiss.Visible = True
            totalFlags += 1
        Else
            If totalFlags = 0 Then
                BackColor = Color.LightSkyBlue
            End If
            lblDNDiss.Visible = False
        End If
    End Sub

    Public Sub InfectiousState(ByVal bool As Boolean)
        If bool Then
            BackColor = Color.Red
            lblDNDist.Visible = True
            totalFlags += 1
        Else
            If totalFlags = 0 Then
                BackColor = Color.LightSkyBlue
            End If
            lblDNDist.Visible = False
        End If
    End Sub

    Public Sub SubjectState(ByVal bool As Boolean, Optional ByVal callingFunction As String = "")
        If bool = True Then
            BackColor = Color.Red
            If callingFunction = "DNCT" Then
                lblDNC.Visible = True
            End If
            If callingFunction = "DNDissT" Then
                lblDNDiss.Visible = True
            End If
            If callingFunction = "DNDistT" Then
                lblDNDist.Visible = True
            End If
        Else
            Select Case callingFunction
                Case "DNDistF"
                    lblDNDist.Visible = False
                Case "DNDissF"
                    lblDNDiss.Visible = False
                Case "DNCF"
                    lblDNC.Visible = False
            End Select
        End If
    End Sub

    Public Sub SetHeaderFlags(Optional ByVal DoNotContact As String = "", Optional ByVal DoNotDissect As String = "", Optional ByVal Infectious As String = "")
        If DoNotContact = "True" Or DoNotDissect = "True" Or Infectious = "True" Then
            backColor = Color.Red
        End If
    End Sub

    Public Sub clearInputs()
        txtFirstName.Clear()
        txtLastName.Clear()
        dtDoB.Clear()
        dtDoD.Clear()
        txtAge.Clear()
        txtSSN.Clear()
        txtBBList.Clear()
        intSubNum.Clear()
        txtXENum.Clear()
        txtNACCID.Clear()
    End Sub

    'Imported IFormMethods interface methods (some used, some not, based on which form is using the interface)
    Public Sub ShowPHI(val As Boolean) Implements IFormMethods.ShowPHI
        If val = True Then
            txtFirstName.PasswordChar = ""
            txtLastName.PasswordChar = ""
            dtDoB.PasswordChar = ""
            dtDoD.PasswordChar = ""
            txtSSN.PasswordChar = ""
        Else
            txtFirstName.PasswordChar = "*"
            txtLastName.PasswordChar = "*"
            dtDoB.PasswordChar = "*"
            dtDoD.PasswordChar = "*"
            txtSSN.PasswordChar = "*"
        End If
    End Sub
    Public Sub Parent1(ByRef val As Object) Implements IFormMethods.Parent
        Me.Parent = val
    End Sub
    Public Sub Show1() Implements IFormMethods.Show
        Me.Show()
    End Sub
    Public Sub TopLevel1(val As Boolean) Implements IFormMethods.TopLevel
        Me.TopLevel = val
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork

    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Me.Dispose()
    End Sub
End Class