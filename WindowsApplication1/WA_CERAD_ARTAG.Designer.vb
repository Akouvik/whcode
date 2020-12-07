<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WA_CERAD_ARTAG
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ARTAG_Severity = New DataWarehouse.ComboBox_()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AmygdalaSubpial = New DataWarehouse.ComboBox_()
        Me.AmygdalaSubependymal = New DataWarehouse.ComboBox_()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AmygdalaGrayMatter = New DataWarehouse.ComboBox_()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AmygdalaWhiteMatter = New DataWarehouse.ComboBox_()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AmygdalaPerivascular = New DataWarehouse.ComboBox_()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FrontNeoPerivascular = New DataWarehouse.ComboBox_()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FrontNeoWhiteMatter = New DataWarehouse.ComboBox_()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FrontNeoGrayMatter = New DataWarehouse.ComboBox_()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FrontNeoSubependymal = New DataWarehouse.ComboBox_()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.FrontNeoSubpial = New DataWarehouse.ComboBox_()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BasGangPerivascular = New DataWarehouse.ComboBox_()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BasGangWhiteMatter = New DataWarehouse.ComboBox_()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BasGangGrayMatter = New DataWarehouse.ComboBox_()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.BasGangSubependymal = New DataWarehouse.ComboBox_()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.BasGangSubpial = New DataWarehouse.ComboBox_()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.MedOblPerivascular = New DataWarehouse.ComboBox_()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.MedOblWhiteMatter = New DataWarehouse.ComboBox_()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.MedOblGrayMatter = New DataWarehouse.ComboBox_()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.MedOblSubependymal = New DataWarehouse.ComboBox_()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.MedOblSubpial = New DataWarehouse.ComboBox_()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.PathAffectDepthSulci = New DataWarehouse.ComboBox_()
        Me.PathAffectGyralBankCrest = New DataWarehouse.ComboBox_()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.btnARTAGTop = New DataWarehouse.Button_()
        Me.btnARTAGBottom = New DataWarehouse.Button_()
        Me.lblNoRecord = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(516, 29)
        Me.Label1.TabIndex = 196
        Me.Label1.Text = "Aging-Related Tau Astrogliopathy (ARTAG)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 13)
        Me.Label2.TabIndex = 197
        Me.Label2.Text = "a. Overall Severity of ARTAG pathology:"
        '
        'ARTAG_Severity
        '
        Me.ARTAG_Severity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ARTAG_Severity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ARTAG_Severity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ARTAG_Severity.FormattingEnabled = True
        Me.ARTAG_Severity.Location = New System.Drawing.Point(208, 60)
        Me.ARTAG_Severity.Name = "ARTAG_Severity"
        Me.ARTAG_Severity.Size = New System.Drawing.Size(121, 21)
        Me.ARTAG_Severity.TabIndex = 102
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(267, 13)
        Me.Label3.TabIndex = 199
        Me.Label3.Text = "b. Localization of ARTAG pathology in the AMYGDALA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 200
        Me.Label4.Text = "Subpial"
        '
        'AmygdalaSubpial
        '
        Me.AmygdalaSubpial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.AmygdalaSubpial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.AmygdalaSubpial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AmygdalaSubpial.FormattingEnabled = True
        Me.AmygdalaSubpial.Location = New System.Drawing.Point(127, 103)
        Me.AmygdalaSubpial.Name = "AmygdalaSubpial"
        Me.AmygdalaSubpial.Size = New System.Drawing.Size(194, 21)
        Me.AmygdalaSubpial.TabIndex = 103
        '
        'AmygdalaSubependymal
        '
        Me.AmygdalaSubependymal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.AmygdalaSubependymal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.AmygdalaSubependymal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AmygdalaSubependymal.FormattingEnabled = True
        Me.AmygdalaSubependymal.Location = New System.Drawing.Point(127, 130)
        Me.AmygdalaSubependymal.Name = "AmygdalaSubependymal"
        Me.AmygdalaSubependymal.Size = New System.Drawing.Size(194, 21)
        Me.AmygdalaSubependymal.TabIndex = 104
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 202
        Me.Label5.Text = "Subependymal"
        '
        'AmygdalaGrayMatter
        '
        Me.AmygdalaGrayMatter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.AmygdalaGrayMatter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.AmygdalaGrayMatter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AmygdalaGrayMatter.FormattingEnabled = True
        Me.AmygdalaGrayMatter.Location = New System.Drawing.Point(127, 157)
        Me.AmygdalaGrayMatter.Name = "AmygdalaGrayMatter"
        Me.AmygdalaGrayMatter.Size = New System.Drawing.Size(194, 21)
        Me.AmygdalaGrayMatter.TabIndex = 105
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 204
        Me.Label6.Text = "Gray matter"
        '
        'AmygdalaWhiteMatter
        '
        Me.AmygdalaWhiteMatter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.AmygdalaWhiteMatter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.AmygdalaWhiteMatter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AmygdalaWhiteMatter.FormattingEnabled = True
        Me.AmygdalaWhiteMatter.Location = New System.Drawing.Point(127, 184)
        Me.AmygdalaWhiteMatter.Name = "AmygdalaWhiteMatter"
        Me.AmygdalaWhiteMatter.Size = New System.Drawing.Size(194, 21)
        Me.AmygdalaWhiteMatter.TabIndex = 106
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 206
        Me.Label7.Text = "White matter"
        '
        'AmygdalaPerivascular
        '
        Me.AmygdalaPerivascular.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.AmygdalaPerivascular.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.AmygdalaPerivascular.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AmygdalaPerivascular.FormattingEnabled = True
        Me.AmygdalaPerivascular.Location = New System.Drawing.Point(127, 211)
        Me.AmygdalaPerivascular.Name = "AmygdalaPerivascular"
        Me.AmygdalaPerivascular.Size = New System.Drawing.Size(194, 21)
        Me.AmygdalaPerivascular.TabIndex = 107
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(44, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 208
        Me.Label8.Text = "Perivascular"
        '
        'FrontNeoPerivascular
        '
        Me.FrontNeoPerivascular.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.FrontNeoPerivascular.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FrontNeoPerivascular.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FrontNeoPerivascular.FormattingEnabled = True
        Me.FrontNeoPerivascular.Location = New System.Drawing.Point(127, 362)
        Me.FrontNeoPerivascular.Name = "FrontNeoPerivascular"
        Me.FrontNeoPerivascular.Size = New System.Drawing.Size(194, 21)
        Me.FrontNeoPerivascular.TabIndex = 112
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(44, 365)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 219
        Me.Label9.Text = "Perivascular"
        '
        'FrontNeoWhiteMatter
        '
        Me.FrontNeoWhiteMatter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.FrontNeoWhiteMatter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FrontNeoWhiteMatter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FrontNeoWhiteMatter.FormattingEnabled = True
        Me.FrontNeoWhiteMatter.Location = New System.Drawing.Point(127, 335)
        Me.FrontNeoWhiteMatter.Name = "FrontNeoWhiteMatter"
        Me.FrontNeoWhiteMatter.Size = New System.Drawing.Size(194, 21)
        Me.FrontNeoWhiteMatter.TabIndex = 111
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(44, 338)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 217
        Me.Label10.Text = "White matter"
        '
        'FrontNeoGrayMatter
        '
        Me.FrontNeoGrayMatter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.FrontNeoGrayMatter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FrontNeoGrayMatter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FrontNeoGrayMatter.FormattingEnabled = True
        Me.FrontNeoGrayMatter.Location = New System.Drawing.Point(127, 308)
        Me.FrontNeoGrayMatter.Name = "FrontNeoGrayMatter"
        Me.FrontNeoGrayMatter.Size = New System.Drawing.Size(194, 21)
        Me.FrontNeoGrayMatter.TabIndex = 110
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(44, 311)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 215
        Me.Label11.Text = "Gray matter"
        '
        'FrontNeoSubependymal
        '
        Me.FrontNeoSubependymal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.FrontNeoSubependymal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FrontNeoSubependymal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FrontNeoSubependymal.FormattingEnabled = True
        Me.FrontNeoSubependymal.Location = New System.Drawing.Point(127, 281)
        Me.FrontNeoSubependymal.Name = "FrontNeoSubependymal"
        Me.FrontNeoSubependymal.Size = New System.Drawing.Size(194, 21)
        Me.FrontNeoSubependymal.TabIndex = 109
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(44, 284)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 13)
        Me.Label12.TabIndex = 213
        Me.Label12.Text = "Subependymal"
        '
        'FrontNeoSubpial
        '
        Me.FrontNeoSubpial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.FrontNeoSubpial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FrontNeoSubpial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FrontNeoSubpial.FormattingEnabled = True
        Me.FrontNeoSubpial.Location = New System.Drawing.Point(127, 254)
        Me.FrontNeoSubpial.Name = "FrontNeoSubpial"
        Me.FrontNeoSubpial.Size = New System.Drawing.Size(194, 21)
        Me.FrontNeoSubpial.TabIndex = 108
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(44, 257)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 13)
        Me.Label13.TabIndex = 211
        Me.Label13.Text = "Subpial"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(5, 238)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(328, 13)
        Me.Label14.TabIndex = 210
        Me.Label14.Text = "c. Localization of ARTAG pathology in the FRONTAL NEOCORTEX"
        '
        'BasGangPerivascular
        '
        Me.BasGangPerivascular.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.BasGangPerivascular.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BasGangPerivascular.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BasGangPerivascular.FormattingEnabled = True
        Me.BasGangPerivascular.Location = New System.Drawing.Point(127, 513)
        Me.BasGangPerivascular.Name = "BasGangPerivascular"
        Me.BasGangPerivascular.Size = New System.Drawing.Size(194, 21)
        Me.BasGangPerivascular.TabIndex = 117
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(44, 516)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 13)
        Me.Label15.TabIndex = 230
        Me.Label15.Text = "Perivascular"
        '
        'BasGangWhiteMatter
        '
        Me.BasGangWhiteMatter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.BasGangWhiteMatter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BasGangWhiteMatter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BasGangWhiteMatter.FormattingEnabled = True
        Me.BasGangWhiteMatter.Location = New System.Drawing.Point(127, 486)
        Me.BasGangWhiteMatter.Name = "BasGangWhiteMatter"
        Me.BasGangWhiteMatter.Size = New System.Drawing.Size(194, 21)
        Me.BasGangWhiteMatter.TabIndex = 116
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(44, 489)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 13)
        Me.Label16.TabIndex = 228
        Me.Label16.Text = "White matter"
        '
        'BasGangGrayMatter
        '
        Me.BasGangGrayMatter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.BasGangGrayMatter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BasGangGrayMatter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BasGangGrayMatter.FormattingEnabled = True
        Me.BasGangGrayMatter.Location = New System.Drawing.Point(127, 459)
        Me.BasGangGrayMatter.Name = "BasGangGrayMatter"
        Me.BasGangGrayMatter.Size = New System.Drawing.Size(194, 21)
        Me.BasGangGrayMatter.TabIndex = 115
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(44, 462)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 13)
        Me.Label17.TabIndex = 226
        Me.Label17.Text = "Gray matter"
        '
        'BasGangSubependymal
        '
        Me.BasGangSubependymal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.BasGangSubependymal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BasGangSubependymal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BasGangSubependymal.FormattingEnabled = True
        Me.BasGangSubependymal.Location = New System.Drawing.Point(127, 432)
        Me.BasGangSubependymal.Name = "BasGangSubependymal"
        Me.BasGangSubependymal.Size = New System.Drawing.Size(194, 21)
        Me.BasGangSubependymal.TabIndex = 114
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(44, 435)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(77, 13)
        Me.Label18.TabIndex = 224
        Me.Label18.Text = "Subependymal"
        '
        'BasGangSubpial
        '
        Me.BasGangSubpial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.BasGangSubpial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BasGangSubpial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BasGangSubpial.FormattingEnabled = True
        Me.BasGangSubpial.Location = New System.Drawing.Point(127, 405)
        Me.BasGangSubpial.Name = "BasGangSubpial"
        Me.BasGangSubpial.Size = New System.Drawing.Size(194, 21)
        Me.BasGangSubpial.TabIndex = 113
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(44, 408)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 13)
        Me.Label19.TabIndex = 222
        Me.Label19.Text = "Subpial"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(5, 389)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(292, 13)
        Me.Label20.TabIndex = 221
        Me.Label20.Text = "d. Localization of ARTAG pathology in the BASAL GANGLIA"
        '
        'MedOblPerivascular
        '
        Me.MedOblPerivascular.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.MedOblPerivascular.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.MedOblPerivascular.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MedOblPerivascular.FormattingEnabled = True
        Me.MedOblPerivascular.Location = New System.Drawing.Point(127, 664)
        Me.MedOblPerivascular.Name = "MedOblPerivascular"
        Me.MedOblPerivascular.Size = New System.Drawing.Size(194, 21)
        Me.MedOblPerivascular.TabIndex = 122
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(44, 667)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(65, 13)
        Me.Label21.TabIndex = 241
        Me.Label21.Text = "Perivascular"
        '
        'MedOblWhiteMatter
        '
        Me.MedOblWhiteMatter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.MedOblWhiteMatter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.MedOblWhiteMatter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MedOblWhiteMatter.FormattingEnabled = True
        Me.MedOblWhiteMatter.Location = New System.Drawing.Point(127, 637)
        Me.MedOblWhiteMatter.Name = "MedOblWhiteMatter"
        Me.MedOblWhiteMatter.Size = New System.Drawing.Size(194, 21)
        Me.MedOblWhiteMatter.TabIndex = 121
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(44, 640)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(67, 13)
        Me.Label22.TabIndex = 239
        Me.Label22.Text = "White matter"
        '
        'MedOblGrayMatter
        '
        Me.MedOblGrayMatter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.MedOblGrayMatter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.MedOblGrayMatter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MedOblGrayMatter.FormattingEnabled = True
        Me.MedOblGrayMatter.Location = New System.Drawing.Point(127, 610)
        Me.MedOblGrayMatter.Name = "MedOblGrayMatter"
        Me.MedOblGrayMatter.Size = New System.Drawing.Size(194, 21)
        Me.MedOblGrayMatter.TabIndex = 120
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(44, 613)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(61, 13)
        Me.Label23.TabIndex = 237
        Me.Label23.Text = "Gray matter"
        '
        'MedOblSubependymal
        '
        Me.MedOblSubependymal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.MedOblSubependymal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.MedOblSubependymal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MedOblSubependymal.FormattingEnabled = True
        Me.MedOblSubependymal.Location = New System.Drawing.Point(127, 583)
        Me.MedOblSubependymal.Name = "MedOblSubependymal"
        Me.MedOblSubependymal.Size = New System.Drawing.Size(194, 21)
        Me.MedOblSubependymal.TabIndex = 119
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(44, 586)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(77, 13)
        Me.Label24.TabIndex = 235
        Me.Label24.Text = "Subependymal"
        '
        'MedOblSubpial
        '
        Me.MedOblSubpial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.MedOblSubpial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.MedOblSubpial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MedOblSubpial.FormattingEnabled = True
        Me.MedOblSubpial.Location = New System.Drawing.Point(127, 556)
        Me.MedOblSubpial.Name = "MedOblSubpial"
        Me.MedOblSubpial.Size = New System.Drawing.Size(194, 21)
        Me.MedOblSubpial.TabIndex = 118
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(44, 559)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(42, 13)
        Me.Label25.TabIndex = 233
        Me.Label25.Text = "Subpial"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(5, 540)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(328, 13)
        Me.Label26.TabIndex = 232
        Me.Label26.Text = "e. Localization of ARTAG pathology in the MEDULLA OBLONGATA"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(5, 691)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(458, 13)
        Me.Label27.TabIndex = 243
        Me.Label27.Text = "f. If ARTAG pathology affects lobar subpial or lobar gray matter, does it affect " &
    "the depth of sulci?"
        '
        'PathAffectDepthSulci
        '
        Me.PathAffectDepthSulci.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PathAffectDepthSulci.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PathAffectDepthSulci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PathAffectDepthSulci.FormattingEnabled = True
        Me.PathAffectDepthSulci.Location = New System.Drawing.Point(479, 688)
        Me.PathAffectDepthSulci.Name = "PathAffectDepthSulci"
        Me.PathAffectDepthSulci.Size = New System.Drawing.Size(121, 21)
        Me.PathAffectDepthSulci.TabIndex = 123
        '
        'PathAffectGyralBankCrest
        '
        Me.PathAffectGyralBankCrest.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PathAffectGyralBankCrest.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PathAffectGyralBankCrest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PathAffectGyralBankCrest.FormattingEnabled = True
        Me.PathAffectGyralBankCrest.Location = New System.Drawing.Point(479, 715)
        Me.PathAffectGyralBankCrest.Name = "PathAffectGyralBankCrest"
        Me.PathAffectGyralBankCrest.Size = New System.Drawing.Size(121, 21)
        Me.PathAffectGyralBankCrest.TabIndex = 124
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(5, 718)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(468, 13)
        Me.Label28.TabIndex = 245
        Me.Label28.Text = "g. If ARTAG pathology affects lobar subpial or lobar gray matter, is it along the" &
    " gyral bank or crest?"
        '
        'btnARTAGTop
        '
        Me.btnARTAGTop.Location = New System.Drawing.Point(3, 35)
        Me.btnARTAGTop.Name = "btnARTAGTop"
        Me.btnARTAGTop.Size = New System.Drawing.Size(121, 23)
        Me.btnARTAGTop.TabIndex = 101
        Me.btnARTAGTop.Text = "Button_1"
        Me.btnARTAGTop.UseVisualStyleBackColor = True
        '
        'btnARTAGBottom
        '
        Me.btnARTAGBottom.Location = New System.Drawing.Point(3, 740)
        Me.btnARTAGBottom.Name = "btnARTAGBottom"
        Me.btnARTAGBottom.Size = New System.Drawing.Size(121, 23)
        Me.btnARTAGBottom.TabIndex = 125
        Me.btnARTAGBottom.Text = "Button_2"
        Me.btnARTAGBottom.UseVisualStyleBackColor = True
        '
        'lblNoRecord
        '
        Me.lblNoRecord.AutoSize = True
        Me.lblNoRecord.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lblNoRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNoRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoRecord.Location = New System.Drawing.Point(4, 61)
        Me.lblNoRecord.Name = "lblNoRecord"
        Me.lblNoRecord.Size = New System.Drawing.Size(596, 64)
        Me.lblNoRecord.TabIndex = 1157
        Me.lblNoRecord.Text = "No ARTAG exists for this subject" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click ""Add New Record"" above to create one"
        Me.lblNoRecord.Visible = False
        '
        'WA_CERAD_ARTAG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.Controls.Add(Me.lblNoRecord)
        Me.Controls.Add(Me.btnARTAGBottom)
        Me.Controls.Add(Me.btnARTAGTop)
        Me.Controls.Add(Me.PathAffectGyralBankCrest)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.PathAffectDepthSulci)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.MedOblPerivascular)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.MedOblWhiteMatter)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.MedOblGrayMatter)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.MedOblSubependymal)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.MedOblSubpial)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.BasGangPerivascular)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.BasGangWhiteMatter)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.BasGangGrayMatter)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.BasGangSubependymal)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.BasGangSubpial)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.FrontNeoPerivascular)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.FrontNeoWhiteMatter)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.FrontNeoGrayMatter)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.FrontNeoSubependymal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.FrontNeoSubpial)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.AmygdalaPerivascular)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.AmygdalaWhiteMatter)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.AmygdalaGrayMatter)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.AmygdalaSubependymal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AmygdalaSubpial)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ARTAG_Severity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WA_CERAD_ARTAG"
        Me.Size = New System.Drawing.Size(611, 766)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ARTAG_Severity As ComboBox_
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents AmygdalaSubpial As ComboBox_
    Friend WithEvents AmygdalaSubependymal As ComboBox_
    Friend WithEvents Label5 As Label
    Friend WithEvents AmygdalaGrayMatter As ComboBox_
    Friend WithEvents Label6 As Label
    Friend WithEvents AmygdalaWhiteMatter As ComboBox_
    Friend WithEvents Label7 As Label
    Friend WithEvents AmygdalaPerivascular As ComboBox_
    Friend WithEvents Label8 As Label
    Friend WithEvents FrontNeoPerivascular As ComboBox_
    Friend WithEvents Label9 As Label
    Friend WithEvents FrontNeoWhiteMatter As ComboBox_
    Friend WithEvents Label10 As Label
    Friend WithEvents FrontNeoGrayMatter As ComboBox_
    Friend WithEvents Label11 As Label
    Friend WithEvents FrontNeoSubependymal As ComboBox_
    Friend WithEvents Label12 As Label
    Friend WithEvents FrontNeoSubpial As ComboBox_
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents BasGangPerivascular As ComboBox_
    Friend WithEvents Label15 As Label
    Friend WithEvents BasGangWhiteMatter As ComboBox_
    Friend WithEvents Label16 As Label
    Friend WithEvents BasGangGrayMatter As ComboBox_
    Friend WithEvents Label17 As Label
    Friend WithEvents BasGangSubependymal As ComboBox_
    Friend WithEvents Label18 As Label
    Friend WithEvents BasGangSubpial As ComboBox_
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents MedOblPerivascular As ComboBox_
    Friend WithEvents Label21 As Label
    Friend WithEvents MedOblWhiteMatter As ComboBox_
    Friend WithEvents Label22 As Label
    Friend WithEvents MedOblGrayMatter As ComboBox_
    Friend WithEvents Label23 As Label
    Friend WithEvents MedOblSubependymal As ComboBox_
    Friend WithEvents Label24 As Label
    Friend WithEvents MedOblSubpial As ComboBox_
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents PathAffectDepthSulci As ComboBox_
    Friend WithEvents PathAffectGyralBankCrest As ComboBox_
    Friend WithEvents Label28 As Label
    Friend WithEvents btnARTAGTop As Button_
    Friend WithEvents btnARTAGBottom As Button_
    Friend WithEvents lblNoRecord As Label
End Class
