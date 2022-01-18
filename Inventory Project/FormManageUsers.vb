Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Globalization

Public Class FormManageUsers
    Dim conn As New SqlConnection("Data Source=(LocalDb)\v11.0;AttachDbFilename=|DataDirectory|\DatabaseInventory.mdf;Integrated Security=True;User ID=admin;Password=adminpass")
    Dim dr As SqlDataReader
    Private Sub manageuserfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userdataloading()
    End Sub
    Sub clear()
        txt_fullname.Clear()
        txt_password.Clear()
        txt_username.Clear()
        txt_ID.Clear()
        Btn_Save.Enabled = True
        combo_role.SelectedIndex = -1
        pic_box.Image = Nothing
    End Sub
    Sub userdataloading()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New SqlCommand("Select * from tbluser", conn)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    If DataGridView1.ColumnCount <> 0 Then
                        DataGridView1.Rows.Add(dr.Item("empid").ToString, dr.Item("fullname").ToString, dr.Item("username").ToString, dr.Item("password").ToString, dr.Item("role").ToString, dr.Item("pic"))
                    End If
                End While
            End If
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Sub save()
        Try
            conn.Open()
            Dim cmd As New SqlCommand("INSERT INTO tbluser(fullname, username, password, role, pic) VALUES (@fullname,@username,@password,@role,@pic)", conn)

            With cmd.Parameters
                .Clear()
                .AddWithValue("@fullname", txt_fullname.Text)
                .AddWithValue("@username", txt_username.Text)
                .AddWithValue("@password", txt_password.Text)
                .AddWithValue("@role", combo_role.Text)
                If Not pic_box.Image Is Nothing Then
                    Dim FileSize As New UInt32
                    Dim mstream As New System.IO.MemoryStream
                    pic_box.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim picture() As Byte = mstream.GetBuffer
                    FileSize = mstream.Length
                    mstream.Close()
                    .AddWithValue("@pic", picture)
                Else
                    .Add("@pic", SqlDbType.VarBinary, -1).Value = DBNull.Value
                End If
            End With

            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("New user registered successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("New user registration failed!" + Environment.NewLine + "Reason: Data error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        userdataloading()
        clear()
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        If txt_fullname.Text = "" Or txt_username.Text = "" Or txt_password.Text = "" Or txt_ID.Text <> "" Then
            txt_fullname.SelectAll()
            txt_fullname.Focus()
            MessageBox.Show("New user registration failed!" + Environment.NewLine + "Reason: Incomplete fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf IsNumeric(txt_fullname.Text) Then
            txt_fullname.SelectAll()
            txt_fullname.Focus()
            MessageBox.Show("New user registration failed!" + Environment.NewLine + "Reason: Invalid input data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf pic_box.Image Is Nothing Then
            If MessageBox.Show("Continue without the user's image?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                save()
            End If
        Else
            save()
        End If
    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        OpenFileDialog1.Filter = "Choose Images(*.JPG,*.PNG,*.JPEG,*.GIF)|*.JPG;*.PNG;*.JPEG*.GIF|ALL FILES(*.*)|*.*"

        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            pic_box.Image = Image.FromFile(OpenFileDialog1.FileName)
            OpenFileDialog1.FileName = OpenFileDialog1.FileName


        End If
    End Sub

    Private Sub Check_showpass_Click(sender As Object, e As EventArgs) Handles Check_showpass.Click
        If Check_showpass.Checked = True Then
            txt_password.UseSystemPasswordChar = False
        Else
            txt_password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellDoubleClick
        Btn_Save.Enabled = False

        txt_ID.Text = DataGridView1.CurrentRow.Cells(0).Value
        txt_fullname.Text = DataGridView1.CurrentRow.Cells(1).Value
        txt_username.Text = DataGridView1.CurrentRow.Cells(2).Value
        txt_password.Text = DataGridView1.CurrentRow.Cells(3).Value
        combo_role.Text = DataGridView1.CurrentRow.Cells(4).Value
        If DataGridView1.CurrentRow.Cells(5).Value IsNot DBNull.Value Then
            Dim bytes As [Byte]() = DataGridView1.CurrentRow.Cells(5).Value
            Dim ms As New MemoryStream(bytes)
            pic_box.Image = Image.FromStream(ms)
        Else
            pic_box.Image = Nothing
        End If


        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colname = "colDelete" Then
            conn.Open()

            If MessageBox.Show("Are you sure delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                Try
                    Dim cmd As New SqlCommand("delete from tbluser where empid=@empid", conn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@empid", DataGridView1.CurrentRow.Cells("Column1").Value.ToString)
                    Dim i As Integer
                    i = cmd.ExecuteNonQuery
                    If i > 0 Then
                        MessageBox.Show("User deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("User delete failed!" + Environment.NewLine + "Reason: Data error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            conn.Close()
            userdataloading()
            clear()
        End If


    End Sub

    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click

        Try

            If txt_ID.Text <> "" Then
                conn.Open()
                Dim cmd As New SqlCommand("UPDATE tbluser SET fullname=@fullname,username=@username,password=@password,role=@role,pic=@pic WHERE empid=@empid", conn)

                With cmd.Parameters
                    .Clear()
                    .AddWithValue("@empid", DataGridView1.CurrentRow.Cells("Column1").Value.ToString)
                    .AddWithValue("@fullname", txt_fullname.Text)
                    .AddWithValue("@username", txt_username.Text)
                    .AddWithValue("@password", txt_password.Text)
                    .AddWithValue("@role", combo_role.Text)
                    If Not pic_box.Image Is Nothing Then
                        Dim FileSize As New UInt32
                        Dim mstream As New System.IO.MemoryStream
                        pic_box.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                        Dim picture() As Byte = mstream.GetBuffer
                        FileSize = mstream.Length
                        mstream.Close()
                        .AddWithValue("@pic", picture)
                    Else
                        .Add("@pic", SqlDbType.VarBinary, -1).Value = DBNull.Value
                    End If
                End With

                Dim i As Integer
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("User updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("User update failed!" + Environment.NewLine + "Reason: Data error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("User update failed!" + Environment.NewLine + "Reason: Nothing was selected from the table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        userdataloading()
        clear()

    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        clear()
    End Sub
End Class