<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class halaman_utama
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_tentangsekolah = New System.Windows.Forms.Button()
        Me.btn_informasi = New System.Windows.Forms.Button()
        Me.ll_signin = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(158, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(380, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "APLIKASI SISTEM INFORMASI" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(224, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "SMK MUHAMMADIYAH 3 METRO"
        '
        'btn_tentangsekolah
        '
        Me.btn_tentangsekolah.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.btn_tentangsekolah.FlatAppearance.BorderSize = 0
        Me.btn_tentangsekolah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tentangsekolah.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_tentangsekolah.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_tentangsekolah.Image = Global.Aplikasi_Sistem_Informasi_Sekolah.My.Resources.Resources.icons8_information_64
        Me.btn_tentangsekolah.Location = New System.Drawing.Point(376, 150)
        Me.btn_tentangsekolah.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_tentangsekolah.Name = "btn_tentangsekolah"
        Me.btn_tentangsekolah.Size = New System.Drawing.Size(244, 108)
        Me.btn_tentangsekolah.TabIndex = 2
        Me.btn_tentangsekolah.Text = "TENTANG SEKOLAH"
        Me.btn_tentangsekolah.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_tentangsekolah.UseVisualStyleBackColor = False
        '
        'btn_informasi
        '
        Me.btn_informasi.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.btn_informasi.FlatAppearance.BorderSize = 0
        Me.btn_informasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_informasi.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_informasi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_informasi.Image = Global.Aplikasi_Sistem_Informasi_Sekolah.My.Resources.Resources.icons8_system_information_64
        Me.btn_informasi.Location = New System.Drawing.Point(54, 150)
        Me.btn_informasi.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_informasi.Name = "btn_informasi"
        Me.btn_informasi.Size = New System.Drawing.Size(244, 108)
        Me.btn_informasi.TabIndex = 2
        Me.btn_informasi.Text = "LIHAT INFORMASI DATA SEKOLAH" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_informasi.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_informasi.UseVisualStyleBackColor = False
        '
        'll_signin
        '
        Me.ll_signin.AutoSize = True
        Me.ll_signin.Location = New System.Drawing.Point(551, 323)
        Me.ll_signin.Name = "ll_signin"
        Me.ll_signin.Size = New System.Drawing.Size(120, 15)
        Me.ll_signin.TabIndex = 5
        Me.ll_signin.TabStop = True
        Me.ll_signin.Text = "Sign in Application"
        '
        'halaman_utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(677, 347)
        Me.Controls.Add(Me.ll_signin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_tentangsekolah)
        Me.Controls.Add(Me.btn_informasi)
        Me.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "halaman_utama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SMKBISA!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_informasi As Button
    Friend WithEvents btn_tentangsekolah As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ll_signin As LinkLabel
End Class
