Public Class PU_Covid_Acceptance
    Private Sub PU_Covid_Acceptance_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearChecked(1)

    End Sub

    Private Sub CQ1Y_CheckStateChanged(sender As Object, e As EventArgs) Handles CQ1Y.CheckedChanged
        If CQ1Y.CheckState = 1 Then
            CQ1N.Checked = False
            ClearChecked(1)
            CQ2Y.Enabled = True
            CQ2N.Enabled = True
        End If
    End Sub
    Private Sub CQ1N_CheckStateChanged(sender As Object, e As EventArgs) Handles CQ1N.CheckedChanged
        If CQ1N.Checked Then
            CQ1Y.Checked = False
            ClearChecked(1)
        End If
    End Sub

    Private Sub CQ2Y_CheckStateChanged(sender As Object, e As EventArgs) Handles CQ2Y.CheckedChanged
        If CQ2Y.Checked Then
            CQ2N.Checked = False
            ClearChecked(2)
        End If
        If CQ2Y.CheckState = 0 And CQ2N.CheckState = 0 Then
            ClearChecked(2, 0)
        End If
    End Sub
    Private Sub CQ2N_CheckStateChanged(sender As Object, e As EventArgs) Handles CQ2N.CheckedChanged
        If CQ2N.Checked Then
            CQ2Y.Checked = False
            ClearChecked(2)

            CQ3Y.Enabled = True
            CQ3N.Enabled = True
        End If
    End Sub
    Private Sub CQ3Y_CheckStateChanged(sender As Object, e As EventArgs) Handles CQ3Y.CheckedChanged
        If CQ3Y.Checked Then
            CQ3N.Checked = False
            ClearChecked(3)
        End If
        If CQ3Y.CheckState = 0 And CQ3N.CheckState = 0 Then
            ClearChecked(3, 0)
        End If
    End Sub
    Private Sub CQ3N_CheckStateChanged(sender As Object, e As EventArgs) Handles CQ3N.CheckedChanged
        If CQ3N.Checked Then
            CQ3Y.Checked = False
            ClearChecked(3)
            CQ4Y.Enabled = True
            CQ4N.Enabled = True
        End If
    End Sub
    Private Sub CQ4Y_CheckStateChanged(sender As Object, e As EventArgs) Handles CQ4Y.CheckedChanged
        If CQ4Y.Checked Then
            CQ4N.Checked = False
            ClearChecked(4)
        End If
        If CQ4Y.CheckState = 0 And CQ4N.CheckState = 0 Then
            ClearChecked(4, 0)
        End If
    End Sub
    Private Sub CQ4N_CheckStateChanged(sender As Object, e As EventArgs) Handles CQ4N.CheckedChanged
        If CQ4N.Checked Then
            CQ4Y.Checked = False
            ClearChecked(4)
            CQ5Y.Enabled = True
            CQ5N.Enabled = True
        End If
    End Sub
    Private Sub CQ5Y_CheckStateChanged(sender As Object, e As EventArgs) Handles CQ5Y.CheckedChanged
        If CQ5Y.Checked Then
            CQ5N.Checked = False
            ClearChecked(5)
        End If
        If CQ5Y.CheckState = 0 And CQ4N.CheckState = 0 Then
            ClearChecked(5, 0)
        End If
    End Sub
    Private Sub CQ5N_CheckStateChanged(sender As Object, e As EventArgs) Handles CQ5N.CheckedChanged
        If CQ5N.Checked Then
            CQ5Y.Checked = False
            ClearChecked(5)
            CQ6Y.Enabled = True
            CQ6N.Enabled = True
        End If
    End Sub
    Private Sub CQ6Y_CheckStateChanged(sender As Object, e As EventArgs) Handles CQ6Y.CheckedChanged
        If CQ6Y.Checked Then
            CQ6N.Checked = False
            ClearChecked(6)
        End If
        If CQ6Y.CheckState = 0 And CQ6N.CheckState = 0 Then
            ClearChecked(6, 0)
        End If
    End Sub
    Private Sub CQ6N_CheckStateChanged(sender As Object, e As EventArgs) Handles CQ6N.CheckedChanged
        If CQ6N.Checked Then
            CQ6Y.Checked = False
            ClearChecked(6)
            CQ7Y.Enabled = True
            CQ7N.Enabled = True
        End If
    End Sub
    Private Sub CQ7Y_CheckStateChanged(sender As Object, e As EventArgs) Handles CQ7Y.CheckedChanged
        If CQ7Y.Checked Then
            CQ7N.Checked = False
            ClearChecked(7)
        End If
        If CQ7Y.CheckState = 0 And CQ7N.CheckState = 0 Then
            ClearChecked(7, 0)
        End If
    End Sub
    Private Sub CQ7N_CheckStateChanged(sender As Object, e As EventArgs) Handles CQ7N.CheckedChanged
        If CQ7N.Checked Then
            CQ7Y.Checked = False
            ClearChecked(7)
        End If

        If CQ7Y.CheckState = 0 And CQ7N.Checked = False Then
            CQ8_ListBox.Enabled = False
        Else
            CQ8_ListBox.Enabled = True
        End If
    End Sub
    Private Sub CQ1_7_CheckBoxScoring(sender As Object, e As EventArgs) Handles CQ1N.CheckedChanged, CQ1Y.CheckedChanged, CQ2N.CheckedChanged, CQ2Y.CheckedChanged, CQ3N.CheckedChanged, CQ3Y.CheckedChanged, CQ4N.CheckedChanged, CQ4Y.CheckedChanged, CQ5N.CheckedChanged, CQ5Y.CheckedChanged, CQ6N.CheckedChanged, CQ6Y.CheckedChanged, CQ7N.CheckedChanged, CQ7Y.CheckedChanged
        Dim result As Boolean = True
        If CQ1N.Checked Or CQ2Y.Checked Or CQ3Y.Checked Or CQ4Y.Checked Or CQ5Y.Checked Or CQ6Y.Checked Or CQ7Y.Checked Then
            formResult.Text = "Decline- Presumed Positive"
        Else
            formResult.Text = "Accept- Presumed Negative"
        End If
    End Sub

    Private Sub CQ8_ListBox_Scoring(sender As Object, e As EventArgs) Handles CQ8_ListBox.SelectedIndexChanged, CQ8_ListBox.EnabledChanged
        If CQ8_ListBox.Enabled = False Then
            For i = 0 To (CQ8_ListBox.Items.Count - 1)
                CQ8_ListBox.SetItemChecked(i, False)
            Next
        End If

        If CQ8_ListBox.Enabled Then
            Dim allCheckedItems As Integer = 0
            allCheckedItems = CQ8_ListBox.CheckedItems.Count

            If allCheckedItems >= 3 Then
                formResult.Text = "Decline- Presumed Positive"
            End If

            If CQ8_ListBox.CheckedItems.Count < 3 Then
                formResult.Text = "Accept- Presumed Negative"
            End If
        End If
    End Sub

    Private Sub ClearChecked(ByVal index As Integer, Optional ByVal stateOfCheckBox As Integer = 1)
        Dim i As Integer = index + 1

        While i < 9
            For Each chk As Control In Controls()
                Dim controlType As String = chk.GetType().ToString()
                If controlType = "System.Windows.Forms.CheckBox" Then

                    If chk.Name = "CQ" & i & "Y" Or chk.Name = "CQ" & i & "N" Then
                        CType(chk, CheckBox).Checked = False
                        chk.Enabled = False
                    End If
                    CQ8_ListBox.Enabled = False
                End If
            Next
            i += 1
        End While
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Hide()
    End Sub
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        formResult.Text = "Cancel"
        Hide()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub
End Class