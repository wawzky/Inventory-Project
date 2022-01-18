<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUOM
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
        Me.txt_productcode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.btm_save = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.SuspendLayout()
        '
        'txt_productcode
        '
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
        Me.txt_productcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_productcode.HoverState.Parent = Me.txt_productcode
        Me.txt_productcode.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_productcode.Location = New System.Drawing.Point(26, 69)
        Me.txt_productcode.Margin = New System.Windows.Forms.Padding(80, 3, 3, 3)
        Me.txt_productcode.Name = "txt_productcode"
        Me.txt_productcode.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.txt_productcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_productcode.PlaceholderText = "UOM"
        Me.txt_productcode.SelectedText = ""
        Me.txt_productcode.ShadowDecoration.Parent = Me.txt_productcode
        Me.txt_productcode.Size = New System.Drawing.Size(267, 36)
        Me.txt_productcode.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_productcode.TabIndex = 28
        '
        'Guna2ShadowForm1
        '
        Me.Guna2ShadowForm1.ShadowColor = System.Drawing.Color.Silver
        '
        'btm_save
        '
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
        Me.btm_save.Location = New System.Drawing.Point(312, 73)
        Me.btm_save.Name = "btm_save"
        Me.btm_save.PressedColor = System.Drawing.Color.White
        Me.btm_save.ShadowDecoration.Parent = Me.btm_save
        Me.btm_save.Size = New System.Drawing.Size(86, 32)
        Me.btm_save.TabIndex = 29
        Me.btm_save.Text = "Save"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI Semilight", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(327, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(10)
        Me.Label2.Size = New System.Drawing.Size(71, 33)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "[ close ]"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI Semilight", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(10)
        Me.Label1.Size = New System.Drawing.Size(132, 39)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Add New UOM"
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.Interval = 250
        '
        'FormUOM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(406, 120)
        Me.Controls.Add(Me.txt_productcode)
        Me.Controls.Add(Me.btm_save)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormUOM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUOM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_productcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents btm_save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
End Class
