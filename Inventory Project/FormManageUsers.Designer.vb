<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormManageUsers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormManageUsers))
        Me.Btn_Edit = New Guna.UI2.WinForms.Guna2Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Check_showpass = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.Btn_Save = New Guna.UI2.WinForms.Guna2Button()
        Me.combo_role = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txt_password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_fullname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_browse = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.pic_box = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.btn_refresh = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_ID = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_browse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Edit
        '
        Me.Btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Btn_Edit.Animated = True
        Me.Btn_Edit.AutoRoundedCorners = True
        Me.Btn_Edit.BorderRadius = 18
        Me.Btn_Edit.CheckedState.Parent = Me.Btn_Edit
        Me.Btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Edit.CustomImages.Parent = Me.Btn_Edit
        Me.Btn_Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_Edit.DisabledState.Parent = Me.Btn_Edit
        Me.Btn_Edit.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Btn_Edit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Edit.ForeColor = System.Drawing.Color.White
        Me.Btn_Edit.HoverState.Parent = Me.Btn_Edit
        Me.Btn_Edit.Location = New System.Drawing.Point(623, 172)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.ShadowDecoration.Parent = Me.Btn_Edit
        Me.Btn_Edit.Size = New System.Drawing.Size(99, 38)
        Me.Btn_Edit.TabIndex = 32
        Me.Btn_Edit.Text = "Edit"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.colDelete})
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridView1.GridColor = System.Drawing.Color.DarkGray
        Me.DataGridView1.Location = New System.Drawing.Point(220, 297)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(502, 217)
        Me.DataGridView1.TabIndex = 31
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Full Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Username"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 94
        '
        'Column5
        '
        Me.Column5.HeaderText = "Password"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Role"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 59
        '
        'Column7
        '
        Me.Column7.HeaderText = "PIC"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column7.Visible = False
        '
        'colDelete
        '
        Me.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        Me.colDelete.DefaultCellStyle = DataGridViewCellStyle14
        Me.colDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.colDelete.HeaderText = ""
        Me.colDelete.Name = "colDelete"
        Me.colDelete.ReadOnly = True
        Me.colDelete.Text = "Delete"
        Me.colDelete.UseColumnTextForButtonValue = True
        Me.colDelete.Width = 5
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me
        '
        'Check_showpass
        '
        Me.Check_showpass.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Check_showpass.Animated = True
        Me.Check_showpass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check_showpass.CheckedState.BorderRadius = 2
        Me.Check_showpass.CheckedState.BorderThickness = 0
        Me.Check_showpass.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check_showpass.CheckedState.Parent = Me.Check_showpass
        Me.Check_showpass.Location = New System.Drawing.Point(562, 195)
        Me.Check_showpass.Name = "Check_showpass"
        Me.Check_showpass.ShadowDecoration.Parent = Me.Check_showpass
        Me.Check_showpass.Size = New System.Drawing.Size(15, 15)
        Me.Check_showpass.TabIndex = 28
        Me.Check_showpass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Check_showpass.UncheckedState.BorderRadius = 2
        Me.Check_showpass.UncheckedState.BorderThickness = 0
        Me.Check_showpass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Check_showpass.UncheckedState.Parent = Me.Check_showpass
        '
        'Btn_Save
        '
        Me.Btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Btn_Save.Animated = True
        Me.Btn_Save.AutoRoundedCorners = True
        Me.Btn_Save.BorderRadius = 18
        Me.Btn_Save.CheckedState.Parent = Me.Btn_Save
        Me.Btn_Save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Save.CustomImages.Parent = Me.Btn_Save
        Me.Btn_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_Save.DisabledState.Parent = Me.Btn_Save
        Me.Btn_Save.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Btn_Save.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Save.ForeColor = System.Drawing.Color.White
        Me.Btn_Save.HoverState.Parent = Me.Btn_Save
        Me.Btn_Save.Location = New System.Drawing.Point(623, 115)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.ShadowDecoration.Parent = Me.Btn_Save
        Me.Btn_Save.Size = New System.Drawing.Size(99, 38)
        Me.Btn_Save.TabIndex = 27
        Me.Btn_Save.Text = "Save"
        '
        'combo_role
        '
        Me.combo_role.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.combo_role.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.combo_role.BackColor = System.Drawing.Color.Transparent
        Me.combo_role.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.combo_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_role.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combo_role.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combo_role.FocusedState.Parent = Me.combo_role
        Me.combo_role.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.combo_role.ForeColor = System.Drawing.Color.DimGray
        Me.combo_role.HoverState.Parent = Me.combo_role
        Me.combo_role.ItemHeight = 30
        Me.combo_role.Items.AddRange(New Object() {"Administrator", "Manager", "Staff", "User"})
        Me.combo_role.ItemsAppearance.Parent = Me.combo_role
        Me.combo_role.Location = New System.Drawing.Point(369, 225)
        Me.combo_role.Name = "combo_role"
        Me.combo_role.ShadowDecoration.Parent = Me.combo_role
        Me.combo_role.Size = New System.Drawing.Size(212, 36)
        Me.combo_role.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.combo_role.TabIndex = 25
        Me.combo_role.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.combo_role.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txt_password
        '
        Me.txt_password.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_password.Animated = True
        Me.txt_password.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.txt_password.BorderThickness = 0
        Me.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_password.DefaultText = ""
        Me.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_password.DisabledState.Parent = Me.txt_password
        Me.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_password.FocusedState.Parent = Me.txt_password
        Me.txt_password.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_password.HoverState.Parent = Me.txt_password
        Me.txt_password.Location = New System.Drawing.Point(369, 183)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_password.PlaceholderText = "Password"
        Me.txt_password.SelectedText = ""
        Me.txt_password.ShadowDecoration.Parent = Me.txt_password
        Me.txt_password.Size = New System.Drawing.Size(212, 36)
        Me.txt_password.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_password.TabIndex = 24
        Me.txt_password.TextOffset = New System.Drawing.Point(5, 0)
        Me.txt_password.UseSystemPasswordChar = True
        '
        'txt_username
        '
        Me.txt_username.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_username.Animated = True
        Me.txt_username.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.txt_username.BorderThickness = 0
        Me.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_username.DefaultText = ""
        Me.txt_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_username.DisabledState.Parent = Me.txt_username
        Me.txt_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_username.FocusedState.Parent = Me.txt_username
        Me.txt_username.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_username.HoverState.Parent = Me.txt_username
        Me.txt_username.Location = New System.Drawing.Point(369, 141)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_username.PlaceholderText = "Username"
        Me.txt_username.SelectedText = ""
        Me.txt_username.ShadowDecoration.Parent = Me.txt_username
        Me.txt_username.Size = New System.Drawing.Size(212, 36)
        Me.txt_username.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_username.TabIndex = 23
        Me.txt_username.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txt_fullname
        '
        Me.txt_fullname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_fullname.Animated = True
        Me.txt_fullname.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.txt_fullname.BorderThickness = 0
        Me.txt_fullname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_fullname.DefaultText = ""
        Me.txt_fullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_fullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_fullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_fullname.DisabledState.Parent = Me.txt_fullname
        Me.txt_fullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_fullname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_fullname.FocusedState.Parent = Me.txt_fullname
        Me.txt_fullname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_fullname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_fullname.HoverState.Parent = Me.txt_fullname
        Me.txt_fullname.Location = New System.Drawing.Point(369, 99)
        Me.txt_fullname.Name = "txt_fullname"
        Me.txt_fullname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_fullname.PlaceholderText = "Full Name"
        Me.txt_fullname.SelectedText = ""
        Me.txt_fullname.ShadowDecoration.Parent = Me.txt_fullname
        Me.txt_fullname.Size = New System.Drawing.Size(212, 36)
        Me.txt_fullname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_fullname.TabIndex = 21
        Me.txt_fullname.TextOffset = New System.Drawing.Point(5, 0)
        '
        'btn_browse
        '
        Me.btn_browse.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_browse.BackColor = System.Drawing.Color.Transparent
        Me.btn_browse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_browse.FillColor = System.Drawing.Color.Transparent
        Me.btn_browse.Image = CType(resources.GetObject("btn_browse.Image"), System.Drawing.Image)
        Me.btn_browse.ImageRotate = 0!
        Me.btn_browse.Location = New System.Drawing.Point(307, 194)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btn_browse.ShadowDecoration.Parent = Me.btn_browse
        Me.btn_browse.Size = New System.Drawing.Size(22, 22)
        Me.btn_browse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_browse.TabIndex = 30
        Me.btn_browse.TabStop = False
        Me.btn_browse.UseTransparentBackground = True
        '
        'pic_box
        '
        Me.pic_box.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pic_box.FillColor = System.Drawing.Color.WhiteSmoke
        Me.pic_box.ImageRotate = 0!
        Me.pic_box.Location = New System.Drawing.Point(220, 124)
        Me.pic_box.Name = "pic_box"
        Me.pic_box.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.pic_box.ShadowDecoration.Parent = Me.pic_box
        Me.pic_box.Size = New System.Drawing.Size(94, 94)
        Me.pic_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_box.TabIndex = 26
        Me.pic_box.TabStop = False
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
        Me.btn_refresh.Location = New System.Drawing.Point(220, 259)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.PressedColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btn_refresh.ShadowDecoration.Parent = Me.btn_refresh
        Me.btn_refresh.Size = New System.Drawing.Size(32, 32)
        Me.btn_refresh.TabIndex = 33
        Me.btn_refresh.Text = "↺"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(381, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Type"
        '
        'txt_ID
        '
        Me.txt_ID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_ID.Animated = True
        Me.txt_ID.BackColor = System.Drawing.Color.White
        Me.txt_ID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_ID.DefaultText = ""
        Me.txt_ID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_ID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_ID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_ID.DisabledState.Parent = Me.txt_ID
        Me.txt_ID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_ID.Enabled = False
        Me.txt_ID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_ID.FocusedState.Parent = Me.txt_ID
        Me.txt_ID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_ID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_ID.HoverState.Parent = Me.txt_ID
        Me.txt_ID.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_ID.Location = New System.Drawing.Point(623, 225)
        Me.txt_ID.Margin = New System.Windows.Forms.Padding(140, 3, 3, 3)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.txt_ID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_ID.PlaceholderText = "ID"
        Me.txt_ID.ReadOnly = True
        Me.txt_ID.SelectedText = ""
        Me.txt_ID.ShadowDecoration.Parent = Me.txt_ID
        Me.txt_ID.Size = New System.Drawing.Size(99, 36)
        Me.txt_ID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_ID.TabIndex = 44
        Me.txt_ID.TabStop = False
        Me.txt_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FormManageUsers
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 621)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.Btn_Edit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_browse)
        Me.Controls.Add(Me.Check_showpass)
        Me.Controls.Add(Me.Btn_Save)
        Me.Controls.Add(Me.pic_box)
        Me.Controls.Add(Me.combo_role)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.txt_fullname)
        Me.Name = "FormManageUsers"
        Me.Text = "Manage Users"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_browse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Edit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_browse As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Check_showpass As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents Btn_Save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pic_box As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents combo_role As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txt_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_fullname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewImageColumn
    Friend WithEvents colDelete As DataGridViewButtonColumn
    Friend WithEvents btn_refresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_ID As Guna.UI2.WinForms.Guna2TextBox
End Class
