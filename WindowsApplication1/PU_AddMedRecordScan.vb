Public Class PU_AddMedRecordScan
    Private researchTeam As String = ""
    Private subNum As Integer
    Private seqNum As Integer
    Public result As DialogResult

    Public Sub New(ByVal mySubNum As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        subNum = mySubNum
        researchTeam = "NBTR"
        'ToDo: remove this ResearchTeam variable since ADRC is not using our system at all
    End Sub

    Private Function getNextSeqNum() As Integer
        Dim seqNum As Integer = 1
        If Database.ExistingRecordCheck("filePointerMedicalRecords", "SubNum = " & subNum) Then
            Dim cmd As New SqlCommand("select max(SeqNum) from filePointerMedicalRecords where SubNum = " & subNum, WarehouseShell.conn)
            seqNum += cmd.ExecuteScalar()
        End If
        Return seqNum
    End Function

    Private Sub btnChooseFile_Click(sender As Object, e As EventArgs) Handles btnChooseFile.Click
        Dim Description As String = txtDescription.Text
        If Description <> "" Then
            Dim FileDiag As New OpenFileDialog
            Dim IncomingFile As String
            Dim DestinationPath As String = "Q:\Warehouse Files\Uploaded Files\General Medical Records\"
            Dim DestinationFile As String
            Dim incomingType As String
            Dim infoReader As FileInfo
            FileDiag.ShowDialog()
            IncomingFile = FileDiag.FileName
            If IncomingFile <> "" Then
                seqNum = getNextSeqNum()
                infoReader = Computer.FileSystem.GetFileInfo(IncomingFile)
                incomingType = infoReader.Extension
                DestinationFile = subNum.ToString & "-" & seqNum & incomingType
                File.Copy(IncomingFile, DestinationPath & DestinationFile, True)
                Dim query As New SqlCommand("", WarehouseShell.conn)
                Dim cmdText As String = "Insert into filePointerMedicalRecords (SubNum, ResearchTeam, SeqNum, Description, FileName, UploadDate, UploadedBy)" &
                    "values (" & subNum & ", '" & researchTeam & "', " & seqNum & ", " & txtDescription.getSQLValue & ", '" & DestinationFile & "', '" & Now.Date() & "', '" & WarehouseShell.userName & "');"
                query.CommandText = cmdText
                query.ExecuteNonQuery()
            End If
            FileDiag.Dispose()
            result = DialogResult.OK
            Hide()
        Else
            MsgBox("Please provide a Description for this file.")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        result = DialogResult.Cancel
        Hide()
    End Sub
End Class