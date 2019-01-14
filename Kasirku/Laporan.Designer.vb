<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Laporan))
        Me.time = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cb_outlet = New System.Windows.Forms.ComboBox()
        Me.txt_Tbeli = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.st_Total = New System.Windows.Forms.Label()
        Me.txt_untung = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txt_totalP = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.st_refund = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.DateTimePicker5 = New System.Windows.Forms.DateTimePicker()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.btn_ekport = New System.Windows.Forms.Button()
        Me.btn_cetak = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.btn_viewall = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.time1 = New System.Windows.Forms.Label()
        Me.btn_chart = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_import = New System.Windows.Forms.Button()
        Me.btn_savedb = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox5.SuspendLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.StatusStrip1.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'time
        '
        Me.time.AutoSize = true
        Me.time.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.time.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.time.ForeColor = System.Drawing.Color.White
        Me.time.Location = New System.Drawing.Point(6, 51)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(136, 18)
        Me.time.TabIndex = 11
        Me.time.Text = "06/09/2018 10:50"
        Me.time.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(416, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(423, 48)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "LAPORAN PENJUALAN DAN PEMBELIAN "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"BARANG"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.DarkCyan
        Me.GroupBox5.Controls.Add(Me.cb_outlet)
        Me.GroupBox5.Controls.Add(Me.txt_Tbeli)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.st_Total)
        Me.GroupBox5.Controls.Add(Me.txt_untung)
        Me.GroupBox5.Controls.Add(Me.Label32)
        Me.GroupBox5.Controls.Add(Me.txt_totalP)
        Me.GroupBox5.Controls.Add(Me.Label33)
        Me.GroupBox5.Controls.Add(Me.st_refund)
        Me.GroupBox5.Controls.Add(Me.Label39)
        Me.GroupBox5.Controls.Add(Me.Label40)
        Me.GroupBox5.Controls.Add(Me.DateTimePicker4)
        Me.GroupBox5.Controls.Add(Me.Label41)
        Me.GroupBox5.Controls.Add(Me.DateTimePicker5)
        Me.GroupBox5.Controls.Add(Me.Label43)
        Me.GroupBox5.Controls.Add(Me.Label45)
        Me.GroupBox5.Controls.Add(Me.Label49)
        Me.GroupBox5.Controls.Add(Me.ShapeContainer3)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 74)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1215, 111)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = false
        Me.GroupBox5.Text = "Menu"
        '
        'cb_outlet
        '
        Me.cb_outlet.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.cb_outlet.FormattingEnabled = true
        Me.cb_outlet.Items.AddRange(New Object() {"--Semua--"})
        Me.cb_outlet.Location = New System.Drawing.Point(110, 73)
        Me.cb_outlet.Name = "cb_outlet"
        Me.cb_outlet.Size = New System.Drawing.Size(244, 25)
        Me.cb_outlet.Sorted = true
        Me.cb_outlet.TabIndex = 18
        Me.cb_outlet.Text = "--Semua--"
        '
        'txt_Tbeli
        '
        Me.txt_Tbeli.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txt_Tbeli.Location = New System.Drawing.Point(773, 62)
        Me.txt_Tbeli.Multiline = true
        Me.txt_Tbeli.Name = "txt_Tbeli"
        Me.txt_Tbeli.ReadOnly = true
        Me.txt_Tbeli.Size = New System.Drawing.Size(138, 31)
        Me.txt_Tbeli.TabIndex = 6
        Me.txt_Tbeli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.Location = New System.Drawing.Point(630, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Total Pembelian"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(409, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Refund  :"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(540, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Items"
        '
        'st_Total
        '
        Me.st_Total.AutoSize = true
        Me.st_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.st_Total.Location = New System.Drawing.Point(509, 36)
        Me.st_Total.Name = "st_Total"
        Me.st_Total.Size = New System.Drawing.Size(24, 16)
        Me.st_Total.TabIndex = 0
        Me.st_Total.Text = "00"
        '
        'txt_untung
        '
        Me.txt_untung.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txt_untung.Font = New System.Drawing.Font("Microsoft Sans Serif", 27!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txt_untung.Location = New System.Drawing.Point(951, 42)
        Me.txt_untung.Multiline = true
        Me.txt_untung.Name = "txt_untung"
        Me.txt_untung.ReadOnly = true
        Me.txt_untung.Size = New System.Drawing.Size(244, 52)
        Me.txt_untung.TabIndex = 6
        Me.txt_untung.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label32
        '
        Me.Label32.AutoSize = true
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label32.Location = New System.Drawing.Point(947, 17)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(130, 20)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "KEUNTUNGAN"
        '
        'txt_totalP
        '
        Me.txt_totalP.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txt_totalP.Location = New System.Drawing.Point(773, 19)
        Me.txt_totalP.Multiline = true
        Me.txt_totalP.Name = "txt_totalP"
        Me.txt_totalP.ReadOnly = true
        Me.txt_totalP.Size = New System.Drawing.Size(138, 31)
        Me.txt_totalP.TabIndex = 6
        Me.txt_totalP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label33
        '
        Me.Label33.AutoSize = true
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label33.Location = New System.Drawing.Point(540, 64)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(45, 16)
        Me.Label33.TabIndex = 0
        Me.Label33.Text = "Items"
        '
        'st_refund
        '
        Me.st_refund.AutoSize = true
        Me.st_refund.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.st_refund.Location = New System.Drawing.Point(509, 66)
        Me.st_refund.Name = "st_refund"
        Me.st_refund.Size = New System.Drawing.Size(24, 16)
        Me.st_refund.TabIndex = 0
        Me.st_refund.Text = "00"
        '
        'Label39
        '
        Me.Label39.AutoSize = true
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label39.Location = New System.Drawing.Point(6, 28)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(66, 16)
        Me.Label39.TabIndex = 0
        Me.Label39.Text = "Tanggal"
        '
        'Label40
        '
        Me.Label40.AutoSize = true
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label40.Location = New System.Drawing.Point(204, 30)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(29, 16)
        Me.Label40.TabIndex = 0
        Me.Label40.Text = "s.d"
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.CustomFormat = ""
        Me.DateTimePicker4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker4.Location = New System.Drawing.Point(91, 25)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(100, 22)
        Me.DateTimePicker4.TabIndex = 4
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(106, 57)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(90, 13)
        Me.Label41.TabIndex = 0
        Me.Label41.Text = "*pilih nama outlet "
        '
        'DateTimePicker5
        '
        Me.DateTimePicker5.CustomFormat = ""
        Me.DateTimePicker5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker5.Location = New System.Drawing.Point(247, 25)
        Me.DateTimePicker5.Name = "DateTimePicker5"
        Me.DateTimePicker5.Size = New System.Drawing.Size(107, 22)
        Me.DateTimePicker5.TabIndex = 4
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(406, 35)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(97, 16)
        Me.Label43.TabIndex = 0
        Me.Label43.Text = "Total Items  :"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(7, 76)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(93, 16)
        Me.Label45.TabIndex = 0
        Me.Label45.Text = "Nama Outlet"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(630, 23)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(133, 20)
        Me.Label49.TabIndex = 0
        Me.Label49.Text = "Total Penjualan"
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2})
        Me.ShapeContainer3.Size = New System.Drawing.Size(1209, 92)
        Me.ShapeContainer3.TabIndex = 8
        Me.ShapeContainer3.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderWidth = 2
        Me.RectangleShape2.Location = New System.Drawing.Point(387, 5)
        Me.RectangleShape2.Name = "RectangleShape3"
        Me.RectangleShape2.Size = New System.Drawing.Size(202, 76)
        '
        'btn_ekport
        '
        Me.btn_ekport.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btn_ekport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ekport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btn_ekport.Location = New System.Drawing.Point(258, 192)
        Me.btn_ekport.Name = "btn_ekport"
        Me.btn_ekport.Size = New System.Drawing.Size(78, 37)
        Me.btn_ekport.TabIndex = 7
        Me.btn_ekport.Text = "EKPORT TO EXCEL"
        Me.btn_ekport.UseVisualStyleBackColor = False
        '
        'btn_cetak
        '
        Me.btn_cetak.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btn_cetak.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cetak.Location = New System.Drawing.Point(89, 192)
        Me.btn_cetak.Name = "btn_cetak"
        Me.btn_cetak.Size = New System.Drawing.Size(70, 36)
        Me.btn_cetak.TabIndex = 7
        Me.btn_cetak.Text = "PRINT"
        Me.btn_cetak.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DarkSeaGreen
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(1, 236)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DataGridView1.Size = New System.Drawing.Size(1219, 413)
        Me.DataGridView1.TabIndex = 12
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.MediumAquamarine
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderWidth = 2
        Me.RectangleShape1.Location = New System.Drawing.Point(3, 187)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(1216, 46)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1222, 708)
        Me.ShapeContainer1.TabIndex = 13
        Me.ShapeContainer1.TabStop = False
        '
        'btn_viewall
        '
        Me.btn_viewall.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btn_viewall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_viewall.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btn_viewall.Location = New System.Drawing.Point(8, 191)
        Me.btn_viewall.Name = "btn_viewall"
        Me.btn_viewall.Size = New System.Drawing.Size(74, 37)
        Me.btn_viewall.TabIndex = 7
        Me.btn_viewall.Text = "VIEW ALL"
        Me.btn_viewall.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 686)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1222, 22)
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "Laporan Penjualan dan Pembelian"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(1207, 17)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.Text = "Status : Private"
        '
        'time1
        '
        Me.time1.AutoSize = True
        Me.time1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.time1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.time1.ForeColor = System.Drawing.Color.White
        Me.time1.Location = New System.Drawing.Point(7, 33)
        Me.time1.Name = "time1"
        Me.time1.Size = New System.Drawing.Size(136, 18)
        Me.time1.TabIndex = 16
        Me.time1.Text = "06/09/2018 10:50"
        Me.time1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_chart
        '
        Me.btn_chart.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btn_chart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_chart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btn_chart.Location = New System.Drawing.Point(171, 191)
        Me.btn_chart.Name = "btn_chart"
        Me.btn_chart.Size = New System.Drawing.Size(74, 37)
        Me.btn_chart.TabIndex = 17
        Me.btn_chart.Text = "CHART"
        Me.btn_chart.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.PictureBox1.Image = Global.Kasirku.My.Resources.Resources.business_salesreport_salesreport_negocio_2353
        Me.PictureBox1.Location = New System.Drawing.Point(1152, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "DATE  :"
        '
        'btn_import
        '
        Me.btn_import.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btn_import.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_import.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btn_import.Location = New System.Drawing.Point(349, 192)
        Me.btn_import.Name = "btn_import"
        Me.btn_import.Size = New System.Drawing.Size(78, 37)
        Me.btn_import.TabIndex = 20
        Me.btn_import.Text = "IMPORT TO EXCEL"
        Me.btn_import.UseVisualStyleBackColor = False
        '
        'btn_savedb
        '
        Me.btn_savedb.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btn_savedb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_savedb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btn_savedb.Location = New System.Drawing.Point(436, 192)
        Me.btn_savedb.Name = "btn_savedb"
        Me.btn_savedb.Size = New System.Drawing.Size(82, 37)
        Me.btn_savedb.TabIndex = 21
        Me.btn_savedb.Text = "SAVE TO DATABASE"
        Me.btn_savedb.UseVisualStyleBackColor = false
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(1222, 708)
        Me.Controls.Add(Me.btn_savedb)
        Me.Controls.Add(Me.btn_import)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_chart)
        Me.Controls.Add(Me.time1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btn_viewall)
        Me.Controls.Add(Me.btn_ekport)
        Me.Controls.Add(Me.btn_cetak)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.time)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1238, 742)
        Me.MinimumSize = New System.Drawing.Size(1238, 742)
        Me.Name = "Laporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard Kasir - Laporan Keuangan"
        Me.GroupBox5.ResumeLayout(false)
        Me.GroupBox5.PerformLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents time As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents st_Total As System.Windows.Forms.Label
    Friend WithEvents txt_untung As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txt_totalP As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents st_refund As System.Windows.Forms.Label
    Friend WithEvents btn_ekport As System.Windows.Forms.Button
    Friend WithEvents btn_cetak As System.Windows.Forms.Button
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker5 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer3 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents btn_viewall As System.Windows.Forms.Button
    Friend WithEvents txt_Tbeli As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents time1 As System.Windows.Forms.Label
    Friend WithEvents btn_chart As System.Windows.Forms.Button
    Friend WithEvents cb_outlet As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_import As System.Windows.Forms.Button
    Friend WithEvents btn_savedb As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
