Public Class PU_Alz_Acceptance
    Private formTables As New DataSet
    Public formResult As String

    Public Sub New(ByVal ADAcceptVal As String)
        InitializeComponent()
        formResult = ADAcceptVal
    End Sub

    Private Sub PU_Alz_Acceptance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formTables.Tables.Add(Database.ReturnTable("lkpAlzAcceptCrit"))
        Result.assignLookup(formTables, "lkpAlzAcceptCrit")
        SetChecked()
    End Sub

    Private Sub NA_CheckedChanged(sender As Object, e As EventArgs) Handles NA.CheckedChanged
        If NA.Checked Then
            ClearChecked(0)
            Result.SelectedValue = "NA"
        Else
            ClearChecked(0)
            Q1Y.Enabled = True
            Q1N.Enabled = True
        End If
    End Sub
    Private Sub Q1Y_CheckedChanged(sender As Object, e As EventArgs) Handles Q1Y.CheckedChanged
        If Q1Y.Checked Then
            Q1N.Checked = False
            ClearChecked(1)
            Result.SelectedValue = "Q1Y"
        End If
    End Sub
    Private Sub Q1N_CheckedChanged(sender As Object, e As EventArgs) Handles Q1N.CheckedChanged
        If Q1N.Checked Then
            Q1Y.Checked = False
            ClearChecked(1)
            Q2Y.Enabled = True
            Q2N.Enabled = True
        End If
    End Sub
    Private Sub Q2Y_CheckedChanged(sender As Object, e As EventArgs) Handles Q2Y.CheckedChanged
        If Q2Y.Checked Then
            Q2N.Checked = False
            ClearChecked(2)
            Result.SelectedValue = "Q2Y"
        End If
    End Sub
    Private Sub Q2N_CheckedChanged(sender As Object, e As EventArgs) Handles Q2N.CheckedChanged
        If Q2N.Checked Then
            Q2Y.Checked = False
            ClearChecked(2)
            Q3Y.Enabled = True
            Q3N.Enabled = True
        End If
    End Sub
    Private Sub Q3Y_CheckedChanged(sender As Object, e As EventArgs) Handles Q3Y.CheckedChanged
        If Q3Y.Checked Then
            Q3N.Checked = False
            ClearChecked(3)
            Result.SelectedValue = "Q3Y"
        End If
    End Sub
    Private Sub Q3N_CheckedChanged(sender As Object, e As EventArgs) Handles Q3N.CheckedChanged
        If Q3N.Checked Then
            Q3Y.Checked = False
            ClearChecked(3)
            Q4Y.Enabled = True
            Q4N.Enabled = True
        End If
    End Sub
    Private Sub Q4Y_CheckedChanged(sender As Object, e As EventArgs) Handles Q4Y.CheckedChanged
        If Q4Y.Checked Then
            Q4N.Checked = False
            ClearChecked(4)
            Q5Y.Enabled = True
            Q5N.Enabled = True
        End If
    End Sub
    Private Sub Q4N_CheckedChanged(sender As Object, e As EventArgs) Handles Q4N.CheckedChanged
        If Q4N.Checked Then
            Q4Y.Checked = False
            ClearChecked(4)
            Result.SelectedValue = "Q4N"
        End If
    End Sub
    Private Sub Q5Y_CheckedChanged(sender As Object, e As EventArgs) Handles Q5Y.CheckedChanged
        If Q5Y.Checked Then
            Q5N.Checked = False
            ClearChecked(5)
            Result.SelectedValue = "Q5Y"
        End If
    End Sub
    Private Sub Q5N_CheckedChanged(sender As Object, e As EventArgs) Handles Q5N.CheckedChanged
        If Q5N.Checked Then
            Q5Y.Checked = False
            ClearChecked(5)
            Q6Y.Enabled = True
            Q6N.Enabled = True
        End If
    End Sub
    Private Sub Q6Y_CheckedChanged(sender As Object, e As EventArgs) Handles Q6Y.CheckedChanged
        If Q6Y.Checked Then
            Q6N.Checked = False
            Result.SelectedValue = "Q6Y"
        End If
    End Sub
    Private Sub Q6N_CheckedChanged(sender As Object, e As EventArgs) Handles Q6N.CheckedChanged
        If Q6N.Checked Then
            Q6Y.Checked = False
            Result.SelectedValue = "Q6N"
        End If
    End Sub

    Private Sub ClearChecked(ByVal index As Integer)
        Dim i As Integer = index + 1
        While i < 7
            For Each chk As Control In Controls()
                If chk.Name = "Q" & i & "Y" Or chk.Name = "Q" & i & "N" Then
                    CType(chk, CheckBox_).Checked = False
                    chk.Enabled = False
                End If
            Next
            i += 1
        End While
        Result.SelectedValue = "-1"
    End Sub
    Private Sub SetChecked()
        If formResult = "-1" Then
            NA.Checked = False
            Q1Y.Checked = False
            Q1N.Checked = False
            NA.Enabled = True
            Q1Y.Enabled = True
            Q1N.Enabled = True
            ClearChecked(1)
        ElseIf formResult = "NA" Then
            NA.Checked = True
            ClearChecked(0)
        ElseIf formResult = "Q1Y" Then
            Q1Y.Checked = True
            Q1N.Checked = False
            Q1Y.Enabled = True
            Q1N.Enabled = True
            ClearChecked(1)
        ElseIf formResult = "Q2Y" Then
            Q1Y.Checked = False
            Q1N.Checked = True
            Q2Y.Checked = True
            Q2N.Checked = False
            Q1Y.Enabled = True
            Q1N.Enabled = True
            Q2Y.Enabled = True
            Q2N.Enabled = True
            ClearChecked(2)
        ElseIf formResult = "Q3Y" Then
            Q1Y.Checked = False
            Q1N.Checked = True
            Q2Y.Checked = False
            Q2N.Checked = True
            Q3Y.Checked = True
            Q3N.Checked = False
            Q1Y.Enabled = True
            Q1N.Enabled = True
            Q2Y.Enabled = True
            Q2N.Enabled = True
            Q3Y.Enabled = True
            Q3N.Enabled = True
            ClearChecked(3)
        ElseIf formResult = "Q4N" Then
            Q1Y.Checked = False
            Q1N.Checked = True
            Q2Y.Checked = False
            Q2N.Checked = True
            Q3Y.Checked = False
            Q3N.Checked = True
            Q4Y.Checked = False
            Q4N.Checked = True
            Q1Y.Enabled = True
            Q1N.Enabled = True
            Q2Y.Enabled = True
            Q2N.Enabled = True
            Q3Y.Enabled = True
            Q3N.Enabled = True
            Q4Y.Enabled = True
            Q4N.Enabled = True
            ClearChecked(4)
        ElseIf formResult = "Q5Y" Then
            Q1Y.Checked = False
            Q1N.Checked = True
            Q2Y.Checked = False
            Q2N.Checked = True
            Q3Y.Checked = False
            Q3N.Checked = True
            Q4Y.Checked = True
            Q4N.Checked = False
            Q5Y.Checked = True
            Q5N.Checked = False
            Q1Y.Enabled = True
            Q1N.Enabled = True
            Q2Y.Enabled = True
            Q2N.Enabled = True
            Q3Y.Enabled = True
            Q3N.Enabled = True
            Q4Y.Enabled = True
            Q4N.Enabled = True
            Q5Y.Enabled = True
            Q5N.Enabled = True
            ClearChecked(5)
        ElseIf formResult = "Q6Y" Or formResult = "Q6N" Then
            Q1Y.Checked = False
            Q1N.Checked = True
            Q2Y.Checked = False
            Q2N.Checked = True
            Q3Y.Checked = False
            Q3N.Checked = True
            Q4Y.Checked = True
            Q4N.Checked = False
            Q5Y.Checked = False
            Q5N.Checked = True
            If formResult = "Q6Y" Then
                Q6Y.Checked = True
                Q6N.Checked = False
            Else
                Q6Y.Checked = False
                Q6N.Checked = True
            End If
            Q1Y.Enabled = True
            Q1N.Enabled = True
            Q2Y.Enabled = True
            Q2N.Enabled = True
            Q3Y.Enabled = True
            Q3N.Enabled = True
            Q4Y.Enabled = True
            Q4N.Enabled = True
            Q5Y.Enabled = True
            Q5N.Enabled = True
            Q6Y.Enabled = True
            Q6N.Enabled = True
        End If
        Result.SelectedValue = formResult
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        formResult = Result.SelectedValue
        Hide()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        formResult = "Cancel"
        Hide()
    End Sub
End Class