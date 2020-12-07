Public Class Loading

    Private selectedTab As String
    Private WithEvents myTimer As Timer

    Sub New(Optional ByVal mySelectedTab As String = "")
        ' This call is required by the designer.
        InitializeComponent()
        selectedTab = mySelectedTab
        myTimer = New Timer
        myTimer.Interval = 10
        myTimer.Start()
    End Sub

    Public Sub mySub()
        WarehouseShell.pnlWorkingArea.Show()
        WarehouseShell.WorkingAreaForm.TopLevel(False)
        WarehouseShell.WorkingAreaForm.Parent(WarehouseShell.pnlWorkingArea)
        WarehouseShell.WorkingAreaForm.Show()
        'If selectedTab <> "" Then
        '    DirectCast(WarehouseShell.WorkingAreaForm, WA_PMCR).loadOpenInSelectedTab(selectedTab)
        'End If
        Me.Hide()
    End Sub

    Private Sub myTimer_Tick(sender As Object, e As EventArgs) Handles myTimer.Tick
        myTimer.Stop()
        mySub()
    End Sub

    Private Sub Button_2_Click(sender As Object, e As EventArgs) Handles Button_2.Click

    End Sub
End Class