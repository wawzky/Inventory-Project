Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Globalization

Public Class FormCars
    Dim conn As New SqlConnection("Data Source=(LocalDb)\v11.0;AttachDbFilename=|DataDirectory|\DatabaseInventory.mdf;Integrated Security=True;User ID=admin;Password=adminpass")
    Dim dr As SqlDataReader
    Private Sub FormCars_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_carname.SelectAll()
        txt_carname.Focus()
        loadingcar()
    End Sub

    Sub clear()
        txt_carID.Clear()
        txt_carname.Clear()
        txt_chassisno.Clear()
        txt_color.Clear()
        txt_engineno.Clear()
        txt_plateno.Clear()
        txt_carprice.Clear()
        txt_search.Clear()
    End Sub

    Sub loadingcar()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New SqlCommand("select * from tblcar", conn)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    If DataGridView1.ColumnCount <> 0 Then
                        DataGridView1.Rows.Add(dr.Item("carid"), dr.Item("carplateno"), dr.Item("carname"), dr.Item("carchassisno"), dr.Item("carengineno"), dr.Item("carcolor"), dr.Item("carprice"))
                    End If
                End While
            End If
            dr.Dispose()
        Catch ex As Exception

        End Try
        conn.Close()
    End Sub

    Sub save()
        Try
            conn.Open()
            Dim str As String = "SELECT carplateno FROM tblcar WHERE carplateno=@cpn OR carid=@id"
            Dim dp As New SqlCommand(str, conn)
            With dp.Parameters
                .Clear()
                .AddWithValue("@cpn", txt_plateno.Text)
                .AddWithValue("@id", txt_carID.Text)
            End With
            Dim i1 As String = dp.ExecuteScalar
            conn.Close()
            If i1 = "" Then
                conn.Open()
                Dim cmd As New SqlCommand("INSERT INTO tblcar (carplateno, carname, carchassisno, carengineno, carcolor,carprice) VALUES (@carplateno,@carname, @carchassisno, @carengineno, @carcolor,@carprice)", conn)
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("@carplateno", txt_plateno.Text)
                    .AddWithValue("@carname", txt_carname.Text)

                    If txt_chassisno.Text.Trim = String.Empty Then
                        .AddWithValue("@carchassisno", "N/A")
                    Else
                        .AddWithValue("@carchassisno", txt_chassisno.Text)
                    End If
                    If txt_engineno.Text.Trim = String.Empty Then
                        .AddWithValue("@carengineno", "N/A")
                    Else
                        .AddWithValue("@carengineno", txt_engineno.Text)
                    End If
                    .AddWithValue("@carcolor", txt_color.Text)
                    .AddWithValue("@carprice", CDec(txt_carprice.Text))
                End With

                Dim i As Integer
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("New car saved successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Failed saving new car!" + Environment.NewLine + "Reason: Data error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Failed saving a new car!" + Environment.NewLine + "Reason: Cannot save a car with duplicate plate number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
        conn.Close()
        loadingcar()
        clear()
    End Sub

    Sub edit()
        Try
            conn.Open()
            Dim cmd As New SqlCommand("UPDATE tblcar SET carplateno=@carplateno,carname=@carname,carchassisno=@carchassisno, carengineno=@carengineno, carcolor=@carcolor,carprice=@carprice WHERE carid=@carid", conn)
            With cmd.Parameters
                .Clear()
                .AddWithValue("@carid", txt_carID.Text)
                .AddWithValue("@carplateno", txt_plateno.Text)
                .AddWithValue("@carname", txt_carname.Text)
                If txt_chassisno.Text.Trim = String.Empty Then
                    .AddWithValue("@carchassisno", "N/A")
                Else
                    .AddWithValue("@carchassisno", txt_chassisno.Text)
                End If
                If txt_engineno.Text.Trim = String.Empty Then
                    .AddWithValue("@carengineno", "N/A")
                Else
                    .AddWithValue("@carengineno", txt_engineno.Text)
                End If
                .AddWithValue("@carcolor", txt_color.Text)
                .AddWithValue("@carprice", CDec(txt_carprice.Text))
            End With

            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Car edited successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed editing a car!" + Environment.NewLine + "Reason: Data error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        loadingcar()
        clear()
    End Sub

    Sub delete()
        If MessageBox.Show("Are you sure delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Try
                conn.Open()
                Dim cmd As New SqlCommand("delete from tblcar where carid=@carid", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@carid", DataGridView1.CurrentRow.Cells("Column1").Value.ToString)
                Dim i As Integer
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("Car deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Failed deleting a car!" + Environment.NewLine + "Reason: Data error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        conn.Close()
        loadingcar()
        clear()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellDoubleClick
        If DataGridView1.Rows.Count > 0 Then
            txt_carID.Text = DataGridView1.CurrentRow.Cells(0).Value
            txt_plateno.Text = DataGridView1.CurrentRow.Cells(1).Value
            txt_carname.Text = DataGridView1.CurrentRow.Cells(2).Value
            txt_chassisno.Text = DataGridView1.CurrentRow.Cells(3).Value
            txt_engineno.Text = DataGridView1.CurrentRow.Cells(4).Value
            txt_color.Text = DataGridView1.CurrentRow.Cells(5).Value
            txt_carprice.Text = DataGridView1.CurrentRow.Cells(6).Value
        End If
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()
        If txt_search.Text <> "" Then
            Try
                conn.Open()
                Dim cmd As New SqlCommand("select * from tblcar where carplateno like '%" & txt_search.Text & "%' or carname like '%" & txt_search.Text & "%'", conn)
                dr = cmd.ExecuteReader
                While dr.Read
                    DataGridView1.Rows.Add(dr.Item("carid"), dr.Item("carplateno"), dr.Item("carname"), dr.Item("carchassisno"), dr.Item("carengineno"), dr.Item("carcolor"), dr.Item("carprice"))
                End While
                dr.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            loadingcar()
        End If
        conn.Close()
    End Sub

    Private Sub btm_save_Click(sender As Object, e As EventArgs) Handles btm_save.Click
        If txt_plateno.Text.Trim = String.Empty Then
            MessageBox.Show("Failed saving a new car!!" + Environment.NewLine + "Reason: Plate number is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_plateno.SelectAll()
            txt_plateno.Focus()
        ElseIf txt_carname.Text.Trim = String.Empty Then
            MessageBox.Show("Failed saving a new car!!" + Environment.NewLine + "Reason: Car name/Model is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_carname.SelectAll()
            txt_carname.Focus()
        ElseIf txt_color.Text.Trim = String.Empty Or IsNumeric(txt_color.Text.Trim) = True Then
            MessageBox.Show("Failed saving a new car!!" + Environment.NewLine + "Reason: Color of the car is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_color.SelectAll()
            txt_color.Focus()
        ElseIf txt_carprice.Text = String.Empty Or IsNumeric(txt_carprice.Text) = False Then
            MessageBox.Show("Failed saving a new car!!" + Environment.NewLine + "Reason: Price of the car is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_carprice.SelectAll()
            txt_carprice.Focus()
        ElseIf txt_engineno.Text.Trim = String.Empty And txt_chassisno.Text.Trim = String.Empty Then
            If MessageBox.Show("Continue without car's chassis and engine number?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                save()
            End If
        ElseIf txt_chassisno.Text.Trim = String.Empty Then
            txt_chassisno.SelectAll()
            txt_chassisno.Focus()
            If MessageBox.Show("Continue without the car's chassis number?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                save()
            End If
        ElseIf txt_engineno.Text.Trim = String.Empty Then
            txt_engineno.SelectAll()
            txt_engineno.Focus()
            If MessageBox.Show("Continue without the car's engine number?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                save()
            End If
        Else
            save()
        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If CStr(txt_carID.Text.Trim) <> String.Empty Then
            If txt_plateno.Text.Trim = String.Empty Then
                MessageBox.Show("Failed editing a car!" + Environment.NewLine + "Reason: Plate number is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_plateno.SelectAll()
                txt_plateno.Focus()
            ElseIf txt_carname.Text.Trim = String.Empty Then
                MessageBox.Show("Failed editing a car!" + Environment.NewLine + "Reason: Car name/Model is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_carname.SelectAll()
                txt_carname.Focus()
            ElseIf txt_color.Text.Trim = String.Empty Or IsNumeric(txt_color.Text.Trim) = True Then
                MessageBox.Show("Failed editing a car!" + Environment.NewLine + "Reason: Color of the car is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_color.SelectAll()
                txt_color.Focus()
            ElseIf txt_carprice.Text = String.Empty Or IsNumeric(txt_carprice.Text) = False Then
                MessageBox.Show("Failed saving a new car!!" + Environment.NewLine + "Reason: Color of the car is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_carprice.SelectAll()
                txt_carprice.Focus()
            ElseIf txt_engineno.Text.Trim = String.Empty And txt_chassisno.Text.Trim = String.Empty Then
                If MessageBox.Show("Continue without chassis and engine number of the car?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    edit()
                End If
            ElseIf txt_chassisno.Text.Trim = String.Empty Then
                txt_chassisno.SelectAll()
                txt_chassisno.Focus()
                If MessageBox.Show("Continue without chassis number of the car?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    edit()
                End If
            ElseIf txt_engineno.Text.Trim = String.Empty Then
                txt_engineno.SelectAll()
                txt_engineno.Focus()
                If MessageBox.Show("Continue without engine number of the car?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    edit()
                End If
            Else
                edit()
            End If
        Else
            MessageBox.Show("Failed editing a car!" + Environment.NewLine + "Reason: Car selection from the table is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If CStr(txt_carID.Text) <> String.Empty Then
            delete()
        Else
            MessageBox.Show("Failed deleting a car!" + Environment.NewLine + "Reason: Car selection from the table is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        clear()
    End Sub

    Private Sub btn_sell_Click(sender As Object, e As EventArgs) Handles btn_sell.Click
        If CStr(txt_carID.Text) <> String.Empty Then
            If MessageBox.Show("Are you sure sell this car?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                Try
                    conn.Open()
                    Dim cmd As New SqlCommand("delete from tblcar where carid=@carid", conn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@carid", DataGridView1.CurrentRow.Cells("Column1").Value.ToString)
                    Dim i As Integer
                    i = cmd.ExecuteNonQuery
                    If i > 0 Then
                        MessageBox.Show("Car sold successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Failed selling a car!" + Environment.NewLine + "Reason: Data error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            conn.Close()
            loadingcar()
            clear()
        Else
            MessageBox.Show("Failed selling a car!" + Environment.NewLine + "Reason: Car selection from the table is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class