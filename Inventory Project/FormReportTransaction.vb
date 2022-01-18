Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Globalization
Public Class FormReportTransaction
    Dim conn As New SqlConnection("Data Source=(LocalDb)\v11.0;AttachDbFilename=|DataDirectory|\DatabaseInventory.mdf;Integrated Security=True;User ID=admin;Password=adminpass")
    Dim dr As SqlDataReader
    Private Sub inboundReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormCustomers.clear()
        loadReport()
    End Sub
    Sub loadReport()

        Try
            conn.Open()
            Dim ds As New DataSet1
            Dim da As New SqlDataAdapter

            da.SelectCommand = New SqlCommand("select * from tblcustomer where invoiceno= '" & RGBColors.invoice & "'", conn)
            da.SelectCommand.Parameters.Clear()
            da.Fill(ds, "DataTable1")

            Dim rpt As New CrystalReport1
            rpt.Load(Application.StartupPath & "\CrystalReport1.rpt")
            rpt.SetDataSource(ds.Tables("DataTable1"))
            CrystalReportViewer1.RefreshReport()
            'Dim value() = Split("x", RGBColors.serv)
            'rpt.SetParameterValue("@arr", value)
            CrystalReportViewer1.ReportSource = rpt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
End Class