Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Globalization

Public Class FormUOM
    Dim conn As New SqlConnection("Data Source=(LocalDb)\v11.0;AttachDbFilename=|DataDirectory|\DatabaseInventory.mdf;Integrated Security=True;User ID=admin;Password=adminpass")
    Dim dr As SqlDataReader
    Private Sub uomfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub uomsave()
        Try
            conn.Open()
            Dim cmd As New SqlCommand("INSERT INTO tblprouom(prouom) VALUES (@prouom)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@prouom", txt_productcode.Text)
            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("New unit of measurement saved successfully !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("New unit of measurement save failed!" + Environment.NewLine + "Reason: Data error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        txt_productcode.Clear()
        txt_productcode.Focus()
        FormProduct.prouomload()
        FormHome.btn_Product.PerformClick()
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub btm_save_Click(sender As Object, e As EventArgs) Handles btm_save.Click
        If txt_productcode.Text <> String.Empty Then
            uomsave()
        Else
            MessageBox.Show("New unit of measurement save failed!" + Environment.NewLine + "Reason: Empty textbox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class