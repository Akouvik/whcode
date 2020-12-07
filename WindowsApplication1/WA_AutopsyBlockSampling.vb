Public Class WA_AutopsyBlockSampling
    Implements IFormMethods
    Private formTables As New DataSet
    Private tooltip1 As New ToolTip

    Private Sub WA_AutopsyBlockSampling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_AutopsyBlockSampling")
        If Database.ExistingRecordCheck("AutopsyBlockSampling", "SubNum = " & WarehouseShell.SubNum) = True Then
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            EnableInputFields(False)
            LoadExistingData()
            SaveTop.Text = "Edit this record"
            SaveBottom.Text = SaveTop.Text
            SaveTop.Focus()
            lblNoRecord.Visible = False
        Else
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            enableInputFields(False)
            SaveTop.Text = "Add New Record"
            SaveBottom.Text = SaveTop.Text
            lblNoRecord.Visible = True
        End If
    End Sub

    Private Sub EnableInputFields(ByVal bool As Boolean)
        For Each item As Control In Controls()
            If TypeOf item Is CheckBox_ Then
                item.Enabled = bool
            ElseIf TypeOf item Is TextBox_ Then
                CType(item, TextBox_).makeReadOnly(Not bool)
            End If
        Next
    End Sub

    Private Sub LoadExistingData()
        'Grab the AutopsyBlockSampling record for this SubNum
        formTables.Tables.Add(Database.ReturnTable("AutopsyBlockSampling", , "SubNum = " & WarehouseShell.SubNum))
        'Apply the existing values to the input fields
        For Each item As Control In Controls()
            If TypeOf item Is CheckBox_ Then
                CType(item, CheckBox_).setValue(formTables, "AutopsyBlockSampling", item.Name)
            ElseIf TypeOf item Is TextBox_ Then
                CType(item, TextBox_).setValue(formTables, "AutopsyBlockSampling", item.Name)
            End If
        Next
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles SaveTop.Click, SaveBottom.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_AutopsyBlockSampling", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                EnableInputFields(True)
                SaveTop.Text = "Save changes"
                SaveBottom.Text = SaveTop.Text
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If User.PermissionCheck("WA_AutopsyBlockSampling", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
                EnableInputFields(True)
                SaveTop.Text = "Save new record"
                SaveBottom.Text = SaveTop.Text
                lblNoRecord.Visible = False
            End If
        Else
            If PreSaveValidation() = True Then
                If MismatchRegionSpecOK() Then
                    Dim sqlCommand As New SqlCommand
                    sqlCommand.Connection = WarehouseShell.conn
                    Dim cmdString = "@SubNum = " & WarehouseShell.SubNum

                    For Each item As Control In Controls()
                        If TypeOf item Is CheckBox_ Then
                            cmdString += ", @" & item.Name & " = " & CType(item, CheckBox_).getSQLValue()
                        ElseIf TypeOf item Is TextBox_ Then
                            cmdString += ", @" & item.Name & " = " & CType(item, TextBox_).getSQLValue()
                        End If
                    Next

                    cmdString += ", @LastModBy = '" & WarehouseShell.userName & "';"

                    If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                        sqlCommand.CommandText = "EXEC dbo.modAutopsyBlockSamplingRecord @Action = 1, " & cmdString
                        Try
                            sqlCommand.ExecuteNonQuery()
                            MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                            EnableInputFields(False)
                            SaveTop.Text = "Edit this record"
                            SaveBottom.Text = SaveTop.Text
                        Catch ex As SqlException
                            ExceptionHandler.CatchSQLException(ex)
                        End Try
                    Else
                        sqlCommand.CommandText = "EXEC dbo.modAutopsyBlockSamplingRecord @Action = 2, " & cmdString
                        Try
                            sqlCommand.ExecuteNonQuery()
                            MessageBox.Show("Record successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                            EnableInputFields(False)
                            SaveTop.Text = "Edit this record"
                            SaveBottom.Text = SaveTop.Text
                        Catch ex As SqlException
                            ExceptionHandler.CatchSQLException(ex)
                        End Try
                    End If

                    SaveNPMappingData()
                End If
            End If
        End If
    End Sub

    Private Function PreSaveValidation() As Boolean
        Dim result As Boolean = True
        Dim errorMessage As String = ""

        'Validate comboWasGenericAutopsyDone
        If Block21.Checked And Block21Spec.Text = "" Then
            result = False
            errorMessage += "- Block 21: Please provide a specify value or uncheck Block 21." & vbNewLine
        ElseIf Block21.Checked = False And Block21Spec.Text <> "" Then
            result = False
            errorMessage += "- Block 21: Please check Block 21 or remove the specify value." & vbNewLine
        End If

        If Block22.Checked And Block22Spec.Text = "" Then
            result = False
            errorMessage += "- Block 22: Please provide a specify value or uncheck Block 22." & vbNewLine
        ElseIf Block22.Checked = False And Block22Spec.Text <> "" Then
            result = False
            errorMessage += "- Block 22: Please check Block 22 or remove the specify value." & vbNewLine
        End If

        If Block23.Checked And Block23Spec.Text = "" Then
            result = False
            errorMessage += "- Block 23: Please provide a specify value or uncheck Block 23." & vbNewLine
        ElseIf Block23.Checked = False And Block23Spec.Text <> "" Then
            result = False
            errorMessage += "- Block 23: Please check Block 23 or remove the specify value." & vbNewLine
        End If

        If Block24.Checked And Block24Spec.Text = "" Then
            result = False
            errorMessage += "- Block 24: Please provide a specify value or uncheck Block 24." & vbNewLine
        ElseIf Block24.Checked = False And Block24Spec.Text <> "" Then
            result = False
            errorMessage += "- Block 24: Please check Block 24 or remove the specify value." & vbNewLine
        End If

        If Block25.Checked And Block25Spec.Text = "" Then
            result = False
            errorMessage += "- Block 25: Please provide a specify value or uncheck Block 25." & vbNewLine
        ElseIf Block25.Checked = False And Block25Spec.Text <> "" Then
            result = False
            errorMessage += "- Block 25: Please check Block 25 or remove the specify value." & vbNewLine
        End If

        If Block26.Checked And Block26Spec.Text = "" Then
            result = False
            errorMessage += "- Block 26: Please provide a specify value or uncheck Block 26." & vbNewLine
        ElseIf Block26.Checked = False And Block26Spec.Text <> "" Then
            result = False
            errorMessage += "- Block 26: Please check Block 26 or remove the specify value." & vbNewLine
        End If

        If Block27.Checked And Block27Spec.Text = "" Then
            result = False
            errorMessage += "- Block 27: Please provide a specify value or uncheck Block 27." & vbNewLine
        ElseIf Block27.Checked = False And Block27Spec.Text <> "" Then
            result = False
            errorMessage += "- Block 27: Please check Block 27 or remove the specify value." & vbNewLine
        End If

        If Block28.Checked And Block28Spec.Text = "" Then
            result = False
            errorMessage += "- Block 28: Please provide a specify value or uncheck Block 28." & vbNewLine
        ElseIf Block28.Checked = False And Block28Spec.Text <> "" Then
            result = False
            errorMessage += "- Block 28: Please check Block 28 or remove the specify value." & vbNewLine
        End If

        If Block29.Checked And Block29Spec.Text = "" Then
            result = False
            errorMessage += "- Block 29: Please provide a specify value or uncheck Block 29." & vbNewLine
        ElseIf Block29.Checked = False And Block29Spec.Text <> "" Then
            result = False
            errorMessage += "- Block 29: Please check Block 29 or remove the specify value." & vbNewLine
        End If

        'Handle result
        If result = False Then
            MsgBox("The following errors must be corrected before this record can be saved: " & vbNewLine & vbNewLine & errorMessage, MsgBoxStyle.OkOnly, "Error")
        End If
        Return result
    End Function

    Private Function MismatchRegionSpecOK() As Boolean
        Dim result As Boolean = True

        If WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit Then
            For Each item As Control In Controls()
                If TypeOf item Is TextBox_ Then
                    Dim existingValue As String = formTables.Tables("AutopsyBlockSampling").Rows(0).Item(item.Name).ToString
                    If existingValue <> "" And CType(item, TextBox_).Text <> "" Then
                        If existingValue <> CType(item, TextBox_).Text Then
                            Dim resp As DialogResult = MsgBox("You are about to change the specify value for an existing block from """ & existingValue & """ to """ & CType(item, TextBox_).Text & """. Would you like to continue?", MsgBoxStyle.YesNo, "Warning")
                            If resp = DialogResult.No Then
                                result = False
                                Exit For
                            End If
                        End If
                    End If
                End If
            Next
        End If

        Return result
    End Function

    Private Sub SaveNPMappingData()
        Dim cmd As New SqlCommand("delete from NPRegionMap where SubNum = " & WarehouseShell.SubNum, WarehouseShell.conn)
        cmd.ExecuteNonQuery()

        If Block1.Checked Then
            cmd.CommandText = "insert into NPRegionMap (SubNum, RegionNum, RegionLkp) values (" & WarehouseShell.SubNum & ", 1, 1);"
            cmd.ExecuteNonQuery()
        End If
        If Block2.Checked Then
            cmd.CommandText = "insert into NPRegionMap (SubNum, RegionNum, RegionLkp) values (" & WarehouseShell.SubNum & ", 2, 15);"
            cmd.ExecuteNonQuery()
        End If
        If Block3.Checked Then
            cmd.CommandText = "insert into NPRegionMap (SubNum, RegionNum, RegionLkp) values (" & WarehouseShell.SubNum & ", 3, 2);"
            cmd.ExecuteNonQuery()
        End If
        If Block4.Checked Then
            cmd.CommandText = "insert into NPRegionMap (SubNum, RegionNum, RegionLkp) values (" & WarehouseShell.SubNum & ", 4, 3);"
            cmd.ExecuteNonQuery()
        End If
        If Block5.Checked Then
            cmd.CommandText = "insert into NPRegionMap (SubNum, RegionNum, RegionLkp) values (" & WarehouseShell.SubNum & ", 5, 4);"
            cmd.ExecuteNonQuery()
        End If
        If Block6.Checked Then
            cmd.CommandText = "insert into NPRegionMap (SubNum, RegionNum, RegionLkp) values (" & WarehouseShell.SubNum & ", 6, 5);"
            cmd.ExecuteNonQuery()
        End If
        If Block7.Checked Then
            cmd.CommandText = "insert into NPRegionMap (SubNum, RegionNum, RegionLkp) values (" & WarehouseShell.SubNum & ", 7, 6);"
            cmd.ExecuteNonQuery()
        End If
        If Block8.Checked Then
            cmd.CommandText = "insert into NPRegionMap (SubNum, RegionNum, RegionLkp) values (" & WarehouseShell.SubNum & ", 8, 16);"
            cmd.ExecuteNonQuery()
        End If
        If Block9.Checked Then
            cmd.CommandText = "insert into NPRegionMap (SubNum, RegionNum, RegionLkp) values (" & WarehouseShell.SubNum & ", 9, 9);"
            cmd.ExecuteNonQuery()
        End If
        If Block10.Checked Then
            cmd.CommandText = "insert into NPRegionMap (SubNum, RegionNum, RegionLkp) values (" & WarehouseShell.SubNum & ", 10, 10);"
            cmd.ExecuteNonQuery()
        End If
        If Block11.Checked Then
            cmd.CommandText = "insert into NPRegionMap (SubNum, RegionNum, RegionLkp) values (" & WarehouseShell.SubNum & ", 11, 11);"
            cmd.ExecuteNonQuery()
        End If
        If Block12.Checked Then
            cmd.CommandText = "insert into NPRegionMap (SubNum, RegionNum, RegionLkp) values (" & WarehouseShell.SubNum & ", 12, 12);"
            cmd.ExecuteNonQuery()
        End If
        If Block13.Checked Then
            cmd.CommandText = "insert into NPRegionMap (SubNum, RegionNum, RegionLkp) values (" & WarehouseShell.SubNum & ", 13, 13);"
            cmd.ExecuteNonQuery()
        End If
        If Block14.Checked Then
            cmd.CommandText = "insert into NPRegionMap (SubNum, RegionNum, RegionLkp) values (" & WarehouseShell.SubNum & ", 14, 14);"
            cmd.ExecuteNonQuery()
        End If
        If Block15.Checked Then
            cmd.CommandText = "insert into NPRegionMap (SubNum, RegionNum, RegionLkp) values (" & WarehouseShell.SubNum & ", 15, 17);"
            cmd.ExecuteNonQuery()
        End If
        If Block16.Checked Then
            cmd.CommandText = "insert into NPRegionMap (SubNum, RegionNum, RegionLkp) values (" & WarehouseShell.SubNum & ", 16, 18);"
            cmd.ExecuteNonQuery()
        End If
        If Block17.Checked Then
            cmd.CommandText = "insert into NPRegionMap (SubNum, RegionNum, RegionLkp) values (" & WarehouseShell.SubNum & ", 17, 19);"
            cmd.ExecuteNonQuery()
        End If
        If Block18.Checked Then
            cmd.CommandText = "insert into NPRegionMap (SubNum, RegionNum, RegionLkp) values (" & WarehouseShell.SubNum & ", 18, 20);"
            cmd.ExecuteNonQuery()
        End If
        If Block19.Checked Then
            cmd.CommandText = "insert into NPRegionMap (SubNum, RegionNum, RegionLkp) values (" & WarehouseShell.SubNum & ", 19, 21);"
            cmd.ExecuteNonQuery()
        End If
        If Block20.Checked Then
            cmd.CommandText = "insert into NPRegionMap (SubNum, RegionNum, RegionLkp) values (" & WarehouseShell.SubNum & ", 20, 22);"
            cmd.ExecuteNonQuery()
        End If
        If Block21.Checked Then
            cmd.CommandText = "insert into NPRegionMap (SubNum, RegionNum, RegionLkp, RegionNameSpec) values (" & WarehouseShell.SubNum & ", 21, 999, " & Block21Spec.getSQLValue() & ");"
            cmd.ExecuteNonQuery()
        End If
        If Block22.Checked Then
            cmd.CommandText = "insert into NPRegionMap (SubNum, RegionNum, RegionLkp, RegionNameSpec) values (" & WarehouseShell.SubNum & ", 22, 999, " & Block22Spec.getSQLValue() & ");"
            cmd.ExecuteNonQuery()
        End If
        If Block23.Checked Then
            cmd.CommandText = "insert into NPRegionMap (SubNum, RegionNum, RegionLkp, RegionNameSpec) values (" & WarehouseShell.SubNum & ", 23, 999, " & Block23Spec.getSQLValue() & ");"
            cmd.ExecuteNonQuery()
        End If
        If Block24.Checked Then
            cmd.CommandText = "insert into NPRegionMap (SubNum, RegionNum, RegionLkp, RegionNameSpec) values (" & WarehouseShell.SubNum & ", 24, 999, " & Block24Spec.getSQLValue() & ");"
            cmd.ExecuteNonQuery()
        End If
        If Block25.Checked Then
            cmd.CommandText = "insert into NPRegionMap (SubNum, RegionNum, RegionLkp, RegionNameSpec) values (" & WarehouseShell.SubNum & ", 25, 999, " & Block25Spec.getSQLValue() & ");"
            cmd.ExecuteNonQuery()
        End If
        If Block26.Checked Then
            cmd.CommandText = "insert into NPRegionMap (SubNum, RegionNum, RegionLkp, RegionNameSpec) values (" & WarehouseShell.SubNum & ", 26, 999, " & Block26Spec.getSQLValue() & ");"
            cmd.ExecuteNonQuery()
        End If
        If Block27.Checked Then
            cmd.CommandText = "insert into NPRegionMap (SubNum, RegionNum, RegionLkp, RegionNameSpec) values (" & WarehouseShell.SubNum & ", 27, 999, " & Block27Spec.getSQLValue() & ");"
            cmd.ExecuteNonQuery()
        End If
        If Block28.Checked Then
            cmd.CommandText = "insert into NPRegionMap (SubNum, RegionNum, RegionLkp, RegionNameSpec) values (" & WarehouseShell.SubNum & ", 28, 999, " & Block28Spec.getSQLValue() & ");"
            cmd.ExecuteNonQuery()
        End If
        If Block29.Checked Then
            cmd.CommandText = "insert into NPRegionMap (SubNum, RegionNum, RegionLkp, RegionNameSpec) values (" & WarehouseShell.SubNum & ", 29, 999, " & Block29Spec.getSQLValue() & ");"
            cmd.ExecuteNonQuery()
        End If
    End Sub

    Private Sub Blank_Click(sender As Object, e As EventArgs) Handles Blank.Click
        Dim outputFileName As String = "Autopsy Block Sampling.pdf"
        'This sub uses https://support.microsoft.com/en-us/kb/316887 & System.Diagnostics to grab the blob file from filestream, copy it with extension to the user's temp file, then open it using whatever default program they have for that extension.
        Dim tempFilePath As String = IO.Path.GetTempPath()
        'These lines get the file extension from the tableName table and assigns it to tempFileExt (and set the connection property for this and subsequent SqlCommands)
        Dim cmd As New SqlCommand("Select FileData from fileBlankDocs where RecordID = 51;", WarehouseShell.conn)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        dr.Read()
        Dim b(dr.GetBytes(0, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
        dr.GetBytes(0, 0, b, 0, b.Length)
        dr.Close()
        Try
            'Write the binary data to a file with extension in the user's temp folder (using provided file name or default)
            tempFilePath = tempFilePath & outputFileName
            Dim fs As New FileStream(tempFilePath, IO.FileMode.Create, IO.FileAccess.Write)
            fs.Write(b, 0, b.Length)
            fs.Close()
            'Open the temp file using the user's default program for that extension
            Dim P As New Process
            Dim s As New ProcessStartInfo(tempFilePath)
            s.UseShellExecute = True
            s.WindowStyle = ProcessWindowStyle.Normal
            P.StartInfo = s
            P.Start()
        Catch ex As Exception
            ExceptionHandler.CatchWindowsException(ex)
        End Try
    End Sub

    Private Sub Export_Click(sender As Object, e As EventArgs) Handles Export.Click
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
            tooltip1.Show("This record must be saved before PDF Export can be created.", sender, 0, 20, 5000)
        Else
            Try
                'Define which template to use
                Dim pdfTemplate As String = "Q:\Warehouse Files\PDF Export Templates\Autopsy Block Sampling.pdf"
                'Define the output file name
                formTables.Tables.Add(Database.ReturnTable("AutopsyFaceSheet", "BB", "SubNum = " & WarehouseShell.SubNum))
                Dim outputFileName As String = "BB " & formTables.Tables("AutopsyFaceSheet").Rows(0).Item("BB").ToString & " Autopsy Block Sampling.pdf"
                'combine the output file name with the user's temp file path location so we can create and fill the PDF
                Dim filledPDF As String = IO.Path.GetTempPath() & outputFileName

                'Use the PDF API to start the the new file
                Dim pdfReader As PdfReader = New PdfReader(pdfTemplate)
                Dim pdfStamper As New PdfStamper(pdfReader, New FileStream(filledPDF, FileMode.Create))
                Dim pdfFormFields As AcroFields = pdfStamper.AcroFields

                'Fill the fields with values
                pdfFormFields.SetField("BB", formTables.Tables("AutopsyFaceSheet").Rows(0).Item("BB").ToString)
                pdfFormFields.SetField("Block1", IIf(Block1.Checked = True, "1", ""))
                pdfFormFields.SetField("Block2", IIf(Block2.Checked = True, "1", ""))
                pdfFormFields.SetField("Block3", IIf(Block3.Checked = True, "1", ""))
                pdfFormFields.SetField("Block4", IIf(Block4.Checked = True, "1", ""))
                pdfFormFields.SetField("Block5", IIf(Block5.Checked = True, "1", ""))
                pdfFormFields.SetField("Block6", IIf(Block6.Checked = True, "1", ""))
                pdfFormFields.SetField("Block7", IIf(Block7.Checked = True, "1", ""))
                pdfFormFields.SetField("Block8", IIf(Block8.Checked = True, "1", ""))
                pdfFormFields.SetField("Block9", IIf(Block9.Checked = True, "1", ""))
                pdfFormFields.SetField("Block10", IIf(Block10.Checked = True, "1", ""))
                pdfFormFields.SetField("Block11", IIf(Block11.Checked = True, "1", ""))
                pdfFormFields.SetField("Block12", IIf(Block12.Checked = True, "1", ""))
                pdfFormFields.SetField("Block13", IIf(Block13.Checked = True, "1", ""))
                pdfFormFields.SetField("Block14", IIf(Block14.Checked = True, "1", ""))
                pdfFormFields.SetField("Block15", IIf(Block15.Checked = True, "1", ""))
                pdfFormFields.SetField("Block16", IIf(Block16.Checked = True, "1", ""))
                pdfFormFields.SetField("Block17", IIf(Block17.Checked = True, "1", ""))
                pdfFormFields.SetField("Block18", IIf(Block18.Checked = True, "1", ""))
                pdfFormFields.SetField("Block19", IIf(Block19.Checked = True, "1", ""))
                pdfFormFields.SetField("Block20", IIf(Block20.Checked = True, "1", ""))
                pdfFormFields.SetField("Block21", IIf(Block21.Checked = True, "1", ""))
                pdfFormFields.SetField("Block21Spec", Block21Spec.Text)
                pdfFormFields.SetField("Block22", IIf(Block22.Checked = True, "1", ""))
                pdfFormFields.SetField("Block22Spec", Block22Spec.Text)
                pdfFormFields.SetField("Block23", IIf(Block23.Checked = True, "1", ""))
                pdfFormFields.SetField("Block23Spec", Block23Spec.Text)
                pdfFormFields.SetField("Block24", IIf(Block24.Checked = True, "1", ""))
                pdfFormFields.SetField("Block24Spec", Block24Spec.Text)
                pdfFormFields.SetField("Block25", IIf(Block25.Checked = True, "1", ""))
                pdfFormFields.SetField("Block25Spec", Block25Spec.Text)
                pdfFormFields.SetField("Block26", IIf(Block26.Checked = True, "1", ""))
                pdfFormFields.SetField("Block26Spec", Block26Spec.Text)
                pdfFormFields.SetField("Block27", IIf(Block27.Checked = True, "1", ""))
                pdfFormFields.SetField("Block27Spec", Block27Spec.Text)
                pdfFormFields.SetField("Block28", IIf(Block28.Checked = True, "1", ""))
                pdfFormFields.SetField("Block28Spec", Block28Spec.Text)
                pdfFormFields.SetField("Block29", IIf(Block29.Checked = True, "1", ""))
                pdfFormFields.SetField("Block29Spec", Block29Spec.Text)

                'Flatten the form to dissuade manual editing of outputs
                pdfStamper.FormFlattening = True

                'Close the stamper (to finalize the Filled PDF)
                pdfStamper.Close()
                pdfReader.Dispose()

                'Launch the filled PDF for the user
                Dim P As New System.Diagnostics.Process
                Dim s As New System.Diagnostics.ProcessStartInfo(filledPDF)
                s.UseShellExecute = True
                s.WindowStyle = ProcessWindowStyle.Normal
                P.StartInfo = s
                P.Start()
            Catch ex As Exception
                ExceptionHandler.CatchWindowsException(ex)
            End Try
        End If
    End Sub

    'Imported IFormMethods
    Public Sub ShowPHI(showPHI As Boolean) Implements IFormMethods.ShowPHI
    End Sub
    Public Sub Parent1(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Public Sub Show1() Implements IFormMethods.Show
        Show()
    End Sub
    Public Sub TopLevel1(val As Boolean) Implements IFormMethods.TopLevel
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
        SaveTop.PerformClick()
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class
