<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHome
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
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btn_ManUsers = New FontAwesome.Sharp.IconButton()
        Me.btn_Stocks = New FontAwesome.Sharp.IconButton()
        Me.btn_Cars = New FontAwesome.Sharp.IconButton()
        Me.btn_Product = New FontAwesome.Sharp.IconButton()
        Me.btn_Customers = New FontAwesome.Sharp.IconButton()
        Me.btn_Logout = New FontAwesome.Sharp.IconButton()
        Me.btn_Dash = New FontAwesome.Sharp.IconButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.imgHome = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.lbl_role = New System.Windows.Forms.Label()
        Me.btn_Exit = New FontAwesome.Sharp.IconButton()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.btn_Min = New FontAwesome.Sharp.IconButton()
        Me.main_picturebox = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.btn_MinMax = New FontAwesome.Sharp.IconButton()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.PanelMenu.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitleBar.SuspendLayout()
        CType(Me.main_picturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btn_ManUsers)
        Me.PanelMenu.Controls.Add(Me.btn_Stocks)
        Me.PanelMenu.Controls.Add(Me.btn_Cars)
        Me.PanelMenu.Controls.Add(Me.btn_Product)
        Me.PanelMenu.Controls.Add(Me.btn_Customers)
        Me.PanelMenu.Controls.Add(Me.btn_Logout)
        Me.PanelMenu.Controls.Add(Me.btn_Dash)
        Me.PanelMenu.Controls.Add(Me.Panel4)
        Me.PanelMenu.Controls.Add(Me.Panel2)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(212, 720)
        Me.PanelMenu.TabIndex = 0
        '
        'btn_ManUsers
        '
        Me.btn_ManUsers.AutoSize = True
        Me.btn_ManUsers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_ManUsers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_ManUsers.FlatAppearance.BorderSize = 0
        Me.btn_ManUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ManUsers.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ManUsers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btn_ManUsers.IconChar = FontAwesome.Sharp.IconChar.Tools
        Me.btn_ManUsers.IconColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btn_ManUsers.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_ManUsers.IconSize = 45
        Me.btn_ManUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ManUsers.Location = New System.Drawing.Point(0, 517)
        Me.btn_ManUsers.Name = "btn_ManUsers"
        Me.btn_ManUsers.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_ManUsers.Size = New System.Drawing.Size(212, 51)
        Me.btn_ManUsers.TabIndex = 8
        Me.btn_ManUsers.TabStop = False
        Me.btn_ManUsers.Text = "Manage Users"
        Me.btn_ManUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ManUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ManUsers.UseVisualStyleBackColor = True
        '
        'btn_Stocks
        '
        Me.btn_Stocks.AutoSize = True
        Me.btn_Stocks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_Stocks.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Stocks.FlatAppearance.BorderSize = 0
        Me.btn_Stocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Stocks.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Stocks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btn_Stocks.IconChar = FontAwesome.Sharp.IconChar.Boxes
        Me.btn_Stocks.IconColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btn_Stocks.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_Stocks.IconSize = 45
        Me.btn_Stocks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Stocks.Location = New System.Drawing.Point(0, 466)
        Me.btn_Stocks.Name = "btn_Stocks"
        Me.btn_Stocks.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_Stocks.Size = New System.Drawing.Size(212, 51)
        Me.btn_Stocks.TabIndex = 6
        Me.btn_Stocks.TabStop = False
        Me.btn_Stocks.Text = "Stocks"
        Me.btn_Stocks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Stocks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Stocks.UseVisualStyleBackColor = True
        '
        'btn_Cars
        '
        Me.btn_Cars.AutoSize = True
        Me.btn_Cars.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_Cars.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Cars.FlatAppearance.BorderSize = 0
        Me.btn_Cars.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cars.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cars.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btn_Cars.IconChar = FontAwesome.Sharp.IconChar.CarSide
        Me.btn_Cars.IconColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btn_Cars.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_Cars.IconSize = 45
        Me.btn_Cars.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Cars.Location = New System.Drawing.Point(0, 415)
        Me.btn_Cars.Name = "btn_Cars"
        Me.btn_Cars.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_Cars.Size = New System.Drawing.Size(212, 51)
        Me.btn_Cars.TabIndex = 5
        Me.btn_Cars.TabStop = False
        Me.btn_Cars.Text = "Cars"
        Me.btn_Cars.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Cars.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cars.UseVisualStyleBackColor = True
        '
        'btn_Product
        '
        Me.btn_Product.AutoSize = True
        Me.btn_Product.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_Product.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Product.FlatAppearance.BorderSize = 0
        Me.btn_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Product.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Product.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btn_Product.IconChar = FontAwesome.Sharp.IconChar.Tags
        Me.btn_Product.IconColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btn_Product.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_Product.IconSize = 45
        Me.btn_Product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Product.Location = New System.Drawing.Point(0, 364)
        Me.btn_Product.Name = "btn_Product"
        Me.btn_Product.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_Product.Size = New System.Drawing.Size(212, 51)
        Me.btn_Product.TabIndex = 4
        Me.btn_Product.TabStop = False
        Me.btn_Product.Text = "Products"
        Me.btn_Product.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Product.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Product.UseVisualStyleBackColor = True
        '
        'btn_Customers
        '
        Me.btn_Customers.AutoSize = True
        Me.btn_Customers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_Customers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Customers.FlatAppearance.BorderSize = 0
        Me.btn_Customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Customers.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Customers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btn_Customers.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.btn_Customers.IconColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btn_Customers.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_Customers.IconSize = 45
        Me.btn_Customers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Customers.Location = New System.Drawing.Point(0, 313)
        Me.btn_Customers.Name = "btn_Customers"
        Me.btn_Customers.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_Customers.Size = New System.Drawing.Size(212, 51)
        Me.btn_Customers.TabIndex = 3
        Me.btn_Customers.TabStop = False
        Me.btn_Customers.Text = "Customers"
        Me.btn_Customers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Customers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Customers.UseVisualStyleBackColor = True
        '
        'btn_Logout
        '
        Me.btn_Logout.AutoSize = True
        Me.btn_Logout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_Logout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_Logout.FlatAppearance.BorderSize = 0
        Me.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Logout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btn_Logout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.btn_Logout.IconColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btn_Logout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_Logout.IconSize = 32
        Me.btn_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Logout.Location = New System.Drawing.Point(0, 682)
        Me.btn_Logout.Name = "btn_Logout"
        Me.btn_Logout.Size = New System.Drawing.Size(212, 38)
        Me.btn_Logout.TabIndex = 9
        Me.btn_Logout.TabStop = False
        Me.btn_Logout.Text = "Log out"
        Me.btn_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Logout.UseVisualStyleBackColor = True
        '
        'btn_Dash
        '
        Me.btn_Dash.AutoSize = True
        Me.btn_Dash.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_Dash.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Dash.FlatAppearance.BorderSize = 0
        Me.btn_Dash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Dash.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Dash.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btn_Dash.IconChar = FontAwesome.Sharp.IconChar.TachometerAlt
        Me.btn_Dash.IconColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btn_Dash.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_Dash.IconSize = 45
        Me.btn_Dash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Dash.Location = New System.Drawing.Point(0, 262)
        Me.btn_Dash.Name = "btn_Dash"
        Me.btn_Dash.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_Dash.Size = New System.Drawing.Size(212, 51)
        Me.btn_Dash.TabIndex = 2
        Me.btn_Dash.TabStop = False
        Me.btn_Dash.Text = "Dashboard"
        Me.btn_Dash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Dash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Dash.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.imgHome)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 50)
        Me.Panel4.MaximumSize = New System.Drawing.Size(212, 212)
        Me.Panel4.MinimumSize = New System.Drawing.Size(212, 212)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(212, 212)
        Me.Panel4.TabIndex = 1
        '
        'imgHome
        '
        Me.imgHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.imgHome.BackgroundImage = Global.Inventory_Project.My.Resources.Resources.ouzo
        Me.imgHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgHome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.imgHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.imgHome.IconChar = FontAwesome.Sharp.IconChar.None
        Me.imgHome.IconColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.imgHome.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.imgHome.IconSize = 212
        Me.imgHome.Location = New System.Drawing.Point(0, 0)
        Me.imgHome.Name = "imgHome"
        Me.imgHome.Size = New System.Drawing.Size(212, 212)
        Me.imgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.imgHome.TabIndex = 0
        Me.imgHome.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.IconCurrentForm)
        Me.Panel2.Controls.Add(Me.lblFormTitle)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(212, 50)
        Me.Panel2.TabIndex = 0
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.Black
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.Color.Black
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.Location = New System.Drawing.Point(12, 12)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(32, 32)
        Me.IconCurrentForm.TabIndex = 1
        Me.IconCurrentForm.TabStop = False
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.Location = New System.Drawing.Point(50, 16)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(45, 18)
        Me.lblFormTitle.TabIndex = 2
        Me.lblFormTitle.Text = "Home"
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.PanelTitleBar.Controls.Add(Me.lbl_role)
        Me.PanelTitleBar.Controls.Add(Me.btn_Exit)
        Me.PanelTitleBar.Controls.Add(Me.lbl_user)
        Me.PanelTitleBar.Controls.Add(Me.btn_Min)
        Me.PanelTitleBar.Controls.Add(Me.main_picturebox)
        Me.PanelTitleBar.Controls.Add(Me.btn_MinMax)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(212, 0)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(1068, 50)
        Me.PanelTitleBar.TabIndex = 1
        '
        'lbl_role
        '
        Me.lbl_role.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_role.AutoSize = True
        Me.lbl_role.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_role.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_role.ForeColor = System.Drawing.Color.White
        Me.lbl_role.Location = New System.Drawing.Point(861, 26)
        Me.lbl_role.Name = "lbl_role"
        Me.lbl_role.Size = New System.Drawing.Size(57, 15)
        Me.lbl_role.TabIndex = 13
        Me.lbl_role.Text = "User Type"
        Me.lbl_role.Visible = False
        '
        'btn_Exit
        '
        Me.btn_Exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Exit.AutoSize = True
        Me.btn_Exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Exit.FlatAppearance.BorderSize = 0
        Me.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Exit.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btn_Exit.IconColor = System.Drawing.Color.Black
        Me.btn_Exit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_Exit.IconSize = 24
        Me.btn_Exit.Location = New System.Drawing.Point(1033, 3)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(30, 30)
        Me.btn_Exit.TabIndex = 4
        Me.btn_Exit.TabStop = False
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'lbl_user
        '
        Me.lbl_user.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_user.AutoSize = True
        Me.lbl_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_user.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.ForeColor = System.Drawing.Color.White
        Me.lbl_user.Location = New System.Drawing.Point(861, 8)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(65, 15)
        Me.lbl_user.TabIndex = 12
        Me.lbl_user.Text = "User Name"
        Me.lbl_user.Visible = False
        '
        'btn_Min
        '
        Me.btn_Min.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Min.AutoSize = True
        Me.btn_Min.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_Min.FlatAppearance.BorderSize = 0
        Me.btn_Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Min.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.btn_Min.IconColor = System.Drawing.Color.Black
        Me.btn_Min.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_Min.IconSize = 24
        Me.btn_Min.Location = New System.Drawing.Point(961, 3)
        Me.btn_Min.Name = "btn_Min"
        Me.btn_Min.Size = New System.Drawing.Size(30, 30)
        Me.btn_Min.TabIndex = 3
        Me.btn_Min.TabStop = False
        Me.btn_Min.UseVisualStyleBackColor = True
        '
        'main_picturebox
        '
        Me.main_picturebox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.main_picturebox.BackColor = System.Drawing.Color.Transparent
        Me.main_picturebox.ImageRotate = 0!
        Me.main_picturebox.Location = New System.Drawing.Point(804, 3)
        Me.main_picturebox.Name = "main_picturebox"
        Me.main_picturebox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.main_picturebox.ShadowDecoration.Parent = Me.main_picturebox
        Me.main_picturebox.Size = New System.Drawing.Size(44, 41)
        Me.main_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.main_picturebox.TabIndex = 11
        Me.main_picturebox.TabStop = False
        Me.main_picturebox.UseTransparentBackground = True
        Me.main_picturebox.Visible = False
        '
        'btn_MinMax
        '
        Me.btn_MinMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_MinMax.AutoSize = True
        Me.btn_MinMax.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_MinMax.FlatAppearance.BorderSize = 0
        Me.btn_MinMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_MinMax.IconChar = FontAwesome.Sharp.IconChar.WindowRestore
        Me.btn_MinMax.IconColor = System.Drawing.Color.Black
        Me.btn_MinMax.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_MinMax.IconSize = 24
        Me.btn_MinMax.Location = New System.Drawing.Point(997, 3)
        Me.btn_MinMax.Name = "btn_MinMax"
        Me.btn_MinMax.Size = New System.Drawing.Size(30, 30)
        Me.btn_MinMax.TabIndex = 0
        Me.btn_MinMax.TabStop = False
        Me.btn_MinMax.UseVisualStyleBackColor = True
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(212, 50)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(1068, 670)
        Me.PanelDesktop.TabIndex = 2
        '
        'FormHome
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btn_Exit
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1920, 1080)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "FormHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        CType(Me.main_picturebox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btn_Logout As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_ManUsers As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Stocks As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Cars As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Product As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Dash As FontAwesome.Sharp.IconButton
    Friend WithEvents imgHome As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents btn_MinMax As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents btn_Min As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Exit As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Customers As FontAwesome.Sharp.IconButton
    Friend WithEvents lbl_role As Label
    Friend WithEvents lbl_user As Label
    Friend WithEvents main_picturebox As Guna.UI2.WinForms.Guna2CirclePictureBox
End Class
