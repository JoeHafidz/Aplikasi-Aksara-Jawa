Public Class frm_latihan

    
    Private Sub btn_check_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_check.Click

        If txt_jawab.Text = "Jaran" Or txt_jawab.Text = "jaran" Then
            lbl_Status.Text = "Benar"
        Else
            lbl_Status.Text = "Salah"
        End If

    End Sub
End Class