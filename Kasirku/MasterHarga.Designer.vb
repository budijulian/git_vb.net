<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterHarga
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterHarga))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_kode = New System.Windows.Forms.TextBox()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ts_proses1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.Process1 = New System.Diagnostics.Process()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_namab = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_satuan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_banyak = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.time = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dt_beli = New System.Windows.Forms.DateTimePicker()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_Hbeli = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_hJual = New System.Windows.Forms.TextBox()
        Me.lb_sbanyak2 = New System.Windows.Forms.Label()
        Me.lb_sbanyak3 = New System.Windows.Forms.Label()
        Me.lb_sbanyak = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rb_vegetables = New System.Windows.Forms.RadioButton()
        Me.rb_fruit = New System.Windows.Forms.RadioButton()
        Me.rb_others = New System.Windows.Forms.RadioButton()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_export = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txt_sear_namab = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(168, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MASTER HARGA"
        '
        'txt_kode
        '
        Me.txt_kode.Location = New System.Drawing.Point(84, 72)
        Me.txt_kode.Name = "txt_kode"
        Me.txt_kode.Size = New System.Drawing.Size(144, 20)
        Me.txt_kode.TabIndex = 6
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_simpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_simpan.Location = New System.Drawing.Point(275, 280)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(59, 29)
        Me.btn_simpan.TabIndex = 2
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.SeaGreen
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.ts_proses1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 556)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(484, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(61, 17)
        Me.ToolStripStatusLabel1.Text = "Database :"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(50, 17)
        Me.ToolStripStatusLabel2.Text = "db_kasir"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(106, 17)
        Me.ToolStripStatusLabel3.Text = "Table : daftarharga"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(133, 17)
        Me.ToolStripStatusLabel4.Text = "                                          "
        '
        'ts_proses1
        '
        Me.ts_proses1.Name = "ts_proses1"
        Me.ts_proses1.Size = New System.Drawing.Size(100, 16)
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "No Kode"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(20, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Jenis"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(19, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nama "
        '
        'txt_namab
        '
        Me.txt_namab.Location = New System.Drawing.Point(84, 138)
        Me.txt_namab.Name = "txt_namab"
        Me.txt_namab.Size = New System.Drawing.Size(144, 20)
        Me.txt_namab.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(20, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Satuan"
        '
        'txt_satuan
        '
        Me.txt_satuan.Location = New System.Drawing.Point(84, 177)
        Me.txt_satuan.Name = "txt_satuan"
        Me.txt_satuan.Size = New System.Drawing.Size(55, 20)
        Me.txt_satuan.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(19, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Banyak"
        '
        'txt_banyak
        '
        Me.txt_banyak.Location = New System.Drawing.Point(84, 214)
        Me.txt_banyak.Name = "txt_banyak"
        Me.txt_banyak.Size = New System.Drawing.Size(55, 20)
        Me.txt_banyak.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(277, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Tanggal Beli"
        '
        'time
        '
        Me.time.AutoSize = True
        Me.time.ForeColor = System.Drawing.Color.White
        Me.time.Location = New System.Drawing.Point(40, 9)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(30, 13)
        Me.time.TabIndex = 0
        Me.time.Text = "Time"
        '
        'Timer1
        '
        '
        'dt_beli
        '
        Me.dt_beli.CustomFormat = ""
        Me.dt_beli.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_beli.Location = New System.Drawing.Point(349, 71)
        Me.dt_beli.Name = "dt_beli"
        Me.dt_beli.Size = New System.Drawing.Size(110, 20)
        Me.dt_beli.TabIndex = 5
        Me.dt_beli.Value = New Date(2018, 8, 30, 0, 0, 0, 0)
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit.Location = New System.Drawing.Point(340, 280)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(59, 29)
        Me.btn_edit.TabIndex = 2
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(20, 254)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Harga Beli"
        '
        'txt_Hbeli
        '
        Me.txt_Hbeli.Location = New System.Drawing.Point(84, 252)
        Me.txt_Hbeli.Name = "txt_Hbeli"
        Me.txt_Hbeli.Size = New System.Drawing.Size(107, 20)
        Me.txt_Hbeli.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(19, 294)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Harga Jual"
        '
        'txt_hJual
        '
        Me.txt_hJual.Location = New System.Drawing.Point(84, 293)
        Me.txt_hJual.Name = "txt_hJual"
        Me.txt_hJual.Size = New System.Drawing.Size(107, 20)
        Me.txt_hJual.TabIndex = 4
        '
        'lb_sbanyak2
        '
        Me.lb_sbanyak2.AutoSize = True
        Me.lb_sbanyak2.ForeColor = System.Drawing.Color.White
        Me.lb_sbanyak2.Location = New System.Drawing.Point(192, 257)
        Me.lb_sbanyak2.Name = "lb_sbanyak2"
        Me.lb_sbanyak2.Size = New System.Drawing.Size(47, 13)
        Me.lb_sbanyak2.TabIndex = 0
        Me.lb_sbanyak2.Text = "/ satuan"
        '
        'lb_sbanyak3
        '
        Me.lb_sbanyak3.AutoSize = True
        Me.lb_sbanyak3.ForeColor = System.Drawing.Color.White
        Me.lb_sbanyak3.Location = New System.Drawing.Point(195, 298)
        Me.lb_sbanyak3.Name = "lb_sbanyak3"
        Me.lb_sbanyak3.Size = New System.Drawing.Size(47, 13)
        Me.lb_sbanyak3.TabIndex = 0
        Me.lb_sbanyak3.Text = "/ satuan"
        '
        'lb_sbanyak
        '
        Me.lb_sbanyak.AutoSize = True
        Me.lb_sbanyak.ForeColor = System.Drawing.Color.White
        Me.lb_sbanyak.Location = New System.Drawing.Point(144, 218)
        Me.lb_sbanyak.Name = "lb_sbanyak"
        Me.lb_sbanyak.Size = New System.Drawing.Size(47, 13)
        Me.lb_sbanyak.TabIndex = 0
        Me.lb_sbanyak.Text = "/ satuan"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(484, 578)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.White
        Me.RectangleShape1.Location = New System.Drawing.Point(11, 53)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(462, 302)
        '
        'rb_vegetables
        '
        Me.rb_vegetables.AutoSize = True
        Me.rb_vegetables.ForeColor = System.Drawing.Color.White
        Me.rb_vegetables.Location = New System.Drawing.Point(84, 107)
        Me.rb_vegetables.Name = "rb_vegetables"
        Me.rb_vegetables.Size = New System.Drawing.Size(78, 17)
        Me.rb_vegetables.TabIndex = 10
        Me.rb_vegetables.TabStop = True
        Me.rb_vegetables.Text = "Vegetables"
        Me.rb_vegetables.UseVisualStyleBackColor = True
        '
        'rb_fruit
        '
        Me.rb_fruit.AutoSize = True
        Me.rb_fruit.ForeColor = System.Drawing.Color.White
        Me.rb_fruit.Location = New System.Drawing.Point(170, 107)
        Me.rb_fruit.Name = "rb_fruit"
        Me.rb_fruit.Size = New System.Drawing.Size(45, 17)
        Me.rb_fruit.TabIndex = 10
        Me.rb_fruit.TabStop = True
        Me.rb_fruit.Text = "Fruit"
        Me.rb_fruit.UseVisualStyleBackColor = True
        '
        'rb_others
        '
        Me.rb_others.AutoSize = True
        Me.rb_others.ForeColor = System.Drawing.Color.White
        Me.rb_others.Location = New System.Drawing.Point(226, 107)
        Me.rb_others.Name = "rb_others"
        Me.rb_others.Size = New System.Drawing.Size(56, 17)
        Me.rb_others.TabIndex = 10
        Me.rb_others.TabStop = True
        Me.rb_others.Text = "Others"
        Me.rb_others.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.Location = New System.Drawing.Point(405, 280)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(59, 28)
        Me.btn_delete.TabIndex = 11
        Me.btn_delete.Text = "Hapus"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Time :"
        '
        'btn_export
        '
        Me.btn_export.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_export.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_export.Location = New System.Drawing.Point(405, 245)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(59, 29)
        Me.btn_export.TabIndex = 12
        Me.btn_export.Text = "Export"
        Me.btn_export.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.Location = New System.Drawing.Point(275, 245)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(59, 29)
        Me.btn_close.TabIndex = 14
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clear.Location = New System.Drawing.Point(340, 245)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(60, 28)
        Me.btn_clear.TabIndex = 15
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.MediumAquamarine
        Me.DataGridView1.Location = New System.Drawing.Point(10, 365)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(465, 190)
        Me.DataGridView1.TabIndex = 16
        '
        'txt_sear_namab
        '
        Me.txt_sear_namab.Location = New System.Drawing.Point(279, 326)
        Me.txt_sear_namab.Name = "txt_sear_namab"
        Me.txt_sear_namab.Size = New System.Drawing.Size(180, 20)
        Me.txt_sear_namab.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(215, 330)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Cari Barang"
        '
        'MasterHarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(484, 578)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_sear_namab)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_export)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.rb_others)
        Me.Controls.Add(Me.rb_fruit)
        Me.Controls.Add(Me.rb_vegetables)
        Me.Controls.Add(Me.dt_beli)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.txt_hJual)
        Me.Controls.Add(Me.lb_sbanyak3)
        Me.Controls.Add(Me.lb_sbanyak)
        Me.Controls.Add(Me.lb_sbanyak2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_Hbeli)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_banyak)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_satuan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_namab)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.time)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_kode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(500, 612)
        Me.MinimumSize = New System.Drawing.Size(500, 612)
        Me.Name = "MasterHarga"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dashboard Kasir  - Master Harga"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_kode As System.Windows.Forms.TextBox
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ts_proses1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Process1 As System.Diagnostics.Process
    Friend WithEvents txt_banyak As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_satuan As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_namab As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents time As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents dt_beli As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents txt_hJual As System.Windows.Forms.TextBox
    Friend WithEvents lb_sbanyak3 As System.Windows.Forms.Label
    Friend WithEvents lb_sbanyak2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_Hbeli As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lb_sbanyak As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rb_others As System.Windows.Forms.RadioButton
    Friend WithEvents rb_fruit As System.Windows.Forms.RadioButton
    Friend WithEvents rb_vegetables As System.Windows.Forms.RadioButton
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_export As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_sear_namab As System.Windows.Forms.TextBox
End Class
