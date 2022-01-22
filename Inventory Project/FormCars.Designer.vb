<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCars
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_search = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_carprice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_engineno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_carname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_carID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_color = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_chassisno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_plateno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.carprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_delete = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_edit = New Guna.UI2.WinForms.Guna2Button()
        Me.btm_save = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_refresh = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_sell = New Guna.UI2.WinForms.Guna2Button()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.txt_search.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_search.ForeColor = System.Drawing.Color.Black
        Me.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_search.HoverState.Parent = Me.txt_search
        Me.txt_search.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_search.Location = New System.Drawing.Point(140, 316)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(80, 3, 3, 3)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.txt_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_search.PlaceholderText = "Search...."
        Me.txt_search.SelectedText = ""
        Me.txt_search.ShadowDecoration.Parent = Me.txt_search
        Me.txt_search.Size = New System.Drawing.Size(300, 36)
        Me.txt_search.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_search.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txt_carprice, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_engineno, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_carname, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_carID, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_color, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_chassisno, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_plateno, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 66)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(924, 194)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'txt_carprice
        '
        Me.txt_carprice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_carprice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_carprice.DefaultText = ""
        Me.txt_carprice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_carprice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_carprice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_carprice.DisabledState.Parent = Me.txt_carprice
        Me.txt_carprice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_carprice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_carprice.FocusedState.Parent = Me.txt_carprice
        Me.txt_carprice.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_carprice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_carprice.ForeColor = System.Drawing.Color.Black
        Me.txt_carprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_carprice.HoverState.Parent = Me.txt_carprice
        Me.txt_carprice.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_carprice.Location = New System.Drawing.Point(140, 147)
        Me.txt_carprice.Margin = New System.Windows.Forms.Padding(140, 3, 3, 3)
        Me.txt_carprice.MaxLength = 20
        Me.txt_carprice.Name = "txt_carprice"
        Me.txt_carprice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_carprice.PlaceholderText = "PRICE"
        Me.txt_carprice.SelectedText = ""
        Me.txt_carprice.ShadowDecoration.Parent = Me.txt_carprice
        Me.txt_carprice.Size = New System.Drawing.Size(300, 36)
        Me.txt_carprice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_carprice.TabIndex = 5
        '
        'txt_engineno
        '
        Me.txt_engineno.Animated = True
        Me.txt_engineno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_engineno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_engineno.DefaultText = ""
        Me.txt_engineno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_engineno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_engineno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_engineno.DisabledState.Parent = Me.txt_engineno
        Me.txt_engineno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_engineno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_engineno.FocusedState.Parent = Me.txt_engineno
        Me.txt_engineno.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_engineno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_engineno.ForeColor = System.Drawing.Color.Black
        Me.txt_engineno.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_engineno.HoverState.Parent = Me.txt_engineno
        Me.txt_engineno.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_engineno.Location = New System.Drawing.Point(140, 99)
        Me.txt_engineno.Margin = New System.Windows.Forms.Padding(140, 3, 3, 3)
        Me.txt_engineno.Name = "txt_engineno"
        Me.txt_engineno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_engineno.PlaceholderText = "ENGINE NO."
        Me.txt_engineno.SelectedText = ""
        Me.txt_engineno.ShadowDecoration.Parent = Me.txt_engineno
        Me.txt_engineno.Size = New System.Drawing.Size(300, 36)
        Me.txt_engineno.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_engineno.TabIndex = 3
        '
        'txt_carname
        '
        Me.txt_carname.Animated = True
        Me.txt_carname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_carname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_carname.DefaultText = ""
        Me.txt_carname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_carname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_carname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_carname.DisabledState.Parent = Me.txt_carname
        Me.txt_carname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_carname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_carname.FocusedState.Parent = Me.txt_carname
        Me.txt_carname.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_carname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_carname.ForeColor = System.Drawing.Color.Black
        Me.txt_carname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_carname.HoverState.Parent = Me.txt_carname
        Me.txt_carname.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_carname.Location = New System.Drawing.Point(140, 51)
        Me.txt_carname.Margin = New System.Windows.Forms.Padding(140, 3, 3, 3)
        Me.txt_carname.Name = "txt_carname"
        Me.txt_carname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_carname.PlaceholderText = "CAR NAME/MODEL"
        Me.txt_carname.SelectedText = ""
        Me.txt_carname.ShadowDecoration.Parent = Me.txt_carname
        Me.txt_carname.Size = New System.Drawing.Size(300, 36)
        Me.txt_carname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_carname.TabIndex = 1
        '
        'txt_carID
        '
        Me.txt_carID.Animated = True
        Me.txt_carID.BackColor = System.Drawing.Color.White
        Me.txt_carID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_carID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_carID.DefaultText = ""
        Me.txt_carID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_carID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_carID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_carID.DisabledState.Parent = Me.txt_carID
        Me.txt_carID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_carID.Enabled = False
        Me.txt_carID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_carID.FocusedState.Parent = Me.txt_carID
        Me.txt_carID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_carID.ForeColor = System.Drawing.Color.Black
        Me.txt_carID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_carID.HoverState.Parent = Me.txt_carID
        Me.txt_carID.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_carID.Location = New System.Drawing.Point(140, 3)
        Me.txt_carID.Margin = New System.Windows.Forms.Padding(140, 3, 3, 3)
        Me.txt_carID.Name = "txt_carID"
        Me.txt_carID.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.txt_carID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_carID.PlaceholderText = "CAR ID"
        Me.txt_carID.ReadOnly = True
        Me.txt_carID.SelectedText = ""
        Me.txt_carID.ShadowDecoration.Parent = Me.txt_carID
        Me.txt_carID.Size = New System.Drawing.Size(69, 36)
        Me.txt_carID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_carID.TabIndex = 6
        Me.txt_carID.TabStop = False
        '
        'txt_color
        '
        Me.txt_color.Animated = True
        Me.txt_color.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_color.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_color.DefaultText = ""
        Me.txt_color.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_color.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_color.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_color.DisabledState.Parent = Me.txt_color
        Me.txt_color.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_color.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_color.FocusedState.Parent = Me.txt_color
        Me.txt_color.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_color.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_color.ForeColor = System.Drawing.Color.Black
        Me.txt_color.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_color.HoverState.Parent = Me.txt_color
        Me.txt_color.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_color.Location = New System.Drawing.Point(512, 147)
        Me.txt_color.Margin = New System.Windows.Forms.Padding(50, 3, 3, 3)
        Me.txt_color.Name = "txt_color"
        Me.txt_color.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.txt_color.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_color.PlaceholderText = "COLOR"
        Me.txt_color.SelectedText = ""
        Me.txt_color.ShadowDecoration.Parent = Me.txt_color
        Me.txt_color.Size = New System.Drawing.Size(267, 36)
        Me.txt_color.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_color.TabIndex = 6
        '
        'txt_chassisno
        '
        Me.txt_chassisno.Animated = True
        Me.txt_chassisno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_chassisno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_chassisno.DefaultText = ""
        Me.txt_chassisno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_chassisno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_chassisno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_chassisno.DisabledState.Parent = Me.txt_chassisno
        Me.txt_chassisno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_chassisno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_chassisno.FocusedState.Parent = Me.txt_chassisno
        Me.txt_chassisno.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_chassisno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_chassisno.ForeColor = System.Drawing.Color.Black
        Me.txt_chassisno.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_chassisno.HoverState.Parent = Me.txt_chassisno
        Me.txt_chassisno.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_chassisno.Location = New System.Drawing.Point(512, 99)
        Me.txt_chassisno.Margin = New System.Windows.Forms.Padding(50, 3, 3, 3)
        Me.txt_chassisno.Name = "txt_chassisno"
        Me.txt_chassisno.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.txt_chassisno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_chassisno.PlaceholderText = "CHASSIS NO."
        Me.txt_chassisno.SelectedText = ""
        Me.txt_chassisno.ShadowDecoration.Parent = Me.txt_chassisno
        Me.txt_chassisno.Size = New System.Drawing.Size(267, 36)
        Me.txt_chassisno.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_chassisno.TabIndex = 4
        '
        'txt_plateno
        '
        Me.txt_plateno.Animated = True
        Me.txt_plateno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_plateno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_plateno.DefaultText = ""
        Me.txt_plateno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_plateno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_plateno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_plateno.DisabledState.Parent = Me.txt_plateno
        Me.txt_plateno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_plateno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_plateno.FocusedState.Parent = Me.txt_plateno
        Me.txt_plateno.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_plateno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_plateno.ForeColor = System.Drawing.Color.Black
        Me.txt_plateno.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_plateno.HoverState.Parent = Me.txt_plateno
        Me.txt_plateno.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_plateno.Location = New System.Drawing.Point(512, 51)
        Me.txt_plateno.Margin = New System.Windows.Forms.Padding(50, 3, 3, 3)
        Me.txt_plateno.Name = "txt_plateno"
        Me.txt_plateno.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.txt_plateno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_plateno.PlaceholderText = "PLATE NO."
        Me.txt_plateno.SelectedText = ""
        Me.txt_plateno.ShadowDecoration.Parent = Me.txt_plateno
        Me.txt_plateno.Size = New System.Drawing.Size(267, 36)
        Me.txt_plateno.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_plateno.TabIndex = 2
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
        Me.DataGridView1.ColumnHeadersHeight = 25
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.carprice})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(140, 370)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(720, 212)
        Me.DataGridView1.TabIndex = 19
        Me.DataGridView1.TabStop = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "carid"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column2.HeaderText = "PlateNo."
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column2.Width = 84
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Car Name/Model"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "ChassisNo."
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column4.Width = 98
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "EngineNo."
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column5.Width = 95
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Color"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column6.Width = 65
        '
        'carprice
        '
        Me.carprice.HeaderText = "Price"
        Me.carprice.Name = "carprice"
        Me.carprice.ReadOnly = True
        Me.carprice.Visible = False
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
        Me.btn_delete.Location = New System.Drawing.Point(656, 320)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.PressedColor = System.Drawing.Color.White
        Me.btn_delete.ShadowDecoration.Parent = Me.btn_delete
        Me.btn_delete.Size = New System.Drawing.Size(99, 32)
        Me.btn_delete.TabIndex = 4
        Me.btn_delete.Text = "&Delete"
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
        Me.btn_edit.Location = New System.Drawing.Point(551, 320)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.PressedColor = System.Drawing.Color.White
        Me.btn_edit.ShadowDecoration.Parent = Me.btn_edit
        Me.btn_edit.Size = New System.Drawing.Size(99, 32)
        Me.btn_edit.TabIndex = 3
        Me.btn_edit.Text = "&Update"
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
        Me.btm_save.Location = New System.Drawing.Point(446, 320)
        Me.btm_save.Name = "btm_save"
        Me.btm_save.PressedColor = System.Drawing.Color.White
        Me.btm_save.ShadowDecoration.Parent = Me.btm_save
        Me.btm_save.Size = New System.Drawing.Size(99, 32)
        Me.btm_save.TabIndex = 2
        Me.btm_save.Text = "&Save"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(924, 60)
        Me.Panel1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI Semilight", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(135, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.Label1.Size = New System.Drawing.Size(144, 48)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Manage Cars"
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
        Me.btn_refresh.Location = New System.Drawing.Point(25, 320)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.PressedColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btn_refresh.ShadowDecoration.Parent = Me.btn_refresh
        Me.btn_refresh.Size = New System.Drawing.Size(32, 32)
        Me.btn_refresh.TabIndex = 6
        Me.btn_refresh.Text = "↺"
        '
        'btn_sell
        '
        Me.btn_sell.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_sell.Animated = True
        Me.btn_sell.AnimatedGIF = True
        Me.btn_sell.BorderColor = System.Drawing.Color.White
        Me.btn_sell.BorderRadius = 5
        Me.btn_sell.BorderThickness = 1
        Me.btn_sell.CheckedState.Parent = Me.btn_sell
        Me.btn_sell.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sell.CustomImages.Parent = Me.btn_sell
        Me.btn_sell.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_sell.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_sell.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_sell.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_sell.DisabledState.Parent = Me.btn_sell
        Me.btn_sell.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btn_sell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_sell.ForeColor = System.Drawing.Color.White
        Me.btn_sell.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btn_sell.HoverState.FillColor = System.Drawing.Color.Gold
        Me.btn_sell.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btn_sell.HoverState.Parent = Me.btn_sell
        Me.btn_sell.Location = New System.Drawing.Point(761, 320)
        Me.btn_sell.Name = "btn_sell"
        Me.btn_sell.PressedColor = System.Drawing.Color.White
        Me.btn_sell.ShadowDecoration.Parent = Me.btn_sell
        Me.btn_sell.Size = New System.Drawing.Size(99, 32)
        Me.btn_sell.TabIndex = 5
        Me.btn_sell.Text = "S&ell"
        '
        'FormCars
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(924, 621)
        Me.Controls.Add(Me.btn_sell)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btm_save)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormCars"
        Me.Text = "Cars"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt_search As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txt_color As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_chassisno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_carname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_plateno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_delete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_edit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btm_save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_refresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_carID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_carprice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_engineno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents carprice As DataGridViewTextBoxColumn
    Friend WithEvents btn_sell As Guna.UI2.WinForms.Guna2Button
End Class
