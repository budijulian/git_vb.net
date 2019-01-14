Imports MySql.Data.MySqlClient
Imports System.IO ' untuk buka dokument io
Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbConnection
Imports Microsoft.Office.Interop

Public Class Laporan
    'Public ConnectionString As String = "server=localhost;database=db_kasir;username=root;password=;"
    Private Sub Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'menambahkan item baru
        cb_outlet.Items.Add("--Semua--")
        'mengkunci textbox
        txt_Tbeli.Enabled = False
        txt_totalP.Enabled = False
        txt_untung.Enabled = False
        Timer1.Enabled = True
        Call Laporan("SELECT `NoPesanan`, `TanggalPesanan`, `NamaOutlet`, `Items`, `BiayaTambahan`, `KetTambahan`, `TotalBelanja`, `Penjualan`, `Keuntungan`, `Refund`, `Keterangan` FROM `laporankeuangan` ORDER BY TanggalPesanan ASC")
        Call T_item()
        Call totalBeli()
        Call totalJual()
        Call untung()
        Call refund()
        Call namaoutlet()
    End Sub


    Public conn As New MySqlConnection
    Public dtbeli As String
    Public jenis As String
    Public namab As String
    Public banyak As String
    Public satuan As String
    Public Hsatuan As String
    Public Hbeli As String
    Sub T_item()
        'menentukan jumlah item seluruhnya
        Dim x As Double
        For b As Integer = 0 To DataGridView1.RowCount - 1
            x = x + DataGridView1.Rows(b).Cells(3).Value
        Next
        st_Total.Text = x
    End Sub
  
    Private Sub totalBeli()
        'menentukan  totalbeli seluruhnya
        Dim x As Double
        For b As Integer = 0 To DataGridView1.RowCount - 1
            x = x + DataGridView1.Rows(b).Cells(6).Value
        Next
        txt_Tbeli.Text = x
    End Sub
    Private Sub totalJual()
        'menentukan jumlah total jual seluruhnya
        Dim x As Double
        For b As Integer = 0 To DataGridView1.RowCount - 1
            x = x + DataGridView1.Rows(b).Cells(7).Value
        Next
        txt_totalP.Text = x
    End Sub
    Private Sub untung()
        'menentukan jumlah total jual seluruhnya
        Dim x As Double
        For b As Integer = 0 To DataGridView1.RowCount - 1
            x = x + DataGridView1.Rows(b).Cells(8).Value
        Next
        txt_untung.Text = x
    End Sub
    
    Private Sub refund()
        'menentukan jumlah refund seluruhnya
        Dim x As Double
        For b As Integer = 0 To DataGridView1.RowCount - 1
            x = x + DataGridView1.Rows(b).Cells(9).Value
        Next
        st_refund.Text = x
    End Sub
   
    Sub Laporan(ByVal query As String)
        Try
            conn = New MySqlConnection("server=localhost;database=db_kasir;username=root;password=;")
            conn.Open()
            Dim dm As MySqlCommand
            dm = New MySqlCommand(query, conn)
            Dim dp As New MySqlDataAdapter(dm)
            Dim dt As New DataTable
            dp.Fill(dt)
            DataGridView1.DataSource = dt
            conn.Close()
            'memberi lebar kolom di datagridview1
            DataGridView1.Columns(0).Width = 120
            DataGridView1.Columns(1).Width = 120
            DataGridView1.Columns(2).Width = 220
            DataGridView1.Columns(3).Width = 100
            DataGridView1.Columns(4).Width = 120
            DataGridView1.Columns(5).Width = 100
            DataGridView1.Columns(6).Width = 100
            DataGridView1.Columns(7).Width = 100
            DataGridView1.Columns(8).Width = 100
            DataGridView1.Columns(9).Width = 100
            DataGridView1.Columns(10).Width = 100
        Catch ex As Exception
            'Menghitung total item yang muncul di datagridview2
            st_Total.Text = DataGridView1.RowCount - 1
        End Try
    End Sub
    

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time.Text = Date.Now.ToString("hh:mm:ss ")
        time1.Text = Date.Now.ToString("dd-MM-yyyy")
    End Sub

    Private Sub DateTimePicker4_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker4.ValueChanged
        Call Laporan("SELECT `NoPesanan`, `TanggalPesanan`, `NamaOutlet`, `Items`, `BiayaTambahan`, `KetTambahan`, `TotalBelanja`, `Penjualan`, `Keuntungan`, `Refund`, `Keterangan` FROM `laporankeuangan` WHERE `TanggalPesanan`='" + DateTimePicker4.Text + "' ORDER BY TanggalPesanan ASC")
        Call T_item()
        Call totalBeli()
        Call totalJual()
        Call untung()
        Call refund()
    End Sub

    Private Sub btn_viewall_Click(sender As Object, e As EventArgs) Handles btn_viewall.Click
        Call Laporan("SELECT `NoPesanan`, `TanggalPesanan`, `NamaOutlet`, `Items`, `BiayaTambahan`, `KetTambahan`, `TotalBelanja`, `Penjualan`, `Keuntungan`, `Refund`, `Keterangan` FROM `laporankeuangan` ORDER BY TanggalPesanan ASC")
        Call T_item()
        Call totalBeli()
        Call totalJual()
        Call untung()
        Call refund()
    End Sub

    Private Sub btn_ekport_Click(sender As Object, e As EventArgs) Handles btn_ekport.Click
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
    End Sub
    Sub namaoutlet()
        Try
            conn.Open()
            Dim query As String = "SELECT DISTINCT `NamaOutlet` FROM `outlet` WHERE 1"
            Dim command = New MySqlCommand
            command = New MySqlCommand(query, conn)
            Dim adapter As MySqlDataAdapter
            adapter = New MySqlDataAdapter
            adapter.SelectCommand = command
            'bind data ke input data ke combobox
            Dim dt As New DataTable
            adapter.Fill(dt)
            cb_outlet.DataSource = dt
            cb_outlet.DisplayMember = "NamaOutlet"
        Catch ex As Exception
        Finally
            conn.Close()
        End Try
    End Sub
    Sub HapusdataDatagridview(ByVal e As Integer)
        Try
            Dim pesan As MsgBoxResult
            pesan = MsgBox("Apakah Anda Yakin Menghapus Data Ini", MsgBoxStyle.YesNo, " Hapus Data")
            If pesan = MsgBoxResult.Yes Then
                Dim delete = New MySqlCommand

                conn.Open()
                delete = conn.CreateCommand
                delete.CommandText = "DELETE FROM `laporankeuangan` WHERE `NoPesanan`='" + DataGridView1.Rows(e).Cells(0).Value + "'"
                delete.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Terhapus", "Perhatian")
                conn.Close()
            Else

            End If
            Call Laporan("SELECT `NoPesanan`, `TanggalPesanan`, `NamaOutlet`, `Items`, `BiayaTambahan`, `KetTambahan`, `TotalBelanja`, `Penjualan`, `Keuntungan`, `Refund`, `Keterangan` FROM `laporankeuangan` ORDER BY TanggalPesanan ASC")

        Catch ex As Exception
            MsgBox("Data gagal terhapus" + ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Call HapusdataDatagridview(e.RowIndex)
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Call HapusdataDatagridview(e.RowIndex)
    End Sub

    Private Sub btn_chart_Click(sender As Object, e As EventArgs) Handles btn_chart.Click
        Try
            If cb_outlet.Text = "" Then
                grafik.Label4.Text = DateTimePicker4.Text
                grafik.Label5.Text = DateTimePicker5.Text
                grafik.st_namao.Text = "Semua Outlet"
                Dim buka As New grafik
                buka.MdiParent = Homepage
                buka.Show()
            Else
                grafik.Label4.Text = DateTimePicker4.Text
                grafik.Label5.Text = DateTimePicker5.Text
                grafik.st_namao.Text = cb_outlet.Text
                Dim buka As New grafik
                buka.MdiParent = Homepage
                buka.Show()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub DateTimePicker5_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker5.ValueChanged
        Call Laporan("SELECT `NoPesanan`, `TanggalPesanan`, `NamaOutlet`, `Items`, `BiayaTambahan`, `KetTambahan`, `TotalBelanja`, `Penjualan`, `Keuntungan`, `Refund`, `Keterangan` FROM `laporankeuangan` WHERE `TanggalPesanan` BETWEEN '" + DateTimePicker4.Text + "' AND '" + DateTimePicker5.Text + "' ORDER BY TanggalPesanan ASC")
        Call T_item()
        Call totalBeli()
        Call totalJual()
        Call untung()
        Call refund()
    End Sub


    Private Sub cb_outlet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_outlet.SelectedIndexChanged
        Call Laporan("SELECT `NoPesanan`, `TanggalPesanan`, `NamaOutlet`, `Items`, `BiayaTambahan`, `KetTambahan`, `TotalBelanja`, `Penjualan`, `Keuntungan`, `Refund`, `Keterangan` FROM `laporankeuangan` WHERE `NamaOutlet` LIKE '" + cb_outlet.Text + "%' ORDER BY TanggalPesanan ASC")
        Call T_item()
        Call totalBeli()
        Call totalJual()
        Call untung()
        Call refund()
    End Sub
    'Sub cetaklaporan(ByRef query As String)
    '    Try
    '        Dim ds As New DataSet()
    '        Dim ad As New MySqlDataAdapter
    '        conn.Open()
    '        ad.SelectCommand = New MySqlCommand(query, conn)
    '        ad.Fill(ds)
    '        ds.WriteXml(CurDir() & "/Pesanan.xml", XmlWriteMode.WriteSchema) ' create xml file dari dataset
    '    Catch ex As Exception

    '    End Try
    'End Sub
    Private Sub btn_cetak_Click(sender As Object, e As EventArgs) Handles btn_cetak.Click
        'formula untuk mengirim value texboxt ke formula di crystal report (CrystalReportViewer1)
        LaporanOutlet.CrystalReportViewer1.SelectionFormula = "{laporankeuangan1.TanggalPesanan} in ('" & DateTimePicker4.Text & "') to ('" & DateTimePicker5.Text & "')"
        LaporanOutlet.CrystalReportViewer1.ReportSource = "Laporan Keuangan.rpt"
        LaporanOutlet.CrystalReportViewer1.RefreshReport()
        LaporanOutlet.MdiParent = Homepage
        LaporanOutlet.Show()
    End Sub
    Dim konek As OleDbConnection 'koneksi odb
    Dim dt As OleDbDataAdapter
    Dim dts As DataSet ' membuat table datasheet virtual
    Dim excel As String
    Dim openfiledialog As New OpenFileDialog ' membuka file dialog
    Private Sub btn_import_Click(sender As Object, e As EventArgs) Handles btn_import.Click

        Try

            openfiledialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments ' folder/ directory pertama kali dibuka
            openfiledialog.Filter = "All Files (*.*)|*.*|Excel Files (*.xlsx)|*.xlsx|Xls Files (*.xls)|*.xls"
            If openfiledialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                Dim fi As New IO.FileInfo(openfiledialog.FileName)
                Dim filename As String = openfiledialog.FileName
                excel = fi.FullName
                konek = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excel + ";Extended Properties=Excel 12.0;")
                dt = New OleDbDataAdapter("Select * From [Sheet2$]", konek)
                dts = New DataSet
                dt.Fill(dts, "[Sheet2$]") ' menyimpan data excel di sheet2$
                DataGridView1.DataSource = dts
                DataGridView1.DataMember = "[Sheet2$]"
                konek.Close()
      
            End If
           
        Catch ex As Exception
            MsgBox(ex.Message)
           
        Finally

        End Try


    End Sub

    Private Sub btn_savedb_Click(sender As Object, e As EventArgs) Handles btn_savedb.Click
        Try
            ' memasukan data ke database mysql dari datagridview
            Dim cmd As MySqlCommand
            Dim import As String

            For i As Integer = 0 To DataGridView1.Rows.Count - 2
                conn.Open()
                import = "INSERT INTO `laporankeuangan` VALUES (@no,@dt_date,@namao,@item,@biayat,@ketT,@totalB,@jual,@untung,@refund,@keterangan)"
                cmd = New MySqlCommand(import, conn)
                cmd.Parameters.Add("@no", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(0).Value.ToString()
                cmd.Parameters.Add("@dt_date", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(1).Value.ToString()
                cmd.Parameters.Add("@namao", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(2).Value.ToString()
                cmd.Parameters.Add("@item", MySqlDbType.Double).Value = DataGridView1.Rows(i).Cells(3).Value.ToString()
                cmd.Parameters.Add("@biayat", MySqlDbType.Double).Value = DataGridView1.Rows(i).Cells(4).Value.ToString()
                cmd.Parameters.Add("@ketT", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(5).Value.ToString()
                cmd.Parameters.Add("@totalB", MySqlDbType.Double).Value = DataGridView1.Rows(i).Cells(6).Value.ToString()
                cmd.Parameters.Add("@jual", MySqlDbType.Double).Value = DataGridView1.Rows(i).Cells(7).Value.ToString()
                cmd.Parameters.Add("@untung", MySqlDbType.Double).Value = DataGridView1.Rows(i).Cells(8).Value.ToString()
                cmd.Parameters.Add("@refund", MySqlDbType.Float).Value = DataGridView1.Rows(i).Cells(9).Value.ToString()
                cmd.Parameters.Add("@keterangan", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(10).Value.ToString()
                cmd.ExecuteNonQuery()
                conn.Close()
            Next

            'menampilkan isi table laporankeuangan
            MessageBox.Show("Data Berhasil disimpan")
            Call Laporan("SELECT `NoPesanan`, `TanggalPesanan`, `NamaOutlet`, `Items`, `BiayaTambahan`, `KetTambahan`, `TotalBelanja`, `Penjualan`, `Keuntungan`, `Refund`, `Keterangan` FROM `laporankeuangan` ORDER BY TanggalPesanan ASC")

        Catch ex As Exception
        Finally

        End Try

    End Sub
End Class