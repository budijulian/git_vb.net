Imports MySql.Data.MySqlClient
Public Class DaftarOutlet
    Public conn As New MySqlConnection
    Sub Load_Data()
        Try
            conn = New MySqlConnection("server=localhost;database=db_kasir;username=root;password=;")
            Dim masuk As String
            masuk = "SELECT `NO`, `TanggalBergabung`, `NamaOutlet`, `NamaPimpinan`, `Alamat`, `Telepon` FROM `outlet` WHERE 1"
            Dim adapter As New MySqlDataAdapter
            conn.Open()
            adapter = New MySqlDataAdapter(masuk, conn)
            Dim dt As New DataTable
            adapter.Fill(dt)
            DataGridView5.DataSource = dt

            'memberi lebar kolom di datagridview1
            DataGridView5.Columns(0).Width = 50
            DataGridView5.Columns(1).Width = 120
            DataGridView5.Columns(2).Width = 150
            DataGridView5.Columns(3).Width = 150
            DataGridView5.Columns(4).Width = 500
            DataGridView5.Columns(5).Width = 120
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
        ' mengisi value awal di textbox
        txt_no.Text = DataGridView5.Rows(0).Cells(0).Value
        dt_gabung.Text = DataGridView5.Rows(0).Cells(1).Value
        txt_namaO.Text = DataGridView5.Rows(0).Cells(2).Value
        txt_nama.Text = DataGridView5.Rows(0).Cells(3).Value
        txt_alamat.Text = DataGridView5.Rows(0).Cells(4).Value
        txt_telepon.Text = DataGridView5.Rows(0).Cells(5).Value
    End Sub

    Sub ubahwarnatexboxt()
        If Val(txt_untung.Text) > 0 Then
            txt_untung.ForeColor = Color.Blue
        Else
            txt_untung.ForeColor = Color.Red
        End If
    End Sub

    Public z As Double
    Public x As Double
    Sub TotalJual()
        Dim x As Double
        For b As Integer = 0 To DataGridView6.RowCount - 1
            x = x + DataGridView6.Rows(b).Cells(7).Value
        Next
        txt_Tjual.Text = x
    End Sub
    Public w As Double
    Sub TotalBeli()
        Dim w As Double
        For b As Integer = 0 To DataGridView6.RowCount - 1
            w = w + DataGridView6.Rows(b).Cells(8).Value
        Next
        txt_Tbeli.Text = w
    End Sub
    Sub TotalLaba()
        Dim totalbeli, totaljual As Double
        totalbeli = txt_Tbeli.Text
        totaljual = txt_Tjual.Text
        txt_untung.Text = totaljual - totalbeli
    End Sub
    Sub LoadData2(ByVal query As String)
        Try
            Dim dm As MySqlCommand
            dm = New MySqlCommand(query, conn)
            dm.Parameters.AddWithValue("@dt1", dt_awal.Text)
            dm.Parameters.AddWithValue("@dt2", dt_akhir.Text)
            conn.Open()
            Dim dp As New MySqlDataAdapter(dm)
            Dim dt As New DataTable
            dp.Fill(dt)
            DataGridView6.DataSource = dt

            'memberi lebar kolom di datagridview1
            DataGridView6.Columns(0).Width = 100
            DataGridView6.Columns(1).Width = 120
            DataGridView6.Columns(2).Width = 100
            DataGridView6.Columns(3).Width = 100
            DataGridView6.Columns(4).Width = 100
            DataGridView6.Columns(5).Width = 85
            DataGridView6.Columns(6).Width = 85
            DataGridView6.Columns(7).Width = 85
            DataGridView6.Columns(8).Width = 85
            DataGridView6.Columns(9).Width = 85
            DataGridView6.Columns(10).Width = 85
            DataGridView6.Columns(11).Width = 85
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
        Call TotalBeli()
        Call TotalJual()
        Call TotalLaba()
    End Sub
    Public ketbiayatambahan As String
    Public array() As String = {}
    ' Public ConnectionString As String = "server=localhost;database=db_kasir;username=root;password=;"
    Private Sub DaftarOutlet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call ubahwarnatexboxt()
        'ListView1.Text = ketbiayatambahan
        'navigation table database
        ShowData(a)
        rd_bayar2.Checked = True
        txt_pengeluaranT.Text = 0
        Timer1.Enabled = True
        Call Load_Data()
        Call LoadData2("SELECT `NoTransaksi`,`NamaOutlet`, `TanggalPesanan`, `NamaPesanan`, `JenisOrder`, `Banyak`, `Satuan`, `HargaJual`, `HargaBeli`,`Keuntungan`,`Keterangan`,`Refund` FROM `order` WHERE 1")
        ' mengkunci texbox
        txt_untung.Enabled = False
        txt_Tjual.Enabled = False
        txt_Tbeli.Enabled = False
        'memberikan nama outlet di combobox
        Try
            Dim query As String = "SELECT `NamaOutlet` FROM `outlet` WHERE 1"
            Dim command = New MySqlCommand
            command = New MySqlCommand(query, conn)
            Dim adapter As MySqlDataAdapter
            adapter = New MySqlDataAdapter
            conn.Open()
            adapter.SelectCommand = command
            'bind data ke input data ke combobox
            Dim dt As New DataTable
            adapter.Fill(dt)
            cb_namaO.DataSource = dt
            cb_namaO.DisplayMember = "NamaOutlet"
            conn.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time.Text = Date.Now.ToString("hh:mm:ss dd-MM-yyyy")
    End Sub
    Sub isidata(ByVal x As Integer)
        txt_no.Text = DataGridView5.Rows(x).Cells(0).Value
        dt_gabung.Text = DataGridView5.Rows(x).Cells(1).Value
        txt_namaO.Text = DataGridView5.Rows(x).Cells(2).Value
        txt_nama.Text = DataGridView5.Rows(x).Cells(3).Value
        txt_alamat.Text = DataGridView5.Rows(x).Cells(4).Value
        txt_telepon.Text = DataGridView5.Rows(x).Cells(5).Value
    End Sub

    Private Sub DataGridView5_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView5.CellClick
        Call isidata(e.RowIndex)
    End Sub
    Dim a As Integer = 0
    Dim table As New DataTable()
    Private Sub ShowData(posisi As Integer)
        Try
            conn.Open()
            Dim masuk As String
            masuk = "SELECT * FROM `outlet` WHERE 1"
            Dim adapter As New MySqlDataAdapter
            adapter = New MySqlDataAdapter(masuk, conn)
            adapter.Fill(table)
            txt_no.Text = table.Rows(posisi)(0).ToString()
            dt_gabung.Text = table.Rows(posisi)(1).ToString()
            txt_namaO.Text = table.Rows(posisi)(2).ToString()
            txt_nama.Text = table.Rows(posisi)(3).ToString()
            txt_alamat.Text = table.Rows(posisi)(4).ToString()
            txt_telepon.Text = table.Rows(posisi)(5).ToString()
        Catch
        End Try
    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        ' menampilkan data selanjutnya
        a += 1
        Call ShowData(a)
        Call isidata(a)
    End Sub
    Private Sub Query(ByVal sql As String)
        Try
            Dim cd = New MySqlCommand
            conn.Open()
            cd = conn.CreateCommand
            cd.CommandText = sql
            cd.Parameters.AddWithValue("no", txt_no.Text)
            cd.Parameters.AddWithValue("@dtgabung", dt_gabung.Text)
            cd.Parameters.AddWithValue("@namaO", txt_namaO.Text)
            cd.Parameters.AddWithValue("@nama", txt_nama.Text)
            cd.Parameters.AddWithValue("@alamat", txt_alamat.Text)
            cd.Parameters.AddWithValue("@telepon", txt_telepon.Text)
            cd.ExecuteNonQuery()
            Call Load_Data()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        Call Query("INSERT INTO `outlet`(`NO`, `TanggalBergabung`, `NamaOutlet`, `NamaPimpinan`, `Alamat`, `Telepon`) VALUES (@no,@dtgabung,@namaO,@nama,@alamat,@telepon)")

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

        Call Query("UPDATE `outlet` SET `TanggalBergabung`=@dtgabung,`NamaOutlet`=@namaO,`NamaPimpinan`=@nama,`Alamat`=@alamat,`Telepon`=@telepon WHERE `NO`=@no")

    End Sub
    Sub Bersih()
        txt_alamat.Text = ""
        txt_nama.Text = ""
        txt_namaO.Text = ""
        txt_telepon.Text = ""
        dt_gabung.Text = Date.Today
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Try
            Dim pesan As MsgBoxResult
            pesan = MsgBox("Apakah Anda Yakin Menghapus Data Ini", MsgBoxStyle.YesNo, " Hapus Data")
            If pesan = MsgBoxResult.Yes Then
                Dim cd = New MySqlCommand
                cd = conn.CreateCommand
                cd.CommandText = "DELETE FROM `outlet` WHERE NO='" + txt_no.Text + "'"
                conn.Open()
                cd.ExecuteNonQuery()

                Call Load_Data()
                Call isidata(0)
            Else
            End If
        Catch ex As Exception
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub btn_bersih_Click(sender As Object, e As EventArgs) Handles btn_bersih.Click
        Call Bersih()
    End Sub


    Private Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click
        Try
            Dim Appli As New Microsoft.Office.Interop.Excel.Application
            Dim workb As Microsoft.Office.Interop.Excel.Workbook
            Dim sheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim col As Integer = DataGridView6.ColumnCount
            Dim row As Integer = DataGridView6.RowCount
            workb = Appli.Workbooks.Add
            sheet = Appli.Worksheets.Add()

            For i As Integer = 1 To col
                sheet.Cells.Item(1, i) = DataGridView6.Columns(i - 1).Name.ToString
            Next

            'recorr data ke file
            For file As Integer = 0 To row - 1
                For a As Integer = 0 To col - 1
                    sheet.Cells.Item(file + 2, a + 1) = DataGridView6.Rows(file).Cells(a).Value
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
    Sub SaveLaporan()
        Try
            'mengitung total refund 
            Dim TRefund As Double
            Dim d As Double
            For b As Integer = 0 To DataGridView6.RowCount - 1
                d = d + DataGridView6.Rows(b).Cells(11).Value
            Next
            TRefund = d

            If rd_bayar1.Checked = True Then
                Dim cd = New MySqlCommand
                Dim ket As String
                ket = ""
                conn.Open()
                cd = conn.CreateCommand
                cd.CommandText = "INSERT INTO `laporankeuangan`(`NoPesanan`, `TanggalPesanan`, `NamaOutlet`, `Items`, `BiayaTambahan`,`KetTambahan`, `TotalBelanja`, `Penjualan`, `Keuntungan`, `Refund`, `Keterangan`) VALUES (@no,@tanggal,@namaO,@banyak,@biayaT,@ketTambahan,@totalb,@penjualan,@untung,@refund,@keterangan)"
                cd.Parameters.AddWithValue("@no", DataGridView6.Rows(x).Cells(0).Value)
                cd.Parameters.AddWithValue("@tanggal", DataGridView6.Rows(x).Cells(2).Value)
                cd.Parameters.AddWithValue("@namaO", cb_namaO.Text)
                cd.Parameters.AddWithValue("@banyak", DataGridView6.RowCount - 1)
                cd.Parameters.AddWithValue("@biayaT", txt_pengeluaranT.Text)
                cd.Parameters.AddWithValue("@ketTambahan", ketbiayatambahan)
                cd.Parameters.AddWithValue("@totalb", txt_Tbeli.Text)
                cd.Parameters.AddWithValue("@penjualan", txt_Tjual.Text)
                cd.Parameters.AddWithValue("@untung", txt_untung.Text)
                cd.Parameters.AddWithValue("@refund", TRefund)

                If rd_bayar1.Checked = True Then
                    ket = "LUNAS"
                ElseIf rd_bayar2.Checked = True Then
                    ket = "BELUM LUNAS"
                End If
                cd.Parameters.AddWithValue("@keterangan", ket)
                cd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Disimpan", "Tersimpan Di Laporan")
                ' meng - default textbox dan varibel keterangan setelah di masukkan agar tidak duplicate
                txt_pengeluaranT.Text = 0
                ketbiayatambahan = ""
            Else
                MessageBox.Show("Anda Belum Melakukan Pembayaran", "Perhatian")
            End If
            
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Call SaveLaporan()
    End Sub

    Private Sub dt_awal_ValueChanged(sender As Object, e As EventArgs) Handles dt_awal.ValueChanged
        If txt_namaO.Text <> "" Then
            Call LoadData2("SELECT `NoTransaksi`, `NamaOutlet`, `TanggalPesanan`, `NamaPesanan`, `JenisOrder`, `Banyak`, `Satuan`, `HargaJual`, `HargaBeli`,`Keuntungan`,`Keterangan`,`Refund` FROM `order` WHERE NamaOutlet='" + cb_namaO.Text + "' AND TanggalPesanan='" + dt_awal.Text + "'")
            Call TotalBeli()
            Call TotalJual()
            Call TotalLaba()
            Call ubahwarnatexboxt()
        End If
    End Sub

    Private Sub dt_akhir_ValueChanged(sender As Object, e As EventArgs) Handles dt_akhir.ValueChanged

        Call LoadData2("SELECT `NoTransaksi`, `NamaOutlet`, `TanggalPesanan`, `NamaPesanan`, `JenisOrder`, `Banyak`, `Satuan`, `HargaJual`, `HargaBeli`,`Keuntungan`,`Keterangan`,`Refund` FROM `order` WHERE NamaOutlet='" + cb_namaO.Text + "' AND TanggalPesanan BETWEEN @dt1 AND @dt2 ")
        Call TotalBeli()
        Call TotalJual()
        Call TotalLaba()
        Call ubahwarnatexboxt()
    End Sub

    Private Sub cb_namaO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_namaO.SelectedIndexChanged
        If txt_namaO.Text <> "" Then
            Call LoadData2("SELECT `NoTransaksi`, `NamaOutlet`, `TanggalPesanan`, `NamaPesanan`, `JenisOrder`, `Banyak`, `Satuan`, `HargaJual`, `HargaBeli`,`Keuntungan`,`Keterangan`,`Refund` FROM `order` WHERE NamaOutlet='" + cb_namaO.Text + "'")
            Call TotalBeli()
            Call TotalJual()
            Call TotalLaba()
            Call ubahwarnatexboxt()
        End If
    End Sub

    Private Sub btn_viewall_Click(sender As Object, e As EventArgs) Handles btn_viewall.Click
        Call LoadData2("SELECT `NoTransaksi`, `NamaOutlet`, `TanggalPesanan`, `NamaPesanan`, `JenisOrder`, `Banyak`, `Satuan`, `HargaJual`, `HargaBeli`,`Keuntungan`,`Keterangan`,`Refund` FROM `order` WHERE 1")
        Call TotalBeli()
        Call TotalJual()
        Call TotalLaba()
        Call ubahwarnatexboxt()
    End Sub

   
    Private Sub btn_biaya_Click(sender As Object, e As EventArgs) Handles btn_biaya.Click
        CostTambahan.MdiParent = Homepage
        CostTambahan.Show()
    End Sub
    Sub HapusdataDatagridview(ByVal e As Integer)
        Try
            Dim pesan As MsgBoxResult
            pesan = MsgBox("Apakah Anda Yakin Menghapus Data Ini", MsgBoxStyle.YesNo, " Hapus Data")
            If pesan = MsgBoxResult.Yes Then
                Dim delete = New MySqlCommand
                conn.Open()
                delete = conn.CreateCommand
                delete.CommandText = "DELETE FROM `order` WHERE `NoTransaksi`='" + DataGridView6.Rows(e).Cells(0).Value + "'"
                delete.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Terhapus", "Perhatian")

            Else

            End If
            Call LoadData2("SELECT `NoTransaksi`, `NamaOutlet`, `TanggalPesanan`, `NamaPesanan`, `JenisOrder`, `Banyak`, `Satuan`, `HargaJual`, `HargaBeli`,`Keuntungan`,`Keterangan`,`Refund` FROM `order` WHERE NamaOutlet='" + cb_namaO.Text + "'")

        Catch ex As Exception
            MsgBox("Data gagal terhapus" + ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub DataGridView6_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView6.CellContentDoubleClick
        Call HapusdataDatagridview(e.RowIndex)
    End Sub
End Class