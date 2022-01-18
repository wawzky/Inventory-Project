<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Dim Animation3 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.panelRegister = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.regChkpass = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbRegUtype = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2CirclePictureBox2 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.buttonCreateAccount = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.LinkLogin = New System.Windows.Forms.LinkLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tbUserNameReg = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbFullNameReg = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbPasswordReg = New Guna.UI2.WinForms.Guna2TextBox()
        Me.panelLogin = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Check_showpass = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboUserType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.tbUsernameLogin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbPasswordLogin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.buttonLogin = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.LinkSignUp = New System.Windows.Forms.LinkLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.panelRegister.SuspendLayout()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelLogin.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent
        Me.Guna2Transition1.Cursor = Nothing
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 0
        Animation3.Padding = New System.Windows.Forms.Padding(0)
        Animation3.RotateCoeff = 0!
        Animation3.RotateLimit = 0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 0!
        Animation3.TransparencyCoeff = 1.0!
        Me.Guna2Transition1.DefaultAnimation = Animation3
        Me.Guna2Transition1.MaxAnimationTime = 500
        '
        'panelRegister
        '
        Me.panelRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelRegister.BackColor = System.Drawing.Color.Transparent
        Me.panelRegister.Controls.Add(Me.regChkpass)
        Me.panelRegister.Controls.Add(Me.Label2)
        Me.panelRegister.Controls.Add(Me.cbRegUtype)
        Me.panelRegister.Controls.Add(Me.Guna2CirclePictureBox2)
        Me.panelRegister.Controls.Add(Me.buttonCreateAccount)
        Me.panelRegister.Controls.Add(Me.LinkLogin)
        Me.panelRegister.Controls.Add(Me.Guna2HtmlLabel2)
        Me.panelRegister.Controls.Add(Me.tbUserNameReg)
        Me.panelRegister.Controls.Add(Me.tbFullNameReg)
        Me.panelRegister.Controls.Add(Me.tbPasswordReg)
        Me.Guna2Transition1.SetDecoration(Me.panelRegister, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.panelRegister.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelRegister.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.panelRegister.Location = New System.Drawing.Point(0, 0)
        Me.panelRegister.Name = "panelRegister"
        Me.panelRegister.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.panelRegister.ShadowDepth = 80
        Me.panelRegister.Size = New System.Drawing.Size(1000, 660)
        Me.panelRegister.TabIndex = 10
        '
        'regChkpass
        '
        Me.regChkpass.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.regChkpass.Animated = True
        Me.regChkpass.AutoSize = True
        Me.regChkpass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.regChkpass.CheckedState.BorderRadius = 3
        Me.regChkpass.CheckedState.BorderThickness = 0
        Me.regChkpass.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.regChkpass, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.regChkpass.Location = New System.Drawing.Point(607, 396)
        Me.regChkpass.Name = "regChkpass"
        Me.regChkpass.Size = New System.Drawing.Size(15, 14)
        Me.regChkpass.TabIndex = 15
        Me.regChkpass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.regChkpass.UncheckedState.BorderRadius = 3
        Me.regChkpass.UncheckedState.BorderThickness = 0
        Me.regChkpass.UncheckedState.FillColor = System.Drawing.Color.Silver
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(373, 435)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "User Type:"
        '
        'cbRegUtype
        '
        Me.cbRegUtype.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbRegUtype.AutoRoundedCorners = True
        Me.cbRegUtype.BackColor = System.Drawing.Color.Transparent
        Me.cbRegUtype.BorderRadius = 17
        Me.Guna2Transition1.SetDecoration(Me.cbRegUtype, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.cbRegUtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbRegUtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRegUtype.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbRegUtype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbRegUtype.FocusedState.Parent = Me.cbRegUtype
        Me.cbRegUtype.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbRegUtype.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbRegUtype.HoverState.Parent = Me.cbRegUtype
        Me.cbRegUtype.ItemHeight = 30
        Me.cbRegUtype.Items.AddRange(New Object() {"Administrator", "Manager", "Staff", "User"})
        Me.cbRegUtype.ItemsAppearance.Parent = Me.cbRegUtype
        Me.cbRegUtype.Location = New System.Drawing.Point(478, 430)
        Me.cbRegUtype.Margin = New System.Windows.Forms.Padding(4, 4, 4, 8)
        Me.cbRegUtype.Name = "cbRegUtype"
        Me.cbRegUtype.ShadowDecoration.Parent = Me.cbRegUtype
        Me.cbRegUtype.Size = New System.Drawing.Size(156, 36)
        Me.cbRegUtype.TabIndex = 8
        '
        'Guna2CirclePictureBox2
        '
        Me.Guna2CirclePictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2CirclePictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.Guna2CirclePictureBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2CirclePictureBox2.Image = Global.Inventory_Project.My.Resources.Resources.add_user
        Me.Guna2CirclePictureBox2.ImageRotate = 0!
        Me.Guna2CirclePictureBox2.Location = New System.Drawing.Point(400, 54)
        Me.Guna2CirclePictureBox2.Margin = New System.Windows.Forms.Padding(10)
        Me.Guna2CirclePictureBox2.Name = "Guna2CirclePictureBox2"
        Me.Guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox2.ShadowDecoration.Parent = Me.Guna2CirclePictureBox2
        Me.Guna2CirclePictureBox2.Size = New System.Drawing.Size(203, 203)
        Me.Guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Guna2CirclePictureBox2.TabIndex = 12
        Me.Guna2CirclePictureBox2.TabStop = False
        '
        'buttonCreateAccount
        '
        Me.buttonCreateAccount.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.buttonCreateAccount.Animated = True
        Me.buttonCreateAccount.AutoRoundedCorners = True
        Me.buttonCreateAccount.BorderRadius = 26
        Me.buttonCreateAccount.CheckedState.Parent = Me.buttonCreateAccount
        Me.buttonCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonCreateAccount.CustomImages.Parent = Me.buttonCreateAccount
        Me.Guna2Transition1.SetDecoration(Me.buttonCreateAccount, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.buttonCreateAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.buttonCreateAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.buttonCreateAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.buttonCreateAccount.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.buttonCreateAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.buttonCreateAccount.DisabledState.Parent = Me.buttonCreateAccount
        Me.buttonCreateAccount.FillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.buttonCreateAccount.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.buttonCreateAccount.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.buttonCreateAccount.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonCreateAccount.ForeColor = System.Drawing.Color.White
        Me.buttonCreateAccount.HoverState.Parent = Me.buttonCreateAccount
        Me.buttonCreateAccount.Location = New System.Drawing.Point(366, 477)
        Me.buttonCreateAccount.Name = "buttonCreateAccount"
        Me.buttonCreateAccount.ShadowDecoration.Parent = Me.buttonCreateAccount
        Me.buttonCreateAccount.Size = New System.Drawing.Size(268, 55)
        Me.buttonCreateAccount.TabIndex = 9
        Me.buttonCreateAccount.Text = "Create an Account"
        '
        'LinkLogin
        '
        Me.LinkLogin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LinkLogin.AutoSize = True
        Me.LinkLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.LinkLogin, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LinkLogin.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLogin.Location = New System.Drawing.Point(590, 539)
        Me.LinkLogin.Name = "LinkLogin"
        Me.LinkLogin.Size = New System.Drawing.Size(44, 18)
        Me.LinkLogin.TabIndex = 10
        Me.LinkLogin.TabStop = True
        Me.LinkLogin.Text = "Log in"
        Me.LinkLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(366, 539)
        Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(168, 20)
        Me.Guna2HtmlLabel2.TabIndex = 8
        Me.Guna2HtmlLabel2.TabStop = False
        Me.Guna2HtmlLabel2.Text = "Already have an account?"
        '
        'tbUserNameReg
        '
        Me.tbUserNameReg.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tbUserNameReg.Animated = True
        Me.tbUserNameReg.AutoRoundedCorners = True
        Me.tbUserNameReg.BorderRadius = 18
        Me.tbUserNameReg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.tbUserNameReg, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tbUserNameReg.DefaultText = ""
        Me.tbUserNameReg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbUserNameReg.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbUserNameReg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbUserNameReg.DisabledState.Parent = Me.tbUserNameReg
        Me.tbUserNameReg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbUserNameReg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbUserNameReg.FocusedState.Parent = Me.tbUserNameReg
        Me.tbUserNameReg.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbUserNameReg.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbUserNameReg.HoverState.Parent = Me.tbUserNameReg
        Me.tbUserNameReg.Location = New System.Drawing.Point(366, 336)
        Me.tbUserNameReg.Margin = New System.Windows.Forms.Padding(4)
        Me.tbUserNameReg.Name = "tbUserNameReg"
        Me.tbUserNameReg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbUserNameReg.PlaceholderText = "Username"
        Me.tbUserNameReg.SelectedText = ""
        Me.tbUserNameReg.ShadowDecoration.Parent = Me.tbUserNameReg
        Me.tbUserNameReg.Size = New System.Drawing.Size(268, 39)
        Me.tbUserNameReg.TabIndex = 6
        '
        'tbFullNameReg
        '
        Me.tbFullNameReg.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tbFullNameReg.Animated = True
        Me.tbFullNameReg.AutoRoundedCorners = True
        Me.tbFullNameReg.BorderRadius = 18
        Me.tbFullNameReg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.tbFullNameReg, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tbFullNameReg.DefaultText = ""
        Me.tbFullNameReg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbFullNameReg.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbFullNameReg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbFullNameReg.DisabledState.Parent = Me.tbFullNameReg
        Me.tbFullNameReg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbFullNameReg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbFullNameReg.FocusedState.Parent = Me.tbFullNameReg
        Me.tbFullNameReg.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbFullNameReg.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbFullNameReg.HoverState.Parent = Me.tbFullNameReg
        Me.tbFullNameReg.Location = New System.Drawing.Point(366, 289)
        Me.tbFullNameReg.Margin = New System.Windows.Forms.Padding(4)
        Me.tbFullNameReg.Name = "tbFullNameReg"
        Me.tbFullNameReg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbFullNameReg.PlaceholderText = "Full Name"
        Me.tbFullNameReg.SelectedText = ""
        Me.tbFullNameReg.ShadowDecoration.Parent = Me.tbFullNameReg
        Me.tbFullNameReg.Size = New System.Drawing.Size(268, 39)
        Me.tbFullNameReg.TabIndex = 5
        '
        'tbPasswordReg
        '
        Me.tbPasswordReg.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tbPasswordReg.Animated = True
        Me.tbPasswordReg.AutoRoundedCorners = True
        Me.tbPasswordReg.BorderRadius = 18
        Me.tbPasswordReg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.tbPasswordReg, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tbPasswordReg.DefaultText = ""
        Me.tbPasswordReg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbPasswordReg.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbPasswordReg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPasswordReg.DisabledState.Parent = Me.tbPasswordReg
        Me.tbPasswordReg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPasswordReg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPasswordReg.FocusedState.Parent = Me.tbPasswordReg
        Me.tbPasswordReg.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbPasswordReg.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPasswordReg.HoverState.Parent = Me.tbPasswordReg
        Me.tbPasswordReg.Location = New System.Drawing.Point(366, 383)
        Me.tbPasswordReg.Margin = New System.Windows.Forms.Padding(4)
        Me.tbPasswordReg.Name = "tbPasswordReg"
        Me.tbPasswordReg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbPasswordReg.PlaceholderText = "Password"
        Me.tbPasswordReg.SelectedText = ""
        Me.tbPasswordReg.ShadowDecoration.Parent = Me.tbPasswordReg
        Me.tbPasswordReg.Size = New System.Drawing.Size(268, 39)
        Me.tbPasswordReg.TabIndex = 7
        Me.tbPasswordReg.UseSystemPasswordChar = True
        '
        'panelLogin
        '
        Me.panelLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelLogin.BackColor = System.Drawing.Color.Transparent
        Me.panelLogin.Controls.Add(Me.Check_showpass)
        Me.panelLogin.Controls.Add(Me.Label1)
        Me.panelLogin.Controls.Add(Me.comboUserType)
        Me.panelLogin.Controls.Add(Me.tbUsernameLogin)
        Me.panelLogin.Controls.Add(Me.tbPasswordLogin)
        Me.panelLogin.Controls.Add(Me.buttonLogin)
        Me.panelLogin.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.panelLogin.Controls.Add(Me.LinkSignUp)
        Me.panelLogin.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Transition1.SetDecoration(Me.panelLogin, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.panelLogin.Location = New System.Drawing.Point(0, 0)
        Me.panelLogin.Name = "panelLogin"
        Me.panelLogin.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.panelLogin.ShadowDepth = 80
        Me.panelLogin.Size = New System.Drawing.Size(1000, 660)
        Me.panelLogin.TabIndex = 11
        '
        'Check_showpass
        '
        Me.Check_showpass.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Check_showpass.Animated = True
        Me.Check_showpass.AutoSize = True
        Me.Check_showpass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check_showpass.CheckedState.BorderRadius = 3
        Me.Check_showpass.CheckedState.BorderThickness = 0
        Me.Check_showpass.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.Check_showpass, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Check_showpass.Location = New System.Drawing.Point(607, 396)
        Me.Check_showpass.Name = "Check_showpass"
        Me.Check_showpass.Size = New System.Drawing.Size(15, 14)
        Me.Check_showpass.TabIndex = 10
        Me.Check_showpass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Check_showpass.UncheckedState.BorderRadius = 3
        Me.Check_showpass.UncheckedState.BorderThickness = 0
        Me.Check_showpass.UncheckedState.FillColor = System.Drawing.Color.Silver
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(373, 435)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "User Type:"
        '
        'comboUserType
        '
        Me.comboUserType.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.comboUserType.AutoRoundedCorners = True
        Me.comboUserType.BackColor = System.Drawing.Color.Transparent
        Me.comboUserType.BorderRadius = 17
        Me.Guna2Transition1.SetDecoration(Me.comboUserType, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.comboUserType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboUserType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.comboUserType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.comboUserType.FocusedState.Parent = Me.comboUserType
        Me.comboUserType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.comboUserType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.comboUserType.HoverState.Parent = Me.comboUserType
        Me.comboUserType.ItemHeight = 30
        Me.comboUserType.ItemsAppearance.Parent = Me.comboUserType
        Me.comboUserType.Location = New System.Drawing.Point(478, 430)
        Me.comboUserType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 8)
        Me.comboUserType.Name = "comboUserType"
        Me.comboUserType.ShadowDecoration.Parent = Me.comboUserType
        Me.comboUserType.Size = New System.Drawing.Size(156, 36)
        Me.comboUserType.TabIndex = 2
        '
        'tbUsernameLogin
        '
        Me.tbUsernameLogin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tbUsernameLogin.Animated = True
        Me.tbUsernameLogin.AutoRoundedCorners = True
        Me.tbUsernameLogin.BorderRadius = 18
        Me.tbUsernameLogin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.tbUsernameLogin, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tbUsernameLogin.DefaultText = ""
        Me.tbUsernameLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbUsernameLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbUsernameLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbUsernameLogin.DisabledState.Parent = Me.tbUsernameLogin
        Me.tbUsernameLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbUsernameLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbUsernameLogin.FocusedState.Parent = Me.tbUsernameLogin
        Me.tbUsernameLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbUsernameLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbUsernameLogin.HoverState.Parent = Me.tbUsernameLogin
        Me.tbUsernameLogin.IconLeft = Global.Inventory_Project.My.Resources.Resources.login__3_
        Me.tbUsernameLogin.Location = New System.Drawing.Point(366, 336)
        Me.tbUsernameLogin.Margin = New System.Windows.Forms.Padding(10, 4, 10, 4)
        Me.tbUsernameLogin.Name = "tbUsernameLogin"
        Me.tbUsernameLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbUsernameLogin.PlaceholderText = "Enter Username"
        Me.tbUsernameLogin.SelectedText = ""
        Me.tbUsernameLogin.ShadowDecoration.Parent = Me.tbUsernameLogin
        Me.tbUsernameLogin.Size = New System.Drawing.Size(268, 39)
        Me.tbUsernameLogin.TabIndex = 0
        '
        'tbPasswordLogin
        '
        Me.tbPasswordLogin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tbPasswordLogin.Animated = True
        Me.tbPasswordLogin.AutoRoundedCorners = True
        Me.tbPasswordLogin.BorderRadius = 18
        Me.tbPasswordLogin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.tbPasswordLogin, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tbPasswordLogin.DefaultText = ""
        Me.tbPasswordLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbPasswordLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbPasswordLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPasswordLogin.DisabledState.Parent = Me.tbPasswordLogin
        Me.tbPasswordLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPasswordLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPasswordLogin.FocusedState.Parent = Me.tbPasswordLogin
        Me.tbPasswordLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbPasswordLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPasswordLogin.HoverState.Parent = Me.tbPasswordLogin
        Me.tbPasswordLogin.IconLeft = Global.Inventory_Project.My.Resources.Resources.key__1_
        Me.tbPasswordLogin.Location = New System.Drawing.Point(366, 383)
        Me.tbPasswordLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.tbPasswordLogin.Name = "tbPasswordLogin"
        Me.tbPasswordLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbPasswordLogin.PlaceholderText = "Enter Password"
        Me.tbPasswordLogin.SelectedText = ""
        Me.tbPasswordLogin.ShadowDecoration.Parent = Me.tbPasswordLogin
        Me.tbPasswordLogin.Size = New System.Drawing.Size(268, 39)
        Me.tbPasswordLogin.TabIndex = 1
        Me.tbPasswordLogin.UseSystemPasswordChar = True
        '
        'buttonLogin
        '
        Me.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.buttonLogin.Animated = True
        Me.buttonLogin.AutoRoundedCorners = True
        Me.buttonLogin.BorderRadius = 26
        Me.buttonLogin.CheckedState.Parent = Me.buttonLogin
        Me.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonLogin.CustomImages.Parent = Me.buttonLogin
        Me.Guna2Transition1.SetDecoration(Me.buttonLogin, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.buttonLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.buttonLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.buttonLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.buttonLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.buttonLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.buttonLogin.DisabledState.Parent = Me.buttonLogin
        Me.buttonLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.buttonLogin.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.buttonLogin.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.buttonLogin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonLogin.ForeColor = System.Drawing.Color.White
        Me.buttonLogin.HoverState.Parent = Me.buttonLogin
        Me.buttonLogin.Location = New System.Drawing.Point(366, 477)
        Me.buttonLogin.Name = "buttonLogin"
        Me.buttonLogin.ShadowDecoration.Parent = Me.buttonLogin
        Me.buttonLogin.Size = New System.Drawing.Size(268, 55)
        Me.buttonLogin.TabIndex = 3
        Me.buttonLogin.Text = "LOGIN"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.Guna2CirclePictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2CirclePictureBox1.Image = Global.Inventory_Project.My.Resources.Resources.login__1_
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(366, 54)
        Me.Guna2CirclePictureBox1.Margin = New System.Windows.Forms.Padding(10)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(268, 268)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox1.TabIndex = 6
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'LinkSignUp
        '
        Me.LinkSignUp.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LinkSignUp.AutoSize = True
        Me.LinkSignUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.LinkSignUp, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LinkSignUp.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkSignUp.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkSignUp.Location = New System.Drawing.Point(580, 537)
        Me.LinkSignUp.Name = "LinkSignUp"
        Me.LinkSignUp.Size = New System.Drawing.Size(54, 18)
        Me.LinkSignUp.TabIndex = 4
        Me.LinkSignUp.TabStop = True
        Me.LinkSignUp.Text = "Sign Up"
        Me.LinkSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(366, 537)
        Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(168, 20)
        Me.Guna2HtmlLabel1.TabIndex = 8
        Me.Guna2HtmlLabel1.TabStop = False
        Me.Guna2HtmlLabel1.Text = "Don't have an account yet?"
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.panelLogin)
        Me.Guna2GradientPanel1.Controls.Add(Me.panelRegister)
        Me.Guna2Transition1.SetDecoration(Me.Guna2GradientPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1000, 660)
        Me.Guna2GradientPanel1.TabIndex = 11
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'FormLogin
        '
        Me.AcceptButton = Me.buttonLogin
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 660)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login"
        Me.panelRegister.ResumeLayout(False)
        Me.panelRegister.PerformLayout()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelLogin.ResumeLayout(False)
        Me.panelLogin.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelRegister As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents buttonCreateAccount As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents LinkLogin As LinkLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tbFullNameReg As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbPasswordReg As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents tbUserNameReg As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents panelLogin As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents buttonLogin As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents LinkSignUp As LinkLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Public WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Guna2CirclePictureBox2 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents tbUsernameLogin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbPasswordLogin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents comboUserType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbRegUtype As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Check_showpass As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents regChkpass As Guna.UI2.WinForms.Guna2CheckBox
End Class
