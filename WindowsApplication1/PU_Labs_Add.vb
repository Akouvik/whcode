Public Class PU_Labs_Add
    Private RecordID As Integer
    Private formTables As New DataSet
    Private mode As String = "view" 'needed to prevent cmbLabName_SelectedValueChanged from firing before form is fully loaded
    Public Sub New(Optional ByVal myRecordID As Integer = 0)
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        RecordID = myRecordID
    End Sub

    Private Sub PU_Labs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formTables.Tables.Add(Database.ReturnTable("refLabs"))
        formTables.Tables.Add(Database.ReturnTable("lkpLabSources"))
        cmbLabName.assignLookup(formTables, "refLabs", "LabID", "LabName", , "LabName")
        cmbLabSource.assignLookup(formTables, "lkpLabSources")
        If RecordID <> 0 Then
            mode = "edit"
            formTables.Tables.Add(Database.ReturnTable("Labs",, "RecordID = " & RecordID))
            cmbLabName.setValue(formTables, "Labs", "Lab")
            cmbLabSource.setValue(formTables, "Labs", "Source")
            txtUoM.setValue(formTables, "Labs", "UoM")
            numRngFrom.setValue(formTables, "Labs", "RangeLow")
            numRngTo.setValue(formTables, "Labs", "RangeHigh")
            numResultQuant.setValue(formTables, "Labs", "QuantitativeResult")
            txtResultQual.setValue(formTables, "Labs", "QualitativeResult")
            dtLabDate.setValue(formTables, "Labs", "LabDate")
            Text = "Edit Existing Lab"
            btnSaveAdd.Text = "Remove Lab"
            btnSaveClose.Text = "Save Changes"
        Else
            mode = "insert"
            Text = "Add New Lab"
            cmbLabSource.SelectedValue = 4
            cmbLabName.SelectedValue = 1
        End If
    End Sub

    Private Sub btnSaveAdd_Click(sender As Object, e As EventArgs) Handles btnSaveAdd.Click
        If mode = "insert" Then
            If preSaveValidation() Then
                Dim cmd As New SqlCommand("", WarehouseShell.conn)
                Dim cmdtext As String = "Exec modLabsRecord @Action = 1" &
                    ", @RecordID = " & RecordID &
                    ", @SubNum = " & WarehouseShell.SubNum &
                    ", @Lab = " & cmbLabName.getSQLValue() &
                    ", @UoM = " & txtUoM.getSQLValue() &
                    ", @RangeLow = " & numRngFrom.getSQLValue() &
                    ", @RangeHigh = " & numRngTo.getSQLValue() &
                    ", @QuantitativeResult = " & numResultQuant.getSQLValue() &
                    ", @QualitativeResult = " & txtResultQual.getSQLValue() &
                    ", @Source = " & cmbLabSource.getSQLValue() &
                    ", @LabDate = " & dtLabDate.getSQLValue() & ";"
                cmd.CommandText = cmdtext

                Try
                    cmd.ExecuteNonQuery()
                    setDoNotDistribute()
                Catch ex As Exception
                    ExceptionHandler.CatchSQLException(ex)
                End Try
            End If
        ElseIf mode = "edit" Then
            Dim cmd As New SqlCommand("Delete from Labs where RecordID = " & RecordID & ";", WarehouseShell.conn)
            Try
                cmd.ExecuteNonQuery()
                Close()
            Catch ex As SqlException
                ExceptionHandler.CatchSQLException(ex)
            End Try
        End If

        If cmbLabName.getSQLValue().ToString() = "'50'" Or cmbLabName.getSQLValue().ToString() = "'49'" AndAlso numResultQuant.Text <> "" Then
            Calc2(cmbLabName.getSQLValue().ToString())
            resetForm()
        End If

        'If cmbLabName.getSQLValue().ToString() = "'50'" Or cmbLabName.getSQLValue().ToString() = "'49'" Then
        '    CalcBMI()
        'End If
    End Sub

    Private Sub btnSaveClose_Click(sender As Object, e As EventArgs) Handles btnSaveClose.Click
        If preSaveValidation() Then
            Dim cmd As New SqlCommand("", WarehouseShell.conn)
            Dim cmdtext As String = "@RecordID = " & RecordID &
                ", @SubNum = " & WarehouseShell.SubNum &
                ", @Lab = " & cmbLabName.getSQLValue() &
                ", @UoM = " & txtUoM.getSQLValue() &
                ", @RangeLow = " & numRngFrom.getSQLValue() &
                ", @RangeHigh = " & numRngTo.getSQLValue() &
                ", @QuantitativeResult = " & numResultQuant.getSQLValue() &
                ", @QualitativeResult = " & txtResultQual.getSQLValue() &
                ", @Source = " & cmbLabSource.getSQLValue() &
                ", @LabDate = " & dtLabDate.getSQLValue() & ";"
            If mode = "insert" Then
                cmd.CommandText = "Exec modLabsRecord @Action = 1, " & cmdtext
            Else
                cmd.CommandText = "Exec modLabsRecord @Action = 2, " & cmdtext
            End If
            Try
                cmd.ExecuteNonQuery()
                setDoNotDistribute()
            Catch ex As Exception
                ExceptionHandler.CatchSQLException(ex)
            End Try
        End If

        'If cmbLabName.getSQLValue().ToString() = "'50'" Or cmbLabName.getSQLValue().ToString() = "'49'" Then
        '    CalcBMI()
        '    Close()
        'End If
        If cmbLabName.getSQLValue().ToString() = "'50'" Or cmbLabName.getSQLValue().ToString() = "'49'" AndAlso numResultQuant.Text <> "" Then
            Calc2(cmbLabName.getSQLValue().ToString())
            Close()
        End If
    End Sub
    Private Sub CalcBMI()
        'if a weight and labdate is entered
        If cmbLabName.getSQLValue().ToString() = "'50'" AndAlso Not (dtLabDate.getSQLValue() Is Nothing) Then
            'run a query to check for a height with the same date
            Dim cmd As New SqlCommand("select count(*) from labs where lab = 49 and Labdate = " & dtLabDate.getSQLValue() & "and Subnum = " & WarehouseShell.SubNum & ";", WarehouseShell.conn)
            Dim value As Integer = cmd.ExecuteScalar()
            'if a heigh tis returned
            If value > 0 Then
                'get the height
                Dim height As String = Database.ReturnString("Labs", "QuantitativeResult", "SubNum = " & WarehouseShell.SubNum & " and Lab = 49 and LabDate = " & dtLabDate.getSQLValue)
                Dim BMI As Decimal = (numResultQuant.Text / 2.205) / ((height / 39.37) ^ 2)
                'use the weight and heigt to calculate the BMI
                If BMI > 50 Then
                    MsgBox("This subject has a BMI greater than 50", MsgBoxStyle.OkOnly, "Warning")
                End If
                AlterLabsBMI(BMI, dtLabDate.getSQLValue())
                'Dim alterLabsCmd As New SqlCommand()
                'Dim checkBMI As New SqlCommand("select count(*) from labs where lab = 51 And LabDate = " & dtLabDate.getSQLValue() & " and Subnum = " & WarehouseShell.SubNum & " and QuantitativeResult is not null" & ";", WarehouseShell.conn)
                'Dim checkExistingBMI = checkBMI.ExecuteScalar()

                'If checkExistingBMI > 0 Then
                '    alterLabsCmd.CommandText = "update Labs set QuantitativeResult = " & FormatNumber(CDbl(BMI), 3) & " where SubNum = " & WarehouseShell.SubNum & " And labdate = " & dtLabDate.getSQLValue & " And Lab = 51 ;"
                'Else
                '    alterLabsCmd.CommandText = "Insert into Labs(SubNum, Lab, UoM, QuantitativeResult, Source, LabDate) values (" & WarehouseShell.SubNum & ", 51, '%', " & FormatNumber(CDbl(BMI), 3) & ", " & cmbLabSource.SelectedValue & ", " & dtLabDate.getSQLValue() & ");"
                'End If
                'alterLabsCmd.Connection = WarehouseShell.conn
                'alterLabsCmd.ExecuteNonQuery()
            End If

        ElseIf cmbLabName.getSQLValue().ToString() = "'49'" AndAlso Not (dtLabDate.getSQLValue() Is Nothing) Then
            Dim cmd As New SqlCommand("select count(*) from labs where lab = 50 And LabDate = " & dtLabDate.getSQLValue() & " and Subnum = " & WarehouseShell.SubNum & ";", WarehouseShell.conn)
            Dim value As Integer = cmd.ExecuteScalar()

            If value > 0 Then
                Dim weight As String = Database.ReturnString("Labs", "QuantitativeResult", "SubNum = " & WarehouseShell.SubNum & " and Lab = 50 and LabDate = " & dtLabDate.getSQLValue)
                Dim BMI As Decimal = (weight / 2.205) / ((numResultQuant.Text / 39.37) ^ 2)
                If BMI > 50 Then
                    MsgBox("This subject has a BMI greater than 50", MsgBoxStyle.OkOnly, "Warning")
                End If

                'Dim alterLabsCmd As New SqlCommand()
                'Dim checkBMI As New SqlCommand("select count(*) from labs where lab = 51 And LabDate = " & dtLabDate.getSQLValue() & " and Subnum = " & WarehouseShell.SubNum & " and QuantitativeResult is not null" & ";", WarehouseShell.conn)
                'Dim checkExistingBMI = checkBMI.ExecuteScalar()

                'If checkExistingBMI > 0 Then
                '    alterLabsCmd.CommandText = "update Labs set QuantitativeResult = " & FormatNumber(CDbl(BMI), 3) & " where SubNum = " & WarehouseShell.SubNum & " And labdate = " & dtLabDate.getSQLValue & " And Lab = 51 ;"
                'Else
                '    alterLabsCmd.CommandText = "Insert into Labs(SubNum, Lab, UoM, QuantitativeResult, Source, LabDate) values (" & WarehouseShell.SubNum & ", 51, '%', " & FormatNumber(CDbl(BMI), 3) & ", " & cmbLabSource.SelectedValue & ", " & dtLabDate.getSQLValue() & ");"
                'End If
                'alterLabsCmd.Connection = WarehouseShell.conn
                'alterLabsCmd.ExecuteNonQuery()
                AlterLabsBMI(BMI, dtLabDate.getSQLValue())
            End If
        End If
    End Sub

    Private Sub Calc2(ByVal labEntered As String)
        Dim dtDataTable As DataTable = Database.ReturnTable("Labs", "*, RANK() OVER (PARTITION BY Lab ORDER BY LabDate desc) as Rank", "SubNum = " & WarehouseShell.SubNum & " And Lab in (49,50,51) and LabDate is not null")
        For Each row As DataRow In dtDataTable.Rows
            Dim lab As Integer = row("Lab")
            Dim rank As Integer = row("Rank")
            Dim BMI As Decimal
            'a weight was entered
            If labEntered = "'50'" Then
                'find the latest height entered
                If lab = 49 And rank = 1 Then
                    Dim closestDate As Date = row("LabDate").ToString()
                    Dim height = row("QuantitativeResult")

                    Dim data = dtLabDate.getSQLValue().ToString()
                    Dim dataint As Date = data.Replace("'", "")
                    Dim days As Long = Math.Abs(DateDiff(DateInterval.Day, closestDate, dataint))


                    If days < 31 Then
                        BMI = (numResultQuant.Text / 2.205) / ((height / 39.37) ^ 2)
                        AlterLabsBMI(BMI, closestDate)
                    End If
                End If
            Else
                If lab = 50 And rank = 1 Then
                    Dim closestDate As Date = row("LabDate").ToString()
                    Dim weight = row("QuantitativeResult")

                    Dim data = dtLabDate.getSQLValue().ToString()
                    Dim dataint As Date = data.Replace("'", "")
                    Dim days As Long = Math.Abs(DateDiff(DateInterval.Day, closestDate, dataint))


                    If days < 31 Then
                        BMI = (weight / 2.205) / ((numResultQuant.Text / 39.37) ^ 2)
                        AlterLabsBMI(BMI, closestDate)
                    End If
                End If
            End If
        Next row
    End Sub


    Private Sub AlterLabsBMI(ByVal BMI As Decimal, ByVal closestDate As Date)
        If BMI > 50 Then
            MsgBox("This subject has a BMI greater than 50", MsgBoxStyle.OkOnly, "Warning")
        End If
        Dim alterLabsCmd As New SqlCommand()
        Dim checkPreviousBMI As New SqlCommand("select count(*) from labs where lab = 51 And (LabDate = " & dtLabDate.getSQLValue() & " Or LabDate = '" & closestDate & "') and Subnum = " & WarehouseShell.SubNum & " and QuantitativeResult is not null" & ";", WarehouseShell.conn)
        Dim prevBMI = checkPreviousBMI.ExecuteScalar()
        'Dim previousBMI As String = Database.ReturnString("Labs", "QuantitativeResult", "SubNum = " & WarehouseShell.SubNum & " and Lab = 49 and LabDate = " & dtLabDate.getSQLValue)
        If prevBMI > 0 Then
            alterLabsCmd.CommandText = "update Labs set QuantitativeResult = " & FormatNumber(CDbl(BMI), 3) & " where SubNum = " & WarehouseShell.SubNum & " And (labdate = " & dtLabDate.getSQLValue & " Or LabDate = '" & closestDate & "') And Lab = 51 ;"
        Else
            alterLabsCmd.CommandText = "Insert into Labs(SubNum, Lab, UoM, QuantitativeResult, Source, LabDate) values (" & WarehouseShell.SubNum & ", 51, '%', " & FormatNumber(CDbl(BMI), 3) & ", " & cmbLabSource.SelectedValue & ", " & dtLabDate.getSQLValue() & ");"
        End If
        alterLabsCmd.Connection = WarehouseShell.conn
        Try
            alterLabsCmd.ExecuteNonQuery()
        Catch ex As Exception
            ExceptionHandler.CatchSQLException(ex)
        End Try
    End Sub

    Private Sub setDoNotDistribute()
        If txtResultQual.getSQLValue().ToString().ToLower() = "'positive'" Then
            Dim value As String = Database.ReturnString("refLabs", "Infectious", "LabID = " & cmbLabName.SelectedValue)
            If value = "1" Then
                Dim cmd As New SqlCommand("update Subject set DoNotDistribute = 1 where SubNum = " & WarehouseShell.SubNum & ";", WarehouseShell.conn)
                cmd.ExecuteNonQuery()
            End If
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
    Private Function preSaveValidation() As Boolean
        Dim result As Boolean = True
        Dim errMsg As String = "The following errors must be corrected before this record can be saved:" & vbNewLine & vbNewLine

        If txtUoM.Text = "Boolean" Then
            If txtResultQual.Text = "" Or (txtResultQual.Text <> "Positive" And txtResultQual.Text <> "Negative") Then
                result = False
                errMsg += "- Please provide a Result Qual value (""Positive"" or ""Negative"")."
            End If
        Else
            If numResultQuant.Text = "" Then
                result = False
                errMsg += "- Please provide a Result Quant value." & vbNewLine
            End If
        End If

        If (cmbLabName.getSQLValue().ToString() = "'50'" AndAlso (dtLabDate.getSQLValue() Is Nothing)) Or (cmbLabName.getSQLValue().ToString() = "'49'" AndAlso (dtLabDate.getSQLValue() Is Nothing)) Then
            result = False
            errMsg += "- Please provide a Date for this Lab." & vbNewLine
        End If


        If result = False Then
            MsgBox(errMsg, MsgBoxStyle.OkOnly, "Error")
        End If
        Return result
    End Function

    Private Sub cmbLabName_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbLabName.SelectedValueChanged
        If mode <> "view" Then
            'get the corresponding refLabs row
            Dim id As Integer = cmbLabName.SelectedValue
            Dim foundRow() As DataRow = formTables.Tables("refLabs").Select("LabID = '" & id & "'")

            'set the default values
            If foundRow.Count() > 0 Then
                txtUoM.Text = foundRow(0).Item("DefUnit").ToString
                numRngFrom.Text = foundRow(0).Item("DefLow").ToString
                numRngTo.Text = foundRow(0).Item("DefHigh").ToString

                If txtUoM.Text = "Boolean" Then
                    numResultQuant.Enabled = False
                    txtResultQual.Enabled = True
                Else
                    numResultQuant.Enabled = True
                    txtResultQual.Enabled = False
                End If
            End If
        End If
    End Sub
    Private Sub resetForm()
        RecordID = 0
        cmbLabName.SelectedValue = 1
        txtUoM.Clear()
        numRngFrom.Clear()
        numRngTo.Clear()
        numResultQuant.Clear()
        txtResultQual.Clear()
        ActiveControl = cmbLabSource
    End Sub

    Private Sub keyPressed(sender As Object, e As KeyEventArgs) Handles txtUoM.KeyDown, numRngFrom.KeyDown, numRngTo.KeyDown, numResultQuant.KeyDown, txtResultQual.KeyDown, dtLabDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            If mode = "edit" Then
                e.Handled = True
                btnSaveClose.PerformClick()
            Else
                e.Handled = True
                btnSaveAdd.PerformClick()
            End If
        End If
    End Sub

    Private Sub btnSuggest_Click(sender As Object, e As EventArgs) Handles btnSuggest.Click
        Dim pu As New PU_Labs_SuggestNew
        pu.ShowDialog()
        pu.Dispose()
    End Sub
End Class