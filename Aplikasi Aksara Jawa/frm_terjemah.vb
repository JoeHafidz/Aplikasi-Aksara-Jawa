Public Class frm_terjemah

    Private Sub frm_terjemah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub txt_input_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_input.TextChanged
        lbl_hasil.Text = txt_input.Text
    End Sub
End Class