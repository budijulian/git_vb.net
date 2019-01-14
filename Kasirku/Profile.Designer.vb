<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Profile))
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pf_alamat = New System.Windows.Forms.TextBox()
        Me.pf_email = New System.Windows.Forms.TextBox()
        Me.pf_telepon = New System.Windows.Forms.TextBox()
        Me.pf_perusahaan = New System.Windows.Forms.TextBox()
        Me.pf_nama = New System.Windows.Forms.TextBox()
        Me.txt_Lfoto = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.notif_pass_lama = New System.Windows.Forms.Label()
        Me.lb_show = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.notif_pass = New System.Windows.Forms.Label()
        Me.pfps_Save = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Kpassword = New System.Windows.Forms.TextBox()
        Me.txt_passwordB = New System.Windows.Forms.TextBox()
        Me.txt_passwordL = New System.Windows.Forms.TextBox()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightGreen
        Me.TabPage1.Controls.Add(Me.btn_edit)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.pf_alamat)
        Me.TabPage1.Controls.Add(Me.pf_email)
        Me.TabPage1.Controls.Add(Me.pf_telepon)
        Me.TabPage1.Controls.Add(Me.pf_perusahaan)
        Me.TabPage1.Controls.Add(Me.pf_nama)
        Me.TabPage1.Controls.Add(Me.txt_Lfoto)
        Me.TabPage1.Location = New System.Drawing.Point(23, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(348, 361)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "New Profile"
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.LightGreen
        Me.btn_edit.Location = New System.Drawing.Point(94, 301)
        Me.btn_edit.MaximumSize = New System.Drawing.Size(58, 31)
        Me.btn_edit.MinimumSize = New System.Drawing.Size(58, 31)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(58, 31)
        Me.btn_edit.TabIndex = 18
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Email "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Telepon"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Perusahaan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(149, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 16)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Profile"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nama"
        '
        'pf_alamat
        '
        Me.pf_alamat.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.pf_alamat.Location = New System.Drawing.Point(94, 212)
        Me.pf_alamat.Multiline = True
        Me.pf_alamat.Name = "pf_alamat"
        Me.pf_alamat.Size = New System.Drawing.Size(232, 81)
        Me.pf_alamat.TabIndex = 17
        '
        'pf_email
        '
        Me.pf_email.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.pf_email.Location = New System.Drawing.Point(94, 177)
        Me.pf_email.Name = "pf_email"
        Me.pf_email.Size = New System.Drawing.Size(232, 20)
        Me.pf_email.TabIndex = 16
        '
        'pf_telepon
        '
        Me.pf_telepon.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.pf_telepon.Location = New System.Drawing.Point(94, 138)
        Me.pf_telepon.Name = "pf_telepon"
        Me.pf_telepon.Size = New System.Drawing.Size(232, 20)
        Me.pf_telepon.TabIndex = 15
        '
        'pf_perusahaan
        '
        Me.pf_perusahaan.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.pf_perusahaan.Location = New System.Drawing.Point(94, 99)
        Me.pf_perusahaan.Name = "pf_perusahaan"
        Me.pf_perusahaan.Size = New System.Drawing.Size(232, 20)
        Me.pf_perusahaan.TabIndex = 8
        '
        'pf_nama
        '
        Me.pf_nama.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.pf_nama.Location = New System.Drawing.Point(94, 58)
        Me.pf_nama.Name = "pf_nama"
        Me.pf_nama.Size = New System.Drawing.Size(232, 20)
        Me.pf_nama.TabIndex = 7
        '
        'txt_Lfoto
        '
        Me.txt_Lfoto.AutoSize = True
        Me.txt_Lfoto.Location = New System.Drawing.Point(3, 345)
        Me.txt_Lfoto.Name = "txt_Lfoto"
        Me.txt_Lfoto.Size = New System.Drawing.Size(39, 13)
        Me.txt_Lfoto.TabIndex = 5
        Me.txt_Lfoto.Text = "*admin"
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = True
        Me.TabControl1.Size = New System.Drawing.Size(375, 369)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightGreen
        Me.TabPage2.Controls.Add(Me.notif_pass_lama)
        Me.TabPage2.Controls.Add(Me.lb_show)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.notif_pass)
        Me.TabPage2.Controls.Add(Me.pfps_Save)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txt_Kpassword)
        Me.TabPage2.Controls.Add(Me.txt_passwordB)
        Me.TabPage2.Controls.Add(Me.txt_passwordL)
        Me.TabPage2.Location = New System.Drawing.Point(23, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(348, 361)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Password"
        '
        'notif_pass_lama
        '
        Me.notif_pass_lama.AutoSize = True
        Me.notif_pass_lama.ForeColor = System.Drawing.Color.Red
        Me.notif_pass_lama.Location = New System.Drawing.Point(119, 86)
        Me.notif_pass_lama.Name = "notif_pass_lama"
        Me.notif_pass_lama.Size = New System.Drawing.Size(142, 13)
        Me.notif_pass_lama.TabIndex = 20
        Me.notif_pass_lama.Text = "*password anda tidak cocok"
        '
        'lb_show
        '
        Me.lb_show.AutoSize = True
        Me.lb_show.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lb_show.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_show.ForeColor = System.Drawing.Color.Black
        Me.lb_show.Location = New System.Drawing.Point(267, 64)
        Me.lb_show.Name = "lb_show"
        Me.lb_show.Size = New System.Drawing.Size(34, 13)
        Me.lb_show.TabIndex = 12
        Me.lb_show.Text = "Show"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(119, 85)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 13)
        Me.Label12.TabIndex = 18
        '
        'notif_pass
        '
        Me.notif_pass.AutoSize = True
        Me.notif_pass.ForeColor = System.Drawing.Color.Red
        Me.notif_pass.Location = New System.Drawing.Point(119, 138)
        Me.notif_pass.Name = "notif_pass"
        Me.notif_pass.Size = New System.Drawing.Size(142, 13)
        Me.notif_pass.TabIndex = 19
        Me.notif_pass.Text = "*password anda tidak cocok"
        '
        'pfps_Save
        '
        Me.pfps_Save.BackColor = System.Drawing.Color.LightGreen
        Me.pfps_Save.Location = New System.Drawing.Point(157, 197)
        Me.pfps_Save.Name = "pfps_Save"
        Me.pfps_Save.Size = New System.Drawing.Size(67, 26)
        Me.pfps_Save.TabIndex = 13
        Me.pfps_Save.Text = "Edit"
        Me.pfps_Save.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Konfirm Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Password baru"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(106, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Ganti Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Password lama"
        '
        'txt_Kpassword
        '
        Me.txt_Kpassword.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txt_Kpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Kpassword.Location = New System.Drawing.Point(120, 160)
        Me.txt_Kpassword.MaxLength = 12
        Me.txt_Kpassword.Name = "txt_Kpassword"
        Me.txt_Kpassword.Size = New System.Drawing.Size(141, 21)
        Me.txt_Kpassword.TabIndex = 11
        Me.txt_Kpassword.UseSystemPasswordChar = True
        '
        'txt_passwordB
        '
        Me.txt_passwordB.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txt_passwordB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_passwordB.Location = New System.Drawing.Point(120, 111)
        Me.txt_passwordB.MaxLength = 12
        Me.txt_passwordB.Name = "txt_passwordB"
        Me.txt_passwordB.Size = New System.Drawing.Size(141, 21)
        Me.txt_passwordB.TabIndex = 10
        Me.txt_passwordB.UseSystemPasswordChar = True
        '
        'txt_passwordL
        '
        Me.txt_passwordL.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txt_passwordL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_passwordL.Location = New System.Drawing.Point(120, 61)
        Me.txt_passwordL.MaxLength = 12
        Me.txt_passwordL.Name = "txt_passwordL"
        Me.txt_passwordL.Size = New System.Drawing.Size(141, 21)
        Me.txt_passwordL.TabIndex = 9
        Me.txt_passwordL.UseSystemPasswordChar = True
        '
        'Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(375, 369)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(391, 403)
        Me.MinimumSize = New System.Drawing.Size(391, 403)
        Me.Name = "Profile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dashboard Kasir  - Profile"
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txt_Lfoto As System.Windows.Forms.Label
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pf_alamat As System.Windows.Forms.TextBox
    Friend WithEvents pf_email As System.Windows.Forms.TextBox
    Friend WithEvents pf_telepon As System.Windows.Forms.TextBox
    Friend WithEvents pf_perusahaan As System.Windows.Forms.TextBox
    Friend WithEvents pf_nama As System.Windows.Forms.TextBox
    Friend WithEvents lb_show As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents notif_pass As System.Windows.Forms.Label
    Friend WithEvents pfps_Save As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_Kpassword As System.Windows.Forms.TextBox
    Friend WithEvents txt_passwordB As System.Windows.Forms.TextBox
    Friend WithEvents txt_passwordL As System.Windows.Forms.TextBox
    Friend WithEvents notif_pass_lama As System.Windows.Forms.Label
End Class
