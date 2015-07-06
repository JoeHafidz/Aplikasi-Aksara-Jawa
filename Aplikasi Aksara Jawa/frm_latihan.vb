Public Class frm_latihan

    Private Sub frm_latihan_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frm_Menu.Show()
    End Sub

    Private Sub btn_check_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_check.Click
        Dim soal1 As String = "bathara"
        Dim soal2 As String = "suku jawa"
        Dim soal3 As String = "kali mati"
        Dim soal4 As String = "cemara"
        Dim soal5 As String = "buku telu"
        Dim nilai1 As Integer = 0
        Dim nilai2 As Integer = 0
        Dim nilai3 As Integer = 0
        Dim nilai4 As Integer = 0
        Dim nilai5 As Integer = 0
        Dim totalNilai As Integer = 0

        If txt_soal1.Text = soal1 Then
            lbl_soal1.Text = "Benar"
            nilai1 = 1
        Else
            lbl_soal1.Text = "Salah"
            nilai1 = 0
        End If
        If txt_soal2.Text = soal2 Then
            lbl_soal2.Text = "Benar"
            nilai2 = 1
        Else
            lbl_soal2.Text = "Salah"
            nilai2 = 0
        End If
        If txt_soal3.Text = soal3 Then
            lbl_soal3.Text = "Benar"
            nilai3 = 1
        Else
            lbl_soal3.Text = "Salah"
            nilai3 = 0
        End If
        If txt_soal4.Text = soal4 Then
            lbl_soal4.Text = "Benar"
            nilai4 = 1
        Else
            lbl_soal4.Text = "Salah"
            nilai4 = 0
        End If
        If txt_soal5.Text = soal5 Then
            lbl_soal5.Text = "Benar"
            nilai5 = 1
        Else
            lbl_soal5.Text = "Salah"
            nilai5 = 0
        End If

        totalNilai = (nilai1 + nilai2 + nilai3 + nilai4 + nilai5) * 2
        lbl_nilai.Text = "Nilai Anda : " + totalNilai.ToString()
    End Sub

End Class