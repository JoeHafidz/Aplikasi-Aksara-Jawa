Public Class frm_Menu

    Private Sub btn_aksara_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aksara.Click
        frm_AksaraJawa.Show()
    End Sub

    Private Sub frm_Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_kosa_kata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_kosa_kata.Click
        frm_kosa_kata.Show()
    End Sub

    Private Sub btn_paribasan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_paribasan.Click
        frm_paribasan.Show()
    End Sub

    Private Sub btn_parikan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_parikan.Click
        frm_parikan.Show()
    End Sub

    Private Sub btn_latihan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_latihan.Click
        frm_latihan.Show()
    End Sub
End Class