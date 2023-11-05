<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataGuru
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_idguru = New System.Windows.Forms.TextBox()
        Me.txt_nip = New System.Windows.Forms.TextBox()
        Me.txt_namaguru = New System.Windows.Forms.TextBox()
        Me.txt_alamat = New System.Windows.Forms.TextBox()
        Me.dtp_tanggallahir = New System.Windows.Forms.DateTimePicker()
        Me.rb_laki = New System.Windows.Forms.RadioButton()
        Me.rb_perempuan = New System.Windows.Forms.RadioButton()
        Me.btn_cari = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_ubah = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 50)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MENU" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MANAJEMEN DATA GURU" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 85)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(735, 150)
        Me.DataGridView1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(46, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "ID GURU"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(46, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "NIP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(46, 320)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "NAMA GURU"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(46, 346)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "ALAMAT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(44, 409)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "TANGGAL LAHIR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(46, 437)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "JENIS KELAMIN"
        '
        'txt_idguru
        '
        Me.txt_idguru.Location = New System.Drawing.Point(225, 264)
        Me.txt_idguru.Name = "txt_idguru"
        Me.txt_idguru.Size = New System.Drawing.Size(261, 20)
        Me.txt_idguru.TabIndex = 11
        '
        'txt_nip
        '
        Me.txt_nip.Location = New System.Drawing.Point(225, 292)
        Me.txt_nip.Name = "txt_nip"
        Me.txt_nip.Size = New System.Drawing.Size(261, 20)
        Me.txt_nip.TabIndex = 12
        '
        'txt_namaguru
        '
        Me.txt_namaguru.Location = New System.Drawing.Point(225, 320)
        Me.txt_namaguru.Name = "txt_namaguru"
        Me.txt_namaguru.Size = New System.Drawing.Size(261, 20)
        Me.txt_namaguru.TabIndex = 13
        '
        'txt_alamat
        '
        Me.txt_alamat.Location = New System.Drawing.Point(225, 346)
        Me.txt_alamat.Multiline = True
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.Size = New System.Drawing.Size(261, 56)
        Me.txt_alamat.TabIndex = 14
        '
        'dtp_tanggallahir
        '
        Me.dtp_tanggallahir.Location = New System.Drawing.Point(225, 409)
        Me.dtp_tanggallahir.Name = "dtp_tanggallahir"
        Me.dtp_tanggallahir.Size = New System.Drawing.Size(261, 20)
        Me.dtp_tanggallahir.TabIndex = 15
        '
        'rb_laki
        '
        Me.rb_laki.AutoSize = True
        Me.rb_laki.Location = New System.Drawing.Point(225, 436)
        Me.rb_laki.Name = "rb_laki"
        Me.rb_laki.Size = New System.Drawing.Size(64, 17)
        Me.rb_laki.TabIndex = 16
        Me.rb_laki.TabStop = True
        Me.rb_laki.Text = "Laki-laki"
        Me.rb_laki.UseVisualStyleBackColor = True
        '
        'rb_perempuan
        '
        Me.rb_perempuan.AutoSize = True
        Me.rb_perempuan.Location = New System.Drawing.Point(407, 435)
        Me.rb_perempuan.Name = "rb_perempuan"
        Me.rb_perempuan.Size = New System.Drawing.Size(79, 17)
        Me.rb_perempuan.TabIndex = 17
        Me.rb_perempuan.TabStop = True
        Me.rb_perempuan.Text = "Perempuan"
        Me.rb_perempuan.UseVisualStyleBackColor = True
        '
        'btn_cari
        '
        Me.btn_cari.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.btn_cari.FlatAppearance.BorderSize = 0
        Me.btn_cari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cari.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cari.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_cari.Location = New System.Drawing.Point(492, 262)
        Me.btn_cari.Name = "btn_cari"
        Me.btn_cari.Size = New System.Drawing.Size(65, 23)
        Me.btn_cari.TabIndex = 18
        Me.btn_cari.Text = "Cari"
        Me.btn_cari.UseVisualStyleBackColor = False
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.btn_simpan.FlatAppearance.BorderSize = 0
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_simpan.Location = New System.Drawing.Point(49, 492)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(112, 35)
        Me.btn_simpan.TabIndex = 19
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'btn_ubah
        '
        Me.btn_ubah.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.btn_ubah.FlatAppearance.BorderSize = 0
        Me.btn_ubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ubah.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ubah.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_ubah.Location = New System.Drawing.Point(318, 492)
        Me.btn_ubah.Name = "btn_ubah"
        Me.btn_ubah.Size = New System.Drawing.Size(112, 35)
        Me.btn_ubah.TabIndex = 19
        Me.btn_ubah.Text = "Ubah"
        Me.btn_ubah.UseVisualStyleBackColor = False
        '
        'btn_hapus
        '
        Me.btn_hapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.btn_hapus.FlatAppearance.BorderSize = 0
        Me.btn_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_hapus.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hapus.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_hapus.Location = New System.Drawing.Point(594, 492)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(112, 35)
        Me.btn_hapus.TabIndex = 19
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = False
        '
        'DataGuru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_ubah)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.btn_cari)
        Me.Controls.Add(Me.rb_perempuan)
        Me.Controls.Add(Me.rb_laki)
        Me.Controls.Add(Me.dtp_tanggallahir)
        Me.Controls.Add(Me.txt_alamat)
        Me.Controls.Add(Me.txt_namaguru)
        Me.Controls.Add(Me.txt_nip)
        Me.Controls.Add(Me.txt_idguru)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DataGuru"
        Me.Size = New System.Drawing.Size(764, 561)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_idguru As TextBox
    Friend WithEvents txt_nip As TextBox
    Friend WithEvents txt_namaguru As TextBox
    Friend WithEvents txt_alamat As TextBox
    Friend WithEvents dtp_tanggallahir As DateTimePicker
    Friend WithEvents rb_laki As RadioButton
    Friend WithEvents rb_perempuan As RadioButton
    Friend WithEvents btn_cari As Button
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_ubah As Button
    Friend WithEvents btn_hapus As Button
End Class
