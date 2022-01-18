<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCustomers
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_search = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_address = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_custname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_custID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_invoice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_plate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_phone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.trandate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txt_insurance = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_chassisno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_engineno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_color = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_maker = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.custid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custaddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custphone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlateNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.maker = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.engineno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chassisno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.insurance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serviceslst = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.partslst = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quanty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_delete = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_edit = New Guna.UI2.WinForms.Guna2Button()
        Me.btm_save = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_refresh = New Guna.UI2.WinForms.Guna2Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.list_Services = New System.Windows.Forms.ListBox()
        Me.Btn_Print = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_rmvlst = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_addtl = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_service = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.list_Parts = New System.Windows.Forms.ListBox()
        Me.txt_parts = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_qty = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_search
        '
        Me.txt_search.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_search.Animated = True
        Me.txt_search.BackColor = System.Drawing.Color.White
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
        Me.txt_search.Location = New System.Drawing.Point(95, 454)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(80, 3, 3, 3)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.txt_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_search.PlaceholderText = "Search...."
        Me.txt_search.SelectedText = ""
        Me.txt_search.ShadowDecoration.Parent = Me.txt_search
        Me.txt_search.Size = New System.Drawing.Size(290, 36)
        Me.txt_search.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_search.TabIndex = 4
        Me.txt_search.TabStop = False
        '
        'txt_address
        '
        Me.txt_address.Animated = True
        Me.txt_address.BackColor = System.Drawing.Color.White
        Me.txt_address.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_address.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_address.DefaultText = ""
        Me.txt_address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_address.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_address.DisabledState.Parent = Me.txt_address
        Me.txt_address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_address.FocusedState.Parent = Me.txt_address
        Me.txt_address.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_address.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_address.ForeColor = System.Drawing.Color.Black
        Me.txt_address.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_address.HoverState.Parent = Me.txt_address
        Me.txt_address.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_address.Location = New System.Drawing.Point(95, 87)
        Me.txt_address.Margin = New System.Windows.Forms.Padding(95, 3, 3, 3)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.txt_address.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_address.PlaceholderText = "ADDRESS"
        Me.txt_address.SelectedText = ""
        Me.txt_address.ShadowDecoration.Parent = Me.txt_address
        Me.txt_address.Size = New System.Drawing.Size(285, 36)
        Me.txt_address.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_address.TabIndex = 2
        '
        'txt_custname
        '
        Me.txt_custname.BackColor = System.Drawing.Color.White
        Me.txt_custname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_custname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_custname.DefaultText = ""
        Me.txt_custname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_custname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_custname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_custname.DisabledState.Parent = Me.txt_custname
        Me.txt_custname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_custname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_custname.FocusedState.Parent = Me.txt_custname
        Me.txt_custname.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_custname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_custname.ForeColor = System.Drawing.Color.Black
        Me.txt_custname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_custname.HoverState.Parent = Me.txt_custname
        Me.txt_custname.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_custname.Location = New System.Drawing.Point(95, 45)
        Me.txt_custname.Margin = New System.Windows.Forms.Padding(95, 3, 3, 3)
        Me.txt_custname.Name = "txt_custname"
        Me.txt_custname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_custname.PlaceholderText = "CUSTOMER NAME"
        Me.txt_custname.SelectedText = ""
        Me.txt_custname.ShadowDecoration.Parent = Me.txt_custname
        Me.txt_custname.Size = New System.Drawing.Size(285, 36)
        Me.txt_custname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_custname.TabIndex = 1
        '
        'txt_custID
        '
        Me.txt_custID.Animated = True
        Me.txt_custID.BackColor = System.Drawing.Color.White
        Me.txt_custID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_custID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_custID.DefaultText = ""
        Me.txt_custID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_custID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_custID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_custID.DisabledState.Parent = Me.txt_custID
        Me.txt_custID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_custID.Enabled = False
        Me.txt_custID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_custID.FocusedState.Parent = Me.txt_custID
        Me.txt_custID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_custID.ForeColor = System.Drawing.Color.Black
        Me.txt_custID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_custID.HoverState.Parent = Me.txt_custID
        Me.txt_custID.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_custID.Location = New System.Drawing.Point(482, 3)
        Me.txt_custID.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.txt_custID.Name = "txt_custID"
        Me.txt_custID.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.txt_custID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_custID.PlaceholderText = "ID"
        Me.txt_custID.ReadOnly = True
        Me.txt_custID.SelectedText = ""
        Me.txt_custID.ShadowDecoration.Parent = Me.txt_custID
        Me.txt_custID.Size = New System.Drawing.Size(83, 36)
        Me.txt_custID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_custID.TabIndex = 0
        Me.txt_custID.TabStop = False
        Me.txt_custID.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txt_invoice, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_plate, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_custID, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_custname, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_phone, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_address, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.trandate, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_insurance, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_chassisno, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_engineno, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_color, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_maker, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 63)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(924, 250)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'txt_invoice
        '
        Me.txt_invoice.Animated = True
        Me.txt_invoice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_invoice.DefaultText = ""
        Me.txt_invoice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_invoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_invoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_invoice.DisabledState.Parent = Me.txt_invoice
        Me.txt_invoice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_invoice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_invoice.FocusedState.Parent = Me.txt_invoice
        Me.txt_invoice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_invoice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_invoice.HoverState.Parent = Me.txt_invoice
        Me.txt_invoice.Location = New System.Drawing.Point(95, 3)
        Me.txt_invoice.Margin = New System.Windows.Forms.Padding(95, 3, 3, 3)
        Me.txt_invoice.Name = "txt_invoice"
        Me.txt_invoice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_invoice.PlaceholderText = ""
        Me.txt_invoice.ReadOnly = True
        Me.txt_invoice.SelectedText = ""
        Me.txt_invoice.ShadowDecoration.Parent = Me.txt_invoice
        Me.txt_invoice.Size = New System.Drawing.Size(134, 36)
        Me.txt_invoice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_invoice.TabIndex = 48
        Me.txt_invoice.TabStop = False
        '
        'txt_plate
        '
        Me.txt_plate.BackColor = System.Drawing.Color.White
        Me.txt_plate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_plate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_plate.DefaultText = ""
        Me.txt_plate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_plate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_plate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_plate.DisabledState.Parent = Me.txt_plate
        Me.txt_plate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_plate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_plate.FocusedState.Parent = Me.txt_plate
        Me.txt_plate.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_plate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_plate.ForeColor = System.Drawing.Color.Black
        Me.txt_plate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_plate.HoverState.Parent = Me.txt_plate
        Me.txt_plate.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_plate.Location = New System.Drawing.Point(95, 212)
        Me.txt_plate.Margin = New System.Windows.Forms.Padding(95, 3, 3, 3)
        Me.txt_plate.Name = "txt_plate"
        Me.txt_plate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_plate.PlaceholderText = "PLATE NO."
        Me.txt_plate.SelectedText = ""
        Me.txt_plate.ShadowDecoration.Parent = Me.txt_plate
        Me.txt_plate.Size = New System.Drawing.Size(285, 35)
        Me.txt_plate.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_plate.TabIndex = 5
        '
        'txt_phone
        '
        Me.txt_phone.Animated = True
        Me.txt_phone.BackColor = System.Drawing.Color.White
        Me.txt_phone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_phone.DefaultText = ""
        Me.txt_phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_phone.DisabledState.Parent = Me.txt_phone
        Me.txt_phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_phone.FocusedState.Parent = Me.txt_phone
        Me.txt_phone.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_phone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_phone.ForeColor = System.Drawing.Color.Black
        Me.txt_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_phone.HoverState.Parent = Me.txt_phone
        Me.txt_phone.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_phone.Location = New System.Drawing.Point(95, 129)
        Me.txt_phone.Margin = New System.Windows.Forms.Padding(95, 3, 3, 3)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.txt_phone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_phone.PlaceholderText = "CONTACT NO. (09xxxxxxxxx)"
        Me.txt_phone.SelectedText = ""
        Me.txt_phone.ShadowDecoration.Parent = Me.txt_phone
        Me.txt_phone.Size = New System.Drawing.Size(285, 36)
        Me.txt_phone.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_phone.TabIndex = 3
        '
        'trandate
        '
        Me.trandate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.trandate.CheckedState.Parent = Me.trandate
        Me.trandate.FillColor = System.Drawing.Color.White
        Me.trandate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.trandate.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.trandate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.trandate.HoverState.Parent = Me.trandate
        Me.trandate.IndicateFocus = True
        Me.trandate.Location = New System.Drawing.Point(97, 171)
        Me.trandate.Margin = New System.Windows.Forms.Padding(25, 3, 3, 3)
        Me.trandate.MaxDate = New Date(2040, 12, 31, 0, 0, 0, 0)
        Me.trandate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.trandate.Name = "trandate"
        Me.trandate.ShadowDecoration.Parent = Me.trandate
        Me.trandate.Size = New System.Drawing.Size(289, 35)
        Me.trandate.TabIndex = 4
        Me.trandate.TabStop = False
        Me.trandate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.trandate.Value = New Date(2021, 6, 15, 12, 45, 55, 655)
        '
        'txt_insurance
        '
        Me.txt_insurance.BackColor = System.Drawing.Color.White
        Me.txt_insurance.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_insurance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_insurance.DefaultText = ""
        Me.txt_insurance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_insurance.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_insurance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_insurance.DisabledState.Parent = Me.txt_insurance
        Me.txt_insurance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_insurance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_insurance.FocusedState.Parent = Me.txt_insurance
        Me.txt_insurance.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_insurance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_insurance.ForeColor = System.Drawing.Color.Black
        Me.txt_insurance.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_insurance.HoverState.Parent = Me.txt_insurance
        Me.txt_insurance.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_insurance.Location = New System.Drawing.Point(482, 212)
        Me.txt_insurance.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.txt_insurance.Name = "txt_insurance"
        Me.txt_insurance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_insurance.PlaceholderText = "INSURANCE"
        Me.txt_insurance.SelectedText = ""
        Me.txt_insurance.ShadowDecoration.Parent = Me.txt_insurance
        Me.txt_insurance.Size = New System.Drawing.Size(285, 35)
        Me.txt_insurance.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_insurance.TabIndex = 10
        '
        'txt_chassisno
        '
        Me.txt_chassisno.BackColor = System.Drawing.Color.White
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
        Me.txt_chassisno.Location = New System.Drawing.Point(482, 171)
        Me.txt_chassisno.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.txt_chassisno.Name = "txt_chassisno"
        Me.txt_chassisno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_chassisno.PlaceholderText = "CHASSIS NO."
        Me.txt_chassisno.SelectedText = ""
        Me.txt_chassisno.ShadowDecoration.Parent = Me.txt_chassisno
        Me.txt_chassisno.Size = New System.Drawing.Size(285, 35)
        Me.txt_chassisno.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_chassisno.TabIndex = 9
        '
        'txt_engineno
        '
        Me.txt_engineno.BackColor = System.Drawing.Color.White
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
        Me.txt_engineno.Location = New System.Drawing.Point(482, 129)
        Me.txt_engineno.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.txt_engineno.Name = "txt_engineno"
        Me.txt_engineno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_engineno.PlaceholderText = "ENGINE NO."
        Me.txt_engineno.SelectedText = ""
        Me.txt_engineno.ShadowDecoration.Parent = Me.txt_engineno
        Me.txt_engineno.Size = New System.Drawing.Size(285, 35)
        Me.txt_engineno.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_engineno.TabIndex = 8
        '
        'txt_color
        '
        Me.txt_color.BackColor = System.Drawing.Color.White
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
        Me.txt_color.Location = New System.Drawing.Point(482, 87)
        Me.txt_color.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.txt_color.Name = "txt_color"
        Me.txt_color.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_color.PlaceholderText = "COLOR"
        Me.txt_color.SelectedText = ""
        Me.txt_color.ShadowDecoration.Parent = Me.txt_color
        Me.txt_color.Size = New System.Drawing.Size(285, 35)
        Me.txt_color.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_color.TabIndex = 7
        '
        'txt_maker
        '
        Me.txt_maker.BackColor = System.Drawing.Color.White
        Me.txt_maker.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_maker.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_maker.DefaultText = ""
        Me.txt_maker.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_maker.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_maker.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_maker.DisabledState.Parent = Me.txt_maker
        Me.txt_maker.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_maker.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_maker.FocusedState.Parent = Me.txt_maker
        Me.txt_maker.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_maker.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_maker.ForeColor = System.Drawing.Color.Black
        Me.txt_maker.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_maker.HoverState.Parent = Me.txt_maker
        Me.txt_maker.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_maker.Location = New System.Drawing.Point(482, 45)
        Me.txt_maker.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.txt_maker.Name = "txt_maker"
        Me.txt_maker.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_maker.PlaceholderText = "MAKER"
        Me.txt_maker.SelectedText = ""
        Me.txt_maker.ShadowDecoration.Parent = Me.txt_maker
        Me.txt_maker.Size = New System.Drawing.Size(285, 35)
        Me.txt_maker.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_maker.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.custid, Me.invoice, Me.custname, Me.custaddress, Me.custphone, Me.custdate, Me.PlateNo, Me.maker, Me.color, Me.engineno, Me.chassisno, Me.insurance, Me.serviceslst, Me.partslst, Me.quanty})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(12, 496)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(900, 224)
        Me.DataGridView1.TabIndex = 19
        Me.DataGridView1.TabStop = False
        '
        'custid
        '
        Me.custid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.custid.HeaderText = "CustomerID"
        Me.custid.Name = "custid"
        Me.custid.ReadOnly = True
        Me.custid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.custid.Visible = False
        Me.custid.Width = 200
        '
        'invoice
        '
        Me.invoice.HeaderText = "invoice"
        Me.invoice.Name = "invoice"
        Me.invoice.ReadOnly = True
        Me.invoice.Visible = False
        '
        'custname
        '
        Me.custname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.custname.HeaderText = "CustomerName"
        Me.custname.Name = "custname"
        Me.custname.ReadOnly = True
        Me.custname.Width = 128
        '
        'custaddress
        '
        Me.custaddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.custaddress.HeaderText = "Address"
        Me.custaddress.Name = "custaddress"
        Me.custaddress.ReadOnly = True
        Me.custaddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.custaddress.Width = 63
        '
        'custphone
        '
        Me.custphone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.custphone.HeaderText = "PhoneNo."
        Me.custphone.Name = "custphone"
        Me.custphone.ReadOnly = True
        Me.custphone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.custphone.Width = 74
        '
        'custdate
        '
        Me.custdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.custdate.HeaderText = "Date"
        Me.custdate.Name = "custdate"
        Me.custdate.ReadOnly = True
        Me.custdate.Width = 61
        '
        'PlateNo
        '
        Me.PlateNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PlateNo.HeaderText = "PlateNo."
        Me.PlateNo.Name = "PlateNo"
        Me.PlateNo.ReadOnly = True
        Me.PlateNo.Width = 84
        '
        'maker
        '
        Me.maker.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.maker.HeaderText = "Maker"
        Me.maker.Name = "maker"
        Me.maker.ReadOnly = True
        Me.maker.Width = 71
        '
        'color
        '
        Me.color.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.color.HeaderText = "Color"
        Me.color.Name = "color"
        Me.color.ReadOnly = True
        Me.color.Width = 65
        '
        'engineno
        '
        Me.engineno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.engineno.HeaderText = "EngineNo."
        Me.engineno.Name = "engineno"
        Me.engineno.ReadOnly = True
        Me.engineno.Width = 95
        '
        'chassisno
        '
        Me.chassisno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.chassisno.HeaderText = "ChassisNo."
        Me.chassisno.Name = "chassisno"
        Me.chassisno.ReadOnly = True
        Me.chassisno.Width = 98
        '
        'insurance
        '
        Me.insurance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.insurance.HeaderText = "Insurance"
        Me.insurance.Name = "insurance"
        Me.insurance.ReadOnly = True
        Me.insurance.Width = 200
        '
        'serviceslst
        '
        Me.serviceslst.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.serviceslst.HeaderText = "serviceslst"
        Me.serviceslst.Name = "serviceslst"
        Me.serviceslst.ReadOnly = True
        Me.serviceslst.Visible = False
        '
        'partslst
        '
        Me.partslst.HeaderText = "partslst"
        Me.partslst.Name = "partslst"
        Me.partslst.ReadOnly = True
        Me.partslst.Visible = False
        '
        'quanty
        '
        Me.quanty.HeaderText = "quanty"
        Me.quanty.Name = "quanty"
        Me.quanty.ReadOnly = True
        Me.quanty.Visible = False
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
        Me.btn_delete.Location = New System.Drawing.Point(703, 458)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.PressedColor = System.Drawing.Color.White
        Me.btn_delete.ShadowDecoration.Parent = Me.btn_delete
        Me.btn_delete.Size = New System.Drawing.Size(99, 32)
        Me.btn_delete.TabIndex = 9
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
        Me.btn_edit.Location = New System.Drawing.Point(598, 458)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.PressedColor = System.Drawing.Color.White
        Me.btn_edit.ShadowDecoration.Parent = Me.btn_edit
        Me.btn_edit.Size = New System.Drawing.Size(99, 32)
        Me.btn_edit.TabIndex = 8
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
        Me.btm_save.Location = New System.Drawing.Point(493, 458)
        Me.btm_save.Name = "btm_save"
        Me.btm_save.PressedColor = System.Drawing.Color.White
        Me.btm_save.ShadowDecoration.Parent = Me.btm_save
        Me.btm_save.Size = New System.Drawing.Size(99, 32)
        Me.btm_save.TabIndex = 7
        Me.btm_save.Text = "&Save"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(924, 57)
        Me.Panel1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI Semilight", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.Label1.Size = New System.Drawing.Size(202, 48)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Manage Customers"
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
        Me.btn_refresh.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_refresh.ForeColor = System.Drawing.Color.White
        Me.btn_refresh.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btn_refresh.HoverState.FillColor = System.Drawing.Color.White
        Me.btn_refresh.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btn_refresh.HoverState.Parent = Me.btn_refresh
        Me.btn_refresh.Location = New System.Drawing.Point(15, 458)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.PressedColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btn_refresh.ShadowDecoration.Parent = Me.btn_refresh
        Me.btn_refresh.Size = New System.Drawing.Size(32, 32)
        Me.btn_refresh.TabIndex = 11
        Me.btn_refresh.Text = "↺"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkGray
        Me.Label11.Location = New System.Drawing.Point(92, 316)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 15)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "SEVICES:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'list_Services
        '
        Me.list_Services.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.list_Services.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_Services.FormattingEnabled = True
        Me.list_Services.ItemHeight = 15
        Me.list_Services.Location = New System.Drawing.Point(94, 334)
        Me.list_Services.Name = "list_Services"
        Me.list_Services.Size = New System.Drawing.Size(351, 64)
        Me.list_Services.TabIndex = 11
        Me.list_Services.TabStop = False
        '
        'Btn_Print
        '
        Me.Btn_Print.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Btn_Print.Animated = True
        Me.Btn_Print.AnimatedGIF = True
        Me.Btn_Print.BorderRadius = 5
        Me.Btn_Print.CheckedState.Parent = Me.Btn_Print
        Me.Btn_Print.CustomImages.Parent = Me.Btn_Print
        Me.Btn_Print.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Print.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Print.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Print.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_Print.DisabledState.Parent = Me.Btn_Print
        Me.Btn_Print.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Btn_Print.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Print.ForeColor = System.Drawing.Color.White
        Me.Btn_Print.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Btn_Print.HoverState.FillColor = System.Drawing.Color.Gold
        Me.Btn_Print.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Btn_Print.HoverState.Parent = Me.Btn_Print
        Me.Btn_Print.Location = New System.Drawing.Point(808, 458)
        Me.Btn_Print.Name = "Btn_Print"
        Me.Btn_Print.ShadowDecoration.Parent = Me.Btn_Print
        Me.Btn_Print.Size = New System.Drawing.Size(104, 32)
        Me.Btn_Print.TabIndex = 10
        Me.Btn_Print.Text = "&Print"
        '
        'btn_rmvlst
        '
        Me.btn_rmvlst.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_rmvlst.Animated = True
        Me.btn_rmvlst.AnimatedGIF = True
        Me.btn_rmvlst.BorderRadius = 5
        Me.btn_rmvlst.CheckedState.Parent = Me.btn_rmvlst
        Me.btn_rmvlst.CustomImages.Parent = Me.btn_rmvlst
        Me.btn_rmvlst.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_rmvlst.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_rmvlst.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_rmvlst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_rmvlst.DisabledState.Parent = Me.btn_rmvlst
        Me.btn_rmvlst.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btn_rmvlst.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_rmvlst.ForeColor = System.Drawing.Color.White
        Me.btn_rmvlst.HoverState.Parent = Me.btn_rmvlst
        Me.btn_rmvlst.Location = New System.Drawing.Point(787, 394)
        Me.btn_rmvlst.Name = "btn_rmvlst"
        Me.btn_rmvlst.ShadowDecoration.Parent = Me.btn_rmvlst
        Me.btn_rmvlst.Size = New System.Drawing.Size(125, 45)
        Me.btn_rmvlst.TabIndex = 6
        Me.btn_rmvlst.Text = "&Remove from list"
        '
        'btn_addtl
        '
        Me.btn_addtl.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_addtl.Animated = True
        Me.btn_addtl.AnimatedGIF = True
        Me.btn_addtl.BorderRadius = 5
        Me.btn_addtl.CheckedState.Parent = Me.btn_addtl
        Me.btn_addtl.CustomImages.Parent = Me.btn_addtl
        Me.btn_addtl.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_addtl.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_addtl.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_addtl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_addtl.DisabledState.Parent = Me.btn_addtl
        Me.btn_addtl.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btn_addtl.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_addtl.ForeColor = System.Drawing.Color.White
        Me.btn_addtl.HoverState.Parent = Me.btn_addtl
        Me.btn_addtl.Location = New System.Drawing.Point(787, 334)
        Me.btn_addtl.Name = "btn_addtl"
        Me.btn_addtl.ShadowDecoration.Parent = Me.btn_addtl
        Me.btn_addtl.Size = New System.Drawing.Size(125, 45)
        Me.btn_addtl.TabIndex = 5
        Me.btn_addtl.Text = "&Add to list"
        '
        'txt_service
        '
        Me.txt_service.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_service.BackColor = System.Drawing.Color.White
        Me.txt_service.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_service.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_service.DefaultText = ""
        Me.txt_service.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_service.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_service.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_service.DisabledState.Parent = Me.txt_service
        Me.txt_service.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_service.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_service.FocusedState.Parent = Me.txt_service
        Me.txt_service.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_service.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_service.ForeColor = System.Drawing.Color.Black
        Me.txt_service.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_service.HoverState.Parent = Me.txt_service
        Me.txt_service.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_service.Location = New System.Drawing.Point(94, 404)
        Me.txt_service.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.txt_service.Name = "txt_service"
        Me.txt_service.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_service.PlaceholderText = "SERVICE - PRICE ( I.E. CARWASH - 200 )"
        Me.txt_service.SelectedText = ""
        Me.txt_service.ShadowDecoration.Parent = Me.txt_service
        Me.txt_service.Size = New System.Drawing.Size(351, 35)
        Me.txt_service.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_service.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(480, 316)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "PARTS:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'list_Parts
        '
        Me.list_Parts.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.list_Parts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_Parts.FormattingEnabled = True
        Me.list_Parts.ItemHeight = 15
        Me.list_Parts.Location = New System.Drawing.Point(482, 334)
        Me.list_Parts.Name = "list_Parts"
        Me.list_Parts.Size = New System.Drawing.Size(300, 64)
        Me.list_Parts.TabIndex = 11
        Me.list_Parts.TabStop = False
        '
        'txt_parts
        '
        Me.txt_parts.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_parts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_parts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_parts.BackColor = System.Drawing.Color.White
        Me.txt_parts.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_parts.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_parts.DefaultText = ""
        Me.txt_parts.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_parts.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_parts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_parts.DisabledState.Parent = Me.txt_parts
        Me.txt_parts.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_parts.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_parts.FocusedState.Parent = Me.txt_parts
        Me.txt_parts.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_parts.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_parts.ForeColor = System.Drawing.Color.Black
        Me.txt_parts.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_parts.HoverState.Parent = Me.txt_parts
        Me.txt_parts.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_parts.Location = New System.Drawing.Point(483, 404)
        Me.txt_parts.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.txt_parts.Name = "txt_parts"
        Me.txt_parts.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_parts.PlaceholderText = "PART NAME"
        Me.txt_parts.SelectedText = ""
        Me.txt_parts.ShadowDecoration.Parent = Me.txt_parts
        Me.txt_parts.Size = New System.Drawing.Size(214, 35)
        Me.txt_parts.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_parts.TabIndex = 3
        '
        'txt_qty
        '
        Me.txt_qty.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_qty.Animated = True
        Me.txt_qty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_qty.DefaultText = ""
        Me.txt_qty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_qty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_qty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_qty.DisabledState.Parent = Me.txt_qty
        Me.txt_qty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_qty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_qty.FocusedState.Parent = Me.txt_qty
        Me.txt_qty.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_qty.ForeColor = System.Drawing.Color.Black
        Me.txt_qty.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_qty.HoverState.Parent = Me.txt_qty
        Me.txt_qty.Location = New System.Drawing.Point(710, 403)
        Me.txt_qty.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.txt_qty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_qty.PlaceholderText = "QTY"
        Me.txt_qty.SelectedText = ""
        Me.txt_qty.ShadowDecoration.Parent = Me.txt_qty
        Me.txt_qty.Size = New System.Drawing.Size(72, 36)
        Me.txt_qty.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_qty.TabIndex = 4
        Me.txt_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FormCustomers
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(924, 767)
        Me.Controls.Add(Me.txt_qty)
        Me.Controls.Add(Me.txt_parts)
        Me.Controls.Add(Me.txt_service)
        Me.Controls.Add(Me.btn_rmvlst)
        Me.Controls.Add(Me.btn_addtl)
        Me.Controls.Add(Me.Btn_Print)
        Me.Controls.Add(Me.list_Parts)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.list_Services)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btm_save)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "FormCustomers"
        Me.Text = "Customers"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_search As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_address As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_custname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_custID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_delete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_edit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btm_save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_phone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_refresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_plate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_maker As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_color As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_engineno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_chassisno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_insurance As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents trandate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents list_Services As ListBox
    Friend WithEvents txt_invoice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Btn_Print As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_rmvlst As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_addtl As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_service As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents list_Parts As ListBox
    Friend WithEvents txt_parts As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_qty As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents custid As DataGridViewTextBoxColumn
    Friend WithEvents invoice As DataGridViewTextBoxColumn
    Friend WithEvents custname As DataGridViewTextBoxColumn
    Friend WithEvents custaddress As DataGridViewTextBoxColumn
    Friend WithEvents custphone As DataGridViewTextBoxColumn
    Friend WithEvents custdate As DataGridViewTextBoxColumn
    Friend WithEvents PlateNo As DataGridViewTextBoxColumn
    Friend WithEvents maker As DataGridViewTextBoxColumn
    Friend WithEvents color As DataGridViewTextBoxColumn
    Friend WithEvents engineno As DataGridViewTextBoxColumn
    Friend WithEvents chassisno As DataGridViewTextBoxColumn
    Friend WithEvents insurance As DataGridViewTextBoxColumn
    Friend WithEvents serviceslst As DataGridViewTextBoxColumn
    Friend WithEvents partslst As DataGridViewTextBoxColumn
    Friend WithEvents quanty As DataGridViewTextBoxColumn
End Class
