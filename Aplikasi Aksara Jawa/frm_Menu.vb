Public Class frm_Menu

    Private Sub btn_aksara_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aksara.Click
        Me.Close()
        frm_AksaraJawa.Show()
    End Sub

    Private Sub btn_kosa_kata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_kosa_kata.Click
        Me.Close()
        frm_kosa_kata.Show()
    End Sub

    Private Sub btn_paribasan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_paribasan.Click
        Me.Close()
        frm_paribasan.Show()
    End Sub

    Private Sub btn_parikan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_parikan.Click
        Me.Close()
        frm_parikan.Show()
    End Sub

    Private Sub btn_latihan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_latihan.Click
        Me.Close()
        frm_latihan.Show()
    End Sub

    Private Sub btn_terjemah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_terjemah.Click
        frm_terjemah.Show()
        Me.Hide()
    End Sub

End Class