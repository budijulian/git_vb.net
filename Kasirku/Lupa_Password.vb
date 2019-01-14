Imports MySql.Data.MySqlClient
Public Class Lupa_Password
    Public conn As New MySqlConnection("server=localhost;database=db_kasir;username=root;password=;")

    Private Sub btn_lihat_Click(sender As Object, e As EventArgs) Handles btn_lihat.Click

        Try
            conn.Open()
            Dim query As String = "select * from login where unsername= @unsername and email=@email"
            Dim command As New MySqlCommand(query, conn)

            command.Parameters.Add("@unsername", MySqlDbType.VarChar).Value = txt_username.Text
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = txt_email.Text
            Dim rd As MySqlDataReader
            rd = command.ExecuteReader
            Dim count As Integer
            count = 0
            While rd.Read
                count = count + 1
            End While
            If count = 1 Then
                conn.Close()
                Call Password()
            Else
                notif_password.Visible = True
                notif_ket.Visible = False
                txt_password.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Lupa_Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_password.Enabled = False
        notif_password.Visible = False
        notif_ket.Visible = False
    End Sub
    Private Sub Password()
        Try

            Dim qr As String = "SELECT * FROM login WHERE unsername='" + txt_username.Text + "' AND email='" + txt_email.Text + "'"
            Dim cm = New MySqlCommand
            cm = New MySqlCommand(qr, conn)
            Dim rd As MySqlDataReader
            conn.Open()
            rd = cm.ExecuteReader()
            While rd.Read()
                txt_password.Text = rd.GetValue(1).ToString()
            End While

        Catch a As Exception
            MessageBox.Show(a.Message)
        Finally
            conn.Close()
        End Try
        notif_password.Visible = False
        notif_ket.Visible = True
    End Sub
End Class