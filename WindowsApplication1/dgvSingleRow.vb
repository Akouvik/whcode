Public Class dgvSingleRow
    Inherits DataGridView

    Public Sub New()
        MyBase.New()
        Dim newPadding As New Padding(0, 0, 0, 0)

        [ReadOnly] = True
        AllowUserToAddRows = False
        AllowUserToDeleteRows = False
        AllowUserToResizeRows = True
        AllowUserToResizeColumns = True
        AllowUserToOrderColumns = True
        AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
        Anchor = AnchorStyles.Top
        Anchor = AnchorStyles.Left
        BackgroundColor = Color.Tan
        BorderStyle = BorderStyle.FixedSingle
        ColumnHeadersDefaultCellStyle.Padding = newPadding
        ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False
        DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue
        DefaultCellStyle.SelectionForeColor = Color.Black
        DefaultCellStyle.WrapMode = DataGridViewTriState.False
        GridColor = Color.Linen
        Height = 45
        MultiSelect = False
        RowHeadersVisible = False
        RowTemplate.DefaultCellStyle.Padding = newPadding
        SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Width = 1010
    End Sub
End Class