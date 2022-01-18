Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Globalization

Public Class FormHome
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form
    Public Sub New()
        'This call is required by the designer.'
        InitializeComponent()
        PanelMenu.Hide()
        OpenChildForm(New FormLogin)

        'Add any initialization after the InitializeComponent () call.'
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 45)
        PanelMenu.Controls.Add(leftBorderBtn)
        lblFormTitle.Text = currentChildForm.Text
        'Form'
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    Public Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button'
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.Font = New Font("Consolas", 14, FontStyle.Bold)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border'
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'current Form icon'
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor
            lblFormTitle.ForeColor = customColor
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.Font = New Font("Calibri", 11, FontStyle.Regular)
            currentBtn.BackColor = Color.FromArgb(223, 230, 233)
            currentBtn.ForeColor = Color.FromArgb(41, 128, 185)
            currentBtn.IconColor = Color.FromArgb(41, 128, 185)
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
            lblFormTitle.ForeColor = ForeColor.Black
        End If
    End Sub

    Public Sub OpenChildForm(childForm As Form)
        'Open only form'
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblFormTitle.Text = childForm.Text
    End Sub

    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        'currentBtn.Font = New Font(currentBtn.Font, FontStyle.Regular)
        IconCurrentForm.IconChar = IconChar.Home
        IconCurrentForm.IconColor = Color.Black
        lblFormTitle.Text = "Home"
    End Sub
    'Events'
    'Reset'
    'Private Sub imgHome_Click(sender As Object, e As EventArgs) Handles imgHome.Click
    '    If currentChildForm IsNot Nothing Then
    '        currentChildForm.Close()
    '    End If
    '    Reset()
    'End Sub

    'Menu buttons Cliks'
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btn_Dash.Click
        ActivateButton(sender, Color.GhostWhite)
        OpenChildForm(New FormDashboard)
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btn_Product.Click
        ActivateButton(sender, Color.DarkOrange)
        OpenChildForm(New FormProduct)
    End Sub

    Private Sub btn_Inventory_Click(sender As Object, e As EventArgs) Handles btn_Cars.Click
        ActivateButton(sender, Color.DarkViolet)
        OpenChildForm(New FormCars)
    End Sub

    Private Sub btn_Stocks_Click(sender As Object, e As EventArgs) Handles btn_Stocks.Click
        ActivateButton(sender, RGBColors.color7)
        OpenChildForm(New FormStocks)
    End Sub

    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btn_ManUsers.Click
        ActivateButton(sender, Color.SpringGreen)
        OpenChildForm(New FormManageUsers)
    End Sub

    Private Sub btn_Customers_Click(sender As Object, e As EventArgs) Handles btn_Customers.Click
        ActivateButton(sender, Color.DodgerBlue)
        OpenChildForm(New FormCustomers)
    End Sub

    'Drag Form'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    'Close-Maximize-Minimize'
    Private Sub btnEExit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Dim MessageString As String = "Do you want to exit?"
        Dim ButtonDialogResult As DialogResult = MessageBox.Show(MessageString, "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If ButtonDialogResult = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
    Private Sub btn_MinMax_Click(sender As Object, e As EventArgs) Handles btn_MinMax.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub btn_Min_Click(sender As Object, e As EventArgs) Handles btn_Min.Click
        WindowState = FormWindowState.Minimized
    End Sub
    'Remove transparent border in maximized state'
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub btn_Logout_Click(sender As Object, e As EventArgs) Handles btn_Logout.Click
        Dim MessageString As String = "Do you want to log out?"
        Dim ButtonDialogResult As DialogResult = MessageBox.Show(MessageString, "Logout?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If ButtonDialogResult = Windows.Forms.DialogResult.Yes Then
            If currentChildForm IsNot Nothing Then
                currentChildForm.Close()
            End If
            Reset()
            PanelMenu.Hide()
            main_picturebox.Visible = False
            lbl_user.Visible = False
            lbl_role.Visible = False
            OpenChildForm(New FormLogin)
        End If
    End Sub
End Class

