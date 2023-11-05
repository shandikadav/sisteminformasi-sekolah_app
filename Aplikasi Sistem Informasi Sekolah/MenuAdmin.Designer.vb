<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAdmin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_datajurusan = New System.Windows.Forms.Button()
        Me.btn_datakelas = New System.Windows.Forms.Button()
        Me.btn_datasiswa = New System.Windows.Forms.Button()
        Me.btn_dataguru = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_datamapel = New System.Windows.Forms.Button()
        Me.DataMapel1 = New Aplikasi_Sistem_Informasi_Sekolah.DataMapel()
        Me.DataSiswa1 = New Aplikasi_Sistem_Informasi_Sekolah.DataSiswa()
        Me.DataKelas1 = New Aplikasi_Sistem_Informasi_Sekolah.DataKelas()
        Me.DataJurusan1 = New Aplikasi_Sistem_Informasi_Sekolah.DataJurusan()
        Me.DataGuru1 = New Aplikasi_Sistem_Informasi_Sekolah.DataGuru()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_logout)
        Me.Panel1.Controls.Add(Me.btn_datajurusan)
        Me.Panel1.Controls.Add(Me.btn_datamapel)
        Me.Panel1.Controls.Add(Me.btn_datakelas)
        Me.Panel1.Controls.Add(Me.btn_datasiswa)
        Me.Panel1.Controls.Add(Me.btn_dataguru)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(216, 561)
        Me.Panel1.TabIndex = 0
        '
        'btn_logout
        '
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_logout.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_logout.Location = New System.Drawing.Point(17, 379)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(176, 39)
        Me.btn_logout.TabIndex = 2
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'btn_datajurusan
        '
        Me.btn_datajurusan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_datajurusan.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_datajurusan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_datajurusan.Location = New System.Drawing.Point(17, 320)
        Me.btn_datajurusan.Name = "btn_datajurusan"
        Me.btn_datajurusan.Size = New System.Drawing.Size(176, 42)
        Me.btn_datajurusan.TabIndex = 3
        Me.btn_datajurusan.Text = "Manajemen Data Jurusan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_datajurusan.UseVisualStyleBackColor = True
        '
        'btn_datakelas
        '
        Me.btn_datakelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_datakelas.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_datakelas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_datakelas.Location = New System.Drawing.Point(17, 202)
        Me.btn_datakelas.Name = "btn_datakelas"
        Me.btn_datakelas.Size = New System.Drawing.Size(176, 39)
        Me.btn_datakelas.TabIndex = 3
        Me.btn_datakelas.Text = "Manajemen Data Kelas"
        Me.btn_datakelas.UseVisualStyleBackColor = True
        '
        'btn_datasiswa
        '
        Me.btn_datasiswa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_datasiswa.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_datasiswa.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_datasiswa.Location = New System.Drawing.Point(17, 146)
        Me.btn_datasiswa.Name = "btn_datasiswa"
        Me.btn_datasiswa.Size = New System.Drawing.Size(176, 39)
        Me.btn_datasiswa.TabIndex = 3
        Me.btn_datasiswa.Text = "Manajemen Data Siswa"
        Me.btn_datasiswa.UseVisualStyleBackColor = True
        '
        'btn_dataguru
        '
        Me.btn_dataguru.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dataguru.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_dataguru.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_dataguru.Location = New System.Drawing.Point(17, 91)
        Me.btn_dataguru.Name = "btn_dataguru"
        Me.btn_dataguru.Size = New System.Drawing.Size(176, 39)
        Me.btn_dataguru.TabIndex = 3
        Me.btn_dataguru.Text = "Manajemen Data Guru"
        Me.btn_dataguru.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MENU" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ADMINISTRATOR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btn_datamapel
        '
        Me.btn_datamapel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_datamapel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_datamapel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_datamapel.Location = New System.Drawing.Point(17, 257)
        Me.btn_datamapel.Name = "btn_datamapel"
        Me.btn_datamapel.Size = New System.Drawing.Size(176, 48)
        Me.btn_datamapel.TabIndex = 3
        Me.btn_datamapel.Text = "Manajemen Data Mapel"
        Me.btn_datamapel.UseVisualStyleBackColor = True
        '
        'DataMapel1
        '
        Me.DataMapel1.Location = New System.Drawing.Point(214, 0)
        Me.DataMapel1.Name = "DataMapel1"
        Me.DataMapel1.Size = New System.Drawing.Size(764, 561)
        Me.DataMapel1.TabIndex = 5
        '
        'DataSiswa1
        '
        Me.DataSiswa1.Location = New System.Drawing.Point(214, 0)
        Me.DataSiswa1.Name = "DataSiswa1"
        Me.DataSiswa1.Size = New System.Drawing.Size(764, 561)
        Me.DataSiswa1.TabIndex = 4
        '
        'DataKelas1
        '
        Me.DataKelas1.Location = New System.Drawing.Point(214, 0)
        Me.DataKelas1.Name = "DataKelas1"
        Me.DataKelas1.Size = New System.Drawing.Size(764, 561)
        Me.DataKelas1.TabIndex = 3
        '
        'DataJurusan1
        '
        Me.DataJurusan1.Location = New System.Drawing.Point(214, 0)
        Me.DataJurusan1.Name = "DataJurusan1"
        Me.DataJurusan1.Size = New System.Drawing.Size(764, 561)
        Me.DataJurusan1.TabIndex = 2
        '
        'DataGuru1
        '
        Me.DataGuru1.Location = New System.Drawing.Point(214, 0)
        Me.DataGuru1.Name = "DataGuru1"
        Me.DataGuru1.Size = New System.Drawing.Size(764, 561)
        Me.DataGuru1.TabIndex = 1
        '
        'MenuAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 561)
        Me.Controls.Add(Me.DataMapel1)
        Me.Controls.Add(Me.DataSiswa1)
        Me.Controls.Add(Me.DataKelas1)
        Me.Controls.Add(Me.DataJurusan1)
        Me.Controls.Add(Me.DataGuru1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MenuAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SMKBISA!"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_logout As Button
    Friend WithEvents btn_datajurusan As Button
    Friend WithEvents btn_datakelas As Button
    Friend WithEvents btn_datasiswa As Button
    Friend WithEvents btn_dataguru As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGuru1 As DataGuru
    Friend WithEvents DataJurusan1 As DataJurusan
    Friend WithEvents DataKelas1 As DataKelas
    Friend WithEvents DataSiswa1 As DataSiswa
    Friend WithEvents btn_datamapel As Button
    Friend WithEvents DataMapel1 As DataMapel
End Class
