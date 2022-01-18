Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Globalization

Public Class FormProduct
    Dim conn As New SqlConnection("Data Source=(LocalDb)\v11.0;AttachDbFilename=|DataDirectory|\DatabaseInventory.mdf;Integrated Security=True;User ID=admin;Password=adminpass")
    Dim dr As SqlDataReader

    Private Sub manageProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_productcode.SelectAll()
        txt_productcode.Focus()
        loadingproduct()

        progroupload()
        prouomload()
    End Sub

    Sub clear()
        txt_proID.Clear()
        txt_productcode.Clear()
        txt_productname.Clear()
        txt_price.Clear()
        txt_location.Clear()
        txt_search.Clear()
        combo_productGroup.SelectedIndex = -1
        combo_UOM.SelectedIndex = -1
    End Sub

    Sub loadingproduct()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New SqlCommand("select * from tblproducts", conn)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    If DataGridView1.ColumnCount <> 0 Then
                        DataGridView1.Rows.Add(dr.Item("proid"), dr.Item("procode"), dr.Item("proname"), dr.Item("procatname"), dr.Item("prouom"), dr.Item("proprice"), dr.Item("prolocation"))
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
            Dim str As String = "SELECT procode FROM tblproducts WHERE procode=@procodes"
            Dim dp As New SqlCommand(str, conn)
            With dp.Parameters
                .Clear()
                .AddWithValue("@procodes", txt_productcode.Text)
            End With
            Dim i1 As String = dp.ExecuteScalar
            conn.Close()

            If i1 = "" Then
                conn.Open()
                Dim cmd As New SqlCommand("INSERT INTO tblproducts(procode, proname, procatname, prouom, proprice,prolocation,proquantity) VALUES (@procode, @proname,@procatname, @prouom,@proprice,@prolocation,@proquantity)", conn)
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("@procode", txt_productcode.Text)
                    .AddWithValue("@proname", txt_productname.Text)
                    .AddWithValue("@procatname", combo_productGroup.Text)
                    .AddWithValue("@prouom", combo_UOM.Text)
                    .AddWithValue("@proprice", CDec(txt_price.Text))
                    If txt_location.Text.Trim = String.Empty Then
                        .AddWithValue("@prolocation", "N/A")
                    Else
                        .AddWithValue("@prolocation", txt_location.Text)
                    End If
                    .AddWithValue("@proquantity", 0)
                End With
                Dim i As Integer
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("New product saved successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("New product save failed!" + Environment.NewLine + "Reason: Data error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("New product save failed!" + Environment.NewLine + "Reason: Cannot save a product with duplicate product code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        loadingproduct()
        clear()
    End Sub

    Private Sub btm_save_Click(sender As Object, e As EventArgs) Handles btm_save.Click
        If txt_productcode.Text.Trim = String.Empty Then
            MessageBox.Show("New product save failed!" + Environment.NewLine + "Reason: Product code is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_productcode.SelectAll()
            txt_productcode.Focus()
        ElseIf txt_productname.Text.Trim = String.Empty Then
            MessageBox.Show("New product save failed!" + Environment.NewLine + "Reason: Product name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_productname.SelectAll()
            txt_productname.Focus()
        ElseIf combo_productGroup.SelectedIndex = -1 Then
            MessageBox.Show("New product save failed!" + Environment.NewLine + "Reason: Product group is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            combo_productGroup.SelectAll()
            combo_productGroup.Focus()
        ElseIf combo_UOM.SelectedIndex = -1 Then
            MessageBox.Show("New product save failed!" + Environment.NewLine + "Reason: Product unit of measurement is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            combo_UOM.SelectAll()
            combo_UOM.Focus()
        ElseIf txt_price.Text.Trim = String.Empty OrElse IsNumeric(txt_price.Text) = False OrElse Integer.Parse(txt_price.Text, Globalization.NumberStyles.Number) <= 0 Then
            MessageBox.Show("New product save failed!" + Environment.NewLine + "Reason: Price must be a number and greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_price.SelectAll()
            txt_price.Focus()
        ElseIf txt_location.Text.Trim = String.Empty Then
            txt_location.SelectAll()
            txt_location.Focus()
            If MessageBox.Show("Continue without the product's specific location?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                save()
            End If
        Else
            save()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellDoubleClick
        If DataGridView1.Rows.Count > 0 Then
            txt_proID.Text = DataGridView1.CurrentRow.Cells(0).Value
            txt_productcode.Text = DataGridView1.CurrentRow.Cells(1).Value
            txt_productname.Text = DataGridView1.CurrentRow.Cells(2).Value
            combo_productGroup.Text = DataGridView1.CurrentRow.Cells(3).Value
            combo_UOM.Text = DataGridView1.CurrentRow.Cells(4).Value
            txt_price.Text = DataGridView1.CurrentRow.Cells(5).Value
            txt_location.Text = DataGridView1.CurrentRow.Cells(6).Value
        End If
    End Sub

    Sub edit()
        Try
            conn.Open()
            Dim cmd As New SqlCommand("UPDATE tblproducts SET procode=@procode,proname=@proname,procatname=@procatname,prouom=@prouom,proprice=@proprice, prolocation=@prolocation WHERE proid=@proid", conn)
            With cmd.Parameters
                .Clear()
                .AddWithValue("@proid", DataGridView1.CurrentRow.Cells("Column1").Value.ToString)
                .AddWithValue("@procode", txt_productcode.Text)
                .AddWithValue("@proname", txt_productname.Text)
                .AddWithValue("@procatname", combo_productGroup.Text)
                .AddWithValue("@prouom", combo_UOM.Text)
                .AddWithValue("@proprice", CDec(txt_price.Text))
                If txt_location.Text.Trim = String.Empty Then
                    .AddWithValue("@prolocation", "N/A")
                Else
                    .AddWithValue("@prolocation", txt_location.Text)
                End If
            End With
            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Product updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Product update failed!" + Environment.NewLine + "Reason: Data error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        loadingproduct()
        clear()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If CStr(txt_proID.Text.Trim) <> String.Empty Then
            If txt_productcode.Text.Trim = String.Empty Then
                MessageBox.Show("Product edit failed!" + Environment.NewLine + "Reason: Product code is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_productcode.SelectAll()
                txt_productcode.Focus()
            ElseIf txt_productname.Text.Trim = String.Empty Then
                MessageBox.Show("Product edit failed!" + Environment.NewLine + "Reason: Product name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_productname.SelectAll()
                txt_productname.Focus()
            ElseIf combo_productGroup.SelectedIndex = -1 Then
                MessageBox.Show("New product save failed!" + Environment.NewLine + "Reason: Product group is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                combo_productGroup.SelectAll()
                combo_productGroup.Focus()
            ElseIf combo_UOM.SelectedIndex = -1 Then
                MessageBox.Show("New product save failed!" + Environment.NewLine + "Reason: Product unit of measurement is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                combo_UOM.SelectAll()
                combo_UOM.Focus()
            ElseIf txt_price.Text.Trim = String.Empty OrElse IsNumeric(txt_price.Text) = False OrElse Decimal.Parse(txt_price.Text, Globalization.NumberStyles.Number) <= 0 Then
                MessageBox.Show("Product edit failed!" + Environment.NewLine + "Reason: Price must be a number and greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_price.SelectAll()
                txt_price.Focus()
            ElseIf txt_location.Text.Trim = String.Empty Then
                txt_location.SelectAll()
                txt_location.Focus()
                If MessageBox.Show("Continue without the product's specific location?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    edit()
                End If
            Else
                edit()
            End If
        Else
            MessageBox.Show("Product edit failed!" + Environment.NewLine + "Reason: Product selection from the table is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub delete()
        If CStr(txt_proID.Text.Trim) <> String.Empty Then
            If MessageBox.Show("Are you sure delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                Try
                    conn.Open()
                    Dim cmd As New SqlCommand("delete from tblproducts where proid=@proid", conn)

                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@proid", DataGridView1.CurrentRow.Cells("Column1").Value.ToString)

                    Dim i As Integer
                    i = cmd.ExecuteNonQuery
                    If i > 0 Then
                        MessageBox.Show("Product deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Product delete failed!" + Environment.NewLine + "Reason: Data error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Else
            MessageBox.Show("Product delete failed!" + Environment.NewLine + "Reason: Product selection from the table is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        conn.Close()
        loadingproduct()
        clear()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If DataGridView1.SelectedRows.Count = 1 Then
            delete()
        End If
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New SqlCommand("select * from tblproducts where procode like '%" & txt_search.Text & "%' or proname like '%" & txt_search.Text & "%'", conn)
            dr = cmd.ExecuteReader
            If dr.HasRows() Then
                While dr.Read
                    If DataGridView1.ColumnCount <> 0 Then
                        DataGridView1.Rows.Add(dr.Item("proid"), dr.Item("procode"), dr.Item("proname"), dr.Item("procatname"), dr.Item("prouom"), dr.Item("proprice"), dr.Item("prolocation"))
                    End If
                End While
            End If
            dr.Dispose()
        Catch ex As Exception
        End Try
        conn.Close()
    End Sub

    Private Sub btm_addproductgroup_Click(sender As Object, e As EventArgs) Handles btm_addproductgroup.Click
        FormGroup.ShowDialog()
    End Sub

    Sub progroupload()
        combo_productGroup.Items.Clear()
        conn.Open()
        Dim cmd As New SqlCommand("select * from tblprocategory order by procatname desc", conn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                combo_productGroup.Items.Add(dr.GetString(1))
            End While
        End If
        dr.Close()
        conn.Close()
    End Sub

    Sub prouomload()
        combo_UOM.Items.Clear()
        conn.Open()
        Dim cmd As New SqlCommand("select * from tblprouom order by prouom desc", conn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                combo_UOM.Items.Add(dr.GetString(1))
            End While
        End If
        dr.Close()
        conn.Close()
    End Sub

    Private Sub btn_addUOM_Click(sender As Object, e As EventArgs) Handles btn_addUOM.Click
        FormUOM.ShowDialog()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        clear()
    End Sub

End Class