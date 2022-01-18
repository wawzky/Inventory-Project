Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Globalization

Public Class Formstockadjustment
    Dim conn As New SqlConnection("Data Source=(LocalDb)\v11.0;AttachDbFilename=|DataDirectory|\DatabaseInventory.mdf;Integrated Security=True;User ID=admin;Password=adminpass")
    Dim dr As SqlDataReader
    Private Sub stockadjustmentfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_procode.Enabled = False
        txt_productname.Enabled = False
        txt_stockqty.SelectAll()
        txt_stockqty.Focus()
    End Sub
    Sub edit()
        Try
            conn.Open()
            Dim cmd As New SqlCommand("UPDATE tblproducts SET proquantity+=@proquantity WHERE procode=@procode", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@procode", txt_procode.Text)
            cmd.Parameters.AddWithValue("@proquantity", txt_stockqty.Text)
            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Stock adjusted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Stock adjustment failed!" + Environment.NewLine + "Reason: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        txt_stockqty.Clear()
        txt_stockqty.Focus()
        FormStocks.loadstock()
        FormHome.btn_Stocks.PerformClick()
    End Sub
    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click
        If txt_stockqty.Text.Trim = String.Empty OrElse IsNumeric(txt_stockqty.Text.Trim) = False OrElse Integer.Parse(txt_stockqty.Text, Globalization.NumberStyles.Number) <= 0 Then
            MessageBox.Show("Stock adjustment failed!" + Environment.NewLine + "Reason: Quantity must be a number and greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf MessageBox.Show("Are you sure you want to add " + txt_stockqty.Text.Trim + " stock(s) to this product?", "Confimration", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            edit()
        Else

        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Dispose()
    End Sub
End Class