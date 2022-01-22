Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Globalization

Public Class FormStocks
    Dim conn As New SqlConnection("Data Source=(LocalDb)\v11.0;AttachDbFilename=|DataDirectory|\DatabaseInventory.mdf;Integrated Security=True;User ID=admin;Password=adminpass")
    Dim dr As SqlDataReader

    Private Sub managestock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadstock()
        progroupload()
        If combo_productGroup.Items.Count <> 0 Then
            combo_productGroup.SelectedIndex = 0
        End If
    End Sub

    Sub progroupload()
        combo_productGroup.Items.Clear()
        conn.Open()
        Dim cmd As New SqlCommand("select * from tblprocategory  order by procatname desc", conn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            combo_productGroup.Items.Add("ALL")
            While dr.Read
                combo_productGroup.Items.Add(dr.GetString(1))
            End While
        End If
        dr.Close()
        conn.Close()
    End Sub

    Sub loadstock()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New SqlCommand("select * from tblproducts", conn)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    If DataGridView1.ColumnCount <> 0 Then
                        DataGridView1.Rows.Add(dr.Item("proid"), dr.Item("procode"), dr.Item("proname"), dr.Item("procatname"), dr.Item("proquantity"), dr.Item("prouom"), dr.Item("prolocation"), dr.Item("proprice"))
                    End If
                End While
            End If
            dr.Dispose()
        Catch ex As Exception
        End Try
        conn.Close()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New SqlCommand("select * from tblproducts where procode like '%" & txt_search.Text & "%' or proname like '%" & txt_search.Text & "%' ", conn)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                If DataGridView1.ColumnCount <> 0 Then
                    DataGridView1.Rows.Add(dr.Item("proid"), dr.Item("procode"), dr.Item("proname"), dr.Item("procatname"), dr.Item("proquantity"), dr.Item("prouom"), dr.Item("prolocation"), dr.Item("proprice"))
                End If
                End While
            End If
            dr.Dispose()
        Catch ex As Exception
        End Try
        conn.Close()
    End Sub

    Private Sub combo_productGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_productGroup.SelectedIndexChanged
        DataGridView1.Rows.Clear()
        If combo_productGroup.SelectedIndex <> 0 Then
            Try
                conn.Open()
                Dim cmd As New SqlCommand("select * from tblproducts where procatname like '%" & combo_productGroup.Text & "%'", conn)
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    While dr.Read
                        If DataGridView1.ColumnCount <> 0 Then
                            DataGridView1.Rows.Add(dr.Item("proid"), dr.Item("procode"), dr.Item("proname"), dr.Item("procatname"), dr.Item("proquantity"), dr.Item("prouom"), dr.Item("prolocation"), dr.Item("proprice"))
                        End If
                    End While
                End If
                dr.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            loadstock()
        End If
        conn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellDoubleClick
        If DataGridView1.Rows.Count > 0 Then
            With Formstockadjustment
                .txt_procode.Text = DataGridView1.CurrentRow.Cells(1).Value
                .txt_productname.Text = DataGridView1.CurrentRow.Cells(2).Value
                .txt_stockqty.Text = ""
                .ShowDialog()
            End With
        End If
    End Sub

End Class