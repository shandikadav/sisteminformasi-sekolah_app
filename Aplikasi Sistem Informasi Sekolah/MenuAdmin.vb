Public Class MenuAdmin
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub MenuAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGuru1.Visible = False
        DataJurusan1.Visible = False
        DataKelas1.Visible = False
        DataMapel1.Visible = False
        DataSiswa1.Visible = False
    End Sub

    Private Sub btn_dataguru_Click(sender As Object, e As EventArgs) Handles btn_dataguru.Click
        DataGuru1.Visible = True
        DataJurusan1.Visible = False
        DataKelas1.Visible = False
        DataMapel1.Visible = False
        DataSiswa1.Visible = False
    End Sub

    Private Sub btn_datasiswa_Click(sender As Object, e As EventArgs) Handles btn_datasiswa.Click
        DataSiswa1.Visible = True
        DataGuru1.Visible = False
        DataJurusan1.Visible = False
        DataKelas1.Visible = False
        DataMapel1.Visible = False
    End Sub

    Private Sub btn_datakelas_Click(sender As Object, e As EventArgs) Handles btn_datakelas.Click
        DataKelas1.Visible = True
        DataGuru1.Visible = False
        DataJurusan1.Visible = False
        DataMapel1.Visible = False
        DataSiswa1.Visible = False
    End Sub

    Private Sub btn_datamapel_Click(sender As Object, e As EventArgs) Handles btn_datamapel.Click
        DataMapel1.Visible = True
        DataGuru1.Visible = False
        DataJurusan1.Visible = False
        DataKelas1.Visible = False
        DataSiswa1.Visible = False
    End Sub

    Private Sub btn_datajurusan_Click(sender As Object, e As EventArgs) Handles btn_datajurusan.Click
        DataJurusan1.Visible = True
        DataGuru1.Visible = False
        DataKelas1.Visible = False
        DataMapel1.Visible = False
        DataSiswa1.Visible = False
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        DataGuru1.Visible = False
        DataJurusan1.Visible = False
        DataKelas1.Visible = False
        DataMapel1.Visible = False
        DataSiswa1.Visible = False
        login.txt_uname.Text = ""
        login.txt_pass.Text = ""
        login.Show()
        Me.Hide()
    End Sub
End Class