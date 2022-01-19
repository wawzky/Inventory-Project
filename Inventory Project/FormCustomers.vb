Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Globalization

Public Class FormCustomers
    Dim conn As New SqlConnection("Data Source=(LocalDb)\v11.0;AttachDbFilename=|DataDirectory|\DatabaseInventory.mdf;Integrated Security=True;User ID=admin;Password=adminpass")
    Dim dr As SqlDataReader
    Dim liststr As String = ""
    Dim procode As String = ""
    Dim price As String = ""
    Dim listparts As String = ""
    Dim qty As Decimal = 0.00
    Private Sub managecustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_invoice.Text = getTransno()
        trandate.Value = Now
        txt_custname.SelectAll()
        txt_custname.Focus()
        loadingcustomer()
        autocompleteprod()
    End Sub

    Sub clear()
        txt_custID.Clear()
        txt_custname.Clear()
        txt_address.Clear()
        txt_phone.Clear()
        txt_search.Clear()
        txt_plate.Clear()
        txt_maker.Clear()
        txt_engineno.Clear()
        txt_chassisno.Clear()
        txt_color.Clear()
        txt_insurance.Clear()
        list_Services.Items.Clear()
        list_Parts.Items.Clear()
        trandate.Value = Now
        txt_invoice.Text = getTransno()
    End Sub

    Sub loadingcustomer()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New SqlCommand("select * from tblcustomer", conn)
            dr = cmd.ExecuteReader
            If dr.HasRows() Then
                While dr.Read
                    If DataGridView1.ColumnCount <> 0 Then
                        DataGridView1.Rows.Add(dr.Item("custid"), dr.Item("invoiceno"), dr.Item("custname"), dr.Item("custaddress"), dr.Item("custphone"),
                                               dr.Item("trandate"), dr.Item("plateno"), dr.Item("maker"), dr.Item("color"), dr.Item("engineno"), dr.Item("chassisno"),
                                               dr.Item("insurance"), dr.Item("serviceslist"), dr.Item("partslist"))
                    End If
                End While
            End If

            dr.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub addupdatestock()
        Try
            Dim i As New Integer
            conn.Open()

            Dim cmd As New SqlCommand("Update tblproducts set proquantity=proquantity-@proquantity where procode=@procode AND proquantity>=@proquantity", conn)
            With cmd.Parameters
                .Clear()
                .AddWithValue("@procode", procode)
                If txt_qty.Text <> "" Then
                    .AddWithValue("@proquantity", CDec(txt_qty.Text))
                Else
                    .AddWithValue("@proquantity", 0.00)
                End If
            End With
            i = cmd.ExecuteNonQuery
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

    End Sub

    Function getTransno() As String
        Try
            Dim sdate As String = Now.ToString("yyyy")
            conn.Open()
            Dim cmd As New SqlCommand("select * from tblcustomer where invoiceno like '" & sdate & "%' order by invoiceno desc", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                getTransno = CLng(dr.Item("invoiceno").ToString) + 1
            Else
                getTransno = sdate & "0001"
            End If

            conn.Close()

        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Function

    Sub autocompleteprod()
        Try
            conn.Open()
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)

            Dim da As New SqlDataAdapter("Select proname from tblproducts", conn)
            da.Fill(dt)
            Dim r As DataRow
            txt_parts.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txt_parts.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub save()
        Try
            conn.Open()
            Dim str As String = "SELECT custid FROM tblcustomer WHERE custid=@id"
            Dim dp As New SqlCommand(str, conn)
            With dp.Parameters
                .Clear()
                .AddWithValue("@id", txt_custID.Text)
            End With
            Dim i1 As Integer = dp.ExecuteScalar
            conn.Close()

            If i1 = 0 Then
                conn.Open()
                Dim cmd As New SqlCommand("INSERT INTO tblcustomer (invoiceno, custname, custaddress, custphone, trandate, plateno, maker, color, engineno, chassisno, insurance, serviceslist, partslist) 
                                            VALUES (@invoiceno,@custname,@custaddress, @custphone, @trandate, @plateno, @maker, @color, @engineno, @chassisno, @insurance, @serviceslst, @partslst)", conn)
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("@invoiceno", txt_invoice.Text)
                    .AddWithValue("@custname", txt_custname.Text)
                    .AddWithValue("@custaddress", txt_address.Text)
                    .AddWithValue("@custphone", txt_phone.Text)
                    .AddWithValue("@trandate", CDate(trandate.Value))
                    .AddWithValue("@plateno", txt_plate.Text)
                    .AddWithValue("@maker", txt_maker.Text)
                    .AddWithValue("@color", txt_color.Text)
                    If txt_chassisno.Text.Trim = String.Empty Then
                        .AddWithValue("@chassisno", "N/A")
                    Else
                        .AddWithValue("@chassisno", txt_chassisno.Text)
                    End If
                    If txt_engineno.Text.Trim = String.Empty Then
                        .AddWithValue("@engineno", "N/A")
                    Else
                        .AddWithValue("@engineno", txt_engineno.Text)
                    End If
                    If txt_insurance.Text = String.Empty Then
                        .AddWithValue("@insurance", "N/A")
                    Else
                        .AddWithValue("@insurance", txt_insurance.Text)
                    End If
                    Dim UseComma As String = ""
                    Dim Selectednames As String = ""
                    For j As Integer = 0 To list_Services.Items.Count - 1
                        If Not (j = list_Services.Items.Count - 1) Then
                            UseComma = "x"
                        Else
                            UseComma = ""
                        End If
                        Selectednames += list_Services.Items(j) + UseComma
                    Next
                    .AddWithValue("@serviceslst", Selectednames)
                    Dim seelec As String = ""
                    Dim use As String = ""
                    For j As Integer = 0 To list_Parts.Items.Count - 1
                        If Not (j = list_Parts.Items.Count - 1) Then
                            use = "x"
                        Else
                            use = ""
                        End If
                        seelec += list_Parts.Items(j) + use
                    Next
                    .AddWithValue("@partslst", seelec)
                End With

                Dim i As Integer
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("New customer saved successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("New customer save failed!" + Environment.NewLine + "Reason: Data error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("New customer save failed!" + Environment.NewLine + "Reason: Cannot save an existing customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        loadingcustomer()
    End Sub

    Private Sub btm_save_Click(sender As Object, e As EventArgs) Handles btm_save.Click
        If txt_custname.Text.Trim = String.Empty OrElse IsNumeric(txt_custname.Text.Trim) = True Then
            MessageBox.Show("Failed saving new customer!" + Environment.NewLine + "Reason: Missing or invalid customer name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_custname.SelectAll()
            txt_custname.Focus()
        ElseIf txt_address.Text.Trim = String.Empty Then
            MessageBox.Show("Failed saving new customer!" + Environment.NewLine + "Reason: Customer's address is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_address.SelectAll()
            txt_address.Focus()
        ElseIf txt_phone.Text.Trim = String.Empty OrElse IsNumeric(txt_phone.Text) = False OrElse Long.Parse(txt_phone.Text, Globalization.NumberStyles.Number) <= 0 Then
            MessageBox.Show("Failed saving new customer!" + Environment.NewLine + "Reason: Missing or invalid customer's contact number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_phone.SelectAll()
            txt_phone.Focus()
        ElseIf txt_plate.Text.Trim = String.Empty Then
            MessageBox.Show("Failed saving new customer!" + Environment.NewLine + "Reason: Plate number is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_plate.SelectAll()
            txt_plate.Focus()
        ElseIf txt_maker.Text.Trim = String.Empty Then
            MessageBox.Show("Failed saving new customer!" + Environment.NewLine + "Reason: Car name/Model is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_maker.SelectAll()
            txt_maker.Focus()
        ElseIf txt_color.Text.Trim = String.Empty Or IsNumeric(txt_color.Text.Trim) = True Then
            MessageBox.Show("Failed saving new customer!" + Environment.NewLine + "Reason: Color of the car is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_color.SelectAll()
            txt_color.Focus()
        ElseIf list_Services.Items.Count = 0 Then
            MessageBox.Show("Failed saving new customer!" + Environment.NewLine + "Reason: Service is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_service.SelectAll()
            txt_service.Focus()
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
        ElseIf txt_insurance.Text = String.Empty Then
            txt_insurance.SelectAll()
            txt_insurance.Focus()
            If MessageBox.Show("Continue without the car's insurance?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                save()
            End If
        Else
            save()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellDoubleClick
        If DataGridView1.Rows.Count > 0 Then
            list_Services.Items.Clear()
            txt_custID.Text = DataGridView1.CurrentRow.Cells(0).Value
            txt_invoice.Text = DataGridView1.CurrentRow.Cells(1).Value
            txt_custname.Text = DataGridView1.CurrentRow.Cells(2).Value
            txt_address.Text = DataGridView1.CurrentRow.Cells(3).Value
            txt_phone.Text = DataGridView1.CurrentRow.Cells(4).Value
            trandate.Value = CDate(DataGridView1.CurrentRow.Cells(5).Value)
            txt_plate.Text = DataGridView1.CurrentRow.Cells(6).Value
            txt_maker.Text = DataGridView1.CurrentRow.Cells(7).Value
            txt_color.Text = DataGridView1.CurrentRow.Cells(8).Value
            txt_engineno.Text = DataGridView1.CurrentRow.Cells(9).Value
            txt_chassisno.Text = DataGridView1.CurrentRow.Cells(10).Value
            txt_insurance.Text = DataGridView1.CurrentRow.Cells(11).Value
            liststr = DataGridView1.CurrentRow.Cells(12).Value
            listparts = DataGridView1.CurrentRow.Cells(13).Value

            Dim arr() As String = liststr.Split("x")
            Dim arr2() As String = listparts.Split("x")
            list_Services.Items.Clear()
            list_Parts.Items.Clear()

            For Each obj As Object In arr.ToList
                list_Services.Items.Add(obj)
            Next
            For Each obj1 As Object In arr2.ToList
                list_Parts.Items.Add(obj1)
            Next
        End If
    End Sub

    Sub edit()
        Try
            conn.Open()
            Dim cmd As New SqlCommand("UPDATE tblcustomer SET custname=@custname, custaddress=@custaddress, custphone=@custphone, trandate=@trandate, plateno=@plateno, maker=@maker, color=@color, engineno=@engineno, chassisno=@chassisno, insurance=@insurance, serviceslist=@serviceslst, partslist=@partslst WHERE custid=@custid", conn)
            With cmd.Parameters
                .Clear()
                .AddWithValue("@custid", CInt(txt_custID.Text))
                .AddWithValue("@custname", txt_custname.Text)
                .AddWithValue("@custaddress", txt_address.Text)
                .AddWithValue("@custphone", txt_phone.Text)
                .AddWithValue("@trandate", CDate(trandate.Value))
                .AddWithValue("@plateno", txt_plate.Text)
                .AddWithValue("@maker", txt_maker.Text)
                .AddWithValue("@color", txt_color.Text)
                If txt_chassisno.Text.Trim = String.Empty Then
                    .AddWithValue("@chassisno", "N/A")
                Else
                    .AddWithValue("@chassisno", txt_chassisno.Text)
                End If
                If txt_engineno.Text.Trim = String.Empty Then
                    .AddWithValue("@engineno", "N/A")
                Else
                    .AddWithValue("@engineno", txt_engineno.Text)
                End If
                If txt_insurance.Text = String.Empty Then
                    .AddWithValue("@insurance", "N/A")
                Else
                    .AddWithValue("@insurance", txt_insurance.Text)
                End If
                Dim Selectednames As String = ""
                Dim UseComma As String = ""
                Dim seelec As String = ""
                Dim use As String = ""
                For j As Integer = 0 To list_Services.Items.Count - 1
                    If Not (j = list_Services.Items.Count - 1) Then
                        UseComma = "x"
                    Else
                        UseComma = ""
                    End If
                    Selectednames += list_Services.Items(j) + UseComma
                Next
                .AddWithValue("@serviceslst", Selectednames)
                For j As Integer = 0 To list_Parts.Items.Count - 1
                    If Not (j = list_Parts.Items.Count - 1) Then
                        use = "x"
                    Else
                        use = ""
                    End If
                    seelec += list_Parts.Items(j) + use
                Next
                .AddWithValue("@partslst", seelec)
            End With

            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Customer updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Customer update failed!" + Environment.NewLine + "Reason: Data Error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        loadingcustomer()
        'clear()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If CStr(txt_custID.Text.Trim) <> String.Empty Then
            If txt_custname.Text.Trim = String.Empty OrElse IsNumeric(txt_custname.Text.Trim) = True Then
                MessageBox.Show("Failed editing customer!" + Environment.NewLine + "Reason: Missing or invalid customer name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_custname.SelectAll()
                txt_custname.Focus()
            ElseIf txt_address.Text = String.Empty Then
                MessageBox.Show("Failed editing customer!" + Environment.NewLine + "Reason: Customer's address is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_address.SelectAll()
                txt_address.Focus()
            ElseIf txt_phone.Text = String.Empty OrElse IsNumeric(txt_phone.Text) = False OrElse txt_phone.Text <= 0 Then
                MessageBox.Show("Failed editing customer!" + Environment.NewLine + "Reason: Missing or invalid customer's contact number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_phone.SelectAll()
                txt_phone.Focus()
            ElseIf txt_plate.Text.Trim = String.Empty Then
                MessageBox.Show("Failed editing customer!" + Environment.NewLine + "Reason: Plate number is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_plate.SelectAll()
                txt_plate.Focus()
            ElseIf txt_maker.Text.Trim = String.Empty Then
                MessageBox.Show("Failed editing customer!" + Environment.NewLine + "Reason: Car name/Model is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_maker.SelectAll()
                txt_maker.Focus()
            ElseIf txt_color.Text.Trim = String.Empty Or IsNumeric(txt_color.Text.Trim) = True Then
                MessageBox.Show("Failed editing customer!" + Environment.NewLine + "Reason: Color of the car is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_color.SelectAll()
                txt_color.Focus()
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
            ElseIf txt_insurance.Text = String.Empty Then
                txt_insurance.SelectAll()
                txt_insurance.Focus()
                If MessageBox.Show("Continue without the car's insurance?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    save()
                End If
            ElseIf list_Services.Items.Count = 0 Then
                MessageBox.Show("Failed editing customer!" + Environment.NewLine + "Reason: Service is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_service.SelectAll()
                txt_service.Focus()
            Else
                edit()
            End If
        Else
            MessageBox.Show("Customer edit failed!" + Environment.NewLine + "Reason: Customer selection from the table is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub delete()
        If MessageBox.Show("Are you sure delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Try
                conn.Open()
                Dim cmd As New SqlCommand("delete from tblcustomer where custid=@custid", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@custid", DataGridView1.CurrentRow.Cells("custid").Value.ToString)
                Dim i As Integer
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("Customer deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Customer delete failed!" + Environment.NewLine + "Reason: Data error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        conn.Close()
        loadingcustomer()
        clear()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If CStr(txt_custID.Text.Trim) <> String.Empty Then
            delete()
        Else
            MessageBox.Show("Customer delete failed!" + Environment.NewLine + "Reason: Customer selection from the table is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()
        If txt_search.Text <> "" Then
            Try
                conn.Open()
                Dim cmd As New SqlCommand("select * from tblcustomer where custid like '%" & txt_search.Text & "%' or custname like '%" &
                                          txt_search.Text & "%'" & "or invoiceno like '%" & txt_search.Text & "%'", conn)
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    While dr.Read
                        DataGridView1.Rows.Add(dr.Item("custid"), dr.Item("invoiceno"), dr.Item("custname"), dr.Item("custaddress"), dr.Item("custphone"),
                                               dr.Item("trandate"), dr.Item("plateno"), dr.Item("maker"), dr.Item("color"), dr.Item("engineno"), dr.Item("chassisno"),
                                               dr.Item("insurance"), dr.Item("serviceslist"), dr.Item("partslist"))
                    End While
                End If
                dr.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            loadingcustomer()
        End If
        conn.Close()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        clear()
    End Sub

    Private Sub Btn_Print_Click(sender As Object, e As EventArgs) Handles Btn_Print.Click
        If MessageBox.Show("Please confirm the transaction.", "Confirm.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            RGBColors.invoice = txt_invoice.Text
            'RGBColors.serv = liststr
            FormHome.OpenChildForm(FormReportTransaction)
        Else
            MessageBox.Show("Printing service/part failed!" + Environment.NewLine + "Reason: Transaction was not saved in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_addtl_Click(sender As Object, e As EventArgs) Handles btn_addtl.Click
        If txt_service.Text <> String.Empty And txt_parts.Text <> String.Empty Then
            If CInt(txt_qty.Text) > 0 And txt_qty.Text <> String.Empty And MessageBox.Show("Please confirm the quantity." + Environment.NewLine + "Part(s) quantity: " + txt_qty.Text, "Confirm.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                list_Services.Items.Add(txt_service.Text)
                txt_service.Clear()
                list_Parts.Items.Add(txt_parts.Text & " - " & txt_qty.Text & " - " & price)
                addupdatestock()
                txt_parts.Clear()
                txt_qty.Clear()
            Else
                MessageBox.Show("Adding service/part failed!" + Environment.NewLine + "Reason: Invalid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf txt_parts.Text <> String.Empty And txt_service.Text = String.Empty Then
            If CInt(txt_qty.Text) > 0 And txt_qty.Text <> String.Empty And MessageBox.Show("Please confirm the quantity." + Environment.NewLine + "Part(s) quantity: " + txt_qty.Text, "Confirm.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                list_Parts.Items.Add(txt_parts.Text & " - " & txt_qty.Text & " - " & price)
                addupdatestock()
                txt_parts.Clear()
                txt_qty.Clear()
            Else
                MessageBox.Show("Adding service/part failed!" + Environment.NewLine + "Reason: Invalid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf txt_service.Text <> "" Then
            list_Services.Items.Add(txt_service.Text)
            txt_service.Clear()
        Else
            MessageBox.Show("Adding service/part failed!" + Environment.NewLine + "Reason: Service/Part is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_service.SelectAll()
            txt_service.Focus()
        End If
    End Sub

    Private Sub btn_rmvlst_Click(sender As Object, e As EventArgs) Handles btn_rmvlst.Click
        If list_Services.SelectedIndex <> -1 Then
            list_Services.Items.RemoveAt(list_Services.SelectedIndex)
        ElseIf list_Parts.SelectedIndex <> -1 Then
            list_Parts.Items.RemoveAt(list_Parts.SelectedIndex)
        Else
            MessageBox.Show("Removing service failed!" + Environment.NewLine + "Reason: Selected service/part is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txt_parts_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_parts.KeyDown
        If txt_parts.Text <> String.Empty Then
            conn.Open()
            Dim cmd As New SqlCommand("Select * from tblproducts where proname='" & CStr(txt_parts.Text) & "'", conn)
            dr = cmd.ExecuteReader
            If dr.Read() = True Then
                procode = dr("procode").ToString
                price = dr("proprice").ToString
                qty = dr("proquantity").ToString
                txt_qty.Text = qty
            End If
            If CInt(txt_qty.Text) = 0 Then
                MessageBox.Show("Adding auto parts failed!" + Environment.NewLine + "Reason: Out of stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_qty.Clear()
                txt_parts.Clear()
                txt_parts.SelectAll()
                txt_parts.Focus()
            End If
        End If
        conn.Close()
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txt_qty.Focus()
        End If
    End Sub
End Class