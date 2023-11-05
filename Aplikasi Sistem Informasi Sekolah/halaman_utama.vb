Public Class halaman_utama
    Private Sub ll_signin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ll_signin.LinkClicked
        login.Show()
        Me.Hide()
    End Sub

    Private Sub btn_tentangsekolah_Click(sender As Object, e As EventArgs) Handles btn_tentangsekolah.Click
        Tentang.Show()
        Me.Hide()
    End Sub
End Class
