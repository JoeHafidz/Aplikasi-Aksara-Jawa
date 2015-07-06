Public Class frm_terjemah

    Private Sub frm_terjemah_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frm_Menu.Show()
    End Sub

    Private Sub txt_input_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_input.TextChanged
        lbl_hasil.Text = txt_input.Text
    End Sub

End Class