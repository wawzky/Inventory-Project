<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProduct
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_search = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_location = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_price = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_delete = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_edit = New Guna.UI2.WinForms.Guna2Button()
        Me.btm_save = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_addUOM = New Guna.UI2.WinForms.Guna2Button()
        Me.combo_UOM = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btm_addproductgroup = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_productcode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.combo_productGroup = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txt_productname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_refresh = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_proID = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_search
        '
        Me.txt_search.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_search.Animated = True
        Me.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_search.DefaultText = ""
        Me.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_search.DisabledState.Parent = Me.txt_search
        Me.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_search.FocusedState.Parent = Me.txt_search
        Me.txt_search.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_search.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_search.ForeColor = System.Drawing.Color.Black
        Me.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_search.HoverState.Parent = Me.txt_search
        Me.txt_search.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_search.Location = New System.Drawing.Point(159, 316)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(80, 3, 3, 3)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_search.PlaceholderText = "Search...."
        Me.txt_search.SelectedText = ""
        Me.txt_search.ShadowDecoration.Parent = Me.txt_search
        Me.txt_search.Size = New System.Drawing.Size(267, 36)
        Me.txt_search.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_search.TabIndex = 5
        '
        'txt_location
        '
        Me.txt_location.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_location.Animated = True
        Me.txt_location.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_location.DefaultText = ""
        Me.txt_location.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_location.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_location.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_location.DisabledState.Parent = Me.txt_location
        Me.txt_location.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_location.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_location.FocusedState.Parent = Me.txt_location
        Me.txt_location.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_location.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_location.ForeColor = System.Drawing.Color.Black
        Me.txt_location.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_location.HoverState.Parent = Me.txt_location
        Me.txt_location.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_location.Location = New System.Drawing.Point(511, 230)
        Me.txt_location.Name = "txt_location"
        Me.txt_location.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_location.PlaceholderText = "Location"
        Me.txt_location.SelectedText = ""
        Me.txt_location.ShadowDecoration.Parent = Me.txt_location
        Me.txt_location.Size = New System.Drawing.Size(267, 36)
        Me.txt_location.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_location.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.Location = New System.Drawing.Point(159, 370)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(619, 208)
        Me.DataGridView1.TabIndex = 42
        Me.DataGridView1.TabStop = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "proid"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "ProductCode"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 112
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "ProductName"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Group"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 71
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "UOM"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 64
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Price"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 62
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "Location"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 84
        '
        'txt_price
        '
        Me.txt_price.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_price.Animated = True
        Me.txt_price.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_price.DefaultText = ""
        Me.txt_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_price.DisabledState.Parent = Me.txt_price
        Me.txt_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_price.FocusedState.Parent = Me.txt_price
        Me.txt_price.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_price.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_price.ForeColor = System.Drawing.Color.Black
        Me.txt_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_price.HoverState.Parent = Me.txt_price
        Me.txt_price.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_price.Location = New System.Drawing.Point(159, 230)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_price.PlaceholderText = "Price"
        Me.txt_price.SelectedText = ""
        Me.txt_price.ShadowDecoration.Parent = Me.txt_price
        Me.txt_price.Size = New System.Drawing.Size(267, 36)
        Me.txt_price.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_price.TabIndex = 3
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_delete.Animated = True
        Me.btn_delete.AnimatedGIF = True
        Me.btn_delete.BorderColor = System.Drawing.Color.White
        Me.btn_delete.BorderRadius = 5
        Me.btn_delete.BorderThickness = 1
        Me.btn_delete.CheckedState.Parent = Me.btn_delete
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.CustomImages.Parent = Me.btn_delete
        Me.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_delete.DisabledState.Parent = Me.btn_delete
        Me.btn_delete.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btn_delete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btn_delete.HoverState.FillColor = System.Drawing.Color.Red
        Me.btn_delete.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btn_delete.HoverState.Parent = Me.btn_delete
        Me.btn_delete.Location = New System.Drawing.Point(703, 320)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.PressedColor = System.Drawing.Color.White
        Me.btn_delete.ShadowDecoration.Parent = Me.btn_delete
        Me.btn_delete.Size = New System.Drawing.Size(75, 32)
        Me.btn_delete.TabIndex = 8
        Me.btn_delete.Text = "Delete"
        '
        'btn_edit
        '
        Me.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_edit.Animated = True
        Me.btn_edit.AnimatedGIF = True
        Me.btn_edit.BorderColor = System.Drawing.Color.White
        Me.btn_edit.BorderRadius = 5
        Me.btn_edit.BorderThickness = 1
        Me.btn_edit.CheckedState.Parent = Me.btn_edit
        Me.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit.CustomImages.Parent = Me.btn_edit
        Me.btn_edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_edit.DisabledState.Parent = Me.btn_edit
        Me.btn_edit.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btn_edit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_edit.ForeColor = System.Drawing.Color.White
        Me.btn_edit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btn_edit.HoverState.FillColor = System.Drawing.Color.Blue
        Me.btn_edit.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btn_edit.HoverState.Parent = Me.btn_edit
        Me.btn_edit.Location = New System.Drawing.Point(611, 320)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.PressedColor = System.Drawing.Color.White
        Me.btn_edit.ShadowDecoration.Parent = Me.btn_edit
        Me.btn_edit.Size = New System.Drawing.Size(86, 32)
        Me.btn_edit.TabIndex = 7
        Me.btn_edit.Text = "Edit"
        '
        'btm_save
        '
        Me.btm_save.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btm_save.Animated = True
        Me.btm_save.AnimatedGIF = True
        Me.btm_save.BorderColor = System.Drawing.Color.White
        Me.btm_save.BorderRadius = 5
        Me.btm_save.BorderThickness = 1
        Me.btm_save.CheckedState.Parent = Me.btm_save
        Me.btm_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btm_save.CustomImages.Parent = Me.btm_save
        Me.btm_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btm_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btm_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btm_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btm_save.DisabledState.Parent = Me.btm_save
        Me.btm_save.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btm_save.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btm_save.ForeColor = System.Drawing.Color.White
        Me.btm_save.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btm_save.HoverState.FillColor = System.Drawing.Color.Green
        Me.btm_save.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btm_save.HoverState.Parent = Me.btm_save
        Me.btm_save.Location = New System.Drawing.Point(519, 320)
        Me.btm_save.Name = "btm_save"
        Me.btm_save.PressedColor = System.Drawing.Color.White
        Me.btm_save.ShadowDecoration.Parent = Me.btm_save
        Me.btm_save.Size = New System.Drawing.Size(86, 32)
        Me.btm_save.TabIndex = 6
        Me.btm_save.Text = "Save"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(516, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "UOM (kg., pc., in.)"
        '
        'btn_addUOM
        '
        Me.btn_addUOM.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_addUOM.Animated = True
        Me.btn_addUOM.AnimatedGIF = True
        Me.btn_addUOM.AutoRoundedCorners = True
        Me.btn_addUOM.BorderColor = System.Drawing.Color.White
        Me.btn_addUOM.BorderRadius = 14
        Me.btn_addUOM.BorderThickness = 1
        Me.btn_addUOM.CheckedState.Parent = Me.btn_addUOM
        Me.btn_addUOM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addUOM.CustomImages.Parent = Me.btn_addUOM
        Me.btn_addUOM.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_addUOM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_addUOM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_addUOM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_addUOM.DisabledState.Parent = Me.btn_addUOM
        Me.btn_addUOM.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btn_addUOM.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_addUOM.ForeColor = System.Drawing.Color.White
        Me.btn_addUOM.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btn_addUOM.HoverState.FillColor = System.Drawing.Color.White
        Me.btn_addUOM.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btn_addUOM.HoverState.Parent = Me.btn_addUOM
        Me.btn_addUOM.Location = New System.Drawing.Point(747, 177)
        Me.btn_addUOM.Name = "btn_addUOM"
        Me.btn_addUOM.PressedColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btn_addUOM.ShadowDecoration.Parent = Me.btn_addUOM
        Me.btn_addUOM.Size = New System.Drawing.Size(31, 32)
        Me.btn_addUOM.TabIndex = 35
        Me.btn_addUOM.TabStop = False
        Me.btn_addUOM.Text = "+"
        '
        'combo_UOM
        '
        Me.combo_UOM.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.combo_UOM.BackColor = System.Drawing.Color.Transparent
        Me.combo_UOM.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.combo_UOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_UOM.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combo_UOM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combo_UOM.FocusedState.Parent = Me.combo_UOM
        Me.combo_UOM.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.combo_UOM.ForeColor = System.Drawing.Color.Black
        Me.combo_UOM.FormattingEnabled = True
        Me.combo_UOM.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combo_UOM.HoverState.Parent = Me.combo_UOM
        Me.combo_UOM.ItemHeight = 30
        Me.combo_UOM.Items.AddRange(New Object() {"Nos"})
        Me.combo_UOM.ItemsAppearance.Parent = Me.combo_UOM
        Me.combo_UOM.Location = New System.Drawing.Point(511, 177)
        Me.combo_UOM.Name = "combo_UOM"
        Me.combo_UOM.ShadowDecoration.Parent = Me.combo_UOM
        Me.combo_UOM.Size = New System.Drawing.Size(230, 36)
        Me.combo_UOM.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.combo_UOM.TabIndex = 2
        Me.combo_UOM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btm_addproductgroup
        '
        Me.btm_addproductgroup.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btm_addproductgroup.Animated = True
        Me.btm_addproductgroup.AnimatedGIF = True
        Me.btm_addproductgroup.AutoRoundedCorners = True
        Me.btm_addproductgroup.BorderColor = System.Drawing.Color.White
        Me.btm_addproductgroup.BorderRadius = 14
        Me.btm_addproductgroup.BorderThickness = 1
        Me.btm_addproductgroup.CheckedState.Parent = Me.btm_addproductgroup
        Me.btm_addproductgroup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btm_addproductgroup.CustomImages.Parent = Me.btm_addproductgroup
        Me.btm_addproductgroup.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btm_addproductgroup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btm_addproductgroup.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btm_addproductgroup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btm_addproductgroup.DisabledState.Parent = Me.btm_addproductgroup
        Me.btm_addproductgroup.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btm_addproductgroup.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btm_addproductgroup.ForeColor = System.Drawing.Color.White
        Me.btm_addproductgroup.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btm_addproductgroup.HoverState.FillColor = System.Drawing.Color.White
        Me.btm_addproductgroup.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btm_addproductgroup.HoverState.Parent = Me.btm_addproductgroup
        Me.btm_addproductgroup.Location = New System.Drawing.Point(395, 181)
        Me.btm_addproductgroup.Name = "btm_addproductgroup"
        Me.btm_addproductgroup.PressedColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btm_addproductgroup.ShadowDecoration.Parent = Me.btm_addproductgroup
        Me.btm_addproductgroup.Size = New System.Drawing.Size(31, 32)
        Me.btm_addproductgroup.TabIndex = 33
        Me.btm_addproductgroup.TabStop = False
        Me.btm_addproductgroup.Text = "+"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(924, 60)
        Me.Panel1.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI Semilight", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(154, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.Label1.Size = New System.Drawing.Size(185, 48)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Manage Products"
        '
        'txt_productcode
        '
        Me.txt_productcode.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_productcode.Animated = True
        Me.txt_productcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_productcode.DefaultText = ""
        Me.txt_productcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_productcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_productcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_productcode.DisabledState.Parent = Me.txt_productcode
        Me.txt_productcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_productcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_productcode.FocusedState.Parent = Me.txt_productcode
        Me.txt_productcode.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_productcode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_productcode.ForeColor = System.Drawing.Color.Black
        Me.txt_productcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_productcode.HoverState.Parent = Me.txt_productcode
        Me.txt_productcode.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_productcode.Location = New System.Drawing.Point(159, 126)
        Me.txt_productcode.Margin = New System.Windows.Forms.Padding(80, 3, 3, 3)
        Me.txt_productcode.Name = "txt_productcode"
        Me.txt_productcode.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.txt_productcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_productcode.PlaceholderText = "Product Code"
        Me.txt_productcode.SelectedText = ""
        Me.txt_productcode.ShadowDecoration.Parent = Me.txt_productcode
        Me.txt_productcode.Size = New System.Drawing.Size(267, 36)
        Me.txt_productcode.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_productcode.TabIndex = 0
        Me.txt_productcode.TabStop = False
        '
        'combo_productGroup
        '
        Me.combo_productGroup.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.combo_productGroup.BackColor = System.Drawing.Color.Transparent
        Me.combo_productGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.combo_productGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_productGroup.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combo_productGroup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combo_productGroup.FocusedState.Parent = Me.combo_productGroup
        Me.combo_productGroup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.combo_productGroup.ForeColor = System.Drawing.Color.Black
        Me.combo_productGroup.FormattingEnabled = True
        Me.combo_productGroup.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combo_productGroup.HoverState.Parent = Me.combo_productGroup
        Me.combo_productGroup.ItemHeight = 30
        Me.combo_productGroup.ItemsAppearance.Parent = Me.combo_productGroup
        Me.combo_productGroup.Location = New System.Drawing.Point(159, 177)
        Me.combo_productGroup.Name = "combo_productGroup"
        Me.combo_productGroup.ShadowDecoration.Parent = Me.combo_productGroup
        Me.combo_productGroup.Size = New System.Drawing.Size(230, 36)
        Me.combo_productGroup.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.combo_productGroup.TabIndex = 1
        Me.combo_productGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_productname
        '
        Me.txt_productname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_productname.Animated = True
        Me.txt_productname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_productname.DefaultText = ""
        Me.txt_productname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_productname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_productname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_productname.DisabledState.Parent = Me.txt_productname
        Me.txt_productname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_productname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_productname.FocusedState.Parent = Me.txt_productname
        Me.txt_productname.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_productname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_productname.ForeColor = System.Drawing.Color.Black
        Me.txt_productname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_productname.HoverState.Parent = Me.txt_productname
        Me.txt_productname.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_productname.Location = New System.Drawing.Point(511, 126)
        Me.txt_productname.Name = "txt_productname"
        Me.txt_productname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_productname.PlaceholderText = "Product Name"
        Me.txt_productname.SelectedText = ""
        Me.txt_productname.ShadowDecoration.Parent = Me.txt_productname
        Me.txt_productname.Size = New System.Drawing.Size(267, 36)
        Me.txt_productname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_productname.TabIndex = 0
        '
        'btn_refresh
        '
        Me.btn_refresh.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_refresh.Animated = True
        Me.btn_refresh.AutoRoundedCorners = True
        Me.btn_refresh.BorderColor = System.Drawing.Color.White
        Me.btn_refresh.BorderRadius = 15
        Me.btn_refresh.BorderThickness = 1
        Me.btn_refresh.CheckedState.Parent = Me.btn_refresh
        Me.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_refresh.CustomImages.Parent = Me.btn_refresh
        Me.btn_refresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_refresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_refresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_refresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_refresh.DisabledState.Parent = Me.btn_refresh
        Me.btn_refresh.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btn_refresh.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.ForeColor = System.Drawing.Color.White
        Me.btn_refresh.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btn_refresh.HoverState.FillColor = System.Drawing.Color.White
        Me.btn_refresh.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btn_refresh.HoverState.Parent = Me.btn_refresh
        Me.btn_refresh.Location = New System.Drawing.Point(44, 316)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.PressedColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btn_refresh.ShadowDecoration.Parent = Me.btn_refresh
        Me.btn_refresh.Size = New System.Drawing.Size(32, 32)
        Me.btn_refresh.TabIndex = 9
        Me.btn_refresh.Text = "↺"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(163, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Group"
        '
        'txt_proID
        '
        Me.txt_proID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_proID.Animated = True
        Me.txt_proID.BackColor = System.Drawing.Color.White
        Me.txt_proID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_proID.DefaultText = ""
        Me.txt_proID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_proID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_proID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_proID.DisabledState.Parent = Me.txt_proID
        Me.txt_proID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_proID.Enabled = False
        Me.txt_proID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_proID.FocusedState.Parent = Me.txt_proID
        Me.txt_proID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_proID.ForeColor = System.Drawing.Color.Black
        Me.txt_proID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_proID.HoverState.Parent = Me.txt_proID
        Me.txt_proID.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_proID.Location = New System.Drawing.Point(159, 79)
        Me.txt_proID.Margin = New System.Windows.Forms.Padding(140, 3, 3, 3)
        Me.txt_proID.Name = "txt_proID"
        Me.txt_proID.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.txt_proID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_proID.PlaceholderText = "Product ID"
        Me.txt_proID.ReadOnly = True
        Me.txt_proID.SelectedText = ""
        Me.txt_proID.ShadowDecoration.Parent = Me.txt_proID
        Me.txt_proID.Size = New System.Drawing.Size(77, 36)
        Me.txt_proID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_proID.TabIndex = 43
        Me.txt_proID.TabStop = False
        '
        'FormProduct
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(924, 621)
        Me.Controls.Add(Me.txt_proID)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.txt_location)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btm_save)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_addUOM)
        Me.Controls.Add(Me.combo_UOM)
        Me.Controls.Add(Me.btm_addproductgroup)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_productcode)
        Me.Controls.Add(Me.combo_productGroup)
        Me.Controls.Add(Me.txt_productname)
        Me.Name = "FormProduct"
        Me.Text = "Products"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_search As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_location As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt_price As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_delete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_edit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btm_save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_addUOM As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents combo_UOM As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btm_addproductgroup As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_productcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents combo_productGroup As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txt_productname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_refresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_proID As Guna.UI2.WinForms.Guna2TextBox
End Class
