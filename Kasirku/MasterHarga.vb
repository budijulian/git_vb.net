Imports MySql.Data.MySqlClient
Public Class MasterHarga
    Public conn As New MySqlConnection
    Private Sub MasterHarga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'menghidupkan waktu = timer1
        Timer1.Enabled = True
        Call Load_Data()
        'mengisi nilai di textbox value maksimum
        txt_kode.Text = 10000 + Convert.ToDouble(DataGridView1.RowCount - 1) + 1
        ' Convert.ToDouble(DataGridView1.Rows(0).Cells(0).Value) + 1
        dt_beli.Value = Date.Today
    End Sub
    Sub KODE()
        txt_kode.Text = 10000 + Convert.ToDouble(DataGridView1.RowCount - 1) + 1
    End Sub
    '  Public ConnectionString As String
    Sub Load_Data()
        Try
            ' ConnectionString = "server=localhost;database=db_kasir;username=root;password=;"
            conn = New MySqlConnection("server=localhost;database=db_kasir;username=root;password=;")
            conn.Open()
            Dim masuk As String
            masuk = "SELECT `Kode`, `TanggalBeli`, `Jenis`, `NamaBarang`, `Satuan`, `Banyak`, `HargaSatuan`, `HargaJual` FROM `daftarharga` ORDER BY `Kode` DESC"
            Dim adapter As New MySqlDataAdapter
            adapter = New MySqlDataAdapter(masuk, conn)
            Dim dt As New DataTable
            adapter.Fill(dt)
            DataGridView1.DataSource = dt

            conn.Close()
            'memberi lebar kolom di datagridview1
            DataGridView1.Columns(0).Width = 100
            DataGridView1.Columns(1).Width = 70
            DataGridView1.Columns(2).Width = 80
            DataGridView1.Columns(3).Width = 100
            DataGridView1.Columns(4).Width = 50
            DataGridView1.Columns(5).Width = 80
            DataGridView1.Columns(6).Width = 100
            DataGridView1.Columns(7).Width = 100
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub isidatagridview1(ByVal x As Integer)
        Try
            txt_kode.Text = DataGridView1.Rows(x).Cells(0).Value
            dt_beli.Text = DataGridView1.Rows(x).Cells(1).Value
            If DataGridView1.Rows(x).Cells(2).Value = "Vegetables" Then
                rb_vegetables.Checked = True
                rb_others.Checked = False
                rb_fruit.Checked = False
            ElseIf DataGridView1.Rows(x).Cells(2).Value = "Fruit" Then
                rb_fruit.Checked = True
                rb_others.Checked = False
                rb_vegetables.Checked = False
            ElseIf DataGridView1.Rows(x).Cells(2).Value = "Others" Then
                rb_others.Checked = True
                rb_vegetables.Checked = False
                rb_fruit.Checked = False
            End If
            'memberi nilai pada objek ketika kita mengklik cell datagridview
            txt_namab.Text = DataGridView1.Rows(x).Cells(3).Value
            txt_satuan.Text = DataGridView1.Rows(x).Cells(4).Value
            lb_sbanyak.Text = String.Copy("/" + txt_satuan.Text)
            lb_sbanyak2.Text = String.Copy("/" + txt_satuan.Text)
            lb_sbanyak3.Text = String.Copy("/" + txt_satuan.Text)
            txt_banyak.Text = DataGridView1.Rows(x).Cells(5).Value
            txt_Hbeli.Text = DataGridView1.Rows(x).Cells(6).Value
            txt_hJual.Text = DataGridView1.Rows(x).Cells(7).Value
            ShowDialog()
        Catch ex As Exception
        End Try
    End Sub
   
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            time.Text = Date.Now.ToString("dd-MM-yyyy hh:mm:ss")
            ts_proses1.Increment(1)
            If ts_proses1.Value = 100 Then
            End If
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub btn_list_Click(sender As Object, e As EventArgs)
        list.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    
    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Try
            Call Query("INSERT INTO `daftarharga`(`Kode`, `TanggalBeli`, `Jenis`, `NamaBarang`, `Satuan`, `Banyak`, `HargaSatuan`, `HargaJual`) VALUES (@kode,@dtbeli,@jenis,@nama,@satuan,@banyak,@hbeli,@hjual);")
            Call KODE()
            Call clear()
        Catch ex As Exception

        End Try
        
    End Sub
    Private Sub Query(ByVal sql As String)
        Timer1.Start()
        Try
            Dim cd = New MySqlCommand
            conn.Open()
            cd = conn.CreateCommand
            cd.CommandText = sql
            cd.Parameters.AddWithValue("@kode", txt_kode.Text)
            cd.Parameters.AddWithValue("@dtbeli", dt_beli.Text)
            If rb_vegetables.Checked = True Then
                cd.Parameters.AddWithValue("@jenis", "Vegetables")
            ElseIf rb_fruit.Checked = True Then
                cd.Parameters.AddWithValue("@jenis", "Fruit")
            ElseIf rb_others.Checked = True Then
                cd.Parameters.AddWithValue("@jenis", "Others")
            Else
                cd.Parameters.AddWithValue("@jenis", "0")
            End If
            cd.Parameters.AddWithValue("@nama", txt_namab.Text)
            cd.Parameters.AddWithValue("@satuan", txt_satuan.Text)
            cd.Parameters.AddWithValue("@banyak", txt_banyak.Text)
            cd.Parameters.AddWithValue("@hbeli", txt_Hbeli.Text)
            cd.Parameters.AddWithValue("@hjual", txt_hJual.Text)
            cd.ExecuteNonQuery()
            Call Load_Data()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            txt_banyak.Text = ""
            txt_Hbeli.Text = "0"
            rb_others.Checked = False
            rb_fruit.Checked = False
            rb_vegetables.Checked = False
            txt_hJual.Text = "0"
            txt_namab.Text = ""
            txt_satuan.Text = "0"
            txt_kode.Text = ""
        End Try
        Timer1.Stop()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Call Query("update daftarharga set TanggalBeli=@dtbeli, Jenis=@jenis, NamaBarang=@nama, Satuan=@satuan, Banyak=@banyak, HargaSatuan=@hbeli, HargaJual=@hjual where Kode=@kode")

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            Dim pesan As MsgBoxResult
            pesan = MsgBox("Apakah Anda Yakin Menghapus Data Ini", MsgBoxStyle.YesNo, " Hapus Data")
            If pesan = MsgBoxResult.Yes Then
                Dim cd = New MySqlCommand
                cd = conn.CreateCommand
                conn.Open()
                cd.CommandText = "delete from daftarharga where Kode=@kode"
                cd.Parameters.AddWithValue("@kode", txt_kode.Text)
                cd.ExecuteNonQuery()

                conn.Close()

                txt_banyak.Text = ""
                dt_beli.Value = Date.Today
                txt_Hbeli.Text = "0"
                rb_others.Checked = False
                rb_fruit.Checked = False
                rb_vegetables.Checked = False
                txt_hJual.Text = "0"
                txt_namab.Text = ""
                txt_satuan.Text = "0"
                txt_kode.Text = ""
                'mengisi nilai di textbox value maksimum
                txt_kode.Text = Convert.ToDouble(DataGridView1.Rows(0).Cells(0).Value) + 1
            Else
            End If
            Call Load_Data()
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click
        Try
            Dim Appli As New Microsoft.Office.Interop.Excel.Application
            Dim workb As Microsoft.Office.Interop.Excel.Workbook
            Dim sheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim col As Integer = DataGridView1.ColumnCount
            Dim row As Integer = DataGridView1.RowCount
            workb = Appli.Workbooks.Add
            sheet = Appli.Worksheets.Add()

            For i As Integer = 1 To col
                sheet.Cells.Item(1, i) = DataGridView1.Columns(i - 1).Name.ToString
            Next

            'recorr data ke file
            For file As Integer = 0 To row - 1
                For a As Integer = 0 To col - 1
                    sheet.Cells.Item(file + 2, a + 1) = DataGridView1.Rows(file).Cells(a).Value
                Next
            Next

            sheet.Rows.Item(1).Font.Bold = 1
            sheet.Rows.Item(1).HorizontalAlignment = 3
            sheet.StandardWidth = 100
            sheet.Columns.AutoFit()
            Appli.Application.Visible = True
            Appli.Application.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized
            sheet = Nothing
            workb = Nothing
            Appli = Nothing
        Catch ex As Exception

        End Try
        
    End Sub
    Sub clear()
        txt_banyak.Text = ""
        dt_beli.Value = Date.Today
        txt_Hbeli.Text = "0"
        rb_others.Checked = False
        rb_fruit.Checked = False
        rb_vegetables.Checked = False
        txt_hJual.Text = "0"
        txt_namab.Text = ""
        txt_satuan.Text = ""
        txt_banyak.Text = "0"
    End Sub

    Private Sub lb_list_Click(sender As Object, e As EventArgs)
        list.ShowDialog()
    End Sub

    Private Sub btn_close_Click_1(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
        list.Close()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Call clear()
        Call KODE()
        dt_beli.Value = Date.Today
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Call isidatagridview1(e.RowIndex)
    End Sub

    Private Sub txt_sear_namab_TextChanged(sender As Object, e As EventArgs) Handles txt_sear_namab.TextChanged
        Dim dm As MySqlCommand
        Dim ds As New DataTable
        Dim sql As String
        Try
            sql = "SELECT `Kode`, `TanggalBeli`, `Jenis`, `NamaBarang`, `Satuan`, `Banyak`, `HargaSatuan`, `HargaJual` FROM `daftarharga` WHERE `NamaBarang` LIKE '%" + txt_sear_namab.Text + "%' ORDER BY `Kode` DESC"
            conn.Open()
            dm = New MySqlCommand(sql, conn)
            dm.Parameters.AddWithValue("@namab", txt_sear_namab.Text)
            Dim dp As New MySqlDataAdapter(dm)
            dp.Fill(ds)
            DataGridView1.DataSource = ds
           'memberi lebar kolom di datagridview1
            DataGridView1.Columns(0).Width = 100
            DataGridView1.Columns(1).Width = 70
            DataGridView1.Columns(2).Width = 80
            DataGridView1.Columns(3).Width = 100
            DataGridView1.Columns(4).Width = 50
            DataGridView1.Columns(5).Width = 80
            DataGridView1.Columns(6).Width = 100
            DataGridView1.Columns(7).Width = 100
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class