<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formstockadjustment
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
        Me.components = New System.ComponentModel.Container()
        Me.Btn_save = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_stockqty = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_productname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_procode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.SuspendLayout()
        '
        'Btn_save
        '
        Me.Btn_save.Animated = True
        Me.Btn_save.AnimatedGIF = True
        Me.Btn_save.BorderRadius = 5
        Me.Btn_save.CheckedState.Parent = Me.Btn_save
        Me.Btn_save.CustomImages.Parent = Me.Btn_save
        Me.Btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_save.DisabledState.Parent = Me.Btn_save
        Me.Btn_save.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Btn_save.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_save.ForeColor = System.Drawing.Color.White
        Me.Btn_save.HoverState.Parent = Me.Btn_save
        Me.Btn_save.Location = New System.Drawing.Point(287, 225)
        Me.Btn_save.Name = "Btn_save"
        Me.Btn_save.ShadowDecoration.Parent = Me.Btn_save
        Me.Btn_save.Size = New System.Drawing.Size(102, 32)
        Me.Btn_save.TabIndex = 42
        Me.Btn_save.Text = "Add"
        '
        'txt_stockqty
        '
        Me.txt_stockqty.BackColor = System.Drawing.SystemColors.Menu
        Me.txt_stockqty.BorderThickness = 0
        Me.txt_stockqty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_stockqty.DefaultText = ""
        Me.txt_stockqty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_stockqty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_stockqty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_stockqty.DisabledState.Parent = Me.txt_stockqty
        Me.txt_stockqty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_stockqty.FillColor = System.Drawing.SystemColors.Menu
        Me.txt_stockqty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_stockqty.FocusedState.Parent = Me.txt_stockqty
        Me.txt_stockqty.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_stockqty.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_stockqty.HoverState.Parent = Me.txt_stockqty
        Me.txt_stockqty.Location = New System.Drawing.Point(169, 167)
        Me.txt_stockqty.Name = "txt_stockqty"
        Me.txt_stockqty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_stockqty.PlaceholderText = ""
        Me.txt_stockqty.SelectedText = ""
        Me.txt_stockqty.ShadowDecoration.Parent = Me.txt_stockqty
        Me.txt_stockqty.Size = New System.Drawing.Size(220, 36)
        Me.txt_stockqty.TabIndex = 41
        Me.txt_stockqty.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txt_productname
        '
        Me.txt_productname.BackColor = System.Drawing.SystemColors.Menu
        Me.txt_productname.BorderThickness = 0
        Me.txt_productname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_productname.DefaultText = ""
        Me.txt_productname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_productname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_productname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_productname.DisabledState.Parent = Me.txt_productname
        Me.txt_productname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_productname.FillColor = System.Drawing.SystemColors.Menu
        Me.txt_productname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_productname.FocusedState.Parent = Me.txt_productname
        Me.txt_productname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_productname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_productname.HoverState.Parent = Me.txt_productname
        Me.txt_productname.Location = New System.Drawing.Point(169, 121)
        Me.txt_productname.Name = "txt_productname"
        Me.txt_productname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_productname.PlaceholderText = ""
        Me.txt_productname.SelectedText = ""
        Me.txt_productname.ShadowDecoration.Parent = Me.txt_productname
        Me.txt_productname.Size = New System.Drawing.Size(220, 36)
        Me.txt_productname.TabIndex = 40
        Me.txt_productname.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txt_procode
        '
        Me.txt_procode.BackColor = System.Drawing.SystemColors.Menu
        Me.txt_procode.BorderThickness = 0
        Me.txt_procode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_procode.DefaultText = ""
        Me.txt_procode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_procode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_procode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_procode.DisabledState.Parent = Me.txt_procode
        Me.txt_procode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_procode.FillColor = System.Drawing.SystemColors.Menu
        Me.txt_procode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_procode.FocusedState.Parent = Me.txt_procode
        Me.txt_procode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_procode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_procode.HoverState.Parent = Me.txt_procode
        Me.txt_procode.Location = New System.Drawing.Point(169, 76)
        Me.txt_procode.Name = "txt_procode"
        Me.txt_procode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_procode.PlaceholderText = ""
        Me.txt_procode.SelectedText = ""
        Me.txt_procode.ShadowDecoration.Parent = Me.txt_procode
        Me.txt_procode.Size = New System.Drawing.Size(220, 36)
        Me.txt_procode.TabIndex = 39
        Me.txt_procode.TextOffset = New System.Drawing.Point(5, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(43, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(10)
        Me.Label5.Size = New System.Drawing.Size(104, 35)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Stock Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(43, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(10)
        Me.Label4.Size = New System.Drawing.Size(102, 35)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Product Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(43, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(10)
        Me.Label3.Size = New System.Drawing.Size(98, 35)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Product Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI Semilight", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(350, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(10)
        Me.Label2.Size = New System.Drawing.Size(62, 33)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "[ close ]"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI Semilight", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(29, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(10)
        Me.Label1.Size = New System.Drawing.Size(165, 41)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Stock Adjustment"
        '
        'Guna2ShadowForm1
        '
        Me.Guna2ShadowForm1.ShadowColor = System.Drawing.Color.LightGray
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_VER_POSITIVE
        Me.Guna2AnimateWindow1.Interval = 250
        '
        'Formstockadjustment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(440, 272)
        Me.Controls.Add(Me.Btn_save)
        Me.Controls.Add(Me.txt_stockqty)
        Me.Controls.Add(Me.txt_productname)
        Me.Controls.Add(Me.txt_procode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Formstockadjustment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "stockadjustmentfrm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_stockqty As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_productname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_procode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
End Class
