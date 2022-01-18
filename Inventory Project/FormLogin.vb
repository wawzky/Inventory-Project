Imports System.Data.SqlClient
Imports System.IO
Public Class FormLogin
    Dim conn As New SqlConnection("Data Source=(LocalDb)\v11.0;AttachDbFilename=|DataDirectory|\DatabaseInventory.mdf;Integrated Security=True;User ID=admin;Password=adminpass")
    Dim dr As SqlDataReader

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear()
        rolecomboload()
    End Sub

    Sub rolecomboload()
        conn.Open()
        comboUserType.Items.Clear()
        Dim cmd As New SqlCommand("select role from tbluser group by role", conn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                comboUserType.Items.Add(dr.GetString(0))
            End While
        End If
        dr.Close()

        conn.Close()
    End Sub

    Sub clear()
        tbFullNameReg.Clear()
        tbUserNameReg.Clear()
        tbPasswordReg.Clear()
        cbRegUtype.SelectedIndex = -1
        tbPasswordLogin.Clear()
        tbUsernameLogin.Clear()
        comboUserType.SelectedIndex = -1
    End Sub

    Sub login()
        Try
            conn.Open()
            Dim cmd As New SqlCommand("select*from tbluser where username=@username AND password=@password AND role=@role", conn)
            With cmd.Parameters
                .Clear()
                .AddWithValue("@username", tbUsernameLogin.Text)
                .AddWithValue("@password", tbPasswordLogin.Text)
                .AddWithValue("@role", comboUserType.Text)
            End With
            Dim username As String = ""
            Dim password As String = ""
            Dim role As String = ""
            Dim picture() As Byte
            dr = cmd.ExecuteReader
            If (dr.Read() = True) Then
                username = dr("username")
                password = dr("password")
                role = dr("role")
                If Not dr.IsDBNull(5) Then
                    picture = dr("pic")
                    Dim mstream As New MemoryStream(picture)
                    FormHome.main_picturebox.Image = Image.FromStream(mstream)
                Else
                    FormHome.main_picturebox.Image = Nothing
                End If
                MessageBox.Show("Welcome " + tbUsernameLogin.Text + ".", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clear()

                Try
                    With FormHome
                        .main_picturebox.Visible = True
                        .lbl_user.Visible = True
                        .lbl_role.Visible = True
                        .lbl_user.Text = dr.Item("fullname")
                        .lbl_role.Text = dr.Item("role")
                        .PanelMenu.Show()
                        .btn_Dash.PerformClick()
                    End With
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                Me.Close()

            ElseIf (dr.Read() = False) Then
                clear()
                tbUsernameLogin.SelectAll()
                tbUsernameLogin.Focus()
                MessageBox.Show("Login error!" + Environment.NewLine + "Reason: Incorrect username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub reg()
        conn.Open()
        Dim cmd As New SqlCommand("INSERT INTO tbluser(fullname, username, password, role) VALUES (@fullname,@username,@password,@role)", conn)

        With cmd.Parameters
            .Clear()
            .AddWithValue("@fullname", tbFullNameReg.Text)
            .AddWithValue("@username", tbUserNameReg.Text)
            .AddWithValue("@password", tbPasswordReg.Text)
            .AddWithValue("@role", cbRegUtype.Text)
        End With

        Dim i As Integer
        i = cmd.ExecuteNonQuery
        If i > 0 Then
            MessageBox.Show("New user registered successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("New user registration failed!" + Environment.NewLine + "Reason: Data error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        conn.Close()
        clear()
        Guna2Transition1.ShowSync(panelLogin)
        panelLogin.Visible = True
    End Sub

    Private Sub Check_showpass_CheckedChanged(sender As Object, e As EventArgs) Handles Check_showpass.CheckedChanged
        If Check_showpass.Checked = True Then
            tbPasswordLogin.UseSystemPasswordChar = False
        Else
            tbPasswordLogin.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles regChkpass.CheckedChanged
        If regChkpass.Checked = True Then
            tbPasswordReg.UseSystemPasswordChar = False
        Else
            tbPasswordReg.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles buttonLogin.Click

        If tbUsernameLogin.Text = "" And tbPasswordLogin.Text = "" Then
            tbUsernameLogin.SelectAll()
            tbUsernameLogin.Focus()
            MessageBox.Show("Login error!" + Environment.NewLine + "Reason: Empty fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf tbUsernameLogin.Text = "" Then
            tbUsernameLogin.SelectAll()
            tbUsernameLogin.Focus()
            MessageBox.Show("Login error!" + Environment.NewLine + "Reason: Empty username textbox field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf tbPasswordLogin.Text = "" Then
            tbPasswordLogin.SelectAll()
            tbPasswordLogin.Focus()
            MessageBox.Show("Login error!" + Environment.NewLine + "Reason: Empty password textbox field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf comboUserType.SelectedIndex = -1 Then
            comboUserType.SelectAll()
            comboUserType.Focus()
            MessageBox.Show("Login error!" + Environment.NewLine + "Reason: Empty user type field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            login()
        End If
    End Sub

    Private Sub LinkLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLogin.LinkClicked
        clear()
        Guna2Transition1.ShowSync(panelLogin)
        panelLogin.Visible = True
    End Sub

    Private Sub LinkSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkSignUp.LinkClicked
        clear()
        Guna2Transition1.HideSync(panelLogin)
        panelLogin.Visible = False
    End Sub

    Private Sub buttonCreateAccount_Click(sender As Object, e As EventArgs) Handles buttonCreateAccount.Click
        Try
            If tbFullNameReg.Text = "" Then
                tbFullNameReg.SelectAll()
                tbFullNameReg.Focus()
                MessageBox.Show("New user registration failed!" + Environment.NewLine + "Reason: Empty fullname textbox field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf IsNumeric(tbFullNameReg.Text) = True Then
                tbFullNameReg.SelectAll()
                tbFullNameReg.Focus()
                MessageBox.Show("New user registration failed!" + Environment.NewLine + "Reason: Invalid input data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf tbUserNameReg.Text = "" Then
                tbUserNameReg.SelectAll()
                tbUserNameReg.Focus()
                MessageBox.Show("New user registration failed!" + Environment.NewLine + "Reason: Empty username textbox field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf cbRegUtype.SelectedIndex = -1 Then
                cbRegUtype.SelectAll()
                cbRegUtype.Focus()
                MessageBox.Show("New user registration failed!" + Environment.NewLine + "Reason: Empty user type field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf MessageBox.Show("Are you sure add this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                reg()
            End If
        Catch ex As Exception

        Finally
            rolecomboload()
        End Try
    End Sub

End Class