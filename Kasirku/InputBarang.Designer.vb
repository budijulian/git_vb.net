<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputBarang
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
        Me.components = New System.ComponentModel.Container()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.st_waktu = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.st_total = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_export = New System.Windows.Forms.Button()
        Me.btn_searching = New System.Windows.Forms.Button()
        Me.dt_beli = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.t_banyak = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_namab = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_viewal = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.SeaGreen
        Me.TextBox10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox10.Location = New System.Drawing.Point(-2, -1)
        Me.TextBox10.Multiline = True
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(916, 65)
        Me.TextBox10.TabIndex = 8
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(-3, 74)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(918, 39)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-2, 114)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(918, 234)
        Me.DataGridView1.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Location = New System.Drawing.Point(-2, 348)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(918, 39)
        Me.TextBox2.TabIndex = 12
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SeaGreen
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(255, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "PEMBELIAN BARANG PER HARI"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(0, 390)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(664, 152)
        Me.DataGridView2.TabIndex = 14
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.st_waktu, Me.ToolStripStatusLabel2, Me.st_total})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 545)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(914, 22)
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(40, 17)
        Me.ToolStripStatusLabel1.Text = "Time :"
        '
        'st_waktu
        '
        Me.st_waktu.BackColor = System.Drawing.Color.Transparent
        Me.st_waktu.Name = "st_waktu"
        Me.st_waktu.Size = New System.Drawing.Size(31, 17)
        Me.st_waktu.Text = "time"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(67, 17)
        Me.ToolStripStatusLabel2.Text = "Total Item :"
        '
        'st_total
        '
        Me.st_total.BackColor = System.Drawing.Color.Transparent
        Me.st_total.Name = "st_total"
        Me.st_total.Size = New System.Drawing.Size(19, 17)
        Me.st_total.Text = "00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label2.Location = New System.Drawing.Point(286, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Tanggal Beli"
        '
        'btn_export
        '
        Me.btn_export.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_export.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_export.ForeColor = System.Drawing.Color.White
        Me.btn_export.Location = New System.Drawing.Point(663, 351)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(121, 33)
        Me.btn_export.TabIndex = 21
        Me.btn_export.Text = "EXPORT"
        Me.btn_export.UseVisualStyleBackColor = False
        '
        'btn_searching
        '
        Me.btn_searching.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_searching.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_searching.ForeColor = System.Drawing.Color.White
        Me.btn_searching.Location = New System.Drawing.Point(486, 76)
        Me.btn_searching.Name = "btn_searching"
        Me.btn_searching.Size = New System.Drawing.Size(83, 33)
        Me.btn_searching.TabIndex = 24
        Me.btn_searching.Text = "SEARCHING"
        Me.btn_searching.UseVisualStyleBackColor = False
        '
        'dt_beli
        '
        Me.dt_beli.CustomFormat = ""
        Me.dt_beli.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.dt_beli.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_beli.Location = New System.Drawing.Point(358, 80)
        Me.dt_beli.Name = "dt_beli"
        Me.dt_beli.Size = New System.Drawing.Size(120, 23)
        Me.dt_beli.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 20)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "DAFTAR PESANAN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(8, 358)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 18)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "PEMBELIAN BARANG"
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(6, 19)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(211, 108)
        Me.ListView1.TabIndex = 30
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.t_banyak)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Location = New System.Drawing.Point(679, 388)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 149)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail"
        '
        't_banyak
        '
        Me.t_banyak.AutoSize = True
        Me.t_banyak.BackColor = System.Drawing.Color.LightGreen
        Me.t_banyak.Location = New System.Drawing.Point(186, 130)
        Me.t_banyak.Name = "t_banyak"
        Me.t_banyak.Size = New System.Drawing.Size(19, 13)
        Me.t_banyak.TabIndex = 33
        Me.t_banyak.Text = "00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightGreen
        Me.Label3.Location = New System.Drawing.Point(124, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Total /Item:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label7.Location = New System.Drawing.Point(584, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Nama Barang"
        '
        'txt_namab
        '
        Me.txt_namab.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.txt_namab.Location = New System.Drawing.Point(663, 82)
        Me.txt_namab.Name = "txt_namab"
        Me.txt_namab.Size = New System.Drawing.Size(177, 23)
        Me.txt_namab.TabIndex = 33
        '
        'Timer1
        '
        '
        'btn_viewal
        '
        Me.btn_viewal.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_viewal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_viewal.ForeColor = System.Drawing.Color.White
        Me.btn_viewal.Location = New System.Drawing.Point(847, 77)
        Me.btn_viewal.Name = "btn_viewal"
        Me.btn_viewal.Size = New System.Drawing.Size(65, 31)
        Me.btn_viewal.TabIndex = 39
        Me.btn_viewal.Text = "VIEW ALL"
        Me.btn_viewal.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.SeaGreen
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(281, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(309, 24)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "FRESH GARDEN SUPPLIER"
        '
        'InputBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(914, 567)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_viewal)
        Me.Controls.Add(Me.txt_namab)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dt_beli)
        Me.Controls.Add(Me.btn_searching)
        Me.Controls.Add(Me.btn_export)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(930, 601)
        Me.MinimumSize = New System.Drawing.Size(930, 601)
        Me.Name = "InputBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard Kasir - Pembelian Barang"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents st_waktu As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btn_export As System.Windows.Forms.Button
    Friend WithEvents btn_searching As System.Windows.Forms.Button
    Friend WithEvents dt_beli As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents t_banyak As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_namab As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btn_viewal As System.Windows.Forms.Button
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents st_total As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
