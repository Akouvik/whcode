Public Class PU_NoKReconcile

    Private formTables As New DataSet

    Public Sub New(ByVal Name As String, ByVal Relation As Integer, ByVal RelationSpec As String, ByVal Add1 As String, ByVal Add2 As String, ByVal Add3 As String, ByVal City As String, ByVal State As String, ByVal Zip As String, ByVal Home As String, ByVal Mobile As String, ByVal Work As String, ByVal Email As String)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        formTables.Tables.Add(Database.ReturnTable("lkpRelation"))
        cmbNokRelationNew.assignLookup(formTables, "lkpRelation")
        txtNoKNameNew.Text = Name
        cmbNokRelationNew.SelectedValue = Relation
        txtNokRelationSpecNew.Text = RelationSpec
        txtNoKAdd1New.Text = Add1
        txtNoKAdd2New.Text = Add2
        txtNoKAdd3New.Text = Add3
        txtNoKCityNew.Text = City
        txtNoKStateNew.Text = State
        txtNoKZipNew.Text = Zip
        txtNoKHomePhoneNew.Text = Home
        txtNoKMobilePhoneNew.Text = Mobile
        txtNoKWorkPhoneNew.Text = Work
        txtNoKEmailNew.Text = Email
    End Sub
    Private Sub PU_NoKReconcile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formTables.Tables.Add(Database.ReturnTable("NoK",, "SubNum = " & WarehouseShell.SubNum))
        cmbNoKRelationOld.assignLookup(formTables, "lkpRelation")
        txtNoKNameOld.setValue(formTables, "NoK", "NoKName")
        cmbNoKRelationOld.setValue(formTables, "NoK", "NoKRelationValue")
        txtNoKRelationsSpecOld.setValue(formTables, "NoK", "NoKRelationSpec")
        txtNoKAdd1Old.setValue(formTables, "NoK", "NoKAddress1")
        txtNoKAdd2Old.setValue(formTables, "NoK", "NoKAddress2")
        txtNoKAdd3Old.setValue(formTables, "NoK", "NoKAddress3")
        txtNoKCityOld.setValue(formTables, "NoK", "NoKCity")
        txtNoKStateOld.setValue(formTables, "NoK", "NoKState")
        txtNoKZipOld.setValue(formTables, "NoK", "NoKZip")
        txtNoKHomePhoneOld.setValue(formTables, "NoK", "NoKHomePhone")
        txtNoKMobilePhoneOld.setValue(formTables, "NoK", "NoKMobilePhone")
        txtNoKWorkPhoneOld.setValue(formTables, "NoK", "NoKWorkPhone")
        txtNoKEmailOld.setValue(formTables, "NoK", "NoKEmail")
    End Sub

    Private Sub btnOverwrite_Click(sender As Object, e As EventArgs) Handles btnOverwrite.Click
        Dim cmd As New SqlCommand
        cmd.Connection = WarehouseShell.conn
        cmd.CommandText = "Update NoK set " &
            "NoKName = " & txtNoKNameNew.getSQLValue() &
            ", NoKRelationValue = " & cmbNokRelationNew.getSQLValue() &
            ", NoKRelationSpec = " & txtNokRelationSpecNew.getSQLValue() &
            ", NoKAddress1 = " & txtNoKAdd1New.getSQLValue() &
            ", NoKAddress2 = " & txtNoKAdd2New.getSQLValue() &
            ", NoKAddress3 = " & txtNoKAdd3New.getSQLValue() &
            ", NoKCity = " & txtNoKCityNew.getSQLValue() &
            ", NoKState = " & txtNoKStateNew.getSQLValue() &
            ", NoKZip = " & txtNoKZipNew.getSQLValue() &
            ", NoKHomePhone = " & txtNoKHomePhoneNew.getSQLValue() &
            ", NoKMobilePhone = " & txtNoKMobilePhoneNew.getSQLValue() &
            ", NoKWorkPhone = " & txtNoKWorkPhoneNew.getSQLValue() &
            ", NoKEmail = " & txtNoKEmailNew.getSQLValue() &
            " where SubNum = " & WarehouseShell.SubNum & ";"
        Try
            cmd.ExecuteNonQuery()
            Me.DialogResult = 1
        Catch ex As SqlException
            ExceptionHandler.CatchSQLException(ex)
        End Try
    End Sub

    Private Sub btnReplace_Click(sender As Object, e As EventArgs) Handles btnReplace.Click
        Dim cmd As New SqlCommand
        cmd.Connection = WarehouseShell.conn
        cmd.CommandText = "Update NoK set " &
            "AltPOCName = NoKName" &
            ", AltPOCRelationValue = NoKRelationValue" &
            ", AltPOCRelationSpec = NoKRelationSpec" &
            ", AltPOCAddress1 = NoKAddress1" &
            ", AltPOCAddress2 = NoKAddress2" &
            ", AltPOCAddress3 = NoKAddress3" &
            ", AltPOCCity = NoKCity" &
            ", AltPOCState = NoKState" &
            ", AltPOCZip = NoKZip" &
            ", AltPOCHomePhone = NoKHomePhone" &
            ", AltPOCMobilePhone = NoKMobilePhone" &
            ", AltPOCWorkPhone = NoKWorkPhone" &
            ", AltPOCEmail = NoKEmail" &
            ", NoKName = " & txtNoKNameNew.getSQLValue() &
            ", NoKRelationValue = " & cmbNokRelationNew.getSQLValue() &
            ", NoKRelationSpec = " & txtNokRelationSpecNew.getSQLValue() &
            ", NoKAddress1 = " & txtNoKAdd1New.getSQLValue() &
            ", NoKAddress2 = " & txtNoKAdd2New.getSQLValue() &
            ", NoKAddress3 = " & txtNoKAdd3New.getSQLValue() &
            ", NoKCity = " & txtNoKCityNew.getSQLValue() &
            ", NoKState = " & txtNoKStateNew.getSQLValue() &
            ", NoKZip = " & txtNoKZipNew.getSQLValue() &
            ", NoKHomePhone = " & txtNoKHomePhoneNew.getSQLValue() &
            ", NoKMobilePhone = " & txtNoKMobilePhoneNew.getSQLValue() &
            ", NoKWorkPhone = " & txtNoKWorkPhoneNew.getSQLValue() &
            ", NoKEmail = " & txtNoKEmailNew.getSQLValue() &
            " where SubNum = " & WarehouseShell.SubNum & ";"
        Try
            cmd.ExecuteNonQuery()
            Me.DialogResult = 2
        Catch ex As SqlException
            ExceptionHandler.CatchSQLException(ex)
        End Try
    End Sub
    Private Sub btnKeepExisting_Click(sender As Object, e As EventArgs) Handles btnKeepExisting.Click
        Me.DialogResult = 3
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = 4
    End Sub
End Class