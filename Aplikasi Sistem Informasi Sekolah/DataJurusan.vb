Imports System.Data.SqlClient
Public Class DataJurusan

    Sub bersihdata()
        txt_idjurusan.Text = ""
        txt_namajurusan.Text = ""
    End Sub

    Sub tampildata()
        konekdb()
        Dim da As New SqlDataAdapter("SELECT * FROM jurusan", konek)
        Dim ds As New DataSet
        ds.Clear()
        da.Fill(ds, "jurusan")
        DataGridView1.DataSource = ds.Tables("jurusan")
    End Sub

    Private Sub DataJurusan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildata()
    End Sub

    Private Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        konekdb()
        Dim cmd As New SqlCommand("SELECT * FROM jurusan WHERE ID = '" + txt_idjurusan.Text + "'", konek)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            txt_idjurusan.Text = rd.Item(0)
            txt_namajurusan.Text = rd.Item(1)
        Else
            MessageBox.Show("Data tidak ditemukan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Dim pesan, sql As String
        If txt_idjurusan.Text = "" Or txt_namajurusan.Text = "" Then
            MessageBox.Show("Data belum lengkap!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txt_idjurusan.Focus()
        Else
            pesan = MessageBox.Show("Apakah Anda yakin ingin menyimpan data ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If pesan = DialogResult.No Then
                Exit Sub
            End If
            sql = "INSERT INTO jurusan VALUES('" + txt_idjurusan.Text + "','" + txt_namajurusan.Text + "')"
            jalankansql(sql)
            MessageBox.Show("Data berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampildata()
            bersihdata()
        End If
    End Sub

    Private Sub btn_ubah_Click(sender As Object, e As EventArgs) Handles btn_ubah.Click
        Dim pesan, sql As String
        If txt_idjurusan.Text = "" Or txt_namajurusan.Text = "" Then
            MessageBox.Show("Data belum lengkap, silahkan cari data yang ingin diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txt_idjurusan.Focus()
        Else
            pesan = MessageBox.Show("Apakah Anda yakin ingin mengubah data ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If pesan = DialogResult.No Then
                Exit Sub
            End If
            sql = "UPDATE jurusan SET NamaJurusan = '" + txt_namajurusan.Text + "' WHERE ID = '" + txt_idjurusan.Text + "'"
            jalankansql(sql)
            MessageBox.Show("Data berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampildata()
            bersihdata()
        End If
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Dim pesan, sql As String
        If txt_idjurusan.Text = "" Or txt_namajurusan.Text = "" Then
            MessageBox.Show("Data belum lengkap, silahkan cari data yang ingin dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txt_idjurusan.Focus()
        Else
            pesan = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If pesan = DialogResult.No Then
                Exit Sub
            End If
            sql = "DELETE FROM jurusan WHERE ID LIKE '" + txt_idjurusan.Text + "'"
            jalankansql(sql)
            MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampildata()
            bersihdata()
        End If
    End Sub
End Class
