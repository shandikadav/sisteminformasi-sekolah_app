Imports System.Data.SqlClient
Public Class DataGuru
    Dim gender As String

    Sub bersihdata()
        txt_idguru.Text = ""
        txt_namaguru.Text = ""
        txt_nip.Text = ""
        txt_alamat.Text = ""
        rb_laki.Checked = False
        rb_perempuan.Checked = False
    End Sub

    Sub tampildata()
        konekdb()
        Dim da As New SqlDataAdapter("SELECT * FROM guru", konek)
        Dim ds As New DataSet
        ds.Clear()
        da.Fill(ds, "guru")
        DataGridView1.DataSource = ds.Tables("guru")
    End Sub

    Private Sub DataGuru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildata()
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Dim pesan, sql As String
        If txt_idguru.Text = "" Or txt_nip.Text = "" Or txt_namaguru.Text = "" Or txt_alamat.Text = "" Or rb_laki.Checked = False Then
            MessageBox.Show("Data belum lengkap!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txt_idguru.Focus()
        Else
            pesan = MessageBox.Show("Apakah Anda yakin ingin menyimpan data ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If pesan = DialogResult.No Then
                Exit Sub
            End If
            sql = "INSERT INTO guru VALUES ('" + txt_idguru.Text + "','" + txt_nip.Text + "','" + txt_namaguru.Text + "','" + txt_alamat.Text + "','" + dtp_tanggallahir.Value.ToString + "','" + gender + "')"
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

    Private Sub btn_ubah_Click(sender As Object, e As EventArgs) Handles btn_ubah.Click
        Dim pesan, sql As String
        If txt_idguru.Text = "" Or txt_nip.Text = "" Or txt_namaguru.Text = "" Or txt_alamat.Text = "" Then
            MessageBox.Show("Data belum lengkap, silahkan cari data terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txt_idguru.Focus()
        Else
            pesan = MessageBox.Show("Apakah Anda yakin ingin mengubah data ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If pesan = DialogResult.No Then
                Exit Sub
            End If
            sql = "UPDATE guru SET NIP = '" + txt_nip.Text + "', NamaGuru = '" + txt_namaguru.Text + "', Alamat = '" + txt_alamat.Text + "', TTL = '" + dtp_tanggallahir.Value.ToString + "', JenisKelamin = '" + gender + "' WHERE ID = '" + txt_idguru.Text + "'"
            jalankansql(sql)
            MessageBox.Show("Data berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampildata()
            bersihdata()
        End If
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Dim pesan, sql As String
        If txt_idguru.Text = "" Or txt_nip.Text = "" Or txt_namaguru.Text = "" Or txt_alamat.Text = "" Or rb_laki.Checked = False Then
            MessageBox.Show("silahkan cari data yang ingin dihapus terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txt_idguru.Focus()
        Else
            pesan = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If pesan = DialogResult.No Then
                Exit Sub
            End If
            sql = "DELETE FROM guru WHERE ID LIKE '" + txt_idguru.Text + "'"
            jalankansql(sql)
            MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampildata()
            bersihdata()
        End If
    End Sub

    Private Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        konekdb()
        Dim cmd As New SqlCommand("SELECT * FROM guru WHERE ID = '" + txt_idguru.Text + "'", konek)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            txt_idguru.Text = rd.Item(0)
            txt_nip.Text = rd.Item(1)
            txt_namaguru.Text = rd.Item(2)
            txt_alamat.Text = rd.Item(3)
        Else
            MessageBox.Show("Data tidak ditemukan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class