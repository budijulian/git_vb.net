<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lupa_Password
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lupa_Password))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_lihat = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.notif_password = New System.Windows.Forms.Label()
        Me.notif_ket = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(233, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_lihat
        '
        Me.btn_lihat.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_lihat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_lihat.Location = New System.Drawing.Point(143, 181)
        Me.btn_lihat.Name = "btn_lihat"
        Me.btn_lihat.Size = New System.Drawing.Size(75, 35)
        Me.btn_lihat.TabIndex = 13
        Me.btn_lihat.Text = "Lihat"
        Me.btn_lihat.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "LUPA PASSWORD !"
        '
        'notif_password
        '
        Me.notif_password.AutoSize = True
        Me.notif_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notif_password.Location = New System.Drawing.Point(29, 152)
        Me.notif_password.Name = "notif_password"
        Me.notif_password.Size = New System.Drawing.Size(166, 13)
        Me.notif_password.TabIndex = 7
        Me.notif_password.Text = "*unsername dan email anda salah"
        '
        'notif_ket
        '
        Me.notif_ket.AutoSize = True
        Me.notif_ket.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notif_ket.Location = New System.Drawing.Point(29, 152)
        Me.notif_ket.Name = "notif_ket"
        Me.notif_ket.Size = New System.Drawing.Size(171, 13)
        Me.notif_ket.TabIndex = 8
        Me.notif_ket.Text = "*unsername dan email anda bernar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(30, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(29, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Email"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(29, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 18)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Username"
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.txt_email.Location = New System.Drawing.Point(109, 99)
        Me.txt_email.Multiline = True
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(109, 50)
        Me.txt_email.TabIndex = 12
        '
        'txt_password
        '
        Me.txt_password.BackColor = System.Drawing.Color.Yellow
        Me.txt_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.ForeColor = System.Drawing.Color.Black
        Me.txt_password.Location = New System.Drawing.Point(109, 231)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(109, 22)
        Me.txt_password.TabIndex = 14
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.txt_username.Location = New System.Drawing.Point(109, 70)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(109, 23)
        Me.txt_username.TabIndex = 5
        '
        'Lupa_Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(258, 297)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_lihat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.notif_password)
        Me.Controls.Add(Me.notif_ket)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(258, 297)
        Me.MinimumSize = New System.Drawing.Size(258, 297)
        Me.Name = "Lupa_Password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Lupa_Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_lihat As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents notif_password As System.Windows.Forms.Label
    Friend WithEvents notif_ket As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
End Class
