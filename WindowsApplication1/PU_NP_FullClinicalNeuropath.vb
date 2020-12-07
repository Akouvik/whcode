Public Class PU_NP_FullClinicalNeuropath
    Public myString As String = ""
    Private myReceiver As String = ""
    Private myConsentor As String = ""
    Private mySubject As String = ""

    Public Sub New(ByVal receiver As String, ByVal consentor As String, ByVal subject As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        myReceiver = receiver
        myConsentor = consentor
        mySubject = subject
    End Sub

    Private Sub PU_NP_FullClinicalNeuropath_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdoIntro1.Checked = True
        If Database.ExistingRecordCheck("Subject", "SubNum = " & WarehouseShell.SubNum & " and ADRCCohort = 1") Then
            rdoContactInfoADRC.Checked = True
        Else
            rdoContactInfoNBTR.Checked = True
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If preSaveValidation() Then
            If rdoIntro1.Checked Then
                myString += "At the request of " & myConsentor & ", we would like to share the findings of our neuropathology examination of " & mySubject & "."
            End If
            If rdoIntro2.Checked Then
                myString += "As per your request, we would like to share the findings of our neuropathology examination of " & mySubject & "."
            End If
            If rdoCustomIntro.Checked Then
                myString += txtCustomIntro.Text
            End If
            If txtOther.Text <> "" Then
                myString += vbNewLine & vbNewLine & txtOther.Text
            End If
            If rdoContactInfoNBTR.Checked Then
                myString += vbNewLine & vbNewLine & rdoContactInfoNBTR.Text
            End If
            If rdoContactInfoADRC.Checked Then
                myString += vbNewLine & vbNewLine & rdoContactInfoADRC.Text
            End If
            myString += vbNewLine & vbNewLine & lblSignatureBlock.Text
        End If

        DialogResult = DialogResult.OK
    End Sub

    Private Sub btnSkip_Click(sender As Object, e As EventArgs) Handles btnSkip.Click
        DialogResult = DialogResult.Ignore
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub txtCustomIntro_Enter(sender As Object, e As EventArgs) Handles txtCustomIntro.Enter
        If txtCustomIntro.Text = "[CUSTOM INTRO TEXT]" Then
            txtCustomIntro.Clear()
        End If
    End Sub
    Private Sub txtCustomIntro_LostFocus(sender As Object, e As EventArgs) Handles txtCustomIntro.Leave
        If txtCustomIntro.Text = "" Then
            txtCustomIntro.Text = "[CUSTOM INTRO TEXT]"
        End If
    End Sub

    Private Function preSaveValidation() As Boolean
        Dim result As Boolean = True
        Dim errMsg As String = "The following errors must be corrected before this can be submitted:" & vbNewLine & vbNewLine

        If rdoCustomIntro.Checked And txtCustomIntro.Text = "[CUSTOM INTRO TEXT]" Then
            errMsg += "- Please enter custom intro text or select default intro radio button" & vbNewLine
            result = False
        End If

        If result = False Then
            MsgBox(errMsg, MsgBoxStyle.OkOnly, "Error")
        End If

        Return result
    End Function

    Private Sub rdoCustomIntro_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCustomIntro.CheckedChanged
        If rdoCustomIntro.Checked Then
            ActiveControl = txtCustomIntro
        Else
            txtCustomIntro.Text = "[CUSTOM INTRO TEXT]"
        End If
    End Sub
End Class