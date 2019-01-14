Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Profile
    Public conn As New MySqlConnection
    
    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ConnectionString = "server=localhost;database=db_kasir;username=root;password=;"
        conn = New MySqlConnection("server=localhost;database=db_kasir;username=root;password=;")

        Call tampil()
        'menyembunyikan notif password
        notif_pass.Visible = False
        notif_pass_lama.Visible = False
        pf_nama.Enabled = False
        pf_perusahaan.Enabled = False
        pf_telepon.Enabled = False
        pf_email.Enabled = False
        pf_alamat.Enabled = False
        txt_passwordL.Focus()

    End Sub
    Public nama As String
    Public password As String
    Sub tampil()
        Try
            ' mengambil value dari username form login
            nama = Form1.st_nama.Text

            Dim query2 As String = "SELECT * FROM login WHERE unsername='" + nama + "'"
            Dim command2 = New MySqlCommand
            command2 = New MySqlCommand(query2, conn)
            Dim rd As MySqlDataReader
            conn.Open()
            rd = command2.ExecuteReader()

            While rd.Read()
                password = rd.GetValue(1).ToString()
                pf_nama.Text = rd.GetValue(2).ToString()
                pf_perusahaan.Text = rd.GetValue(3).ToString()
                pf_telepon.Text = rd.GetValue(5).ToString()
                pf_email.Text = rd.GetValue(6).ToString()
                pf_alamat.Text = rd.GetValue(4).ToString()
            End While

        Catch a As Exception
            MessageBox.Show(a.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Close()
        txt_Kpassword.Clear()
        txt_passwordB.Clear()
        txt_passwordL.Clear()
    End Sub

    'Sub notif_password()
    '    Try
    '        Dim query As String = "select * from login where password= @password"
    '        Dim command As New MySqlCommand(query, conn)
    '        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = txt_passwordL.Text
    '        Dim rd As MySqlDataReader
    '        rd = command.ExecuteReader
    '        conn.Open()
    '        Dim count As Integer
    '        count = 0
    '        While rd.Read
    '            count = count + 1
    '        End While
    '        If count = 1 Then

    '        Else

    '        End If

    '    Catch ex As MySqlException
    '        MessageBox.Show(ex.Message)
    '    Finally
    '        conn.Close()
    '    End Try
    'End Sub

    Private Sub lb_show_Click(sender As Object, e As EventArgs) Handles lb_show.Click

        If txt_passwordL.UseSystemPasswordChar = True Then
            txt_passwordL.UseSystemPasswordChar = False
            txt_passwordB.UseSystemPasswordChar = False
            txt_Kpassword.UseSystemPasswordChar = False
            lb_show.Text = "Hide"
        Else
            txt_passwordL.UseSystemPasswordChar = True
            txt_passwordB.UseSystemPasswordChar = True
            txt_Kpassword.UseSystemPasswordChar = True
            lb_show.Text = "Show"
        End If
    End Sub
    Sub notif_passwordbaru()
        If String.Equals(txt_passwordB, txt_Kpassword.Text) Then
            notif_pass.Visible = True
        Else
            notif_pass.Visible = False
        End If
    End Sub


    Private Sub txt_Kpassword_TabIndexChanged(sender As Object, e As EventArgs) Handles txt_Kpassword.TabIndexChanged
        notif_passwordbaru()
    End Sub

    Private Sub txt_Kpassword_MouseLeave(sender As Object, e As EventArgs) Handles txt_Kpassword.MouseLeave
        notif_passwordbaru()
    End Sub

    Private Sub pfps_Save_Click(sender As Object, e As EventArgs) Handles pfps_Save.Click

        If txt_passwordL.Text <> "" And txt_Kpassword.Text <> "" And txt_passwordB.Text <> "" Then
            'string.equals berguna untuk mengetahui password benar atau tidak di database
            If String.Equals(txt_passwordL.Text, password) Then
                Dim pesan As MsgBoxResult
                pesan = MsgBox("Apakah Anda Yakin Mengubah Password", MsgBoxStyle.YesNo, " Password Berhasil diubah")
                If pesan = MsgBoxResult.Yes Then
                    If String.Equals(txt_passwordB.Text, txt_Kpassword.Text) = True Then
                        Try
                            notif_pass.Visible = False
                            Dim cd = New MySqlCommand
                            cd = conn.CreateCommand
                            conn.Open()
                            cd.CommandText = "update login set password=@passwordB where password=@passwordL"
                            cd.Parameters.AddWithValue("@passwordB", txt_passwordB.Text)
                            cd.Parameters.AddWithValue("@passwordL", txt_passwordL.Text)
                            cd.ExecuteNonQuery()
                            conn.Close()
                            Call tampil()
                            txt_Kpassword.Text = ""
                            txt_passwordB.Text = ""
                            txt_passwordL.Text = ""
                            MessageBox.Show("Password telah diganti")
                        Catch ex As Exception

                        End Try
                    Else
                        notif_pass.Visible = True
                    End If
                Else
                End If
            Else
                notif_pass_lama.Visible = True
            End If
        Else
        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

        Try
            Dim cd = New MySqlCommand
            cd = conn.CreateCommand
            cd.CommandText = "update login set `nama`=@nama,`perusahaan`=@perusahaan,`alamat`=@alamat,`telepon`=@telepon,`email`=@email where `unsername`='" + FormLogin.txt_unsername.Text + "'"
            conn.Open()
            cd.Parameters.AddWithValue("@nama", pf_nama.Text)
            cd.Parameters.AddWithValue("@perusahaan", pf_perusahaan.Text)
            cd.Parameters.AddWithValue("@alamat", pf_alamat.Text)
            cd.Parameters.AddWithValue("@telepon", pf_telepon.Text)
            cd.Parameters.AddWithValue("@email", pf_email.Text)
            cd.ExecuteNonQuery()
            MessageBox.Show("Profile Berhasil diganti")
        Catch
        Finally
            conn.Close()
        End Try

        pf_nama.Enabled = True
        pf_perusahaan.Enabled = True
        pf_telepon.Enabled = True
        pf_email.Enabled = True
        pf_alamat.Enabled = True
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class