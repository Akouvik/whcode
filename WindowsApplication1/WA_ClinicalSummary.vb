Public Class WA_ClinicalSummary
    Implements IFormMethods

    Private Sub WA_ClincalSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_ClinicalSummary")
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        loadFileData()
    End Sub

    Private Sub loadFileData()
        If SubjectFiles1to1.CheckFile("fileClinicalSummary", WarehouseShell.SubNum) Then
            btnAdd.Text = "View Clinical Summary"
            btnAdd.BackColor = Color.Chartreuse
            btnRemove.Visible = True
        Else
            btnAdd.Text = "Upload Clinical Summary"
            btnAdd.BackColor = Color.Linen
            btnRemove.Visible = False
        End If
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If User.PermissionCheck("WA_ClinicalSummary", "Modify") Then
            If SubjectFiles1to1.CheckFile("fileClinicalSummary", WarehouseShell.SubNum) Then
                If WarehouseShell.ShowingPHI Then
                    SubjectFiles1to1.OpenFile("fileClinicalSummary", WarehouseShell.SubNum, "SubNum " & WarehouseShell.SubNum & " Clinical Summary")
                Else
                    MsgBox("Please enable PHI before attempting to open this file.", MsgBoxStyle.OkOnly)
                End If
            Else
                SubjectFiles1to1.SaveFile("fileClinicalSummary", WarehouseShell.SubNum)
            End If
            loadFileData()
        End If
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If User.PermissionCheck("WA_ClinicalSummary", "Modify") Then
            SubjectFiles1to1.DeleteFile("fileClinicalSummary", WarehouseShell.SubNum)
            loadFileData()
        End If
    End Sub

    Public Sub TopLevel(val As Boolean) Implements IFormMethods.TopLevel
    End Sub
    Public Sub ShowPHI(val As Boolean) Implements IFormMethods.ShowPHI
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
    Private Sub IFormMethods_Parent(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Private Sub IFormMethods_Show() Implements IFormMethods.Show
        Show()
    End Sub
End Class