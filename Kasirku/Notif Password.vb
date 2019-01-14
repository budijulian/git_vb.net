Imports MySql.Data.MySqlClient
Public Class Notif_Password

    Private Sub btn_password_Click(sender As Object, e As EventArgs) Handles btn_password.Click
        loginpassword()
    End Sub
    Public conn As MySqlConnection
    ' Public ConnectionString As String
    Private Sub Notif_Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_password.MaxLength = 12
        txt_password.UseSystemPasswordChar = True
        ' ConnectionString = "server=localhost;database=db_kasir;username=root;password=;"
        conn = New MySqlConnection("server=localhost;database=db_kasir;username=root;password=;")
       
    End Sub

    Sub loginpassword()
        Try
            Dim o As New Notif_Password ' membuat objek
            Dim query As String = "select * from login where password= @password"
            conn.Open()
            Dim command As New MySqlCommand(query, conn)
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = txt_password.Text
            Dim rd As MySqlDataReader
            rd = command.ExecuteReader
            Dim count As Integer
            count = 0
            While rd.Read
                'hanya sebagai nilai untuk konfimasi perintah lain
                'jika program benar akan diberi nilai 1
                count = count + 1
            End While
            If count = 1 Then
                MessageBox.Show("Username & Password Anda Benar")
                Me.Close()
                Laporan.MdiParent = Homepage
                Laporan.Show()
            Else
                MessageBox.Show("Username & Password Anda Salah")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub txt_password_DragEnter(sender As Object, e As DragEventArgs) Handles txt_password.DragEnter
        loginpassword()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
End Class