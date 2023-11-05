Imports System.Data.SqlClient
Public Class DataKelas

    Sub bersihdata()
        txt_idkelas.Text = ""
        txt_namakelas.Text = ""
    End Sub

    Sub tampildata()
        konekdb()
        Dim da As New SqlDataAdapter("SELECT * FROM kelas", konek)
        Dim ds As New DataSet
        ds.Clear()
        da.Fill(ds, "kelas")
        DataGridView1.DataSource = ds.Tables("kelas")
    End Sub

    Private Sub DataKelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildata()
    End Sub

    Private Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        konekdb()
        Dim cmd As New SqlCommand("SELECT * FROM kelas WHERE ID = '" + txt_idkelas.Text + "'", konek)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            txt_idkelas.Text = rd.Item(0)
            txt_namakelas.Text = rd.Item(1)
        Else
            MessageBox.Show("Data tidak ditemukan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Dim pesan, sql As String
        If txt_idkelas.Text = "" Or txt_namakelas.Text = "" Then
            MessageBox.Show("Data belum lengkap!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txt_idkelas.Focus()
        Else
            pesan = MessageBox.Show("Apakah Anda yakin ingin menyimpan data ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If pesan = DialogResult.No Then
                Exit Sub
            End If
            sql = "INSERT INTO kelas VALUES('" + txt_idkelas.Text + "','" + txt_namakelas.Text + "')"
            jalankansql(sql)
            MessageBox.Show("Data berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampildata()
            bersihdata()
        End If
    End Sub

    Private Sub btn_ubah_Click(sender As Object, e As EventArgs) Handles btn_ubah.Click
        Dim pesan, sql As String
        If txt_idkelas.Text = "" Or txt_namakelas.Text = "" Then
            MessageBox.Show("Data belum lengkap, silahkan cari data yang ingin diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txt_idkelas.Focus()
        Else
            pesan = MessageBox.Show("Apakah Anda yakin ingin mengubah data ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If pesan = DialogResult.No Then
                Exit Sub
            End If
            sql = "UPDATE kelas SET NamaKelas = '" + txt_namakelas.Text + "' WHERE ID = '" + txt_idkelas.Text + "'"
            jalankansql(sql)
            MessageBox.Show("Data berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampildata()
            bersihdata()
        End If
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Dim pesan, sql As String
        If txt_idkelas.Text = "" Or txt_namakelas.Text = "" Then
            MessageBox.Show("Data belum lengkap, silahkan cari data yang ingin dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txt_idkelas.Focus()
        Else
            pesan = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If pesan = DialogResult.No Then
                Exit Sub
            End If
            sql = "DELETE FROM kelas WHERE ID LIKE '" + txt_idkelas.Text + "'"
            jalankansql(sql)
            MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampildata()
            bersihdata()
        End If
    End Sub
End Class
