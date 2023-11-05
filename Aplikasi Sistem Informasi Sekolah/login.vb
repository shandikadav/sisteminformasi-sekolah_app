Imports System.Data.SqlClient
Public Class login
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        konekdb()
        Dim cmd As New SqlCommand("SELECT * FROM akun WHERE Username = '" + txt_uname.Text + "' AND Password = '" + txt_pass.Text + "'", konek)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            If rd.Item(2).ToString = "administrator" Then
                MessageBox.Show("Login Administrator berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MenuAdmin.Show()
                Me.Hide()
            End If
        Else
            MessageBox.Show("Login gagal, silahkan periksa Username dan Password!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_uname.Text = ""
            txt_pass.Text = ""
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txt_pass.PasswordChar = ""
        Else
            txt_pass.PasswordChar = "*"
        End If
    End Sub

    Private Sub btn_kembali_Click(sender As Object, e As EventArgs) Handles btn_kembali.Click
        halaman_utama.Show()
        Me.Hide()
        txt_uname.Text = ""
        txt_pass.Text = ""
    End Sub
End Class