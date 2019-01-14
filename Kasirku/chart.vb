Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Public Class grafik

    Private conn As New MySqlConnection
    Private database As String = "db_kasir"
    Private server As String = "localhost"
    Private username As String = "root"
    Private pass As String = ""
    Private connstring = String.Format("server={0};database={1};username={2};password={3};", server, database, username, pass)
    Private adp As New MySqlDataAdapter
    Private ds As New DataTable
    Private cm As New MySqlCommand

    Private Sub konek()
        If Not conn Is Nothing Then conn.Close()

        Try
            conn.ConnectionString = connstring
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub grafik(ByRef query As String, ByRef keterangan As String)
        konek()
        adp = New MySqlDataAdapter(query, conn)
        Dim dataset As New DataSet()

        adp.Fill(dataset, "order")
        Dim chartarea1 As ChartArea = New ChartArea()
        Dim legend1 As Legend = New Legend()
        Dim series1 As Series = New Series()
        Dim series2 As Series = New Series()
        Dim Chart1 = New Chart()
        Me.Controls.Add(Chart1)

        chartarea1.Name = "ChartArea1"
        Chart1.ChartAreas.Add(chartarea1)
        legend1.Name = "Legend1"

        Chart1.Legends.Add(legend1)
        Chart1.Location = New System.Drawing.Point(15, 60) ' atur posisi chart
        Chart1.Name = "Chart1"

        series1.ChartArea = "ChartArea1"
        series1.Legend = "Legend1"
        series1.Name = keterangan  ' memberi keterangan di chart

        Chart1.Series.Add(series1)
        Chart1.Size = New System.Drawing.Size(1050, 500)
        Chart1.TabIndex = 0
        Chart1.Text = "Chart1"
        Chart1.Series(keterangan).XValueMember = "TanggalPesanan" ' content horizontal
        Chart1.Series(keterangan).YValueMembers = "Keuntungan"   ' content vertikalhorizontal

        Chart1.DataSource = dataset.Tables("order")

    End Sub
    Private Sub chart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Chart1.Visible = False

        'mengambil value di class laporan
        Label3.Text = Laporan.DateTimePicker4.Text 'menerima nilai dari form lain
        Label5.Text = Laporan.DateTimePicker5.Text  'menerima nilai dari form lain
        st_namao.Text = Laporan.cb_outlet.Text   'menerima nilai dari form lain
        If st_namao.Text = "" Then
            st_namao.Text = "Semua Outlet"
            grafik("SELECT * FROM `laporankeuangan` WHERE `TanggalPesanan` BETWEEN '" + Label3.Text + "' AND '" + Label5.Text + "' ORDER BY TanggalPesanan ASC", "Semua Outlet")
        Else
            grafik("SELECT * FROM `laporankeuangan` WHERE `NamaOutlet` LIKE '%" + st_namao.Text + "%' AND `TanggalPesanan` BETWEEN '" + Label3.Text + "' AND '" + Label5.Text + "' ORDER BY TanggalPesanan ASC", st_namao.Text)

        End If
       
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

   
End Class