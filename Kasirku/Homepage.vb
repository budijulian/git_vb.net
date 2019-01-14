Public Class Homepage

    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormLogin.MdiParent = Me
        FormLogin.Show()
        Me.Show()
    End Sub

 
    Private Sub LOGINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles lupapassToolStripMenuItem.Click
        Lupa_Password.MdiParent = Me
        Lupa_Password.Show()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Dim pesan As MsgBoxResult
        pesan = MsgBox("Apakah Anda yakin Logout", MsgBoxStyle.YesNo, "Logout")
        If pesan = MsgBoxResult.Yes Then
            Me.Close()
            FormLogin.MdiParent = Me
            FormLogin.Show()
        Else
        End If
    End Sub

    Private Sub EXIITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXIITToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        AboutBox1.MdiParent = Me
        AboutBox1.Show()
        Me.Show()
    End Sub
End Class