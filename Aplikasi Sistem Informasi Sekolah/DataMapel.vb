Imports System.Data.SqlClient
Public Class DataMapel

    Sub tampildatacmb()
        konekdb()
        Dim cmd As New SqlCommand("SELECT NamaGuru FROM guru", konek)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        If rd.HasRows = True Then
            Do While rd.Read
                cmb_guru.Items.Add(rd.Item("NamaGuru"))
            Loop
        End If
    End Sub

    Sub bersihkandata()
        txt_idmapel.Text = ""
        cmb_guru.Text = ""
        txt_mapel.Text = ""
        txt_idguru.Text = ""
    End Sub

    Sub tampildata()
        konekdb()
        Dim da As New SqlDataAdapter("SELECT mapel.ID,guru.NamaGuru as GuruPengajar, NamaMapel as MataPelajaran FROM mapel,guru WHERE guru.ID = GuruID", konek)
        Dim ds As New DataSet
        ds.Clear()
        da.Fill(ds, "mapel")
        DataGridView1.DataSource = ds.Tables("mapel")
    End Sub
    Private Sub DataMapel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildata()
        tampildatacmb()
        Label5.Visible = False
        txt_idguru.Visible = False
    End Sub

    Private Sub cmb_guru_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_guru.SelectedIndexChanged
        konekdb()
        Dim cmd As New SqlCommand("SELECT * FROM guru WHERE NamaGuru = '" + cmb_guru.Text + "'", konek)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            txt_idguru.Text = rd.Item(0)
        End If
    End Sub

    Private Sub txt_idguru_TextChanged(sender As Object, e As EventArgs) Handles txt_idguru.TextChanged
        konekdb()
        Dim cmd As New SqlCommand("SELECT * FROM guru WHERE ID = '" + txt_idguru.Text + "'", konek)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            cmb_guru.Text = rd.Item(2)
        End If
    End Sub

    Private Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        konekdb()
        Dim cmd As New SqlCommand("SELECT * FROM mapel WHERE ID = '" + txt_idmapel.Text + "'", konek)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            txt_idmapel.Text = rd.Item(0)
            txt_idguru.Text = rd.Item(1)
            txt_mapel.Text = rd.Item(2)
        End If
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Dim pesan, sql As String
        If txt_idmapel.Text = "" Or cmb_guru.Text = "" Or txt_mapel.Text = "" Then
            MessageBox.Show("Data belum lengkap!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txt_idmapel.Focus()
        Else
            pesan = MessageBox.Show("Apakah Anda yakin ingin menyimpan data ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If pesan = DialogResult.No Then
                Exit Sub
            End If
            sql = "INSERT INTO mapel VALUES ('" + txt_idmapel.Text + "','" + txt_idguru.Text + "','" + txt_mapel.Text + "')"
            jalankansql(sql)
            MessageBox.Show("Data berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampildata()
            bersihkandata()
        End If
    End Sub

    Private Sub btn_ubah_Click(sender As Object, e As EventArgs) Handles btn_ubah.Click
        Dim pesan, sql As String
        If txt_idmapel.Text = "" Or cmb_guru.Text = "" Or txt_mapel.Text = "" Then
            MessageBox.Show("Data belum lengkap!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txt_idmapel.Focus()
        Else
            pesan = MessageBox.Show("Apakah Anda yakin ingin mengubah data ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If pesan = DialogResult.No Then
                Exit Sub
            End If
            sql = "UPDATE mapel SET GuruID = '" + txt_idguru.Text + "', NamaMapel = '" + txt_mapel.Text + "' WHERE ID = '" + txt_idmapel.Text + "'"
            jalankansql(sql)
            MessageBox.Show("Data berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampildata()
            bersihkandata()
        End If
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Dim pesan, sql As String
        If txt_idmapel.Text = "" Or cmb_guru.Text = "" Or txt_mapel.Text = "" Then
            MessageBox.Show("Data belum lengkap!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txt_idmapel.Focus()
        Else
            pesan = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If pesan = DialogResult.No Then
                Exit Sub
            End If
            sql = "DELETE FROM mapel WHERE ID LIKE '" + txt_idmapel.Text + "'"
            jalankansql(sql)
            MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampildata()
            bersihkandata()
        End If
    End Sub
End Class