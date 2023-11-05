Imports System.Data.SqlClient
Public Class DataSiswa
    Dim gender As String

    Sub tampilcmbjurusan()
        konekdb()
        Dim cmd As New SqlCommand("SELECT NamaJurusan FROM jurusan", konek)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        If rd.HasRows = True Then
            Do While rd.Read
                cmb_jurusan.Items.Add(rd.Item("NamaJurusan"))
            Loop
        End If
    End Sub

    Sub tampilcmbkelas()
        konekdb()
        Dim cmd As New SqlCommand("SELECT NamaKelas FROM kelas", konek)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        If rd.HasRows = True Then
            Do While rd.Read
                cmb_kelas.Items.Add(rd.Item("NamaKelas"))
            Loop
        End If
    End Sub

    Sub bersihdata()
        txt_alamat.Text = ""
        txt_idjurusan.Text = ""
        txt_idkelas.Text = ""
        txt_idsiswa.Text = ""
        txt_nis.Text = ""
        txt_namasiswa.Text = ""
        cmb_jurusan.Text = ""
        cmb_kelas.Text = ""
        rb_laki.Checked = False
        rb_perempuan.Checked = False
    End Sub

    Sub tampildata()
        konekdb()
        Dim da As New SqlDataAdapter("SELECT siswa.ID,NIS,NamaSiswa,kelas.NamaKelas as Kelas,jurusan.NamaJurusan as Jurusan, Alamat,TTL,JenisKelamin FROM siswa,kelas,jurusan WHERE kelas.ID = siswa.KelasID AND jurusan.ID = siswa.JurusanID", konek)
        Dim ds As New DataSet
        ds.Clear()
        da.Fill(ds, "siswa")
        DataGridView1.DataSource = ds.Tables("siswa")
    End Sub

    Private Sub DataSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildata()
        tampilcmbkelas()
        tampilcmbjurusan()
        txt_idkelas.Visible = False
        txt_idjurusan.Visible = False
        Label11.Visible = False
        Label10.Visible = False
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Dim pesan, sql As String
        If txt_alamat.Text = "" Or txt_namasiswa.Text = "" Or txt_idsiswa.Text = "" Or txt_nis.Text = "" Or cmb_jurusan.Text = "" Or cmb_kelas.Text = "" Then
            MessageBox.Show("Data belum lengkap!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txt_idsiswa.Focus()
        Else
            pesan = MessageBox.Show("Apakah Anda yakin ingin menyimpan data ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If pesan = DialogResult.No Then
                Exit Sub
            End If
            sql = "INSERT INTO siswa VALUES ('" + txt_idkelas.Text + "','" + txt_nis.Text + "','" + txt_namasiswa.Text + "','" + txt_idkelas.Text + "','" + txt_idjurusan.Text + "','" + txt_alamat.Text + "','" + dtp_tanggallahir.Value.ToString + "','" + gender + "')"
            jalankansql(sql)
            MessageBox.Show("Data berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampildata()
            bersihdata()
        End If
    End Sub

    Private Sub rb_laki_CheckedChanged(sender As Object, e As EventArgs) Handles rb_laki.CheckedChanged
        gender = "Laki-laki"
    End Sub

    Private Sub rb_perempuan_CheckedChanged(sender As Object, e As EventArgs) Handles rb_perempuan.CheckedChanged
        gender = "Perempuan"
    End Sub

    Private Sub cmb_kelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_kelas.SelectedIndexChanged
        konekdb()
        Dim cmd As New SqlCommand("SELECT * FROM kelas WHERE NamaKelas = '" + cmb_kelas.Text + "'", konek)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            txt_idkelas.Text = rd.Item(0)
        End If
    End Sub

    Private Sub cmb_jurusan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_jurusan.SelectedIndexChanged
        konekdb()
        Dim cmd As New SqlCommand("SELECT * FROM jurusan WHERE NamaJurusan = '" + cmb_jurusan.Text + "'", konek)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            txt_idjurusan.Text = rd.Item(0)
        End If
    End Sub

    Private Sub txt_idkelas_TextChanged(sender As Object, e As EventArgs) Handles txt_idkelas.TextChanged
        konekdb()
        Dim cmd As New SqlCommand("SELECT * FROM kelas WHERE ID = '" + txt_idkelas.Text + "'", konek)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            cmb_kelas.Text = rd.Item(1)
        End If
    End Sub

    Private Sub txt_idjurusan_TextChanged(sender As Object, e As EventArgs) Handles txt_idjurusan.TextChanged
        konekdb()
        Dim cmd As New SqlCommand("SELECT * FROM jurusan WHERE ID = '" + txt_idjurusan.Text + "'", konek)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            cmb_jurusan.Text = rd.Item(1)
        End If
    End Sub

    Private Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        konekdb()
        Dim cmd As New SqlCommand("SELECT * FROM siswa WHERE ID = '" + txt_idsiswa.Text + "'", konek)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            txt_idkelas.Text = rd.Item(0)
            txt_nis.Text = rd.Item(1)
            txt_namasiswa.Text = rd.Item(2)
            txt_idkelas.Text = rd.Item(3)
            txt_idjurusan.Text = rd.Item(4)
            txt_alamat.Text = rd.Item(5)
        End If
    End Sub

    Private Sub btn_ubah_Click(sender As Object, e As EventArgs) Handles btn_ubah.Click
        Dim pesan, sql As String
        If txt_alamat.Text = "" Or txt_namasiswa.Text = "" Or txt_idsiswa.Text = "" Or txt_nis.Text = "" Or cmb_jurusan.Text = "" Or cmb_kelas.Text = "" Then
            MessageBox.Show("Data belum lengkap, silahkan cari data yang ingin diubah terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txt_idsiswa.Focus()
        Else
            pesan = MessageBox.Show("Apakah Anda yakin ingin mengubah data ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If pesan = DialogResult.No Then
                Exit Sub
            End If
            sql = "UPDATE siswa SET NIS = '" + txt_nis.Text + "', NamaSiswa = '" + txt_namasiswa.Text + "', KelasID = '" + txt_idkelas.Text + "', JurusanID = '" + txt_idjurusan.Text + "' , Alamat = '" + txt_alamat.Text + "', TTL = '" + dtp_tanggallahir.Value.ToString + "', JenisKelamin = '" + gender + "' WHERE ID = '" + txt_idsiswa.Text + "'"
            jalankansql(sql)
            MessageBox.Show("Data berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampildata()
            bersihdata()
        End If
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Dim pesan, sql As String
        If txt_alamat.Text = "" Or txt_namasiswa.Text = "" Or txt_idsiswa.Text = "" Or txt_nis.Text = "" Or cmb_jurusan.Text = "" Or cmb_kelas.Text = "" Then
            MessageBox.Show("Data belum lengkap, silahkan cari data yang ingin dihapus terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txt_idsiswa.Focus()
        Else
            pesan = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If pesan = DialogResult.No Then
                Exit Sub
            End If
            sql = "DELETE FROM siswa WHERE ID LIKE '" + txt_idsiswa.Text + "'"
            jalankansql(sql)
            MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampildata()
            bersihdata()
        End If
    End Sub
End Class