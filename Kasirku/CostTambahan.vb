Public Class CostTambahan
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
        ListView1.Items.Clear()
        txt_total.Text = ""
        txt_banyak.Text = ""
        txt_biaya.Text = ""
        'menghapus nilai  di stack
        st.Clear()
        tumpukan = ""
    End Sub

    Private Sub CostTambahan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.Columns.Add("No", 50)
        ListView1.Columns.Add("Jenis Pengeluaran", 120)
        ListView1.Columns.Add("Biaya", 200)

        cb_jenis.Items.Add("Transportasi")
        cb_jenis.Items.Add("Bensin")
        cb_jenis.Items.Add("Makan")
        cb_jenis.Items.Add("Gaji Karyawan")
        cb_jenis.Items.Add("Others")
    End Sub
    Public st As Stack = New Stack() ' deklarasi STACK
    Public tumpukan As String
    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        Try
            Dim tampil As ListViewItem
            tampil = New ListViewItem

            ' menampilkan isi di listview
            tampil = ListView1.Items.Add(ListView1.Items.Count + 1)
            tampil.SubItems.Add(cb_jenis.Text)
            tampil.SubItems.Add(txt_biaya.Text)
            'mencari nilai total dari value txt_biaya.text
            Dim total As Double
            For x As Integer = 0 To ListView1.Items.Count - 1
                total = total + ListView1.Items(x).SubItems(2).Text
            Next
            txt_total.Text = total
            txt_banyak.Text = ListView1.Items.Count

            'menampung data dengan fungsi STACK
            'st merupakan objek dari stack
            st.Push(cb_jenis.Text + ": " + txt_biaya.Text) ' input tumpukan

            'setiap inputan dari jenis dan biaya disimpan STACK 
            'Stack akan menkopi value ke variabel tumpukan 
            tumpukan = st.Pop() & " " & tumpukan
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        ' mengirim nilai dari tumpukan untuk disimpan ke varibel ketbiayatambahan di form daftar outlet.
        ' disimpan ke dalam database
        DaftarOutlet.ketbiayatambahan = tumpukan
        
        ' mengirim nilai total ke form daftar outlet
        DaftarOutlet.txt_pengeluaranT.Text = txt_total.Text

        Call untung()
    End Sub
    Sub untung()
        Dim totaljual, totalbeli, untung As Double
        totaljual = DaftarOutlet.txt_Tjual.Text
        totalbeli = DaftarOutlet.txt_Tbeli.Text
        untung = Val(totaljual) - (Val(totalbeli) + Val(txt_total.Text))
        DaftarOutlet.txt_untung.Text = untung
    End Sub
    Private Sub btn_bersih_Click(sender As Object, e As EventArgs) Handles btn_bersih.Click
        Try
            ListView1.Items.Clear()
            txt_total.Text = ""
            txt_banyak.Text = ""
            txt_biaya.Text = ""
            'menghapus nilai  di stack
            st.Clear()
            tumpukan = ""
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txt_total_TextChanged(sender As Object, e As EventArgs) Handles txt_total.TextChanged

    End Sub
End Class