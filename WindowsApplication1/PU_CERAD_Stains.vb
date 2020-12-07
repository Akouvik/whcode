Public Class PU_CERAD_Stains

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If preSaveValidation() Then
            Dim cmd As New SqlCommand
            cmd.Connection = WarehouseShell.conn
            Dim cmdString = "@SubNum = " & WarehouseShell.SubNum &
                    ", @HandE = " & chkHE.getSQLValue() &
                    ", @CongoRed = " & chkCongoRed.getSQLValue() &
                    ", @ThioflavinS = " & chkThioflavinS.getSQLValue() &
                    ", @AmyloidBeta = " & chkAmyloidBeta.getSQLValue() &
                    ", @Tau = " & chkTau.getSQLValue() &
                    ", @Synuclein = " & chkSynuclein.getSQLValue() &
                    ", @TDP43 = " & chkTDP43.getSQLValue() &
                    ", @Ubiquitin = " & chkUbiquitin.getSQLValue() &
                    ", @Silver = " & chkSilverStain.getSQLValue() &
                    ", @SilverNote = " & txtSilverStain.getSQLValue() &
                    ", @OtherStain1 = " & chkOtherStain1.getSQLValue() &
                    ", @OtherStain1Note = " & txtOtherStain1.getSQLValue() &
                    ", @OtherStain2 = " & chkOtherStain2.getSQLValue() &
                    ", @OtherStain2Note = " & txtOtherStain2.getSQLValue() &
                    ", @OtherStain3 = " & chkOtherStain3.getSQLValue() &
                    ", @OtherStain3Note = " & txtOtherStain3.getSQLValue() &
                    ", @OtherStain4 = " & chkOtherStain4.getSQLValue() &
                    ", @OtherStain4Note = " & txtOtherStain4.getSQLValue() &
                    ", @HippoPlaques = 0" &
                    ", @EntorPlaques = 0" &
                    ", @AmygPlaques = 0" &
                    ", @HippoPlaquesWCores = 0" &
                    ", @EntorPlaquesWCores = 0" &
                    ", @AmygPlaquesWCores = 0" &
                    ", @HippoTangles = 0" &
                    ", @EntorTangles = 0" &
                    ", @AmygTangles = 0" &
                    ", @HippoParench = 0" &
                    ", @EntorParench = 0" &
                    ", @AmygParench = 0" &
                    ", @HippoMenin = 0" &
                    ", @EntorMenin = 0" &
                    ", @AmygMenin = 0" &
                    ", @HippoHemo = 0" &
                    ", @EntorHemo = 0" &
                    ", @AmygHemo = 0" &
                    ", @HippoGranulo = 0" &
                    ", @EntorGranulo = 0" &
                    ", @AmygGranulo = 0" &
                    ", @HippoHirano = 0" &
                    ", @EntorHirano = 0" &
                    ", @AmygHirano = 0" &
                    ", @HippoNeuro = 0" &
                    ", @EntorNeuro = 0" &
                    ", @AmygNeuro = 0" &
                    ", @HippoGliosis = 0" &
                    ", @EntorGliosis = 0" &
                    ", @AmygGliosis = 0" &
                    ", @HippoPick = 0" &
                    ", @EntorPick = 0" &
                    ", @AmygPick = 0" &
                    ", @HippoLewy = 0" &
                    ", @EntorLewy = 0" &
                    ", @AmygLewy = 0" &
                    ", @HippoOther = 0" &
                    ", @EntorOther = 0" &
                    ", @AmygOther = 0" &
                    ", @Other10Note = 0" &
                    ", @HippoTissueTaken = 0" &
                    ", @EntorTissueTaken = 0" &
                    ";"
            cmd.CommandText = "EXEC dbo.modCERADG1Record @Action = 1, " & cmdString
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Stains added to CERAD-G1.", MsgBoxStyle.OkOnly, "Success")
            Catch ex As SqlException
                ExceptionHandler.CatchSQLException(ex)
            Finally
                Close()
            End Try
        End If
    End Sub

    Private Function preSaveValidation() As Boolean
        Dim result As Boolean = True
        Dim errorMessage As String = ""

        'Make sure at least 1 stain is selected
        Dim stainCount As Integer = 0
        For Each chk As CheckBox_ In Controls
            If chk.Checked Then
                stainCount += 1
            End If
        Next
        If stainCount = 0 Then
            result = False
            errorMessage += "- Please select at least one stain."
        End If

        'Check specify dependencies
        If chkSilverStain.Checked = False Then
            If txtSilverStain.Text <> "" Then
                result = False
                errorMessage += "- You have entered a Silver Stain note without checking the Silver Stain box. Please clear the note or check the Silver Stain box." & vbNewLine
            End If
        ElseIf chkSilverStain.Checked Then
            If txtSilverStain.Text = "" Then
                result = False
                errorMessage += "- You have checked the Silver Stain box without specifying a note. Please add a note or uncheck the Silver Stain box." & vbNewLine
            End If
        End If
        If chkOtherStain1.Checked = False Then
            If txtOtherStain1.Text <> "" Then
                result = False
                errorMessage += "- You have entered a Other Stain note without checking the Other Stain 1 box. Please clear the note or check the Other Stain 1 box." & vbNewLine
            End If
        ElseIf chkOtherStain1.Checked Then
            If txtOtherStain1.Text = "" Then
                result = False
                errorMessage += "- You have checked the Other Stain 1 box without specifying a note. Please add a note or uncheck the Other Stain 1 box." & vbNewLine
            End If
        End If
        If chkOtherStain2.Checked = False Then
            If txtOtherStain2.Text <> "" Then
                result = False
                errorMessage += "- You have entered a Other Stain note without checking the Other Stain 2 box. Please clear the note or check the Other Stain 2 box." & vbNewLine
            End If
        ElseIf chkOtherStain2.Checked Then
            If txtOtherStain2.Text = "" Then
                result = False
                errorMessage += "- You have checked the Other Stain 2 box without specifying a note. Please add a note or uncheck the Other Stain 2 box." & vbNewLine
            End If
        End If
        If chkOtherStain3.Checked = False Then
            If txtOtherStain3.Text <> "" Then
                result = False
                errorMessage += "- You have entered a Other Stain note without checking the Other Stain 3 box. Please clear the note or check the Other Stain 3 box." & vbNewLine
            End If
        ElseIf chkOtherStain3.Checked Then
            If txtOtherStain3.Text = "" Then
                result = False
                errorMessage += "- You have checked the Other Stain 3 box without specifying a note. Please add a note or uncheck the Other Stain 3 box." & vbNewLine
            End If
        End If
        If chkOtherStain4.Checked = False Then
            If txtOtherStain4.Text <> "" Then
                result = False
                errorMessage += "- You have entered a Other Stain note without checking the Other Stain 4 box. Please clear the note or check the Other Stain 4 box." & vbNewLine
            End If
        ElseIf chkOtherStain4.Checked Then
            If txtOtherStain4.Text = "" Then
                result = False
                errorMessage += "- You have checked the Other Stain 4 box without specifying a note. Please add a note or uncheck the Other Stain 4 box." & vbNewLine
            End If
        End If

        'Handle false result
        If result = False Then
            errorMessage = "The following errors must be corrected before this record can be saved:" & vbNewLine & vbNewLine & errorMessage
            MsgBox(errorMessage, MsgBoxStyle.OkOnly, "Error")
        End If
        Return result
    End Function
End Class