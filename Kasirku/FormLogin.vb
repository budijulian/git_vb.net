Imports MySql.Data.MySqlClient
Public Class FormLogin

    Private Sub RectangleShape2_Click(sender As Object, e As EventArgs)

    End Sub
    Public conn As New MySqlConnection("server=localhost;database=db_kasir;username=root;password=;")

    Public unsername As String
    Public password As String
    Sub Login()
        Try
            'membuka koneksi
            conn.Open()
            Dim query As String = "select * from login where unsername= @unsername and password= @password"
            Dim command As New MySqlCommand(query, conn)
            'mengunakan inputan paramerter mysqlcommand yang memiliki bertipe data 
            command.Parameters.Add("@unsername", MySqlDbType.VarChar).Value = txt_unsername.Text
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = txt_password.Text
            Dim rd As MySqlDataReader
            rd = command.ExecuteReader
            Dim count As Integer
            count = 0
            While rd.Read
                count = count + 1
            End While
            If count = 1 Then
                MessageBox.Show("Username & Password Anda Benar", "Information" & MessageBoxIcon.Information)
                'memberi value pada nama admin
                Form1.st_nama.Text = txt_unsername.Text
                Dim open As New Form1
                open.MdiParent = Homepage
                open.Show()
                Me.Hide()
            Else
                notif_unser.Visible = True
            End If
            conn.Close()
            unsername = txt_unsername.Text
            password = txt_password.Text

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            Call Login()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Public ConnectionString As String = "server=localhost;database=db_kasir;username=root;password=;"
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        notif_unser.Visible = False

        txt_password.PasswordChar = "*" ' memberi sejenis kode * setiap text yang masukan
        txt_password.MaxLength = 12 ' membatasi text di sepanjang 8 karakter
        Timer1.Enabled = True

        'menjalankan timer2 
        Timer2.Start()
        Timer2.Interval = 100
        n = 1 ' memberi nilai n =1 
        'memberi value pada text di form
        Dim text2 As String = " Created by : Budi Julian"
        Dim text As String = "Selamat Datang di Aplikasi Kasir,Mohon Anda Login terlebih dahulu.Terima Kasih. " + text2
        textwelcome.Text = text


    End Sub


    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        If txt_password.UseSystemPasswordChar = True Then
            txt_password.UseSystemPasswordChar = False
            Label6.Text = "Show Password"
        Else
            txt_password.UseSystemPasswordChar = True

            Label6.Text = "Hide Password"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Lupa_Password.MdiParent = Homepage
        Lupa_Password.Show()
        Me.Show()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'menampilkan tanggal sekarang berdasarkan format
        time.Text = Date.Now.ToString("hh:mm:ss")
        Label7.Text = Date.Now.ToString("dd-MM-yyyy")
    End Sub

    
    Private Sub btn_close_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Dim n As Integer
    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer2.Tick
        'berfungsi untuk mengerakan text dari kiri kekanan 
        'text bergerak

        'textwelcome.Left = textwelcome.Left + n
        'If textwelcome.Left < 0 Or textwelcome.Left > Me.Width Then
        '    n = n * -1
        'End If
        If (textwelcome.Left + textwelcome.Width <= 0) Then
            textwelcome.Left = Me.Width
        Else
            textwelcome.Left = textwelcome.Left - 5

        End If

    End Sub
End Class