<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CostTambahan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CostTambahan))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_bersih = New System.Windows.Forms.Button()
        Me.txt_banyak = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_biaya = New System.Windows.Forms.TextBox()
        Me.cb_jenis = New System.Windows.Forms.ComboBox()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btn_bersih)
        Me.GroupBox1.Controls.Add(Me.txt_banyak)
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_total)
        Me.GroupBox1.Controls.Add(Me.txt_biaya)
        Me.GroupBox1.Controls.Add(Me.cb_jenis)
        Me.GroupBox1.Controls.Add(Me.btn_tambah)
        Me.GroupBox1.Controls.Add(Me.btn_simpan)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(375, 442)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(112, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 24)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Biaya Tambahan"
        '
        'btn_bersih
        '
        Me.btn_bersih.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_bersih.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_bersih.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.btn_bersih.Location = New System.Drawing.Point(244, 162)
        Me.btn_bersih.Name = "btn_bersih"
        Me.btn_bersih.Size = New System.Drawing.Size(69, 31)
        Me.btn_bersih.TabIndex = 6
        Me.btn_bersih.Text = "Bersih"
        Me.btn_bersih.UseVisualStyleBackColor = False
        '
        'txt_banyak
        '
        Me.txt_banyak.AutoSize = True
        Me.txt_banyak.Location = New System.Drawing.Point(33, 394)
        Me.txt_banyak.Name = "txt_banyak"
        Me.txt_banyak.Size = New System.Drawing.Size(20, 24)
        Me.txt_banyak.TabIndex = 5
        Me.txt_banyak.Text = "0"
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.Location = New System.Drawing.Point(14, 212)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(349, 162)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 394)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(126, 394)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Biaya"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Jenis"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(201, 391)
        Me.txt_total.Multiline = True
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(156, 33)
        Me.txt_total.TabIndex = 2
        '
        'txt_biaya
        '
        Me.txt_biaya.Location = New System.Drawing.Point(111, 112)
        Me.txt_biaya.Multiline = True
        Me.txt_biaya.Name = "txt_biaya"
        Me.txt_biaya.Size = New System.Drawing.Size(156, 33)
        Me.txt_biaya.TabIndex = 2
        '
        'cb_jenis
        '
        Me.cb_jenis.FormattingEnabled = True
        Me.cb_jenis.Location = New System.Drawing.Point(111, 62)
        Me.cb_jenis.Name = "cb_jenis"
        Me.cb_jenis.Size = New System.Drawing.Size(156, 32)
        Me.cb_jenis.TabIndex = 1
        '
        'btn_tambah
        '
        Me.btn_tambah.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_tambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_tambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tambah.Location = New System.Drawing.Point(163, 162)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(75, 31)
        Me.btn_tambah.TabIndex = 0
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = False
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_simpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_simpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.Location = New System.Drawing.Point(82, 162)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(75, 31)
        Me.btn_simpan.TabIndex = 0
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'CostTambahan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(399, 456)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(415, 490)
        Me.MinimumSize = New System.Drawing.Size(415, 490)
        Me.Name = "CostTambahan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Daftar Outlet - Biaya Tambahan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_biaya As System.Windows.Forms.TextBox
    Friend WithEvents cb_jenis As System.Windows.Forms.ComboBox
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents btn_tambah As System.Windows.Forms.Button
    Friend WithEvents txt_banyak As System.Windows.Forms.Label
    Friend WithEvents btn_bersih As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
