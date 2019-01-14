Imports MySql.Data.MySqlClient
Public Class list
    Public conn As New MySqlConnection
    Public dm As New MySqlCommand
    ' Public ConnectionString As String
    Private Sub list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'ConnectionString = "server=localhost;database=db_kasir;username=root;password=;"
            conn = New MySqlConnection("server=localhost;database=db_kasir;username=root;password=;")
            conn.Open()
            Dim masuk As String
            masuk = "SELECT `Kode`, `TanggalBeli`, `Jenis`, `NamaBarang`, `Satuan`, `Banyak`, `HargaSatuan`, `HargaJual` FROM `daftarharga` WHERE 1"
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
        MasterHarga.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class