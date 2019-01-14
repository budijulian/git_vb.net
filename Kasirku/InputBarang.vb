Imports MySql.Data.MySqlClient
Public Class InputBarang
    Private conn As MySqlConnection
    Private adapter As New MySqlDataAdapter
    Private cm As New MySqlCommand
    Sub TampilTransaksi(ByRef sql As String)
        Try
            conn = New MySqlConnection("server=localhost;database=db_kasir;username=root;password=;")
            conn.Open()
            adapter = New MySqlDataAdapter(sql, conn)
            Dim dt As New DataTable
            adapter.Fill(dt)
            DataGridView1.DataSource = dt
            'st_tItems.Text = DataGridView1.RowCount - 1
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Sub TampilBeliBarang(ByVal sql As String)
        Try
            conn.Open()
            adapter = New MySqlDataAdapter(sql, conn)
            Dim dt As New DataTable
            adapter.Fill(dt)
            DataGridView2.DataSource = dt

            'memberi lebar kolom di datagridview1

            DataGridView2.Columns(0).Width = 50
            DataGridView2.Columns(1).Width = 100
            DataGridView2.Columns(2).Width = 120
            DataGridView2.Columns(3).Width = 90
            DataGridView2.Columns(4).Width = 80
            DataGridView2.Columns(5).Width = 80
            DataGridView2.Columns(6).Width = 80
            DataGridView2.Columns(7).Width = 70
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    'Public ConnectionString As String = "server=localhost;database=db_kasir;username=root;password=;"
    Private Sub InputBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        Call TampilTransaksi("SELECT `NoTransaksi`, `TanggalBeli`, `NamaOutlet`,  `NamaPesanan`, `JenisOrder`,`Banyak`, `Satuan`, `HargaBeliS` As `HargaSatuan`,`HargaBeli`,`Keterangan` FROM `order` ORDER BY TanggalPesanan ASC")

        'memberi colom pada listview
        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.Columns.Add("No", 30)
        ListView1.Columns.Add("Nama Outlet", 100)
        ListView1.Columns.Add("Banyak", 90)

    End Sub
    Sub tampildatabelidgv2(ByRef sql As String)
        Try
            conn.Open()
            adapter = New MySqlDataAdapter(Sql, conn)
            Dim dt As New DataTable
            adapter.Fill(dt)
            DataGridView2.DataSource = dt

            'memberi lebar kolom di datagridview1

            DataGridView2.Columns(0).Width = 80
            DataGridView2.Columns(1).Width = 100
            DataGridView2.Columns(2).Width = 100
            DataGridView2.Columns(3).Width = 90
            DataGridView2.Columns(4).Width = 80
            DataGridView2.Columns(5).Width = 80
            DataGridView2.Columns(6).Width = 80
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub btn_searching_Click(sender As Object, e As EventArgs) Handles btn_searching.Click
        Call TampilTransaksi("SELECT `NoTransaksi`, `TanggalBeli`, `NamaOutlet`,  `NamaPesanan`, `JenisOrder`,`Banyak`, `Satuan`, `HargaBeliS` As `HargaSatuan`,`HargaBeli`,`Keterangan` FROM `order` WHERE TanggalBeli ='" + dt_beli.Text + "' ORDER BY TanggalPesanan ASC")
        Call tampildatabelidgv2("SELECT `TanggalBeli`,`NamaPesanan` AS `NamaBarang`,`JenisOrder`AS `Jenis`,SUM(`Banyak`) AS `Total/satuan`,`Satuan`,`HargaBeliS` As `HargaSatuan`,SUM(`HargaBeli`) AS `HargaBeli*` FROM `order` WHERE TanggalBeli='" + dt_beli.Text + "' GROUP BY `NamaBarang`")


        st_total.Text = DataGridView2.RowCount - 1
    End Sub
    Sub hapustransaksi(ByVal e As Integer)
        Try
            Dim pesan As MsgBoxResult
            pesan = MsgBox("Apakah Anda Yakin Menghapus Data Ini", MsgBoxStyle.YesNo, " Hapus Data")
            If pesan = MsgBoxResult.Yes Then
                Dim delete = New MySqlCommand
                conn.Open()
                delete = conn.CreateCommand
                delete.CommandText = "DELETE FROM `order` WHERE `NoTransaksi`='" + DataGridView1.Rows(e).Cells(0).Value + "'"
                delete.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Terhapus", "Perhatian")

                Call TampilTransaksi("SELECT `NoTransaksi`, `TanggalBeli`, `NamaOutlet`,  `NamaPesanan`, `JenisOrder`,`Banyak`, `Satuan`, `HargaBeliS` As `HargaSatuan`,`HargaBeli`,`Keterangan` FROM `order` WHERE TanggalBeli ='" + dt_beli.Text + "' ORDER BY TanggalPesanan ASC")

                conn.Close()
            Else
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Call hapustransaksi(e.RowIndex)
    End Sub


    Private Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click
        Dim Appli As New Microsoft.Office.Interop.Excel.Application
        Dim workb As Microsoft.Office.Interop.Excel.Workbook
        Dim sheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim col As Integer = DataGridView2.ColumnCount
        Dim row As Integer = DataGridView2.RowCount
        workb = Appli.Workbooks.Add
        sheet = Appli.Worksheets.Add()

        For i As Integer = 1 To col
            sheet.Cells.Item(1, i) = DataGridView2.Columns(i - 1).Name.ToString
        Next

        'recorr data ke file
        For file As Integer = 0 To row - 1
            For a As Integer = 0 To col - 1
                sheet.Cells.Item(file + 2, a + 1) = DataGridView2.Rows(file).Cells(a).Value
            Next
        Next

        sheet.Rows.Item(1).Font.Bold = 1
        sheet.Rows.Item(1).HorizontalAlignment = 3
        sheet.StandardWidth = 100 'memberi ukuran lebar column sesuai standar
        sheet.Columns.AutoFit()
        Appli.Application.Visible = True
        Appli.Application.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized
        sheet = Nothing
        workb = Nothing
        Appli = Nothing
    End Sub
    Public NO As Double
    Private Sub NoTransaksi()
        Try
            Dim angka As New Random
            Dim angka2 As New Random
            Dim number As Double

            number = angka.Next(999) + angka2.Next(99)
            number = number + 100000
            NO = number
        Catch ex As Exception

        End Try
    End Sub
    

    Sub detail_namabarang(ByRef x As Integer)
        Try
            'membersihkan secara default listview
            ListView1.Items.Clear()

            conn.Open()
            Dim sql As String = "SELECT `NamaOutlet`,SUM(`Banyak`) AS `Banyak` FROM `order` WHERE `TanggalBeli`='" + dt_beli.Text + "' AND `NamaPesanan`='" + DataGridView2.Rows(x).Cells(1).Value + "' GROUP BY `NamaOutlet`"
            Dim NO As Integer = 1

            cm = New MySqlCommand(sql, conn)
            Dim rd As MySqlDataReader
            rd = cm.ExecuteReader
            While rd.Read
                Dim lst As New ListViewItem
                lst.Text = NO 'kolom pertama di listview
                lst.SubItems.Add(rd("NamaOutlet")) ' memasukan nilai dari nama colomn di database
                lst.SubItems.Add(rd("Banyak")) ' memasukan nilai dari nama colomn di database
                'memasukan data ke listview 
                ListView1.Items.Add(lst)
                NO = NO + 1 ' kenaikan 1 angka atau untuk memberi nilai default pada colomn NO
            End While
            'memanggil sub banyak item per outlet
            Call BanyakItemOutlet()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Sub BanyakItemOutlet()
        'mencari total  item di tiap outlet
        Dim tambah As Integer
        For i = 0 To ListView1.Items.Count - 1
            tambah = tambah + Val(ListView1.Items(i).SubItems(2).Text)
        Next
        t_banyak.Text = tambah
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Call detail_namabarang(e.RowIndex)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'memanggil waktu
        st_waktu.Text = Date.Now.ToString("hh:mm")
    End Sub
    Sub hapusdvg2(ByVal e As Integer)
        Try
            Dim pesan As MsgBoxResult
            pesan = MsgBox("Apakah Anda Yakin Menghapus Data Ini", MsgBoxStyle.YesNo, " Hapus Data")
            If pesan = MsgBoxResult.Yes Then
                Dim delete = New MySqlCommand
                conn.Open()
                delete = conn.CreateCommand
                delete.CommandText = "DELETE FROM `belibarang` WHERE `NO`='" + DataGridView2.Rows(e).Cells(0).Value.ToString + "'"
                delete.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Terhapus", "Perhatian")
                conn.Close()
            Else
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub DataGridView2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        ' Call hapusdvg2(e.RowIndex)

    End Sub

    Private Sub btn_viewal_Click(sender As Object, e As EventArgs) Handles btn_viewal.Click
        Call TampilTransaksi("SELECT `NoTransaksi`,`TanggalBeli`, `NamaOutlet`,  `NamaPesanan`, `JenisOrder`,`Banyak`, `Satuan`, `HargaBeliS`,`HargaBeli`,`Keterangan` FROM `order` WHERE 1 ORDER BY TanggalPesanan ASC")

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class