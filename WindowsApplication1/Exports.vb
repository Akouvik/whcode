Imports Microsoft.Office.Interop

Public Class Exports

    'Quarterly NBB Reporting
    Public Shared Function QuarterlyNIHTissueAcquisitionReport(ByVal fy As Integer, ByVal qtr As Integer) As DataTable
        Try
            Dim myQuery As String =
                "declare
					@qtr as integer,
					@startDate as date,
					@endDate as date

				Select @qtr = " & qtr & ";

				If @qtr = 1
					select @startDate = '9/1/" & fy - 1 & "', @endDate = '11/30/" & fy - 1 & "')
				else If @qtr = 2
					select @startDate = '12/1/" & fy - 1 & "', @endDate = '2/28/" & fy & "'
				else If @qtr = 3
					select @startDate = '3/1/" & fy & "', @endDate = '5/31/" & fy & "'
				else If @qtr = 4
					select @startDate = '6/1/" & fy & "', @endDate = '8/31/" & fy & "';

				select 
					(select count(BB) from AutopsyFaceSheet where DateOfDeath >= @startDate and DateOfDeath <= @endDate) as [# of Acquisitions], 
					(select convert(decimal(3,1),AVG(PMI)/convert(decimal(3,1), 60)) from AutopsyFaceSheet where DateOfDeath >= @startDate and DateOfDeath <= @endDate) as [Avg PMI (Hours)],
					(select AVG(Age) from viewSubject where SubNum in (select SubNum from AutopsyFaceSheet where DateOfDeath >= @startDate and DateOfDeath <= @endDate)) as [Avg Age],
					(select MIN(Age) from viewSubject where SubNum in (select SubNum from AutopsyFaceSheet where DateOfDeath >= @startDate and DateOfDeath <= @endDate)) as [Min Age],
					(select MAX(Age) from viewSubject where SubNum in (select SubNum from AutopsyFaceSheet where DateOfDeath >= @startDate and DateOfDeath <= @endDate)) as [Max Age],
					(select count(SexValue) from Subject where SubNum in (select SubNum from AutopsyFaceSheet where DateOfDeath >= @startDate and DateOfDeath <= @endDate) and SexValue = 1) as [# Male],
					(select count(SexValue) from Subject where SubNum in (select SubNum from AutopsyFaceSheet where DateOfDeath >= @startDate and DateOfDeath <= @endDate) and SexValue = 2) as [# Female],
					(select count(RaceValue) from Subject where SubNum in (select SubNum from AutopsyFaceSheet where DateOfDeath >= @startDate and DateOfDeath <= @endDate) and RaceValue = 1) as [# White],
					(select count(RaceValue) from Subject where SubNum in (select SubNum from AutopsyFaceSheet where DateOfDeath >= @startDate and DateOfDeath <= @endDate) and RaceValue = 2) as [# Black],
					(select count(RaceValue) from Subject where SubNum in (select SubNum from AutopsyFaceSheet where DateOfDeath >= @startDate and DateOfDeath <= @endDate) and RaceValue = 3) as [# Asian],
					(select count(RaceValue) from Subject where SubNum in (select SubNum from AutopsyFaceSheet where DateOfDeath >= @startDate and DateOfDeath <= @endDate) and RaceValue = 4) as [# Hispanic],
					(select count(RaceValue) from Subject where SubNum in (select SubNum from AutopsyFaceSheet where DateOfDeath >= @startDate and DateOfDeath <= @endDate) and (RaceValue is null or RaceValue = -1 or RaceValue = 5 or RaceValue = 9)) as [# Other/Unknown];"
            Dim reader As New SqlDataAdapter(myQuery, WarehouseShell.conn)
            Dim result As New Data.DataTable("TissueAcquisitionTable")
            reader.Fill(result)
            Return result
        Catch ex As Exception
            ExceptionHandler.CatchSQLException(ex)
            Return Nothing
        End Try
    End Function
    Public Shared Function ViewBDPReporting() As DataTable
        Try
            Dim myQuery As String = "Select * from viewBDPReporting as [BDP Report]"
            Dim reader As New SqlDataAdapter(myQuery, WarehouseShell.conn)
            'Do we need to create a table inthe db for this report?
            Dim result As New DataTable("BDPReportTable")
            reader.Fill(result)
            Return result
        Catch ex As Exception
            ExceptionHandler.CatchSQLException(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function QuarterlyNIHTissueDistributionReport(ByVal fy As Integer, ByVal qtr As Integer) As DataTable
        Try
            Dim myQuery As String =
                "declare
					@qtr as integer,
					@startDate as date,
					@endDate as date

				Select @qtr = " & qtr & ";

				If @qtr = 1
					select @startDate = '9/1/" & fy - 1 & "', @endDate = '11/30/" & fy - 1 & "')
				else If @qtr = 2
					select @startDate = '12/1/" & fy - 1 & "', @endDate = '2/28/" & fy & "'
				else If @qtr = 3
					select @startDate = '3/1/" & fy & "', @endDate = '5/31/" & fy & "'
				else If @qtr = 4
					select @startDate = '6/1/" & fy & "', @endDate = '8/31/" & fy & "';


				select 
					(select count(ProjectID) from TissueRequests where RequestDate >= @startDate and RequestDate <= @endDate) as [# of Requests], 
					(select count(ProjectID) from TissueRequests where DateShipped >= @startDate and DateShipped <= @endDate) as [# of Requests Fulfilled], 
					(select sum(TotalSamples) from TissueTasker where RequestDate >= @startDate and RequestDate <= @endDate) as [# Samples Requested],
					(select sum(TotalComplete) from TissueTasker where ProjectID in (select ProjectID from TissueRequests where DateShipped >= @startDate and DateShipped <= @endDate)) as [# Samples Filfilled]"
            Dim reader As New SqlDataAdapter(myQuery, WarehouseShell.conn)
            Dim result As New DataTable("TissueDistributionTable")
            reader.Fill(result)
            Return result
        Catch ex As Exception
            ExceptionHandler.CatchSQLException(ex)
            Return Nothing
        End Try
    End Function

    'Quarterly NBB IMS Reporting
    Public Shared Sub ExportNBBReports()
        Dim result As DialogResult = MsgBox("This operation can take 5-10 minutes or more to complete, during which time the Data Wareouse will be unresponsive. Are you sure you'd like to continue?", MsgBoxStyle.YesNo, "Warning")
        If result = DialogResult.Yes Then
            'set the current quarter
            Dim qtr As String = Right("0" & Now.Month.ToString, 2) & Right(Now.Year.ToString, 2)

            'remove (if exists) and recreate Desktop folder for results (this will clear out any previous results)
            Dim desktopFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\NBB Quarterly Reports"
            If Directory.Exists(desktopFolder) Then
                Directory.Delete(desktopFolder, True)
            End If
            Directory.CreateDirectory(desktopFolder)

            'Create the CSV files
            ExportNBBData("GeneralSubjectFields", qtr, desktopFolder)
            ExportNBBData("GeneralBrainSpecimenData", qtr, desktopFolder)
            ExportNBBData("Diagnoses", qtr, desktopFolder)
            ExportNBBData("MedicationHistory", qtr, desktopFolder)
            ExportNBBData("NonBrainSpecimenData", qtr, desktopFolder)
            ExportNBBData("NMSToxCrosswalk", qtr, desktopFolder)
            MsgBox("The operation is complete and the files have been written to a folder on your desktop named ""NBB Quarterly Reports"".", MsgBoxStyle.OkOnly)
        End If
    End Sub
    Private Shared Sub ExportNBBData(ByVal table As String, ByVal qtr As String, ByVal desktopPath As String)
        'Get the table from SQL
        Dim refTable As DataTable = Database.ReturnTable("viewNBB_" & table)

        'Build the CSV file data as a Comma separated string.
        Dim csv As String = ""

        'Add the Header row for CSV file.
        For Each column As DataColumn In refTable.Columns
            csv += """" & column.ColumnName & ""","
        Next

        'Josh test
        csv = csv.Remove(csv.Length - 1)

        'Add new line.
        csv += vbCr & vbLf

        'Adding the Rows
        For Each row As DataRow In refTable.Rows
            Dim i As Integer = 0
            While i < row.ItemArray.Length
                If TypeOf row.Item(i) Is Date Then
                    csv += """" & Format(row.Item(i), "MM'/'dd'/'yyyy").ToString & ""","
                ElseIf TypeOf row.Item(i) Is String Then
                    csv += """" & row.Item(i).ToString().Replace("""", """""""") & ""","
                Else
                    csv += row.Item(i).ToString & ","
                End If
                i += 1
            End While

            'Josh test
            csv = csv.Remove(csv.Length - 1)

            'Add new line.
            csv += vbCr & vbLf
        Next

        'Export data to CSV file
        File.WriteAllText(desktopPath & "\Mount_Sinai_" & qtr & "_" & table & ".csv", csv)
    End Sub

    Public Shared Sub MoveImages()
        Dim DescriptionList As DataTable = Database.ReturnTable("fileAutopsyMacroImages", "distinct Description")
        Dim FileList As DataTable
        'This sub uses https://support.microsoft.com/en-us/kb/316887 & System.Diagnostics to grab the blob file from filestream, copy it with extension to the user's temp file, then open it using whatever default program they have for that extension.
        'Dim tempFileName As String
        Dim tempFileExt As String
        'These lines get the file extension from the fileAutopsyMacroImages table and assigns it to tempFileExt (and set the connection property for this and subsequent SqlCommands)
        Dim cmd As New SqlCommand
        cmd.Connection = WarehouseShell.conn
        For Each desc As DataRow In DescriptionList.Rows()
            FileList = Database.ReturnTable("JoshMacroImages",, "Description = '" & desc.Item("Description").ToString & "'")
            For Each img As DataRow In FileList.Rows()
                Dim tempFilePath As String = "Q:\Warehouse Files\AutopsyMacroscopicImages\"
                tempFileExt = img.Item("FileExtension").ToString
                'Grab the binary data from FileStream and load it into the SqlDataReader
                cmd.CommandText = "Select FileData from fileAutopsyMacroImages where SubNum = " & img.Item("SubNum") & " and Description = '" & desc.Item("Description") & "';"
                Dim dr As SqlDataReader = cmd.ExecuteReader()
                dr.Read()
                Dim b(dr.GetBytes(0, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
                dr.GetBytes(0, 0, b, 0, b.Length)
                dr.Close()
                Try
                    'Write the binary data to a file with extension in the user's temp folder (using provided file name or default)
                    tempFilePath = tempFilePath & img.Item("BB") & " " & img.Item("Description") & tempFileExt
                    Dim fs As New System.IO.FileStream(tempFilePath, IO.FileMode.Create, IO.FileAccess.Write)
                    fs.Write(b, 0, b.Length)
                    fs.Close()
                    cmd.CommandText = "Update fileAutopsyMacroImages set FileName = '" & img.Item("BB") & " " & img.Item("Description") & tempFileExt &
                        "', FileLocation = '" & tempFilePath & "' where SubNum = " & img.Item("SubNum") & " and Description = '" & img.Item("Description") & "';"
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    ExceptionHandler.CatchWindowsException(ex)
                End Try
            Next
        Next

    End Sub

    'VRL Manifests for Tissue Distributions
    Public Shared Sub GenerateVRLManifest(ByVal ProjectID As String)
        'Create/Recreate tempVRLManifest table using ProjectID provided
        Try
            Dim sql As New SqlCommand("exec GenVRLManifest @project = " & ProjectID, WarehouseShell.conn)
            sql.ExecuteNonQuery()
        Catch ex As SqlException
            ExceptionHandler.CatchSQLException(ex)
        End Try

        'Load the table into memory and write it to Excel
        Try
            Dim table As New DataTable("table")
            table = Database.ReturnTable("tempVRLManifest")

            'Start a new workbook in Excel
            Dim appXL As Excel.Application = CreateObject("Excel.Application")
            Dim wbXL As Excel.Workbook = appXL.Workbooks.Add
            Dim shXL As Excel.Worksheet = wbXL.ActiveSheet


            'Add data to cells of the first worksheet in the new workbook
            shXL.Range("A1").Value = "Primary Account"
            shXL.Range("B1").Value = "Additional Reports"
            shXL.Range("C1").Value = "Demographics"
            shXL.Range("D1").Value = "Donor ID"
            shXL.Range("E1").Value = "Sample Info"
            shXL.Range("F1").Value = "Shipping System"
            shXL.Range("G1").Value = "Pkg Date Time"
            shXL.Range("H1").Value = "Collection Date Time"
            shXL.Range("I1").Value = "Sample Type"
            shXL.Range("J1").Value = "Centrifuge Date Time"
            shXL.Range("K1").Value = "Frozen Date Time"
            shXL.Range("L1").Value = "Init Refrigeration Date Time"
            shXL.Range("M1").Value = "Profile Test Code Selection"
            shXL.Range("N1").Value = "Individual Test Code Selection"
            shXL.Range("O1").Value = "Individual Test Description"


            For i As Integer = 1 To table.Rows().Count
                shXL.Range("A" & i + 1).Value = table.Rows(i - 1).Item(0).ToString
                shXL.Range("B" & i + 1).Value = table.Rows(i - 1).Item(1).ToString
                shXL.Range("C" & i + 1).Value = table.Rows(i - 1).Item(2).ToString
                shXL.Range("D" & i + 1).Value = table.Rows(i - 1).Item(3).ToString
                shXL.Range("E" & i + 1).Value = table.Rows(i - 1).Item(4).ToString
                shXL.Range("F" & i + 1).Value = table.Rows(i - 1).Item(5).ToString
                shXL.Range("G" & i + 1).Value = table.Rows(i - 1).Item(6).ToString
                shXL.Range("H" & i + 1).Value = table.Rows(i - 1).Item(7).ToString
                shXL.Range("I" & i + 1).Value = table.Rows(i - 1).Item(8).ToString
                shXL.Range("J" & i + 1).Value = table.Rows(i - 1).Item(9).ToString
                shXL.Range("K" & i + 1).Value = table.Rows(i - 1).Item(10).ToString
                shXL.Range("L" & i + 1).Value = table.Rows(i - 1).Item(11).ToString
                shXL.Range("M" & i + 1).Value = table.Rows(i - 1).Item(12).ToString
                shXL.Range("N" & i + 1).Value = table.Rows(i - 1).Item(13).ToString
                shXL.Range("O" & i + 1).Value = table.Rows(i - 1).Item(14).ToString
            Next

            'Resize the columns to autofit
            shXL.Range("A1", "O1").EntireColumn.AutoFit()

            MsgBox("A new Excel file named ""VRL Manifest.xlsx"" will be saved to your desktop and opened for your review. Check the taskbar at the bottom of your screen if you do not see the Excel form when you click OK below.", MsgBoxStyle.OkOnly)

            'Delete target file if it already exists (from previous use) and save the new file to the desktop
            File.Delete(My.Computer.FileSystem.SpecialDirectories.Desktop & "\VRL Manifest.xlsx")
            wbXL.SaveAs(My.Computer.FileSystem.SpecialDirectories.Desktop & "\VRL Manifest.xlsx")

            'Free up the memory
            appXL.Quit()
            appXL = Nothing
            table = Nothing
            Process.Start(My.Computer.FileSystem.SpecialDirectories.Desktop & "\VRL Manifest.xlsx")
        Catch ex As Exception
            ExceptionHandler.CatchWindowsException(ex)
        End Try
    End Sub
End Class
