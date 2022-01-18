Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Globalization

Public Class FormDashboard
    Dim conn As New SqlConnection("Data Source=(LocalDb)\v11.0;AttachDbFilename=|DataDirectory|\DatabaseInventory.mdf;Integrated Security=True;User ID=admin;Password=adminpass")
    Dim dr As SqlDataReader

    Private Sub Dashboardfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totalcustomer()
        totalproduct()
        totaluser()
        totalcar()
        criticalstock()
        zerostock()
        Timer1.Start()

    End Sub

    Sub totalcustomer()
        Try
            conn.Open()
            Dim cmd As New SqlCommand("select count(custid) from tblcustomer ", conn)
            lbl_totalcustomer.Text = cmd.ExecuteScalar.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub totalcar()
        Try
            conn.Open()
            Dim cmd As New SqlCommand("select count(carid) from tblcar ", conn)
            lbl_totalcar.Text = cmd.ExecuteScalar.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub totalproduct()
        Try
            conn.Open()
            Dim cmd As New SqlCommand("select count(procode) from tblproducts ", conn)
            lbl_totalProduct.Text = cmd.ExecuteScalar.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub totaluser()
        Try
            conn.Open()
            Dim cmd As New SqlCommand("select count(empid) from tbluser ", conn)
            lbl_totalusers.Text = cmd.ExecuteScalar.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub criticalstock()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New SqlCommand("select * from tblproducts where proquantity<=10 and proquantity>0", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("procode"), dr.Item("proname"), dr.Item("proquantity"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub zerostock()
        DataGridView2.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New SqlCommand("select * from tblproducts where proquantity=0", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView2.Rows.Add(dr.Item("procode"), dr.Item("proname"), dr.Item("proquantity"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_time.Text = Date.Now.ToString("dddd, hh:mm:ss tt")
    End Sub
End Class