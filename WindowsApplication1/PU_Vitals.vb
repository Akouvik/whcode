Public Class PU_Vitals
    Private mode As String
    Private myRecordID As String
    Private formTables As New DataSet
    Public Changed As Boolean = False

    Public Sub New(ByVal RecordID As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        myRecordID = RecordID

    End Sub

    Private Sub PU_Vitals_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If myRecordID = "0" Then
            mode = "Insert"
        Else
            mode = "Update"
            loadExistingData(myRecordID)
        End If

    End Sub

    Private Sub loadExistingData(ByVal RecordID As String)
        formTables.Tables.Add(Database.ReturnTable("Vitals",, "RecordID = " & RecordID))
        dtVitalsDate.setValue(formTables, "Vitals", "VitalsDate")
        numHeight.setValue(formTables, "Vitals", "Height")
        numWeight.setValue(formTables, "Vitals", "Weight")
        numWaist.setValue(formTables, "Vitals", "Waist")
        numBMI.setValue(formTables, "Vitals", "BMI")
        intRespirations.setValue(formTables, "Vitals", "Respiration")
        intPulse.setValue(formTables, "Vitals", "Pulse")
        intSystolic.setValue(formTables, "Vitals", "SystolicBP")
        intDiastolic.setValue(formTables, "Vitals", "DiastolicBP")
        numMeanBP.setValue(formTables, "Vitals", "MeanBP")
        numTempF.setValue(formTables, "Vitals", "TempF")
        numTempC.setValue(formTables, "Vitals", "TempC")
        numPh.setValue(formTables, "Vitals", "PhLevel")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sqlCMD As New SqlCommand
        sqlCMD.Connection = WarehouseShell.conn
        Dim cmdString = "@RecordID = " & myRecordID &
            ", @SubNum = " & WarehouseShell.SubNum &
            ", @Height = " & numHeight.getSQLValue() &
            ", @Weight = " & numWeight.getSQLValue() &
            ", @BMI = " & numBMI.getSQLValue() &
            ", @Waist = " & numWaist.getSQLValue() &
            ", @Respiration = " & intRespirations.getSQLValue() &
            ", @Pulse = " & intPulse.getSQLValue() &
            ", @SystolicBP = " & intSystolic.getSQLValue() &
            ", @DiastolicBP = " & intDiastolic.getSQLValue() &
            ", @MeanBP = " & numMeanBP.getSQLValue() &
            ", @TempF = " & numTempF.getSQLValue() &
            ", @TempC = " & numTempC.getSQLValue() &
            ", @PhLevel = " & numPh.getSQLValue() &
            ", @VitalsDate = " & dtVitalsDate.getSQLValue() & ";"
        If mode = "Insert" Then
            sqlCMD.CommandText = "EXEC dbo.modVitalsRecord @Action = 1, " & cmdString
            Try
                sqlCMD.ExecuteNonQuery()
                MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Changed = True
                Me.Hide()
            Catch ex As Exception
                ExceptionHandler.CatchSQLException(ex)
            End Try
        Else
            sqlCMD.CommandText = "EXEC dbo.modVitalsRecord @Action = 2, " & cmdString
            Try
                sqlCMD.ExecuteNonQuery()
                MessageBox.Show("Record successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Changed = True
                Me.Hide()
            Catch ex As Exception
                ExceptionHandler.CatchSQLException(ex)
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    Private Sub numTempF_Leave(sender As Object, e As EventArgs) Handles numTempF.Leave
        If numTempF.Text <> "" Then
            numTempC.Text = Math.Round((CType(numTempF.Text, Decimal) - 32) * (5 / 9), 1)
        End If
    End Sub
    Private Sub numTempC_Leave(sender As Object, e As EventArgs) Handles numTempC.Leave
        If numTempC.Text <> "" Then
            numTempF.Text = Math.Round(CType(numTempC.Text, Decimal) * 9 / 5 + 32, 1)
        End If
    End Sub
    Private Sub intSystolic_Leave(sender As Object, e As EventArgs) Handles intSystolic.Leave, intDiastolic.Leave
        If intSystolic.Text <> "" And intDiastolic.Text <> "" Then
            numMeanBP.Text = (CType(intSystolic.Text, Int32) + CType(intDiastolic.Text, Int32)) / 2
        End If
    End Sub
    Private Sub numHeight_Leave(sender As Object, e As EventArgs) Handles numHeight.Leave, numWeight.Leave
        If numHeight.Text <> "" And numWeight.Text <> "" Then
            numBMI.Text = Math.Round((CType(numWeight.Text, Decimal) / (CType(numHeight.Text, Decimal) * CType(numHeight.Text, Decimal))) * 703, 1)
        End If
    End Sub
End Class