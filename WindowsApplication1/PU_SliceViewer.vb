Imports System.IO

Public Class PU_SliceViewer
    Implements IFormMethods
    Dim ImageNum As Integer = 0

    'Define on-load actions
    Private Sub PU_SliceViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getImage(ImageNum)
        lblPictureTitle.Text = "Brain Image"
    End Sub

    'Define button click events
    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        ImageNum = 0
        getImage(ImageNum)
        lblPictureTitle.Text = "Brain"
        btnPrev.Enabled = False
        btnNext.Enabled = True
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ImageNum = ImageNum + 1
        getImage(ImageNum)
        If ImageNum = 33 Then
            btnNext.Enabled = False
        ElseIf ImageNum = 1 Then
            btnPrev.Enabled = True
            lblPictureTitle.Text = "Brain Image"
        End If
        lblPictureTitle.Text = "Map Level " & ImageNum.ToString
    End Sub
    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        ImageNum = ImageNum - 1
        getImage(ImageNum)
        If ImageNum = 32 Then
            btnNext.Enabled = True
            lblPictureTitle.Text = "Map Level " & ImageNum.ToString
        ElseIf ImageNum = 0 Then
            btnPrev.Enabled = False
            lblPictureTitle.Text = "Brain Image"
        Else
            lblPictureTitle.Text = "Map Level " & ImageNum.ToString
        End If
    End Sub
    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        ImageNum = 33
        getImage(ImageNum)
        lblPictureTitle.Text = "Map Level 33"
        btnNext.Enabled = False
        btnPrev.Enabled = True
    End Sub

    'Sub to grab pictures for display
    Private Sub getImage(myImageNum As Integer)
        Dim ImageName As String
        'All images are named "Map Level X" except for the "Brain" image. THis if statement solves that.
        If ImageNum = 0 Then
            ImageName = "Brain"
        Else
            ImageName = "Map Level " & ImageNum.ToString
        End If
        'Grab the FileStream binary string for the above named file.
        Dim cmd As New SqlCommand("Select FileData from fileAutopsyMapLevels where Description = '" & ImageName & "';", WarehouseShell.conn)
        'Define a data reader and read the binary file into it.
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        dr.Read()
        'The next three lines turn the binary file into a byte array and load it into RAM (I don't completely understand this part).
        Dim b(dr.GetBytes(0, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
        dr.GetBytes(0, 0, b, 0, b.Length)
        Dim BLOBData As New MemoryStream(b)
        'Load the byte array as an image into the form picture box and close the data reader (to release the system resources).
        pbxPicture.Image = Drawing.Image.FromStream(BLOBData)
        dr.Close()
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
        TopLevel = val
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class