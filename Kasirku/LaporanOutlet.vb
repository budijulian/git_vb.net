Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Public Class LaporanOutlet

    Public conn As MySqlConnection
    ' Public ConnectionString As String = "server=localhost;database=db_kasir;username=root;password=;"
    Private Sub LaporanOutlet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrystalReportViewer1.RefreshReport()
        ' mmeberi value pada combobox
        
        conn = New MySqlConnection("server=localhost;database=db_kasir;username=root;password=;")
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

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cb_outlet.Text <> "" Then ' "Totext({order1.NamaOutlet}) ='" + txt_namaO.Text + "'
            CrystalReportViewer1.SelectionFormula = "{laporankeuangan1.TanggalPesanan} in ('" & dt_awal.Text & "') to ('" & dt_akhir.Text & "') and Totext({laporankeuangan1.NamaOutlet})='" + cb_outlet.Text + "'"
            CrystalReportViewer1.ReportSource = "Laporan Keuangan.rpt"
            CrystalReportViewer1.RefreshReport()
        Else
            CrystalReportViewer1.SelectionFormula = "{laporankeuangan1.TanggalPesanan} in ('" & dt_awal.Text & "') to ('" & dt_akhir.Text & "')"
            CrystalReportViewer1.ReportSource = "Laporan Keuangan.rpt"
            CrystalReportViewer1.RefreshReport()
        End If

      
    End Sub

End Class