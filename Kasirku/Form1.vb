Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Xml
Imports System.IO
Imports System.Data.OleDb.OleDbConnection
Imports Microsoft.Office.Interop
Imports CrystalDecisions.CrystalReports
Imports System.Configuration
Imports System.Text.RegularExpressions
Public Class Form1
    Public conn As MySqlConnection
    Public namapimpinan As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' <ConnectionString>
        ' <Add name="db_kasir.sql" providerName="System.MySql.Data.MySqlClient" ConnectionString="server=localhost;database=db_kasir;username=root;password=;"/>
        '   </ConnectionString>
        '
        conn = New MySqlConnection("server=localhost;database=db_kasir;username=root;password=;")
        'mengaktifkan timer pada waktu
        Timer1.Enabled = True

        ' mengambil value dari username form login
        namapimpinan = FormLogin.txt_unsername.Text
        Call dataprofile()
        'mengisi value di cb_keterangan
        ' cb_keterangan.Items.Add("Sale")
        cb_keterangan.Items.Add("Refund")
        ' menginputkan nilai di texbox
        cb_outlet.Enabled = True
        'mengkunci  texbox yang di kunci
        ' txt_faktur.Enabled = False
        txt_namaO.Enabled = False
        dt_order.Enabled = False
        dt_beli.Enabled = False
        txt_namab.Enabled = False
        txt_jenisb.Enabled = False
        txt_satuan.Enabled = False
        txt_hbeli.Enabled = False
        txt_HSatuan.Enabled = False
        txt_TOthers.Enabled = False
        cb_keterangan.Enabled = False
        st_nama.Enabled = True
        n_refund.Visible = False
        btn_edit.Enabled = False
        btn_hapus.Enabled = False
        pf_alamat.Enabled = False
        pf_email.Enabled = False
        pf_perusahaan.Enabled = False
        pf_telepon.Enabled = False
        '***Memasukan value ke texbox = cb_outlet
        txt_hjual.Enabled = False
        'mengkunci texkbox
        txt_Tbuah.Enabled = False
        txt_T_item.Enabled = False
        txt_TJual.Enabled = False
        txt_TotalB.Enabled = False
        txt_Tsayur.Enabled = False
        Try
            conn.Open()
            Dim query As String = "SELECT `NamaOutlet` FROM `outlet` WHERE 1"
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


        'memasukan item di texbox dan combobox
        txt_jenisb.Text = "Pilih Jenis Barang"
        txt_namab.Text = "Pilih Nama Barang"

        'meamanggil tmapilan datagridview2

        Call TampilPesanan()
        'memanggil tampilan datagridview1
        Call TampilTransaksi()
        Call totaljenisjual()
        Call TotalBeliItem()

        'Menghitung total item yang muncul di datagridview2
        txt_T_item.Text = DataGridView2.RowCount - 1
        'memberi status pada statusstip
        st_date.Text = dt_order.Text
        st_namab.Text = txt_namab.Text
        st_outlet.Text = txt_namaO.Text
        st_tItems.Text = DataGridView1.RowCount - 1

        'memberi lebar kolom di datagridview1
        DataGridView1.Columns(0).Width = 170
        DataGridView1.Columns(1).Width = 150
        DataGridView1.Columns(2).Width = 130
        DataGridView1.Columns(3).Width = 110
        DataGridView1.Columns(4).Width = 125
        DataGridView1.Columns(5).Width = 100
        DataGridView1.Columns(6).Width = 70
        DataGridView1.Columns(7).Width = 60
        DataGridView1.Columns(8).Width = 100
        DataGridView1.Columns(9).Width = 90
        DataGridView1.Columns(10).Width = 90
        DataGridView1.Columns(11).Width = 100
        DataGridView1.Columns(12).Width = 100
        DataGridView1.Columns(13).Width = 100

    End Sub
    Sub totaljenisjual()

        Dim x As Integer
        For b As Integer = 0 To DataGridView2.RowCount - 1
            If DataGridView2.Rows(b).Cells(4).Value = "Vegetables" Then
                x = x + 1 'DataGridView2.Rows(b).Cells(4).Value = jika mencari nilai dari kolom(4) 
            End If
        Next
        txt_Tsayur.Text = x
        Dim y As Integer
        For b As Integer = 0 To DataGridView2.RowCount - 1
            If DataGridView2.Rows(b).Cells(4).Value = "Fruit" Then
                y = y + 1 'DataGridView2.Rows(b).Cells(5).Value
            End If
        Next
        txt_Tbuah.Text = y
        Dim d As Integer
        For b As Integer = 0 To DataGridView2.RowCount - 1
            If DataGridView2.Rows(b).Cells(4).Value = "Others" Then
                d = d + 1
            End If
        Next
        txt_TOthers.Text = d
        Dim z As Double
        For b As Integer = 0 To DataGridView2.RowCount - 1
            z = z + DataGridView2.Rows(b).Cells(8).Value
        Next
        txt_TJual.Text = z

    End Sub
   
    Sub TotalJualItem()
        Dim z As Double
        For b As Integer = 0 To DataGridView2.RowCount - 1
            z = z + DataGridView2.Rows(b).Cells(8).Value
        Next
        txt_TJual.Text = z
    End Sub
    Sub TotalBeliItem()
        Dim g As Double
        For b As Integer = 0 To DataGridView2.RowCount - 1
            g = g + DataGridView2.Rows(b).Cells(7).Value
        Next
        txt_TotalB.Text = g
    End Sub
    Private Sub btn_profile_Click(sender As Object, e As EventArgs) Handles btn_profile.Click

        'mengirim nilai / value ke form profile
        Profile.pf_nama.Text = st_nama.Text
        Dim open As New Profile
        open.MdiParent = Homepage
        open.Show()
    End Sub
    Public Sub dataprofile()
        Try
            conn.Open()
            Dim query4 As String = "SELECT `nama`,`alamat`,`email`,`telepon` FROM `login` WHERE unsername='" + namapimpinan + "'"
            Dim command2 = New MySqlCommand
            command2 = New MySqlCommand(query4, conn)
            Dim rd As MySqlDataReader
            rd = command2.ExecuteReader()
            While rd.Read()
                st_nama.Text = rd.GetValue(0).ToString()
                pf_alamat.Text = rd.GetValue(1).ToString()
                pf_email.Text = rd.GetValue(2).ToString()
                pf_telepon.Text = rd.GetValue(3).ToString()
            End While
        Catch ex As Exception
        Finally
            conn.Close()
        End Try
        'memberi nilai pada value lb namalogin ketika masuk di form login
        namalogin.Text = "Hai," + st_nama.Text
    End Sub

    Private Sub pf_edit_Click(sender As Object, e As EventArgs) Handles pf_edit.Click
        'mengirim nilai / value ke form profile
        Profile.nama = st_nama.Text
        Dim open As New Profile
        open.MdiParent = Homepage
        open.Show()
    End Sub
    Sub Tampil_Order(ByVal date_order As String)
        Try
            conn.Open()
            Dim masuk As String
            masuk = "SELECT `NoTransaksi`,`NamaOutlet`, `TanggalPesanan`, `TanggalBeli`, `NamaPesanan`, `JenisOrder`,`Banyak`, `Satuan`, `HargaBeliS`,`HargaJualS`,`HargaBeli`, `HargaJual`,`Keterangan`,`Refund` FROM `order` WHERE NamaOutlet like '%" + txt_namaO.Text + "%' AND TanggalPesanan='" + date_order + "' ORDER BY TanggalPesanan ASC"
            Dim adapter As New MySqlDataAdapter
            adapter = New MySqlDataAdapter(masuk, conn)
            Dim dt As New DataTable
            adapter.Fill(dt)
            DataGridView1.DataSource = dt

            'memberi lebar kolom di datagridview1
            DataGridView1.Columns(0).Width = 170
            DataGridView1.Columns(1).Width = 150
            DataGridView1.Columns(2).Width = 130
            DataGridView1.Columns(3).Width = 110
            DataGridView1.Columns(4).Width = 125
            DataGridView1.Columns(5).Width = 100
            DataGridView1.Columns(6).Width = 70
            DataGridView1.Columns(7).Width = 60
            DataGridView1.Columns(8).Width = 100
            DataGridView1.Columns(9).Width = 90
            DataGridView1.Columns(10).Width = 90
            DataGridView1.Columns(11).Width = 100
            DataGridView1.Columns(12).Width = 100
            DataGridView1.Columns(13).Width = 100
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Sub TampilTransaksi()
        Try
            conn.Open()
            Dim masuk As String
            Dim dt As New DataTable
            masuk = "SELECT `NoTransaksi`,`NamaOutlet`, `TanggalPesanan`, `TanggalBeli`, `NamaPesanan`, `JenisOrder`,`Banyak`, `Satuan`, `HargaBeliS`,`HargaJualS`,`HargaBeli`, `HargaJual`,`Keterangan`,`Refund` FROM `order` ORDER BY TanggalPesanan ASC"
            Dim adapter As New MySqlDataAdapter
            adapter = New MySqlDataAdapter(masuk, conn)
            'Dim dt As New DataTable
            adapter.Fill(dt)
            DataGridView1.DataSource = dt
            'memberi lebar kolom di datagridview1
            DataGridView1.Columns(0).Width = 170
            DataGridView1.Columns(1).Width = 150
            DataGridView1.Columns(2).Width = 130
            DataGridView1.Columns(3).Width = 110
            DataGridView1.Columns(4).Width = 125
            DataGridView1.Columns(5).Width = 100
            DataGridView1.Columns(6).Width = 70
            DataGridView1.Columns(7).Width = 60
            DataGridView1.Columns(8).Width = 100
            DataGridView1.Columns(9).Width = 90
            DataGridView1.Columns(10).Width = 90
            DataGridView1.Columns(11).Width = 100
            DataGridView1.Columns(12).Width = 100
            DataGridView1.Columns(13).Width = 100
            'mencari total banyak baris di item  DGV
            st_tItems.Text = DataGridView1.RowCount - 1


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
  
    Sub Query(ByVal sql As String)
        Try
            Dim untung As String
            untung = Convert.ToDouble(TJual) - Convert.ToDouble(TBeli)
            conn.Open()
            Dim cd = New MySqlCommand
            cd = conn.CreateCommand
            cd.CommandText = sql
            cd.Parameters.AddWithValue("@No", txt_faktur.Text)
            cd.Parameters.AddWithValue("@namaO", txt_namaO.Text)
            cd.Parameters.AddWithValue("@alamat", alamat_outlet) ' variabel alamat outlet di sub alamat
            cd.Parameters.AddWithValue("@dtOrder", dt_order.Text)
            cd.Parameters.AddWithValue("@dtbeli", dt_beli.Text)
            cd.Parameters.AddWithValue("@nama", txt_namab.Text)
            cd.Parameters.AddWithValue("@jenis", txt_jenisb.Text)
            cd.Parameters.AddWithValue("@banyak", txt_satuan.Text)
            cd.Parameters.AddWithValue("@satuan", lb_satuan.Text)
            cd.Parameters.AddWithValue("@hargabelis", txt_HSatuan.Text)
            cd.Parameters.AddWithValue("@hargajuals", HJualsatuan)
            cd.Parameters.AddWithValue("@hargaJ", Convert.ToDouble(TJual))
            cd.Parameters.AddWithValue("@hargaB", Convert.ToDouble(TBeli))
            cd.Parameters.AddWithValue("@untung", untung)
            cd.Parameters.AddWithValue("@keterangan", cb_keterangan.Text)
            cd.Parameters.AddWithValue("@refund", n_refund.Text)

            cd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        ' memanggil sub untuk mencari nama alamat
        Call alamat()
        Call Query("INSERT INTO `order`(`NoTransaksi`, `NamaOutlet`, `TanggalPesanan`, `TanggalBeli`, `NamaPesanan`, `JenisOrder`, `Banyak`, `Satuan`,`HargaBeliS`,`HargaJualS`, `HargaJual`, `HargaBeli`,`Alamat`,`Keuntungan`,`Keterangan`,`Refund`) VALUES (@No,@namaO,@dtOrder,@dtbeli,@nama,@jenis,@banyak,@satuan,@hargabelis,@hargajuals,@hargaJ,@hargaB,@alamat,@untung,@keterangan,@refund)")
        st_tItems.Text = DataGridView1.RowCount - 1
        btn_edit.Enabled = True
        btn_hapus.Enabled = True
        n_refund.Text = 0
        'membersihkan atau mengkosongkan
        txt_hbeli.Text = "0"
        txt_hjual.Text = "0"
        txt_satuan.Text = "0"
        txt_HSatuan.Text = "0"
        n_refund.Text = 0
        cb_keterangan.Text = "Sale"
        'memasukan item di texbox dan combobox
        txt_jenisb.Text = "Pilih Jenis Barang"
        txt_namab.Text = "Pilih Nama Barang"
        'memanggil no tranksaksi yang berbeda

        Call NoTransaksi()
        Call Tampil_Order(dt_order.Text)
    End Sub

    Private Sub btn_Refresh_Click(sender As Object, e As EventArgs) Handles btn_Refresh.Click
        Call TampilTransaksi()
        btn_edit.Enabled = False
        btn_hapus.Enabled = False
    End Sub
    Private Sub NoTransaksi()
        Try
            Dim angka, angka2 As New Random
            Dim number, number2 As Double
            Dim kata As String
            'skrip ini befungsi  memberikan nilai angka acak pada texboxt
            number = angka.Next(999)
            number2 = angka2.Next(999)
            number2 = number + number2
            number = number + 100000
            kata = Strings.Left(cb_outlet.Text, 3) ' mengambil huruf 3 kiri terakhir dari kalimat

            Me.txt_faktur.Text = number & kata.ToUpper() & number2


        Catch ex As Exception

        End Try
    End Sub


    Private Sub btn_pilih_Click(sender As Object, e As EventArgs) Handles btn_pilih.Click
        cb_keterangan.Text = "Sale"
        'membuka dan mengkunci texbox 
        dt_order.Enabled = True
        dt_beli.Enabled = True
        txt_namab.Enabled = True
        txt_satuan.Enabled = True
        txt_HSatuan.Enabled = True
        txt_hbeli.Enabled = False
        txt_hjual.Enabled = False
        txt_jenisb.Enabled = True
        'enable button simpan
        btn_tambah.Enabled = True
        'membuat nomor faktur
        Call NoTransaksi()

        ' mengcopy value di nama pilihan outlet dengan fungsi string.copy
        txt_namaO.Text = String.Copy(cb_outlet.Text)
        'mereset isi kolom datagridview
        DataGridView1.Columns.Clear()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Try
            Dim refund As Double
            Dim untung As String = 0
            'keterangan pesanan refund atau tidak 
            If cb_keterangan.Text = "Sale" Then
                n_refund.Visible = False
                TJual = (HJualsatuan * Convert.ToDouble(txt_satuan.Text))
                TBeli = (HBelisatuan * Convert.ToDouble(txt_satuan.Text))
                untung = Convert.ToDouble(TJual) - Convert.ToDouble(TBeli)

                txt_hbeli.Text = String.Copy("RP. " + TBeli.ToString() + ",00")
                txt_hjual.Text = String.Copy("RP. " + TJual.ToString() + ",00")
            ElseIf cb_keterangan.Text = "Refund" Then
                n_refund.Visible = True
                TJual = (HJualsatuan * Convert.ToDouble(txt_satuan.Text))
                TBeli = (HBelisatuan * Convert.ToDouble(txt_satuan.Text))
                refund = HJualsatuan * n_refund.Text
                TJual = TJual - refund
                untung = Convert.ToDouble(TJual) - Convert.ToDouble(TBeli)

                txt_hbeli.Text = String.Copy("RP. " + TBeli.ToString() + ",00")
                txt_hjual.Text = String.Copy("RP. " + TJual.ToString() + ",00")
            End If
            Dim cd = New MySqlCommand
            cd = conn.CreateCommand
            cd.CommandText = "UPDATE `order` SET NoTransaksi=@No,NamaOutlet=@namaO,TanggalPesanan=@dtOrder,TanggalBeli=@dtbeli,JenisOrder=@jenis,Banyak=@banyak,Satuan=@satuan,HargaBeliS=@hargabelis,HargaJual=@hargaJ,HargaBeli=@hargaB,Keuntungan=@untung,Keterangan=@keterangan,Refund=@refund WHERE NoTransaksi=@No"
            cd.Parameters.AddWithValue("@No", txt_faktur.Text)
            cd.Parameters.AddWithValue("@namaO", txt_namaO.Text)
            cd.Parameters.AddWithValue("@dtOrder", dt_order.Text)
            cd.Parameters.AddWithValue("@dtbeli", dt_beli.Text)
            cd.Parameters.AddWithValue("@nama", txt_namab.Text)
            cd.Parameters.AddWithValue("@jenis", txt_jenisb.Text)
            cd.Parameters.AddWithValue("@banyak", txt_satuan.Text)
            cd.Parameters.AddWithValue("@satuan", lb_satuan.Text)
            cd.Parameters.AddWithValue("@hargabelis", txt_HSatuan.Text)
            cd.Parameters.AddWithValue("@hargaJ", Convert.ToDouble(TJual))
            cd.Parameters.AddWithValue("@hargaB", Convert.ToDouble(TBeli))
            cd.Parameters.AddWithValue("@untung", untung)
            cd.Parameters.AddWithValue("@keterangan", cb_keterangan.Text)
            cd.Parameters.AddWithValue("@refund", n_refund.Text)
            conn.Open()
            cd.ExecuteNonQuery()
            'menampilkan default
            MessageBox.Show("Data Berhasil diedit")
            Call dtp_order("SELECT `NoTransaksi`,`NamaOutlet`, `TanggalPesanan`, `TanggalBeli`, `NamaPesanan`, `JenisOrder`,`Banyak`, `Satuan`, `HargaBeliS`,`HargaJualS`, `HargaBeli`, `HargaJual`,`Keterangan`,`Refund` FROM `order` WHERE NamaOutlet like '%" + txt_namaO.Text + "%' and TanggalPesanan=@dt1 ORDER BY TanggalPesanan ASC")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
        st_tItems.Text = DataGridView1.RowCount - 1
    End Sub
    Sub Keterangan()
        Dim refund As Double
        Dim Trefund As Double
        'keterangan pesanan refund atau tidak 
        If cb_keterangan.Text = "Sale" Then
            n_refund.Visible = False
            TJual = (HJualsatuan * Convert.ToDouble(txt_satuan.Text))
            TBeli = (HBelisatuan * Convert.ToDouble(txt_satuan.Text))
            txt_hbeli.Text = String.Copy("RP. " + TBeli.ToString() + ",00")
            txt_hjual.Text = String.Copy("RP. " + TJual.ToString() + ",00")
        ElseIf cb_keterangan.Text = "Refund" Then
            If n_refund.Text <> "" Then
                n_refund.Visible = True
                TJual = (HJualsatuan * Convert.ToDouble(txt_satuan.Text))
                TBeli = (HBelisatuan * Convert.ToDouble(txt_satuan.Text))
                refund = HJualsatuan * n_refund.Text
                Trefund = TJual - refund
                txt_hbeli.Text = String.Copy("RP. " + TBeli.ToString() + ",00")
                txt_hjual.Text = String.Copy("RP. " + Trefund.ToString() + ",00")
            Else

            End If
           
        End If
    End Sub

    Private Sub cb_keterangan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_keterangan.SelectedIndexChanged
        'keterangan pesanan refund atau tidak 
        'Call Keterangan()
        If cb_keterangan.Text = "Sale" Then
            n_refund.Visible = False
        ElseIf cb_keterangan.Text = "Refund" Then
            n_refund.Visible = True
        End If
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click

        Try
            Dim pesan As MsgBoxResult
            pesan = MsgBox("Apakah Anda Yakin Menghapus Data Ini", MsgBoxStyle.YesNo, " Hapus Data")
            If pesan = MsgBoxResult.Yes Then
                Dim delete = New MySqlCommand
                conn.Open()
                delete = conn.CreateCommand
                delete.CommandText = "DELETE FROM `order` WHERE NoTransaksi='" + txt_faktur.Text + "'"
                delete.ExecuteNonQuery()
                MessageBox.Show("Data Terhapus")
                conn.Close()
            Else

            End If
            If cbp_namaO.Text = "" Then
                Call dtp_order("SELECT `NoTransaksi`,`NamaOutlet`, `TanggalPesanan`, `TanggalBeli`, `NamaPesanan`, `JenisOrder`,`Banyak`, `Satuan`, `HargaBeliS`,`HargaJualS`, `HargaBeli`, `HargaJual`,`Keterangan`,`Refund` FROM `order` WHERE NamaOutlet like '%" + txt_namaO.Text + "%' and TanggalPesanan='" + dt_order.Text + "'")
            ElseIf cbp_namaO.Text <> "" Then
                Call dtp_order("SELECT `NoTransaksi`,`NamaOutlet`, `TanggalPesanan`, `TanggalBeli`, `NamaPesanan`, `JenisOrder`,`Banyak`, `Satuan`, `HargaBeliS`,`HargaJualS`, `HargaBeli`, `HargaJual`,`Keterangan`,`Refund` FROM `order` WHERE NamaOutlet like '%" + cbp_namaO.Text + "%' and TanggalPesanan=@dt1")
            End If
              Catch ex As Exception
            MsgBox("Data gagal terhapus" + ex.Message)
        End Try
        'mencari nilai total item di datagridview
        st_tItems.Text = DataGridView1.RowCount - 1
    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        ' Membersihkan 
        txt_faktur.Text = Nothing
        txt_hbeli.Text = Nothing
        txt_hjual.Text = Nothing
        txt_namaO.Text = Nothing
        txt_satuan.Text = Nothing
        txt_HSatuan.Text = Nothing
        dt_beli.Value = Date.Today
        dt_order.Value = Date.Today
    End Sub
    Private Sub isidatagridview(ByVal x As Integer)
        Try
            txt_faktur.Text = DataGridView1.Rows(x).Cells(0).Value
            txt_namaO.Text = DataGridView1.Rows(x).Cells(1).Value
            dt_order.Text = DataGridView1.Rows(x).Cells(2).Value
            dt_beli.Text = DataGridView1.Rows(x).Cells(3).Value
            txt_namab.Text = DataGridView1.Rows(x).Cells(4).Value
            txt_jenisb.Text = DataGridView1.Rows(x).Cells(5).Value
            txt_satuan.Text = DataGridView1.Rows(x).Cells(6).Value
            lb_satuan.Text = DataGridView1.Rows(x).Cells(7).Value
            lbsatuan1.Text = String.Copy(lb_satuan.Text)
            txt_HSatuan.Text = DataGridView1.Rows(x).Cells(8).Value
            txt_hbeli.Text = DataGridView1.Rows(x).Cells(10).Value
            txt_hjual.Text = DataGridView1.Rows(x).Cells(11).Value
            cb_keterangan.Text = DataGridView1.Rows(x).Cells(12).Value
            n_refund.Text = DataGridView1.Rows(x).Cells(13).Value

            DataGridView1.Columns(14).Width = 100
        Catch ex As Exception

        End Try
        'keterangan di status bar
        st_date.Text = dt_order.Text
        st_namab.Text = txt_namab.Text
        st_outlet.Text = txt_namaO.Text
        st_tItems.Text = DataGridView1.RowCount - 1
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'memanggil value kolom dalam datagridview
        Call isidatagridview(e.RowIndex)
        dt_order.Enabled = True
        dt_beli.Enabled = True
        txt_namab.Enabled = True
        txt_satuan.Enabled = True
        txt_hbeli.Enabled = False
        txt_hjual.Enabled = False
        txt_jenisb.Enabled = True
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim pesan As MsgBoxResult
        pesan = MsgBox("Apakah Anda yakin Logout", MsgBoxStyle.YesNo, "Logout")
        If pesan = MsgBoxResult.Yes Then
            Me.Close()
            FormLogin.MdiParent = Homepage
            FormLogin.Show()
        Else
        End If

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        DaftarOutlet.MdiParent = Homepage
        DaftarOutlet.Show()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Dim pesan As MsgBoxResult
        pesan = MsgBox("Apakah Anda yakin keluar", MsgBoxStyle.YesNo, " Keluar")
        If pesan = MsgBoxResult.Yes Then
            Application.Exit()
        Else
        End If
    End Sub
    Sub dtp_order(ByVal query As String)

        Dim dm As New MySqlCommand
        Dim dp As New MySqlDataAdapter
        Dim ds As New DataTable
        Try
            conn.Open()
            dm = New MySqlCommand(query, conn)
            dm.Parameters.AddWithValue("namaO", txt_namaO.Text)
            dm.Parameters.AddWithValue("@dt1", dt_order.Text)
            dp = New MySqlDataAdapter(dm)
            dp.Fill(ds)
            DataGridView1.DataSource = ds
        Catch ex As Exception
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        If cbp_namaO.Text <> "" Then
            Call dtp_order("SELECT `NoTransaksi`,`NamaOutlet`, `TanggalPesanan`, `TanggalBeli`, `NamaPesanan`, `JenisOrder`,`Banyak`, `Satuan`, `HargaBeliS`,`HargaJualS`, `HargaBeli`, `HargaJual`,`Keterangan`,`Refund` FROM `order` WHERE NamaOutlet like '%" + cbp_namaO.Text + "%' and TanggalPesanan='" + dtp_orderP.Text + "' ORDER BY NamaOutlet ASC")
            btn_edit.Enabled = True
            btn_hapus.Enabled = True
            st_tItems.Text = DataGridView1.RowCount - 1
        ElseIf cbp_namaO.Text = "" Then
            Call dtp_order("SELECT `NoTransaksi`,`NamaOutlet`, `TanggalPesanan`, `TanggalBeli`, `NamaPesanan`, `JenisOrder`,`Banyak`, `Satuan`, `HargaBeliS`,`HargaJualS`, `HargaBeli`, `HargaJual`,`Keterangan`,`Refund` FROM `order` WHERE TanggalPesanan='" + dtp_orderP.Text + "'ORDER BY NamaOutlet ASC")
            btn_edit.Enabled = True
            btn_hapus.Enabled = True
        End If
        'keterangan di status bar
        st_date.Text = DataGridView1.Rows(0).Cells(2).Value
        st_namab.Text = DataGridView1.Rows(0).Cells(4).Value
        st_outlet.Text = DataGridView1.Rows(0).Cells(1).Value
        st_tItems.Text = DataGridView1.RowCount - 1
    End Sub

    Private Sub btn_cari_p_Click(sender As Object, e As EventArgs)
        If txt_SOutlet.Text <> "" Then
            Call CariPesanan("SELECT `NoTransaksi`,`NamaOutlet`, `TanggalPesanan`, `NamaPesanan`, `JenisOrder`,`Banyak`, `Satuan`, `HargaBeli`, `HargaJual`, `Keterangan`,`Refund` FROM `order` WHERE NamaOutlet like '%" + txt_SOutlet.Text + "%'")
            'Call CariHargaBeli("SELECT `HargaBeli` FROM `order` WHERE NamaOutlet like '%" + txt_SOutlet.Text + "%'")

        ElseIf txt_SOutlet.Text = "" Then
            Call CariPesanan("select `NoTransaksi`,`NamaOutlet`, `TanggalPesanan`, `NamaPesanan`, `JenisOrder`,`Banyak`, `Satuan`, `HargaBeli`, `HargaJual`, `Keterangan`,`Refund` from order where TanggalPesanan between @dt1 and @dt2")
            ' Call CariPesanan("select HargaBeli from order where TanggalPesanan between @dt1 and @dt2")

        End If
        ' menhitung total item yang muncul di datagridview2
        txt_T_item.Text = DataGridView2.RowCount - 1

        'menghitung total penjualan
        Call TotalJualItem()
        Call totaljenisjual()
        Call TotalBeliItem()

    End Sub

    Sub TampilPesanan()

        Try
            Dim masuk As String '
            masuk = "SELECT `NoTransaksi`,`NamaOutlet`, `TanggalPesanan`, `NamaPesanan`, `JenisOrder`,`Banyak`, `Satuan`, `HargaBeli`, `HargaJual`, `Keterangan`,`Refund` FROM `order` WHERE 1"
            Dim adapter As New MySqlDataAdapter
            adapter = New MySqlDataAdapter(masuk, conn)
            Dim dt2 As New DataTable
            adapter.Fill(dt2)
            DataGridView2.DataSource = dt2
            conn.Close()
            'memberi lebar kolom di datagridview1
            DataGridView2.Columns(0).Width = 170
            DataGridView2.Columns(1).Width = 120
            DataGridView2.Columns(2).Width = 125
            DataGridView2.Columns(3).Width = 130
            DataGridView2.Columns(4).Width = 80
            DataGridView2.Columns(5).Width = 60
            DataGridView2.Columns(6).Width = 60
            DataGridView2.Columns(7).Width = 90
            DataGridView2.Columns(8).Width = 90
            DataGridView2.Columns(9).Width = 100
            DataGridView2.Columns(10).Width = 60
        Catch ex As Exception
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub btn_viewall_Click(sender As Object, e As EventArgs) Handles btn_viewall.Click
        Call TampilPesanan()
        ' menhitung total item yang muncul di datagridview2
        txt_T_item.Text = DataGridView2.RowCount - 1

        'menghitung total penjualan
        Call TotalJualItem()
        Call totaljenisjual()
        Call TotalBeliItem()
    End Sub
    Public HBelisatuan As Double
    Public HJualsatuan As Double
    Public TBeli As Double
    Public TJual As Double

    Private Sub txt_satuan_TextChanged(sender As Object, e As EventArgs) Handles txt_satuan.TextChanged

        TBeli = 0
        Try
            Dim query2 As String = "SELECT `HargaSatuan`,`HargaJual` FROM `daftarharga` WHERE NamaBarang='" + txt_namab.Text + "'"
            Dim command2 = New MySqlCommand
            command2 = New MySqlCommand(query2, conn)
            Dim rd As MySqlDataReader
            conn.Open()
            rd = command2.ExecuteReader()

            While rd.Read()
                HBelisatuan = rd.GetValue(0)
                HJualsatuan = rd.GetValue(1)
            End While


        Catch a As Exception
            MessageBox.Show(a.Message)
        Finally
            conn.Close()
        End Try
        'menghitung value dari harga 
        If txt_satuan.Text <> "" Then
            TJual = (HJualsatuan * txt_satuan.Text)
            TBeli = (HBelisatuan * txt_satuan.Text)

            txt_hbeli.Text = String.Copy("RP. " + TBeli.ToString() + ",00")
            txt_hjual.Text = String.Copy("RP. " + TJual.ToString() + ",00")
        Else
            TJual = 0
            TBeli = 0
            txt_hbeli.Text = String.Copy("RP. " + TBeli.ToString() + ",00")
            txt_hjual.Text = String.Copy("RP. " + TJual.ToString() + ",00")
        End If
    End Sub

    Private Sub txt_satuan_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_satuan.MouseClick
        txt_satuan.Text = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time2.Text = Date.Today
        time.Text = Date.Now.ToString("hh:mm")
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        MasterHarga.MdiParent = Homepage
        MasterHarga.Show()
    End Sub

    Private Sub btn_list_Click(sender As Object, e As EventArgs) Handles btn_list.Click
        list.MdiParent = Homepage
        list.Show()
    End Sub
    Sub CariPesanan(ByVal sql As String)

        ' mengisi data pada tabpage2 pesanan
        'mengisi pencarian pada serching combo box
        Dim dm As MySqlCommand
        Dim ds As New DataTable
        Try
            conn.Open()
            dm = New MySqlCommand(sql, conn)
            dm.Parameters.AddWithValue("@dt1", dt_awal.Text)
            dm.Parameters.AddWithValue("@dt2", dt_akhir.Text)
            Dim dp As New MySqlDataAdapter(dm)
            dp.Fill(ds)
            DataGridView2.DataSource = ds
            'memberi lebar kolom di datagridview1
            DataGridView2.Columns(0).Width = 170
            DataGridView2.Columns(1).Width = 120
            DataGridView2.Columns(2).Width = 125
            DataGridView2.Columns(3).Width = 130
            DataGridView2.Columns(4).Width = 80
            DataGridView2.Columns(5).Width = 60
            DataGridView2.Columns(6).Width = 60
            DataGridView2.Columns(7).Width = 90
            DataGridView2.Columns(8).Width = 90
            DataGridView2.Columns(9).Width = 100
            DataGridView2.Columns(10).Width = 60
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
        ' menhitung total item yang muncul di datagridview2
        txt_T_item.Text = DataGridView2.RowCount - 1
    End Sub
    

    Private Sub dt_awal_ValueChanged(sender As Object, e As EventArgs) Handles dt_awal.ValueChanged
        Call CariPesanan(" SELECT `NoTransaksi`,`NamaOutlet`, `TanggalPesanan`, `NamaPesanan`, `JenisOrder`,`Banyak`, `Satuan`, `HargaBeli`, `HargaJual`, `Keterangan`,`Refund` FROM `order` WHERE NamaOutlet Like '%" + txt_SOutlet.Text + "%' AND TanggalPesanan = @dt1")
        
        'menghitung total penjualan
        Call TotalJualItem()
        Call totaljenisjual()
        Call TotalBeliItem()
    End Sub

    Private Sub dt_akhir_ValueChanged(sender As Object, e As EventArgs) Handles dt_akhir.ValueChanged
        Call CariPesanan("SELECT `NoTransaksi`,`NamaOutlet`, `TanggalPesanan`, `NamaPesanan`, `JenisOrder`,`Banyak`, `Satuan`, `HargaBeli`, `HargaJual`, `Keterangan`,`Refund` FROM `order` WHERE NamaOutlet Like '%" + txt_SOutlet.Text + "%' AND TanggalPesanan BETWEEN @dt1 AND @dt2")

        'menghitung total penjualan
        Call TotalJualItem()
        Call totaljenisjual()
        Call TotalBeliItem()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        AboutBox1.MdiParent = Homepage
        AboutBox1.Show()
    End Sub
    Sub openlaporan()

        Try
            Dim o As New Notif_Password ' membuat objek
            Dim query As String = "select * from login where password= @password"
            conn.Open()
            Dim command As New MySqlCommand(query, conn)
            command.Parameters.Add("@password", MySqlDbType.VarChar)
            Dim rd As MySqlDataReader
            rd = command.ExecuteReader
            Dim count As Integer
            count = 0
            While rd.Read
                count = count + 1
            End While
            If count = 1 Then
                MessageBox.Show("Username & Password Anda Benar")
                MasterHarga.Show()
            Else

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btn_Lpenjualan_Click(sender As Object, e As EventArgs) Handles btn_Lpenjualan.Click
        Notif_Password.MdiParent = Homepage
        Notif_Password.Show()

    End Sub

    Private Sub btn_Kedit_Click(sender As Object, e As EventArgs) Handles btn_Kedit.Click
        cb_keterangan.Enabled = True
    End Sub

    Private Sub txt_HSatuan_TextChanged(sender As Object, e As EventArgs) Handles txt_HSatuan.TextChanged
        HBelisatuan = txt_HSatuan.Text
        'menghitung value dari harga 
        If txt_satuan.Text <> "" Then
            TJual = (HJualsatuan * Convert.ToDouble(txt_satuan.Text))
            TBeli = (HBelisatuan * Convert.ToDouble(txt_satuan.Text))
            txt_hbeli.Text = String.Copy("RP. " + TBeli.ToString() + ",00")
            txt_hjual.Text = String.Copy("RP. " + TJual.ToString() + ",00")
        Else

        End If
    End Sub


    Private Sub btn_Lpembelian_Click(sender As Object, e As EventArgs) Handles btn_Lpembelian.Click
        Notif_Password.MdiParent = Homepage
        Notif_Password.Show()
    End Sub

    Private Sub txt_namab_SelectedValueChanged(sender As Object, e As EventArgs) Handles txt_namab.SelectedValueChanged
        HJualsatuan = 0
        Try
            Dim query3 As String = "SELECT * FROM `daftarharga` WHERE `NamaBarang`= '" + txt_namab.Text.ToString() + "'"
            Dim command3 = New MySqlCommand
            command3 = New MySqlCommand(query3, conn)
            Dim rd2 As MySqlDataReader
            conn.Open()
            rd2 = command3.ExecuteReader()

            While rd2.Read()
                ' untuk mencari value di dalm column database
                lb_satuan.Text = rd2.GetValue(4).ToString()
                txt_HSatuan.Text = rd2.GetValue(6)
                HJualsatuan = rd2.GetValue(7)
            End While

        Catch a As Exception
            MessageBox.Show(a.Message)
        Finally
            conn.Close()
        End Try
        lbsatuan1.Text = String.Copy(lb_satuan.Text)

    End Sub

    Private Sub txt_jenisb_TextChanged(sender As Object, e As EventArgs) Handles txt_jenisb.TextChanged
        Try
            Dim query As String = "SELECT `NamaBarang`FROM `daftarharga` WHERE `Jenis`= '" + txt_jenisb.Text.ToString() + "'"
            Dim command = New MySqlCommand
            command = New MySqlCommand(query, conn)
            Dim adapter As MySqlDataAdapter
            adapter = New MySqlDataAdapter
            adapter.SelectCommand = command
            'bind data ke input data ke combobox
            Dim dt5 As New DataTable
            adapter.Fill(dt5)
            txt_namab.DataSource = dt5
            txt_namab.DisplayMember = "NamaBarang"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            ' conn.Close()
        End Try
    End Sub

    Private Sub btn_ekport_Click(sender As Object, e As EventArgs) Handles btn_ekport.Click
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

    Private Sub btn_cari_p_Click_1(sender As Object, e As EventArgs) Handles btn_cari_p.Click
        Call CariPesanan(" SELECT `NoTransaksi`,`NamaOutlet`, `TanggalPesanan`, `NamaPesanan`, `JenisOrder`,`Banyak`, `Satuan`, `HargaBeli`, `HargaJual`, `Keterangan`,`Refund` FROM `order` WHERE NamaOutlet Like '%" + txt_SOutlet.Text + "%'")

        'menghitung total penjualan
        Call TotalJualItem()
        Call totaljenisjual()
        Call TotalBeliItem()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'memanggil value kolom dalam datagridview
        Call isidatagridview(e.RowIndex)
        dt_order.Enabled = True
        dt_beli.Enabled = True
        txt_namab.Enabled = True
        txt_satuan.Enabled = True
        txt_hbeli.Enabled = False
        txt_hjual.Enabled = False
        txt_jenisb.Enabled = True
    End Sub

    Sub datagridview2_info(ByVal x As Integer)
        Try
            st_outlet.Text = DataGridView2.Rows(x).Cells(1).Value
            st_date.Text = DataGridView2.Rows(x).Cells(2).Value
            st_namab.Text = DataGridView2.Rows(x).Cells(4).Value
            st_tItems.Text = DataGridView2.RowCount - 1
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        datagridview2_info(e.RowIndex)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        DaftarOutlet.MdiParent = Homepage
        DaftarOutlet.Show()
    End Sub

    Private Sub btn_belibarang_Click(sender As Object, e As EventArgs) Handles btn_belibarang.Click
        InputBarang.MdiParent = Homepage
        InputBarang.Show()
    End Sub
    Public alamat_outlet As String
    Sub alamat()
        Try
            Dim query2 As String = "SELECT * FROM `outlet` WHERE `NamaOutlet`='" + txt_namaO.Text + "'"
            Dim command2 = New MySqlCommand
            command2 = New MySqlCommand(query2, conn)
            Dim rd As MySqlDataReader
            conn.Open()
            rd = command2.ExecuteReader()

            While rd.Read()
                'mencari nilai di column alamat di table outlet
                alamat_outlet = rd.GetValue(4).ToString()
            End While

        Catch a As Exception
            MessageBox.Show(a.Message)
        Finally
            conn.Close()
        End Try

    End Sub
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        'Try
        '    Dim ds As New DataSet()
        '    Dim ad As New MySqlDataAdapter
        '    Dim query As String = "SELECT `NoTransaksi`, `NamaOutlet`, `TanggalPesanan`, `NamaPesanan`, `JenisOrder`,`Banyak`, `Satuan`,`HargaJualS`,`HargaJual`,`Keterangan`,`Refund` FROM `order` WHERE `NamaOutlet` like '%" + txt_namaO.Text + "%' AND `TanggalPesanan`='" + dt_order.Text + "' ORDER BY TanggalPesanan ASC"
        '    conn.Open()
        '    ad.SelectCommand = New MySqlCommand(query, conn)
        '    ad.Fill(ds)
        '    ds.WriteXml(CurDir() & "/Transaksi.xml", XmlWriteMode.WriteSchema) ' create xml file dari dataset

        '    TransaksiReport.CrystalReportViewer2.RefreshReport()

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error")

        'End Try
        Call alamat()
        LaporanTransaksi.CrystalReportViewer1.SelectionFormula = "Totext({order1.NamaOutlet}) ='" + txt_namaO.Text + "' And Totext({order1.TanggalPesanan}) ='" + dt_order.Text + "'"
        LaporanTransaksi.CrystalReportViewer1.SelectionFormula = "Totext({order1.Alamat}) ='" + alamat_outlet + "'"
        LaporanTransaksi.CrystalReportViewer1.ReportSource = "ReportHarian.rpt"
        LaporanTransaksi.CrystalReportViewer1.RefreshReport()
        LaporanTransaksi.MdiParent = Homepage
        LaporanTransaksi.Show()
        

    End Sub
    Sub g()
      

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
                DataGridView2.DataSource = dts
                DataGridView2.DataMember = "[Sheet2$]"
                konek.Close()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

        End Try

    End Sub

    Private Sub savedb_Click(sender As Object, e As EventArgs) Handles savedb.Click
        Try
            ' memasukan data ke database mysql dari datagridview
            Dim cmd As MySqlCommand
            Dim import As String
            For i As Integer = 0 To DataGridView2.Rows.Count - 2
                conn.Open() '`NoTransaksi`,`NamaOutlet`, `TanggalPesanan`, `NamaPesanan`, `JenisOrder`,`Banyak`, `Satuan`, `HargaBeli`, `HargaJual`, `Keterangan`,`Refund` 
                import = "INSERT INTO `order`(`NoTransaksi`, `NamaOutlet`, `TanggalPesanan`,`NamaPesanan`, `JenisOrder`, `Banyak`, `Satuan`, `HargaBeli`, `HargaJual`,`Keterangan`, `Refund`) VALUES (@no,@namao,@dt_date,@nama,@jenis,@item,@satuan,@hargab,@hargaj,@ket,@refund)"
                cmd = New MySqlCommand(import, conn)
                cmd.Parameters.Add("@no", MySqlDbType.VarChar).Value = DataGridView2.Rows(i).Cells(0).Value.ToString()
                cmd.Parameters.Add("@namao", MySqlDbType.VarChar).Value = DataGridView2.Rows(i).Cells(1).Value.ToString()
                cmd.Parameters.Add("@dt_date", MySqlDbType.VarChar).Value = DataGridView2.Rows(i).Cells(2).Value.ToString()
                cmd.Parameters.Add("@nama", MySqlDbType.VarChar).Value = DataGridView2.Rows(i).Cells(3).Value.ToString()
                cmd.Parameters.Add("@jenis", MySqlDbType.VarChar).Value = DataGridView2.Rows(i).Cells(4).Value.ToString()
                cmd.Parameters.Add("@item", MySqlDbType.VarChar).Value = DataGridView2.Rows(i).Cells(5).Value.ToString()
                cmd.Parameters.Add("@satuan", MySqlDbType.VarChar).Value = DataGridView2.Rows(i).Cells(6).Value.ToString()
                cmd.Parameters.Add("@hargab", MySqlDbType.Double).Value = DataGridView2.Rows(i).Cells(7).Value.ToString()
                cmd.Parameters.Add("@hargaj", MySqlDbType.Double).Value = DataGridView2.Rows(i).Cells(8).Value.ToString()
                cmd.Parameters.Add("@ket", MySqlDbType.VarChar).Value = DataGridView2.Rows(i).Cells(9).Value.ToString()
                cmd.Parameters.Add("@refund", MySqlDbType.VarChar).Value = DataGridView2.Rows(i).Cells(10).Value.ToString()
                cmd.ExecuteNonQuery()
                conn.Close()
            Next

            'menampilkan isi table laporankeuangan
            MessageBox.Show("Data Berhasil disimpan")
            Call TampilPesanan()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

  
    Private Sub n_refund_TextChanged(sender As Object, e As EventArgs) Handles n_refund.TextChanged
        Call Keterangan()
    End Sub
End Class