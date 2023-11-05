<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataSiswa
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_idsiswa = New System.Windows.Forms.TextBox()
        Me.txt_nis = New System.Windows.Forms.TextBox()
        Me.txt_namasiswa = New System.Windows.Forms.TextBox()
        Me.cmb_kelas = New System.Windows.Forms.ComboBox()
        Me.cmb_jurusan = New System.Windows.Forms.ComboBox()
        Me.txt_alamat = New System.Windows.Forms.TextBox()
        Me.dtp_tanggallahir = New System.Windows.Forms.DateTimePicker()
        Me.rb_laki = New System.Windows.Forms.RadioButton()
        Me.rb_perempuan = New System.Windows.Forms.RadioButton()
        Me.txt_idjurusan = New System.Windows.Forms.TextBox()
        Me.txt_idkelas = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_cari = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_ubah = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 85)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(735, 150)
        Me.DataGridView1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 50)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "MENU" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MANAJEMEN DATA SISWA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(110, 389)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "ALAMAT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(110, 360)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "JURUSAN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(110, 333)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "KELAS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(110, 307)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "NAMA SISWA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(110, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "NIS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(110, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "ID SISWA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(110, 450)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "TANGGAL LAHIR"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(110, 477)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "JENIS KELAMIN"
        '
        'txt_idsiswa
        '
        Me.txt_idsiswa.Location = New System.Drawing.Point(270, 256)
        Me.txt_idsiswa.Name = "txt_idsiswa"
        Me.txt_idsiswa.Size = New System.Drawing.Size(200, 20)
        Me.txt_idsiswa.TabIndex = 19
        '
        'txt_nis
        '
        Me.txt_nis.Location = New System.Drawing.Point(270, 282)
        Me.txt_nis.Name = "txt_nis"
        Me.txt_nis.Size = New System.Drawing.Size(200, 20)
        Me.txt_nis.TabIndex = 20
        '
        'txt_namasiswa
        '
        Me.txt_namasiswa.Location = New System.Drawing.Point(270, 307)
        Me.txt_namasiswa.Name = "txt_namasiswa"
        Me.txt_namasiswa.Size = New System.Drawing.Size(200, 20)
        Me.txt_namasiswa.TabIndex = 20
        '
        'cmb_kelas
        '
        Me.cmb_kelas.FormattingEnabled = True
        Me.cmb_kelas.Location = New System.Drawing.Point(270, 333)
        Me.cmb_kelas.Name = "cmb_kelas"
        Me.cmb_kelas.Size = New System.Drawing.Size(200, 21)
        Me.cmb_kelas.TabIndex = 21
        '
        'cmb_jurusan
        '
        Me.cmb_jurusan.FormattingEnabled = True
        Me.cmb_jurusan.Location = New System.Drawing.Point(270, 360)
        Me.cmb_jurusan.Name = "cmb_jurusan"
        Me.cmb_jurusan.Size = New System.Drawing.Size(200, 21)
        Me.cmb_jurusan.TabIndex = 21
        '
        'txt_alamat
        '
        Me.txt_alamat.Location = New System.Drawing.Point(270, 389)
        Me.txt_alamat.Multiline = True
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.Size = New System.Drawing.Size(200, 54)
        Me.txt_alamat.TabIndex = 22
        '
        'dtp_tanggallahir
        '
        Me.dtp_tanggallahir.Location = New System.Drawing.Point(270, 450)
        Me.dtp_tanggallahir.Name = "dtp_tanggallahir"
        Me.dtp_tanggallahir.Size = New System.Drawing.Size(200, 20)
        Me.dtp_tanggallahir.TabIndex = 23
        '
        'rb_laki
        '
        Me.rb_laki.AutoSize = True
        Me.rb_laki.Location = New System.Drawing.Point(270, 477)
        Me.rb_laki.Name = "rb_laki"
        Me.rb_laki.Size = New System.Drawing.Size(64, 17)
        Me.rb_laki.TabIndex = 24
        Me.rb_laki.TabStop = True
        Me.rb_laki.Text = "Laki-laki"
        Me.rb_laki.UseVisualStyleBackColor = True
        '
        'rb_perempuan
        '
        Me.rb_perempuan.AutoSize = True
        Me.rb_perempuan.Location = New System.Drawing.Point(391, 477)
        Me.rb_perempuan.Name = "rb_perempuan"
        Me.rb_perempuan.Size = New System.Drawing.Size(79, 17)
        Me.rb_perempuan.TabIndex = 25
        Me.rb_perempuan.TabStop = True
        Me.rb_perempuan.Text = "Perempuan"
        Me.rb_perempuan.UseVisualStyleBackColor = True
        '
        'txt_idjurusan
        '
        Me.txt_idjurusan.Location = New System.Drawing.Point(270, 530)
        Me.txt_idjurusan.Name = "txt_idjurusan"
        Me.txt_idjurusan.Size = New System.Drawing.Size(200, 20)
        Me.txt_idjurusan.TabIndex = 29
        '
        'txt_idkelas
        '
        Me.txt_idkelas.Location = New System.Drawing.Point(270, 504)
        Me.txt_idkelas.Name = "txt_idkelas"
        Me.txt_idkelas.Size = New System.Drawing.Size(200, 20)
        Me.txt_idkelas.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(110, 530)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 16)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "ID JURUSAN"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(110, 504)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 16)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "ID KELAS"
        '
        'btn_cari
        '
        Me.btn_cari.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.btn_cari.FlatAppearance.BorderSize = 0
        Me.btn_cari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cari.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cari.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_cari.Location = New System.Drawing.Point(476, 254)
        Me.btn_cari.Name = "btn_cari"
        Me.btn_cari.Size = New System.Drawing.Size(65, 23)
        Me.btn_cari.TabIndex = 30
        Me.btn_cari.Text = "Cari"
        Me.btn_cari.UseVisualStyleBackColor = False
        '
        'btn_hapus
        '
        Me.btn_hapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.btn_hapus.FlatAppearance.BorderSize = 0
        Me.btn_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_hapus.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hapus.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_hapus.Location = New System.Drawing.Point(537, 420)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(112, 35)
        Me.btn_hapus.TabIndex = 31
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = False
        '
        'btn_ubah
        '
        Me.btn_ubah.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.btn_ubah.FlatAppearance.BorderSize = 0
        Me.btn_ubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ubah.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ubah.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_ubah.Location = New System.Drawing.Point(537, 369)
        Me.btn_ubah.Name = "btn_ubah"
        Me.btn_ubah.Size = New System.Drawing.Size(112, 35)
        Me.btn_ubah.TabIndex = 32
        Me.btn_ubah.Text = "Ubah"
        Me.btn_ubah.UseVisualStyleBackColor = False
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.btn_simpan.FlatAppearance.BorderSize = 0
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_simpan.Location = New System.Drawing.Point(537, 321)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(112, 35)
        Me.btn_simpan.TabIndex = 33
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'DataSiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_ubah)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.btn_cari)
        Me.Controls.Add(Me.txt_idjurusan)
        Me.Controls.Add(Me.txt_idkelas)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.rb_perempuan)
        Me.Controls.Add(Me.rb_laki)
        Me.Controls.Add(Me.dtp_tanggallahir)
        Me.Controls.Add(Me.txt_alamat)
        Me.Controls.Add(Me.cmb_jurusan)
        Me.Controls.Add(Me.cmb_kelas)
        Me.Controls.Add(Me.txt_namasiswa)
        Me.Controls.Add(Me.txt_nis)
        Me.Controls.Add(Me.txt_idsiswa)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DataSiswa"
        Me.Size = New System.Drawing.Size(764, 561)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_idsiswa As TextBox
    Friend WithEvents txt_nis As TextBox
    Friend WithEvents txt_namasiswa As TextBox
    Friend WithEvents cmb_kelas As ComboBox
    Friend WithEvents cmb_jurusan As ComboBox
    Friend WithEvents txt_alamat As TextBox
    Friend WithEvents dtp_tanggallahir As DateTimePicker
    Friend WithEvents rb_laki As RadioButton
    Friend WithEvents rb_perempuan As RadioButton
    Friend WithEvents txt_idjurusan As TextBox
    Friend WithEvents txt_idkelas As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_cari As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_ubah As Button
    Friend WithEvents btn_simpan As Button
End Class
