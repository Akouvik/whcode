Public Class WH_Imports

    Public Shared Sub ImportMRI()
        Dim NIFTI As String() = Directory.GetDirectories("I:\MRI\NIFTI\")

        For Each NIFTIdir As String In NIFTI
            Dim BB As String = NIFTIdir.Substring(21, 4)
            Dim SubNum As String = Database.ReturnString("AutopsyFaceSheet", "SubNum", "BB = " & BB)

            If Not Database.ExistingRecordCheck("fileMRI", "SubNum = " & SubNum) Then
                Dim SESSION As String() = Directory.GetDirectories(NIFTIdir)

                For Each SESSIONdir As String In SESSION
                    Dim ANAT As String() = Directory.GetDirectories(SESSIONdir)

                    For Each ANATdir As String In ANAT
                        If ANATdir.Substring(ANATdir.Length - 5) = "\anat" Then
                            Dim datFiles As String() = Directory.GetFiles(ANATdir)

                            For Each myFile As String In datFiles
                                If Not myFile.Contains("BUBBLE") Then
                                    If myFile.Contains(".nii.") Then
                                        If myFile.Contains("_run-") Then
                                            Dim scanDate As String = myFile.Substring(61, 8)
                                            Dim run As String = myFile.Substring(74, 2)
                                            Dim scanType As String = myFile.Substring(77)
                                            If scanType.Substring(0, 2) = "T1" Then
                                                scanType = "T1"
                                            ElseIf scanType.Substring(0, 2) = "T2" Then
                                                scanType = "T2"
                                            Else
                                                scanType = scanType.Substring(0, 12)
                                            End If

                                            Dim cmd As New SqlCommand("", WarehouseShell.conn)
                                            cmd.CommandText = "insert into fileMRI (SubNum, ScanDate, Run, ScanType, FileLocation) values (" &
                                                SubNum & ", '" & scanDate & "', " & run & ", '" & scanType & "', '" & myFile & "');"
                                            cmd.ExecuteNonQuery()
                                        End If
                                    End If
                                End If
                            Next
                        End If
                    Next
                Next
            End If
        Next
    End Sub

End Class
